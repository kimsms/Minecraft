namespace ImageAutoClick
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            X좌표 = new Label();
            Y좌표 = new Label();
            label5 = new Label();
            label6 = new Label();
            시작X = new TextBox();
            시작Y = new TextBox();
            끝X = new TextBox();
            끝Y = new TextBox();
            시작버튼 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            이미지버튼 = new Button();
            pictureBox1 = new PictureBox();
            클릭Y = new TextBox();
            클릭X = new TextBox();
            label3 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            중앙Y = new TextBox();
            중앙X = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 31);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "X :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 31);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 1;
            label2.Text = "Y :";
            // 
            // X좌표
            // 
            X좌표.AutoSize = true;
            X좌표.Location = new Point(47, 31);
            X좌표.Name = "X좌표";
            X좌표.Size = new Size(14, 15);
            X좌표.TabIndex = 2;
            X좌표.Text = "0";
            // 
            // Y좌표
            // 
            Y좌표.AutoSize = true;
            Y좌표.Location = new Point(120, 31);
            Y좌표.Name = "Y좌표";
            Y좌표.Size = new Size(14, 15);
            Y좌표.TabIndex = 3;
            Y좌표.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 70);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "시작영역";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 96);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 5;
            label6.Text = "끝 영역";
            // 
            // 시작X
            // 
            시작X.Location = new Point(81, 67);
            시작X.Name = "시작X";
            시작X.Size = new Size(48, 23);
            시작X.TabIndex = 6;
            시작X.Text = "790";
            // 
            // 시작Y
            // 
            시작Y.Location = new Point(164, 67);
            시작Y.Name = "시작Y";
            시작Y.Size = new Size(48, 23);
            시작Y.TabIndex = 7;
            시작Y.Text = "400";
            // 
            // 끝X
            // 
            끝X.Location = new Point(81, 93);
            끝X.Name = "끝X";
            끝X.Size = new Size(48, 23);
            끝X.TabIndex = 8;
            끝X.Text = "1130";
            // 
            // 끝Y
            // 
            끝Y.Location = new Point(164, 93);
            끝Y.Name = "끝Y";
            끝Y.Size = new Size(48, 23);
            끝Y.TabIndex = 9;
            끝Y.Text = "475";
            // 
            // 시작버튼
            // 
            시작버튼.Location = new Point(164, 326);
            시작버튼.Name = "시작버튼";
            시작버튼.Size = new Size(96, 23);
            시작버튼.TabIndex = 10;
            시작버튼.Text = "시작";
            시작버튼.UseVisualStyleBackColor = true;
            시작버튼.Click += 시작버튼_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // 이미지버튼
            // 
            이미지버튼.Location = new Point(20, 326);
            이미지버튼.Name = "이미지버튼";
            이미지버튼.Size = new Size(100, 23);
            이미지버튼.TabIndex = 11;
            이미지버튼.Text = "이미지 설정";
            이미지버튼.UseVisualStyleBackColor = true;
            이미지버튼.Click += 이미지버튼_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(20, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // 클릭Y
            // 
            클릭Y.Location = new Point(164, 122);
            클릭Y.Name = "클릭Y";
            클릭Y.Size = new Size(48, 23);
            클릭Y.TabIndex = 15;
            클릭Y.Text = "450";
            // 
            // 클릭X
            // 
            클릭X.Location = new Point(81, 122);
            클릭X.Name = "클릭X";
            클릭X.Size = new Size(48, 23);
            클릭X.TabIndex = 14;
            클릭X.Text = "1100";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 125);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 13;
            label3.Text = "클릭 영역";
            // 
            // timer2
            // 
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 151);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 18;
            label7.Text = "중앙 위치";
            // 
            // 중앙Y
            // 
            중앙Y.Location = new Point(164, 148);
            중앙Y.Name = "중앙Y";
            중앙Y.Size = new Size(48, 23);
            중앙Y.TabIndex = 20;
            중앙Y.Text = "531";
            // 
            // 중앙X
            // 
            중앙X.Location = new Point(81, 148);
            중앙X.Name = "중앙X";
            중앙X.Size = new Size(48, 23);
            중앙X.TabIndex = 19;
            중앙X.Text = "960";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(중앙Y);
            Controls.Add(중앙X);
            Controls.Add(label7);
            Controls.Add(클릭Y);
            Controls.Add(클릭X);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(이미지버튼);
            Controls.Add(시작버튼);
            Controls.Add(끝Y);
            Controls.Add(끝X);
            Controls.Add(시작Y);
            Controls.Add(시작X);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Y좌표);
            Controls.Add(X좌표);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(300, 400);
            MinimumSize = new Size(300, 400);
            Name = "Main";
            Text = "AutoClick(by.Aibot0729)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label X좌표;
        private Label Y좌표;
        private Label label5;
        private Label label6;
        private TextBox 시작X;
        private TextBox 시작Y;
        private TextBox 끝X;
        private TextBox 끝Y;
        private Button 시작버튼;
        private System.Windows.Forms.Timer timer1;
        private Button 이미지버튼;
        private PictureBox pictureBox1;
        private TextBox 클릭Y;
        private TextBox 클릭X;
        private Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label label7;
        private TextBox 중앙Y;
        private TextBox 중앙X;
    }
}