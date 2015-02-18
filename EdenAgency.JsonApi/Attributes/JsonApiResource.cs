using EdenAgency.JsonApi.Formats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenAgency.JsonApi.Attributes
{
    /// <summary>
    /// Tells the JsonApiMediaTypeFormatter how to serialize the resource.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=false)]
    public class JsonApiResource : Attribute
    {
        #region Members

        private RelationshipNotation defaultRelationshipNotation = RelationshipNotation.Collapsed;

        private string name;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonApiResource"/> class.
        /// </summary>
        /// <param name="defaultRelationshipNotation">The default relationship notation.</param>
        /// <param name="name">The name.</param>
        public JsonApiResource(RelationshipNotation defaultRelationshipNotation = RelationshipNotation.Collapsed, string name = null)
        {
            this.name = name;
            this.defaultRelationshipNotation = defaultRelationshipNotation;
        }

        #endregion Constructors
    }
}
