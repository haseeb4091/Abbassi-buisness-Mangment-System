
namespace Abbassi_buisness_Mangment_System
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecievePayment = new System.Windows.Forms.Button();
            this.btnAddclient = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addrrom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(284, 135);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1363, 917);
            this.panel.TabIndex = 0;
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(14, 152);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(220, 60);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnRecievePayment);
            this.panel1.Controls.Add(this.btnAddclient);
            this.panel1.Controls.Add(this.btnExpense);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_addrrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 1022);
            this.panel1.TabIndex = 2;
            // 
            // btnRecievePayment
            // 
            this.btnRecievePayment.Location = new System.Drawing.Point(14, 617);
            this.btnRecievePayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecievePayment.Name = "btnRecievePayment";
            this.btnRecievePayment.Size = new System.Drawing.Size(220, 60);
            this.btnRecievePayment.TabIndex = 7;
            this.btnRecievePayment.Text = "Recieve Payments";
            this.btnRecievePayment.UseVisualStyleBackColor = true;
            this.btnRecievePayment.Click += new System.EventHandler(this.btnRecievePayment_Click);
            // 
            // btnAddclient
            // 
            this.btnAddclient.Location = new System.Drawing.Point(14, 518);
            this.btnAddclient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddclient.Name = "btnAddclient";
            this.btnAddclient.Size = new System.Drawing.Size(220, 60);
            this.btnAddclient.TabIndex = 6;
            this.btnAddclient.Text = "Add Client";
            this.btnAddclient.UseVisualStyleBackColor = true;
            this.btnAddclient.Click += new System.EventHandler(this.btnAddclient_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.Location = new System.Drawing.Point(14, 423);
            this.btnExpense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(220, 60);
            this.btnExpense.TabIndex = 5;
            this.btnExpense.Text = "Add Expenses";
            this.btnExpense.UseVisualStyleBackColor = true;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Shops";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addrrom
            // 
            this.btn_addrrom.Location = new System.Drawing.Point(14, 247);
            this.btn_addrrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addrrom.Name = "btn_addrrom";
            this.btn_addrrom.Size = new System.Drawing.Size(220, 60);
            this.btn_addrrom.TabIndex = 3;
            this.btn_addrrom.Text = "Add Room";
            this.btn_addrrom.UseVisualStyleBackColor = true;
            this.btn_addrrom.Click += new System.EventHandler(this.btn_addrrom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abbasi Buisness Center.";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(286, 22);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1361, 103);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1226, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1141, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_addrrom;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddclient;
        private System.Windows.Forms.Button btnRecievePayment;
    }
}

