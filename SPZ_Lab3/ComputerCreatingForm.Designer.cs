namespace SPZ_Lab3
{
    partial class ComputerCreatingForm
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
            this.LComputerName = new System.Windows.Forms.Label();
            this.TBComputerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBCOMPorts = new System.Windows.Forms.ComboBox();
            this.CBMICROUSBPorts = new System.Windows.Forms.ComboBox();
            this.CBUSBPorts = new System.Windows.Forms.ComboBox();
            this.BReturnComputer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LComputerName
            // 
            this.LComputerName.AutoSize = true;
            this.LComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LComputerName.Location = new System.Drawing.Point(18, 17);
            this.LComputerName.Name = "LComputerName";
            this.LComputerName.Size = new System.Drawing.Size(142, 20);
            this.LComputerName.TabIndex = 0;
            this.LComputerName.Text = "Имя компьютера:";
            // 
            // TBComputerName
            // 
            this.TBComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBComputerName.Location = new System.Drawing.Point(275, 17);
            this.TBComputerName.MaxLength = 30;
            this.TBComputerName.Name = "TBComputerName";
            this.TBComputerName.Size = new System.Drawing.Size(207, 23);
            this.TBComputerName.TabIndex = 1;
            this.TBComputerName.Text = "MY-PC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество COM-портов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество портов microUSB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество портов USB:";
            // 
            // CBCOMPorts
            // 
            this.CBCOMPorts.DropDownHeight = 112;
            this.CBCOMPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCOMPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCOMPorts.FormattingEnabled = true;
            this.CBCOMPorts.IntegralHeight = false;
            this.CBCOMPorts.ItemHeight = 16;
            this.CBCOMPorts.Location = new System.Drawing.Point(329, 64);
            this.CBCOMPorts.Name = "CBCOMPorts";
            this.CBCOMPorts.Size = new System.Drawing.Size(153, 24);
            this.CBCOMPorts.TabIndex = 5;
            // 
            // CBMICROUSBPorts
            // 
            this.CBMICROUSBPorts.DropDownHeight = 112;
            this.CBMICROUSBPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMICROUSBPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBMICROUSBPorts.FormattingEnabled = true;
            this.CBMICROUSBPorts.IntegralHeight = false;
            this.CBMICROUSBPorts.Location = new System.Drawing.Point(329, 110);
            this.CBMICROUSBPorts.Name = "CBMICROUSBPorts";
            this.CBMICROUSBPorts.Size = new System.Drawing.Size(153, 24);
            this.CBMICROUSBPorts.TabIndex = 6;
            // 
            // CBUSBPorts
            // 
            this.CBUSBPorts.DropDownHeight = 112;
            this.CBUSBPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBUSBPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBUSBPorts.FormattingEnabled = true;
            this.CBUSBPorts.IntegralHeight = false;
            this.CBUSBPorts.Location = new System.Drawing.Point(329, 159);
            this.CBUSBPorts.Name = "CBUSBPorts";
            this.CBUSBPorts.Size = new System.Drawing.Size(153, 24);
            this.CBUSBPorts.TabIndex = 7;
            // 
            // BReturnComputer
            // 
            this.BReturnComputer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BReturnComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BReturnComputer.Location = new System.Drawing.Point(177, 213);
            this.BReturnComputer.Name = "BReturnComputer";
            this.BReturnComputer.Size = new System.Drawing.Size(150, 45);
            this.BReturnComputer.TabIndex = 8;
            this.BReturnComputer.Text = "Применить";
            this.BReturnComputer.UseVisualStyleBackColor = true;
            // 
            // ComputerCreatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 271);
            this.Controls.Add(this.BReturnComputer);
            this.Controls.Add(this.CBUSBPorts);
            this.Controls.Add(this.CBMICROUSBPorts);
            this.Controls.Add(this.CBCOMPorts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBComputerName);
            this.Controls.Add(this.LComputerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComputerCreatingForm";
            this.ShowIcon = false;
            this.Text = "Добавление нового компьютера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LComputerName;
        private System.Windows.Forms.TextBox TBComputerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBCOMPorts;
        private System.Windows.Forms.ComboBox CBMICROUSBPorts;
        private System.Windows.Forms.ComboBox CBUSBPorts;
        private System.Windows.Forms.Button BReturnComputer;
    }
}