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
        readonly IList<Type> _supportedTypes = new List<Type>();

        public DisplayFactory()
        {
            _supportedTypes = GetSupportedTypesList<IDisplay>();
        }
        
        public IDisplay Create<T>()
        {
            if (_supportedTypes.Any(t => t.Name == typeof(T).Name))
                return (IDisplay)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}