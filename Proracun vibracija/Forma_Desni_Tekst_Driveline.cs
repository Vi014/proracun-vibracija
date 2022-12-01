using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proracun_vibracija
{
    public partial class Forma_Desni_Tekst_Driveline : Form
    {
        public Forma_Desni_Glavni FormaDesniGlavni;

        public Forma_Desni_Tekst_Driveline(Forma_Desni_Glavni konstruktor)
        {
            InitializeComponent();
            FormaDesniGlavni = konstruktor;
        }

        // intovi neophodni za linkove idu ovde

        public void PromenaJezika()
        {
            this.Text = FormaDesniGlavni.FormaHomeScreen.jezik[382];

            #region dokument

            label1.Location = new Point(16, 14);
            label1.Text = FormaDesniGlavni.FormaHomeScreen.jezik[383];

            label2.Location = new Point(label1.Location.X, label1.Bottom + 20);
            label2.Text = FormaDesniGlavni.FormaHomeScreen.jezik[384];

            label3.Location = new Point(label2.Location.X, label2.Bottom + 20);
            label3.Text = FormaDesniGlavni.FormaHomeScreen.jezik[385];

            label4.Location = new Point(label3.Location.X, label3.Bottom + 20);
            label4.Text = FormaDesniGlavni.FormaHomeScreen.jezik[386];

            label5.Location = new Point(label4.Location.X, label4.Bottom + 20);
            label5.Text = FormaDesniGlavni.FormaHomeScreen.jezik[387];

            label6.Location = new Point(label5.Location.X, label5.Bottom + 20);
            label6.Text = FormaDesniGlavni.FormaHomeScreen.jezik[388];

            label7.Location = new Point(label6.Location.X, label6.Bottom + 1);
            label7.Text = FormaDesniGlavni.FormaHomeScreen.jezik[389];

            label8.Location = new Point(label7.Right - 7, label7.Location.Y);
            label8.Text = FormaDesniGlavni.FormaHomeScreen.jezik[390];

            label9.Location = new Point(label7.Location.X, label7.Bottom + 1);
            label9.Text = FormaDesniGlavni.FormaHomeScreen.jezik[391];

            label10.Location = new Point(label9.Right - 7, label9.Location.Y);
            label10.Text = FormaDesniGlavni.FormaHomeScreen.jezik[392];

            label11.Location = new Point(label9.Location.X, label9.Bottom + 1);
            label11.Text = FormaDesniGlavni.FormaHomeScreen.jezik[393];

            label12.Location = new Point(label11.Right - 7, label11.Location.Y);
            label12.Text = FormaDesniGlavni.FormaHomeScreen.jezik[394];

            label13.Location = new Point(label11.Location.X, label11.Bottom + 1);
            label13.Text = FormaDesniGlavni.FormaHomeScreen.jezik[395];

            label14.Location = new Point(label13.Right - 7, label13.Location.Y);
            label14.Text = FormaDesniGlavni.FormaHomeScreen.jezik[396];

            #endregion
        }

        private void Forma_Desni_Tekst_Driveline_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(0, 0);
        }

        private void Forma_Desni_Tekst_Driveline_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaDesniGlavni.FormaDesniTekstDriveline = null;
        }

        private void zoom(object sender, EventArgs e)
        {
            (sender as ZoomablePictureBox).Zoom(zoomPicture, button1, panel1, this); // KADA PRAVIS NOVU FORMU SA TEKSTOM, URADI SEND TO BACK NA PANELU, INACE SE ZOOMPICTURE I BUTTON1 NECE VIDETI KADA POKUSAVAS DA OTVORIS NEKU SLIKU
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zoomPicture.Visible = button1.Visible = false;
            panel1.Enabled = true;
        }

        private void CursorHand(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand; // ovo je za MouseMove na labelima koju sluze kao linkovi, da bi se mis pretvorio u onaj kursor sa pokazujucom rukom kao u browserima
        }

        // goto-ovi idu ove

        // enkapsulacija panel1.autoscrollpos ce ici ovde ako bude bila potrebna
    }
}
