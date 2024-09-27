namespace ProjBase1
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PostText = new System.Windows.Forms.Panel();
            this.Logoff = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btHome = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btNotification = new System.Windows.Forms.Button();
            this.btProfile = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 727);
            this.panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(43, 186);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 34);
            this.textBox1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btHome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btSearch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btNotification, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btProfile, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btSettings, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 279);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 446);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // PostText
            // 
            this.PostText.AutoScroll = true;
            this.PostText.Location = new System.Drawing.Point(405, 162);
            this.PostText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(1024, 532);
            this.PostText.TabIndex = 8;
            // 
            // Logoff
            // 
            this.Logoff.Location = new System.Drawing.Point(388, 66);
            this.Logoff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logoff.Name = "Logoff";
            this.Logoff.Size = new System.Drawing.Size(117, 26);
            this.Logoff.TabIndex = 9;
            this.Logoff.Text = "Logoff";
            this.Logoff.UseVisualStyleBackColor = true;
            this.Logoff.Click += new System.EventHandler(this.Logoff_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjBase1.Properties.Resources.Letreiro;
            this.pictureBox2.Location = new System.Drawing.Point(291, -596);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1027, 834);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btHome
            // 
            this.btHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHome.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.Image = global::ProjBase1.Properties.Resources.home;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(34, 17);
            this.btHome.Margin = new System.Windows.Forms.Padding(4);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(236, 54);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "   Home";
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHome.UseVisualStyleBackColor = false;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Image = global::ProjBase1.Properties.Resources.search;
            this.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.Location = new System.Drawing.Point(36, 106);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(231, 54);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "   Pequisa";
            this.btSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSearch.UseVisualStyleBackColor = false;
            // 
            // btNotification
            // 
            this.btNotification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNotification.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btNotification.FlatAppearance.BorderSize = 0;
            this.btNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNotification.Image = global::ProjBase1.Properties.Resources.notification;
            this.btNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNotification.Location = new System.Drawing.Point(42, 195);
            this.btNotification.Margin = new System.Windows.Forms.Padding(4);
            this.btNotification.Name = "btNotification";
            this.btNotification.Size = new System.Drawing.Size(219, 54);
            this.btNotification.TabIndex = 2;
            this.btNotification.Text = "   Notificações";
            this.btNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNotification.UseVisualStyleBackColor = false;
            // 
            // btProfile
            // 
            this.btProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btProfile.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProfile.FlatAppearance.BorderSize = 0;
            this.btProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProfile.Image = global::ProjBase1.Properties.Resources.user;
            this.btProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProfile.Location = new System.Drawing.Point(48, 284);
            this.btProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btProfile.Name = "btProfile";
            this.btProfile.Size = new System.Drawing.Size(207, 54);
            this.btProfile.TabIndex = 4;
            this.btProfile.Text = "   Perfil";
            this.btProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProfile.UseVisualStyleBackColor = false;
            this.btProfile.Click += new System.EventHandler(this.btProfile_Click);
            // 
            // btSettings
            // 
            this.btSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSettings.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSettings.FlatAppearance.BorderSize = 0;
            this.btSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSettings.Image = global::ProjBase1.Properties.Resources.setting;
            this.btSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSettings.Location = new System.Drawing.Point(40, 374);
            this.btSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(224, 54);
            this.btSettings.TabIndex = 3;
            this.btSettings.Text = "   Configurações";
            this.btSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSettings.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(43, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 153);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1604, 720);
            this.Controls.Add(this.Logoff);
            this.Controls.Add(this.PostText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button btNotification;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PostText;
        private System.Windows.Forms.Button Logoff;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}