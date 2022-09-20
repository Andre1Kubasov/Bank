namespace BankCredit
{
    partial class Form10
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выйтиВГлавноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОВкладеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бессрочныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.семейныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.накопительныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Бессрочный";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Семейный";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(555, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Накопительный";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 107);
            this.textBox1.MaxLength = 3;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 47);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 209);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '7';
            this.textBox2.Size = new System.Drawing.Size(204, 47);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F);
            this.label1.Location = new System.Drawing.Point(69, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Срок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F);
            this.label2.Location = new System.Drawing.Point(69, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(68, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 25);
            this.label3.TabIndex = 8;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиВГлавноеМенюToolStripMenuItem,
            this.информацияОВкладеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выйтиВГлавноеМенюToolStripMenuItem
            // 
            this.выйтиВГлавноеМенюToolStripMenuItem.Name = "выйтиВГлавноеМенюToolStripMenuItem";
            this.выйтиВГлавноеМенюToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.выйтиВГлавноеМенюToolStripMenuItem.Text = "Выйти в главное меню";
            this.выйтиВГлавноеМенюToolStripMenuItem.Click += new System.EventHandler(this.выйтиВГлавноеМенюToolStripMenuItem_Click);
            // 
            // информацияОВкладеToolStripMenuItem
            // 
            this.информацияОВкладеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бессрочныйToolStripMenuItem,
            this.семейныйToolStripMenuItem,
            this.накопительныйToolStripMenuItem});
            this.информацияОВкладеToolStripMenuItem.Name = "информацияОВкладеToolStripMenuItem";
            this.информацияОВкладеToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.информацияОВкладеToolStripMenuItem.Text = "Информация о вкладе";
            // 
            // бессрочныйToolStripMenuItem
            // 
            this.бессрочныйToolStripMenuItem.Name = "бессрочныйToolStripMenuItem";
            this.бессрочныйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.бессрочныйToolStripMenuItem.Text = "Бессрочный";
            this.бессрочныйToolStripMenuItem.Click += new System.EventHandler(this.бессрочныйToolStripMenuItem_Click);
            // 
            // семейныйToolStripMenuItem
            // 
            this.семейныйToolStripMenuItem.Name = "семейныйToolStripMenuItem";
            this.семейныйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.семейныйToolStripMenuItem.Text = "Семейный";
            this.семейныйToolStripMenuItem.Click += new System.EventHandler(this.семейныйToolStripMenuItem_Click);
            // 
            // накопительныйToolStripMenuItem
            // 
            this.накопительныйToolStripMenuItem.Name = "накопительныйToolStripMenuItem";
            this.накопительныйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.накопительныйToolStripMenuItem.Text = "Накопительный";
            this.накопительныйToolStripMenuItem.Click += new System.EventHandler(this.накопительныйToolStripMenuItem_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form10";
            this.Text = "VkladTinkoff";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выйтиВГлавноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОВкладеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бессрочныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem семейныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem накопительныйToolStripMenuItem;
    }
}