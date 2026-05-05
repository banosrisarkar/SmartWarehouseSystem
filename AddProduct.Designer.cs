namespace SmartWarehouseUI_New
{
    partial class AddProduct
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.RadioButton radioButton1; // YES
        private System.Windows.Forms.RadioButton radioButton3; // NO

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();

            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();

            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();

            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ================= TITLE =================
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label1.Text = "Add Product";
            label1.Location = new System.Drawing.Point(320, 30);

            // ================= SKU =================
            label2.AutoSize = true;
            label2.Text = "SKU";
            label2.Location = new System.Drawing.Point(200, 90);

            textBox1.Location = new System.Drawing.Point(300, 90);
            textBox1.Size = new System.Drawing.Size(150, 23);

            // ================= NAME =================
            label3.AutoSize = true;
            label3.Text = "Name";
            label3.Location = new System.Drawing.Point(200, 130);

            textBox2.Location = new System.Drawing.Point(300, 130);
            textBox2.Size = new System.Drawing.Size(150, 23);

            // ================= PRICE =================
            label4.AutoSize = true;
            label4.Text = "Price";
            label4.Location = new System.Drawing.Point(200, 170);

            textBox3.Location = new System.Drawing.Point(300, 170);
            textBox3.Size = new System.Drawing.Size(150, 23);

            // ================= QTY =================
            label5.AutoSize = true;
            label5.Text = "Qty";
            label5.Location = new System.Drawing.Point(200, 210);

            textBox4.Location = new System.Drawing.Point(300, 210);
            textBox4.Size = new System.Drawing.Size(150, 23);

            // ================= PERISHABLE =================
            label6.AutoSize = true;
            label6.Text = "Perishable";
            label6.Location = new System.Drawing.Point(200, 250);

            // YES
            radioButton1.AutoSize = true;
            radioButton1.Text = "Yes";
            radioButton1.Location = new System.Drawing.Point(300, 250);
            radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);

            // NO
            radioButton3.AutoSize = true;
            radioButton3.Text = "No";
            radioButton3.Location = new System.Drawing.Point(370, 250);
            radioButton3.Checked = true;
            radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);

            // ================= DATE =================
            dateTimePicker1.Location = new System.Drawing.Point(300, 290);
            dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            dateTimePicker1.Enabled = false;

            // ================= BUTTON =================
            button1.Text = "Save";
            button1.Location = new System.Drawing.Point(300, 330);
            button1.Size = new System.Drawing.Size(100, 30);
            button1.Click += new System.EventHandler(this.button1_Click);

            // ================= FORM =================
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label6);

            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
            this.Controls.Add(textBox4);

            this.Controls.Add(radioButton1);
            this.Controls.Add(radioButton3);

            this.Controls.Add(dateTimePicker1);
            this.Controls.Add(button1);

            this.Text = "AddProduct";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}