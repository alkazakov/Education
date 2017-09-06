using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephone
{
    class OperationSystemFactory : IPartFactory<IOperationSystem>
    {
        readonly IList<IOperationSystem> _supportedTypes = new List<IOperationSystem>();

        public void Initialize()
        {
            _supportedTypes.Add(new OperationSystem());
            IsInitialized = true;
        }

        public OperationSystemFactory()
        {
            Initialize();
        }
        public bool IsInitialized { get; private set; } = false;

        public IOperationSystem Create<T>()
        {
            if (!IsInitialized)
                throw new Exception($"{nameof(OperationSystemFactory)} is not Initialized!");
            if (_supportedTypes.Any(t => t.GetType() == typeof(T)))
                return (IOperationSystem)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}