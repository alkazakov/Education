using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Telephone.Parts;

namespace Telephone
{
    class DisplayFactory: PartFactory, IPartFactory<IDisplay>
    {
        /// <summary>
        /// The supported types
        /// </summary>
        private IList<Type> _supportedTypes = new List<Type>();
        /// <summary>
        /// Create Instance of concrete Display
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IDisplay Create<T>()
        {
            _supportedTypes = GetSupportedTypesList<IDisplay>();
            if (_supportedTypes.Any(t => t.Name == typeof(T).Name))
                return (IDisplay)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}