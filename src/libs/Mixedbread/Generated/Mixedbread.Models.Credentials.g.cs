#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// How Mixedbread authenticates against the bucket. `assume_role` is the recommended default for AWS; `access_key` is for S3-compatible providers with a custom endpoint.
    /// </summary>
    public readonly partial struct Credentials : global::System.IEquatable<Credentials>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType? Type { get; }

        /// <summary>
        /// Cross-account IAM role the platform assumes via STS (recommended for AWS).<br/>
        /// Nothing secret is stored: the role ARN and the server-generated external id<br/>
        /// are plain metadata, and access is granted/revoked entirely through the<br/>
        /// role's trust policy in the customer's account.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.BucketAssumeRoleCredentials? AssumeRole { get; init; }
#else
        public global::Mixedbread.BucketAssumeRoleCredentials? AssumeRole { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssumeRole))]
#endif
        public bool IsAssumeRole => AssumeRole != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAssumeRole(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.BucketAssumeRoleCredentials? value)
        {
            value = AssumeRole;
            return IsAssumeRole;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.BucketAssumeRoleCredentials PickAssumeRole() => IsAssumeRole
            ? AssumeRole!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AssumeRole' but the value was {ToString()}.");

        /// <summary>
        /// AWS-style access key credentials for a customer bucket (write-only, never returned).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.BucketAccessKeyCredentials? AccessKey { get; init; }
#else
        public global::Mixedbread.BucketAccessKeyCredentials? AccessKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AccessKey))]
#endif
        public bool IsAccessKey => AccessKey != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAccessKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.BucketAccessKeyCredentials? value)
        {
            value = AccessKey;
            return IsAccessKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.BucketAccessKeyCredentials PickAccessKey() => IsAccessKey
            ? AccessKey!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AccessKey' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Credentials(global::Mixedbread.BucketAssumeRoleCredentials value) => new Credentials((global::Mixedbread.BucketAssumeRoleCredentials?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.BucketAssumeRoleCredentials?(Credentials @this) => @this.AssumeRole;

        /// <summary>
        /// 
        /// </summary>
        public Credentials(global::Mixedbread.BucketAssumeRoleCredentials? value)
        {
            AssumeRole = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Credentials FromAssumeRole(global::Mixedbread.BucketAssumeRoleCredentials? value) => new Credentials(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Credentials(global::Mixedbread.BucketAccessKeyCredentials value) => new Credentials((global::Mixedbread.BucketAccessKeyCredentials?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.BucketAccessKeyCredentials?(Credentials @this) => @this.AccessKey;

        /// <summary>
        /// 
        /// </summary>
        public Credentials(global::Mixedbread.BucketAccessKeyCredentials? value)
        {
            AccessKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Credentials FromAccessKey(global::Mixedbread.BucketAccessKeyCredentials? value) => new Credentials(value);

        /// <summary>
        /// 
        /// </summary>
        public Credentials(
            global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType? type,
            global::Mixedbread.BucketAssumeRoleCredentials? assumeRole,
            global::Mixedbread.BucketAccessKeyCredentials? accessKey
            )
        {
            Type = type;

            AssumeRole = assumeRole;
            AccessKey = accessKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AccessKey as object ??
            AssumeRole as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AssumeRole?.ToString() ??
            AccessKey?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAssumeRole && !IsAccessKey || !IsAssumeRole && IsAccessKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mixedbread.BucketAssumeRoleCredentials, TResult>? assumeRole = null,
            global::System.Func<global::Mixedbread.BucketAccessKeyCredentials, TResult>? accessKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssumeRole && assumeRole != null)
            {
                return assumeRole(AssumeRole!);
            }
            else if (IsAccessKey && accessKey != null)
            {
                return accessKey(AccessKey!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mixedbread.BucketAssumeRoleCredentials>? assumeRole = null,

            global::System.Action<global::Mixedbread.BucketAccessKeyCredentials>? accessKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssumeRole)
            {
                assumeRole?.Invoke(AssumeRole!);
            }
            else if (IsAccessKey)
            {
                accessKey?.Invoke(AccessKey!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Mixedbread.BucketAssumeRoleCredentials>? assumeRole = null,
            global::System.Action<global::Mixedbread.BucketAccessKeyCredentials>? accessKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssumeRole)
            {
                assumeRole?.Invoke(AssumeRole!);
            }
            else if (IsAccessKey)
            {
                accessKey?.Invoke(AccessKey!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AssumeRole,
                typeof(global::Mixedbread.BucketAssumeRoleCredentials),
                AccessKey,
                typeof(global::Mixedbread.BucketAccessKeyCredentials),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Credentials other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.BucketAssumeRoleCredentials?>.Default.Equals(AssumeRole, other.AssumeRole) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.BucketAccessKeyCredentials?>.Default.Equals(AccessKey, other.AccessKey) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Credentials obj1, Credentials obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Credentials>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Credentials obj1, Credentials obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Credentials o && Equals(o);
        }
    }
}
