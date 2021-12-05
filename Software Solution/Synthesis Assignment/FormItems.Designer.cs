
namespace Synthesis_Assignment
{
    partial class FormItems
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelEuroSymbole2 = new System.Windows.Forms.Label();
            this.labelEuroSymbole = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.labelRequiredFields = new System.Windows.Forms.Label();
            this.labelRemark = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.labelCosts = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Synthesis_Assignment.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(526, 154);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(597, 88);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(395, 61);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "ADD NEW ITEM";
            // 
            // labelEuroSymbole2
            // 
            this.labelEuroSymbole2.AutoSize = true;
            this.labelEuroSymbole2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEuroSymbole2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelEuroSymbole2.Location = new System.Drawing.Point(705, 592);
            this.labelEuroSymbole2.Name = "labelEuroSymbole2";
            this.labelEuroSymbole2.Size = new System.Drawing.Size(37, 45);
            this.labelEuroSymbole2.TabIndex = 43;
            this.labelEuroSymbole2.Text = "€";
            // 
            // labelEuroSymbole
            // 
            this.labelEuroSymbole.AutoSize = true;
            this.labelEuroSymbole.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEuroSymbole.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelEuroSymbole.Location = new System.Drawing.Point(705, 425);
            this.labelEuroSymbole.Name = "labelEuroSymbole";
            this.labelEuroSymbole.Size = new System.Drawing.Size(37, 45);
            this.labelEuroSymbole.TabIndex = 42;
            this.labelEuroSymbole.Text = "€";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAddItem.Location = new System.Drawing.Point(119, 733);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(1204, 74);
            this.buttonAddItem.TabIndex = 41;
            this.buttonAddItem.Text = "ADD";
            this.buttonAddItem.UseVisualStyleBackColor = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(993, 424);
            this.textBoxRemark.Multiline = true;
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(356, 83);
            this.textBoxRemark.TabIndex = 40;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(993, 281);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(356, 39);
            this.textBoxQuantity.TabIndex = 39;
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Location = new System.Drawing.Point(343, 599);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(356, 39);
            this.textBoxDeposit.TabIndex = 38;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(343, 431);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(356, 39);
            this.textBoxCost.TabIndex = 37;
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(343, 280);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(356, 40);
            this.comboBoxItem.TabIndex = 35;
            // 
            // labelRequiredFields
            // 
            this.labelRequiredFields.AutoSize = true;
            this.labelRequiredFields.Location = new System.Drawing.Point(119, 820);
            this.labelRequiredFields.Name = "labelRequiredFields";
            this.labelRequiredFields.Size = new System.Drawing.Size(190, 32);
            this.labelRequiredFields.TabIndex = 34;
            this.labelRequiredFields.Text = "* Required fields";
            // 
            // labelRemark
            // 
            this.labelRemark.AutoSize = true;
            this.labelRemark.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRemark.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelRemark.Location = new System.Drawing.Point(802, 424);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(126, 45);
            this.labelRemark.TabIndex = 33;
            this.labelRemark.Text = "Remark";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantity.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelQuantity.Location = new System.Drawing.Point(787, 273);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(163, 90);
            this.labelQuantity.TabIndex = 32;
            this.labelQuantity.Text = "Quantity *\r\nAvailable";
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDeposit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelDeposit.Location = new System.Drawing.Point(119, 592);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(160, 90);
            this.labelDeposit.TabIndex = 31;
            this.labelDeposit.Text = "Deposit\r\n(per item)";
            // 
            // labelCosts
            // 
            this.labelCosts.AutoSize = true;
            this.labelCosts.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCosts.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelCosts.Location = new System.Drawing.Point(119, 424);
            this.labelCosts.Name = "labelCosts";
            this.labelCosts.Size = new System.Drawing.Size(165, 90);
            this.labelCosts.TabIndex = 30;
            this.labelCosts.Text = "Cost *\r\n(per 2 hrs)";
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelItem.Location = new System.Drawing.Point(119, 273);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(107, 45);
            this.labelItem.TabIndex = 28;
            this.labelItem.Text = "Item *";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(1366, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(126, 58);
            this.buttonLogout.TabIndex = 45;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(1366, 82);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(126, 58);
            this.buttonBack.TabIndex = 44;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1504, 900);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelEuroSymbole2);
            this.Controls.Add(this.labelEuroSymbole);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.textBoxRemark);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxDeposit);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.labelRequiredFields);
            this.Controls.Add(this.labelRemark);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelDeposit);
            this.Controls.Add(this.labelCosts);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "FormItems";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.FormItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelEuroSymbole2;
        private System.Windows.Forms.Label labelEuroSymbole;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Label labelRequiredFields;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.Label labelCosts;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonBack;
    }
}