
namespace ChangeIt
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnCamera = new FontAwesome.Sharp.IconButton();
            this.BtnVideoFilters = new FontAwesome.Sharp.IconButton();
            this.BtnImageFilters = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnChangeIt = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iPbClose = new FontAwesome.Sharp.IconPictureBox();
            this.iPbMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iPbMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeIt)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.BtnCamera);
            this.panelMenu.Controls.Add(this.BtnVideoFilters);
            this.panelMenu.Controls.Add(this.BtnImageFilters);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 581);
            this.panelMenu.TabIndex = 0;
            // 
            // BtnCamera
            // 
            this.BtnCamera.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCamera.FlatAppearance.BorderSize = 0;
            this.BtnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.BtnCamera.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.BtnCamera.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.BtnCamera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCamera.IconSize = 32;
            this.BtnCamera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCamera.Location = new System.Drawing.Point(0, 260);
            this.BtnCamera.Name = "BtnCamera";
            this.BtnCamera.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCamera.Size = new System.Drawing.Size(220, 60);
            this.BtnCamera.TabIndex = 3;
            this.BtnCamera.Text = "Camara Utilities";
            this.BtnCamera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCamera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCamera.UseVisualStyleBackColor = true;
            this.BtnCamera.Click += new System.EventHandler(this.BtnCamera_Click);
            // 
            // BtnVideoFilters
            // 
            this.BtnVideoFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVideoFilters.FlatAppearance.BorderSize = 0;
            this.BtnVideoFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVideoFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.BtnVideoFilters.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.BtnVideoFilters.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.BtnVideoFilters.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVideoFilters.IconSize = 32;
            this.BtnVideoFilters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVideoFilters.Location = new System.Drawing.Point(0, 200);
            this.BtnVideoFilters.Name = "BtnVideoFilters";
            this.BtnVideoFilters.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnVideoFilters.Size = new System.Drawing.Size(220, 60);
            this.BtnVideoFilters.TabIndex = 2;
            this.BtnVideoFilters.Text = "Filters for Video";
            this.BtnVideoFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVideoFilters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVideoFilters.UseVisualStyleBackColor = true;
            this.BtnVideoFilters.Click += new System.EventHandler(this.BtnVideoFilters_Click);
            // 
            // BtnImageFilters
            // 
            this.BtnImageFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnImageFilters.FlatAppearance.BorderSize = 0;
            this.BtnImageFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImageFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.BtnImageFilters.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.BtnImageFilters.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.BtnImageFilters.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImageFilters.IconSize = 32;
            this.BtnImageFilters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImageFilters.Location = new System.Drawing.Point(0, 140);
            this.BtnImageFilters.Name = "BtnImageFilters";
            this.BtnImageFilters.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnImageFilters.Size = new System.Drawing.Size(220, 60);
            this.BtnImageFilters.TabIndex = 1;
            this.BtnImageFilters.Text = "Filters for Images";
            this.BtnImageFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImageFilters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImageFilters.UseVisualStyleBackColor = true;
            this.BtnImageFilters.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnChangeIt);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnChangeIt
            // 
            this.btnChangeIt.Image = global::ChangeIt.Properties.Resources.ChangeIt_Logo;
            this.btnChangeIt.Location = new System.Drawing.Point(0, 0);
            this.btnChangeIt.Name = "btnChangeIt";
            this.btnChangeIt.Size = new System.Drawing.Size(206, 140);
            this.btnChangeIt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChangeIt.TabIndex = 0;
            this.btnChangeIt.TabStop = false;
            this.btnChangeIt.Click += new System.EventHandler(this.btnChangeIt_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.panelTitleBar.Controls.Add(this.panel1);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(767, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.iPbClose);
            this.panel1.Controls.Add(this.iPbMaximize);
            this.panel1.Controls.Add(this.iPbMinimize);
            this.panel1.Location = new System.Drawing.Point(668, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 34);
            this.panel1.TabIndex = 3;
            // 
            // iPbClose
            // 
            this.iPbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.iPbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iPbClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.iPbClose.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.iPbClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.iPbClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPbClose.IconSize = 29;
            this.iPbClose.Location = new System.Drawing.Point(61, 4);
            this.iPbClose.Name = "iPbClose";
            this.iPbClose.Size = new System.Drawing.Size(32, 29);
            this.iPbClose.TabIndex = 4;
            this.iPbClose.TabStop = false;
            this.iPbClose.Click += new System.EventHandler(this.iPbClose_Click);
            // 
            // iPbMaximize
            // 
            this.iPbMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.iPbMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iPbMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.iPbMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iPbMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.iPbMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPbMaximize.IconSize = 29;
            this.iPbMaximize.Location = new System.Drawing.Point(29, 4);
            this.iPbMaximize.Name = "iPbMaximize";
            this.iPbMaximize.Size = new System.Drawing.Size(36, 29);
            this.iPbMaximize.TabIndex = 3;
            this.iPbMaximize.TabStop = false;
            this.iPbMaximize.Click += new System.EventHandler(this.iPbMaximize_Click);
            // 
            // iPbMinimize
            // 
            this.iPbMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.iPbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iPbMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.iPbMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iPbMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.iPbMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPbMinimize.IconSize = 29;
            this.iPbMinimize.Location = new System.Drawing.Point(0, 4);
            this.iPbMinimize.Name = "iPbMinimize";
            this.iPbMinimize.Size = new System.Drawing.Size(32, 29);
            this.iPbMinimize.TabIndex = 2;
            this.iPbMinimize.TabStop = false;
            this.iPbMinimize.Click += new System.EventHandler(this.iPbMinimize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(61, 27);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(63, 25);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(23, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(767, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(767, 497);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ChangeIt.Properties.Resources.ChangeIt_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(210, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(987, 581);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormHome";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeIt)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iPbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton BtnImageFilters;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton BtnCamera;
        private FontAwesome.Sharp.IconButton BtnVideoFilters;
        private System.Windows.Forms.PictureBox btnChangeIt;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iPbMinimize;
        private FontAwesome.Sharp.IconPictureBox iPbClose;
        private FontAwesome.Sharp.IconPictureBox iPbMaximize;
    }
}

