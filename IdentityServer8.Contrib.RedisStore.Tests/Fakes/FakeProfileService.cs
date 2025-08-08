﻿using IdentityServer8.Models;
using IdentityServer8.Services;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;

namespace IdentityServer8.Contrib.RedisStore.Tests.Fakes
{
    public class FakeProfileService : IProfileService
    {
        public IEnumerable<Claim> Claims = new List<Claim>();

        public Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            context.IssuedClaims = Claims.ToList();
            return Task.CompletedTask;
        }

        public Action<IsActiveContext> IsActive;

        public Task IsActiveAsync(IsActiveContext context)
        {
            IsActive?.Invoke(context);
            return Task.CompletedTask;
        }
    }
}
