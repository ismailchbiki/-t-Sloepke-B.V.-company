
namespace Synthesis_Assignment
{
    partial class FormInventory
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
            this.tabControlAdministration = new System.Windows.Forms.TabControl();
            this.tabPageBoats = new System.Windows.Forms.TabPage();
            this.dataGridViewBoats = new System.Windows.Forms.DataGridView();
            this.tabPageItems = new System.Windows.Forms.TabPage();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeleteSelectedRow = new System.Windows.Forms.Button();
            this.tabControlAdministration.SuspendLayout();
            this.tabPageBoats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoats)).BeginInit();
            this.tabPageItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdministration
            // 
            this.tabControlAdministration.Controls.Add(this.tabPageBoats);
            this.tabControlAdministration.Controls.Add(this.tabPageItems);
            this.tabControlAdministration.Font = new System.Drawing.Font("Simplified Arabic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControlAdministration.Location = new System.Drawing.Point(22, 270);
            this.tabControlAdministration.Name = "tabControlAdministration";
            this.tabControlAdministration.SelectedIndex = 0;
            this.tabControlAdministration.Size = new System.Drawing.Size(2018, 796);
            this.tabControlAdministration.TabIndex = 0;
            // 
            // tabPageBoats
            // 
            this.tabPageBoats.Controls.Add(this.dataGridViewBoats);
            this.tabPageBoats.Location = new System.Drawing.Point(8, 59);
            this.tabPageBoats.Name = "tabPageBoats";
            this.tabPageBoats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBoats.Size = new System.Drawing.Size(2002, 729);
            this.tabPageBoats.TabIndex = 0;
            this.tabPageBoats.Text = "BOATS";
            this.tabPageBoats.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBoats
            // 
            this.dataGridViewBoats.AllowUserToOrderColumns = true;
            this.dataGridViewBoats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBoats.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridViewBoats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoats.Location = new System.Drawing.Point(17, 18);
            this.dataGridViewBoats.Name = "dataGridViewBoats";
            this.dataGridViewBoats.RowHeadersWidth = 82;
            this.dataGridViewBoats.RowTemplate.Height = 41;
            this.dataGridViewBoats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBoats.Size = new System.Drawing.Size(1964, 700);
            this.dataGridViewBoats.TabIndex = 0;
            // 
            // tabPageItems
            // 
            this.tabPageItems.Controls.Add(this.dataGridViewItems);
            this.tabPageItems.Location = new System.Drawing.Point(8, 59);
            this.tabPageItems.Name = "tabPageItems";
            this.tabPageItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItems.Size = new System.Drawing.Size(2002, 729);
            this.tabPageItems.TabIndex = 1;
            this.tabPageItems.Text = "ITEMS";
            this.tabPageItems.UseVisualStyleBackColor = true;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToOrderColumns = true;
            this.dataGridViewItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(19, 21);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersWidth = 82;
            this.dataGridViewItems.RowTemplate.Height = 41;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(1964, 700);
            this.dataGridViewItems.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Synthesis_Assignment.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(22, 22);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(526, 154);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(1932, 22);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(126, 58);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(1788, 22);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(126, 58);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Emoji", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(1300, 1081);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(360, 66);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add new";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI Emoji", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.Location = new System.Drawing.Point(1680, 1081);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(360, 66);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update Selected Row";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeleteSelectedRow
            // 
            this.buttonDeleteSelectedRow.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteSelectedRow.Font = new System.Drawing.Font("Segoe UI Emoji", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteSelectedRow.Location = new System.Drawing.Point(1680, 1163);
            this.buttonDeleteSelectedRow.Name = "buttonDeleteSelectedRow";
            this.buttonDeleteSelectedRow.Size = new System.Drawing.Size(360, 66);
            this.buttonDeleteSelectedRow.TabIndex = 9;
            this.buttonDeleteSelectedRow.Text = "Delete Selected Row";
            this.buttonDeleteSelectedRow.UseVisualStyleBackColor = false;
            this.buttonDeleteSelectedRow.Click += new System.EventHandler(this.buttonDeleteSelectedRow_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2070, 1260);
            this.Controls.Add(this.buttonDeleteSelectedRow);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.tabControlAdministration);
            this.Name = "FormInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.tabControlAdministration.ResumeLayout(false);
            this.tabPageBoats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoats)).EndInit();
            this.tabPageItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdministration;
        private System.Windows.Forms.TabPage tabPageBoats;
        private System.Windows.Forms.TabPage tabPageItems;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DataGridView dataGridViewBoats;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDeleteSelectedRow;
    }
}