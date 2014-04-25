namespace GerdasSyhorna
{
    partial class FormSupplier
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonInsertSupplier = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTelephone2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.buttonUpdateSupplier = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 353);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonInsertSupplier);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxTelephone);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxAddress);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(335, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lägg till";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonInsertSupplier
            // 
            this.buttonInsertSupplier.Location = new System.Drawing.Point(109, 271);
            this.buttonInsertSupplier.Name = "buttonInsertSupplier";
            this.buttonInsertSupplier.Size = new System.Drawing.Size(125, 23);
            this.buttonInsertSupplier.TabIndex = 21;
            this.buttonInsertSupplier.Text = "Lägg till leverantör";
            this.buttonInsertSupplier.UseVisualStyleBackColor = true;
            this.buttonInsertSupplier.Click += new System.EventHandler(this.buttonInsertSupplier_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(84, 216);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmail.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefon:";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(84, 161);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(169, 20);
            this.textBoxTelephone.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Adress:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(84, 104);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(169, 20);
            this.textBoxAddress.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Företagsnamn:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(84, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(169, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxSupplier);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxEmail2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxTelephone2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxAddress2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBoxName2);
            this.tabPage2.Controls.Add(this.buttonUpdateSupplier);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(335, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Redigera";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(204, 6);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(125, 21);
            this.comboBoxSupplier.TabIndex = 29;
            this.comboBoxSupplier.Text = "Välj leverantör här";
            this.comboBoxSupplier.SelectedValueChanged += new System.EventHandler(this.comboBoxSupplier_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Email:";
            // 
            // textBoxEmail2
            // 
            this.textBoxEmail2.Location = new System.Drawing.Point(84, 216);
            this.textBoxEmail2.Name = "textBoxEmail2";
            this.textBoxEmail2.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmail2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Telefon:";
            // 
            // textBoxTelephone2
            // 
            this.textBoxTelephone2.Location = new System.Drawing.Point(84, 161);
            this.textBoxTelephone2.Name = "textBoxTelephone2";
            this.textBoxTelephone2.Size = new System.Drawing.Size(169, 20);
            this.textBoxTelephone2.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Adress:";
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(84, 104);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(169, 20);
            this.textBoxAddress2.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Företagsnamn:";
            // 
            // textBoxName2
            // 
            this.textBoxName2.Location = new System.Drawing.Point(84, 48);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(169, 20);
            this.textBoxName2.TabIndex = 21;
            // 
            // buttonUpdateSupplier
            // 
            this.buttonUpdateSupplier.Location = new System.Drawing.Point(108, 271);
            this.buttonUpdateSupplier.Name = "buttonUpdateSupplier";
            this.buttonUpdateSupplier.Size = new System.Drawing.Size(125, 23);
            this.buttonUpdateSupplier.TabIndex = 0;
            this.buttonUpdateSupplier.Text = "Ändra leverantör";
            this.buttonUpdateSupplier.UseVisualStyleBackColor = true;
            this.buttonUpdateSupplier.Click += new System.EventHandler(this.buttonUpdateSupplier_Click);
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 373);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSupplier";
            this.Text = "FormSupplier";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonInsertSupplier;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox textBoxEmail2;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox textBoxTelephone2;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.Button buttonUpdateSupplier;
        private System.Windows.Forms.ComboBox comboBoxSupplier;

    }
}