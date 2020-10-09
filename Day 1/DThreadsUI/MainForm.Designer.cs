namespace DThreadsUI
{
    partial class MainForm
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
            this.bGetUltimateAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGetUltimateAnswer
            // 
            this.bGetUltimateAnswer.Location = new System.Drawing.Point(81, 58);
            this.bGetUltimateAnswer.Name = "bGetUltimateAnswer";
            this.bGetUltimateAnswer.Size = new System.Drawing.Size(189, 78);
            this.bGetUltimateAnswer.TabIndex = 0;
            this.bGetUltimateAnswer.Text = "Ultimate Answer";
            this.bGetUltimateAnswer.UseVisualStyleBackColor = true;
            this.bGetUltimateAnswer.Click += new System.EventHandler(this.bGetUltimateAnswer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bGetUltimateAnswer);
            this.Name = "MainForm";
            this.Text = "Threads and UI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGetUltimateAnswer;
    }
}

