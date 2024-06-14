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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CarsButton = new System.Windows.Forms.Button();
            this.btnTank = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstRefuels
            // 
            this.lstRefuels.HideSelection = false;
            this.lstRefuels.Location = new System.Drawing.Point(12, 176);
            this.lstRefuels.Name = "lstRefuels";
            this.lstRefuels.Size = new System.Drawing.Size(558, 262);
            this.lstRefuels.TabIndex = 0;
            this.lstRefuels.UseCompatibleStateImageBehavior = false;
            this.lstRefuels.SelectedIndexChanged += new System.EventHandler(this.lstRefuels_SelectedIndexChanged_1);
            this.lstRefuels.DoubleClick += new System.EventHandler(this.lstRefuels_DoubleClick);
            // 
            // btnAddRefuel
            // 
            this.btnAddRefuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRefuel.Location = new System.Drawing.Point(629, 176);
            this.btnAddRefuel.Name = "btnAddRefuel";
            this.btnAddRefuel.Size = new System.Drawing.Size(136, 54);
            this.btnAddRefuel.TabIndex = 1;
            this.btnAddRefuel.Text = "Voeg toe";
            this.btnAddRefuel.UseVisualStyleBackColor = true;
            this.btnAddRefuel.Click += new System.EventHandler(this.btnAddRefuel_Click);
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
            this.btnChange.Location = new System.Drawing.Point(629, 236);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(136, 54);
            this.btnChange.TabIndex = 24;
            this.btnChange.Text = "Aanpassen";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // RefuelingForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}
