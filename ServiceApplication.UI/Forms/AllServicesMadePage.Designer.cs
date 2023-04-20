namespace ServiceApplication.UI.Forms
{
    partial class AllServicesMadePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllServicesMadePage));
            this.dgwAll = new System.Windows.Forms.DataGridView();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.pbxServicePhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxServicePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAll
            // 
            this.dgwAll.BackgroundColor = System.Drawing.Color.White;
            this.dgwAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAll.GridColor = System.Drawing.Color.Black;
            this.dgwAll.Location = new System.Drawing.Point(13, 13);
            this.dgwAll.Name = "dgwAll";
            this.dgwAll.RowHeadersWidth = 51;
            this.dgwAll.RowTemplate.Height = 24;
            this.dgwAll.Size = new System.Drawing.Size(649, 535);
            this.dgwAll.TabIndex = 0;
            this.dgwAll.SelectionChanged += new System.EventHandler(this.dgwAll_SelectionChanged);
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnRefreshData.FlatAppearance.BorderSize = 0;
            this.btnRefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefreshData.ForeColor = System.Drawing.Color.White;
            this.btnRefreshData.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshData.Image")));
            this.btnRefreshData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshData.Location = new System.Drawing.Point(720, 555);
            this.btnRefreshData.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(160, 44);
            this.btnRefreshData.TabIndex = 45;
            this.btnRefreshData.Text = "Refresh Data";
            this.btnRefreshData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshData.UseVisualStyleBackColor = false;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // pbxServicePhoto
            // 
            this.pbxServicePhoto.BackColor = System.Drawing.Color.Silver;
            this.pbxServicePhoto.Location = new System.Drawing.Point(668, 13);
            this.pbxServicePhoto.Name = "pbxServicePhoto";
            this.pbxServicePhoto.Size = new System.Drawing.Size(212, 170);
            this.pbxServicePhoto.TabIndex = 46;
            this.pbxServicePhoto.TabStop = false;
            // 
            // AllServicesMadePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 612);
            this.Controls.Add(this.pbxServicePhoto);
            this.Controls.Add(this.btnRefreshData);
            this.Controls.Add(this.dgwAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllServicesMadePage";
            this.Text = "AllServicesMadePage";
            this.Load += new System.EventHandler(this.AllServicesMadePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxServicePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAll;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.PictureBox pbxServicePhoto;
    }
}