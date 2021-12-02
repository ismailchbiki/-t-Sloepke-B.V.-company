
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
            this.buttonCrud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCrud
            // 
            this.buttonCrud.Location = new System.Drawing.Point(311, 196);
            this.buttonCrud.Name = "buttonCrud";
            this.buttonCrud.Size = new System.Drawing.Size(150, 46);
            this.buttonCrud.TabIndex = 0;
            this.buttonCrud.Text = "CRUD";
            this.buttonCrud.UseVisualStyleBackColor = true;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCrud);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCrud;
    }
}