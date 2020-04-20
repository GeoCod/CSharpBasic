namespace Less_07
{
    partial class FormGuess
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
            this.tbxAnswer = new System.Windows.Forms.TextBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxAnswer
            // 
            this.tbxAnswer.Location = new System.Drawing.Point(14, 31);
            this.tbxAnswer.Name = "tbxAnswer";
            this.tbxAnswer.Size = new System.Drawing.Size(274, 20);
            this.tbxAnswer.TabIndex = 0;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(14, 58);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(274, 23);
            this.btnAnswer.TabIndex = 1;
            this.btnAnswer.Text = "button1";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.Location = new System.Drawing.Point(11, 96);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(277, 44);
            this.lblPrompt.TabIndex = 2;
            this.lblPrompt.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Угадай число от 1 до 100";
            // 
            // FormGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 150);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.tbxAnswer);
            this.Name = "FormGuess";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAnswer;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Label label2;
    }
}