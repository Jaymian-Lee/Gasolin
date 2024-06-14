namespace Gasolin.forms
{
    partial class RefuelingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lstRefuels;
        private System.Windows.Forms.Button btnAddRefuel;
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
            this.lstRefuels = new System.Windows.Forms.ListView();
            this.btnAddRefuel = new System.Windows.Forms.Button();
            this.CarsButton = new System.Windows.Forms.Button();
            this.btnTank = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnChangeFuelType = new System.Windows.Forms.Button();
            this.btnAddFuelType = new System.Windows.Forms.Button();
            this.lstFuelTypes = new System.Windows.Forms.ListView();
            this.btnRemoveFuel = new System.Windows.Forms.Button();
            this.btnRemoveFuelType = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstRefuels
            // 
            this.lstRefuels.HideSelection = false;
            this.lstRefuels.Location = new System.Drawing.Point(12, 176);
            this.lstRefuels.Name = "lstRefuels";
            this.lstRefuels.Size = new System.Drawing.Size(400, 262);
            this.lstRefuels.TabIndex = 0;
            this.lstRefuels.UseCompatibleStateImageBehavior = false;
            this.lstRefuels.SelectedIndexChanged += new System.EventHandler(this.lstRefuels_SelectedIndexChanged_1);
            this.lstRefuels.DoubleClick += new System.EventHandler(this.lstRefuels_DoubleClick);
            // 
            // btnAddRefuel
            // 
            this.btnAddRefuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRefuel.Location = new System.Drawing.Point(418, 175);
            this.btnAddRefuel.Name = "btnAddRefuel";
            this.btnAddRefuel.Size = new System.Drawing.Size(136, 54);
            this.btnAddRefuel.TabIndex = 1;
            this.btnAddRefuel.Text = "Voeg toe";
            this.btnAddRefuel.UseVisualStyleBackColor = true;
            this.btnAddRefuel.Click += new System.EventHandler(this.btnAddRefuel_Click);
            // 
            // CarsButton
            // 
            this.CarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsButton.Location = new System.Drawing.Point(487, 48);
            this.CarsButton.Name = "CarsButton";
            this.CarsButton.Size = new System.Drawing.Size(136, 54);
            this.CarsButton.TabIndex = 23;
            this.CarsButton.Text = "Cars";
            this.CarsButton.UseVisualStyleBackColor = true;
            this.CarsButton.Click += new System.EventHandler(this.CarsButton_Click);
            // 
            // btnTank
            // 
            this.btnTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTank.Location = new System.Drawing.Point(629, 48);
            this.btnTank.Name = "btnTank";
            this.btnTank.Size = new System.Drawing.Size(136, 54);
            this.btnTank.TabIndex = 22;
            this.btnTank.Text = "Tankbeurt";
            this.btnTank.UseVisualStyleBackColor = true;
            this.btnTank.Click += new System.EventHandler(this.btnTank_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 54);
            this.button1.TabIndex = 21;
            this.button1.Text = "Medewerkers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(418, 235);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(136, 54);
            this.btnChange.TabIndex = 24;
            this.btnChange.Text = "Aanpassen";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnChangeFuelType
            // 
            this.btnChangeFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFuelType.Location = new System.Drawing.Point(802, 235);
            this.btnChangeFuelType.Name = "btnChangeFuelType";
            this.btnChangeFuelType.Size = new System.Drawing.Size(136, 54);
            this.btnChangeFuelType.TabIndex = 27;
            this.btnChangeFuelType.Text = "Aanpassen";
            this.btnChangeFuelType.UseVisualStyleBackColor = true;
            this.btnChangeFuelType.Click += new System.EventHandler(this.btnChangeFuelType_Click);
            // 
            // btnAddFuelType
            // 
            this.btnAddFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFuelType.Location = new System.Drawing.Point(802, 175);
            this.btnAddFuelType.Name = "btnAddFuelType";
            this.btnAddFuelType.Size = new System.Drawing.Size(136, 54);
            this.btnAddFuelType.TabIndex = 26;
            this.btnAddFuelType.Text = "Voeg toe";
            this.btnAddFuelType.UseVisualStyleBackColor = true;
            this.btnAddFuelType.Click += new System.EventHandler(this.btnAddFuelType_Click);
            // 
            // lstFuelTypes
            // 
            this.lstFuelTypes.HideSelection = false;
            this.lstFuelTypes.Location = new System.Drawing.Point(604, 175);
            this.lstFuelTypes.Name = "lstFuelTypes";
            this.lstFuelTypes.Size = new System.Drawing.Size(192, 262);
            this.lstFuelTypes.TabIndex = 25;
            this.lstFuelTypes.UseCompatibleStateImageBehavior = false;
            this.lstFuelTypes.SelectedIndexChanged += new System.EventHandler(this.lstFuelTypes_SelectedIndexChanged);
            // 
            // btnRemoveFuel
            // 
            this.btnRemoveFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFuel.Location = new System.Drawing.Point(418, 295);
            this.btnRemoveFuel.Name = "btnRemoveFuel";
            this.btnRemoveFuel.Size = new System.Drawing.Size(136, 54);
            this.btnRemoveFuel.TabIndex = 28;
            this.btnRemoveFuel.Text = "Verwijderen";
            this.btnRemoveFuel.UseVisualStyleBackColor = true;
            this.btnRemoveFuel.Click += new System.EventHandler(this.btnRemoveFuel_Click);
            // 
            // btnRemoveFuelType
            // 
            this.btnRemoveFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFuelType.Location = new System.Drawing.Point(802, 295);
            this.btnRemoveFuelType.Name = "btnRemoveFuelType";
            this.btnRemoveFuelType.Size = new System.Drawing.Size(136, 54);
            this.btnRemoveFuelType.TabIndex = 29;
            this.btnRemoveFuelType.Text = "Verwijderen";
            this.btnRemoveFuelType.UseVisualStyleBackColor = true;
            this.btnRemoveFuelType.Click += new System.EventHandler(this.btnRemoveFuelType_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gasolin.Properties.Resources.Gasolin_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RefuelingForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.btnRemoveFuelType);
            this.Controls.Add(this.btnRemoveFuel);
            this.Controls.Add(this.btnChangeFuelType);
            this.Controls.Add(this.btnAddFuelType);
            this.Controls.Add(this.lstFuelTypes);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.CarsButton);
            this.Controls.Add(this.btnTank);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddRefuel);
            this.Controls.Add(this.lstRefuels);
            this.Name = "RefuelingForm";
            this.Text = "Refueling Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button CarsButton;
        private System.Windows.Forms.Button btnTank;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnChangeFuelType;
        private System.Windows.Forms.Button btnAddFuelType;
        private System.Windows.Forms.ListView lstFuelTypes;
        private System.Windows.Forms.Button btnRemoveFuel;
        private System.Windows.Forms.Button btnRemoveFuelType;
    }
}
