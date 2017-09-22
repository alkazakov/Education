using System;
using System.Collections.Generic;
using System.Linq;
using Telephone.Parts;

namespace Telephone
{
    class MemoryFactory : PartFactory,IPartFactory<IMemory>
    {
        private IList<Type> _supportedTypes = new List<Type>();
        public IMemory Create<T>()
        {
            _supportedTypes = GetSupportedTypesList<IMemory>();
            if (_supportedTypes.Any(t => t.Name == typeof(T).Name))
                return (IMemory)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}