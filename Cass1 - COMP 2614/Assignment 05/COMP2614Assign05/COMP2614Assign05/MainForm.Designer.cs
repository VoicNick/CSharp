namespace COMP2614Assign05
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.buttonCheckDate = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.toolTipOnMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(10, 11);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "&Year:";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(164, 11);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(29, 13);
            this.labelDay.TabIndex = 4;
            this.labelDay.Text = "&Day:";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(87, 11);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(40, 13);
            this.labelMonth.TabIndex = 2;
            this.labelMonth.Text = "&Month:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(14, 27);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(70, 20);
            this.textBoxYear.TabIndex = 1;
            this.textBoxYear.Enter += new System.EventHandler(this.textBoxYear_Enter);
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(89, 27);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(70, 20);
            this.textBoxMonth.TabIndex = 3;
            this.textBoxMonth.Enter += new System.EventHandler(this.textBoxMonth_Enter);
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(163, 27);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(70, 20);
            this.textBoxDay.TabIndex = 5;
            this.textBoxDay.Enter += new System.EventHandler(this.textBoxDay_Enter);
            // 
            // buttonCheckDate
            // 
            this.buttonCheckDate.Location = new System.Drawing.Point(150, 81);
            this.buttonCheckDate.Name = "buttonCheckDate";
            this.buttonCheckDate.Size = new System.Drawing.Size(82, 24);
            this.buttonCheckDate.TabIndex = 7;
            this.buttonCheckDate.Text = "&Check Date";
            this.buttonCheckDate.UseVisualStyleBackColor = true;
            this.buttonCheckDate.Click += new System.EventHandler(this.buttonCheckDate_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(9, 78);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(96, 24);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "<Output>";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonCheckDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 125);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonCheckDate);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Validator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.Button buttonCheckDate;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.ToolTip toolTipOnMainForm;
    }
}

