using System;
using System.Collections.Generic;

namespace SPZ_Lab3
{
    //класс компьютера
    public class Computer
    {
        //коллекция подключенных устройств
        private List<Device> _devices;

        //идентификатор (имя) компьютера
        public string Id { get; set; }

        //кол-во COM-портов компьютера
        public int COM_Count { get; private set; }

        //кол-во microUSB-портов компьютера
        public int MICROUSB_Count { get; private set; }
        
        //кол-во USB-портов компьютера
        public int USB_Count { get; private set; }

        //кол-во свободных COM-портов компьютера
        public int Free_COM_Count { get; private set; }

        //кол-во свободных microUSB-портов компьютера
        public int Free_MICROUSB_Count { get; private set; }

        //кол-во свободных USB-портов компьютера
        public int Free_USB_Count { get; private set; }
        
        //общее кол-во свободных портов
        public int FreePortsCount { get; set; }

        //кол-во подключенных устройств /**/
        public int DevicesCount
        {
            get
            {
                return _devices.Count;
            }
        }

        //инициализирующий конструктор
        public Computer(string id, int COM_count, int MICROUSB_count, int USB_count)
        {
            Id = id;
            COM_Count = COM_count;
            MICROUSB_Count = MICROUSB_count;
            USB_Count = USB_count;

            Free_COM_Count = COM_Count;
            Free_MICROUSB_Count = MICROUSB_Count;
            Free_USB_Count = USB_Count;

            FreePortsCount = COM_Count + USB_Count + MICROUSB_Count;
            _devices = new List<Device>(FreePortsCount);
        }

        //конструктор копирования
        public Computer(Computer obj)
        {
            Id = obj.Id;
            COM_Count = obj.COM_Count;
            MICROUSB_Count = obj.MICROUSB_Count;
            USB_Count = obj.USB_Count;

            Free_COM_Count = obj.Free_COM_Count;
            Free_MICROUSB_Count = obj.Free_MICROUSB_Count;
            Free_USB_Count = obj.Free_USB_Count;

            FreePortsCount = obj.FreePortsCount;
            _devices = obj._devices;
        }

        //подключение устройства
        public bool ConnectDevice(Device device)
        {
            //если это устройство не является уже подключеным к этому компьютеру
            //if (!_devices.Contains(device))
            //{
                //подключить устройство в зависимости от его типа порта
                switch (device.DevicePortType)
                {
                    case Ports.COM:
                        if (Free_COM_Count > 0)
                        {
                            _devices.Add(device);
                            device.IsConnected = true;
                            FreePortsCount--;
                            Free_COM_Count--;
                            return true;
                        }
                        break;
                    case Ports.MICROUSB:
                        if (Free_MICROUSB_Count > 0)
                        {
                            _devices.Add(device);
                            device.IsConnected = true;
                            FreePortsCount--;
                            Free_MICROUSB_Count--;
                            return true;
                        }
                        break;
                    case Ports.USB:
                        if (Free_USB_Count > 0)
                        {
                            _devices.Add(device);
                            device.IsConnected = true;
                            FreePortsCount--;
                            Free_USB_Count--;
                            return true;
                        }
                        break;
                }
            //}
            return false;
        }

        //отключение устройства
        public bool DisconnectDevice(Device device)
        {
            //если устройство успешно удалено из коллекции
            if (_devices.Remove(device))
            {
                //снять флаг подключение
                device.IsConnected = false;
                
                //общее кол-во свободных портов: +1
                FreePortsCount++;

                //кол-во свободных портов типа отключенного устройства: +1
                switch (device.DevicePortType)
                {
                    case Ports.COM:
                        Free_COM_Count++;
                        break;
                    case Ports.MICROUSB:
                        Free_MICROUSB_Count++;
                        break;
                    case Ports.USB:
                        Free_USB_Count++;
                        break;
                }
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format("{0} (COM: {1}, MICROUSB: {2}, USB: {3})", Id, COM_Count, MICROUSB_Count, USB_Count);
        }

        //оператор приведения строки к компьютеру
        public static explicit operator Computer(string data)
        {
            string[] parts = data.Split(" ,():".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string Id = parts[0];
            int Com;
            int.TryParse(parts[2], out Com);
            int MUsb;
            int.TryParse(parts[4], out MUsb);
            int Usb;
            int.TryParse(parts[6], out Usb);


            return new Computer(Id, Com, MUsb, Usb);
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Computer temp = (Computer)obj;
            if (/*this._devices.Equals(((Computer)obj)._devices) &&*/
                this.Id == temp.Id
                &&
                this.COM_Count == temp.COM_Count &&
                this.MICROUSB_Count == temp.MICROUSB_Count &&
                this.USB_Count == temp.USB_Count
                )
            {
                return true;
            }

            return false;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //индексатор по подключенным устройствам
        public Device this[int index]
        {
            get
            {
                return _devices[index];
            }
        }
    }
}