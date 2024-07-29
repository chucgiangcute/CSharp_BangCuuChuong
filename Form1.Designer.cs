namespace CSharp_BangCuuChuong
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
            label1 = new Label();
            BCC = new TextBox();
            NUMBER = new NumericUpDown();
            lbkq = new Label();
            KQ = new Label();
            TINH = new Button();
            TRACKBAR = new TrackBar();
            groupBox1 = new GroupBox();
            rd10 = new RadioButton();
            rd9 = new RadioButton();
            rd8 = new RadioButton();
            rd7 = new RadioButton();
            rd6 = new RadioButton();
            rd5 = new RadioButton();
            rd4 = new RadioButton();
            rd3 = new RadioButton();
            rd2 = new RadioButton();
            rd1 = new RadioButton();
            listBox1 = new ListBox();
            xemlai = new Button();
            ((System.ComponentModel.ISupportInitialize)NUMBER).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TRACKBAR).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Tahoma", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 76);
            label1.Name = "label1";
            label1.Size = new Size(431, 48);
            label1.TabIndex = 0;
            label1.Text = "Chọn bảng cửu chương";
            label1.Click += label1_Click;
            // 
            // BCC
            // 
            BCC.BackColor = Color.FromArgb(255, 128, 128);
            BCC.Font = new Font("Tahoma", 15F);
            BCC.Location = new Point(568, 68);
            BCC.Name = "BCC";
            BCC.Size = new Size(248, 56);
            BCC.TabIndex = 1;
            // 
            // NUMBER
            // 
            NUMBER.BackColor = Color.FromArgb(255, 128, 128);
            NUMBER.Font = new Font("Tahoma", 15F);
            NUMBER.Location = new Point(951, 68);
            NUMBER.Name = "NUMBER";
            NUMBER.Size = new Size(204, 56);
            NUMBER.TabIndex = 2;
            NUMBER.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lbkq
            // 
            lbkq.AutoSize = true;
            lbkq.BackColor = Color.Red;
            lbkq.Font = new Font("Tahoma", 15F);
            lbkq.ForeColor = Color.White;
            lbkq.Location = new Point(47, 446);
            lbkq.Name = "lbkq";
            lbkq.Size = new Size(226, 48);
            lbkq.TabIndex = 3;
            lbkq.Text = "Kết quả là :";
            // 
            // KQ
            // 
            KQ.AutoSize = true;
            KQ.Location = new Point(373, 362);
            KQ.Name = "KQ";
            KQ.Size = new Size(0, 32);
            KQ.TabIndex = 4;
            // 
            // TINH
            // 
            TINH.BackColor = Color.Red;
            TINH.Font = new Font("Tahoma", 15F);
            TINH.ForeColor = Color.White;
            TINH.Location = new Point(47, 177);
            TINH.Name = "TINH";
            TINH.Size = new Size(150, 65);
            TINH.TabIndex = 5;
            TINH.Text = "TÍNH";
            TINH.UseVisualStyleBackColor = false;
            TINH.Click += TINH_Click;
            // 
            // TRACKBAR
            // 
            TRACKBAR.Location = new Point(563, 152);
            TRACKBAR.Minimum = 1;
            TRACKBAR.Name = "TRACKBAR";
            TRACKBAR.Size = new Size(592, 90);
            TRACKBAR.TabIndex = 6;
            TRACKBAR.Value = 1;
            TRACKBAR.Scroll += trackBar1_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rd10);
            groupBox1.Controls.Add(rd9);
            groupBox1.Controls.Add(rd8);
            groupBox1.Controls.Add(rd7);
            groupBox1.Controls.Add(rd6);
            groupBox1.Controls.Add(rd5);
            groupBox1.Controls.Add(rd4);
            groupBox1.Controls.Add(rd3);
            groupBox1.Controls.Add(rd2);
            groupBox1.Controls.Add(rd1);
            groupBox1.Font = new Font("Tahoma", 15F);
            groupBox1.Location = new Point(393, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(828, 120);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rd10
            // 
            rd10.AutoSize = true;
            rd10.Location = new Point(731, 55);
            rd10.Name = "rd10";
            rd10.Size = new Size(95, 52);
            rd10.TabIndex = 9;
            rd10.TabStop = true;
            rd10.Text = "10";
            rd10.UseVisualStyleBackColor = true;
            // 
            // rd9
            // 
            rd9.AutoSize = true;
            rd9.Location = new Point(652, 55);
            rd9.Name = "rd9";
            rd9.Size = new Size(73, 52);
            rd9.TabIndex = 8;
            rd9.TabStop = true;
            rd9.Text = "9";
            rd9.UseVisualStyleBackColor = true;
            // 
            // rd8
            // 
            rd8.AutoSize = true;
            rd8.Location = new Point(573, 55);
            rd8.Name = "rd8";
            rd8.Size = new Size(73, 52);
            rd8.TabIndex = 7;
            rd8.TabStop = true;
            rd8.Text = "8";
            rd8.UseVisualStyleBackColor = true;
            // 
            // rd7
            // 
            rd7.AutoSize = true;
            rd7.Location = new Point(494, 55);
            rd7.Name = "rd7";
            rd7.Size = new Size(73, 52);
            rd7.TabIndex = 6;
            rd7.TabStop = true;
            rd7.Text = "7";
            rd7.UseVisualStyleBackColor = true;
            // 
            // rd6
            // 
            rd6.AutoSize = true;
            rd6.Location = new Point(415, 55);
            rd6.Name = "rd6";
            rd6.Size = new Size(73, 52);
            rd6.TabIndex = 5;
            rd6.TabStop = true;
            rd6.Text = "6";
            rd6.UseVisualStyleBackColor = true;
            // 
            // rd5
            // 
            rd5.AutoSize = true;
            rd5.Location = new Point(336, 55);
            rd5.Name = "rd5";
            rd5.Size = new Size(73, 52);
            rd5.TabIndex = 4;
            rd5.TabStop = true;
            rd5.Text = "5";
            rd5.UseVisualStyleBackColor = true;
            // 
            // rd4
            // 
            rd4.AutoSize = true;
            rd4.Location = new Point(257, 55);
            rd4.Name = "rd4";
            rd4.Size = new Size(73, 52);
            rd4.TabIndex = 3;
            rd4.TabStop = true;
            rd4.Text = "4";
            rd4.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            rd3.AutoSize = true;
            rd3.Location = new Point(178, 55);
            rd3.Name = "rd3";
            rd3.Size = new Size(73, 52);
            rd3.TabIndex = 2;
            rd3.TabStop = true;
            rd3.Text = "3";
            rd3.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            rd2.AutoSize = true;
            rd2.Location = new Point(99, 55);
            rd2.Name = "rd2";
            rd2.Size = new Size(73, 52);
            rd2.TabIndex = 1;
            rd2.TabStop = true;
            rd2.Text = "2";
            rd2.UseVisualStyleBackColor = true;
            // 
            // rd1
            // 
            rd1.AutoSize = true;
            rd1.Location = new Point(20, 55);
            rd1.Name = "rd1";
            rd1.Size = new Size(73, 52);
            rd1.TabIndex = 0;
            rd1.TabStop = true;
            rd1.Text = "1";
            rd1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Tahoma", 15F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 48;
            listBox1.Location = new Point(705, 404);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(397, 484);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // xemlai
            // 
            xemlai.BackColor = Color.Red;
            xemlai.Font = new Font("Tahoma", 15F);
            xemlai.ForeColor = Color.White;
            xemlai.Location = new Point(47, 295);
            xemlai.Name = "xemlai";
            xemlai.Size = new Size(291, 109);
            xemlai.TabIndex = 9;
            xemlai.Text = "Xem lại kết quả ";
            xemlai.UseVisualStyleBackColor = false;
            xemlai.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1259, 934);
            Controls.Add(xemlai);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(TRACKBAR);
            Controls.Add(TINH);
            Controls.Add(KQ);
            Controls.Add(lbkq);
            Controls.Add(NUMBER);
            Controls.Add(BCC);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BẢNG CỬU CHƯƠNG";
            ((System.ComponentModel.ISupportInitialize)NUMBER).EndInit();
            ((System.ComponentModel.ISupportInitialize)TRACKBAR).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox BCC;
        private NumericUpDown NUMBER;
        private Label lbkq;
        private Label KQ;
        private Button TINH;
        private TrackBar TRACKBAR;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button xemlai;
        private RadioButton rd10;
        private RadioButton rd9;
        private RadioButton rd8;
        private RadioButton rd7;
        private RadioButton rd6;
        private RadioButton rd5;
        private RadioButton rd4;
        private RadioButton rd3;
        private RadioButton rd2;
        private RadioButton rd1;
    }
}
