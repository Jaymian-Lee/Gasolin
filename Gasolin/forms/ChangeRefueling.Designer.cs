﻿namespace Gasolin.forms
{
    partial class ChangeRefueling
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.DateTimePicker dtpTimeStamp;
        private System.Windows.Forms.TextBox txtLiters;
        private System.Windows.Forms.TextBox txtCurrentKm;
        private System.Windows.Forms.TextBox txtAmountEuro;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.dtpTimeStamp = new System.Windows.Forms.DateTimePicker();
            this.txtLiters = new System.Windows.Forms.TextBox();
            this.txtCurrentKm = new System.Windows.Forms.TextBox();
            this.txtAmountEuro = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Location = new System.Drawing.Point(12, 144);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(200, 24);
            this.cmbVehicle.TabIndex = 0;
            // 
            // cmbPerson
            // 
            this.cmbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(236, 144);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(200, 24);
            this.cmbPerson.TabIndex = 1;
            // 
            // dtpTimeStamp
            // 
            this.dtpTimeStamp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeStamp.Location = new System.Drawing.Point(12, 198);
            this.dtpTimeStamp.Name = "dtpTimeStamp";
            this.dtpTimeStamp.Size = new System.Drawing.Size(200, 22);
            this.dtpTimeStamp.TabIndex = 2;
            // 
            // txtLiters
            // 
            this.txtLiters.Location = new System.Drawing.Point(236, 200);
            this.txtLiters.Name = "txtLiters";
            this.txtLiters.Size = new System.Drawing.Size(200, 22);
            this.txtLiters.TabIndex = 3;
            // 
            // txtCurrentKm
            // 
            this.txtCurrentKm.Location = new System.Drawing.Point(12, 250);
            this.txtCurrentKm.Name = "txtCurrentKm";
            this.txtCurrentKm.Size = new System.Drawing.Size(200, 22);
            this.txtCurrentKm.TabIndex = 4;
            // 
            // txtAmountEuro
            // 
            this.txtAmountEuro.Location = new System.Drawing.Point(236, 250);
            this.txtAmountEuro.Name = "txtAmountEuro";
            this.txtAmountEuro.Size = new System.Drawing.Size(200, 22);
            this.txtAmountEuro.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(300, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 54);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gasolin.Properties.Resources.Gasolin_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 54);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Annuleren";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Prijs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kilometer stand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Aantal liter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Persoon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Voertuig";
            // 
            // ChangeRefueling
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(448, 377);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAmountEuro);
            this.Controls.Add(this.txtCurrentKm);
            this.Controls.Add(this.txtLiters);
            this.Controls.Add(this.dtpTimeStamp);
            this.Controls.Add(this.cmbPerson);
            this.Controls.Add(this.cmbVehicle);
            this.Name = "ChangeRefueling";
            this.Text = "Change Refueling";
            this.Load += new System.EventHandler(this.ChangeRefueling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
