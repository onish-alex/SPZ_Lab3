namespace SPZ_Lab3
{
    partial class DeviceManagerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BAddComputer = new System.Windows.Forms.Button();
            this.computerTree = new System.Windows.Forms.TreeView();
            this.BRemoveComputer = new System.Windows.Forms.Button();
            this.BAddDevice = new System.Windows.Forms.Button();
            this.BRemoveDevice = new System.Windows.Forms.Button();
            this.BConnectDevice = new System.Windows.Forms.Button();
            this.BArrowLeft = new System.Windows.Forms.Button();
            this.BArrowRight = new System.Windows.Forms.Button();
            this.LDevice = new System.Windows.Forms.Label();
            this.LComputer = new System.Windows.Forms.Label();
            this.BDisconnectDevice = new System.Windows.Forms.Button();
            this.LBDevices = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BAddComputer
            // 
            this.BAddComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddComputer.Location = new System.Drawing.Point(441, 380);
            this.BAddComputer.Name = "BAddComputer";
            this.BAddComputer.Size = new System.Drawing.Size(168, 41);
            this.BAddComputer.TabIndex = 1;
            this.BAddComputer.Text = "ДОБАВИТЬ";
            this.BAddComputer.UseVisualStyleBackColor = true;
            this.BAddComputer.Click += new System.EventHandler(this.BAddComputer_Click);
            // 
            // computerTree
            // 
            this.computerTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computerTree.Location = new System.Drawing.Point(441, 35);
            this.computerTree.Name = "computerTree";
            this.computerTree.Size = new System.Drawing.Size(347, 292);
            this.computerTree.TabIndex = 2;
            this.computerTree.DoubleClick += new System.EventHandler(this.ComputerTree_DoubleClick);
            // 
            // BRemoveComputer
            // 
            this.BRemoveComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRemoveComputer.Location = new System.Drawing.Point(620, 380);
            this.BRemoveComputer.Name = "BRemoveComputer";
            this.BRemoveComputer.Size = new System.Drawing.Size(168, 41);
            this.BRemoveComputer.TabIndex = 4;
            this.BRemoveComputer.Text = "УДАЛИТЬ";
            this.BRemoveComputer.UseVisualStyleBackColor = true;
            this.BRemoveComputer.Click += new System.EventHandler(this.BRemoveComputer_Click);
            // 
            // BAddDevice
            // 
            this.BAddDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddDevice.Location = new System.Drawing.Point(12, 380);
            this.BAddDevice.Name = "BAddDevice";
            this.BAddDevice.Size = new System.Drawing.Size(168, 41);
            this.BAddDevice.TabIndex = 6;
            this.BAddDevice.Text = "ДОБАВИТЬ";
            this.BAddDevice.UseVisualStyleBackColor = true;
            this.BAddDevice.Click += new System.EventHandler(this.BAddDevice_Click);
            // 
            // BRemoveDevice
            // 
            this.BRemoveDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRemoveDevice.Location = new System.Drawing.Point(191, 380);
            this.BRemoveDevice.Name = "BRemoveDevice";
            this.BRemoveDevice.Size = new System.Drawing.Size(168, 41);
            this.BRemoveDevice.TabIndex = 7;
            this.BRemoveDevice.Text = "УДАЛИТЬ";
            this.BRemoveDevice.UseVisualStyleBackColor = true;
            this.BRemoveDevice.Click += new System.EventHandler(this.BRemoveDevice_Click);
            // 
            // BConnectDevice
            // 
            this.BConnectDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BConnectDevice.Location = new System.Drawing.Point(12, 333);
            this.BConnectDevice.Name = "BConnectDevice";
            this.BConnectDevice.Size = new System.Drawing.Size(347, 41);
            this.BConnectDevice.TabIndex = 8;
            this.BConnectDevice.Text = "ПРИСОЕДИНЕНИЕ УСТРОЙСТВА";
            this.BConnectDevice.UseVisualStyleBackColor = true;
            this.BConnectDevice.Click += new System.EventHandler(this.BConnectDevice_Click);
            // 
            // BArrowLeft
            // 
            this.BArrowLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BArrowLeft.Location = new System.Drawing.Point(365, 125);
            this.BArrowLeft.Name = "BArrowLeft";
            this.BArrowLeft.Size = new System.Drawing.Size(70, 44);
            this.BArrowLeft.TabIndex = 9;
            this.BArrowLeft.Text = "<=";
            this.BArrowLeft.UseVisualStyleBackColor = true;
            this.BArrowLeft.Click += new System.EventHandler(this.BDisconnectDevice_Click);
            // 
            // BArrowRight
            // 
            this.BArrowRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BArrowRight.Location = new System.Drawing.Point(365, 175);
            this.BArrowRight.Name = "BArrowRight";
            this.BArrowRight.Size = new System.Drawing.Size(70, 44);
            this.BArrowRight.TabIndex = 10;
            this.BArrowRight.Text = "=>";
            this.BArrowRight.UseVisualStyleBackColor = true;
            this.BArrowRight.Click += new System.EventHandler(this.BConnectDevice_Click);
            // 
            // LDevice
            // 
            this.LDevice.AutoSize = true;
            this.LDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDevice.Location = new System.Drawing.Point(115, 8);
            this.LDevice.Name = "LDevice";
            this.LDevice.Size = new System.Drawing.Size(137, 24);
            this.LDevice.TabIndex = 11;
            this.LDevice.Text = "УСТРОЙСТВА";
            // 
            // LComputer
            // 
            this.LComputer.AutoSize = true;
            this.LComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LComputer.Location = new System.Drawing.Point(546, 8);
            this.LComputer.Name = "LComputer";
            this.LComputer.Size = new System.Drawing.Size(150, 24);
            this.LComputer.TabIndex = 12;
            this.LComputer.Text = "КОМПЬЮТЕРЫ";
            // 
            // BDisconnectDevice
            // 
            this.BDisconnectDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDisconnectDevice.Location = new System.Drawing.Point(441, 333);
            this.BDisconnectDevice.Name = "BDisconnectDevice";
            this.BDisconnectDevice.Size = new System.Drawing.Size(347, 41);
            this.BDisconnectDevice.TabIndex = 13;
            this.BDisconnectDevice.Text = "ОТСОЕДИНЕНИЕ УСТРОЙСТВА";
            this.BDisconnectDevice.UseVisualStyleBackColor = true;
            this.BDisconnectDevice.Click += new System.EventHandler(this.BDisconnectDevice_Click);
            // 
            // LBDevices
            // 
            this.LBDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBDevices.FormattingEnabled = true;
            this.LBDevices.ItemHeight = 18;
            this.LBDevices.Location = new System.Drawing.Point(12, 35);
            this.LBDevices.Name = "LBDevices";
            this.LBDevices.Size = new System.Drawing.Size(347, 292);
            this.LBDevices.TabIndex = 14;
            this.LBDevices.DoubleClick += new System.EventHandler(this.LBDevices_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LStatus);
            this.panel1.Location = new System.Drawing.Point(-1, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 24);
            this.panel1.TabIndex = 15;
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LStatus.Location = new System.Drawing.Point(3, 5);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(38, 13);
            this.LStatus.TabIndex = 0;
            this.LStatus.Text = "qwerty";
            // 
            // DeviceManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBDevices);
            this.Controls.Add(this.BDisconnectDevice);
            this.Controls.Add(this.LComputer);
            this.Controls.Add(this.LDevice);
            this.Controls.Add(this.BArrowRight);
            this.Controls.Add(this.BArrowLeft);
            this.Controls.Add(this.BConnectDevice);
            this.Controls.Add(this.BRemoveDevice);
            this.Controls.Add(this.BAddDevice);
            this.Controls.Add(this.BRemoveComputer);
            this.Controls.Add(this.computerTree);
            this.Controls.Add(this.BAddComputer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DeviceManagerForm";
            this.Text = "Менеджер периферийных устройств";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BAddComputer;
        private System.Windows.Forms.TreeView computerTree;
        private System.Windows.Forms.Button BRemoveComputer;
        private System.Windows.Forms.Button BAddDevice;
        private System.Windows.Forms.Button BRemoveDevice;
        private System.Windows.Forms.Button BConnectDevice;
        private System.Windows.Forms.Button BArrowLeft;
        private System.Windows.Forms.Button BArrowRight;
        private System.Windows.Forms.Label LDevice;
        private System.Windows.Forms.Label LComputer;
        private System.Windows.Forms.Button BDisconnectDevice;
        private System.Windows.Forms.ListBox LBDevices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LStatus;
    }
}

