using System.Windows.Forms;

namespace SPZ_Lab3
{
    public partial class ComputerCreatingForm : Form
    {
        public ComputerCreatingForm()
        {
            InitializeComponent();
            for (int i = 1; i <= 128; i++) {
                CBCOMPorts.Items.Add(i);
                CBMICROUSBPorts.Items.Add(i);
                CBUSBPorts.Items.Add(i);
            }

            CBCOMPorts.SelectedItem = 1;
            CBMICROUSBPorts.SelectedItem = 1;
            CBUSBPorts.SelectedItem = 1;

        }

        public ComputerCreatingForm(Computer computer)
        {
            InitializeComponent();
            for (int i = 1; i <= 128; i++)
            {
                CBCOMPorts.Items.Add(i);
                CBMICROUSBPorts.Items.Add(i);
                CBUSBPorts.Items.Add(i);
            }

            TBComputerName.Text = computer.Id;
            CBCOMPorts.SelectedItem = computer.COM_Count;
            CBMICROUSBPorts.SelectedItem = computer.MICROUSB_Count;
            CBUSBPorts.SelectedItem = computer.USB_Count;
        }

        public Computer GetComputer()
        {
            string Id = TBComputerName.Text;
            int Com = (int)CBCOMPorts.SelectedItem;
            int mUsb = (int)CBMICROUSBPorts.SelectedItem;
            int Usb = (int)CBUSBPorts.SelectedItem;

            return new Computer(Id, Com, mUsb, Usb);
        }
    }
}
