using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenAgency.JsonApi.Formats
{
    /// <summary>
    /// Defines the notation used to represent the relationship in a JSON resource. 
    /// When a null reference is supplied in a To-One relationship then the output falls back to the standard format of a null for the value.
    /// When an empty array or a null references is supplied in a To-Many relationship then the output falls back to the standard format of an empty array.
    /// </summary>
    /// <see cref="http://jsonapi.org/format/"/>
    /// <example>
    /// When no value is supplied the no
    /// </example>
    public enum RelationshipNotation
    {
        /// <summary>
        /// When used in a To-One relationship the collapsed notation outputs the id of the To-One Relationship.
        /// When used in a To-Many relationship the collapsed notation outputs the ids of the relationnship as an array.
        /// </summary>
        /// <example>
        /// This example shows how a To-One relationship will be shown with the collapsed notation.
        /// <code>
        /// {
        ///     "id": "1",
        ///     "title": "Rails is Omakase",
        ///     "links": {
        ///         "author": "17"
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <example>
        /// This example shows how a To-Many relationship will be shown with the collapsed notation.
        /// <code>
        /// { // To-Many Relationship
        ///     "id": "1",
        ///     "title": "Rails is Omakase",
        ///     "links": {
        ///         "comments": [ "5", "12", "17", "20" ]
        ///     }
        /// }
        /// </code>
        /// </example>
        Collapsed,
        /// <summary>
        /// When used in a To-One relationship the exploded notation outputs the id, href and type of the To-One Relationship.
        /// </summary>
        /// <example>
        /// This example shows how a To-One relationship will be shown with the exploded notation.
        /// <code>
        /// { 
        ///     "id": "1",
        ///     "title": "Rails is Omakase",
        ///     "links": {
        ///         "author": {
        ///             "href": "http://example.com/people/17",
        ///             "id": "17",
        ///             "type": "people"
        ///         }
        ///     }
        /// }
        /// </code>
        /// </example>
        /// This example shows how a To-Many relationship will be shown with the exploded notation.
        /// <code>
        /// { // To-One Relationship
        ///     "id": "1",
        ///     "title": "Rails is Omakase",
        ///     "links": {
        ///         "comments": {
        ///             "href": "http://example.com/comments/5,12,17,20",
        ///              "ids": [ "5", "12", "17", "20" ],
        ///             "type": "comments"
        ///         }
        ///     }
        /// }
        /// </code>
        /// </example>
        Exploded
    }
}
