namespace Gasolin.forms
{
    partial class CarsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            this.lstCars = new System.Windows.Forms.ListView();
            this.btnTank = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.CarsButton = new System.Windows.Forms.Button();
            this.lstVehicleType = new System.Windows.Forms.ListView();
            this.btnRemoveVehicleType = new System.Windows.Forms.Button();
            this.btnChangeVehicleType = new System.Windows.Forms.Button();
            this.btnAddVehicleType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCars
            // 
            this.lstCars.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstCars.HideSelection = false;
            this.lstCars.Location = new System.Drawing.Point(12, 176);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(422, 262);
            this.lstCars.TabIndex = 15;
            this.lstCars.UseCompatibleStateImageBehavior = false;
            // 
            // btnTank
            // 
            this.btnTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTank.Location = new System.Drawing.Point(767, 48);
            this.btnTank.Name = "btnTank";
            this.btnTank.Size = new System.Drawing.Size(136, 54);
            this.btnTank.TabIndex = 13;
            this.btnTank.Text = "Tankbeurt";
            this.btnTank.UseVisualStyleBackColor = true;
            this.btnTank.Click += new System.EventHandler(this.btnTank_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerson.Location = new System.Drawing.Point(483, 48);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(136, 54);
            this.btnPerson.TabIndex = 11;
            this.btnPerson.Text = "Medewerkers";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(465, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 54);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Voeg toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(465, 236);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 54);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Aanpassen";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(465, 296);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 54);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Verwijder";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // CarsButton
            // 
            this.CarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsButton.Location = new System.Drawing.Point(625, 48);
            this.CarsButton.Name = "CarsButton";
            this.CarsButton.Size = new System.Drawing.Size(136, 54);
            this.CarsButton.TabIndex = 20;
            this.CarsButton.Text = "Cars";
            this.CarsButton.UseVisualStyleBackColor = true;
            this.CarsButton.Click += new System.EventHandler(this.CarsButton_Click);
            // 
            // lstVehicleType
            // 
            this.lstVehicleType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstVehicleType.HideSelection = false;
            this.lstVehicleType.Location = new System.Drawing.Point(625, 176);
            this.lstVehicleType.Name = "lstVehicleType";
            this.lstVehicleType.Size = new System.Drawing.Size(141, 262);
            this.lstVehicleType.TabIndex = 21;
            this.lstVehicleType.UseCompatibleStateImageBehavior = false;
            this.lstVehicleType.SelectedIndexChanged += new System.EventHandler(this.lstVehicleType_SelectedIndexChanged);
            // 
            // btnRemoveVehicleType
            // 
            this.btnRemoveVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveVehicleType.Location = new System.Drawing.Point(792, 296);
            this.btnRemoveVehicleType.Name = "btnRemoveVehicleType";
            this.btnRemoveVehicleType.Size = new System.Drawing.Size(136, 54);
            this.btnRemoveVehicleType.TabIndex = 24;
            this.btnRemoveVehicleType.Text = "Verwijder";
            this.btnRemoveVehicleType.UseVisualStyleBackColor = true;
            this.btnRemoveVehicleType.Click += new System.EventHandler(this.btnRemoveVehicleType_Click);
            // 
            // btnChangeVehicleType
            // 
            this.btnChangeVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeVehicleType.Location = new System.Drawing.Point(792, 236);
            this.btnChangeVehicleType.Name = "btnChangeVehicleType";
            this.btnChangeVehicleType.Size = new System.Drawing.Size(136, 54);
            this.btnChangeVehicleType.TabIndex = 23;
            this.btnChangeVehicleType.Text = "Aanpassen";
            this.btnChangeVehicleType.UseVisualStyleBackColor = true;
            this.btnChangeVehicleType.Click += new System.EventHandler(this.btnChangeVehicleType_Click);
            // 
            // btnAddVehicleType
            // 
            this.btnAddVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicleType.Location = new System.Drawing.Point(792, 176);
            this.btnAddVehicleType.Name = "btnAddVehicleType";
            this.btnAddVehicleType.Size = new System.Drawing.Size(136, 54);
            this.btnAddVehicleType.TabIndex = 22;
            this.btnAddVehicleType.Text = "Voeg toe";
            this.btnAddVehicleType.UseVisualStyleBackColor = true;
            this.btnAddVehicleType.Click += new System.EventHandler(this.btnAddVehicleType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Voertuigen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Voertuig types";
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveVehicleType);
            this.Controls.Add(this.btnChangeVehicleType);
            this.Controls.Add(this.btnAddVehicleType);
            this.Controls.Add(this.lstVehicleType);
            this.Controls.Add(this.CarsButton);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.btnTank);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarsForm";
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCars;
        private System.Windows.Forms.Button btnTank;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button CarsButton;
        private System.Windows.Forms.ListView lstVehicleType;
        private System.Windows.Forms.Button btnRemoveVehicleType;
        private System.Windows.Forms.Button btnChangeVehicleType;
        private System.Windows.Forms.Button btnAddVehicleType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}