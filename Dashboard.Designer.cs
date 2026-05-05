namespace SmartWarehouseUI_New
{
    partial class Dashboard
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
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label1.Location = new System.Drawing.Point(285, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(155, 15);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO DASHBOARD";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.DarkSalmon;
            button1.Location = new System.Drawing.Point(322, 111);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(91, 42);
            button1.TabIndex = 1;
            button1.Text = "AddProduct";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Salmon;
            button2.Location = new System.Drawing.Point(322, 208);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(91, 43);
            button2.TabIndex = 2;
            button2.Text = "Order";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Salmon;
            button3.Location = new System.Drawing.Point(322, 257);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(91, 47);
            button3.TabIndex = 3;
            button3.Text = "StockReport";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.PeachPuff;
            button4.Location = new System.Drawing.Point(652, 392);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(69, 29);
            button4.TabIndex = 4;
            button4.Text = "LOGOUT";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.Salmon;
            button5.Location = new System.Drawing.Point(322, 159);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(91, 43);
            button5.TabIndex = 5;
            button5.Text = "Supplier";
            button5.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}