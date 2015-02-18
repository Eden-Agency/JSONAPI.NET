using EdenAgency.JsonApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenAgency.JsonApi
{
    /// <summary>
    /// Represents a link
    /// </summary>
    public class Link
    {

    }

    /// <summary>
    /// Used for typing purposes to avoid dynamism.
    /// </summary>
    /// <typeparam name="T">The top level resource to serialize.</typeparam>
    public class Link<T> : Link where T : class, IResource {}
}
