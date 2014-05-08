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
            this.SuspendLayout();
            // 
            // treeViewOrders
            // 
            this.treeViewOrders.Location = new System.Drawing.Point(79, 42);
            this.treeViewOrders.Name = "treeViewOrders";
            this.treeViewOrders.Size = new System.Drawing.Size(305, 260);
            this.treeViewOrders.TabIndex = 0;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 356);
            this.Controls.Add(this.treeViewOrders);
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewOrders;
    }
}