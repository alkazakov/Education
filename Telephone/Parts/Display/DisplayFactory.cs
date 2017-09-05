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

        public void Initialize()
        {
            _supportedTypes.Add(new RetinaDisplay());
            _supportedTypes.Add(new AmoledDisplay());
            IsInitialized = true;
        }

        public bool IsInitialized { get; private set; } = false;

        public IDisplay Create<T>()
        {

            if (!IsInitialized)
                throw  new Exception($"{nameof(DisplayFactory)} is not Initialized!");

            if (_supportedTypes.Any(t => t.GetType() == typeof(T)))
                return (IDisplay)Activator.CreateInstance<T>();

                //switch (typeof(T).Name)
                //{
                //    case nameof(RetinaDisplay): return new RetinaDisplay();
                //    case nameof(AmoledDisplay): return  new AmoledDisplay();
                //    default: return null;
                //}

            throw new ArgumentException($"Invalid Type: {typeof(T).Name}");
        }
    }
}