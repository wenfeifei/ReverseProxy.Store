using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReverseProxy.Store.EFCore
{
    public class Cluster
    {
        /// <summary>
        /// The Id for this cluster. This needs to be globally unique.
        /// </summary>
        [Key]
        public string Id { get; set; }

        /// <summary>
        /// Load balancing policy.
        /// </summary>
        public string LoadBalancingPolicy { get; set; }

        /// <summary>
        /// Session affinity options.
        /// </summary>
        public virtual SessionAffinityOptions SessionAffinity { get; set; }

        /// <summary>
        /// Health checking options.
        /// </summary>
        public virtual HealthCheckOptions HealthCheck { get; set; }

        /// <summary>
        /// Options of an HTTP client that is used to call this cluster.
        /// </summary>
        public virtual ProxyHttpClientOptions HttpClient { get; set; }

        /// <summary>
        /// Options of an outgoing HTTP request.
        /// </summary>
        public virtual RequestProxyOptions HttpRequest { get; set; }

        /// <summary>
        /// The set of destinations associated with this cluster.
        /// </summary>
        public virtual List<Destination> Destinations { get; set; }

        /// <summary>
        /// Arbitrary key-value pairs that further describe this cluster.
        /// </summary>
        public virtual List<Metadata> Metadata { get; set; }

        public virtual List<ProxyRoute> ProxyRoutes { get; set; }
    }
}
