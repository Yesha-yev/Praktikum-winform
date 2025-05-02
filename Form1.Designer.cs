namespace Praktikum_winform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelatas = new Label();
            labelbawah = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(352, 281);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // labelatas
            // 
            labelatas.AutoSize = true;
            labelatas.BackColor = Color.SkyBlue;
            labelatas.Font = new Font("Tekton Pro Ext", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelatas.ForeColor = Color.White;
            labelatas.Location = new Point(352, 198);
            labelatas.Name = "labelatas";
            labelatas.Size = new Size(112, 23);
            labelatas.TabIndex = 2;
            labelatas.Text = "Username";
            labelatas.Click += label1_Click;
            // 
            // labelbawah
            // 
            labelbawah.AutoSize = true;
            labelbawah.Location = new Point(424, 317);
            labelbawah.Name = "labelbawah";
            labelbawah.Size = new Size(42, 15);
            labelbawah.TabIndex = 3;
            labelbawah.Text = "Bawah";
            labelbawah.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(606, 231);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Cek";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelbawah);
            Controls.Add(labelatas);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelatas;
        private Label labelbawah;
        private Button button1;
    }
}
