namespace ApexSharpApi.ApexApi // quick fix
{
}

namespace Apex.ConnectApi
{
    public class ChatterGroupSummaryPage { }

    public class ConnectContentHubItemType { }
}

namespace Apex.Auth
{
    public class AuthConfig { }

    public class AuthConfigProviders { }

    public class AuthProvider { }

    public class SamlSsoConfig { }

    public class SessionLevel { }

    public class VerificationPolicy { }
}

namespace Apex.System
{
    using ApexSharpApi.ApexApi;

    public class Id : ID
    {
        public Id(string id) : base(id)
        {
        }

        public Id(ID id) : base(id)
        {
        }
    }

    public class Idea { }

    public class IdeaComment { }

    public class Question { }

    public class AsyncInsertCallback { }

    public class AsyncUpdateCallback { }
}

namespace Apex.Database
{
    public class LocaleOptions { }

    public class Savepoint { }
}

namespace Apex.DataSource
{
    public class DataType { }

    public class OrderDirection { }

    public class Capability { }

    public class AuthenticationCapability { }

    public class FilterType { }

    public class IdentityType { }

    public class QueryAggregation { }
}

namespace Apex.UserProvisioning
{
    public class ConnectedApplication { }

    public class UserProvisioningRequest { }
}

namespace Apex.Search
{
    public class KnowledegeSuggestionFilter { }
}

namespace Apex.Social
{
    public class SocialPersona { }

    public class SocialPost { }
}