namespace WindowsFormsApp1
{
    partial class Form1
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
            this.asdgadsg = new System.Windows.Forms.Label();
            this.item1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.discount1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantity1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Preceived1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Tamount1 = new System.Windows.Forms.Label();
            this.Tchange1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // asdgadsg
            // 
            this.asdgadsg.AutoSize = true;
            this.asdgadsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asdgadsg.Location = new System.Drawing.Point(12, 9);
            this.asdgadsg.Name = "asdgadsg";
            this.asdgadsg.Size = new System.Drawing.Size(45, 20);
            this.asdgadsg.TabIndex = 0;
            this.asdgadsg.Text = "Item:";
            this.asdgadsg.Click += new System.EventHandler(this.label1_Click);
            // 
            // item1
            // 
            this.item1.Location = new System.Drawing.Point(16, 32);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(155, 20);
            this.item1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price:";
            // 
            // price1
            // 
            this.price1.Location = new System.Drawing.Point(66, 58);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(105, 20);
            this.price1.TabIndex = 3;
            this.price1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Discount(%):";
            // 
            // discount1
            // 
            this.discount1.Location = new System.Drawing.Point(177, 32);
            this.discount1.Name = "discount1";
            this.discount1.Size = new System.Drawing.Size(155, 20);
            this.discount1.TabIndex = 6;
            this.discount1.TextChanged += new System.EventHandler(this.dd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity:";
            // 
            // quantity1
            // 
            this.quantity1.Location = new System.Drawing.Point(255, 60);
            this.quantity1.Name = "quantity1";
            this.quantity1.Size = new System.Drawing.Size(77, 20);
            this.quantity1.TabIndex = 8;
            this.quantity1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Payment Received:";
            // 
            // Preceived1
            // 
            this.Preceived1.Location = new System.Drawing.Point(163, 167);
            this.Preceived1.Name = "Preceived1";
            this.Preceived1.Size = new System.Drawing.Size(105, 20);
            this.Preceived1.TabIndex = 11;
            this.Preceived1.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 20);
            this.button2.TabIndex = 12;
            this.button2.Text = "Compute";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Change:";
            // 
            // Tamount1
            // 
            this.Tamount1.AutoSize = true;
            this.Tamount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tamount1.Location = new System.Drawing.Point(173, 128);
            this.Tamount1.Name = "Tamount1";
            this.Tamount1.Size = new System.Drawing.Size(29, 20);
            this.Tamount1.TabIndex = 14;
            this.Tamount1.Text = "     ";
            // 
            // Tchange1
            // 
            this.Tchange1.AutoSize = true;
            this.Tchange1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tchange1.Location = new System.Drawing.Point(141, 200);
            this.Tchange1.Name = "Tchange1";
            this.Tchange1.Size = new System.Drawing.Size(29, 20);
            this.Tchange1.TabIndex = 15;
            this.Tchange1.Text = "     ";
            this.Tchange1.Click += new System.EventHandler(this.changessss_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 235);
            this.Controls.Add(this.Tchange1);
            this.Controls.Add(this.Tamount1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Preceived1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantity1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discount1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.asdgadsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label asdgadsg;
        private System.Windows.Forms.TextBox item1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox discount1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantity1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Preceived1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Tamount1;
        private System.Windows.Forms.Label Tchange1;
    }
}

