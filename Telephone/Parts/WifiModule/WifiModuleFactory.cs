using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephone
{
    class WifiModuleFactory : IPartFactory<IWifiModule>
    {
        readonly IList<IWifiModule> _supportedTypes = new List<IWifiModule>();

        public void Initialize()
        {
            _supportedTypes.Add(new WifiModule());
            IsInitialized = true;
        }

        public WifiModuleFactory()
        {
            Initialize();
        }
        public bool IsInitialized { get; private set; } = false;

        public IWifiModule Create<T>()
        {
            if (!IsInitialized)
                throw new Exception($"{nameof(WifiModuleFactory)} is not Initialized!");
            if (_supportedTypes.Any(t => t.GetType() == typeof(T)))
                return (IWifiModule)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}