
namespace AThreadsUI
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
            this.bGetQotD = new System.Windows.Forms.Button();
            this.tbQotD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bGetQotD
            // 
            this.bGetQotD.Location = new System.Drawing.Point(12, 12);
            this.bGetQotD.Name = "bGetQotD";
            this.bGetQotD.Size = new System.Drawing.Size(135, 55);
            this.bGetQotD.TabIndex = 0;
            this.bGetQotD.Text = "Get QotD";
            this.bGetQotD.UseVisualStyleBackColor = true;
            this.bGetQotD.Click += new System.EventHandler(this.bGetQotD_Click);
            // 
            // tbQotD
            // 
            this.tbQotD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbQotD.Location = new System.Drawing.Point(12, 84);
            this.tbQotD.Multiline = true;
            this.tbQotD.Name = "tbQotD";
            this.tbQotD.Size = new System.Drawing.Size(547, 127);
            this.tbQotD.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 282);
            this.Controls.Add(this.tbQotD);
            this.Controls.Add(this.bGetQotD);
            this.Name = "MainForm";
            this.Text = "Threads and UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGetQotD;
        private System.Windows.Forms.TextBox tbQotD;
    }
}

