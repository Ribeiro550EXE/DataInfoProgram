namespace Vetores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BAddContact = new System.Windows.Forms.Button();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.AddContact = new System.Windows.Forms.TextBox();
            this.Information = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeT = new System.Windows.Forms.TextBox();
            this.LocT = new System.Windows.Forms.TextBox();
            this.NumT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.FoundText = new System.Windows.Forms.TextBox();
            this.LFound = new System.Windows.Forms.Label();
            this.LocTF = new System.Windows.Forms.Label();
            this.Founded = new System.Windows.Forms.Label();
            this.NumTF = new System.Windows.Forms.Label();
            this.AgeTF = new System.Windows.Forms.Label();
            this.ReadFilesRTB = new System.Windows.Forms.Label();
            this.FRFile = new System.Windows.Forms.Label();
            this.CDFT = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.BirthDate = new System.Windows.Forms.Label();
            this.BirthT = new System.Windows.Forms.TextBox();
            this.BTDeleteMultipleFiles = new System.Windows.Forms.Button();
            this.TXTPATH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BAddContact
            // 
            this.BAddContact.Location = new System.Drawing.Point(218, 57);
            this.BAddContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BAddContact.Name = "BAddContact";
            this.BAddContact.Size = new System.Drawing.Size(112, 35);
            this.BAddContact.TabIndex = 0;
            this.BAddContact.Text = "Add";
            this.BAddContact.UseVisualStyleBackColor = true;
            this.BAddContact.Click += new System.EventHandler(this.BAddContact_Click);
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(152, 105);
            this.ContactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(0, 20);
            this.ContactLabel.TabIndex = 1;
            // 
            // AddContact
            // 
            this.AddContact.Location = new System.Drawing.Point(58, 62);
            this.AddContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddContact.Name = "AddContact";
            this.AddContact.Size = new System.Drawing.Size(148, 26);
            this.AddContact.TabIndex = 2;
            this.AddContact.TextChanged += new System.EventHandler(this.AddContact_TextChanged);
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Location = new System.Drawing.Point(804, 57);
            this.Information.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(13, 20);
            this.Information.TabIndex = 3;
            this.Information.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "NºTel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loc";
            // 
            // AgeT
            // 
            this.AgeT.Location = new System.Drawing.Point(424, 155);
            this.AgeT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgeT.Name = "AgeT";
            this.AgeT.Size = new System.Drawing.Size(148, 26);
            this.AgeT.TabIndex = 7;
            // 
            // LocT
            // 
            this.LocT.Location = new System.Drawing.Point(424, 68);
            this.LocT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LocT.Name = "LocT";
            this.LocT.Size = new System.Drawing.Size(148, 26);
            this.LocT.TabIndex = 8;
            // 
            // NumT
            // 
            this.NumT.Location = new System.Drawing.Point(424, 25);
            this.NumT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumT.MaxLength = 9;
            this.NumT.Name = "NumT";
            this.NumT.Size = new System.Drawing.Size(148, 26);
            this.NumT.TabIndex = 9;
            this.NumT.TextChanged += new System.EventHandler(this.NumT_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(873, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 11;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(363, 175);
            this.LName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(13, 20);
            this.LName.TabIndex = 12;
            this.LName.Text = ".";
            // 
            // FoundText
            // 
            this.FoundText.Location = new System.Drawing.Point(831, 18);
            this.FoundText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FoundText.Name = "FoundText";
            this.FoundText.Size = new System.Drawing.Size(148, 26);
            this.FoundText.TabIndex = 13;
            this.FoundText.TextChanged += new System.EventHandler(this.FoundText_TextChanged);
            // 
            // LFound
            // 
            this.LFound.AutoSize = true;
            this.LFound.Location = new System.Drawing.Point(747, 18);
            this.LFound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFound.Name = "LFound";
            this.LFound.Size = new System.Drawing.Size(73, 20);
            this.LFound.TabIndex = 14;
            this.LFound.Text = "Found IT";
            // 
            // LocTF
            // 
            this.LocTF.AutoSize = true;
            this.LocTF.Location = new System.Drawing.Point(826, 135);
            this.LocTF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocTF.Name = "LocTF";
            this.LocTF.Size = new System.Drawing.Size(35, 20);
            this.LocTF.TabIndex = 15;
            this.LocTF.Text = "Loc";
            // 
            // Founded
            // 
            this.Founded.AutoSize = true;
            this.Founded.Location = new System.Drawing.Point(828, 77);
            this.Founded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Founded.Name = "Founded";
            this.Founded.Size = new System.Drawing.Size(18, 20);
            this.Founded.TabIndex = 16;
            this.Founded.Text = "1";
            // 
            // NumTF
            // 
            this.NumTF.AutoSize = true;
            this.NumTF.Location = new System.Drawing.Point(826, 155);
            this.NumTF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumTF.Name = "NumTF";
            this.NumTF.Size = new System.Drawing.Size(90, 20);
            this.NumTF.TabIndex = 17;
            this.NumTF.Text = "000000000";
            // 
            // AgeTF
            // 
            this.AgeTF.AutoSize = true;
            this.AgeTF.Location = new System.Drawing.Point(826, 175);
            this.AgeTF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeTF.Name = "AgeTF";
            this.AgeTF.Size = new System.Drawing.Size(36, 20);
            this.AgeTF.TabIndex = 18;
            this.AgeTF.Text = "000";
            // 
            // ReadFilesRTB
            // 
            this.ReadFilesRTB.AutoSize = true;
            this.ReadFilesRTB.Location = new System.Drawing.Point(396, 332);
            this.ReadFilesRTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReadFilesRTB.Name = "ReadFilesRTB";
            this.ReadFilesRTB.Size = new System.Drawing.Size(90, 20);
            this.ReadFilesRTB.TabIndex = 19;
            this.ReadFilesRTB.Text = "000000000";
            // 
            // FRFile
            // 
            this.FRFile.AutoSize = true;
            this.FRFile.Location = new System.Drawing.Point(826, 260);
            this.FRFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FRFile.Name = "FRFile";
            this.FRFile.Size = new System.Drawing.Size(90, 20);
            this.FRFile.TabIndex = 20;
            this.FRFile.Text = "000000000";
            // 
            // CDFT
            // 
            this.CDFT.AutoSize = true;
            this.CDFT.Location = new System.Drawing.Point(826, 388);
            this.CDFT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CDFT.Name = "CDFT";
            this.CDFT.Size = new System.Drawing.Size(90, 20);
            this.CDFT.TabIndex = 21;
            this.CDFT.Text = "000000000";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(832, 434);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 35);
            this.Delete.TabIndex = 22;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(363, 115);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(42, 20);
            this.BirthDate.TabIndex = 23;
            this.BirthDate.Text = "Birth";
            // 
            // BirthT
            // 
            this.BirthT.Location = new System.Drawing.Point(424, 111);
            this.BirthT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BirthT.Name = "BirthT";
            this.BirthT.Size = new System.Drawing.Size(148, 26);
            this.BirthT.TabIndex = 24;
            this.BirthT.TextChanged += new System.EventHandler(this.BirthT_TextChanged);
            // 
            // BTDeleteMultipleFiles
            // 
            this.BTDeleteMultipleFiles.Location = new System.Drawing.Point(966, 609);
            this.BTDeleteMultipleFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTDeleteMultipleFiles.Name = "BTDeleteMultipleFiles";
            this.BTDeleteMultipleFiles.Size = new System.Drawing.Size(221, 69);
            this.BTDeleteMultipleFiles.TabIndex = 25;
            this.BTDeleteMultipleFiles.Text = "Delete Multiple Files";
            this.BTDeleteMultipleFiles.UseVisualStyleBackColor = true;
            this.BTDeleteMultipleFiles.Click += new System.EventHandler(this.BTDeleteMultipleFiles_Click);
            // 
            // TXTPATH
            // 
            this.TXTPATH.Location = new System.Drawing.Point(13, 652);
            this.TXTPATH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTPATH.Name = "TXTPATH";
            this.TXTPATH.Size = new System.Drawing.Size(345, 26);
            this.TXTPATH.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.TXTPATH);
            this.Controls.Add(this.BTDeleteMultipleFiles);
            this.Controls.Add(this.BirthT);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.CDFT);
            this.Controls.Add(this.FRFile);
            this.Controls.Add(this.ReadFilesRTB);
            this.Controls.Add(this.AgeTF);
            this.Controls.Add(this.NumTF);
            this.Controls.Add(this.Founded);
            this.Controls.Add(this.LocTF);
            this.Controls.Add(this.LFound);
            this.Controls.Add(this.FoundText);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumT);
            this.Controls.Add(this.LocT);
            this.Controls.Add(this.AgeT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.AddContact);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.BAddContact);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAddContact;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.TextBox AddContact;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AgeT;
        private System.Windows.Forms.TextBox LocT;
        private System.Windows.Forms.TextBox NumT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox FoundText;
        private System.Windows.Forms.Label LFound;
        private System.Windows.Forms.Label LocTF;
        private System.Windows.Forms.Label Founded;
        private System.Windows.Forms.Label NumTF;
        private System.Windows.Forms.Label AgeTF;
        private System.Windows.Forms.Label ReadFilesRTB;
        private System.Windows.Forms.Label FRFile;
        private System.Windows.Forms.Label CDFT;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.TextBox BirthT;
        private System.Windows.Forms.Button BTDeleteMultipleFiles;
        private System.Windows.Forms.TextBox TXTPATH;
    }
}

