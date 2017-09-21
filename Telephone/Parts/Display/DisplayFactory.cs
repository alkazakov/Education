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
        
        public IDisplay Create<T>()
        {
            _supportedTypes = GetSupportedTypesList<IDisplay>();
            if (_supportedTypes.Any(t => t.Name == typeof(T).Name))
                return (IDisplay)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}