namespace BlackJack
{
    partial class blackJackForm
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
            this.shuffleButton = new System.Windows.Forms.Button();
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.dealerListBox = new System.Windows.Forms.ListBox();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerSumLabel = new System.Windows.Forms.Label();
            this.dealerSumLabel = new System.Windows.Forms.Label();
            this.stayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(242, 12);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(75, 23);
            this.shuffleButton.TabIndex = 0;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(242, 41);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 23);
            this.dealButton.TabIndex = 1;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(242, 125);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 49);
            this.hitButton.TabIndex = 2;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // dealerListBox
            // 
            this.dealerListBox.FormattingEnabled = true;
            this.dealerListBox.Location = new System.Drawing.Point(45, 97);
            this.dealerListBox.Name = "dealerListBox";
            this.dealerListBox.Size = new System.Drawing.Size(141, 160);
            this.dealerListBox.TabIndex = 10;
            // 
            // playerListBox
            // 
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.Location = new System.Drawing.Point(382, 97);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(141, 160);
            this.playerListBox.TabIndex = 11;
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Location = new System.Drawing.Point(92, 51);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(38, 13);
            this.dealerLabel.TabIndex = 12;
            this.dealerLabel.Text = "Dealer";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(431, 51);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(36, 13);
            this.playerLabel.TabIndex = 13;
            this.playerLabel.Text = "Player";
            // 
            // playerSumLabel
            // 
            this.playerSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerSumLabel.Location = new System.Drawing.Point(406, 289);
            this.playerSumLabel.Name = "playerSumLabel";
            this.playerSumLabel.Size = new System.Drawing.Size(100, 23);
            this.playerSumLabel.TabIndex = 14;
            // 
            // dealerSumLabel
            // 
            this.dealerSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dealerSumLabel.Location = new System.Drawing.Point(66, 289);
            this.dealerSumLabel.Name = "dealerSumLabel";
            this.dealerSumLabel.Size = new System.Drawing.Size(100, 23);
            this.dealerSumLabel.TabIndex = 15;
            // 
            // stayButton
            // 
            this.stayButton.Location = new System.Drawing.Point(242, 194);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(75, 49);
            this.stayButton.TabIndex = 16;
            this.stayButton.Text = "Stay";
            this.stayButton.UseVisualStyleBackColor = true;
            this.stayButton.Click += new System.EventHandler(this.stayButton_Click);
            // 
            // blackJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 371);
            this.Controls.Add(this.stayButton);
            this.Controls.Add(this.dealerSumLabel);
            this.Controls.Add(this.playerSumLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.dealerListBox);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.shuffleButton);
            this.Name = "blackJackForm";
            this.Text = "Blackjack Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.ListBox dealerListBox;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerSumLabel;
        private System.Windows.Forms.Label dealerSumLabel;
        private System.Windows.Forms.Button stayButton;
    }
}

