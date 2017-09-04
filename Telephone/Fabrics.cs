using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{

    interface IPartFactory<out TResult>
    {
        TResult Create();
        void Initialize();

        bool Isinitialized { get; }
    }



    class DisplayFactory: IPartFactory<IDisplay>
    {
        IList<IDisplay> SupportedTypes = new List<IDisplay>();

        public void Initialize()
        {
            SupportedTypes.Add(new Display());
            Isinitialized = true;

        }

        public bool Isinitialized { get; }

        public IDisplay Create(Type type)
        {
            if (!Isinitialized)
            {
                throw  new Exception("Not Initialized!");
            }
            if (SupportedTypes.Any(t=> type.Name == nameof(t) ))
            return new Display();
            throw  new Exception("InvalidTypeName");
        }

        public IDisplay Create()
        {
            throw new NotImplementedException();
        }
    }
    class KeyboardFactory : IPartFactory<IKeyboard>
    {
        public IKeyboard Create()
        {
            return new Keyboard();
        }
    }
    class OperationSystemFactory : IPartFactory<IOperationSystem>
    {
        public IOperationSystem Create()
        {
            return new OperationSystem();
        }
    }
    class HardDriveFactory: IPartFactory<IHardDrive>
    {
        public IHardDrive Create()
        {
            return  new HardDrive();
        }
    }
    class MemoryFactory : IPartFactory<IMemory>
    {
        public IMemory Create()
        {
            return new Memory();
        }
    }
    class CameraFactory : IPartFactory<ICamera>
    {
        public ICamera Create()
        {
            return new Camera();
        }
    }
    class WifiModuleFactory : IPartFactory<IWifiModule>
    {
        public IWifiModule Create()
        {
            return new WifiModule();
        }
    } 
}
