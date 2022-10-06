
namespace client
{
    partial class frmClient
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
            this.lblClient = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClient.Location = new System.Drawing.Point(348, 24);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(95, 32);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "CLIENT";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(61, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(662, 244);
            this.listBox1.TabIndex = 1;
            // 
            // btnNuovo
            // 
            this.btnNuovo.BackColor = System.Drawing.Color.DarkBlue;
            this.btnNuovo.FlatAppearance.BorderSize = 0;
            this.btnNuovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuovo.ForeColor = System.Drawing.Color.White;
            this.btnNuovo.Location = new System.Drawing.Point(315, 388);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(75, 23);
            this.btnNuovo.TabIndex = 2;
            this.btnNuovo.Text = "NUOVO";
            this.btnNuovo.UseVisualStyleBackColor = false;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.BackColor = System.Drawing.Color.DarkBlue;
            this.btnEsci.FlatAppearance.BorderSize = 0;
            this.btnEsci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsci.ForeColor = System.Drawing.Color.White;
            this.btnEsci.Location = new System.Drawing.Point(414, 388);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 23);
            this.btnEsci.TabIndex = 3;
            this.btnEsci.Text = "ESCI";
            this.btnEsci.UseVisualStyleBackColor = false;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnNuovo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblClient);
            this.Name = "frmClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Button btnEsci;
    }
}

