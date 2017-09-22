using System;
using System.Collections.Generic;
using System.Linq;
using Telephone.Parts;

namespace Telephone
{
    class KeyboardFactory : PartFactory, IPartFactory<IKeyboard>
    {
        private IList<Type> _supportedTypes = new List<Type>();
        public IKeyboard Create<T>()
        {
            _supportedTypes = GetSupportedTypesList<IKeyboard>();
            if (_supportedTypes.Any(t => t.Name == typeof(T).Name))
                return (IKeyboard)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}