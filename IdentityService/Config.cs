using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityService
{
    public class Config
    {
        // API that are allowed to access the Auth server
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
                   {
                   new ApiResource("api1", "My API")
                };
        }

        public static IEnumerable<Client> GetClients()
        {
            // client credentials, list of clients
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                     {
                       new Secret("secret".Sha256())
                      },
                  AllowedScopes = { "api1" }
                }
            };
        }
    }
}