namespace GuessingGame
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
            Words = new Label();
            UserInput = new TextBox();
            Guess = new Button();
            Next = new Button();
            Result = new Label();
            ListBox = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Words
            // 
            Words.BackColor = Color.HotPink;
            Words.BorderStyle = BorderStyle.FixedSingle;
            Words.FlatStyle = FlatStyle.Flat;
            Words.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Words.ForeColor = Color.Black;
            Words.Location = new Point(35, 34);
            Words.Name = "Words";
            Words.Size = new Size(330, 71);
            Words.TabIndex = 0;
            Words.Text = "Guess the Words!";
            Words.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserInput
            // 
            UserInput.Font = new Font("Bahnschrift SemiLight SemiConde", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserInput.Location = new Point(53, 126);
            UserInput.Name = "UserInput";
            UserInput.Size = new Size(293, 46);
            UserInput.TabIndex = 1;
            UserInput.TextAlign = HorizontalAlignment.Center;
            // 
            // Guess
            // 
            Guess.BackColor = Color.MediumPurple;
            Guess.FlatAppearance.BorderColor = Color.Black;
            Guess.FlatAppearance.BorderSize = 2;
            Guess.FlatStyle = FlatStyle.Flat;
            Guess.Font = new Font("High Tower Text", 21.75F);
            Guess.Location = new Point(93, 190);
            Guess.Name = "Guess";
            Guess.Size = new Size(208, 55);
            Guess.TabIndex = 2;
            Guess.Tag = "Start";
            Guess.Text = "Start";
            Guess.UseVisualStyleBackColor = false;
            Guess.Click += button1_Click;
            // 
            // Next
            // 
            Next.BackColor = Color.MediumPurple;
            Next.Enabled = false;
            Next.FlatAppearance.BorderColor = Color.Black;
            Next.FlatAppearance.BorderSize = 2;
            Next.FlatStyle = FlatStyle.Flat;
            Next.Font = new Font("High Tower Text", 21.75F);
            Next.Location = new Point(93, 251);
            Next.Name = "Next";
            Next.Size = new Size(208, 55);
            Next.TabIndex = 3;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = false;
            Next.Click += button2_Click;
            // 
            // Result
            // 
            Result.BackColor = Color.Orchid;
            Result.BorderStyle = BorderStyle.FixedSingle;
            Result.FlatStyle = FlatStyle.Flat;
            Result.Font = new Font("High Tower Text", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result.ForeColor = SystemColors.ControlText;
            Result.Location = new Point(93, 329);
            Result.Name = "Result";
            Result.Size = new Size(208, 55);
            Result.TabIndex = 4;
            Result.Text = "GoodLuck!";
            Result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ListBox
            // 
            ListBox.BackColor = Color.Plum;
            ListBox.BorderStyle = BorderStyle.FixedSingle;
            ListBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 20;
            ListBox.Location = new Point(420, 69);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(198, 322);
            ListBox.TabIndex = 5;
            ListBox.SelectedIndexChanged += WrongGuess_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Orchid;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("High Tower Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(445, 31);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 6;
            label1.Text = "Wrong Guess";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(662, 414);
            Controls.Add(label1);
            Controls.Add(ListBox);
            Controls.Add(Result);
            Controls.Add(Next);
            Controls.Add(Guess);
            Controls.Add(UserInput);
            Controls.Add(Words);
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Words;
        private TextBox UserInput;
        private Button Guess;
        private Button Next;
        private Label Result;
        private ListBox ListBox;
        private Label label1;
    }
}
