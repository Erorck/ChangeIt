﻿
namespace ChangeIt
{
    partial class FormImageFilters
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
            this.panelHistogram = new System.Windows.Forms.Panel();
            this.btnSaveImage = new FontAwesome.Sharp.IconButton();
            this.cbSelectedFilter = new System.Windows.Forms.ComboBox();
            this.btnResetImage = new FontAwesome.Sharp.IconButton();
            this.btnApplyFilter = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUploadImage = new FontAwesome.Sharp.IconButton();
            this.pbEdited = new System.Windows.Forms.PictureBox();
            this.pBOriginal = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdited)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.panelHistogram);
            this.panel1.Controls.Add(this.btnSaveImage);
            this.panel1.Controls.Add(this.cbSelectedFilter);
            this.panel1.Controls.Add(this.btnResetImage);
            this.panel1.Controls.Add(this.btnApplyFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUploadImage);
            this.panel1.Controls.Add(this.pbEdited);
            this.panel1.Controls.Add(this.pBOriginal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 480);
            this.panel1.TabIndex = 0;
            // 
            // panelHistogram
            // 
            this.panelHistogram.BackColor = System.Drawing.Color.Black;
            this.panelHistogram.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHistogram.Location = new System.Drawing.Point(814, 0);
            this.panelHistogram.Name = "panelHistogram";
            this.panelHistogram.Size = new System.Drawing.Size(283, 480);
            this.panelHistogram.TabIndex = 17;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.btnSaveImage.FlatAppearance.BorderSize = 0;
            this.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnSaveImage.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnSaveImage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnSaveImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveImage.IconSize = 32;
            this.btnSaveImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveImage.Location = new System.Drawing.Point(610, 418);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSaveImage.Size = new System.Drawing.Size(147, 40);
            this.btnSaveImage.TabIndex = 16;
            this.btnSaveImage.Text = "Save Edited Image";
            this.btnSaveImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveImage.UseVisualStyleBackColor = false;
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
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.btnUploadImage.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnUploadImage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(142)))), ((int)(((byte)(156)))));
            this.btnUploadImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUploadImage.IconSize = 32;
            this.btnUploadImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadImage.Location = new System.Drawing.Point(43, 367);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUploadImage.Size = new System.Drawing.Size(160, 40);
            this.btnUploadImage.TabIndex = 11;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUploadImage.UseVisualStyleBackColor = false;
            // 
            // pbEdited
            // 
            this.pbEdited.Location = new System.Drawing.Point(442, 43);
            this.pbEdited.Name = "pbEdited";
            this.pbEdited.Size = new System.Drawing.Size(315, 254);
            this.pbEdited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEdited.TabIndex = 9;
            this.pbEdited.TabStop = false;
            // 
            // pBOriginal
            // 
            this.pBOriginal.Location = new System.Drawing.Point(43, 43);
            this.pBOriginal.Name = "pBOriginal";
            this.pBOriginal.Size = new System.Drawing.Size(315, 254);
            this.pBOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBOriginal.TabIndex = 8;
            this.pBOriginal.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(428, 413);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 20;
            // 
            // FormImageFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 480);
            this.Controls.Add(this.panel1);
            this.Name = "FormImageFilters";
            this.Text = "FormImageFilters";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdited)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSelectedFilter;
        private FontAwesome.Sharp.IconButton btnResetImage;
        private FontAwesome.Sharp.IconButton btnApplyFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnUploadImage;
        private System.Windows.Forms.PictureBox pbEdited;
        private System.Windows.Forms.PictureBox pBOriginal;
        private FontAwesome.Sharp.IconButton btnSaveImage;
        private System.Windows.Forms.Panel panelHistogram;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}