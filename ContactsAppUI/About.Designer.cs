namespace ContactsAppUI
{
    partial class About
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AthorLabel = new System.Windows.Forms.Label();
            this.GitLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.EmailLink = new System.Windows.Forms.LinkLabel();
            this.GitLnk = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(13, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(146, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "ContactsApp";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(18, 42);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(43, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v. 1.0.0";
            // 
            // AthorLabel
            // 
            this.AthorLabel.AutoSize = true;
            this.AthorLabel.Location = new System.Drawing.Point(15, 87);
            this.AthorLabel.Name = "AthorLabel";
            this.AthorLabel.Size = new System.Drawing.Size(127, 13);
            this.AthorLabel.TabIndex = 2;
            this.AthorLabel.Text = "Author: Nikita Novozhilov";
            // 
            // GitLabel
            // 
            this.GitLabel.AutoSize = true;
            this.GitLabel.Location = new System.Drawing.Point(15, 148);
            this.GitLabel.Name = "GitLabel";
            this.GitLabel.Size = new System.Drawing.Size(46, 13);
            this.GitLabel.TabIndex = 3;
            this.GitLabel.Text = "Git Hub:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(15, 132);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(100, 13);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "e-mail for feedback:";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(15, 229);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(129, 13);
            this.CopyrightLabel.TabIndex = 5;
            this.CopyrightLabel.Text = "2018 Nikita Novozhilov ©";
            // 
            // EmailLink
            // 
            this.EmailLink.AutoSize = true;
            this.EmailLink.Location = new System.Drawing.Point(122, 131);
            this.EmailLink.Name = "EmailLink";
            this.EmailLink.Size = new System.Drawing.Size(114, 13);
            this.EmailLink.TabIndex = 6;
            this.EmailLink.TabStop = true;
            this.EmailLink.Text = "nikita_novozh@mail.ru";
            // 
            // GitLnk
            // 
            this.GitLnk.AutoSize = true;
            this.GitLnk.Location = new System.Drawing.Point(67, 148);
            this.GitLnk.Name = "GitLnk";
            this.GitLnk.Size = new System.Drawing.Size(206, 13);
            this.GitLnk.TabIndex = 7;
            this.GitLnk.TabStop = true;
            this.GitLnk.Text = "github.com/nikitanovozhilov/ContactsApp\r\n";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.GitLnk);
            this.Controls.Add(this.EmailLink);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.GitLabel);
            this.Controls.Add(this.AthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AthorLabel;
        private System.Windows.Forms.Label GitLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.LinkLabel EmailLink;
        private System.Windows.Forms.LinkLabel GitLnk;
    }
}