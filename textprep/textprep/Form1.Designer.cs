namespace textprep
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
            btnAnswer = new Button();
            tbFirstNumber = new TextBox();
            TextMessage = new Label();
            tbSecondNumber = new TextBox();
            SuspendLayout();
            // 
            // btnAnswer
            // 
            btnAnswer.Location = new Point(90, 90);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(75, 25);
            btnAnswer.TabIndex = 0;
            btnAnswer.Text = "Answer";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += button1_Click;
            // 
            // tbFirstNumber
            // 
            tbFirstNumber.Location = new Point(40, 35);
            tbFirstNumber.Name = "tbFirstNumber";
            tbFirstNumber.Size = new Size(50, 27);
            tbFirstNumber.TabIndex = 1;
            tbFirstNumber.Text = "10";
            tbFirstNumber.TextChanged += textBox1_TextChanged;
            // 
            // TextMessage
            // 
            TextMessage.AutoSize = true;
            TextMessage.Location = new Point(87, 126);
            TextMessage.Name = "TextMessage";
            TextMessage.Size = new Size(102, 20);
            TextMessage.TabIndex = 2;
            TextMessage.Text = "Message Area";
            // 
            // tbSecondNumber
            // 
            tbSecondNumber.Location = new Point(264, 35);
            tbSecondNumber.Name = "tbSecondNumber";
            tbSecondNumber.Size = new Size(125, 27);
            tbSecondNumber.TabIndex = 3;
            tbSecondNumber.Text = "5";
            tbSecondNumber.TextChanged += tbSecondNumber_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbSecondNumber);
            Controls.Add(TextMessage);
            Controls.Add(tbFirstNumber);
            Controls.Add(btnAnswer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnswer;
        private TextBox tbFirstNumber;
        private Label TextMessage;
        private TextBox tbSecondNumber;
    }
}
