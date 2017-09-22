using System;
using System.Collections.Generic;
using System.Linq;
using Telephone.Parts;

namespace Telephone
{
    class BatteryFactory : PartFactory, IPartFactory<IBattery>
    {
        private IList<Type> _supportedTypes = new List<Type>();

        public IBattery Create<T>()
        {
            _supportedTypes = GetSupportedTypesList<IBattery>();
            if (_supportedTypes.Any(t => t.Name == typeof(T).Name))
                return (IBattery) Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}