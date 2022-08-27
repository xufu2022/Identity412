﻿using Microsoft.AspNetCore.Identity;

namespace Identity4121.Infrastructure.Identity
{
    public class WeakPasswordValidator : IPasswordValidator<User>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user, string password)
        {
            if (password.Contains("testweakpassword"))
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError
                {
                    Code = "WeakPassword",
                    Description = "WeakPasswordValidator testing.",
                }));
            }

            // TODO: check weak password, leaked password, password histories, etc.
            return Task.FromResult(IdentityResult.Success);
        }
    }
}
