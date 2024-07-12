namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class TransactionDetails
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionDetails));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            RoundedCornerElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            HeaderBox = new Guna.UI2.WinForms.Guna2ResizeBox();
            Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            panel1 = new Panel();
            HeaderText = new Label();
            TransactionNoText = new Label();
            TransactionTypeText = new Label();
            TransactionNameText = new Label();
            GuestNameText = new Label();
            EmailText = new Label();
            ContactNumberText = new Label();
            DateOfPaymentText = new Label();
            PaymentMethodText = new Label();
            AmountPaidText = new Label();
            PaymentReferenceText = new Label();
            BalanceText = new Label();
            AmountPaid2Text = new Label();
            TotalAmountText = new Label();
            AdditionalChargesText = new Label();
            TaxesText = new Label();
            ServiceChargeText = new Label();
            RoomRateText = new Label();
            CheckOutDateText = new Label();
            CheckInDateText = new Label();
            RoomTypeText = new Label();
            LengthOfStayText = new Label();
            Email = new Label();
            ContactNumber = new Label();
            GuestName = new Label();
            DateOfPayment = new Label();
            PaymentMethod = new Label();
            AmountPaid = new Label();
            PaymentReference = new Label();
            TransactionName = new Label();
            TransactionType = new Label();
            TransactionNo = new Label();
            RoomType = new Label();
            CheckInDate = new Label();
            CheckOutDate = new Label();
            Balance = new Label();
            AmountPaid2 = new Label();
            TotalAmount = new Label();
            LengthOfStay = new Label();
            RoomRate = new Label();
            Taxes = new Label();
            ServiceCharge = new Label();
            AdditionalCharges = new Label();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // RoundedCornerElipse
            // 
            RoundedCornerElipse.BorderRadius = 25;
            RoundedCornerElipse.TargetControl = this;
            // 
            // HeaderBox
            // 
            HeaderBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            HeaderBox.BackColor = Color.FromArgb(13, 22, 29);
            HeaderBox.FillColor = Color.Transparent;
            HeaderBox.ForeColor = Color.Black;
            HeaderBox.Location = new Point(-8, -25);
            HeaderBox.Name = "HeaderBox";
            HeaderBox.Size = new Size(1179, 150);
            HeaderBox.TabIndex = 8;
            // 
            // Logo
            // 
            Logo.BackColor = Color.FromArgb(13, 22, 29);
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Stretch;
            Logo.CustomizableEdges = customizableEdges1;
            Logo.FillColor = Color.Transparent;
            Logo.ImageRotate = 0F;
            Logo.Location = new Point(465, 0);
            Logo.Name = "Logo";
            Logo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Logo.Size = new Size(220, 125);
            Logo.TabIndex = 9;
            Logo.TabStop = false;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(576, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 444);
            panel1.TabIndex = 56;
            // 
            // HeaderText
            // 
            HeaderText.AutoSize = true;
            HeaderText.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderText.Location = new Point(465, 140);
            HeaderText.Name = "HeaderText";
            HeaderText.Size = new Size(229, 28);
            HeaderText.TabIndex = 57;
            HeaderText.Text = "Transaction Details";
            // 
            // TransactionNoText
            // 
            TransactionNoText.AutoSize = true;
            TransactionNoText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TransactionNoText.Location = new Point(117, 206);
            TransactionNoText.Name = "TransactionNoText";
            TransactionNoText.Size = new Size(120, 20);
            TransactionNoText.TabIndex = 58;
            TransactionNoText.Text = "Transaction No.";
            // 
            // TransactionTypeText
            // 
            TransactionTypeText.AutoSize = true;
            TransactionTypeText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TransactionTypeText.Location = new Point(117, 237);
            TransactionTypeText.Name = "TransactionTypeText";
            TransactionTypeText.Size = new Size(128, 20);
            TransactionTypeText.TabIndex = 59;
            TransactionTypeText.Text = "Transaction Type";
            // 
            // TransactionNameText
            // 
            TransactionNameText.AutoSize = true;
            TransactionNameText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TransactionNameText.Location = new Point(117, 268);
            TransactionNameText.Name = "TransactionNameText";
            TransactionNameText.Size = new Size(139, 20);
            TransactionNameText.TabIndex = 60;
            TransactionNameText.Text = "Transaction Name";
            // 
            // GuestNameText
            // 
            GuestNameText.AutoSize = true;
            GuestNameText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuestNameText.Location = new Point(117, 348);
            GuestNameText.Name = "GuestNameText";
            GuestNameText.Size = new Size(100, 20);
            GuestNameText.TabIndex = 61;
            GuestNameText.Text = "Guest Name";
            // 
            // EmailText
            // 
            EmailText.AutoSize = true;
            EmailText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailText.Location = new Point(117, 410);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(46, 20);
            EmailText.TabIndex = 63;
            EmailText.Text = "Email";
            // 
            // ContactNumberText
            // 
            ContactNumberText.AutoSize = true;
            ContactNumberText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactNumberText.Location = new Point(117, 379);
            ContactNumberText.Name = "ContactNumberText";
            ContactNumberText.Size = new Size(132, 20);
            ContactNumberText.TabIndex = 64;
            ContactNumberText.Text = "Contact Number";
            // 
            // DateOfPaymentText
            // 
            DateOfPaymentText.AutoSize = true;
            DateOfPaymentText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateOfPaymentText.Location = new Point(117, 486);
            DateOfPaymentText.Name = "DateOfPaymentText";
            DateOfPaymentText.Size = new Size(132, 20);
            DateOfPaymentText.TabIndex = 65;
            DateOfPaymentText.Text = "Date of Payment";
            // 
            // PaymentMethodText
            // 
            PaymentMethodText.AutoSize = true;
            PaymentMethodText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentMethodText.Location = new Point(117, 516);
            PaymentMethodText.Name = "PaymentMethodText";
            PaymentMethodText.Size = new Size(136, 20);
            PaymentMethodText.TabIndex = 66;
            PaymentMethodText.Text = "Payment Method";
            // 
            // AmountPaidText
            // 
            AmountPaidText.AutoSize = true;
            AmountPaidText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountPaidText.Location = new Point(117, 549);
            AmountPaidText.Name = "AmountPaidText";
            AmountPaidText.Size = new Size(102, 20);
            AmountPaidText.TabIndex = 67;
            AmountPaidText.Text = "Amount Paid";
            // 
            // PaymentReferenceText
            // 
            PaymentReferenceText.AutoSize = true;
            PaymentReferenceText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentReferenceText.Location = new Point(117, 580);
            PaymentReferenceText.Name = "PaymentReferenceText";
            PaymentReferenceText.Size = new Size(155, 20);
            PaymentReferenceText.TabIndex = 68;
            PaymentReferenceText.Text = "Payment Reference";
            // 
            // BalanceText
            // 
            BalanceText.AutoSize = true;
            BalanceText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BalanceText.Location = new Point(702, 576);
            BalanceText.Name = "BalanceText";
            BalanceText.Size = new Size(70, 20);
            BalanceText.TabIndex = 78;
            BalanceText.Text = "Balance";
            // 
            // AmountPaid2Text
            // 
            AmountPaid2Text.AutoSize = true;
            AmountPaid2Text.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountPaid2Text.Location = new Point(702, 545);
            AmountPaid2Text.Name = "AmountPaid2Text";
            AmountPaid2Text.Size = new Size(102, 20);
            AmountPaid2Text.TabIndex = 77;
            AmountPaid2Text.Text = "Amount Paid";
            // 
            // TotalAmountText
            // 
            TotalAmountText.AutoSize = true;
            TotalAmountText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalAmountText.Location = new Point(702, 512);
            TotalAmountText.Name = "TotalAmountText";
            TotalAmountText.Size = new Size(103, 20);
            TotalAmountText.TabIndex = 76;
            TotalAmountText.Text = "Total Amount";
            // 
            // AdditionalChargesText
            // 
            AdditionalChargesText.AutoSize = true;
            AdditionalChargesText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdditionalChargesText.Location = new Point(702, 445);
            AdditionalChargesText.Name = "AdditionalChargesText";
            AdditionalChargesText.Size = new Size(149, 20);
            AdditionalChargesText.TabIndex = 75;
            AdditionalChargesText.Text = "Additional Charges";
            // 
            // TaxesText
            // 
            TaxesText.AutoSize = true;
            TaxesText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaxesText.Location = new Point(702, 384);
            TaxesText.Name = "TaxesText";
            TaxesText.Size = new Size(47, 20);
            TaxesText.TabIndex = 74;
            TaxesText.Text = "Taxes";
            // 
            // ServiceChargeText
            // 
            ServiceChargeText.AutoSize = true;
            ServiceChargeText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ServiceChargeText.Location = new Point(702, 415);
            ServiceChargeText.Name = "ServiceChargeText";
            ServiceChargeText.Size = new Size(124, 20);
            ServiceChargeText.TabIndex = 73;
            ServiceChargeText.Text = "Service Charge";
            // 
            // RoomRateText
            // 
            RoomRateText.AutoSize = true;
            RoomRateText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomRateText.Location = new Point(702, 357);
            RoomRateText.Name = "RoomRateText";
            RoomRateText.Size = new Size(89, 20);
            RoomRateText.TabIndex = 72;
            RoomRateText.Text = "Room Rate";
            // 
            // CheckOutDateText
            // 
            CheckOutDateText.AutoSize = true;
            CheckOutDateText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckOutDateText.Location = new Point(702, 264);
            CheckOutDateText.Name = "CheckOutDateText";
            CheckOutDateText.Size = new Size(127, 20);
            CheckOutDateText.TabIndex = 71;
            CheckOutDateText.Text = "Check-out Date";
            // 
            // CheckInDateText
            // 
            CheckInDateText.AutoSize = true;
            CheckInDateText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckInDateText.Location = new Point(702, 233);
            CheckInDateText.Name = "CheckInDateText";
            CheckInDateText.Size = new Size(115, 20);
            CheckInDateText.TabIndex = 70;
            CheckInDateText.Text = "Check-in Date";
            // 
            // RoomTypeText
            // 
            RoomTypeText.AutoSize = true;
            RoomTypeText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomTypeText.Location = new Point(702, 202);
            RoomTypeText.Name = "RoomTypeText";
            RoomTypeText.Size = new Size(88, 20);
            RoomTypeText.TabIndex = 69;
            RoomTypeText.Text = "Room Type";
            // 
            // LengthOfStayText
            // 
            LengthOfStayText.AutoSize = true;
            LengthOfStayText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LengthOfStayText.Location = new Point(702, 293);
            LengthOfStayText.Name = "LengthOfStayText";
            LengthOfStayText.Size = new Size(112, 20);
            LengthOfStayText.TabIndex = 79;
            LengthOfStayText.Text = "Length of Stay";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email.Location = new Point(286, 410);
            Email.Name = "Email";
            Email.Size = new Size(161, 18);
            Email.TabIndex = 80;
            Email.Text = "johndoe@gmail.com";
            // 
            // ContactNumber
            // 
            ContactNumber.AutoSize = true;
            ContactNumber.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactNumber.Location = new Point(286, 380);
            ContactNumber.Name = "ContactNumber";
            ContactNumber.Size = new Size(113, 18);
            ContactNumber.TabIndex = 81;
            ContactNumber.Text = "+639123456789";
            // 
            // GuestName
            // 
            GuestName.AutoSize = true;
            GuestName.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GuestName.Location = new Point(286, 348);
            GuestName.Name = "GuestName";
            GuestName.Size = new Size(78, 18);
            GuestName.TabIndex = 82;
            GuestName.Text = "John Doe";
            // 
            // DateOfPayment
            // 
            DateOfPayment.AutoSize = true;
            DateOfPayment.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateOfPayment.Location = new Point(286, 488);
            DateOfPayment.Name = "DateOfPayment";
            DateOfPayment.Size = new Size(117, 18);
            DateOfPayment.TabIndex = 83;
            DateOfPayment.Text = "August 08, 2024";
            // 
            // PaymentMethod
            // 
            PaymentMethod.AutoSize = true;
            PaymentMethod.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentMethod.Location = new Point(286, 517);
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.Size = new Size(94, 18);
            PaymentMethod.TabIndex = 84;
            PaymentMethod.Text = "Credit Card";
            // 
            // AmountPaid
            // 
            AmountPaid.AutoSize = true;
            AmountPaid.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AmountPaid.Location = new Point(286, 550);
            AmountPaid.Name = "AmountPaid";
            AmountPaid.Size = new Size(95, 18);
            AmountPaid.TabIndex = 85;
            AmountPaid.Text = "Php 5,000.00";
            // 
            // PaymentReference
            // 
            PaymentReference.AutoSize = true;
            PaymentReference.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentReference.Location = new Point(286, 581);
            PaymentReference.Name = "PaymentReference";
            PaymentReference.Size = new Size(65, 18);
            PaymentReference.TabIndex = 86;
            PaymentReference.Text = "SRNTL01";
            // 
            // TransactionName
            // 
            TransactionName.AutoSize = true;
            TransactionName.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransactionName.Location = new Point(286, 270);
            TransactionName.Name = "TransactionName";
            TransactionName.Size = new Size(124, 18);
            TransactionName.TabIndex = 87;
            TransactionName.Text = "Reservation Fee";
            // 
            // TransactionType
            // 
            TransactionType.AutoSize = true;
            TransactionType.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransactionType.Location = new Point(286, 239);
            TransactionType.Name = "TransactionType";
            TransactionType.Size = new Size(72, 18);
            TransactionType.TabIndex = 88;
            TransactionType.Text = "Payment";
            // 
            // TransactionNo
            // 
            TransactionNo.AutoSize = true;
            TransactionNo.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransactionNo.Location = new Point(286, 208);
            TransactionNo.Name = "TransactionNo";
            TransactionNo.Size = new Size(40, 18);
            TransactionNo.TabIndex = 89;
            TransactionNo.Text = "1000";
            // 
            // RoomType
            // 
            RoomType.AutoSize = true;
            RoomType.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomType.Location = new Point(876, 204);
            RoomType.Name = "RoomType";
            RoomType.Size = new Size(139, 18);
            RoomType.TabIndex = 99;
            RoomType.Text = "Master’s Bedroom";
            // 
            // CheckInDate
            // 
            CheckInDate.AutoSize = true;
            CheckInDate.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckInDate.Location = new Point(876, 235);
            CheckInDate.Name = "CheckInDate";
            CheckInDate.Size = new Size(117, 18);
            CheckInDate.TabIndex = 98;
            CheckInDate.Text = "August 11, 2024";
            // 
            // CheckOutDate
            // 
            CheckOutDate.AutoSize = true;
            CheckOutDate.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckOutDate.Location = new Point(876, 266);
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.Size = new Size(117, 18);
            CheckOutDate.TabIndex = 97;
            CheckOutDate.Text = "August 09, 2024";
            // 
            // Balance
            // 
            Balance.AutoSize = true;
            Balance.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Balance.Location = new Point(876, 577);
            Balance.Name = "Balance";
            Balance.Size = new Size(95, 18);
            Balance.TabIndex = 96;
            Balance.Text = "Php 2,500.00";
            // 
            // AmountPaid2
            // 
            AmountPaid2.AutoSize = true;
            AmountPaid2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AmountPaid2.Location = new Point(876, 546);
            AmountPaid2.Name = "AmountPaid2";
            AmountPaid2.Size = new Size(95, 18);
            AmountPaid2.TabIndex = 95;
            AmountPaid2.Text = "Php 2,500.00";
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSize = true;
            TotalAmount.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalAmount.Location = new Point(876, 513);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Size = new Size(95, 18);
            TotalAmount.TabIndex = 94;
            TotalAmount.Text = "Php 5,100.00";
            // 
            // LengthOfStay
            // 
            LengthOfStay.AutoSize = true;
            LengthOfStay.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LengthOfStay.Location = new Point(876, 295);
            LengthOfStay.Name = "LengthOfStay";
            LengthOfStay.Size = new Size(16, 18);
            LengthOfStay.TabIndex = 92;
            LengthOfStay.Text = "3";
            // 
            // RoomRate
            // 
            RoomRate.AutoSize = true;
            RoomRate.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomRate.Location = new Point(876, 359);
            RoomRate.Name = "RoomRate";
            RoomRate.Size = new Size(95, 18);
            RoomRate.TabIndex = 91;
            RoomRate.Text = "Php 2,455.00";
            // 
            // Taxes
            // 
            Taxes.AutoSize = true;
            Taxes.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Taxes.Location = new Point(876, 386);
            Taxes.Name = "Taxes";
            Taxes.Size = new Size(83, 18);
            Taxes.TabIndex = 90;
            Taxes.Text = "Php 100.00";
            // 
            // ServiceCharge
            // 
            ServiceCharge.AutoSize = true;
            ServiceCharge.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ServiceCharge.Location = new Point(876, 417);
            ServiceCharge.Name = "ServiceCharge";
            ServiceCharge.Size = new Size(67, 18);
            ServiceCharge.TabIndex = 100;
            ServiceCharge.Text = "Php 0.00";
            // 
            // AdditionalCharges
            // 
            AdditionalCharges.AutoSize = true;
            AdditionalCharges.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdditionalCharges.Location = new Point(876, 447);
            AdditionalCharges.Name = "AdditionalCharges";
            AdditionalCharges.Size = new Size(67, 18);
            AdditionalCharges.TabIndex = 101;
            AdditionalCharges.Text = "Php 0.00";
            // 
            // TransactionDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1170, 688);
            Controls.Add(AdditionalCharges);
            Controls.Add(ServiceCharge);
            Controls.Add(RoomType);
            Controls.Add(CheckInDate);
            Controls.Add(CheckOutDate);
            Controls.Add(Balance);
            Controls.Add(AmountPaid2);
            Controls.Add(TotalAmount);
            Controls.Add(LengthOfStay);
            Controls.Add(RoomRate);
            Controls.Add(Taxes);
            Controls.Add(TransactionNo);
            Controls.Add(TransactionType);
            Controls.Add(TransactionName);
            Controls.Add(PaymentReference);
            Controls.Add(AmountPaid);
            Controls.Add(PaymentMethod);
            Controls.Add(DateOfPayment);
            Controls.Add(GuestName);
            Controls.Add(ContactNumber);
            Controls.Add(Email);
            Controls.Add(LengthOfStayText);
            Controls.Add(BalanceText);
            Controls.Add(AmountPaid2Text);
            Controls.Add(TotalAmountText);
            Controls.Add(AdditionalChargesText);
            Controls.Add(TaxesText);
            Controls.Add(ServiceChargeText);
            Controls.Add(RoomRateText);
            Controls.Add(CheckOutDateText);
            Controls.Add(CheckInDateText);
            Controls.Add(RoomTypeText);
            Controls.Add(PaymentReferenceText);
            Controls.Add(AmountPaidText);
            Controls.Add(PaymentMethodText);
            Controls.Add(DateOfPaymentText);
            Controls.Add(ContactNumberText);
            Controls.Add(EmailText);
            Controls.Add(GuestNameText);
            Controls.Add(TransactionNameText);
            Controls.Add(TransactionTypeText);
            Controls.Add(TransactionNoText);
            Controls.Add(HeaderText);
            Controls.Add(Logo);
            Controls.Add(HeaderBox);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TransactionDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionDetails";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundedCornerElipse;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2ResizeBox HeaderBox;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Panel panel1;
        private Label TransactionNameText;
        private Label TransactionTypeText;
        private Label TransactionNoText;
        private Label HeaderText;
        private Label ContactNumberText;
        private Label EmailText;
        private Label GuestNameText;
        private Label Email;
        private Label LengthOfStayText;
        private Label BalanceText;
        private Label AmountPaid2Text;
        private Label TotalAmountText;
        private Label AdditionalChargesText;
        private Label TaxesText;
        private Label ServiceChargeText;
        private Label RoomRateText;
        private Label CheckOutDateText;
        private Label CheckInDateText;
        private Label RoomTypeText;
        private Label PaymentReferenceText;
        private Label AmountPaidText;
        private Label PaymentMethodText;
        private Label DateOfPaymentText;
        private Label AdditionalCharges;
        private Label ServiceCharge;
        private Label RoomType;
        private Label CheckInDate;
        private Label CheckOutDate;
        private Label Balance;
        private Label AmountPaid2;
        private Label TotalAmount;
        private Label LengthOfStay;
        private Label RoomRate;
        private Label Taxes;
        private Label TransactionNo;
        private Label TransactionType;
        private Label TransactionName;
        private Label PaymentReference;
        private Label AmountPaid;
        private Label PaymentMethod;
        private Label DateOfPayment;
        private Label GuestName;
        private Label ContactNumber;
    }
}