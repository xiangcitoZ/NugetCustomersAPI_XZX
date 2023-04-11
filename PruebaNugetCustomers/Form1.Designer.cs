namespace PruebaNugetCustomers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            txtIdCliente = new TextBox();
            txtCompany = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtCity = new TextBox();
            label5 = new Label();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 148);
            button1.Name = "button1";
            button1.Size = new Size(75, 54);
            button1.TabIndex = 0;
            button1.Text = "Cargar clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_ClickAsync;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 69);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(128, 105);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(169, 259);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 51);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "ID Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(367, 90);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(100, 23);
            txtIdCliente.TabIndex = 4;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(367, 193);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(100, 23);
            txtCompany.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 154);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Company";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(367, 289);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 250);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Address";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(367, 358);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 319);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 9;
            label5.Text = "City";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(536, 105);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(169, 259);
            listBox2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 450);
            Controls.Add(listBox2);
            Controls.Add(txtCity);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtCompany);
            Controls.Add(label3);
            Controls.Add(txtIdCliente);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private TextBox txtIdCliente;
        private TextBox txtCompany;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtCity;
        private Label label5;
        private ListBox listBox2;
    }
}