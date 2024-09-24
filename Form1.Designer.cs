namespace Rock_Paper_Scissors
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
            titleLabel = new Label();
            userLbl = new Label();
            botLbl = new Label();
            shoot_button = new Button();
            rockRadio = new RadioButton();
            paperBtn = new RadioButton();
            scissorsBtn = new RadioButton();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Tw Cen MT Condensed Extra Bold", 16.2782612F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = SystemColors.ControlText;
            titleLabel.Location = new Point(419, 44);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(220, 31);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Rock, Paper, Scissors";
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Font = new Font("Segoe UI", 8.765218F, FontStyle.Underline, GraphicsUnit.Point, 0);
            userLbl.Location = new Point(267, 142);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(38, 20);
            userLbl.TabIndex = 1;
            userLbl.Text = "User";
            // 
            // botLbl
            // 
            botLbl.AutoSize = true;
            botLbl.Font = new Font("Segoe UI", 8.765218F, FontStyle.Underline, GraphicsUnit.Point, 0);
            botLbl.Location = new Point(732, 142);
            botLbl.Name = "botLbl";
            botLbl.Size = new Size(32, 20);
            botLbl.TabIndex = 2;
            botLbl.Text = "Bot";
            // 
            // shoot_button
            // 
            shoot_button.Location = new Point(471, 424);
            shoot_button.Name = "shoot_button";
            shoot_button.Size = new Size(136, 45);
            shoot_button.TabIndex = 3;
            shoot_button.Text = "Shoot!";
            shoot_button.UseVisualStyleBackColor = true;
            // 
            // rockRadio
            // 
            rockRadio.AutoSize = true;
            rockRadio.Location = new Point(491, 260);
            rockRadio.Name = "rockRadio";
            rockRadio.Size = new Size(59, 24);
            rockRadio.TabIndex = 4;
            rockRadio.TabStop = true;
            rockRadio.Text = "Rock";
            rockRadio.UseVisualStyleBackColor = true;
            // 
            // paperBtn
            // 
            paperBtn.AutoSize = true;
            paperBtn.Location = new Point(491, 314);
            paperBtn.Name = "paperBtn";
            paperBtn.Size = new Size(64, 24);
            paperBtn.TabIndex = 5;
            paperBtn.TabStop = true;
            paperBtn.Text = "Paper";
            paperBtn.UseVisualStyleBackColor = true;
            // 
            // scissorsBtn
            // 
            scissorsBtn.AutoSize = true;
            scissorsBtn.Location = new Point(491, 367);
            scissorsBtn.Name = "scissorsBtn";
            scissorsBtn.Size = new Size(78, 24);
            scissorsBtn.TabIndex = 6;
            scissorsBtn.TabStop = true;
            scissorsBtn.Text = "Scissors";
            scissorsBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 847);
            Controls.Add(scissorsBtn);
            Controls.Add(paperBtn);
            Controls.Add(rockRadio);
            Controls.Add(shoot_button);
            Controls.Add(botLbl);
            Controls.Add(userLbl);
            Controls.Add(titleLabel);
            Name = "Form1";
            Text = "C# Project #1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label userLbl;
        private Label botLbl;
        private Button shoot_button;
        private RadioButton rockRadio;
        private RadioButton paperBtn;
        private RadioButton scissorsBtn;
    }
}
