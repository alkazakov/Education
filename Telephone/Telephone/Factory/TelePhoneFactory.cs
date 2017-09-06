using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephone
{
    class TelePhoneFactory : ITelePhoneFactory<ITelephoneBuilder>
    {
        readonly IList<ITelephoneBuilder> _supportedTypes = new List<ITelephoneBuilder>();

        public void Initialize()
        {
            _supportedTypes.Add(new SamsungPhoneBuilder());
            _supportedTypes.Add(new PrimitivePhoneBuilder());
            IsInitialized = true;
        }

        public TelePhoneFactory()
        {
            Initialize();
        }
        public bool IsInitialized { get; private set; } = false;

        public ITelephoneBuilder Create<T>()
        {
            if (!IsInitialized)
                throw new Exception($"{nameof(TelePhoneFactory)} is not Initialized!");
            if (_supportedTypes.Any(t => t.GetType() == typeof(T)))
                return (ITelephoneBuilder)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}