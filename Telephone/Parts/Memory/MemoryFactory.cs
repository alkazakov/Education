using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephone
{
    class MemoryFactory : IPartFactory<IMemory>
    {
        readonly IList<IMemory> _supportedTypes = new List<IMemory>();

        public void Initialize()
        {
            _supportedTypes.Add(new Memory());
            IsInitialized = true;
        }

        public MemoryFactory()
        {
            Initialize();
        }
        public bool IsInitialized { get; private set; } = false;

        public IMemory Create<T>()
        {
            if (!IsInitialized)
                throw new Exception($"{nameof(MemoryFactory)} is not Initialized!");
            if (_supportedTypes.Any(t => t.GetType() == typeof(T)))
                return (IMemory)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}