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
    public partial class Forma_Desni_Tekst_Tocak : Form
    {
        public Forma_Desni_Glavni FormaDesniGlavni;

        public Forma_Desni_Tekst_Tocak(Forma_Desni_Glavni konstruktor)
        {
            InitializeComponent();
            FormaDesniGlavni = konstruktor;
        }

        public Int32 RadialWheelAndTireAssemblyRunout, LateralWheelAndTireAssemblyRunout, RadialWheelRunout, LateralWheelRunout, HubBrakeDiscRunout, RadialForceVariation, BentAxleShaft;

        public void PromenaJezika()
        {
            this.Text = FormaDesniGlavni.FormaHomeScreen.jezik[434];

            #region dokument

            label1.Location = new Point(16, 14);
            label1.Text = FormaDesniGlavni.FormaHomeScreen.jezik[435];

            label2.Location = new Point(label1.Location.X, label1.Bottom + 20);
            label2.Text = FormaDesniGlavni.FormaHomeScreen.jezik[436];

            label3.Location = new Point(label1.Location.X, label2.Bottom + 20);
            label3.Text = FormaDesniGlavni.FormaHomeScreen.jezik[437];

            label4.Location = new Point(label1.Location.X, label3.Bottom + 20);
            label4.Text = FormaDesniGlavni.FormaHomeScreen.jezik[438];

            label5.Location = new Point(label1.Location.X, label4.Bottom + 20);
            label5.Text = FormaDesniGlavni.FormaHomeScreen.jezik[439];



            // prvi el -
            label6.Location = new Point(label1.Location.X, label5.Bottom + 1);
            label6.Text = FormaDesniGlavni.FormaHomeScreen.jezik[440];
            // prvi el tekst
            label7.Location = new Point(label6.Right - 7, label6.Location.Y);
            label7.Text = FormaDesniGlavni.FormaHomeScreen.jezik[441];

            // drugi el -
            label8.Location = new Point(label1.Location.X, label6.Bottom + 1);
            label8.Text = FormaDesniGlavni.FormaHomeScreen.jezik[442];
            // drugi el tekst
            label9.Location = new Point(label8.Right - 7, label8.Location.Y);
            label9.Text = FormaDesniGlavni.FormaHomeScreen.jezik[443];

            // treci el -
            label10.Location = new Point(label1.Location.X, label8.Bottom + 1);
            label10.Text = FormaDesniGlavni.FormaHomeScreen.jezik[444];
            // treci el tekst
            label11.Location = new Point(label10.Right - 7, label10.Location.Y);
            label11.Text = FormaDesniGlavni.FormaHomeScreen.jezik[445];

            // cetvrti el -
            label12.Location = new Point(label1.Location.X, label10.Bottom + 1);
            label12.Text = FormaDesniGlavni.FormaHomeScreen.jezik[446];
            // cetvrti el tekst
            label13.Location = new Point(label12.Right - 7, label12.Location.Y);
            label13.Text = FormaDesniGlavni.FormaHomeScreen.jezik[447];

            // peti el -
            label14.Location = new Point(label1.Location.X, label12.Bottom + 1);
            label14.Text = FormaDesniGlavni.FormaHomeScreen.jezik[448];
            // peti el tekst
            label15.Location = new Point(label14.Right - 7, label14.Location.Y);
            label15.Text = FormaDesniGlavni.FormaHomeScreen.jezik[449];

            // sesti el -
            label16.Location = new Point(label1.Location.X, label14.Bottom + 1);
            label16.Text = FormaDesniGlavni.FormaHomeScreen.jezik[450];
            // sesti el tekst
            label17.Location = new Point(label16.Right - 7, label16.Location.Y);
            label17.Text = FormaDesniGlavni.FormaHomeScreen.jezik[451];

            // sedmi el -
            label18.Location = new Point(label1.Location.X, label16.Bottom + 1);
            label18.Text = FormaDesniGlavni.FormaHomeScreen.jezik[452];
            // sedmi el tekst
            label19.Location = new Point(label18.Right - 7, label18.Location.Y);
            label19.Text = FormaDesniGlavni.FormaHomeScreen.jezik[453];

            // osmi el -
            label20.Location = new Point(label1.Location.X, label18.Bottom + 1);
            label20.Text = FormaDesniGlavni.FormaHomeScreen.jezik[454];
            // osmi el tekst
            label21.Location = new Point(label20.Right - 7, label20.Location.Y);
            label21.Text = FormaDesniGlavni.FormaHomeScreen.jezik[455];

            // deveti el -
            label22.Location = new Point(label1.Location.X, label20.Bottom + 1);
            label22.Text = FormaDesniGlavni.FormaHomeScreen.jezik[456];
            // deveti el tekst
            label23.Location = new Point(label22.Right - 7, label22.Location.Y);
            label23.Text = FormaDesniGlavni.FormaHomeScreen.jezik[457];



            label24.Location = new Point(label1.Location.X, label22.Bottom + 20);
            label24.Text = FormaDesniGlavni.FormaHomeScreen.jezik[458];

            label25.Location = new Point(label1.Location.X, label24.Bottom + 20);
            label25.Text = FormaDesniGlavni.FormaHomeScreen.jezik[459];

            label26.Location = new Point(label1.Location.X, label25.Bottom + 20);
            label26.Text = FormaDesniGlavni.FormaHomeScreen.jezik[460];

            label27.Location = new Point(label1.Location.X, label26.Bottom + 20);
            label27.Text = FormaDesniGlavni.FormaHomeScreen.jezik[461];

            zoomablePictureBox1.Location = new Point(label1.Location.X, label27.Bottom + 20);

            label28.Location = new Point(label1.Location.X, zoomablePictureBox1.Bottom);
            label28.Text = FormaDesniGlavni.FormaHomeScreen.jezik[462];

            label29.Location = new Point(label1.Location.X, label28.Bottom + 20);
            label29.Text = FormaDesniGlavni.FormaHomeScreen.jezik[463];

            label30.Location = new Point(label1.Location.X, label29.Bottom + 20);
            label30.Text = FormaDesniGlavni.FormaHomeScreen.jezik[464];

            label31.Location = new Point(label1.Location.X, label30.Bottom + 20);
            label31.Text = FormaDesniGlavni.FormaHomeScreen.jezik[465];

            label32.Location = new Point(label1.Location.X, label31.Bottom + 20);
            label32.Text = FormaDesniGlavni.FormaHomeScreen.jezik[466];

            label33.Location = new Point(label1.Location.X, label32.Bottom + 20);
            label33.Text = FormaDesniGlavni.FormaHomeScreen.jezik[467];

            label34.Location = new Point(label1.Location.X, label33.Bottom + 20);
            label34.Text = FormaDesniGlavni.FormaHomeScreen.jezik[468];

            label35.Location = new Point(label1.Location.X, label34.Bottom + 20);
            label35.Text = FormaDesniGlavni.FormaHomeScreen.jezik[469];

            zoomablePictureBox2.Location = new Point(label1.Location.X, label35.Bottom + 20);

            label36.Location = new Point(label1.Location.X, zoomablePictureBox2.Bottom);
            label36.Text = FormaDesniGlavni.FormaHomeScreen.jezik[470];

            label37.Location = new Point(label1.Location.X, label36.Bottom + 20);
            label37.Text = FormaDesniGlavni.FormaHomeScreen.jezik[471];

            label38.Location = new Point(label1.Location.X, label37.Bottom + 20);
            label38.Text = FormaDesniGlavni.FormaHomeScreen.jezik[472];

            label39.Location = new Point(label1.Location.X, label38.Bottom + 20);
            label39.Text = FormaDesniGlavni.FormaHomeScreen.jezik[473];

            label40.Location = new Point(label1.Location.X, label39.Bottom + 20);
            label40.Text = FormaDesniGlavni.FormaHomeScreen.jezik[474];

            label41.Location = new Point(label1.Location.X, label40.Bottom + 20);
            label41.Text = FormaDesniGlavni.FormaHomeScreen.jezik[475];

            label42.Location = new Point(label1.Location.X, label41.Bottom + 20);
            label42.Text = FormaDesniGlavni.FormaHomeScreen.jezik[476];

            zoomablePictureBox3.Location = new Point(label1.Location.X, label42.Bottom + 20);

            label43.Location = new Point(label1.Location.X, zoomablePictureBox3.Bottom);
            label43.Text = FormaDesniGlavni.FormaHomeScreen.jezik[477];

            label44.Location = new Point(label1.Location.X, label43.Bottom + 20);
            label44.Text = FormaDesniGlavni.FormaHomeScreen.jezik[478];

            label45.Location = new Point(label1.Location.X, label44.Bottom + 20);
            label45.Text = FormaDesniGlavni.FormaHomeScreen.jezik[479];

            label46.Location = new Point(label1.Location.X, label45.Bottom + 20);
            label46.Text = FormaDesniGlavni.FormaHomeScreen.jezik[480];

            label47.Location = new Point(label1.Location.X, label46.Bottom + 20);
            label47.Text = FormaDesniGlavni.FormaHomeScreen.jezik[481];

            label48.Location = new Point(label1.Location.X, label47.Bottom + 20);
            label48.Text = FormaDesniGlavni.FormaHomeScreen.jezik[482];

            label49.Location = new Point(label1.Location.X, label48.Bottom + 20);
            label49.Text = FormaDesniGlavni.FormaHomeScreen.jezik[483];

            label50.Location = new Point(label1.Location.X, label49.Bottom + 20);
            label50.Text = FormaDesniGlavni.FormaHomeScreen.jezik[484];

            zoomablePictureBox4.Location = new Point(label1.Location.X, label50.Bottom + 20);

            label51.Location = new Point(label1.Location.X, zoomablePictureBox4.Bottom);
            label51.Text = FormaDesniGlavni.FormaHomeScreen.jezik[485];

            label52.Location = new Point(label1.Location.X, label51.Bottom + 20);
            label52.Text = FormaDesniGlavni.FormaHomeScreen.jezik[486];

            label53.Location = new Point(label1.Location.X, label52.Bottom + 20);
            label53.Text = FormaDesniGlavni.FormaHomeScreen.jezik[487];

            label54.Location = new Point(label1.Location.X, label53.Bottom + 20);
            label54.Text = FormaDesniGlavni.FormaHomeScreen.jezik[488];

            label55.Location = new Point(label1.Location.X, label54.Bottom + 20);
            label55.Text = FormaDesniGlavni.FormaHomeScreen.jezik[489];

            label56.Location = new Point(label1.Location.X, label55.Bottom + 20);
            label56.Text = FormaDesniGlavni.FormaHomeScreen.jezik[490];

            label57.Location = new Point(label1.Location.X, label56.Bottom + 20);
            label57.Text = FormaDesniGlavni.FormaHomeScreen.jezik[491];

            label58.Location = new Point(label1.Location.X, label57.Bottom + 20);
            label58.Text = FormaDesniGlavni.FormaHomeScreen.jezik[492];

            label59.Location = new Point(label1.Location.X, label58.Bottom + 20);
            label59.Text = FormaDesniGlavni.FormaHomeScreen.jezik[493];

            zoomablePictureBox5.Location = new Point(label1.Location.X, label59.Bottom + 20);

            label60.Location = new Point(label1.Location.X, zoomablePictureBox5.Bottom);
            label60.Text = FormaDesniGlavni.FormaHomeScreen.jezik[494];

            zoomablePictureBox6.Location = new Point(label1.Location.X, label60.Bottom + 20);

            label61.Location = new Point(label1.Location.X, zoomablePictureBox6.Bottom);
            label61.Text = FormaDesniGlavni.FormaHomeScreen.jezik[495];

            label62.Location = new Point(label1.Location.X, label61.Bottom + 20);
            label62.Text = FormaDesniGlavni.FormaHomeScreen.jezik[496];

            label63.Location = new Point(label1.Location.X, label62.Bottom + 20);
            label63.Text = FormaDesniGlavni.FormaHomeScreen.jezik[497];

            label64.Location = new Point(label1.Location.X, label63.Bottom + 20);
            label64.Text = FormaDesniGlavni.FormaHomeScreen.jezik[498];

            label65.Location = new Point(label1.Location.X, label64.Bottom + 20);
            label65.Text = FormaDesniGlavni.FormaHomeScreen.jezik[499];

            zoomablePictureBox7.Location = new Point(label1.Location.X, label65.Bottom + 20);

            label66.Location = new Point(label1.Location.X, zoomablePictureBox7.Bottom);
            label66.Text = FormaDesniGlavni.FormaHomeScreen.jezik[500];

            label67.Location = new Point(label1.Location.X, label66.Bottom + 20);
            label67.Text = FormaDesniGlavni.FormaHomeScreen.jezik[501];

            label68.Location = new Point(label1.Location.X, label67.Bottom + 20);
            label68.Text = FormaDesniGlavni.FormaHomeScreen.jezik[502];

            zoomablePictureBox8.Location = new Point(label1.Location.X, label68.Bottom + 20);

            label69.Location = new Point(label1.Location.X, zoomablePictureBox8.Bottom);
            label69.Text = FormaDesniGlavni.FormaHomeScreen.jezik[503];

            label70.Location = new Point(label1.Location.X, label69.Bottom + 20);
            label70.Text = FormaDesniGlavni.FormaHomeScreen.jezik[504];

            label71.Location = new Point(label1.Location.X, label70.Bottom + 20);
            label71.Text = FormaDesniGlavni.FormaHomeScreen.jezik[505];

            label72.Location = new Point(label1.Location.X, label71.Bottom + 20);
            label72.Text = FormaDesniGlavni.FormaHomeScreen.jezik[506];

            zoomablePictureBox9.Location = new Point(label1.Location.X, label72.Bottom + 20);

            label73.Location = new Point(label1.Location.X, zoomablePictureBox9.Bottom);
            label73.Text = FormaDesniGlavni.FormaHomeScreen.jezik[507];

            label74.Location = new Point(label1.Location.X, label73.Bottom + 20);
            label74.Text = FormaDesniGlavni.FormaHomeScreen.jezik[508];

            button2.Text = FormaDesniGlavni.FormaHomeScreen.jezik[314];
            button2.Location = new Point(button2.Location.X, label74.Location.Y - (button2.Height - label74.Height) - 5);

            #endregion

            RadialWheelAndTireAssemblyRunout  = label24.Location.Y - 5;
            LateralWheelAndTireAssemblyRunout = label33.Location.Y - 5;
            RadialWheelRunout                 = label40.Location.Y - 5;
            LateralWheelRunout                = label48.Location.Y - 5;
            HubBrakeDiscRunout                = label56.Location.Y - 5;
            RadialForceVariation              = label63.Location.Y - 5;
            BentAxleShaft                     = label71.Location.Y - 5;
        }

        private void Forma_Desni_Tekst_Tocak_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(0, 0);
        }

        private void Forma_Desni_Tekst_Tocak_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaDesniGlavni.FormaDesniTekstTocak = null;
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
        
        private void gotoRadialWheelAndTireAssemblyRunout(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, RadialWheelAndTireAssemblyRunout);
        }

        private void gotoLateralWheelAndTireAssemblyRunout(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, LateralWheelAndTireAssemblyRunout);
        }

        private void gotoRadialWheelRunout(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, RadialWheelRunout);
        }

        private void gotoLateralWheelRunout(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, LateralWheelRunout);
        }

        private void gotoHubBrakeDiscRunout(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, HubBrakeDiscRunout);
        }

        private void gotoRadialForceVariation(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, RadialForceVariation);
        }

        private void gotoBentAxleShaft(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, BentAxleShaft);
        }

        public Point PanelScrollPos
        {
            get { return panel1.AutoScrollPosition; }
            set { panel1.AutoScrollPosition = value; }
        }
    }
}
