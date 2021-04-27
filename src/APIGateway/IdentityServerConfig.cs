using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGateway
{
    public class IdentityServerConfig
    {
        public string Protocol { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public string IdentityScheme { get; set; }
        public List<APIResource> Resources { get; set; }
    }

    public class APIResource
    {
        public string Key { get; set; }
        public string Name { get; set; }
    }
}
