
namespace Synthesis_Assignment
{
    partial class FormBoats
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBoatType = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelCosts = new System.Windows.Forms.Label();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelRemark = new System.Windows.Forms.Label();
            this.labelAllfieldsRequired = new System.Windows.Forms.Label();
            this.comboBoxBoatType = new System.Windows.Forms.ComboBox();
            this.comboBoxCapacity = new System.Windows.Forms.ComboBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.buttonAddBoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(1360, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(126, 58);
            this.buttonLogout.TabIndex = 10;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Synthesis_Assignment.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(526, 154);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(1360, 82);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(126, 58);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(598, 79);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(410, 61);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "ADD NEW BOAT";
            // 
            // labelBoatType
            // 
            this.labelBoatType.AutoSize = true;
            this.labelBoatType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBoatType.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelBoatType.Location = new System.Drawing.Point(116, 278);
            this.labelBoatType.Name = "labelBoatType";
            this.labelBoatType.Size = new System.Drawing.Size(181, 45);
            this.labelBoatType.TabIndex = 12;
            this.labelBoatType.Text = "Boat Type *";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCapacity.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelCapacity.Location = new System.Drawing.Point(116, 428);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(162, 90);
            this.labelCapacity.TabIndex = 13;
            this.labelCapacity.Text = "Capacity *\r\n(per boat)";
            // 
            // labelCosts
            // 
            this.labelCosts.AutoSize = true;
            this.labelCosts.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCosts.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelCosts.Location = new System.Drawing.Point(116, 604);
            this.labelCosts.Name = "labelCosts";
            this.labelCosts.Size = new System.Drawing.Size(165, 90);
            this.labelCosts.TabIndex = 14;
            this.labelCosts.Text = "Cost *\r\n(per 2 hrs)";
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDeposit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelDeposit.Location = new System.Drawing.Point(760, 278);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(161, 90);
            this.labelDeposit.TabIndex = 15;
            this.labelDeposit.Text = "Deposit *\r\n(per boat)";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantity.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelQuantity.Location = new System.Drawing.Point(758, 428);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(163, 90);
            this.labelQuantity.TabIndex = 16;
            this.labelQuantity.Text = "Quantity *\r\nAvailable";
            // 
            // labelRemark
            // 
            this.labelRemark.AutoSize = true;
            this.labelRemark.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRemark.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelRemark.Location = new System.Drawing.Point(758, 604);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(148, 45);
            this.labelRemark.TabIndex = 17;
            this.labelRemark.Text = "Remark *";
            // 
            // labelAllfieldsRequired
            // 
            this.labelAllfieldsRequired.AutoSize = true;
            this.labelAllfieldsRequired.Location = new System.Drawing.Point(116, 825);
            this.labelAllfieldsRequired.Name = "labelAllfieldsRequired";
            this.labelAllfieldsRequired.Size = new System.Drawing.Size(259, 32);
            this.labelAllfieldsRequired.TabIndex = 18;
            this.labelAllfieldsRequired.Text = "* All fields are required";
            // 
            // comboBoxBoatType
            // 
            this.comboBoxBoatType.FormattingEnabled = true;
            this.comboBoxBoatType.Location = new System.Drawing.Point(340, 285);
            this.comboBoxBoatType.Name = "comboBoxBoatType";
            this.comboBoxBoatType.Size = new System.Drawing.Size(356, 40);
            this.comboBoxBoatType.TabIndex = 19;
            // 
            // comboBoxCapacity
            // 
            this.comboBoxCapacity.FormattingEnabled = true;
            this.comboBoxCapacity.Location = new System.Drawing.Point(340, 435);
            this.comboBoxCapacity.Name = "comboBoxCapacity";
            this.comboBoxCapacity.Size = new System.Drawing.Size(356, 40);
            this.comboBoxCapacity.TabIndex = 20;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(340, 611);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(356, 39);
            this.textBoxCost.TabIndex = 21;
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Location = new System.Drawing.Point(964, 286);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(356, 39);
            this.textBoxDeposit.TabIndex = 22;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(964, 436);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(356, 39);
            this.textBoxQuantity.TabIndex = 23;
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(964, 611);
            this.textBoxRemark.Multiline = true;
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(356, 83);
            this.textBoxRemark.TabIndex = 24;
            // 
            // buttonAddBoat
            // 
            this.buttonAddBoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAddBoat.Location = new System.Drawing.Point(116, 738);
            this.buttonAddBoat.Name = "buttonAddBoat";
            this.buttonAddBoat.Size = new System.Drawing.Size(1204, 74);
            this.buttonAddBoat.TabIndex = 25;
            this.buttonAddBoat.Text = "ADD";
            this.buttonAddBoat.UseVisualStyleBackColor = false;
            this.buttonAddBoat.Click += new System.EventHandler(this.buttonAddBoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(702, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 45);
            this.label1.TabIndex = 26;
            this.label1.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(1326, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 45);
            this.label2.TabIndex = 27;
            this.label2.Text = "€";
            // 
            // FormBoats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1504, 900);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddBoat);
            this.Controls.Add(this.textBoxRemark);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxDeposit);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.comboBoxCapacity);
            this.Controls.Add(this.comboBoxBoatType);
            this.Controls.Add(this.labelAllfieldsRequired);
            this.Controls.Add(this.labelRemark);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelDeposit);
            this.Controls.Add(this.labelCosts);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelBoatType);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormBoats";
            this.Text = "Add Boat";
            this.Load += new System.EventHandler(this.FormAddBoat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBoatType;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelCosts;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.Label labelAllfieldsRequired;
        private System.Windows.Forms.ComboBox comboBoxBoatType;
        private System.Windows.Forms.ComboBox comboBoxCapacity;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.Button buttonAddBoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}