using System;
using System.Collections.Generic;
using System.Linq;
using Telephone.Parts;

namespace Telephone
{
    class CameraFactory : PartFactory, IPartFactory<ICamera>
    {
        private IList<Type> _supportedTypes = new List<Type>();
        public ICamera Create<T>()
        {
            _supportedTypes = GetSupportedTypesList<ICamera>();
            if (_supportedTypes.Any(t => t.Name == typeof(T).Name))
                return (ICamera)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}