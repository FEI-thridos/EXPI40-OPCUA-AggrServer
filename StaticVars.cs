using Opc.Ua;
using Opc.Ua.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationServer
{
    internal static class StaticVars
    {
        internal static Dictionary<ConfiguredEndpoint, AggregationClientSession> _activeSessions = new Dictionary<ConfiguredEndpoint, AggregationClientSession>();
    }
}
