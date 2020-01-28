using System;
using System.Windows.Forms;

namespace SPZ_Lab3
{
    public partial class DeviceCreatingForm : Form
    {
        public DeviceCreatingForm()
        {
            InitializeComponent();
           
            CBDeviceType.Items.AddRange(Enum.GetNames(typeof(Devices)));
            CBDeviceType.SelectedItem = Enum.GetNames(typeof(Devices))[0];

            CBPortType.Items.AddRange(Enum.GetNames(typeof(Ports)));
            CBPortType.SelectedItem = Enum.GetNames(typeof(Ports))[0];
        }

        public DeviceCreatingForm(Device device)
        {
            InitializeComponent();

            TBDeviceName.Text = device.DeviceName;
            TBManufacturer.Text = device.DeviceManufacturer;

            CBDeviceType.Items.AddRange(Enum.GetNames(typeof(Devices)));
            CBDeviceType.SelectedItem = Enum.GetName(typeof(Devices), device.DeviceType);

            CBPortType.Items.AddRange(Enum.GetNames(typeof(Ports)));
            CBPortType.SelectedItem = Enum.GetName(typeof(Ports), device.DevicePortType);

        }

        public Device GetDevice()
        {
            string Name = TBDeviceName.Text;
            string Manufacturer = TBManufacturer.Text;
            Devices DeviceType /*= (Devices)(CBDeviceType.SelectedItem)*/;
            Ports PortType/* = (Ports)CBPortType.SelectedItem*/;

            Enum.TryParse<Devices>(CBDeviceType.SelectedItem.ToString(), out DeviceType);
            Enum.TryParse<Ports>(CBPortType.SelectedItem.ToString(), out PortType);


            return new Device(Name, Manufacturer, DeviceType, PortType);
        }
    }
}
