using System;
using System.Collections.Generic;
using System.Linq;
using Telephone.Parts;

namespace Telephone
{
    class WifiModuleFactory : PartFactory,IPartFactory<IWifiModule>
    {
        private IList<Type> _supportedTypes = new List<Type>();
        public IWifiModule Create<T>()
        {
            _supportedTypes = GetSupportedTypesList<IWifiModule>();
            if (_supportedTypes.Any(t => t.Name == typeof(T).Name))
                return (IWifiModule)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}