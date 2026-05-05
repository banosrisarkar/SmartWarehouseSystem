namespace SmartWarehouseUI_New
{
    partial class Supplier
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // LABEL
            label1.AutoSize = true;
            label1.Text = "Supplier Name";
            label1.Location = new System.Drawing.Point(200, 120);

            // TEXTBOX
            textBox1.Location = new System.Drawing.Point(320, 120);
            textBox1.Size = new System.Drawing.Size(180, 23);

            // BUTTON
            button1.Text = "Save";
            button1.Location = new System.Drawing.Point(320, 170);
            button1.Size = new System.Drawing.Size(100, 30);

            // 🔥 IMPORTANT FIX (THIS WAS YOUR ISSUE)
            button1.Click += new System.EventHandler(this.button1_Click);

            // FORM
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label1);
            this.Controls.Add(textBox1);
            this.Controls.Add(button1);

            this.Text = "Supplier";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}