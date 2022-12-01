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
    public partial class Forma_Centar_Tekst : Form
    {
        public Forma_Centar_Glavni FormaCentarGlavni;

        public Forma_Centar_Tekst(Forma_Centar_Glavni konstruktor)
        {
            InitializeComponent();
            FormaCentarGlavni = konstruktor;
        }

        public Int32 EngineVibrations, EngineFiringFrequency, EngineAccessoryVibrations, CrankshaftPulley, TorqueConverter, EngineMounts, ExhaustHangers;

        public void PromenaJezika()
        {
            this.Text = FormaCentarGlavni.FormaHomeScreen.jezik[319];

            #region dokument

            label1.Location = new Point(16, 14);
            label1.Text = FormaCentarGlavni.FormaHomeScreen.jezik[320];

            label2.Location = new Point(label1.Location.X, label1.Bottom + 20);
            label2.Text = FormaCentarGlavni.FormaHomeScreen.jezik[321];

            label3.Location = new Point(label1.Location.X, label2.Bottom + 1);
            label3.Text = FormaCentarGlavni.FormaHomeScreen.jezik[322];

            label4.Location = new Point(label3.Right - 7, label3.Location.Y);
            label4.Text = FormaCentarGlavni.FormaHomeScreen.jezik[323];

            label5.Location = new Point(label1.Location.X, label3.Bottom + 1);
            label5.Text = FormaCentarGlavni.FormaHomeScreen.jezik[322];

            label6.Location = new Point(label5.Right - 7, label5.Location.Y);
            label6.Text = FormaCentarGlavni.FormaHomeScreen.jezik[324];

            label7.Location = new Point(label1.Location.X, label5.Bottom + 1);
            label7.Text = FormaCentarGlavni.FormaHomeScreen.jezik[322];

            label8.Location = new Point(label7.Right - 7, label7.Location.Y);
            label8.Text = FormaCentarGlavni.FormaHomeScreen.jezik[325];

            label9.Location = new Point(label1.Location.X, label7.Bottom + 20);
            label9.Text = FormaCentarGlavni.FormaHomeScreen.jezik[326];

            label10.Location = new Point(label1.Location.X, label9.Bottom + 20);
            label10.Text = FormaCentarGlavni.FormaHomeScreen.jezik[327];

            label11.Location = new Point(label1.Location.X, label10.Bottom + 20);
            label11.Text = FormaCentarGlavni.FormaHomeScreen.jezik[328];

            label12.Location = new Point(label1.Location.X, label11.Bottom + 20);
            label12.Text = FormaCentarGlavni.FormaHomeScreen.jezik[329];

            label13.Location = new Point(label1.Location.X, label12.Bottom + 1);
            label13.Text = FormaCentarGlavni.FormaHomeScreen.jezik[330];

            label14.Location = new Point(label1.Location.X, label13.Bottom + 1);
            label14.Text = FormaCentarGlavni.FormaHomeScreen.jezik[331];

            label15.Location = new Point(label14.Right - 7, label14.Location.Y);
            label15.Text = FormaCentarGlavni.FormaHomeScreen.jezik[332];

            label16.Location = new Point(label1.Location.X, label14.Bottom + 1);
            label16.Text = FormaCentarGlavni.FormaHomeScreen.jezik[333];

            label17.Location = new Point(label1.Location.X, label16.Bottom + 1);
            label17.Text = FormaCentarGlavni.FormaHomeScreen.jezik[334];

            label18.Location = new Point(label17.Right - 7, label17.Location.Y);
            label18.Text = FormaCentarGlavni.FormaHomeScreen.jezik[335];

            label19.Location = new Point(label1.Location.X, label18.Bottom + 1);
            label19.Text = FormaCentarGlavni.FormaHomeScreen.jezik[336];

            label20.Location = new Point(label1.Location.X, label19.Bottom + 20);
            label20.Text = FormaCentarGlavni.FormaHomeScreen.jezik[337];

            label21.Location = new Point(label1.Location.X, label20.Bottom + 20);
            label21.Text = FormaCentarGlavni.FormaHomeScreen.jezik[338];

            zoomablePictureBox1.Location = new Point(label1.Location.X, label21.Bottom + 20);

            label22.Location = new Point(label1.Location.X, zoomablePictureBox1.Bottom + 20);
            label22.Text = FormaCentarGlavni.FormaHomeScreen.jezik[339];

            zoomablePictureBox2.Location = new Point(label1.Location.X, label22.Bottom + 20);

            label23.Location = new Point(label1.Location.X, zoomablePictureBox2.Bottom + 20);
            label23.Text = FormaCentarGlavni.FormaHomeScreen.jezik[340];

            label24.Location = new Point(label1.Location.X, label23.Bottom + 20);
            label24.Text = FormaCentarGlavni.FormaHomeScreen.jezik[341];

            label25.Location = new Point(label1.Location.X, label24.Bottom + 20);
            label25.Text = FormaCentarGlavni.FormaHomeScreen.jezik[342];

            label26.Location = new Point(label1.Location.X, label25.Bottom + 20);
            label26.Text = FormaCentarGlavni.FormaHomeScreen.jezik[343];

            label27.Location = new Point(label1.Location.X, label26.Bottom + 20);
            label27.Text = FormaCentarGlavni.FormaHomeScreen.jezik[344];

            label28.Location = new Point(label1.Location.X, label27.Bottom + 1);
            label28.Text = FormaCentarGlavni.FormaHomeScreen.jezik[345];

            label29.Location = new Point(label28.Right - 7, label28.Location.Y);
            label29.Text = FormaCentarGlavni.FormaHomeScreen.jezik[346];

            label30.Location = new Point(label1.Location.X, label29.Bottom + 1);
            label30.Text = FormaCentarGlavni.FormaHomeScreen.jezik[347];

            label31.Location = new Point(label1.Location.X, label30.Bottom + 1);
            label31.Text = FormaCentarGlavni.FormaHomeScreen.jezik[348];

            label32.Location = new Point(label1.Location.X, label31.Bottom + 1);
            label32.Text = FormaCentarGlavni.FormaHomeScreen.jezik[349];

            label33.Location = new Point(label1.Location.X, label32.Bottom + 20);
            label33.Text = FormaCentarGlavni.FormaHomeScreen.jezik[350];

            label34.Location = new Point(label1.Location.X, label33.Bottom + 20);
            label34.Text = FormaCentarGlavni.FormaHomeScreen.jezik[351];

            label35.Location = new Point(label1.Location.X, label34.Bottom + 20);
            label35.Text = FormaCentarGlavni.FormaHomeScreen.jezik[352];

            label36.Location = new Point(label35.Right - 7, label35.Location.Y);
            label36.Text = FormaCentarGlavni.FormaHomeScreen.jezik[353];

            label37.Location = new Point(label1.Location.X, label35.Bottom + 20);
            label37.Text = FormaCentarGlavni.FormaHomeScreen.jezik[354];

            label38.Location = new Point(label1.Location.X, label37.Bottom + 20);
            label38.Text = FormaCentarGlavni.FormaHomeScreen.jezik[355];

            label39.Location = new Point(label38.Right - 7, label38.Location.Y);
            label39.Text = FormaCentarGlavni.FormaHomeScreen.jezik[356];

            label40.Location = new Point(label1.Location.X, label38.Bottom + 20);
            label40.Text = FormaCentarGlavni.FormaHomeScreen.jezik[357];

            label41.Location = new Point(label1.Location.X, label40.Bottom + 20);
            label41.Text = FormaCentarGlavni.FormaHomeScreen.jezik[358];

            label42.Location = new Point(label41.Right - 7, label41.Location.Y);
            label42.Text = FormaCentarGlavni.FormaHomeScreen.jezik[359];

            label43.Location = new Point(label1.Location.X, label41.Bottom + 20);
            label43.Text = FormaCentarGlavni.FormaHomeScreen.jezik[360];

            label44.Location = new Point(label1.Location.X, label43.Bottom + 20);
            label44.Text = FormaCentarGlavni.FormaHomeScreen.jezik[361];

            label45.Location = new Point(label1.Location.X, label44.Bottom + 20);
            label45.Text = FormaCentarGlavni.FormaHomeScreen.jezik[362];

            label46.Location = new Point(label1.Location.X, label45.Bottom + 20);
            label46.Text = FormaCentarGlavni.FormaHomeScreen.jezik[363];

            label47.Location = new Point(label1.Location.X, label46.Bottom + 1);
            label47.Text = FormaCentarGlavni.FormaHomeScreen.jezik[364];

            label48.Location = new Point(label47.Right - 7, label47.Location.Y);
            label48.Text = FormaCentarGlavni.FormaHomeScreen.jezik[365];

            label49.Location = new Point(label1.Location.X, label47.Bottom + 1);
            label49.Text = FormaCentarGlavni.FormaHomeScreen.jezik[366];

            label50.Location = new Point(label49.Right - 7, label49.Location.Y);
            label50.Text = FormaCentarGlavni.FormaHomeScreen.jezik[367];

            label51.Location = new Point(label1.Location.X, label49.Bottom + 1);
            label51.Text = FormaCentarGlavni.FormaHomeScreen.jezik[368];

            label52.Location = new Point(label1.Location.X, label51.Bottom + 20);
            label52.Text = FormaCentarGlavni.FormaHomeScreen.jezik[369];

            label53.Location = new Point(label1.Location.X, label52.Bottom + 20);
            label53.Text = FormaCentarGlavni.FormaHomeScreen.jezik[370];

            label54.Location = new Point(label1.Location.X, label53.Bottom + 20);
            label54.Text = FormaCentarGlavni.FormaHomeScreen.jezik[371];

            label55.Location = new Point(label1.Location.X, label54.Bottom + 20);
            label55.Text = FormaCentarGlavni.FormaHomeScreen.jezik[372];

            zoomablePictureBox3.Location = new Point(label1.Location.X, label55.Bottom + 20);

            label56.Location = new Point(label1.Location.X, zoomablePictureBox3.Bottom + 20);
            label56.Text = FormaCentarGlavni.FormaHomeScreen.jezik[373];

            zoomablePictureBox4.Location = new Point(label1.Location.X, label56.Bottom + 20);
            zoomablePictureBox5.Location = new Point(zoomablePictureBox4.Right + 5, zoomablePictureBox4.Location.Y);

            label57.Location = new Point(label1.Location.X, zoomablePictureBox4.Bottom + 20);
            label57.Text = FormaCentarGlavni.FormaHomeScreen.jezik[374];

            label58.Location = new Point(label1.Location.X, label57.Bottom + 20);
            label58.Text = FormaCentarGlavni.FormaHomeScreen.jezik[375];

            label59.Location = new Point(label1.Location.X, label58.Bottom + 20);
            label59.Text = FormaCentarGlavni.FormaHomeScreen.jezik[376];

            label60.Location = new Point(label1.Location.X, label59.Bottom + 20);
            label60.Text = FormaCentarGlavni.FormaHomeScreen.jezik[377];

            zoomablePictureBox6.Location = new Point(label1.Location.X, label60.Bottom + 20);

            label61.Location = new Point(label1.Location.X, zoomablePictureBox6.Bottom + 20);
            label61.Text = FormaCentarGlavni.FormaHomeScreen.jezik[378];

            label62.Location = new Point(label1.Location.X, label61.Bottom + 20);
            label62.Text = FormaCentarGlavni.FormaHomeScreen.jezik[379];

            label63.Location = new Point(label1.Location.X, label62.Bottom + 20);
            label63.Text = FormaCentarGlavni.FormaHomeScreen.jezik[380];

            label64.Location = new Point(label1.Location.X, label63.Bottom + 20);
            label64.Text = FormaCentarGlavni.FormaHomeScreen.jezik[381];

            button1.Text = FormaCentarGlavni.FormaHomeScreen.jezik[314];
            button2.Location = new Point(button2.Location.X, label64.Location.Y + (label64.Height - button2.Height) - 5);

            #endregion

            EngineVibrations          = label9.Location.Y  - 5;
            EngineFiringFrequency     = label43.Location.Y - 5;
            EngineAccessoryVibrations = label62.Location.Y - 5;
            CrankshaftPulley          = label20.Location.Y - 5;
            TorqueConverter           = label24.Location.Y - 5;
            EngineMounts              = label52.Location.Y - 5;
            ExhaustHangers            = label58.Location.Y - 5;
        }

        private void Forma_Centar_Tekst_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(0, 0);
        }

        private void Forma_Centar_Tekst_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormaCentarGlavni.FormaCentarTekst = null;
        }

        private void zoom(object sender, EventArgs e)
        {
            (sender as ZoomablePictureBox).Zoom(zoomPicture, button1, panel1, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zoomPicture.Visible = button1.Visible = false;
            panel1.Enabled = true;
        }

        private void CursorHand(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void gotoBeginning(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, 0);
        }

        private void gotoEngineVibrations(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, EngineVibrations);
        }

        private void gotoEngineFiringFrequency(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, EngineFiringFrequency);
        }

        private void gotoEngineAccessoryVibrations(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, EngineAccessoryVibrations);
        }

        private void gotoCrankshaftPulley(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, CrankshaftPulley);
        }

        private void gotoTorqueConverter(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, TorqueConverter);
        }

        private void gotoEngineMounts(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, EngineMounts);
        }

        private void gotoExhaustHangers(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, ExhaustHangers);
        }

        public Point PanelScrollPos
        {
            get { return panel1.AutoScrollPosition;  }
            set { panel1.AutoScrollPosition = value; }
        }
    }
}