namespace GerdasSyhorna
{
    partial class FormOrders
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
            this.treeViewOrders = new System.Windows.Forms.TreeView();
            this.buttonMarkOrder = new System.Windows.Forms.Button();
            this.buttonRemoveOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewOrders
            // 
            this.treeViewOrders.Location = new System.Drawing.Point(83, 42);
            this.treeViewOrders.Name = "treeViewOrders";
            this.treeViewOrders.Size = new System.Drawing.Size(305, 260);
            this.treeViewOrders.TabIndex = 0;
            // 
            // buttonMarkOrder
            // 
            this.buttonMarkOrder.Location = new System.Drawing.Point(60, 321);
            this.buttonMarkOrder.Name = "buttonMarkOrder";
            this.buttonMarkOrder.Size = new System.Drawing.Size(166, 23);
            this.buttonMarkOrder.TabIndex = 1;
            this.buttonMarkOrder.Text = "Markera order som hanterad";
            this.buttonMarkOrder.UseVisualStyleBackColor = true;
            this.buttonMarkOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRemoveOrder
            // 
            this.buttonRemoveOrder.Location = new System.Drawing.Point(244, 321);
            this.buttonRemoveOrder.Name = "buttonRemoveOrder";
            this.buttonRemoveOrder.Size = new System.Drawing.Size(166, 23);
            this.buttonRemoveOrder.TabIndex = 2;
            this.buttonRemoveOrder.Text = "Ta bort order";
            this.buttonRemoveOrder.UseVisualStyleBackColor = true;
            this.buttonRemoveOrder.Click += new System.EventHandler(this.buttonRemoveOrder_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 356);
            this.Controls.Add(this.buttonRemoveOrder);
            this.Controls.Add(this.buttonMarkOrder);
            this.Controls.Add(this.treeViewOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewOrders;
        private System.Windows.Forms.Button buttonMarkOrder;
        private System.Windows.Forms.Button buttonRemoveOrder;
    }
}