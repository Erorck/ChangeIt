
namespace ChangeIt
{
    partial class FormCameraUtilities
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
            this.pBVideoPreview = new System.Windows.Forms.PictureBox();
            this.btnTurnOn = new FontAwesome.Sharp.IconButton();
            this.cbSelectedDevice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDetectedUsers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDetectedMovingUsers = new System.Windows.Forms.Label();
            this.noCameraIcon = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnalyze = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.pbDetected = new System.Windows.Forms.PictureBox();
            this.tbPersonName = new System.Windows.Forms.TextBox();
            this.btnDetectFaces = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBVideoPreview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetected)).BeginInit();
            this.SuspendLayout();
            // 
            // pBVideoPreview
            // 
            this.pBVideoPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBVideoPreview.InitialImage = global::ChangeIt.Properties.Resources.foto;
            this.pBVideoPreview.Location = new System.Drawing.Point(35, 57);
            this.pBVideoPreview.Name = "pBVideoPreview";
            this.pBVideoPreview.Size = new System.Drawing.Size(434, 272);
            this.pBVideoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBVideoPreview.TabIndex = 8;
            this.pBVideoPreview.TabStop = false;
            // 
            // btnTurnOn
            // 
            this.btnTurnOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.btnTurnOn.FlatAppearance.BorderSize = 0;
            this.btnTurnOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnTurnOn.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnTurnOn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnTurnOn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTurnOn.IconSize = 32;
            this.btnTurnOn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurnOn.Location = new System.Drawing.Point(333, 361);
            this.btnTurnOn.Name = "btnTurnOn";
            this.btnTurnOn.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnTurnOn.Size = new System.Drawing.Size(116, 43);
            this.btnTurnOn.TabIndex = 14;
            this.btnTurnOn.Text = "Turn On/Off";
            this.btnTurnOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurnOn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTurnOn.UseVisualStyleBackColor = false;
            this.btnTurnOn.Click += new System.EventHandler(this.BtnTurnOn_Click);
            // 
            // cbSelectedDevice
            // 
            this.cbSelectedDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.cbSelectedDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelectedDevice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbSelectedDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.cbSelectedDevice.FormattingEnabled = true;
            this.cbSelectedDevice.Location = new System.Drawing.Point(56, 368);
            this.cbSelectedDevice.Name = "cbSelectedDevice";
            this.cbSelectedDevice.Size = new System.Drawing.Size(246, 25);
            this.cbSelectedDevice.TabIndex = 15;
            this.cbSelectedDevice.Text = "Select a video device";
            this.cbSelectedDevice.SelectedIndexChanged += new System.EventHandler(this.cbSelectedDevice_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.label2.Location = new System.Drawing.Point(493, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Facial detection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(543, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Users";
            // 
            // lblDetectedUsers
            // 
            this.lblDetectedUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetectedUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.lblDetectedUsers.Location = new System.Drawing.Point(539, 81);
            this.lblDetectedUsers.Name = "lblDetectedUsers";
            this.lblDetectedUsers.Size = new System.Drawing.Size(53, 13);
            this.lblDetectedUsers.TabIndex = 18;
            this.lblDetectedUsers.Text = "0 detected";
            this.lblDetectedUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.label5.Location = new System.Drawing.Point(525, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Movement";
            // 
            // lblDetectedMovingUsers
            // 
            this.lblDetectedMovingUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetectedMovingUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.lblDetectedMovingUsers.Location = new System.Drawing.Point(539, 131);
            this.lblDetectedMovingUsers.Name = "lblDetectedMovingUsers";
            this.lblDetectedMovingUsers.Size = new System.Drawing.Size(53, 13);
            this.lblDetectedMovingUsers.TabIndex = 20;
            this.lblDetectedMovingUsers.Text = "0 detected";
            this.lblDetectedMovingUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noCameraIcon
            // 
            this.noCameraIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.noCameraIcon.Enabled = false;
            this.noCameraIcon.FlatAppearance.BorderSize = 0;
            this.noCameraIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noCameraIcon.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.noCameraIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.noCameraIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.noCameraIcon.Location = new System.Drawing.Point(220, 171);
            this.noCameraIcon.Name = "noCameraIcon";
            this.noCameraIcon.Size = new System.Drawing.Size(64, 45);
            this.noCameraIcon.TabIndex = 21;
            this.noCameraIcon.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.btnAnalyze);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.pbDetected);
            this.panel1.Controls.Add(this.tbPersonName);
            this.panel1.Controls.Add(this.btnDetectFaces);
            this.panel1.Controls.Add(this.noCameraIcon);
            this.panel1.Controls.Add(this.lblDetectedMovingUsers);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblDetectedUsers);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbSelectedDevice);
            this.panel1.Controls.Add(this.btnTurnOn);
            this.panel1.Controls.Add(this.pBVideoPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 508);
            this.panel1.TabIndex = 2;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnAnalyze.FlatAppearance.BorderSize = 0;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.btnAnalyze.IconChar = FontAwesome.Sharp.IconChar.Phabricator;
            this.btnAnalyze.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.btnAnalyze.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnalyze.IconSize = 28;
            this.btnAnalyze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalyze.Location = new System.Drawing.Point(510, 440);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(110, 42);
            this.btnAnalyze.TabIndex = 27;
            this.btnAnalyze.Text = "Analyze faces";
            this.btnAnalyze.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalyze.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(520, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Captured";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 28;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(510, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 41);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save Image";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbDetected
            // 
            this.pbDetected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetected.InitialImage = global::ChangeIt.Properties.Resources.foto;
            this.pbDetected.Location = new System.Drawing.Point(500, 225);
            this.pbDetected.Name = "pbDetected";
            this.pbDetected.Size = new System.Drawing.Size(131, 122);
            this.pbDetected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDetected.TabIndex = 24;
            this.pbDetected.TabStop = false;
            // 
            // tbPersonName
            // 
            this.tbPersonName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.tbPersonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.tbPersonName.Location = new System.Drawing.Point(507, 354);
            this.tbPersonName.Name = "tbPersonName";
            this.tbPersonName.Size = new System.Drawing.Size(116, 20);
            this.tbPersonName.TabIndex = 23;
            this.tbPersonName.Text = "Nombre";
            // 
            // btnDetectFaces
            // 
            this.btnDetectFaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.btnDetectFaces.Enabled = false;
            this.btnDetectFaces.FlatAppearance.BorderSize = 0;
            this.btnDetectFaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectFaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnDetectFaces.IconChar = FontAwesome.Sharp.IconChar.FaceSmileBeam;
            this.btnDetectFaces.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnDetectFaces.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetectFaces.IconSize = 28;
            this.btnDetectFaces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectFaces.Location = new System.Drawing.Point(507, 160);
            this.btnDetectFaces.Name = "btnDetectFaces";
            this.btnDetectFaces.Size = new System.Drawing.Size(116, 38);
            this.btnDetectFaces.TabIndex = 22;
            this.btnDetectFaces.Text = "Detect Faces";
            this.btnDetectFaces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectFaces.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetectFaces.UseVisualStyleBackColor = false;
            this.btnDetectFaces.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // FormCameraUtilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 508);
            this.Controls.Add(this.panel1);
            this.Name = "FormCameraUtilities";
            this.Text = "FormCameraUtilities";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCameraUtilities_FormClosed);
            this.Load += new System.EventHandler(this.FormCameraUtilities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBVideoPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBVideoPreview;
        private FontAwesome.Sharp.IconButton btnTurnOn;
        private System.Windows.Forms.ComboBox cbSelectedDevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDetectedUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDetectedMovingUsers;
        private FontAwesome.Sharp.IconButton noCameraIcon;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnDetectFaces;
        private System.Windows.Forms.TextBox tbPersonName;
        private System.Windows.Forms.PictureBox pbDetected;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnAnalyze;
    }
}