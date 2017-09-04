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
    }

    class DisplayFactory: IPartFactory<IDisplay>
    {
        public IDisplay Create()
        {
            return new Display();
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
    class WifiModulFactory : IPartFactory<IWifiModule>
    {
        public IWifiModule Create()
        {
            return new WifiModule();
        }
    } 
}
