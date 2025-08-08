using IdentityModel;
using IdentityServer8.Validation;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer8.Contrib.RedisStore.Tests.Fakes
{
    class FakeResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        public Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            context.Result = new GrantValidationResult(subject: "1",
                authenticationMethod: OidcConstants.AuthenticationMethods.Password,
                claims: new List<Claim> { });

            return Task.CompletedTask;
        }
    }
}
