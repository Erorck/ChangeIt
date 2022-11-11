
namespace ChangeIt
{
    partial class FormVideoFilters
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panelHistogram = new System.Windows.Forms.Panel();
            this.cbSelectedFilter = new System.Windows.Forms.ComboBox();
            this.btnResetImage = new FontAwesome.Sharp.IconButton();
            this.btnApplyFilter = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUploadVideo = new FontAwesome.Sharp.IconButton();
            this.pbEdited = new System.Windows.Forms.PictureBox();
            this.pBOriginal = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdited)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.panelHistogram);
            this.panel1.Controls.Add(this.cbSelectedFilter);
            this.panel1.Controls.Add(this.btnResetImage);
            this.panel1.Controls.Add(this.btnApplyFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUploadVideo);
            this.panel1.Controls.Add(this.pbEdited);
            this.panel1.Controls.Add(this.pBOriginal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 494);
            this.panel1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(430, 415);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 19;
            // 
            // panelHistogram
            // 
            this.panelHistogram.BackColor = System.Drawing.Color.Black;
            this.panelHistogram.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHistogram.Location = new System.Drawing.Point(814, 0);
            this.panelHistogram.Name = "panelHistogram";
            this.panelHistogram.Size = new System.Drawing.Size(283, 494);
            this.panelHistogram.TabIndex = 18;
            // 
            // cbSelectedFilter
            // 
            this.cbSelectedFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.cbSelectedFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelectedFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSelectedFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.cbSelectedFilter.FormattingEnabled = true;
            this.cbSelectedFilter.Location = new System.Drawing.Point(396, 375);
            this.cbSelectedFilter.Name = "cbSelectedFilter";
            this.cbSelectedFilter.Size = new System.Drawing.Size(175, 25);
            this.cbSelectedFilter.TabIndex = 15;
            this.cbSelectedFilter.Text = "Select a Filter";
            // 
            // btnResetImage
            // 
            this.btnResetImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.btnResetImage.FlatAppearance.BorderSize = 0;
            this.btnResetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnResetImage.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.btnResetImage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnResetImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetImage.IconSize = 32;
            this.btnResetImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetImage.Location = new System.Drawing.Point(221, 367);
            this.btnResetImage.Name = "btnResetImage";
            this.btnResetImage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnResetImage.Size = new System.Drawing.Size(105, 40);
            this.btnResetImage.TabIndex = 14;
            this.btnResetImage.Text = "Reset";
            this.btnResetImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetImage.UseVisualStyleBackColor = false;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnApplyFilter.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.btnApplyFilter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnApplyFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApplyFilter.IconSize = 32;
            this.btnApplyFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplyFilter.Location = new System.Drawing.Point(610, 367);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnApplyFilter.Size = new System.Drawing.Size(147, 40);
            this.btnApplyFilter.TabIndex = 13;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplyFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(571, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Edited";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(154, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Original";
            // 
            // btnUploadVideo
            // 
            this.btnUploadVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnUploadVideo.FlatAppearance.BorderSize = 0;
            this.btnUploadVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.btnUploadVideo.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnUploadVideo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.btnUploadVideo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUploadVideo.IconSize = 32;
            this.btnUploadVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadVideo.Location = new System.Drawing.Point(43, 367);
            this.btnUploadVideo.Name = "btnUploadVideo";
            this.btnUploadVideo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUploadVideo.Size = new System.Drawing.Size(160, 40);
            this.btnUploadVideo.TabIndex = 11;
            this.btnUploadVideo.Text = "Upload Video";
            this.btnUploadVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadVideo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUploadVideo.UseVisualStyleBackColor = false;
            // 
            // pbEdited
            // 
            this.pbEdited.Location = new System.Drawing.Point(442, 43);
            this.pbEdited.Name = "pbEdited";
            this.pbEdited.Size = new System.Drawing.Size(315, 254);
            this.pbEdited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdited.TabIndex = 9;
            this.pbEdited.TabStop = false;
            // 
            // pBOriginal
            // 
            this.pBOriginal.Location = new System.Drawing.Point(43, 43);
            this.pBOriginal.Name = "pBOriginal";
            this.pBOriginal.Size = new System.Drawing.Size(315, 254);
            this.pBOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBOriginal.TabIndex = 8;
            this.pBOriginal.TabStop = false;
            // 
            // FormVideoFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 494);
            this.Controls.Add(this.panel1);
            this.Name = "FormVideoFilters";
            this.Text = "FormVideoFilters";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdited)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSelectedFilter;
        private FontAwesome.Sharp.IconButton btnResetImage;
        private FontAwesome.Sharp.IconButton btnApplyFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnUploadVideo;
        private System.Windows.Forms.PictureBox pbEdited;
        private System.Windows.Forms.PictureBox pBOriginal;
        private System.Windows.Forms.Panel panelHistogram;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}