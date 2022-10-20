
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
            this.pbDetected = new System.Windows.Forms.PictureBox();
            this.tbPerson = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBVideoPreview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetected)).BeginInit();
            this.SuspendLayout();
            // 
            // pBVideoPreview
            // 
            this.pBVideoPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBVideoPreview.InitialImage = global::ChangeIt.Properties.Resources.foto;
            this.pBVideoPreview.Location = new System.Drawing.Point(43, 31);
            this.pBVideoPreview.Name = "pBVideoPreview";
            this.pBVideoPreview.Size = new System.Drawing.Size(469, 314);
            this.pBVideoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBVideoPreview.TabIndex = 8;
            this.pBVideoPreview.TabStop = false;
            this.pBVideoPreview.Click += new System.EventHandler(this.pBVideoPreview_Click);
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
            this.btnTurnOn.Location = new System.Drawing.Point(391, 382);
            this.btnTurnOn.Name = "btnTurnOn";
            this.btnTurnOn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTurnOn.Size = new System.Drawing.Size(121, 40);
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
            this.cbSelectedDevice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSelectedDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.cbSelectedDevice.FormattingEnabled = true;
            this.cbSelectedDevice.Location = new System.Drawing.Point(68, 390);
            this.cbSelectedDevice.Name = "cbSelectedDevice";
            this.cbSelectedDevice.Size = new System.Drawing.Size(286, 25);
            this.cbSelectedDevice.TabIndex = 15;
            this.cbSelectedDevice.Text = "Select a video device";
            this.cbSelectedDevice.SelectedIndexChanged += new System.EventHandler(this.cbSelectedDevice_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.label2.Location = new System.Drawing.Point(549, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Facial detection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(593, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Users";
            // 
            // lblDetectedUsers
            // 
            this.lblDetectedUsers.AutoSize = true;
            this.lblDetectedUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetectedUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.lblDetectedUsers.Location = new System.Drawing.Point(586, 93);
            this.lblDetectedUsers.Name = "lblDetectedUsers";
            this.lblDetectedUsers.Size = new System.Drawing.Size(62, 15);
            this.lblDetectedUsers.TabIndex = 18;
            this.lblDetectedUsers.Text = "0 detected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.label5.Location = new System.Drawing.Point(577, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Movement";
            // 
            // lblDetectedMovingUsers
            // 
            this.lblDetectedMovingUsers.AutoSize = true;
            this.lblDetectedMovingUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetectedMovingUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.lblDetectedMovingUsers.Location = new System.Drawing.Point(586, 156);
            this.lblDetectedMovingUsers.Name = "lblDetectedMovingUsers";
            this.lblDetectedMovingUsers.Size = new System.Drawing.Size(62, 15);
            this.lblDetectedMovingUsers.TabIndex = 20;
            this.lblDetectedMovingUsers.Text = "0 detected";
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
            this.noCameraIcon.Location = new System.Drawing.Point(233, 166);
            this.noCameraIcon.Name = "noCameraIcon";
            this.noCameraIcon.Size = new System.Drawing.Size(75, 52);
            this.noCameraIcon.TabIndex = 21;
            this.noCameraIcon.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.pbDetected);
            this.panel1.Controls.Add(this.tbPerson);
            this.panel1.Controls.Add(this.btnAddPerson);
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
            this.panel1.Size = new System.Drawing.Size(723, 460);
            this.panel1.TabIndex = 2;
            // 
            // pbDetected
            // 
            this.pbDetected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetected.InitialImage = global::ChangeIt.Properties.Resources.foto;
            this.pbDetected.Location = new System.Drawing.Point(541, 189);
            this.pbDetected.Name = "pbDetected";
            this.pbDetected.Size = new System.Drawing.Size(153, 140);
            this.pbDetected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDetected.TabIndex = 24;
            this.pbDetected.TabStop = false;
            // 
            // tbPerson
            // 
            this.tbPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.tbPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(182)))), ((int)(((byte)(156)))));
            this.tbPerson.Location = new System.Drawing.Point(549, 348);
            this.tbPerson.Name = "tbPerson";
            this.tbPerson.Size = new System.Drawing.Size(135, 23);
            this.tbPerson.TabIndex = 23;
            this.tbPerson.Text = "Nombre";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.btnAddPerson.FlatAppearance.BorderSize = 0;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnAddPerson.IconChar = FontAwesome.Sharp.IconChar.FaceSmileBeam;
            this.btnAddPerson.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(39)))));
            this.btnAddPerson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPerson.IconSize = 28;
            this.btnAddPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPerson.Location = new System.Drawing.Point(549, 386);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(135, 33);
            this.btnAddPerson.TabIndex = 22;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            // 
            // FormCameraUtilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
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
        private FontAwesome.Sharp.IconButton btnAddPerson;
        private System.Windows.Forms.TextBox tbPerson;
        private System.Windows.Forms.PictureBox pbDetected;
    }
}