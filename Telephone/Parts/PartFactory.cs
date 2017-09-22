using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Telephone.Parts
{
    /// <summary>
    /// This is an abstract Factory for all Phone Parts
    /// </summary>
    abstract class PartFactory
    {
        /// <summary>
        /// Gets supported types for concrete Factory.
        /// Check whether instance implement supported interface.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        protected List<Type> GetSupportedTypesList<T>() => Assembly.GetExecutingAssembly().
                                                                    GetTypes().
                                                                    Where(t => t.IsClass && 
                                                                               t.GetInterfaces().Contains(typeof(T))).
                                                                    ToList();
    }
}
