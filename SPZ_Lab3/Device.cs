using System;

namespace SPZ_Lab3
{
    //типы периферийных устройств
    public enum Devices
    {
        MOUSE,
        KEYBOARD,
        HDD,
        RAM,
        PRINTER,
        LOUDSPEAKERS,
        PHONE,
        MICROPHONE,
        HEADPHONES,
        FLASH,
        MONITOR
    }

    //типы портов устройств
    public enum Ports
    {
        COM,
        MICROUSB,
        USB
        
    }

    //класс периферийного устройства
    public class Device
    {
        //имя устройства
        public string DeviceName { get; set; }
        //имя фирмы-производителя устройства
        public string DeviceManufacturer { get; set; }
        //тип устройства
        public Devices DeviceType { get; set; }
        //тип порта устройства
        public Ports DevicePortType { get; set; }
        //флаг подключение устройства
        public bool IsConnected { get; set; }

        //инициализирующий конструктор
        public Device(string name, string manufacturer, Devices deviceType, Ports portType)
        {
            DeviceName = name;
            DeviceManufacturer = manufacturer;
            DeviceType = deviceType;
            DevicePortType = portType;
            IsConnected = false;
        }

        //конструктор копирования
        public Device(Device obj)
        {
            DeviceName = obj.DeviceName;
            DeviceManufacturer = obj.DeviceManufacturer;
            DeviceType = obj.DeviceType;
            DevicePortType = obj.DevicePortType;
            IsConnected = false;
        }

        public override string ToString()
        {
            return String.Format("{2} ({0} {1}), {3}", DevicePortType, DeviceType, DeviceName, DeviceManufacturer);
        }

        //перегруженный оператор true
        public static bool operator true(Device obj)
        {
            if (obj.IsConnected)
                return true;
            return false;
        }

        //перегруженный оператор false
        public static bool operator false(Device obj)
        {
            if (!obj.IsConnected)
                return true;
            return false;
        }

        //оператор приведения строки к периферийному устройству
        public static explicit operator Device(string data)
        {
            string[] parts = data.Split(" ,()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string Name = parts[0];
            Ports PortType;
            Enum.TryParse<Ports>(parts[1], out PortType);
            Devices DeviceType;
            Enum.TryParse<Devices>(parts[2], out DeviceType);
            string Manufacturer = parts[3];

            return new Device(Name, Manufacturer, DeviceType, PortType);
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

            // TODO: write your implementation of Equals() here
            Device temp = (Device)obj;
            if (this.DeviceName == temp.DeviceName &&
                this.DeviceManufacturer == temp.DeviceManufacturer &&
                this.DevicePortType == temp.DevicePortType &&
                this.DeviceType == temp.DeviceType)
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
    }
}