using System;
using System.Collections.Generic;
using System.Linq;
using Telephone.Parts;

namespace Telephone
{
    class OperationSystemFactory : PartFactory,IPartFactory<IOperationSystem>
    {
        private IList<Type> _supportedTypes = new List<Type>();
        public IOperationSystem Create<T>()
        {
            _supportedTypes = GetSupportedTypesList<IOperationSystem>();
            if (_supportedTypes.Any(t => t.Name == typeof(T).Name))
                return (IOperationSystem)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}