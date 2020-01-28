using System.Collections.Generic;

namespace SPZ_Lab3
{
    //класс менеджера устройств
    class DeviceManager
    {
        //ключ для следующего добавленного устройства
        private static int _deviceKey;

        private const int _computerMaxCount = 10;
        private const int _deviceMaxCount = 100;

        //коллекция компьютеров
        private List<Computer> _computers;

        //коллекция устройств
        private SortedList<int, Device> _devices;

        //общее кол-во устройств
        public int DeviceCount { get; private set; }

        //общее кол-во компьютеров
        public int ComputerCount { get; private set; }

        //кол-во не подключенных устройств
        public int UnusedDeviceCount { get; private set; }

        //статический конструктор
        static DeviceManager()
        {
            _deviceKey = 0;
        }

        //конструктор по умолчанию
        public DeviceManager()
        {
            _computers = new List<Computer>();
            _devices = new SortedList<int, Device>();
            //
        }

        //добавить компьютер
        public bool AddComputer(Computer computer)
        {
            if (ComputerCount < _computerMaxCount && !_computers.Contains(computer))
            {
                _computers.Add(computer);
                ComputerCount++;
                return true;
            }
            return false;
        }

        //удалить компьютер
        public bool RemoveComputer(Computer computer)
        {
            //если менеджер содержит нужный компьютер, и к нему не подключены устройства
            if (computer.DevicesCount == 0 &&
                _computers.Contains(computer))
            {
                _computers.Remove(computer);
                ComputerCount--;
                return true;
            }
            return false;
        }

        //замена компьютера
        public bool ChangeComputer(Computer dest, Computer src)
        {
            if (_computers.Contains(dest) && !_computers.Contains(src) || dest.Id == src.Id)
            {
                _computers[_computers.IndexOf(dest)] = new Computer(src); 
                return true;
            }
            return false;
        }
        
        //добавление устройства
        public bool AddDevice(Device device)
        {
            if (DeviceCount < _deviceMaxCount)
            {
                _devices.Add(_deviceKey++, device);
                DeviceCount++;
                UnusedDeviceCount++;
                return true;
            }
            return false;
        }

        //удаление устройства
        public bool RemoveDevice(Device device)
        {
            //если коллекция содержит устройство
            if (_devices.ContainsValue(device))
            {
                if (_devices.IndexOfValue(device) == (_deviceKey - 1))
                {
                    _devices.Remove(_devices.IndexOfValue(device));
                    DeviceCount--;
                    UnusedDeviceCount--;
                    _deviceKey--;
                    return true;
               
                } else
                {
                    int temp = _devices.IndexOfValue(device);
                    for (int i = temp; i < _devices.Count - 1; i++)
                    {
                        _devices[i] = _devices[i + 1];
                        
                    }
                    _deviceKey = _devices.Count - 1;
                    _devices.RemoveAt(_devices.Count - 1);
                    DeviceCount--;
                    UnusedDeviceCount--;
                    return true;
                }
            }
            return false;
        }

        //замена устройства
        public bool ChangeDevice(Device dest, Device src)
        {
            if (_devices.ContainsValue(dest))
            {
                _devices[_devices.IndexOfValue(dest)] = new Device(src);
                return true;
            }
            return false;
        }
       
        //подключение устройства к компьютеру
        public bool ConnectDevice(Computer computer, Device device)
        {
            //если устройство и компьютер содержатся в соответсвующих коллекциях менеджера
            //и устройство подключается к компьютеру, кол-во неиспользуемых устройств: -1
            if (_devices.ContainsValue(device) && _computers.Contains(computer) && computer.ConnectDevice(device))
            {
                UnusedDeviceCount--;
                return true;
            }
            return false;
        }

        //отключение устройства от компьютера
        public bool DisconnectDevice(Computer computer, Device device)
        {
            if (computer.DisconnectDevice(device) && _devices.ContainsValue(device))
            {
                UnusedDeviceCount++;
                return true;
            }
            return false;
        }

        //индексатор по коллекции компьютеров
        public Computer this[int index]
        {
            get
            {
                return _computers[index];
            }
        }
    }
}