
namespace Synthesis_Assignment
{
    partial class FormDashboard
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelAdministration = new System.Windows.Forms.Panel();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonAdministration = new System.Windows.Forms.Button();
            this.buttonExtra = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelAdministration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Synthesis_Assignment.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(159, 36);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(526, 154);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelAdministration
            // 
            this.panelAdministration.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelAdministration.Controls.Add(this.buttonExtra);
            this.panelAdministration.Controls.Add(this.buttonInventory);
            this.panelAdministration.Controls.Add(this.buttonAdministration);
            this.panelAdministration.Location = new System.Drawing.Point(159, 240);
            this.panelAdministration.Name = "panelAdministration";
            this.panelAdministration.Size = new System.Drawing.Size(526, 528);
            this.panelAdministration.TabIndex = 2;
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.Color.Tan;
            this.buttonInventory.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInventory.Location = new System.Drawing.Point(60, 80);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(410, 94);
            this.buttonInventory.TabIndex = 0;
            this.buttonInventory.Text = "INVENTORY";
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonAdministration
            // 
            this.buttonAdministration.BackColor = System.Drawing.Color.Tan;
            this.buttonAdministration.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdministration.Location = new System.Drawing.Point(60, 216);
            this.buttonAdministration.Name = "buttonAdministration";
            this.buttonAdministration.Size = new System.Drawing.Size(410, 94);
            this.buttonAdministration.TabIndex = 1;
            this.buttonAdministration.Text = "ADMINISTRATION";
            this.buttonAdministration.UseVisualStyleBackColor = false;
            // 
            // buttonExtra
            // 
            this.buttonExtra.BackColor = System.Drawing.Color.Tan;
            this.buttonExtra.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExtra.Location = new System.Drawing.Point(60, 350);
            this.buttonExtra.Name = "buttonExtra";
            this.buttonExtra.Size = new System.Drawing.Size(410, 94);
            this.buttonExtra.TabIndex = 2;
            this.buttonExtra.Text = "EXTRA";
            this.buttonExtra.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(700, 36);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(126, 58);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 814);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.panelAdministration);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelAdministration.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelAdministration;
        private System.Windows.Forms.Button buttonExtra;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonAdministration;
        private System.Windows.Forms.Button buttonLogout;
    }
}