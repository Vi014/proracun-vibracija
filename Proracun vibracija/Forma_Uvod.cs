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
    public partial class Forma_Uvod : Form
    {
        Forma_HomeScreen FormaHomeScreen;

        public Forma_Uvod(Forma_HomeScreen konstruktor)
        {
            InitializeComponent();
            FormaHomeScreen = konstruktor;
        }

        // Int32 h;

        public void PromenaJezika() // za vertikalne razmake izmedju dva labela, bottom + 20 za veliki razmak (razmak izmedju dva razlicita paragrafa) ili bottom + 1 za mali razmak (razmak izmedju dve razlicite linije u jednom paragrafu)
        {
            this.Text = FormaHomeScreen.jezik[251];
            // za recenice gde je jedan deo u italicu (npr "the <i>transmission system</i> bla bla")
            // ako je ovaj deo recenice sto ide posle italika dovoljno velik da se mora razdvojiti u vise redova
            // on ce morati da se pise kao dva odvojena labela (a samim tim i dva odvojena elementa u nizu jezik)
            // zato sto ovaj prvi label koji ide posle italika
            // ima kao svoje koordinate mesto direktno desno od italika
            // te ako bi se u njega ubacio novi red, taj sam novi red bi bio pomeren ka desno
            // npr
            // ITALIKNESTO ostatakteksta ostatakteksta
            //             ostatakteksta
            // umesto
            // ITALIKNESTO ostatakteksta ostatakteksta
            // ostatakteksta

            #region dokument

            label1.Text = FormaHomeScreen.jezik[252];

            label2.Location = new Point(label1.Location.X, label1.Bottom + 20);
            label2.Text = FormaHomeScreen.jezik[253];

            label3.Location = new Point(label2.Right - 5, label2.Location.Y);
            label3.Text = FormaHomeScreen.jezik[254];

            label4.Location = new Point(label1.Location.X, label2.Bottom + 20);
            label4.Text = FormaHomeScreen.jezik[255];

            label5.Location = new Point(label4.Right - 5, label4.Location.Y);
            label5.Text = FormaHomeScreen.jezik[256];

            label6.Location = new Point(label1.Location.X, label4.Bottom + 20);
            label6.Text = FormaHomeScreen.jezik[257];

            label7.Location = new Point(label6.Right - 5, label6.Location.Y);
            label7.Text = FormaHomeScreen.jezik[258];

            label8.Location = new Point(label1.Location.X, label6.Bottom + 20);
            label8.Text = FormaHomeScreen.jezik[259];

            label9.Location = new Point(label8.Right - 5, label8.Location.Y);
            label9.Text = FormaHomeScreen.jezik[260];

            label10.Location = new Point(label9.Right - 5, label9.Location.Y);
            label10.Text = FormaHomeScreen.jezik[261];

            label11.Location = new Point(label1.Location.X, label9.Bottom + 1);
            label11.Text = FormaHomeScreen.jezik[262];

            pictureBox1.Location = new Point(label1.Location.X, label11.Bottom + 20);
            pictureBox2.Location = new Point(pictureBox1.Right, pictureBox1.Location.Y);

            label12.Location = new Point(label1.Location.X, pictureBox1.Bottom + 20);
            label12.Text = FormaHomeScreen.jezik[263];

            label13.Location = new Point(label1.Location.X, label12.Bottom + 20);
            label13.Text = FormaHomeScreen.jezik[264];

            label14.Location = new Point(label1.Location.X, label13.Bottom + 20);
            label14.Text = FormaHomeScreen.jezik[265];

            label15.Location = new Point(label1.Location.X, label14.Bottom + 20);
            label15.Text = FormaHomeScreen.jezik[266];

            pictureBox3.Location = new Point(label1.Location.X, label15.Bottom);

            label16.Location = new Point(label1.Location.X, pictureBox3.Bottom + 20);
            label16.Text = FormaHomeScreen.jezik[267];

            label17.Location = new Point(label1.Location.X, label16.Location.Y + 20);
            label17.Text = FormaHomeScreen.jezik[268];

            pictureBox4.Location = new Point(label1.Location.X, label17.Bottom + 20);

            label18.Location = new Point(label1.Location.X, pictureBox4.Bottom);
            label18.Text = FormaHomeScreen.jezik[269];

            pictureBox5.Location = new Point(label1.Location.X, label18.Bottom + 20);

            label19.Location = new Point(label1.Location.X, pictureBox5.Bottom);
            label19.Text = FormaHomeScreen.jezik[270];

            label20.Location = new Point(label1.Location.X, label19.Bottom + 20);
            label20.Text = FormaHomeScreen.jezik[271];

            label21.Location = new Point(label1.Location.X, label20.Bottom + 20);
            label21.Text = FormaHomeScreen.jezik[272];

            label22.Location = new Point(label1.Location.X, label21.Bottom + 20);
            label22.Text = FormaHomeScreen.jezik[273];

            pictureBox6.Location = new Point(label1.Location.X, label22.Bottom + 20);

            label23.Location = new Point(label1.Location.X, pictureBox6.Bottom);
            label23.Text = FormaHomeScreen.jezik[274];

            pictureBox7.Location = new Point(label1.Location.X, label23.Bottom + 20);

            label24.Location = new Point(label1.Location.X, pictureBox7.Bottom);
            label24.Text = FormaHomeScreen.jezik[275];

            label25.Location = new Point(label1.Location.X, label24.Bottom + 20);
            label25.Text = FormaHomeScreen.jezik[276];

            label26.Location = new Point(label1.Location.X, label25.Bottom + 20);
            label26.Text = FormaHomeScreen.jezik[277];

            pictureBox8.Location = new Point(label1.Location.X, label26.Bottom + 20);

            label27.Location = new Point(label1.Location.X, pictureBox8.Bottom);
            label27.Text = FormaHomeScreen.jezik[278];

            label28.Location = new Point(label1.Location.X, label27.Bottom + 20);
            label28.Text = FormaHomeScreen.jezik[279];

            label29.Location = new Point(label1.Location.X, label28.Bottom + 20);
            label29.Text = FormaHomeScreen.jezik[280];

            pictureBox9.Location = new Point(label1.Location.X, label29.Bottom + 20);

            label30.Location = new Point(label1.Location.X, pictureBox9.Bottom + 20);
            label30.Text = FormaHomeScreen.jezik[281];



            label31.Location = new Point(label1.Location.X, label30.Bottom + 20);
            label31.Text = FormaHomeScreen.jezik[282];

            label32.Location = new Point(label1.Location.X, label31.Bottom + 20);
            label32.Text = FormaHomeScreen.jezik[283];

            label33.Location = new Point(label1.Location.X, label32.Bottom + 20);
            label33.Text = FormaHomeScreen.jezik[284];

            label34.Location = new Point(label33.Right - 5, label33.Location.Y);
            label34.Text = FormaHomeScreen.jezik[285];

            label35.Location = new Point(label34.Right - 5, label34.Location.Y);
            label35.Text = FormaHomeScreen.jezik[286];

            label36.Location = new Point(label1.Location.X, label35.Bottom + 1);
            label36.Text = FormaHomeScreen.jezik[287];



            label37.Location = new Point(label1.Location.X, label36.Bottom + 20);
            label37.Text = FormaHomeScreen.jezik[288];

            label38.Location = new Point(label37.Right - 5, label37.Location.Y);
            label38.Text = FormaHomeScreen.jezik[289];

            label39.Location = new Point(label38.Right - 5, label38.Location.Y);
            label39.Text = FormaHomeScreen.jezik[290];

            label40.Location = new Point(label1.Location.X, label37.Bottom + 1);
            label40.Text = FormaHomeScreen.jezik[291];



            label41.Location = new Point(label1.Location.X, label40.Bottom + 20);
            label41.Text = FormaHomeScreen.jezik[292]; // The

            label42.Location = new Point(label41.Right - 5, label41.Location.Y);
            label42.Text = FormaHomeScreen.jezik[293];

            label43.Location = new Point(label42.Right - 5, label41.Location.Y);
            label43.Text = FormaHomeScreen.jezik[294];

            label44.Location = new Point(label1.Location.X, label41.Bottom + 1);
            label44.Text = FormaHomeScreen.jezik[295];

            label45.Location = new Point(label1.Location.X, label44.Bottom + 1);
            label45.Text = FormaHomeScreen.jezik[296];



            label46.Location = new Point(label1.Location.X, label45.Bottom + 20);
            label46.Text = FormaHomeScreen.jezik[297];

            label47.Location = new Point(label46.Right - 5, label46.Location.Y);
            label47.Text = FormaHomeScreen.jezik[298];

            label48.Location = new Point(label47.Right - 5, label46.Location.Y);
            label48.Text = FormaHomeScreen.jezik[299];

            label49.Location = new Point(label1.Location.X, label46.Bottom + 1);
            label49.Text = FormaHomeScreen.jezik[300];



            label50.Location = new Point(label1.Location.X, label49.Bottom + 20);
            label50.Text = FormaHomeScreen.jezik[301];

            label51.Location = new Point(label1.Location.X, label50.Bottom + 1);
            label51.Text = FormaHomeScreen.jezik[302];

            label52.Location = new Point(label1.Location.X, label51.Bottom + 1);
            label52.Text = FormaHomeScreen.jezik[303];



            label53.Location = new Point(label1.Location.X, label52.Bottom + 20);
            label53.Text = FormaHomeScreen.jezik[304];

            label54.Location = new Point(label1.Location.X, label53.Bottom + 1);
            label54.Text = FormaHomeScreen.jezik[305];

            pictureBox10.Location = new Point(label1.Location.X, label54.Bottom + 20);
            pictureBox11.Location = new Point(pictureBox10.Right + 5, pictureBox10.Location.Y);
            pictureBox12.Location = new Point(pictureBox11.Right + 5, pictureBox10.Location.Y);
            pictureBox13.Location = new Point(pictureBox12.Right + 5, pictureBox10.Location.Y);

            #endregion
        }

        private void Forma_Uvod_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(0, 0);
        }

        private void Forma_Uvod_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaHomeScreen.FormaUvod           = null;
            FormaHomeScreen.dugmeDodatnoEnabled = true;
        }

        private void zoom(object sender, EventArgs e)
        {
            Image slika = (sender as PictureBox).Image;

            zoomPicture.Image = slika;
            zoomPicture.Visible = button1.Visible = true;
            panel1.Enabled = false;

            Int32 panelH = panel1.Height,
                    panelW = panel1.Width,
                    slikaH = slika.Height,
                    slikaW = slika.Width,
                    centarX = panelW / 2 + panel1.Location.X,
                    centarY = panelH / 2 + panel1.Location.Y;
            Double ratioH = 0, ratioW = 0;

            for (Double i = 0; slikaH * i <= panelH; i += 0.25) ratioH = i;
            for (Double i = 0; slikaW * i <= panelW; i += 0.25) ratioW = i;

            if (ratioH < ratioW)
            {
                zoomPicture.Height = Convert.ToInt32(slikaH * ratioH);
                zoomPicture.Width  = Convert.ToInt32(slikaW * ratioH);
            }
            else
            {
                zoomPicture.Height = Convert.ToInt32(slikaH * ratioW);
                zoomPicture.Width  = Convert.ToInt32(slikaW * ratioW);
            }

            zoomPicture.Location = new Point((centarX - zoomPicture.Width / 2), (centarY - zoomPicture.Height / 2));
            button1.Location     = new Point(zoomPicture.Right, zoomPicture.Top);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zoomPicture.Visible = button1.Visible = false;
            panel1.Enabled = true;
        }
    }
}
