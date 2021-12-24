
namespace Synthesis_Assignment
{
    partial class FormFindCustomer
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelDepositPay = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelRefNum = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxRefNum = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(692, 99);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(126, 58);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Synthesis_Assignment.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(151, 26);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(526, 154);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(692, 26);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(126, 58);
            this.buttonLogout.TabIndex = 9;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelDepositPay
            // 
            this.labelDepositPay.AutoSize = true;
            this.labelDepositPay.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelDepositPay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelDepositPay.Location = new System.Drawing.Point(284, 210);
            this.labelDepositPay.Name = "labelDepositPay";
            this.labelDepositPay.Size = new System.Drawing.Size(281, 50);
            this.labelDepositPay.TabIndex = 11;
            this.labelDepositPay.Text = "Seach For Client";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLastname.Location = new System.Drawing.Point(101, 315);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(155, 40);
            this.labelLastname.TabIndex = 12;
            this.labelLastname.Text = "Last Name";
            // 
            // labelRefNum
            // 
            this.labelRefNum.AutoSize = true;
            this.labelRefNum.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRefNum.Location = new System.Drawing.Point(101, 423);
            this.labelRefNum.Name = "labelRefNum";
            this.labelRefNum.Size = new System.Drawing.Size(262, 40);
            this.labelRefNum.TabIndex = 17;
            this.labelRefNum.Text = "Reference Number";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(413, 316);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(324, 52);
            this.textBoxLastName.TabIndex = 18;
            // 
            // textBoxRefNum
            // 
            this.textBoxRefNum.Location = new System.Drawing.Point(413, 410);
            this.textBoxRefNum.Multiline = true;
            this.textBoxRefNum.Name = "textBoxRefNum";
            this.textBoxRefNum.Size = new System.Drawing.Size(324, 53);
            this.textBoxRefNum.TabIndex = 19;
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonFind.Location = new System.Drawing.Point(481, 488);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(196, 62);
            this.buttonFind.TabIndex = 20;
            this.buttonFind.Text = "SEARCH";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // FormFindCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 578);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxRefNum);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelRefNum);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelDepositPay);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonLogout);
            this.Name = "FormFindCustomer";
            this.Text = "Find Customer";
            this.Load += new System.EventHandler(this.FormDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelDepositPay;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelRefNum;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxRefNum;
        private System.Windows.Forms.Button buttonFind;
    }
}