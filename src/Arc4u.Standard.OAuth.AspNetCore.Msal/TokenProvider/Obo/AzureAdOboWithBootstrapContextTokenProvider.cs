using Arc4u.Dependency;
using Arc4u.Dependency.Attribute;
using Arc4u.Diagnostics;
using Arc4u.OAuth2.Security;
using Arc4u.OAuth2.Token;
using Arc4u.Security.Principal;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;

namespace Arc4u.OAuth2.TokenProvider;

[Export(OboTokenProvider.ProviderName, typeof(ITokenProvider))]
public class AzureAdOboWithBootstrapContextTokenProvider : OboWithBootstrapContextTokenProvider
{
    public AzureAdOboWithBootstrapContextTokenProvider(ICacheHelper cacheHelper, IContainerResolve container, IApplicationContext applicationContext, IUserObjectIdentifier userObjectIdentifier, ILogger<AzureAdOboWithBootstrapContextTokenProvider> logger, IActivitySourceFactory activitySourceFactory) : base(cacheHelper, container, applicationContext, userObjectIdentifier, logger, activitySourceFactory)
    { }

    protected override IConfidentialClientApplication CreateCca(IKeyValueSettings valueSettings)
    {
        return ConfidentialClientApplicationBuilder
            .Create(valueSettings.Values[TokenKeys.ClientIdKey])
            .WithAuthority(valueSettings.Values[TokenKeys.AuthorityKey])
            .WithClientSecret(valueSettings.Values[TokenKeys.ApplicationKey])
            .Build();
    }
}
