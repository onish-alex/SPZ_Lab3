using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SPZ_Lab3
{
    public partial class DeviceManagerForm : Form
    {
        //менеджер устройств
        private DeviceManager manager;
        //коллекция изображений для элементов TreeView 
        private ImageList imageList;

        public DeviceManagerForm()
        {
            InitializeComponent();

            manager = new DeviceManager();
            imageList = new ImageList();
            
            //добавление иконок для компьютера и устройства
            imageList.Images.Add(Image.FromFile("MyComputer.png"));
            imageList.Images.Add(Image.FromFile("MyPeripheral.png"));
            computerTree.ImageList = imageList;

            StatusUpdate();
        }

        //обновление строки статуса менеджера
        private void StatusUpdate()
        {
            LStatus.Text = String.Format("Всего компьютеров: {0}; Всего устройств: {1}; Готово к использованию: {2}", manager.ComputerCount, manager.DeviceCount, manager.DeviceCount - manager.UnusedDeviceCount);
        }

        //добавление нового устройства
        private void BAddDevice_Click(object sender, EventArgs e)
        {
           //вызов диалогового окна создания устройства
           Device device;
           DeviceCreatingForm deviceCreatingForm = new DeviceCreatingForm();
           deviceCreatingForm.ShowDialog();
           
           //при подтверждении пользователем - создать новое устройство, добавить в список менеджера и список в интерфейсе
           if (deviceCreatingForm.DialogResult == DialogResult.OK)
           {
                device = deviceCreatingForm.GetDevice();
                manager.AddDevice(device);

                LBDevices.Items.Add(device);

                StatusUpdate();
           }
        }

        //удаление устройства
        private void BRemoveDevice_Click(object sender, EventArgs e)
        {
            //если в списке устройств есть выделенный элемент
            if (LBDevices.SelectedItem != null)
            {
                //извлечь информацию об устройстве в новый объект
                Device device = (Device)LBDevices.SelectedItem;
                //удаляем из менеджера
                if (manager.RemoveDevice(device))
                {
                    LBDevices.Items.Remove(device);
                    StatusUpdate();
                }
            }
        }

        //добавление компьютера
        private void BAddComputer_Click(object sender, EventArgs e)
        {
            //вызов диалогового окна создания компьютера
            Computer computer;
            ComputerCreatingForm computerCreatingForm = new ComputerCreatingForm();
            computerCreatingForm.ShowDialog();

            //при подтверждении пользователем - создать новый компьютер, добавить в список менеджера и дерево в интерфейсе
            if (computerCreatingForm.DialogResult == DialogResult.OK)
            {
                computer = computerCreatingForm.GetComputer();
                if (manager.AddComputer(computer))
                {
                    TreeNode node = new TreeNode(computer.ToString(), 0, 0);
                    computerTree.Nodes.Add(node);

                    StatusUpdate();
                } else
                {
                    MessageBox.Show("Компьютер с таким именем уже существует!", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //удаление компьютера
        private void BRemoveComputer_Click(object sender, EventArgs e)
        {
            //если в дереве есть выделенный элемент и это не устройство
            if (computerTree.SelectedNode != null && computerTree.SelectedNode.Parent == null)
            {
                //извлечь информацию из узла в новый объект
                Computer computer = (Computer)computerTree.SelectedNode.Text;

                //если в дереве есть подключенные устройства, добавляем их в новый объект
                foreach(TreeNode a in computerTree.SelectedNode.Nodes)
                {
                    computer.ConnectDevice((Device)a.Text);
                }
                
                //если нет подключенных устройств, удаляем компьютер, иначе - выдать сообщение об ошибке
                if (manager.RemoveComputer(computer))
                {
                    computerTree.Nodes.Remove(computerTree.SelectedNode);

                    StatusUpdate();
                } else
                {
                    MessageBox.Show("Компьютер не может быть удален\nпока к нему подключены устройства!", 
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //подключение устройства
        private void BConnectDevice_Click(object sender, EventArgs e)
        {
            //если выделены и устройство и компьютер (и выделенный узел в дереве действительно компьютер)
            if (LBDevices.SelectedItem != null && computerTree.SelectedNode != null && computerTree.SelectedNode.Parent == null)
            {
                //извлечь информацию об устройстве
                Device deviceToConnect = (Device)LBDevices.SelectedItem;

                //извлечь информацию о компьютере
                Computer computer = (Computer)computerTree.SelectedNode.Text;

                for (int i = 0; i < manager.ComputerCount; i++)
                {
                    if (manager[i].Equals(computer))
                    {
                        computer = manager[i];
                        break;
                    }
                }
                
                //если в компьютере есть порты нужного типа, подключить устройство
                //иначе - выдать сообщение
                if (manager.ConnectDevice(computer, deviceToConnect))
                {
                    TreeNode node = new TreeNode(deviceToConnect.ToString(), 1, 1);
                    computerTree.SelectedNode.Nodes.Add(node);

                    LBDevices.Items.Remove(LBDevices.SelectedItem);

                    StatusUpdate();
                } else
                {
                    MessageBox.Show("В данном компьютере нету свободных портов нужного типа!",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //отчключение устройства
        private void BDisconnectDevice_Click(object sender, EventArgs e)
        {
            if (computerTree.SelectedNode != null && computerTree.SelectedNode.Parent != null)
            {
                //извлечь информацию об устройстве
                Device deviceToDisconnect = (Device)computerTree.SelectedNode.Text;
               
                //извлечь информацию о компьютере
                Computer computer = (Computer)computerTree.SelectedNode.Parent.Text;

                for (int i = 0; i < manager.ComputerCount; i++)
                {
                    if (manager[i].Equals(computer))
                    {
                        computer = manager[i];
                        break;
                    }
                }

                //то же для объекта /**/
                for (int i = 0; i < computer.DevicesCount; i++)
                {
                    if (computer[i].Equals(deviceToDisconnect))
                    {
                        deviceToDisconnect = computer[i];
                        break;
                    }
                }
                
                if (manager.DisconnectDevice(computer, deviceToDisconnect))
                {
                    computerTree.Nodes.Remove(computerTree.SelectedNode);
                    LBDevices.Items.Add(deviceToDisconnect);

                    StatusUpdate();
                }
            }
        }

        //замена устройства
        private void LBDevices_DoubleClick(object sender, EventArgs e)
        {
            //если есть выделенный элемент списка
            if (LBDevices.SelectedItem != null)
            {
                //извлечь информацию об устройстве
                Device device = (Device)LBDevices.SelectedItem;
                
                //вызов диалогового окна создания устройства, с установленными значениями полей
                DeviceCreatingForm deviceCreatingForm = new DeviceCreatingForm(device);
                deviceCreatingForm.ShowDialog();

                //при подтверждении пользователем - заменить устройство
                if (deviceCreatingForm.DialogResult == DialogResult.OK)
                {
                    Device newDevice = deviceCreatingForm.GetDevice();
                    
                    manager.ChangeDevice(device, newDevice);
                    LBDevices.Items[LBDevices.SelectedIndex] = newDevice;

                    StatusUpdate();
                }
            }
        }

        //замена компьютера
        private void ComputerTree_DoubleClick(object sender, EventArgs e)
        {
            //если выделен узел и он не является устройством
            if (computerTree.SelectedNode != null && computerTree.SelectedNode.Parent == null)
            {
                //получение объекта из выбранного узла
                Computer computer = (Computer)computerTree.SelectedNode.Text;
                //узел выбранного компьютера
                TreeNode selected = computerTree.SelectedNode;

                //вызов диалогового окна создания компьютера, с установленными значениями полей
                ComputerCreatingForm computerCreatingForm = new ComputerCreatingForm(computer);
                computerCreatingForm.ShowDialog();

                for (int i = 0; i < manager.ComputerCount; i++)
                {
                    if (manager[i].Equals(computer))
                    {
                        computer = manager[i];
                        break;
                    }

                }

                //при подтверждении пользователем - заменить устройство
                if (computerCreatingForm.DialogResult == DialogResult.OK)
                {
                    Computer newComputer = computerCreatingForm.GetComputer();

                    //коллекция подключенных устройств, которые надо будет отключить при замене компа
                    var devicesToDisconnect = new List<TreeNode>();
                    
                    //собираем устройства для отключения
                    foreach (TreeNode a in selected.Nodes)
                    {
                        Device deviceToDisconnect = (Device)a.Text;

                        // /**/
                        for (int i = 0; i < computer.DevicesCount; i++)
                        {
                            if (computer[i].Equals(deviceToDisconnect))
                            {
                                deviceToDisconnect = computer[i];
                                break;
                            }
                        }

                        //если устройство отключается, добавляем его в список устройств
                        if (manager.DisconnectDevice(computer, deviceToDisconnect))
                        {
                            devicesToDisconnect.Add(a);
                            LBDevices.Items.Add(deviceToDisconnect);
                        }

                    }

                    //убираем накопленные устройства из коллекции
                    foreach (TreeNode a in devicesToDisconnect)
                    {
                        a.Remove();
                    }

                    //заменяем компьютер
                    if (manager.ChangeComputer(computer, newComputer))
                    {
                        computerTree.Nodes.Remove(selected);

                        TreeNode node = new TreeNode(newComputer.ToString(), 0, 0);
                        computerTree.Nodes.Add(node);

                        StatusUpdate();
                    } else
                    {
                        MessageBox.Show("Компьютер с таким именем уже существует!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}