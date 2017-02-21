namespace TableGenerator
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelSNPrefix = new System.Windows.Forms.Label();
            this.textBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(34, 53);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(119, 23);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "&Generate Table";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(30, 91);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(466, 111);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "<Result>";
            // 
            // labelSNPrefix
            // 
            this.labelSNPrefix.AutoSize = true;
            this.labelSNPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSNPrefix.Location = new System.Drawing.Point(200, 53);
            this.labelSNPrefix.Name = "labelSNPrefix";
            this.labelSNPrefix.Size = new System.Drawing.Size(41, 20);
            this.labelSNPrefix.TabIndex = 0;
            this.labelSNPrefix.Text = "A00";
            // 
            // textBoxStudentNumber
            // 
            this.textBoxStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentNumber.Location = new System.Drawing.Point(242, 50);
            this.textBoxStudentNumber.Name = "textBoxStudentNumber";
            this.textBoxStudentNumber.Size = new System.Drawing.Size(83, 26);
            this.textBoxStudentNumber.TabIndex = 1;
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.Location = new System.Drawing.Point(31, 23);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(318, 15);
            this.labelPrompt.TabIndex = 4;
            this.labelPrompt.Text = "Complete your Student Number and click Generate Table";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(528, 225);
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.labelSNPrefix);
            this.Controls.Add(this.textBoxStudentNumber);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMP2614 Assignment 6 Table  Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxStudentNumber;
        private System.Windows.Forms.Label labelSNPrefix;
        private System.Windows.Forms.Label labelPrompt;
    }
}

