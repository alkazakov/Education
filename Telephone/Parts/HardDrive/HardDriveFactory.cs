using System;
using System.Collections.Generic;
using System.Linq;
using Telephone.Parts;

namespace Telephone
{
    class HardDriveFactory : PartFactory,IPartFactory<IHardDrive>
    {
        private IList<Type> _supportedTypes = new List<Type>();
        public IHardDrive Create<T>()
        {
            _supportedTypes = GetSupportedTypesList<IHardDrive>();
            if (_supportedTypes.Any(t => t.Name == typeof(T).Name))
                return (IHardDrive)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}