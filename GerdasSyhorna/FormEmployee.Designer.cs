﻿namespace GerdasSyhorna
{
    partial class FormEmployee
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
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonChangeProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewProducts
            // 
            this.listViewProducts.AllowColumnReorder = true;
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.Location = new System.Drawing.Point(12, 53);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(489, 224);
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewProducts_ColumnClick);
            this.listViewProducts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewProducts_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Namn";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pris";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Antal i lager";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Antal på order";
            this.columnHeader5.Width = 80;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(7, 25);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(114, 25);
            this.labelProducts.TabIndex = 1;
            this.labelProducts.Text = "Produkter";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplier.Location = new System.Drawing.Point(534, 25);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(125, 25);
            this.labelSupplier.TabIndex = 2;
            this.labelSupplier.Text = "Leverantör";
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Location = new System.Drawing.Point(539, 53);
            this.textBoxSupplier.Multiline = true;
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.ReadOnly = true;
            this.textBoxSupplier.Size = new System.Drawing.Size(169, 114);
            this.textBoxSupplier.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Klicka på en produkt för att \r\nfå fram leverantör och bild\r\n";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(539, 257);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(169, 114);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bild";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(12, 303);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(169, 35);
            this.buttonAddProduct.TabIndex = 8;
            this.buttonAddProduct.Text = "Lägg till produkt";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonChangeProduct
            // 
            this.buttonChangeProduct.Location = new System.Drawing.Point(12, 344);
            this.buttonChangeProduct.Name = "buttonChangeProduct";
            this.buttonChangeProduct.Size = new System.Drawing.Size(169, 35);
            this.buttonChangeProduct.TabIndex = 9;
            this.buttonChangeProduct.Text = "Redigera vald produkt";
            this.buttonChangeProduct.UseVisualStyleBackColor = true;
            this.buttonChangeProduct.Click += new System.EventHandler(this.buttonChangeProduct_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 439);
            this.Controls.Add(this.buttonChangeProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSupplier);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.listViewProducts);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonChangeProduct;
    }
}