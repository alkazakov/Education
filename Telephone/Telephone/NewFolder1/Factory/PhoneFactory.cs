using System;
using System.Collections.Generic;
using System.Linq;
using Telephone.Parts;

namespace Telephone
{
    class PhoneFactory : PartFactory, IPartFactory<IManufacturer>
    {
        private IList<Type> _supportedTypes = new List<Type>();
        public IManufacturer Create<T>()
        {
            _supportedTypes = GetSupportedTypesList<IManufacturer>();
            if (_supportedTypes.Any(t => t.Name == typeof(T).Name))
                return (IManufacturer)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}