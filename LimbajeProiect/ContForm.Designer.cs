namespace LimbajeProiect
{
    partial class ContForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContForm));
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.btnDeconectUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMesaj = new System.Windows.Forms.Label();
            this.panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsername.Location = new System.Drawing.Point(91, 37);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(91, 20);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelUsername.Controls.Add(this.btnDeconectUser);
            this.panelUsername.Controls.Add(this.pictureBox1);
            this.panelUsername.Controls.Add(this.labelMesaj);
            this.panelUsername.Controls.Add(this.labelUsername);
            this.panelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsername.Location = new System.Drawing.Point(0, 0);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(800, 77);
            this.panelUsername.TabIndex = 1;
            // 
            // btnDeconectUser
            // 
            this.btnDeconectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconectUser.Location = new System.Drawing.Point(670, 20);
            this.btnDeconectUser.Name = "btnDeconectUser";
            this.btnDeconectUser.Size = new System.Drawing.Size(109, 37);
            this.btnDeconectUser.TabIndex = 3;
            this.btnDeconectUser.Text = "DECONECTARE";
            this.btnDeconectUser.UseVisualStyleBackColor = true;
            this.btnDeconectUser.Click += new System.EventHandler(this.BtnDeconectUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelMesaj
            // 
            this.labelMesaj.AutoSize = true;
            this.labelMesaj.Font = new System.Drawing.Font("Digital-7 Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMesaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMesaj.Location = new System.Drawing.Point(92, 20);
            this.labelMesaj.Name = "labelMesaj";
            this.labelMesaj.Size = new System.Drawing.Size(120, 17);
            this.labelMesaj.TabIndex = 1;
            this.labelMesaj.Text = "BINE AI VENIT,";
            // 
            // ContForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.panelUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContForm";
            this.Load += new System.EventHandler(this.ContForm_Load);
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Label labelMesaj;
        private System.Windows.Forms.Button btnDeconectUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}