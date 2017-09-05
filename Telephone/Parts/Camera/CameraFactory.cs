using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephone
{
    class CameraFactory : IPartFactory<ICamera>
    {
        readonly IList<ICamera> _supportedTypes = new List<ICamera>();

        public void Initialize()
        {
            _supportedTypes.Add(new AppleFrontCamera());
            _supportedTypes.Add(new AppleRearCamera());
            _supportedTypes.Add(new SamsungFrontCamera());
            _supportedTypes.Add(new SamsungRearCamera());
            IsInitialized = true;
        }

        public CameraFactory()
        {
            Initialize();
        }
        public bool IsInitialized { get; private set; } = false;

        public ICamera Create<T>()
        {

            if (!IsInitialized)
                throw new Exception($"{nameof(CameraFactory)} is not Initialized!");

            if (_supportedTypes.Any(t => t.GetType() == typeof(T)))
                return (ICamera)Activator.CreateInstance<T>();

            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}