namespace clock
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.электронкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.секундомерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Num0 = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.Num3 = new System.Windows.Forms.Label();
            this.Num4 = new System.Windows.Forms.Label();
            this.Num5 = new System.Windows.Forms.Label();
            this.Num6 = new System.Windows.Forms.Label();
            this.Num7 = new System.Windows.Forms.Label();
            this.Num8 = new System.Windows.Forms.Label();
            this.Num9 = new System.Windows.Forms.Label();
            this.Num10 = new System.Windows.Forms.Label();
            this.Num11 = new System.Windows.Forms.Label();
            this.внизуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посерединеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.White;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimeLabel.Location = new System.Drawing.Point(83, 351);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(182, 50);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "00:00:00";
            this.TimeLabel.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem,
            this.электронкаToolStripMenuItem,
            this.секундомерToolStripMenuItem,
            this.настройкиToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 92);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // электронкаToolStripMenuItem
            // 
            this.электронкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.внизуToolStripMenuItem,
            this.посерединеToolStripMenuItem});
            this.электронкаToolStripMenuItem.Name = "электронкаToolStripMenuItem";
            this.электронкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.электронкаToolStripMenuItem.Text = "Электронка";
            this.электронкаToolStripMenuItem.Click += new System.EventHandler(this.электронкаToolStripMenuItem_Click);
            // 
            // секундомерToolStripMenuItem
            // 
            this.секундомерToolStripMenuItem.Name = "секундомерToolStripMenuItem";
            this.секундомерToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.секундомерToolStripMenuItem.Text = "Секундомер";
            this.секундомерToolStripMenuItem.Click += new System.EventHandler(this.секундомерToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem2
            // 
            this.настройкиToolStripMenuItem2.Name = "настройкиToolStripMenuItem2";
            this.настройкиToolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.настройкиToolStripMenuItem2.Text = "Настройки";
            this.настройкиToolStripMenuItem2.Click += new System.EventHandler(this.настройкиToolStripMenuItem2_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(439, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Цвет секундной стрелки";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(599, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цвет минутной стрелки";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(494, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цвет часовой стрелки";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(621, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цвет часов";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(622, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Шрифт часов";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(620, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Цвет эл. часов";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(590, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Шрифт эл. часов";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(271, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 350);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Num0
            // 
            this.Num0.BackColor = System.Drawing.Color.White;
            this.Num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Num0.Location = new System.Drawing.Point(145, 10);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(60, 40);
            this.Num0.TabIndex = 12;
            this.Num0.Text = "12";
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.Color.White;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Num1.Location = new System.Drawing.Point(234, 46);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(30, 40);
            this.Num1.TabIndex = 13;
            this.Num1.Text = "1";
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.Color.White;
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Num2.Location = new System.Drawing.Point(280, 100);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(30, 40);
            this.Num2.TabIndex = 14;
            this.Num2.Text = "2";
            // 
            // Num3
            // 
            this.Num3.BackColor = System.Drawing.Color.White;
            this.Num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Num3.Location = new System.Drawing.Point(305, 155);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(30, 40);
            this.Num3.TabIndex = 15;
            this.Num3.Text = "3";
            // 
            // Num4
            // 
            this.Num4.BackColor = System.Drawing.Color.White;
            this.Num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Num4.Location = new System.Drawing.Point(280, 220);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(30, 40);
            this.Num4.TabIndex = 16;
            this.Num4.Text = "4";
            // 
            // Num5
            // 
            this.Num5.BackColor = System.Drawing.Color.White;
            this.Num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Num5.Location = new System.Drawing.Point(234, 275);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(30, 40);
            this.Num5.TabIndex = 17;
            this.Num5.Text = "5";
            // 
            // Num6
            // 
            this.Num6.BackColor = System.Drawing.Color.White;
            this.Num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Num6.Location = new System.Drawing.Point(160, 304);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(30, 40);
            this.Num6.TabIndex = 18;
            this.Num6.Text = "6";
            // 
            // Num7
            // 
            this.Num7.BackColor = System.Drawing.Color.White;
            this.Num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Num7.Location = new System.Drawing.Point(81, 265);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(30, 40);
            this.Num7.TabIndex = 19;
            this.Num7.Text = "7";
            // 
            // Num8
            // 
            this.Num8.BackColor = System.Drawing.Color.White;
            this.Num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Num8.Location = new System.Drawing.Point(35, 210);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(30, 40);
            this.Num8.TabIndex = 20;
            this.Num8.Text = "8";
            // 
            // Num9
            // 
            this.Num9.BackColor = System.Drawing.Color.White;
            this.Num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Num9.Location = new System.Drawing.Point(10, 155);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(30, 40);
            this.Num9.TabIndex = 21;
            this.Num9.Text = "9";
            // 
            // Num10
            // 
            this.Num10.BackColor = System.Drawing.Color.White;
            this.Num10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Num10.Location = new System.Drawing.Point(35, 90);
            this.Num10.Name = "Num10";
            this.Num10.Size = new System.Drawing.Size(60, 40);
            this.Num10.TabIndex = 22;
            this.Num10.Text = "10";
            // 
            // Num11
            // 
            this.Num11.BackColor = System.Drawing.Color.White;
            this.Num11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Num11.Location = new System.Drawing.Point(81, 36);
            this.Num11.Name = "Num11";
            this.Num11.Size = new System.Drawing.Size(60, 40);
            this.Num11.TabIndex = 23;
            this.Num11.Text = "11";
            // 
            // внизуToolStripMenuItem
            // 
            this.внизуToolStripMenuItem.Name = "внизуToolStripMenuItem";
            this.внизуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.внизуToolStripMenuItem.Text = "внизу";
            this.внизуToolStripMenuItem.Click += new System.EventHandler(this.внизуToolStripMenuItem_Click);
            // 
            // посерединеToolStripMenuItem
            // 
            this.посерединеToolStripMenuItem.Name = "посерединеToolStripMenuItem";
            this.посерединеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.посерединеToolStripMenuItem.Text = "посередине";
            this.посерединеToolStripMenuItem.Click += new System.EventHandler(this.посерединеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.Num11);
            this.Controls.Add(this.Num10);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem секундомерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem электронкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Num0;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Num3;
        private System.Windows.Forms.Label Num4;
        private System.Windows.Forms.Label Num5;
        private System.Windows.Forms.Label Num6;
        private System.Windows.Forms.Label Num7;
        private System.Windows.Forms.Label Num8;
        private System.Windows.Forms.Label Num9;
        private System.Windows.Forms.Label Num10;
        private System.Windows.Forms.Label Num11;
        private System.Windows.Forms.ToolStripMenuItem внизуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посерединеToolStripMenuItem;
    }
}

