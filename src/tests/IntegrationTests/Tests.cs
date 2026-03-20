namespace Mixedbread.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MixedbreadClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MIXEDBREAD_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("MIXEDBREAD_API_KEY environment variable is not found.");

        var client = new MixedbreadClient(apiKey);
        
        return client;
    }
}
