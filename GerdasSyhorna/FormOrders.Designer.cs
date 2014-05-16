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
            this.buttonRemoveOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEndOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewOrders
            // 
            this.treeViewOrders.Location = new System.Drawing.Point(17, 24);
            this.treeViewOrders.Name = "treeViewOrders";
            this.treeViewOrders.Size = new System.Drawing.Size(305, 260);
            this.treeViewOrders.TabIndex = 0;
            // 
            // buttonRemoveOrder
            // 
            this.buttonRemoveOrder.Location = new System.Drawing.Point(86, 334);
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
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "Markera en order\r\n(personens namn) för att\r\nta bort den eller ändra\r\ndess status";
            // 
            // buttonEndOrder
            // 
            this.buttonEndOrder.Location = new System.Drawing.Point(86, 299);
            this.buttonEndOrder.Name = "buttonEndOrder";
            this.buttonEndOrder.Size = new System.Drawing.Size(166, 23);
            this.buttonEndOrder.TabIndex = 4;
            this.buttonEndOrder.Text = "Utför order";
            this.buttonEndOrder.UseVisualStyleBackColor = true;
            this.buttonEndOrder.Click += new System.EventHandler(this.buttonEndOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(388, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 288);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 80);
            this.label3.TabIndex = 5;
            this.label3.Text = "Om en order tas bort \r\nsparas den inte och\r\nde beställda varorna\r\nräknas inte bor" +
    "t ifrån\r\nlagerantalet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 64);
            this.label2.TabIndex = 4;
            this.label2.Text = "Om en order utförs\r\nsparas den och de \r\nbeställda varorna räknas\r\nbort ifrån lage" +
    "rantalet";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEndOrder);
            this.Controls.Add(this.buttonRemoveOrder);
            this.Controls.Add(this.treeViewOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.Activated += new System.EventHandler(this.FormOrders_Activated);
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewOrders;
        private System.Windows.Forms.Button buttonRemoveOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEndOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}