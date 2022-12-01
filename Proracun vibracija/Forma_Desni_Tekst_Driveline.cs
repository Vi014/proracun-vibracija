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

        public Int32 DriveshaftRunout, MissingBalnaceWeights, PinionAndRingGearPitchLine, DrivelineOperatingAngles;

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

            label15.Location = new Point(label13.Location.X, label13.Bottom + 20);
            label15.Text = FormaDesniGlavni.FormaHomeScreen.jezik[397];

            label16.Location = new Point(label15.Location.X, label15.Bottom + 20);
            label16.Text = FormaDesniGlavni.FormaHomeScreen.jezik[398];

            zoomablePictureBox1.Location = new Point(label1.Location.X, label16.Bottom + 20);

            label17.Location = new Point(label1.Location.X, zoomablePictureBox1.Bottom);
            label17.Text = FormaDesniGlavni.FormaHomeScreen.jezik[399];

            zoomablePictureBox2.Location = new Point(label1.Location.X, label17.Bottom + 20);

            label18.Location = new Point(label1.Location.X, zoomablePictureBox2.Bottom);
            label18.Text = FormaDesniGlavni.FormaHomeScreen.jezik[400];

            label19.Location = new Point(label15.Location.X, label18.Bottom + 20);
            label19.Text = FormaDesniGlavni.FormaHomeScreen.jezik[401];

            label20.Location = new Point(label15.Location.X, label19.Bottom + 20);
            label20.Text = FormaDesniGlavni.FormaHomeScreen.jezik[402];

            label21.Location = new Point(label15.Location.X, label20.Bottom + 20);
            label21.Text = FormaDesniGlavni.FormaHomeScreen.jezik[403];

            label22.Location = new Point(label15.Location.X, label21.Bottom + 20);
            label22.Text = FormaDesniGlavni.FormaHomeScreen.jezik[404];

            zoomablePictureBox3.Location = new Point(label1.Location.X, label22.Bottom + 20);

            label23.Location = new Point(label1.Location.X, zoomablePictureBox3.Bottom);
            label23.Text = FormaDesniGlavni.FormaHomeScreen.jezik[405];

            label24.Location = new Point(label15.Location.X, label23.Bottom + 20);
            label24.Text = FormaDesniGlavni.FormaHomeScreen.jezik[406];

            label25.Location = new Point(label15.Location.X, label24.Bottom + 20);
            label25.Text = FormaDesniGlavni.FormaHomeScreen.jezik[407];

            label26.Location = new Point(label15.Location.X, label25.Bottom + 20);
            label26.Text = FormaDesniGlavni.FormaHomeScreen.jezik[408];

            zoomablePictureBox4.Location = new Point(label1.Location.X, label26.Bottom + 20);

            label27.Location = new Point(label1.Location.X, zoomablePictureBox4.Bottom);
            label27.Text = FormaDesniGlavni.FormaHomeScreen.jezik[409];

            label28.Location = new Point(label15.Location.X, label27.Bottom + 20);
            label28.Text = FormaDesniGlavni.FormaHomeScreen.jezik[410];

            label29.Location = new Point(label15.Location.X, label28.Bottom + 20);
            label29.Text = FormaDesniGlavni.FormaHomeScreen.jezik[411];

            label30.Location = new Point(label15.Location.X, label29.Bottom + 20);
            label30.Text = FormaDesniGlavni.FormaHomeScreen.jezik[412];

            label31.Location = new Point(label15.Location.X, label30.Bottom + 20);
            label31.Text = FormaDesniGlavni.FormaHomeScreen.jezik[413];

            zoomablePictureBox5.Location = new Point(label1.Location.X, label31.Bottom + 20);

            label32.Location = new Point(label1.Location.X, zoomablePictureBox5.Bottom);
            label32.Text = FormaDesniGlavni.FormaHomeScreen.jezik[414];

            label33.Location = new Point(label15.Location.X, label32.Bottom + 20);
            label33.Text = FormaDesniGlavni.FormaHomeScreen.jezik[415];

            label34.Location = new Point(label15.Location.X, label33.Bottom + 20);
            label34.Text = FormaDesniGlavni.FormaHomeScreen.jezik[416];

            label35.Location = new Point(label15.Location.X, label34.Bottom + 20);
            label35.Text = FormaDesniGlavni.FormaHomeScreen.jezik[417];

            label36.Location = new Point(label15.Location.X, label35.Bottom + 20);
            label36.Text = FormaDesniGlavni.FormaHomeScreen.jezik[418];

            label37.Location = new Point(label15.Location.X, label36.Bottom + 20);
            label37.Text = FormaDesniGlavni.FormaHomeScreen.jezik[419];

            zoomablePictureBox6.Location = new Point(label1.Location.X, label37.Bottom + 20);

            label38.Location = new Point(label1.Location.X, zoomablePictureBox6.Bottom);
            label38.Text = FormaDesniGlavni.FormaHomeScreen.jezik[420];

            label39.Location = new Point(label15.Location.X, label38.Bottom + 20);
            label39.Text = FormaDesniGlavni.FormaHomeScreen.jezik[421];


            // prvi el -
            label40.Location = new Point(label15.Location.X, label39.Bottom + 20);
            label40.Text = FormaDesniGlavni.FormaHomeScreen.jezik[422];
            // prvi el tekst
            label41.Location = new Point(label40.Right - 7, label40.Location.Y);
            label41.Text = FormaDesniGlavni.FormaHomeScreen.jezik[423];
            // drugi el -
            label42.Location = new Point(label15.Location.X, label40.Bottom + 1);
            label42.Text = FormaDesniGlavni.FormaHomeScreen.jezik[424];
            // drugi el tekst
            label43.Location = new Point(label42.Right - 7, label42.Location.Y);
            label43.Text = FormaDesniGlavni.FormaHomeScreen.jezik[425];
            // treci el -
            label44.Location = new Point(label15.Location.X, label42.Bottom + 1);
            label44.Text = FormaDesniGlavni.FormaHomeScreen.jezik[426];
            // treci el tekst
            label45.Location = new Point(label44.Right - 7, label44.Location.Y);
            label45.Text = FormaDesniGlavni.FormaHomeScreen.jezik[427];
            // cetvrti el -
            label46.Location = new Point(label15.Location.X, label44.Bottom + 1);
            label46.Text = FormaDesniGlavni.FormaHomeScreen.jezik[428];
            // cetvrti el tekst
            label47.Location = new Point(label46.Right - 7, label46.Location.Y);
            label47.Text = FormaDesniGlavni.FormaHomeScreen.jezik[429];
            // peti el -
            label48.Location = new Point(label15.Location.X, label46.Bottom + 1);
            label48.Text = FormaDesniGlavni.FormaHomeScreen.jezik[430];
            // peti el tekst
            label49.Location = new Point(label48.Right - 7, label48.Location.Y);
            label49.Text = FormaDesniGlavni.FormaHomeScreen.jezik[431];



            label50.Location = new Point(label15.Location.X, label48.Bottom + 20);
            label50.Text = FormaDesniGlavni.FormaHomeScreen.jezik[432];

            label51.Location = new Point(label15.Location.X, label50.Bottom + 20);
            label51.Text = FormaDesniGlavni.FormaHomeScreen.jezik[433];

            button2.Text = FormaDesniGlavni.FormaHomeScreen.jezik[314];
            button2.Location = new Point(button2.Location.X, label51.Location.Y - (button2.Height - label51.Height) - 5);

            #endregion

            DriveshaftRunout           = label15.Location.Y - 5;
            MissingBalnaceWeights      = label21.Location.Y - 5;
            PinionAndRingGearPitchLine = label25.Location.Y - 5;
            DrivelineOperatingAngles   = label29.Location.Y - 5;
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

        private void gotoBeginning(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, 0);
        }

        private void gotoDriveshaftRunout(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, DriveshaftRunout);
        }

        private void gotoMissingBalanceWeights(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, MissingBalnaceWeights);
        }

        private void gotoPinionAndRingGearPitchLine(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, PinionAndRingGearPitchLine);
        }

        private void gotoDrivelineOperatingAngles(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, DrivelineOperatingAngles);
        }

        public Point PanelScrollPos
        {
            get { return panel1.AutoScrollPosition; }
            set { panel1.AutoScrollPosition = value; }
        }
    }
}
