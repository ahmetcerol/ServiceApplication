namespace ServiceApplication.UI
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.pnlChildForms = new System.Windows.Forms.Panel();
            this.pnlMainPageMenu = new System.Windows.Forms.Panel();
            this.btnService = new System.Windows.Forms.Button();
            this.pnlMainPageLogo = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnBackMain = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMainPageMenu.SuspendLayout();
            this.pnlMainPageLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChildForms
            // 
            this.pnlChildForms.Location = new System.Drawing.Point(221, 73);
            this.pnlChildForms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChildForms.Name = "pnlChildForms";
            this.pnlChildForms.Size = new System.Drawing.Size(892, 612);
            this.pnlChildForms.TabIndex = 5;
            // 
            // pnlMainPageMenu
            // 
            this.pnlMainPageMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlMainPageMenu.Controls.Add(this.btnService);
            this.pnlMainPageMenu.Controls.Add(this.pnlMainPageLogo);
            this.pnlMainPageMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainPageMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPageMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMainPageMenu.Name = "pnlMainPageMenu";
            this.pnlMainPageMenu.Size = new System.Drawing.Size(215, 686);
            this.pnlMainPageMenu.TabIndex = 6;
            // 
            // btnService
            // 
            this.btnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnService.ForeColor = System.Drawing.Color.White;
            this.btnService.Image = ((System.Drawing.Image)(resources.GetObject("btnService.Image")));
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.Location = new System.Drawing.Point(0, 123);
            this.btnService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnService.Name = "btnService";
            this.btnService.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnService.Size = new System.Drawing.Size(215, 57);
            this.btnService.TabIndex = 1;
            this.btnService.Text = "Create Service";
            this.btnService.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnService.UseVisualStyleBackColor = true;
            // 
            // pnlMainPageLogo
            // 
            this.pnlMainPageLogo.Controls.Add(this.pbxLogo);
            this.pnlMainPageLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainPageLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPageLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMainPageLogo.Name = "pnlMainPageLogo";
            this.pnlMainPageLogo.Size = new System.Drawing.Size(215, 123);
            this.pnlMainPageLogo.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(215, 123);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.UseWaitCursor = true;
            // 
            // btnBackMain
            // 
            this.btnBackMain.BackColor = System.Drawing.Color.White;
            this.btnBackMain.FlatAppearance.BorderSize = 0;
            this.btnBackMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMain.Image = ((System.Drawing.Image)(resources.GetObject("btnBackMain.Image")));
            this.btnBackMain.Location = new System.Drawing.Point(223, 14);
            this.btnBackMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(47, 42);
            this.btnBackMain.TabIndex = 7;
            this.btnBackMain.UseVisualStyleBackColor = false;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1029, 14);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(17, 25);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(1053, 14);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(17, 25);
            this.btnMaximize.TabIndex = 9;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1079, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 25);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 686);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBackMain);
            this.Controls.Add(this.pnlMainPageMenu);
            this.Controls.Add(this.pnlChildForms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Application";
            this.pnlMainPageMenu.ResumeLayout(false);
            this.pnlMainPageLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildForms;
        private System.Windows.Forms.Panel pnlMainPageMenu;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Panel pnlMainPageLogo;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
    }
}

