using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenAgency.JsonApi.Interfaces
{
    /// <summary>
    /// This interface encapsulates a resource in the JSON API specification. 
    /// When utilized as the return type for an API methhod this interface defines a documents 'top level'.
    /// If utilized as a resource relationship then this interface will defined the To-One relationship specification structure when decorated with the 
    /// </summary>
    /// <see cref="http://jsonapi.org/format/"/>
    public interface IResource
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier as specified for any JSON API Resource.
        /// </value>
        [JsonProperty("id")]
        string Id { get; set; }

        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        /// <value>
        /// The href as specified for any JSON API Resource.
        /// </value>
        [JsonProperty("href")]
        string Href { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type as specified for any JSON API Resource.
        /// </value>
        [JsonProperty("type")]
        string Type { get; set; }

        /// <summary>
        /// Gets or sets the meta.
        /// </summary>
        /// <value>
        /// The meta as specified for any JSON API Resource.
        /// </value>
        [JsonIgnore]
        IDictionary<string, object> Meta { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        /// <value>
        /// The links as specified for any JSON API Resource.
        /// </value>
        [JsonProperty("links")]
        IList<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the linked resource objects.
        /// </summary>
        /// <value>
        /// The linked.
        /// </value>
        [JsonProperty("linked")]
        IList<IResource> Linked { get; set; }
    }
}
