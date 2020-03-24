namespace assignment2
{
    partial class RebateForm
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
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.MiddleNmeBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.Address1Box = new System.Windows.Forms.TextBox();
            this.Address2Box = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.ZipCodeBox = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DateReceivedPicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.ProofAttachedDropDownList = new System.Windows.Forms.ComboBox();
            this.labelProofAttached = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ResultList = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.StartTimeBox = new System.Windows.Forms.TextBox();
            this.SaveTimeBox = new System.Windows.Forms.TextBox();
            this.BackNumBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(20, 58);
            this.FirstNameBox.MaxLength = 20;
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameBox.TabIndex = 0;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.BoxTextChanged);
            this.FirstNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            // 
            // MiddleNmeBox
            // 
            this.MiddleNmeBox.Location = new System.Drawing.Point(126, 57);
            this.MiddleNmeBox.MaxLength = 1;
            this.MiddleNmeBox.Name = "MiddleNmeBox";
            this.MiddleNmeBox.Size = new System.Drawing.Size(41, 20);
            this.MiddleNmeBox.TabIndex = 1;
            this.MiddleNmeBox.TextChanged += new System.EventHandler(this.BoxTextChanged);
            this.MiddleNmeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(205, 58);
            this.LastNameBox.MaxLength = 20;
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(98, 20);
            this.LastNameBox.TabIndex = 2;
            this.LastNameBox.TextChanged += new System.EventHandler(this.BoxTextChanged);
            this.LastNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            // 
            // Address1Box
            // 
            this.Address1Box.Location = new System.Drawing.Point(19, 264);
            this.Address1Box.MaxLength = 35;
            this.Address1Box.Name = "Address1Box";
            this.Address1Box.Size = new System.Drawing.Size(283, 20);
            this.Address1Box.TabIndex = 6;
            this.Address1Box.TextChanged += new System.EventHandler(this.BoxTextChanged);
            this.Address1Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            // 
            // Address2Box
            // 
            this.Address2Box.Location = new System.Drawing.Point(20, 303);
            this.Address2Box.MaxLength = 35;
            this.Address2Box.Name = "Address2Box";
            this.Address2Box.Size = new System.Drawing.Size(283, 20);
            this.Address2Box.TabIndex = 7;
            this.Address2Box.TextChanged += new System.EventHandler(this.BoxTextChanged);
            this.Address2Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(20, 349);
            this.CityBox.MaxLength = 25;
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(100, 20);
            this.CityBox.TabIndex = 8;
            this.CityBox.TextChanged += new System.EventHandler(this.BoxTextChanged);
            this.CityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            // 
            // StateBox
            // 
            this.StateBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.StateBox.Location = new System.Drawing.Point(142, 349);
            this.StateBox.MaxLength = 2;
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(41, 20);
            this.StateBox.TabIndex = 9;
            this.StateBox.TextChanged += new System.EventHandler(this.BoxTextChanged);
            this.StateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            // 
            // ZipCodeBox
            // 
            this.ZipCodeBox.Location = new System.Drawing.Point(205, 349);
            this.ZipCodeBox.MaxLength = 9;
            this.ZipCodeBox.Name = "ZipCodeBox";
            this.ZipCodeBox.Size = new System.Drawing.Size(98, 20);
            this.ZipCodeBox.TabIndex = 10;
            this.ZipCodeBox.TextChanged += new System.EventHandler(this.BoxTextChanged);
            this.ZipCodeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            // 
            // GenderBox
            // 
            this.GenderBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.GenderBox.Location = new System.Drawing.Point(20, 113);
            this.GenderBox.MaxLength = 1;
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(36, 20);
            this.GenderBox.TabIndex = 3;
            this.GenderBox.TextChanged += new System.EventHandler(this.BoxTextChanged);
            this.GenderBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(20, 165);
            this.PhoneNumberBox.MaxLength = 21;
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(163, 20);
            this.PhoneNumberBox.TabIndex = 4;
            this.PhoneNumberBox.TextChanged += new System.EventHandler(this.BoxTextChanged);
            this.PhoneNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(20, 208);
            this.EmailBox.MaxLength = 60;
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(197, 20);
            this.EmailBox.TabIndex = 5;
            this.EmailBox.TextChanged += new System.EventHandler(this.BoxTextChanged);
            this.EmailBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone Number *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "E-mail Address *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address Line 1 *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Address Line 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "City *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "State *";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(202, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Zip Code *";
            // 
            // DateReceivedPicker
            // 
            this.DateReceivedPicker.Location = new System.Drawing.Point(20, 413);
            this.DateReceivedPicker.Name = "DateReceivedPicker";
            this.DateReceivedPicker.Size = new System.Drawing.Size(200, 20);
            this.DateReceivedPicker.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Date received *";
            // 
            // ProofAttachedDropDownList
            // 
            this.ProofAttachedDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProofAttachedDropDownList.FormattingEnabled = true;
            this.ProofAttachedDropDownList.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ProofAttachedDropDownList.Location = new System.Drawing.Point(20, 468);
            this.ProofAttachedDropDownList.Name = "ProofAttachedDropDownList";
            this.ProofAttachedDropDownList.Size = new System.Drawing.Size(50, 21);
            this.ProofAttachedDropDownList.TabIndex = 12;
            // 
            // labelProofAttached
            // 
            this.labelProofAttached.AutoSize = true;
            this.labelProofAttached.Location = new System.Drawing.Point(17, 452);
            this.labelProofAttached.Name = "labelProofAttached";
            this.labelProofAttached.Size = new System.Drawing.Size(139, 13);
            this.labelProofAttached.TabIndex = 25;
            this.labelProofAttached.Text = "Proof of purchase attached ";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(126, 512);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(228, 512);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(19, 512);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // ResultList
            // 
            this.ResultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.PhoneNumberColumn});
            this.ResultList.FullRowSelect = true;
            this.ResultList.HideSelection = false;
            this.ResultList.Location = new System.Drawing.Point(395, 31);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(304, 505);
            this.ResultList.TabIndex = 29;
            this.ResultList.UseCompatibleStateImageBehavior = false;
            this.ResultList.View = System.Windows.Forms.View.Details;
            this.ResultList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ResultList_DoubleClick);
            this.ResultList.SelectedIndexChanged += new System.EventHandler(this.ResultList_DoubleClick);
            this.ResultList.DoubleClick += new System.EventHandler(this.ResultList_DoubleClick);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 200;
            // 
            // PhoneNumberColumn
            // 
            this.PhoneNumberColumn.Text = "Phone Number";
            this.PhoneNumberColumn.Width = 100;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "M(Male)/ F(Female)";
            // 
            // StartTimeBox
            // 
            this.StartTimeBox.Location = new System.Drawing.Point(20, 541);
            this.StartTimeBox.Name = "StartTimeBox";
            this.StartTimeBox.Size = new System.Drawing.Size(74, 20);
            this.StartTimeBox.TabIndex = 31;
            this.StartTimeBox.Visible = false;
            // 
            // SaveTimeBox
            // 
            this.SaveTimeBox.Location = new System.Drawing.Point(126, 541);
            this.SaveTimeBox.Name = "SaveTimeBox";
            this.SaveTimeBox.Size = new System.Drawing.Size(75, 20);
            this.SaveTimeBox.TabIndex = 32;
            this.SaveTimeBox.Visible = false;
            // 
            // BackNumBox
            // 
            this.BackNumBox.Location = new System.Drawing.Point(228, 541);
            this.BackNumBox.Name = "BackNumBox";
            this.BackNumBox.Size = new System.Drawing.Size(75, 20);
            this.BackNumBox.TabIndex = 33;
            this.BackNumBox.Visible = false;
            // 
            // RebateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 563);
            this.Controls.Add(this.BackNumBox);
            this.Controls.Add(this.SaveTimeBox);
            this.Controls.Add(this.StartTimeBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ResultList);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.labelProofAttached);
            this.Controls.Add(this.ProofAttachedDropDownList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DateReceivedPicker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.ZipCodeBox);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.Address2Box);
            this.Controls.Add(this.Address1Box);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.MiddleNmeBox);
            this.Controls.Add(this.FirstNameBox);
            this.Name = "RebateForm";
            this.Text = "Rebate Form";
            this.Load += new System.EventHandler(this.RebateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox MiddleNmeBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox Address1Box;
        private System.Windows.Forms.TextBox Address2Box;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.TextBox ZipCodeBox;
        private System.Windows.Forms.TextBox GenderBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DateReceivedPicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ProofAttachedDropDownList;
        private System.Windows.Forms.Label labelProofAttached;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListView ResultList;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader PhoneNumberColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox StartTimeBox;
        private System.Windows.Forms.TextBox SaveTimeBox;
        private System.Windows.Forms.TextBox BackNumBox;
    }
}

