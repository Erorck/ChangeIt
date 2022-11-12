using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ChangeIt
{
    public partial class FormHome : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FormHome()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBColors
        {
            public static Color cYellow = Color.FromArgb(210, 150, 57),
            cTiffany = Color.FromArgb(83, 182, 156),
            cBondi = Color.FromArgb(35, 142, 156),
            cCobalt = Color.FromArgb(46, 72, 115),
            cPersia = Color.FromArgb(43, 48, 85),
            cDark = Color.FromArgb(10, 13, 39);
        }

        //Methods 
        private void ActivateButton(Object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(43, 48, 85);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(10, 13, 39);
                currentBtn.ForeColor = Color.FromArgb(83, 182, 156);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(35, 142, 156);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only one form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //childForm.Size = panelDesktop.Size;
            lblTitleChildForm.Text = currentBtn.Text;
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.cYellow);
            this.Size = new Size(1190 + 220, 490 + 81);
            OpenChildForm(new FormImageFilters());
        }

        private void BtnVideoFilters_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.cYellow);
            this.Size = new Size(220 + 1097, 490 + 81);
            OpenChildForm(new FormVideoFilters());
        }

        private void BtnCamera_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.cYellow);
            this.Size = new Size(200 + 700, 525 + 81);
            OpenChildForm(new FormCameraUtilities());
        }

        private void btnChangeIt_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = RGBColors.cBondi;
            lblTitleChildForm.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iPbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iPbMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else            
                WindowState = FormWindowState.Normal;
        }

        private void iPbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
               

        private void FormHome_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}
