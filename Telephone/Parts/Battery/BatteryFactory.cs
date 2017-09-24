using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            {
                var instance = (T)(object) Activator.CreateInstance(typeof(T));
                var type = instance.GetType();

                var prop = type.GetField("_capacity", BindingFlags.Instance | BindingFlags.NonPublic);

                var batteryConfig = type.GetField("_batteryConfig._capacity", BindingFlags.Instance);

                batteryConfig?.SetValue(instance,1250);

                Console.WriteLine(prop.Name);
                prop?.SetValue(instance,123);
                return instance as IBattery;
            }
            else
            {
                throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
            }
                
            
        }
    }
}