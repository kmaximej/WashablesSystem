﻿namespace WashablesSystem
{
    partial class EditLaundry
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblItemTitle = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lvlPickup = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.rb2hrs = new System.Windows.Forms.RadioButton();
            this.rb3hrs = new System.Windows.Forms.RadioButton();
            this.rbCustomHour = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCust = new System.Windows.Forms.ComboBox();
            this.cbItem1 = new System.Windows.Forms.ComboBox();
            this.cbItem2 = new System.Windows.Forms.ComboBox();
            this.cbItem3 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb1min = new System.Windows.Forms.RadioButton();
            this.rb3min = new System.Windows.Forms.RadioButton();
            this.rbCustomMin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnService = new WashablesSystem.CustomTextbox();
            this.pickupDate = new WashablesSystem.CustomDatePicker();
            this.btnCancel = new WashablesSystem.CustomButton();
            this.btnAdd = new WashablesSystem.CustomButton();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMachine = new System.Windows.Forms.ComboBox();
            this.priorityCheckBox = new System.Windows.Forms.CheckBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.quantity3 = new System.Windows.Forms.NumericUpDown();
            this.quantity2 = new System.Windows.Forms.NumericUpDown();
            this.quantity1 = new System.Windows.Forms.NumericUpDown();
            this.txtWeight3 = new System.Windows.Forms.NumericUpDown();
            this.txtWeight2 = new System.Windows.Forms.NumericUpDown();
            this.txtWeight = new System.Windows.Forms.NumericUpDown();
            this.txtOtherHr = new System.Windows.Forms.NumericUpDown();
            this.txtOtherMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherMin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblHeader.Location = new System.Drawing.Point(19, 18);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(161, 21);
            this.lblHeader.TabIndex = 44;
            this.lblHeader.Text = "Edit Laundry Form";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "____________________________________________________________________________";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblQuantity.Location = new System.Drawing.Point(222, 318);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(116, 18);
            this.lblQuantity.TabIndex = 69;
            this.lblQuantity.Text = "Quantity (g/mL)";
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblWeight.Location = new System.Drawing.Point(35, 236);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(88, 18);
            this.lblWeight.TabIndex = 68;
            this.lblWeight.Text = "Weight (kg)";
            // 
            // lblItemTitle
            // 
            this.lblItemTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemTitle.AutoSize = true;
            this.lblItemTitle.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblItemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblItemTitle.Location = new System.Drawing.Point(35, 296);
            this.lblItemTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemTitle.Name = "lblItemTitle";
            this.lblItemTitle.Size = new System.Drawing.Size(121, 18);
            this.lblItemTitle.TabIndex = 64;
            this.lblItemTitle.Text = "Items to be Used:";
            // 
            // lblCust
            // 
            this.lblCust.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCust.AutoSize = true;
            this.lblCust.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblCust.Location = new System.Drawing.Point(34, 178);
            this.lblCust.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(114, 18);
            this.lblCust.TabIndex = 63;
            this.lblCust.Text = "Customer Name";
            // 
            // lblService
            // 
            this.lblService.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblService.Location = new System.Drawing.Point(34, 119);
            this.lblService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(89, 18);
            this.lblService.TabIndex = 62;
            this.lblService.Text = "Service Type";
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblItemName.Location = new System.Drawing.Point(35, 318);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(82, 18);
            this.lblItemName.TabIndex = 70;
            this.lblItemName.Text = "Item Name";
            // 
            // lvlPickup
            // 
            this.lvlPickup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lvlPickup.AutoSize = true;
            this.lvlPickup.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lvlPickup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lvlPickup.Location = new System.Drawing.Point(364, 61);
            this.lvlPickup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvlPickup.Name = "lvlPickup";
            this.lvlPickup.Size = new System.Drawing.Size(99, 18);
            this.lvlPickup.TabIndex = 73;
            this.lvlPickup.Text = "Pick-Up Date";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblTime.Location = new System.Drawing.Point(364, 135);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 18);
            this.lblTime.TabIndex = 75;
            this.lblTime.Text = "Time";
            // 
            // lblHours
            // 
            this.lblHours.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblHours.Location = new System.Drawing.Point(364, 153);
            this.lblHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(67, 18);
            this.lblHours.TabIndex = 76;
            this.lblHours.Text = "By Hours";
            // 
            // lblMinutes
            // 
            this.lblMinutes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblMinutes.Location = new System.Drawing.Point(364, 279);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(78, 18);
            this.lblMinutes.TabIndex = 77;
            this.lblMinutes.Text = "By Minutes";
            // 
            // rb2hrs
            // 
            this.rb2hrs.AutoSize = true;
            this.rb2hrs.Location = new System.Drawing.Point(6, 19);
            this.rb2hrs.Name = "rb2hrs";
            this.rb2hrs.Size = new System.Drawing.Size(14, 13);
            this.rb2hrs.TabIndex = 78;
            this.rb2hrs.TabStop = true;
            this.rb2hrs.UseVisualStyleBackColor = true;
            // 
            // rb3hrs
            // 
            this.rb3hrs.AutoSize = true;
            this.rb3hrs.Location = new System.Drawing.Point(6, 43);
            this.rb3hrs.Name = "rb3hrs";
            this.rb3hrs.Size = new System.Drawing.Size(14, 13);
            this.rb3hrs.TabIndex = 79;
            this.rb3hrs.TabStop = true;
            this.rb3hrs.UseVisualStyleBackColor = true;
            // 
            // rbCustomHour
            // 
            this.rbCustomHour.AutoSize = true;
            this.rbCustomHour.Location = new System.Drawing.Point(6, 68);
            this.rbCustomHour.Name = "rbCustomHour";
            this.rbCustomHour.Size = new System.Drawing.Size(14, 13);
            this.rbCustomHour.TabIndex = 80;
            this.rbCustomHour.TabStop = true;
            this.rbCustomHour.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "2 Hours (default time)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 82;
            this.label3.Text = "3 Hours";
            // 
            // cbCust
            // 
            this.cbCust.BackColor = System.Drawing.SystemColors.Control;
            this.cbCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCust.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCust.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.cbCust.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbCust.FormattingEnabled = true;
            this.cbCust.Items.AddRange(new object[] {
            "Kiana Martin",
            "Quiana Momingo",
            "Lei Mar",
            "Dap Man",
            "Natasha Valerio"});
            this.cbCust.Location = new System.Drawing.Point(34, 203);
            this.cbCust.Name = "cbCust";
            this.cbCust.Size = new System.Drawing.Size(276, 25);
            this.cbCust.TabIndex = 91;
            // 
            // cbItem1
            // 
            this.cbItem1.BackColor = System.Drawing.SystemColors.Control;
            this.cbItem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbItem1.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.cbItem1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbItem1.FormattingEnabled = true;
            this.cbItem1.Items.AddRange(new object[] {
            "Surf Powder",
            "Tide",
            "Champion Liquid"});
            this.cbItem1.Location = new System.Drawing.Point(37, 338);
            this.cbItem1.Name = "cbItem1";
            this.cbItem1.Size = new System.Drawing.Size(180, 25);
            this.cbItem1.TabIndex = 92;
            // 
            // cbItem2
            // 
            this.cbItem2.BackColor = System.Drawing.SystemColors.Control;
            this.cbItem2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbItem2.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.cbItem2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbItem2.FormattingEnabled = true;
            this.cbItem2.Items.AddRange(new object[] {
            "Surf Powder",
            "Tide",
            "Champion Liquid"});
            this.cbItem2.Location = new System.Drawing.Point(38, 370);
            this.cbItem2.Name = "cbItem2";
            this.cbItem2.Size = new System.Drawing.Size(180, 25);
            this.cbItem2.TabIndex = 93;
            // 
            // cbItem3
            // 
            this.cbItem3.BackColor = System.Drawing.SystemColors.Control;
            this.cbItem3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbItem3.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.cbItem3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbItem3.FormattingEnabled = true;
            this.cbItem3.Items.AddRange(new object[] {
            "Surf Powder",
            "Tide",
            "Champion Liquid"});
            this.cbItem3.Location = new System.Drawing.Point(38, 402);
            this.cbItem3.Name = "cbItem3";
            this.cbItem3.Size = new System.Drawing.Size(180, 25);
            this.cbItem3.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOtherHr);
            this.groupBox1.Controls.Add(this.rb2hrs);
            this.groupBox1.Controls.Add(this.rb3hrs);
            this.groupBox1.Controls.Add(this.rbCustomHour);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(383, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOtherMin);
            this.groupBox2.Controls.Add(this.rb1min);
            this.groupBox2.Controls.Add(this.rb3min);
            this.groupBox2.Controls.Add(this.rbCustomMin);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(383, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            // 
            // rb1min
            // 
            this.rb1min.AutoSize = true;
            this.rb1min.Location = new System.Drawing.Point(6, 19);
            this.rb1min.Name = "rb1min";
            this.rb1min.Size = new System.Drawing.Size(14, 13);
            this.rb1min.TabIndex = 78;
            this.rb1min.TabStop = true;
            this.rb1min.UseVisualStyleBackColor = true;
            // 
            // rb3min
            // 
            this.rb3min.AutoSize = true;
            this.rb3min.Location = new System.Drawing.Point(6, 43);
            this.rb3min.Name = "rb3min";
            this.rb3min.Size = new System.Drawing.Size(14, 13);
            this.rb3min.TabIndex = 79;
            this.rb3min.TabStop = true;
            this.rb3min.UseVisualStyleBackColor = true;
            // 
            // rbCustomMin
            // 
            this.rbCustomMin.AutoSize = true;
            this.rbCustomMin.Location = new System.Drawing.Point(6, 68);
            this.rbCustomMin.Name = "rbCustomMin";
            this.rbCustomMin.Size = new System.Drawing.Size(14, 13);
            this.rbCustomMin.TabIndex = 80;
            this.rbCustomMin.TabStop = true;
            this.rbCustomMin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "1 minute";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "30 minutes";
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.Color.White;
            this.btnService.BorderColor = System.Drawing.Color.LightGray;
            this.btnService.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnService.BorderRadius = 5;
            this.btnService.BorderSize = 1;
            this.btnService.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnService.ForeColor = System.Drawing.Color.Black;
            this.btnService.Location = new System.Drawing.Point(34, 138);
            this.btnService.Margin = new System.Windows.Forms.Padding(4);
            this.btnService.Multiline = false;
            this.btnService.Name = "btnService";
            this.btnService.Padding = new System.Windows.Forms.Padding(10, 5, 7, 5);
            this.btnService.PasswordChar = false;
            this.btnService.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.btnService.PlaceholderText = "";
            this.btnService.Size = new System.Drawing.Size(276, 30);
            this.btnService.TabIndex = 98;
            this.btnService.UnderlinedStyle = false;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // pickupDate
            // 
            this.pickupDate.BorderColor = System.Drawing.Color.LightGray;
            this.pickupDate.BorderSize = 1;
            this.pickupDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.pickupDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.pickupDate.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.pickupDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickupDate.Location = new System.Drawing.Point(367, 83);
            this.pickupDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.pickupDate.Name = "pickupDate";
            this.pickupDate.Size = new System.Drawing.Size(258, 35);
            this.pickupDate.SkinColor = System.Drawing.Color.White;
            this.pickupDate.TabIndex = 74;
            this.pickupDate.TextColor = System.Drawing.Color.Black;
            this.pickupDate.Value = new System.DateTime(2024, 11, 30, 0, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(521, 403);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 29);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(401, 403);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 29);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // cbUnit
            // 
            this.cbUnit.BackColor = System.Drawing.SystemColors.Control;
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbUnit.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.cbUnit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "Unit I",
            "Unit II",
            "Unit III"});
            this.cbUnit.Location = new System.Drawing.Point(155, 85);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(90, 25);
            this.cbUnit.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.label6.Location = new System.Drawing.Point(155, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 107;
            this.label6.Text = "Unit";
            // 
            // cbMachine
            // 
            this.cbMachine.BackColor = System.Drawing.SystemColors.Control;
            this.cbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMachine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbMachine.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.cbMachine.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbMachine.FormattingEnabled = true;
            this.cbMachine.Items.AddRange(new object[] {
            "Washing Machine",
            "Dryer",
            "Iron"});
            this.cbMachine.Location = new System.Drawing.Point(34, 85);
            this.cbMachine.Name = "cbMachine";
            this.cbMachine.Size = new System.Drawing.Size(114, 25);
            this.cbMachine.TabIndex = 106;
            // 
            // priorityCheckBox
            // 
            this.priorityCheckBox.AutoSize = true;
            this.priorityCheckBox.Location = new System.Drawing.Point(274, 91);
            this.priorityCheckBox.Name = "priorityCheckBox";
            this.priorityCheckBox.Size = new System.Drawing.Size(15, 14);
            this.priorityCheckBox.TabIndex = 105;
            this.priorityCheckBox.UseVisualStyleBackColor = true;
            // 
            // lblPriority
            // 
            this.lblPriority.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblPriority.Location = new System.Drawing.Point(252, 63);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(61, 18);
            this.lblPriority.TabIndex = 104;
            this.lblPriority.Text = "Priority?";
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblUnit.Location = new System.Drawing.Point(34, 63);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(61, 18);
            this.lblUnit.TabIndex = 103;
            this.lblUnit.Text = "Machine";
            // 
            // quantity3
            // 
            this.quantity3.DecimalPlaces = 2;
            this.quantity3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.quantity3.Location = new System.Drawing.Point(243, 402);
            this.quantity3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantity3.Name = "quantity3";
            this.quantity3.Size = new System.Drawing.Size(70, 25);
            this.quantity3.TabIndex = 218;
            // 
            // quantity2
            // 
            this.quantity2.DecimalPlaces = 2;
            this.quantity2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.quantity2.Location = new System.Drawing.Point(243, 370);
            this.quantity2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantity2.Name = "quantity2";
            this.quantity2.Size = new System.Drawing.Size(69, 25);
            this.quantity2.TabIndex = 217;
            // 
            // quantity1
            // 
            this.quantity1.DecimalPlaces = 2;
            this.quantity1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.quantity1.Location = new System.Drawing.Point(243, 338);
            this.quantity1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantity1.Name = "quantity1";
            this.quantity1.Size = new System.Drawing.Size(69, 25);
            this.quantity1.TabIndex = 216;
            // 
            // txtWeight3
            // 
            this.txtWeight3.DecimalPlaces = 2;
            this.txtWeight3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtWeight3.Location = new System.Drawing.Point(221, 261);
            this.txtWeight3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtWeight3.Name = "txtWeight3";
            this.txtWeight3.Size = new System.Drawing.Size(89, 25);
            this.txtWeight3.TabIndex = 215;
            // 
            // txtWeight2
            // 
            this.txtWeight2.DecimalPlaces = 2;
            this.txtWeight2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtWeight2.Location = new System.Drawing.Point(129, 261);
            this.txtWeight2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtWeight2.Name = "txtWeight2";
            this.txtWeight2.Size = new System.Drawing.Size(89, 25);
            this.txtWeight2.TabIndex = 214;
            // 
            // txtWeight
            // 
            this.txtWeight.DecimalPlaces = 2;
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtWeight.Location = new System.Drawing.Point(34, 261);
            this.txtWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(89, 25);
            this.txtWeight.TabIndex = 213;
            // 
            // txtOtherHr
            // 
            this.txtOtherHr.DecimalPlaces = 2;
            this.txtOtherHr.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtOtherHr.Location = new System.Drawing.Point(28, 62);
            this.txtOtherHr.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtOtherHr.Name = "txtOtherHr";
            this.txtOtherHr.Size = new System.Drawing.Size(57, 25);
            this.txtOtherHr.TabIndex = 209;
            // 
            // txtOtherMin
            // 
            this.txtOtherMin.DecimalPlaces = 2;
            this.txtOtherMin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtOtherMin.Location = new System.Drawing.Point(28, 61);
            this.txtOtherMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtOtherMin.Name = "txtOtherMin";
            this.txtOtherMin.Size = new System.Drawing.Size(57, 25);
            this.txtOtherMin.TabIndex = 210;
            // 
            // EditLaundry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 454);
            this.Controls.Add(this.quantity3);
            this.Controls.Add(this.quantity2);
            this.Controls.Add(this.quantity1);
            this.Controls.Add(this.txtWeight3);
            this.Controls.Add(this.txtWeight2);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMachine);
            this.Controls.Add(this.priorityCheckBox);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbItem3);
            this.Controls.Add(this.cbItem2);
            this.Controls.Add(this.cbItem1);
            this.Controls.Add(this.cbCust);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pickupDate);
            this.Controls.Add(this.lvlPickup);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblItemTitle);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditLaundry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLaundry";
            this.Load += new System.EventHandler(this.EditLaundry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private CustomButton btnCancel;
        private CustomButton btnAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblItemTitle;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lvlPickup;
        private CustomDatePicker pickupDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.RadioButton rb2hrs;
        private System.Windows.Forms.RadioButton rb3hrs;
        private System.Windows.Forms.RadioButton rbCustomHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCust;
        private System.Windows.Forms.ComboBox cbItem1;
        private System.Windows.Forms.ComboBox cbItem2;
        private System.Windows.Forms.ComboBox cbItem3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb1min;
        private System.Windows.Forms.RadioButton rb3min;
        private System.Windows.Forms.RadioButton rbCustomMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomTextbox btnService;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMachine;
        private System.Windows.Forms.CheckBox priorityCheckBox;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.NumericUpDown quantity3;
        private System.Windows.Forms.NumericUpDown quantity2;
        private System.Windows.Forms.NumericUpDown quantity1;
        private System.Windows.Forms.NumericUpDown txtWeight3;
        private System.Windows.Forms.NumericUpDown txtWeight2;
        private System.Windows.Forms.NumericUpDown txtWeight;
        private System.Windows.Forms.NumericUpDown txtOtherHr;
        private System.Windows.Forms.NumericUpDown txtOtherMin;
    }
}