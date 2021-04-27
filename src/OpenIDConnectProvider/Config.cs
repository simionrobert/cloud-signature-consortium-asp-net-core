using IdentityServer4.Models;
using IdentityServer4.Test;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenIDConnectProvider
{
    public class Config
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser> {
            new TestUser {
                SubjectId = "5BE86359-073C-434B-AD2D-A3932222DABE",
                Username = "scott",
                Password = "password"
            }
        };
        }

        public static IEnumerable<ApiScope> ApiScopes =>
      new List<ApiScope>
      {
                new ApiScope("service", "csc"),
                   new ApiScope("credentials", "csc")
      };

        public static IEnumerable<ApiResource> GetApiResources(IConfigurationSection section)
        {
            List<ApiResource> resource = new List<ApiResource>();

            if (section != null)
            {
                List<ApiConfig> configs = new List<ApiConfig>();
                section.Bind("ApiResources", configs);
                foreach (var config in configs)
                {
                    resource.Add(new ApiResource
                    {
                        Name = config.Name,
                        DisplayName = config.DisplayName,
                        Description = "Allow the application to access API #1 on your behalf",
                        // API has multiple scopes
                        Scopes = new List<string> { "service", "credentials" },
                        // secret for introspection endpoint
                        ApiSecrets = new List<Secret> { new Secret("ScopeSecret".Sha256()) }
                    });
                }
            }

            return resource.ToArray();
        }

        public static IEnumerable<Client> GetClients =>
           new List<Client>
           {
                // JavaScript Client
                new Client
                {
                    ClientId = "cscClient",
                    ClientName = "cscClient",
                    AllowedGrantTypes = GrantTypes.Code,
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    RequirePkce = false,
                    RedirectUris =           { "https://localhost:8080" },
                   // PostLogoutRedirectUris = { "https://localhost:5003/index.html" },
                    //AllowedCorsOrigins =     { "https://localhost:5003" },

                    AllowedScopes =new List<string>
                    {
                       "service",
                       "credentials"
                    }

                }
           };

        /*
        public static IEnumerable<Client> GetClients(IConfigurationSection section)
        {
            List<Client> clients = new List<Client>();

            if (section != null)
            {
                List<ClientConfig> configs = new List<ClientConfig>();
                section.Bind("Clients", configs);
                foreach (var config in configs)
                {
                    Client client = new Client();
                    client.ClientId = config.ClientId;
                    List<Secret> clientSecrets = new List<Secret>();
                    foreach (var secret in config.ClientSecrets)
                    {
                        clientSecrets.Add(new Secret(secret.Sha256()));
                    }
                    client.ClientSecrets = clientSecrets.ToArray();

                    GrantTypes grantTypes = new GrantTypes();
                    var allowedGrantTypes = grantTypes.GetType().GetProperty(config.AllowedGrantTypes);
                    client.AllowedGrantTypes = allowedGrantTypes == null ?
                        GrantTypes.ClientCredentials : (ICollection<string>)allowedGrantTypes.GetValue(grantTypes, null);

                    client.AllowedScopes = config.AllowedScopes.ToArray();

                    client.RequireConsent = true;
                    client.AllowRememberConsent = true;
                    //client.AccessTokenType = AccessTokenType.Reference;
                    clients.Add(client);
                }
            }
            return clients.ToArray();
        }
        */
    }

    public class ApiConfig
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class ClientConfig
    {
        public string ClientId { get; set; }
        public List<string> ClientSecrets { get; set; }
        public string AllowedGrantTypes { get; set; }
        public List<string> AllowedScopes { get; set; }
    }
}
