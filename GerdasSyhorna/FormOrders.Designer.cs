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
            this.buttonUntreated = new System.Windows.Forms.Button();
            this.buttonRemoveOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTreated = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewOrders
            // 
            this.treeViewOrders.Location = new System.Drawing.Point(83, 71);
            this.treeViewOrders.Name = "treeViewOrders";
            this.treeViewOrders.Size = new System.Drawing.Size(305, 260);
            this.treeViewOrders.TabIndex = 0;
            // 
            // buttonUntreated
            // 
            this.buttonUntreated.Location = new System.Drawing.Point(66, 350);
            this.buttonUntreated.Name = "buttonUntreated";
            this.buttonUntreated.Size = new System.Drawing.Size(166, 23);
            this.buttonUntreated.TabIndex = 1;
            this.buttonUntreated.Text = "Markera som Obehandlad";
            this.buttonUntreated.UseVisualStyleBackColor = true;
            this.buttonUntreated.Click += new System.EventHandler(this.buttonUntreated_Click);
            // 
            // buttonRemoveOrder
            // 
            this.buttonRemoveOrder.Location = new System.Drawing.Point(152, 379);
            this.buttonRemoveOrder.Name = "buttonRemoveOrder";
            this.buttonRemoveOrder.Size = new System.Drawing.Size(166, 23);
            this.buttonRemoveOrder.TabIndex = 2;
            this.buttonRemoveOrder.Text = "Ta bort order";
            this.buttonRemoveOrder.UseVisualStyleBackColor = true;
            this.buttonRemoveOrder.Click += new System.EventHandler(this.buttonRemoveOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Markera en order för att\r\nta bort den eller ändra\r\ndess status";
            // 
            // buttonTreated
            // 
            this.buttonTreated.Location = new System.Drawing.Point(238, 350);
            this.buttonTreated.Name = "buttonTreated";
            this.buttonTreated.Size = new System.Drawing.Size(166, 23);
            this.buttonTreated.TabIndex = 4;
            this.buttonTreated.Text = "Markera som behandlad";
            this.buttonTreated.UseVisualStyleBackColor = true;
            this.buttonTreated.Click += new System.EventHandler(this.buttonTreated_Click_1);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 407);
            this.Controls.Add(this.buttonTreated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoveOrder);
            this.Controls.Add(this.buttonUntreated);
            this.Controls.Add(this.treeViewOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.Activated += new System.EventHandler(this.FormOrders_Activated);
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewOrders;
        private System.Windows.Forms.Button buttonUntreated;
        private System.Windows.Forms.Button buttonRemoveOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTreated;
    }
}