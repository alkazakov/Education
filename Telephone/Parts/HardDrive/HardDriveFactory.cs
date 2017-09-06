using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephone
{
    class HardDriveFactory : IPartFactory<IHardDrive>
    {
        readonly IList<IHardDrive> _supportedTypes = new List<IHardDrive>();

        public void Initialize()
        {
            _supportedTypes.Add(new HardDrive());
            IsInitialized = true;
        }

        public HardDriveFactory()
        {
            Initialize();
        }
        public bool IsInitialized { get; private set; } = false;

        public IHardDrive Create<T>()
        {
            if (!IsInitialized)
                throw new Exception($"{nameof(HardDriveFactory)} is not Initialized!");
            if (_supportedTypes.Any(t => t.GetType() == typeof(T)))
                return (IHardDrive)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}