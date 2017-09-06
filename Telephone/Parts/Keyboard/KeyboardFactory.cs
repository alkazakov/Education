using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephone
{
    class KeyboardFactory : IPartFactory<IKeyboard>
    {
        readonly IList<IKeyboard> _supportedTypes = new List<IKeyboard>();

        public void Initialize()
        {
            _supportedTypes.Add(new Keyboard());
            _supportedTypes.Add(new PrimitiveKeyboard());
            IsInitialized = true;
        }

        public KeyboardFactory()
        {
            Initialize();
        }
        public bool IsInitialized { get; private set; } = false;

        public IKeyboard Create<T>()
        {
            if (!IsInitialized)
                throw new Exception($"{nameof(KeyboardFactory)} is not Initialized!");
            if (_supportedTypes.Any(t => t.GetType() == typeof(T)))
                return (IKeyboard)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}