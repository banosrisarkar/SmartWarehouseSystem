namespace SmartWarehouseUI_New
{
    partial class Order
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();

            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();

            this.button1 = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ================= LABEL 1 (Supplier) =================
            label1.AutoSize = true;
            label1.Text = "Supplier";
            label1.Location = new System.Drawing.Point(200, 100);

            // ================= COMBOBOX 1 =================
            comboBox1.Location = new System.Drawing.Point(300, 100);
            comboBox1.Size = new System.Drawing.Size(150, 23);

            // ================= LABEL 2 (Product) =================
            label2.AutoSize = true;
            label2.Text = "Product";
            label2.Location = new System.Drawing.Point(200, 150);

            // ================= COMBOBOX 2 =================
            comboBox2.Location = new System.Drawing.Point(300, 150);
            comboBox2.Size = new System.Drawing.Size(150, 23);

            // ================= LABEL 3 (Qty) =================
            label3.AutoSize = true;
            label3.Text = "Qty";
            label3.Location = new System.Drawing.Point(200, 200);

            // ================= TEXTBOX =================
            textBox1.Location = new System.Drawing.Point(300, 200);
            textBox1.Size = new System.Drawing.Size(150, 23);

            // ================= BUTTON =================
            button1.Text = "Save";
            button1.Location = new System.Drawing.Point(300, 250);
            button1.Size = new System.Drawing.Size(100, 30);
            button1.Click += new System.EventHandler(this.button1_Click);

            // ================= FORM =================
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.Controls.Add(label1);
            this.Controls.Add(comboBox1);

            this.Controls.Add(label2);
            this.Controls.Add(comboBox2);

            this.Controls.Add(label3);
            this.Controls.Add(textBox1);

            this.Controls.Add(button1);

            this.Text = "Order";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}