namespace SPZ_Lab3
{
    partial class DeviceCreatingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LDeviceName = new System.Windows.Forms.Label();
            this.LManufacturer = new System.Windows.Forms.Label();
            this.LDeviceType = new System.Windows.Forms.Label();
            this.LPortType = new System.Windows.Forms.Label();
            this.TBDeviceName = new System.Windows.Forms.TextBox();
            this.TBManufacturer = new System.Windows.Forms.TextBox();
            this.CBDeviceType = new System.Windows.Forms.ComboBox();
            this.CBPortType = new System.Windows.Forms.ComboBox();
            this.BReturnDevice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LDeviceName
            // 
            this.LDeviceName.AutoSize = true;
            this.LDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDeviceName.Location = new System.Drawing.Point(12, 21);
            this.LDeviceName.Name = "LDeviceName";
            this.LDeviceName.Size = new System.Drawing.Size(254, 20);
            this.LDeviceName.TabIndex = 0;
            this.LDeviceName.Text = "Название устройства (модель) :";
            // 
            // LManufacturer
            // 
            this.LManufacturer.AutoSize = true;
            this.LManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LManufacturer.Location = new System.Drawing.Point(12, 63);
            this.LManufacturer.Name = "LManufacturer";
            this.LManufacturer.Size = new System.Drawing.Size(135, 20);
            this.LManufacturer.TabIndex = 1;
            this.LManufacturer.Text = "Производитель:";
            // 
            // LDeviceType
            // 
            this.LDeviceType.AutoSize = true;
            this.LDeviceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDeviceType.Location = new System.Drawing.Point(54, 109);
            this.LDeviceType.Name = "LDeviceType";
            this.LDeviceType.Size = new System.Drawing.Size(126, 20);
            this.LDeviceType.TabIndex = 2;
            this.LDeviceType.Text = "Тип устройства";
            // 
            // LPortType
            // 
            this.LPortType.AutoSize = true;
            this.LPortType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPortType.Location = new System.Drawing.Point(324, 109);
            this.LPortType.Name = "LPortType";
            this.LPortType.Size = new System.Drawing.Size(85, 20);
            this.LPortType.TabIndex = 3;
            this.LPortType.Text = "Тип порта";
            // 
            // TBDeviceName
            // 
            this.TBDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBDeviceName.Location = new System.Drawing.Point(298, 21);
            this.TBDeviceName.MaxLength = 30;
            this.TBDeviceName.Name = "TBDeviceName";
            this.TBDeviceName.Size = new System.Drawing.Size(165, 23);
            this.TBDeviceName.TabIndex = 4;
            this.TBDeviceName.Text = "Model1";
            // 
            // TBManufacturer
            // 
            this.TBManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBManufacturer.Location = new System.Drawing.Point(298, 63);
            this.TBManufacturer.MaxLength = 30;
            this.TBManufacturer.Name = "TBManufacturer";
            this.TBManufacturer.Size = new System.Drawing.Size(165, 23);
            this.TBManufacturer.TabIndex = 5;
            this.TBManufacturer.Text = "Company";
            // 
            // CBDeviceType
            // 
            this.CBDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDeviceType.FormattingEnabled = true;
            this.CBDeviceType.Location = new System.Drawing.Point(58, 143);
            this.CBDeviceType.Name = "CBDeviceType";
            this.CBDeviceType.Size = new System.Drawing.Size(121, 21);
            this.CBDeviceType.TabIndex = 6;
            // 
            // CBPortType
            // 
            this.CBPortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPortType.FormattingEnabled = true;
            this.CBPortType.Location = new System.Drawing.Point(309, 143);
            this.CBPortType.Name = "CBPortType";
            this.CBPortType.Size = new System.Drawing.Size(121, 21);
            this.CBPortType.TabIndex = 7;
            // 
            // BReturnDevice
            // 
            this.BReturnDevice.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BReturnDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BReturnDevice.Location = new System.Drawing.Point(169, 181);
            this.BReturnDevice.Name = "BReturnDevice";
            this.BReturnDevice.Size = new System.Drawing.Size(150, 45);
            this.BReturnDevice.TabIndex = 8;
            this.BReturnDevice.Text = "Применить";
            this.BReturnDevice.UseVisualStyleBackColor = true;
            // 
            // DeviceCreatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 240);
            this.Controls.Add(this.BReturnDevice);
            this.Controls.Add(this.CBPortType);
            this.Controls.Add(this.CBDeviceType);
            this.Controls.Add(this.TBManufacturer);
            this.Controls.Add(this.TBDeviceName);
            this.Controls.Add(this.LPortType);
            this.Controls.Add(this.LDeviceType);
            this.Controls.Add(this.LManufacturer);
            this.Controls.Add(this.LDeviceName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceCreatingForm";
            this.ShowIcon = false;
            this.Text = "Добавление нового устройства";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDeviceName;
        private System.Windows.Forms.Label LManufacturer;
        private System.Windows.Forms.Label LDeviceType;
        private System.Windows.Forms.Label LPortType;
        private System.Windows.Forms.TextBox TBDeviceName;
        private System.Windows.Forms.TextBox TBManufacturer;
        private System.Windows.Forms.ComboBox CBDeviceType;
        private System.Windows.Forms.ComboBox CBPortType;
        private System.Windows.Forms.Button BReturnDevice;
    }
}