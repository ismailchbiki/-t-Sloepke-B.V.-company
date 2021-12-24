
namespace Synthesis_Assignment
{
    partial class FormPayment
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
            this.labelQuoteDetails = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelRefNum = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblBoat = new System.Windows.Forms.Label();
            this.lblBoatQuantity = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblRefNum = new System.Windows.Forms.Label();
            this.labelDepositStatus = new System.Windows.Forms.Label();
            this.labelPaymentStatus = new System.Windows.Forms.Label();
            this.lblDepositStatus = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuoteDetails
            // 
            this.labelQuoteDetails.AutoSize = true;
            this.labelQuoteDetails.Font = new System.Drawing.Font("Myanmar Text", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuoteDetails.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelQuoteDetails.Location = new System.Drawing.Point(451, 194);
            this.labelQuoteDetails.Name = "labelQuoteDetails";
            this.labelQuoteDetails.Size = new System.Drawing.Size(252, 65);
            this.labelQuoteDetails.TabIndex = 0;
            this.labelQuoteDetails.Text = "Quote Details";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(1034, 85);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(126, 58);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Synthesis_Assignment.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(315, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(526, 154);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(1034, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(126, 58);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Nirmala UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelLastname.Location = new System.Drawing.Point(57, 295);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(271, 37);
            this.labelLastname.TabIndex = 14;
            this.labelLastname.Text = "Customer Lastname";
            // 
            // labelRefNum
            // 
            this.labelRefNum.AutoSize = true;
            this.labelRefNum.Font = new System.Drawing.Font("Nirmala UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelRefNum.Location = new System.Drawing.Point(57, 349);
            this.labelRefNum.Name = "labelRefNum";
            this.labelRefNum.Size = new System.Drawing.Size(256, 37);
            this.labelRefNum.TabIndex = 15;
            this.labelRefNum.Text = "Reference Number";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Nirmala UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelStartDate.Location = new System.Drawing.Point(71, 459);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(148, 37);
            this.labelStartDate.TabIndex = 16;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Nirmala UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelEndDate.Location = new System.Drawing.Point(71, 523);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(132, 37);
            this.labelEndDate.TabIndex = 17;
            this.labelEndDate.Text = "End Date";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Nirmala UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelLocation.Location = new System.Drawing.Point(71, 589);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(128, 37);
            this.labelLocation.TabIndex = 18;
            this.labelLocation.Text = "Location";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Nirmala UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTotalPrice.Location = new System.Drawing.Point(651, 716);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(152, 37);
            this.labelTotalPrice.TabIndex = 19;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Font = new System.Drawing.Font("Nirmala UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelDeposit.Location = new System.Drawing.Point(71, 716);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(117, 37);
            this.labelDeposit.TabIndex = 20;
            this.labelDeposit.Text = "Deposit";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Nirmala UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelItems.Location = new System.Drawing.Point(651, 459);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(89, 37);
            this.labelItems.TabIndex = 23;
            this.labelItems.Text = "Items";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Nirmala UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelQuantity.Location = new System.Drawing.Point(978, 459);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(129, 37);
            this.labelQuantity.TabIndex = 24;
            this.labelQuantity.Text = "Quantity";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartDate.Location = new System.Drawing.Point(240, 463);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(312, 47);
            this.lblStartDate.TabIndex = 25;
            this.lblStartDate.Text = "2022-01-10 10.00";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndDate.Location = new System.Drawing.Point(240, 528);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(312, 47);
            this.lblEndDate.TabIndex = 26;
            this.lblEndDate.Text = "2022-01-12 10.00";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.Location = new System.Drawing.Point(240, 589);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(122, 47);
            this.lblLocation.TabIndex = 27;
            this.lblLocation.Text = "Renesse";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeposit.Location = new System.Drawing.Point(282, 712);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(95, 47);
            this.lblDeposit.TabIndex = 28;
            this.lblDeposit.Text = "$100";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.Location = new System.Drawing.Point(862, 712);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(95, 47);
            this.lblTotalPrice.TabIndex = 29;
            this.lblTotalPrice.Text = "$500";
            // 
            // lblBoat
            // 
            this.lblBoat.AutoSize = true;
            this.lblBoat.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBoat.Location = new System.Drawing.Point(651, 523);
            this.lblBoat.Name = "lblBoat";
            this.lblBoat.Size = new System.Drawing.Size(102, 47);
            this.lblBoat.TabIndex = 30;
            this.lblBoat.Text = "Canoe";
            // 
            // lblBoatQuantity
            // 
            this.lblBoatQuantity.AutoSize = true;
            this.lblBoatQuantity.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBoatQuantity.Location = new System.Drawing.Point(1034, 523);
            this.lblBoatQuantity.Name = "lblBoatQuantity";
            this.lblBoatQuantity.Size = new System.Drawing.Size(40, 47);
            this.lblBoatQuantity.TabIndex = 31;
            this.lblBoatQuantity.Text = "1";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItem.Location = new System.Drawing.Point(651, 589);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(89, 47);
            this.lblItem.TabIndex = 32;
            this.lblItem.Text = "None";
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemQuantity.Location = new System.Drawing.Point(1034, 589);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(40, 47);
            this.lblItemQuantity.TabIndex = 33;
            this.lblItemQuantity.Text = "0";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(71, 859);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(306, 46);
            this.buttonDeposit.TabIndex = 34;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(651, 859);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(306, 46);
            this.buttonPay.TabIndex = 35;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastname.Location = new System.Drawing.Point(349, 295);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(104, 47);
            this.lblLastname.TabIndex = 36;
            this.lblLastname.Text = "Chbiki";
            // 
            // lblRefNum
            // 
            this.lblRefNum.AutoSize = true;
            this.lblRefNum.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRefNum.Location = new System.Drawing.Point(349, 349);
            this.lblRefNum.Name = "lblRefNum";
            this.lblRefNum.Size = new System.Drawing.Size(237, 47);
            this.lblRefNum.TabIndex = 37;
            this.lblRefNum.Text = "2021-232365";
            // 
            // labelDepositStatus
            // 
            this.labelDepositStatus.AutoSize = true;
            this.labelDepositStatus.Font = new System.Drawing.Font("Nirmala UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelDepositStatus.Location = new System.Drawing.Point(651, 295);
            this.labelDepositStatus.Name = "labelDepositStatus";
            this.labelDepositStatus.Size = new System.Drawing.Size(203, 37);
            this.labelDepositStatus.TabIndex = 38;
            this.labelDepositStatus.Text = "Deposit Status";
            // 
            // labelPaymentStatus
            // 
            this.labelPaymentStatus.AutoSize = true;
            this.labelPaymentStatus.Font = new System.Drawing.Font("Nirmala UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelPaymentStatus.Location = new System.Drawing.Point(651, 350);
            this.labelPaymentStatus.Name = "labelPaymentStatus";
            this.labelPaymentStatus.Size = new System.Drawing.Size(216, 37);
            this.labelPaymentStatus.TabIndex = 39;
            this.labelPaymentStatus.Text = "Payment Status";
            // 
            // lblDepositStatus
            // 
            this.lblDepositStatus.AutoSize = true;
            this.lblDepositStatus.Font = new System.Drawing.Font("Nirmala UI", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDepositStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDepositStatus.Location = new System.Drawing.Point(890, 295);
            this.lblDepositStatus.Name = "lblDepositStatus";
            this.lblDepositStatus.Size = new System.Drawing.Size(130, 40);
            this.lblDepositStatus.TabIndex = 40;
            this.lblDepositStatus.Text = "Pending";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Nirmala UI", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPaymentStatus.Location = new System.Drawing.Point(890, 350);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(130, 40);
            this.lblPaymentStatus.TabIndex = 41;
            this.lblPaymentStatus.Text = "Pending";
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Location = new System.Drawing.Point(71, 790);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(306, 39);
            this.textBoxDeposit.TabIndex = 42;
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(651, 790);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(306, 39);
            this.textBoxPayment.TabIndex = 43;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1172, 976);
            this.Controls.Add(this.textBoxPayment);
            this.Controls.Add(this.textBoxDeposit);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.lblDepositStatus);
            this.Controls.Add(this.labelPaymentStatus);
            this.Controls.Add(this.labelDepositStatus);
            this.Controls.Add(this.lblRefNum);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.lblItemQuantity);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblBoatQuantity);
            this.Controls.Add(this.lblBoat);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.labelDeposit);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelRefNum);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelQuoteDetails);
            this.Name = "FormPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuoteDetails;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelRefNum;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblBoat;
        private System.Windows.Forms.Label lblBoatQuantity;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblRefNum;
        private System.Windows.Forms.Label labelDepositStatus;
        private System.Windows.Forms.Label labelPaymentStatus;
        private System.Windows.Forms.Label lblDepositStatus;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.TextBox textBoxPayment;
    }
}