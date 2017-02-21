namespace COMP2614Assign06
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
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.labelClientCode = new System.Windows.Forms.Label();
            this.textBoxClientCode = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.labelProvince = new System.Windows.Forms.Label();
            this.textBoxYTDSales = new System.Windows.Forms.TextBox();
            this.labelYTDSales = new System.Windows.Forms.Label();
            this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonSaveClient = new System.Windows.Forms.Button();
            this.errorProviderMainForm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxClients
            // 
            this.listBoxClients.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.IntegralHeight = false;
            this.listBoxClients.Location = new System.Drawing.Point(0, 0);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(165, 461);
            this.listBoxClients.TabIndex = 0;
            this.listBoxClients.SelectedIndexChanged += new System.EventHandler(this.listBoxClients_SelectedIndexChanged);
            // 
            // labelClientCode
            // 
            this.labelClientCode.AutoSize = true;
            this.labelClientCode.Location = new System.Drawing.Point(198, 40);
            this.labelClientCode.Name = "labelClientCode";
            this.labelClientCode.Size = new System.Drawing.Size(61, 13);
            this.labelClientCode.TabIndex = 1;
            this.labelClientCode.Text = "ClientCo&de:";
            // 
            // textBoxClientCode
            // 
            this.textBoxClientCode.Location = new System.Drawing.Point(280, 37);
            this.textBoxClientCode.Name = "textBoxClientCode";
            this.textBoxClientCode.Size = new System.Drawing.Size(270, 20);
            this.textBoxClientCode.TabIndex = 2;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(280, 71);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(270, 20);
            this.textBoxCompanyName.TabIndex = 4;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(198, 74);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(82, 13);
            this.labelCompanyName.TabIndex = 3;
            this.labelCompanyName.Text = "Co&mpanyName:";
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(280, 105);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(270, 20);
            this.textBoxAddress1.TabIndex = 6;
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(198, 108);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(54, 13);
            this.labelAddress1.TabIndex = 5;
            this.labelAddress1.Text = "&Address1:";
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(280, 139);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(270, 20);
            this.textBoxAddress2.TabIndex = 8;
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(198, 142);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(54, 13);
            this.labelAddress2.TabIndex = 7;
            this.labelAddress2.Text = "&Address2:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(280, 173);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(270, 20);
            this.textBoxCity.TabIndex = 10;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(198, 176);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 9;
            this.labelCity.Text = "&City:";
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(280, 207);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(90, 20);
            this.textBoxProvince.TabIndex = 12;
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(198, 210);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(52, 13);
            this.labelProvince.TabIndex = 11;
            this.labelProvince.Text = "&Province:";
            // 
            // textBoxYTDSales
            // 
            this.textBoxYTDSales.Location = new System.Drawing.Point(280, 241);
            this.textBoxYTDSales.Name = "textBoxYTDSales";
            this.textBoxYTDSales.Size = new System.Drawing.Size(270, 20);
            this.textBoxYTDSales.TabIndex = 16;
            // 
            // labelYTDSales
            // 
            this.labelYTDSales.AutoSize = true;
            this.labelYTDSales.Location = new System.Drawing.Point(198, 244);
            this.labelYTDSales.Name = "labelYTDSales";
            this.labelYTDSales.Size = new System.Drawing.Size(58, 13);
            this.labelYTDSales.TabIndex = 15;
            this.labelYTDSales.Text = "&YTDSales:";
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(280, 275);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(75, 17);
            this.checkBoxCreditHold.TabIndex = 17;
            this.checkBoxCreditHold.Text = "Credit&Hold";
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(280, 309);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(270, 60);
            this.textBoxNotes.TabIndex = 19;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(198, 312);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(38, 13);
            this.labelNotes.TabIndex = 18;
            this.labelNotes.Text = "No&tes:";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(460, 207);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(90, 20);
            this.textBoxPostalCode.TabIndex = 14;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(390, 210);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(64, 13);
            this.labelPostalCode.TabIndex = 13;
            this.labelPostalCode.Text = "P&ostalCode:";
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(201, 407);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(75, 23);
            this.buttonNewClient.TabIndex = 20;
            this.buttonNewClient.Text = "&New Client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Location = new System.Drawing.Point(340, 407);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteClient.TabIndex = 21;
            this.buttonDeleteClient.Text = "&Delete";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // buttonSaveClient
            // 
            this.buttonSaveClient.Location = new System.Drawing.Point(475, 407);
            this.buttonSaveClient.Name = "buttonSaveClient";
            this.buttonSaveClient.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveClient.TabIndex = 22;
            this.buttonSaveClient.Text = "&Save";
            this.buttonSaveClient.UseVisualStyleBackColor = true;
            this.buttonSaveClient.Click += new System.EventHandler(this.buttonSaveClient_Click);
            // 
            // errorProviderMainForm
            // 
            this.errorProviderMainForm.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSaveClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonSaveClient);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.buttonNewClient);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.checkBoxCreditHold);
            this.Controls.Add(this.textBoxYTDSales);
            this.Controls.Add(this.labelYTDSales);
            this.Controls.Add(this.textBoxProvince);
            this.Controls.Add(this.labelProvince);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxAddress2);
            this.Controls.Add(this.labelAddress2);
            this.Controls.Add(this.textBoxAddress1);
            this.Controls.Add(this.labelAddress1);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.textBoxClientCode);
            this.Controls.Add(this.labelClientCode);
            this.Controls.Add(this.listBoxClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Label labelClientCode;
        private System.Windows.Forms.TextBox textBoxClientCode;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.TextBox textBoxYTDSales;
        private System.Windows.Forms.Label labelYTDSales;
        private System.Windows.Forms.CheckBox checkBoxCreditHold;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonSaveClient;
        private System.Windows.Forms.ErrorProvider errorProviderMainForm;
    }
}

