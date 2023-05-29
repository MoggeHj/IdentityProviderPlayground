// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using IdentityModel;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace IdentityProviderPlayground.IDP;

public class TestUsers
{
    public static List<TestUser> Users =>
        new()
        {
            new()
            {
                SubjectId = "1",
                Username = "Morgan",
                Password = "password",
                Claims =
                {
                    new Claim(JwtClaimTypes.GivenName, "Morgan"),
                    new Claim(JwtClaimTypes.FamilyName, "Hjelm")
                }
            },
            new()
            {
                SubjectId = "2",
                Username = "Erik",
                Password = "password",
                Claims =
                {
                    new Claim(JwtClaimTypes.GivenName, "Erik"),
                    new Claim(JwtClaimTypes.FamilyName, "Hjelm"),
                    new Claim(JwtClaimTypes.Email, "ErikH@email.com")
                }
            }
        };
}