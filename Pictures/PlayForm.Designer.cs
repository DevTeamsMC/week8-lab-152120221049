namespace OOP2_Exp6_Grp10.Pictures
{
    partial class PlayForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            GameOverBtn = new Button();
            GuessBtn = new Button();
            GuessTxtBox = new TextBox();
            PointLabel = new Label();
            WrongLetterLbl = new Label();
            WorlLengthLbl = new Label();
            TipButton = new Button();
            WordLabel = new Label();
            groupBox2 = new GroupBox();
            hangManpb = new PictureBox();
            label1 = new Label();
            TimerLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            DiffInfoLbl = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hangManpb).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GameOverBtn);
            groupBox1.Controls.Add(GuessBtn);
            groupBox1.Controls.Add(GuessTxtBox);
            groupBox1.Controls.Add(PointLabel);
            groupBox1.Controls.Add(WrongLetterLbl);
            groupBox1.Controls.Add(WorlLengthLbl);
            groupBox1.Controls.Add(TipButton);
            groupBox1.Controls.Add(WordLabel);
            groupBox1.Location = new Point(12, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 323);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "  ";
            // 
            // GameOverBtn
            // 
            GameOverBtn.BackColor = Color.SandyBrown;
            GameOverBtn.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GameOverBtn.Location = new Point(273, 275);
            GameOverBtn.Name = "GameOverBtn";
            GameOverBtn.Size = new Size(96, 23);
            GameOverBtn.TabIndex = 7;
            GameOverBtn.Text = "Oyunu Bitir";
            GameOverBtn.UseVisualStyleBackColor = false;
            GameOverBtn.Click += GameOverBtn_Click;
            // 
            // GuessBtn
            // 
            GuessBtn.BackColor = Color.Ivory;
            GuessBtn.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuessBtn.Location = new Point(178, 274);
            GuessBtn.Name = "GuessBtn";
            GuessBtn.Size = new Size(89, 23);
            GuessBtn.TabIndex = 6;
            GuessBtn.Text = "Tahmin Et";
            GuessBtn.UseVisualStyleBackColor = false;
            GuessBtn.Click += GuessBtn_Click;
            // 
            // GuessTxtBox
            // 
            GuessTxtBox.Location = new Point(6, 275);
            GuessTxtBox.Name = "GuessTxtBox";
            GuessTxtBox.Size = new Size(100, 23);
            GuessTxtBox.TabIndex = 5;
            // 
            // PointLabel
            // 
            PointLabel.AutoSize = true;
            PointLabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PointLabel.Location = new Point(6, 218);
            PointLabel.Name = "PointLabel";
            PointLabel.Size = new Size(62, 20);
            PointLabel.TabIndex = 4;
            PointLabel.Text = "Puan:";
            // 
            // WrongLetterLbl
            // 
            WrongLetterLbl.AutoSize = true;
            WrongLetterLbl.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WrongLetterLbl.Location = new Point(6, 189);
            WrongLetterLbl.Name = "WrongLetterLbl";
            WrongLetterLbl.Size = new Size(107, 15);
            WrongLetterLbl.TabIndex = 3;
            WrongLetterLbl.Text = "Yanlış harfler:";
            // 
            // WorlLengthLbl
            // 
            WorlLengthLbl.AutoSize = true;
            WorlLengthLbl.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WorlLengthLbl.Location = new Point(6, 158);
            WorlLengthLbl.Name = "WorlLengthLbl";
            WorlLengthLbl.Size = new Size(124, 15);
            WorlLengthLbl.TabIndex = 2;
            WorlLengthLbl.Text = "Kelime Uzunluğu:";
            // 
            // TipButton
            // 
            TipButton.BackColor = Color.IndianRed;
            TipButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TipButton.Location = new Point(273, 88);
            TipButton.Name = "TipButton";
            TipButton.Size = new Size(75, 23);
            TipButton.TabIndex = 1;
            TipButton.Text = "Ipucu";
            TipButton.UseVisualStyleBackColor = false;
            TipButton.Click += TipButton_Click;
            // 
            // WordLabel
            // 
            WordLabel.AutoSize = true;
            WordLabel.BackColor = SystemColors.ActiveBorder;
            WordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WordLabel.Location = new Point(6, 41);
            WordLabel.Name = "WordLabel";
            WordLabel.Size = new Size(0, 30);
            WordLabel.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hangManpb);
            groupBox2.Location = new Point(390, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(375, 323);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "                   ";
            // 
            // hangManpb
            // 
            hangManpb.Location = new Point(0, 8);
            hangManpb.Name = "hangManpb";
            hangManpb.Size = new Size(375, 315);
            hangManpb.SizeMode = PictureBoxSizeMode.StretchImage;
            hangManpb.TabIndex = 0;
            hangManpb.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 2;
            label1.Text = "HANGMAN";
            // 
            // TimerLbl
            // 
            TimerLbl.AutoSize = true;
            TimerLbl.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimerLbl.Location = new Point(40, 48);
            TimerLbl.Name = "TimerLbl";
            TimerLbl.Size = new Size(82, 30);
            TimerLbl.TabIndex = 3;
            TimerLbl.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // DiffInfoLbl
            // 
            DiffInfoLbl.AutoSize = true;
            DiffInfoLbl.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiffInfoLbl.Location = new Point(285, 51);
            DiffInfoLbl.Name = "DiffInfoLbl";
            DiffInfoLbl.Size = new Size(346, 27);
            DiffInfoLbl.TabIndex = 4;
            DiffInfoLbl.Text = "Topic:       Difficulty:       Time:       ";
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DiffInfoLbl);
            Controls.Add(TimerLbl);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PlayForm";
            Text = "PlayForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hangManpb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label WorlLengthLbl;
        private Button TipButton;
        private Label WordLabel;
        private Button GameOverBtn;
        private Button GuessBtn;
        private TextBox GuessTxtBox;
        private Label PointLabel;
        private Label WrongLetterLbl;
        private PictureBox hangManpb;
        private Label TimerLbl;
        private System.Windows.Forms.Timer timer1;
        private Label DiffInfoLbl;
    }
}