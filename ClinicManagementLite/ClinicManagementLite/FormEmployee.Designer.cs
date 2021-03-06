﻿namespace ClinicManagementLite
{
    partial class FormEmployee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.pickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.imgPerson = new System.Windows.Forms.PictureBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerson)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.pickerDateTime);
            this.groupBox1.Controls.Add(this.btnUploadImage);
            this.groupBox1.Controls.Add(this.imgPerson);
            this.groupBox1.Controls.Add(this.cbxGender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion personal:";
            // 
            // txtLastName
            // 
            this.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastName.Location = new System.Drawing.Point(222, 166);
            this.txtLastName.MaxLength = 40;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ShortcutsEnabled = false;
            this.txtLastName.Size = new System.Drawing.Size(247, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_OnlyText);
            // 
            // pickerDateTime
            // 
            this.pickerDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerDateTime.Location = new System.Drawing.Point(354, 221);
            this.pickerDateTime.Name = "pickerDateTime";
            this.pickerDateTime.Size = new System.Drawing.Size(115, 20);
            this.pickerDateTime.TabIndex = 5;
            this.pickerDateTime.Value = new System.DateTime(2019, 6, 30, 4, 46, 34, 0);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Enabled = false;
            this.btnUploadImage.Location = new System.Drawing.Point(20, 218);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(178, 23);
            this.btnUploadImage.TabIndex = 10;
            this.btnUploadImage.Text = "Cargar imagen";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            // 
            // imgPerson
            // 
            this.imgPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPerson.Location = new System.Drawing.Point(20, 31);
            this.imgPerson.Name = "imgPerson";
            this.imgPerson.Size = new System.Drawing.Size(178, 164);
            this.imgPerson.TabIndex = 15;
            this.imgPerson.TabStop = false;
            // 
            // cbxGender
            // 
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cbxGender.Location = new System.Drawing.Point(354, 50);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(115, 21);
            this.cbxGender.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Genero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Direccion:";
            // 
            // txtAddress
            // 
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress.Location = new System.Drawing.Point(222, 272);
            this.txtAddress.MaxLength = 80;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ShortcutsEnabled = false;
            this.txtAddress.Size = new System.Drawing.Size(247, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Celular:";
            // 
            // txtPhone
            // 
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPhone.Location = new System.Drawing.Point(222, 221);
            this.txtPhone.MaxLength = 9;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ShortcutsEnabled = false;
            this.txtPhone.Size = new System.Drawing.Size(111, 20);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_OnlyNumber);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres:";
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(222, 107);
            this.txtName.MaxLength = 40;
            this.txtName.Name = "txtName";
            this.txtName.ShortcutsEnabled = false;
            this.txtName.Size = new System.Drawing.Size(247, 20);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_OnlyText);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Location = new System.Drawing.Point(222, 50);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.ShortcutsEnabled = false;
            this.txtDni.Size = new System.Drawing.Size(111, 20);
            this.txtDni.TabIndex = 0;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_OnlyNumber);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxPosition);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbxArea);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSalary);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(519, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empleado:";
            // 
            // cbxPosition
            // 
            this.cbxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Location = new System.Drawing.Point(19, 107);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(157, 21);
            this.cbxPosition.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cargo:";
            // 
            // cbxArea
            // 
            this.cbxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Location = new System.Drawing.Point(19, 50);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(157, 21);
            this.cbxArea.TabIndex = 7;
            this.cbxArea.SelectedValueChanged += new System.EventHandler(this.CbxArea_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Area:";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(519, 311);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(200, 23);
            this.btnAction.TabIndex = 9;
            this.btnAction.Text = "Accion";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSalary.Location = new System.Drawing.Point(19, 166);
            this.txtSalary.MaxLength = 20;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ShortcutsEnabled = false;
            this.txtSalary.Size = new System.Drawing.Size(157, 20);
            this.txtSalary.TabIndex = 0;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_OnlyNumber);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Salario:";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 351);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerson)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox imgPerson;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox cbxPosition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker pickerDateTime;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label10;
    }
}