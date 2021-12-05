
namespace Synthesis_Assignment
{
    partial class FormSelectOption
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
            this.panelSelectOption = new System.Windows.Forms.Panel();
            this.labelSelectOption = new System.Windows.Forms.Label();
            this.buttonExtra = new System.Windows.Forms.Button();
            this.buttonBoats = new System.Windows.Forms.Button();
            this.buttonItems = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelSelectOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelectOption
            // 
            this.panelSelectOption.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSelectOption.Controls.Add(this.labelSelectOption);
            this.panelSelectOption.Controls.Add(this.buttonExtra);
            this.panelSelectOption.Controls.Add(this.buttonBoats);
            this.panelSelectOption.Controls.Add(this.buttonItems);
            this.panelSelectOption.Location = new System.Drawing.Point(155, 243);
            this.panelSelectOption.Name = "panelSelectOption";
            this.panelSelectOption.Size = new System.Drawing.Size(526, 528);
            this.panelSelectOption.TabIndex = 5;
            // 
            // labelSelectOption
            // 
            this.labelSelectOption.AutoSize = true;
            this.labelSelectOption.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectOption.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelSelectOption.Location = new System.Drawing.Point(134, 14);
            this.labelSelectOption.Name = "labelSelectOption";
            this.labelSelectOption.Size = new System.Drawing.Size(258, 53);
            this.labelSelectOption.TabIndex = 8;
            this.labelSelectOption.Text = "Select Option";
            // 
            // buttonExtra
            // 
            this.buttonExtra.BackColor = System.Drawing.Color.Tan;
            this.buttonExtra.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExtra.Location = new System.Drawing.Point(60, 350);
            this.buttonExtra.Name = "buttonExtra";
            this.buttonExtra.Size = new System.Drawing.Size(410, 94);
            this.buttonExtra.TabIndex = 2;
            this.buttonExtra.Text = "LOCATION";
            this.buttonExtra.UseVisualStyleBackColor = false;
            // 
            // buttonBoats
            // 
            this.buttonBoats.BackColor = System.Drawing.Color.Tan;
            this.buttonBoats.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBoats.Location = new System.Drawing.Point(60, 80);
            this.buttonBoats.Name = "buttonBoats";
            this.buttonBoats.Size = new System.Drawing.Size(410, 94);
            this.buttonBoats.TabIndex = 0;
            this.buttonBoats.Text = "BOAT";
            this.buttonBoats.UseVisualStyleBackColor = false;
            this.buttonBoats.Click += new System.EventHandler(this.buttonBoats_Click);
            // 
            // buttonItems
            // 
            this.buttonItems.BackColor = System.Drawing.Color.Tan;
            this.buttonItems.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonItems.Location = new System.Drawing.Point(60, 216);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(410, 94);
            this.buttonItems.TabIndex = 1;
            this.buttonItems.Text = "ITEM";
            this.buttonItems.UseVisualStyleBackColor = false;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Synthesis_Assignment.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(155, 39);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(526, 154);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(706, 109);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(126, 58);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(706, 39);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(126, 58);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FormSelectOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 814);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.panelSelectOption);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormSelectOption";
            this.Text = "Select Option";
            this.Load += new System.EventHandler(this.FormSelectOption_Load);
            this.panelSelectOption.ResumeLayout(false);
            this.panelSelectOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSelectOption;
        private System.Windows.Forms.Button buttonExtra;
        private System.Windows.Forms.Button buttonBoats;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelSelectOption;
    }
}