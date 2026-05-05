namespace SmartWarehouseUI_New
{
    partial class Screen
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button button2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // TITLE
            lblTitle.AutoSize = true;
            lblTitle.Text = "LOGIN";
            lblTitle.Location = new System.Drawing.Point(320, 40);

            // EMAIL
            lblEmail.AutoSize = true;
            lblEmail.Text = "Email";
            lblEmail.Location = new System.Drawing.Point(200, 120);

            // PASSWORD
            lblPassword.AutoSize = true;
            lblPassword.Text = "Password";
            lblPassword.Location = new System.Drawing.Point(200, 180);

            // TEXTBOX 1
            textBox1.Location = new System.Drawing.Point(320, 115);
            textBox1.Size = new System.Drawing.Size(200, 23);
            textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);

            // TEXTBOX 2
            textBox2.Location = new System.Drawing.Point(320, 175);
            textBox2.Size = new System.Drawing.Size(200, 23);
            textBox2.UseSystemPasswordChar = true;

            // LOGIN BUTTON
            btnEnter.Text = "Login";
            btnEnter.Location = new System.Drawing.Point(320, 230);
            btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

            // REGISTER BUTTON
            button2.Text = "Register";
            button2.Location = new System.Drawing.Point(430, 230);
            button2.Click += new System.EventHandler(this.button2_Click);

            // FORM
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblEmail);
            this.Controls.Add(lblPassword);
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(btnEnter);
            this.Controls.Add(button2);

            this.Text = "Smart Warehouse Login";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}