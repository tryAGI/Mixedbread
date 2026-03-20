#!/usr/bin/env bash
set -euo pipefail

# Mixedbread spec is hosted on Stainless GCS with hash-based URLs that change each update.
# We dynamically resolve the latest URL from mixedbread-ai/mixedbread-python/.stats.yml.
readonly stats_url="https://raw.githubusercontent.com/mixedbread-ai/mixedbread-python/main/.stats.yml"

echo "Fetching latest spec URL from .stats.yml..."
openapi_url=$(curl --fail --silent --show-error --location "$stats_url" | grep 'openapi_spec_url:' | sed 's/openapi_spec_url: *//')

if [ -z "$openapi_url" ]; then
  echo "ERROR: Could not extract openapi_spec_url from .stats.yml"
  exit 1
fi

echo "Spec URL: $openapi_url"

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.yaml

# Add top-level security array (spec defines securitySchemes but not top-level security)
# The spec is JSON format despite the .yaml extension
python3 -c "
import json
with open('openapi.yaml') as f:
    data = json.load(f)
data['security'] = [{'ApiKeyAuth': []}]
with open('openapi.yaml', 'w') as f:
    json.dump(data, f, indent=2)
"

autosdk generate openapi.yaml \
  --namespace Mixedbread \
  --clientClassName MixedbreadClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
