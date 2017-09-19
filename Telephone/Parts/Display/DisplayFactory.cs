using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Telephone
{
    class DisplayFactory: IPartFactory<IDisplay>
    {
        readonly IList<IDisplay> _supportedTypes = new List<IDisplay>();

        /// <summary>
        /// supported types-> find in assembly by pattern xxxDisplay
        /// </summary>
        public void Initialize()
        {
            _supportedTypes.Add(new RetinaDisplay());
            _supportedTypes.Add(new AmoledDisplay());
            _supportedTypes.Add(new PrimitiveDisplay());

        }

        public DisplayFactory()
        {
           Initialize();
        }
       
        public IDisplay Create<T>()
        {
           
            if (_supportedTypes.Any(t => t.GetType() == typeof(T)))
                return (IDisplay)Activator.CreateInstance<T>();
            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}