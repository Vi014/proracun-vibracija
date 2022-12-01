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
    public partial class Forma_Desni_Grafik : Form
    {
        public Forma_Desni_Glavni FormaDesniGlavni;

        Graphics g;
        Pen p = new Pen(Color.Black, 2);

        Pen p_L1 = new Pen(Color.Blue,          2);
        Pen p_L2 = new Pen(Color.DarkGoldenrod, 2);
        Pen p_L3 = new Pen(Color.Green,         2);
        Pen p_L4 = new Pen(Color.Orange,        2);
        Pen p_L5 = new Pen(Color.Purple,        2);
        Pen p_L6 = new Pen(Color.Black,         2);
        Pen p_L7 = new Pen(Color.DodgerBlue,    2);
        Pen p_L8 = new Pen(Color.DeepPink,      2);

        Pen p_L21 = new Pen(Color.Navy,           2);
        Pen p_L22 = new Pen(Color.SaddleBrown,    2);
        Pen p_L23 = new Pen(Color.DarkOliveGreen, 2);
        Pen p_L24 = new Pen(Color.Peru,           2);
        Pen p_L25 = new Pen(Color.Red,            2);
        Pen p_L26 = new Pen(Color.DarkGray,       2);
        Pen p_L27 = new Pen(Color.SteelBlue,      2);
        Pen p_L28 = new Pen(Color.Orchid,         2);

        Font font    = new Font("Arial", 8);
        Font fontX   = new Font("Arial", 14);
        Font osaFont = new Font("Arial", 10);
        SolidBrush cetka      = new SolidBrush(Color.Black);
        SolidBrush cetkaError = new SolidBrush(Color.Red);

        SolidBrush cetkaL1 = new SolidBrush(Color.Blue);
        SolidBrush cetkaL2 = new SolidBrush(Color.DarkGoldenrod);
        SolidBrush cetkaL3 = new SolidBrush(Color.Green);
        SolidBrush cetkaL4 = new SolidBrush(Color.Orange);
        SolidBrush cetkaL5 = new SolidBrush(Color.Purple);
        SolidBrush cetkaL6 = new SolidBrush(Color.Black);
        SolidBrush cetkaL7 = new SolidBrush(Color.DodgerBlue);
        SolidBrush cetkaL8 = new SolidBrush(Color.DeepPink);

        Stack<Double> V_Stek           = new Stack<Double>();
        Stack<Double> Frekvencije_Stek = new Stack<Double>();
        Double[] V_Niz, Frekvencije_Niz;

        Int32 i, j;
        Int32 brPodeljakaX, brPodeljakaY, podeljakX, podeljakY;
        Int32 centarX, centarY;

        Double pom;
        Double Xmax, Ymax;
        Double X_Razdaljina_Piksel, Y_Razdaljina_Piksel;
        Double konverzijaX, konverzijaY;

        Double y;

        public Forma_Desni_Grafik(Forma_Desni_Glavni konstruktor)
        {
            InitializeComponent();
            FormaDesniGlavni = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text        = FormaDesniGlavni.FormaHomeScreen.jezik[149];
            button1.Text     = FormaDesniGlavni.FormaHomeScreen.jezik[150];
            label1.Text      = FormaDesniGlavni.FormaHomeScreen.jezik[151];
            checkBox_L1.Text = FormaDesniGlavni.FormaHomeScreen.jezik[168];
            checkBox_L2.Text = FormaDesniGlavni.FormaHomeScreen.jezik[169];
            checkBox_L3.Text = FormaDesniGlavni.FormaHomeScreen.jezik[170];
            checkBox_L4.Text = FormaDesniGlavni.FormaHomeScreen.jezik[171];
            checkBox_L5.Text = FormaDesniGlavni.FormaHomeScreen.jezik[172];
            checkBox_L6.Text = FormaDesniGlavni.FormaHomeScreen.jezik[173];
            checkBox_L7.Text = FormaDesniGlavni.FormaHomeScreen.jezik[174];
            checkBox_L8.Text = FormaDesniGlavni.FormaHomeScreen.jezik[175];

            label2.Text = FormaDesniGlavni.FormaHomeScreen.jezik[192];
            label3.Text = FormaDesniGlavni.FormaHomeScreen.jezik[193];

            checkBox_L21.Text = FormaDesniGlavni.FormaHomeScreen.jezik[194];
            checkBox_L22.Text = FormaDesniGlavni.FormaHomeScreen.jezik[195];
            checkBox_L23.Text = FormaDesniGlavni.FormaHomeScreen.jezik[196];
            checkBox_L24.Text = FormaDesniGlavni.FormaHomeScreen.jezik[197];
            checkBox_L25.Text = FormaDesniGlavni.FormaHomeScreen.jezik[198];
            checkBox_L26.Text = FormaDesniGlavni.FormaHomeScreen.jezik[199];
            checkBox_L27.Text = FormaDesniGlavni.FormaHomeScreen.jezik[200];
            checkBox_L28.Text = FormaDesniGlavni.FormaHomeScreen.jezik[201];

            IscrtajGrafik();
        }

        private void Forma_Desni_Grafik_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

            g = panel1.CreateGraphics();

            centarX = 30;
            centarY = panel1.Height - 30;
        }

        private void Forma_Desni_Grafik_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaDesniGlavni.FormaDesniGrafik = null;
            FormaDesniGlavni.buttonGrafikEnabled = true;
        }

        private void Forma_Desni_Grafik_Shown(object sender, EventArgs e)
        {
            Racun();
            PromenaJezika();
        }

        public void Racun()
        {
            checkBox_L5.Enabled     = button_FKx1.Enabled =
                checkBox_L6.Enabled = button_FKx2.Enabled =
                checkBox_L7.Enabled = button_FKx3.Enabled =
                checkBox_L8.Enabled = button_FKx4.Enabled =
                checkBox_L1.Checked = checkBox_L2.Checked = checkBox_L3.Checked = checkBox_L4.Checked = checkBox_L5.Checked = checkBox_L6.Checked = checkBox_L7.Checked = checkBox_L8.Checked = 
                checkBox_L21.Enabled = checkBox_L22.Enabled = checkBox_L23.Enabled = checkBox_L24.Enabled = checkBox_L25.Enabled = checkBox_L26.Enabled = checkBox_L27.Enabled = checkBox_L28.Enabled = 
                checkBox_L21.Checked = checkBox_L22.Checked = checkBox_L23.Checked = checkBox_L24.Checked = checkBox_L25.Checked = checkBox_L26.Checked = checkBox_L27.Checked = checkBox_L28.Checked = 
                false;

            if (FormaDesniGlavni.I != 0)
                checkBox_L5.Enabled = button_FKx1.Enabled =
                checkBox_L6.Enabled = button_FKx2.Enabled =
                checkBox_L7.Enabled = button_FKx3.Enabled =
                checkBox_L8.Enabled = button_FKx4.Enabled = true;

            if (FormaDesniGlavni.checkBox1Checked)
            {
                checkBox_L21.Enabled = checkBox_L22.Enabled = checkBox_L23.Enabled = checkBox_L24.Enabled = true;
                if (FormaDesniGlavni.I != 0) checkBox_L25.Enabled = checkBox_L26.Enabled = checkBox_L27.Enabled = checkBox_L28.Enabled = true;
            }

            V_Stek.Clear();
            Frekvencije_Stek.Clear();

            if (FormaDesniGlavni.v1unet)
            {
                V_Stek.Push(FormaDesniGlavni.V1);
                if (FormaDesniGlavni.F11 != 0) Frekvencije_Stek.Push(FormaDesniGlavni.F11);
                if (FormaDesniGlavni.F12 != 0) Frekvencije_Stek.Push(FormaDesniGlavni.F12);
                if (FormaDesniGlavni.F13 != 0) Frekvencije_Stek.Push(FormaDesniGlavni.F13);

                Frekvencije_Stek.Push(FormaDesniGlavni.FT1);
                Frekvencije_Stek.Push(FormaDesniGlavni.FT1x2);
                Frekvencije_Stek.Push(FormaDesniGlavni.FT1x3);
                Frekvencije_Stek.Push(FormaDesniGlavni.FT1x4);

                if (FormaDesniGlavni.I != 0)
                {
                    Frekvencije_Stek.Push(FormaDesniGlavni.FK1);
                    Frekvencije_Stek.Push(FormaDesniGlavni.FK1x2);
                    Frekvencije_Stek.Push(FormaDesniGlavni.FK1x3);
                    Frekvencije_Stek.Push(FormaDesniGlavni.FK1x4);
                }
            }
            if (FormaDesniGlavni.v2unet)
            {
                V_Stek.Push(FormaDesniGlavni.V2);
                if (FormaDesniGlavni.F21 != 0) Frekvencije_Stek.Push(FormaDesniGlavni.F21);
                if (FormaDesniGlavni.F22 != 0) Frekvencije_Stek.Push(FormaDesniGlavni.F22);
                if (FormaDesniGlavni.F23 != 0) Frekvencije_Stek.Push(FormaDesniGlavni.F23);

                Frekvencije_Stek.Push(FormaDesniGlavni.FT2);
                Frekvencije_Stek.Push(FormaDesniGlavni.FT2x2);
                Frekvencije_Stek.Push(FormaDesniGlavni.FT2x3);
                Frekvencije_Stek.Push(FormaDesniGlavni.FT2x4);

                if (FormaDesniGlavni.I != 0)
                {
                    Frekvencije_Stek.Push(FormaDesniGlavni.FK2);
                    Frekvencije_Stek.Push(FormaDesniGlavni.FK2x2);
                    Frekvencije_Stek.Push(FormaDesniGlavni.FK2x3);
                    Frekvencije_Stek.Push(FormaDesniGlavni.FK2x4);
                }
            }
            if (FormaDesniGlavni.v3unet)
            {
                V_Stek.Push(FormaDesniGlavni.V3);
                if (FormaDesniGlavni.F31 != 0) Frekvencije_Stek.Push(FormaDesniGlavni.F31);
                if (FormaDesniGlavni.F32 != 0) Frekvencije_Stek.Push(FormaDesniGlavni.F32);
                if (FormaDesniGlavni.F33 != 0) Frekvencije_Stek.Push(FormaDesniGlavni.F33);

                Frekvencije_Stek.Push(FormaDesniGlavni.FT3);
                Frekvencije_Stek.Push(FormaDesniGlavni.FT3x2);
                Frekvencije_Stek.Push(FormaDesniGlavni.FT3x3);
                Frekvencije_Stek.Push(FormaDesniGlavni.FT3x4);

                if (FormaDesniGlavni.I != 0)
                {
                    Frekvencije_Stek.Push(FormaDesniGlavni.FK3);
                    Frekvencije_Stek.Push(FormaDesniGlavni.FK3x2);
                    Frekvencije_Stek.Push(FormaDesniGlavni.FK3x3);
                    Frekvencije_Stek.Push(FormaDesniGlavni.FK3x4);
                }
            }

            V_Niz = V_Stek.ToArray();
            Frekvencije_Niz = Frekvencije_Stek.ToArray();

            #region sortiraj V_Niz
            for (i = 0; i < V_Niz.Length - 1; i++)
            {
                for (j = i + 1; j < V_Niz.Length; j++)
                {
                    if (V_Niz[i] > V_Niz[j])
                    {
                        pom = V_Niz[i];
                        V_Niz[i] = V_Niz[j];
                        V_Niz[j] = pom;
                    }
                }
            }
            #endregion

            #region sortiraj Frekvencije_Niz
            for (i = 0; i < Frekvencije_Niz.Length - 1; i++)
            {
                for (j = i + 1; j < Frekvencije_Niz.Length; j++)
                {
                    if (Frekvencije_Niz[i] > Frekvencije_Niz[j])
                    {
                        pom = Frekvencije_Niz[i];
                        Frekvencije_Niz[i] = Frekvencije_Niz[j];
                        Frekvencije_Niz[j] = pom;
                    }
                }
            }
            #endregion

            Xmax = V_Niz[V_Niz.Length - 1];
            Ymax = Frekvencije_Niz[Frekvencije_Niz.Length - 1];

            X_Razdaljina_Piksel = panel1.Width - centarX;
            Y_Razdaljina_Piksel = centarY;

            konverzijaX = (Double)X_Razdaljina_Piksel / Xmax;
            konverzijaY = (Double)Y_Razdaljina_Piksel / Ymax;

            brPodeljakaX = Convert.ToInt32(Xmax / 5);
            brPodeljakaY = Convert.ToInt32(Ymax / 10);

            podeljakX = Convert.ToInt32(X_Razdaljina_Piksel) / brPodeljakaX;
            podeljakY = Convert.ToInt32(Y_Razdaljina_Piksel) / brPodeljakaY;

            IscrtajGrafik();

            #region boje na dugmicima sa znakom pitanja

            if (provera(FormaDesniGlavni.FT1, FormaDesniGlavni.FT2, FormaDesniGlavni.FT3, FormaDesniGlavni.FT2_1, FormaDesniGlavni.FT2_2, FormaDesniGlavni.FT2_3))
                button_FTx1.ForeColor = button_FTx1.FlatAppearance.BorderColor = Color.Red;
            else
                button_FTx1.ForeColor = button_FTx1.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaDesniGlavni.FT1x2, FormaDesniGlavni.FT2x2, FormaDesniGlavni.FT3x2, FormaDesniGlavni.FT2_1x2, FormaDesniGlavni.FT2_2x2, FormaDesniGlavni.FT2_3x2))
                button_FTx2.ForeColor = button_FTx2.FlatAppearance.BorderColor = Color.Red;
            else
                button_FTx2.ForeColor = button_FTx2.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaDesniGlavni.FT1x3, FormaDesniGlavni.FT2x3, FormaDesniGlavni.FT3x3, FormaDesniGlavni.FT2_1x3, FormaDesniGlavni.FT2_2x3, FormaDesniGlavni.FT2_3x3))
                button_FTx3.ForeColor = button_FTx3.FlatAppearance.BorderColor = Color.Red;
            else
                button_FTx3.ForeColor = button_FTx3.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaDesniGlavni.FT1x4, FormaDesniGlavni.FT2x4, FormaDesniGlavni.FT3x4, FormaDesniGlavni.FT2_1x4, FormaDesniGlavni.FT2_2x4, FormaDesniGlavni.FT2_3x4))
                button_FTx4.ForeColor = button_FTx4.FlatAppearance.BorderColor = Color.Red;
            else
                button_FTx4.ForeColor = button_FTx4.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaDesniGlavni.FK1, FormaDesniGlavni.FK2, FormaDesniGlavni.FK3, FormaDesniGlavni.FK2_1, FormaDesniGlavni.FK2_2, FormaDesniGlavni.FK2_3))
                button_FKx1.ForeColor = button_FKx1.FlatAppearance.BorderColor = Color.Red;
            else
                button_FKx1.ForeColor = button_FKx1.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaDesniGlavni.FK1x2, FormaDesniGlavni.FK2x2, FormaDesniGlavni.FK3x2, FormaDesniGlavni.FK2_1x2, FormaDesniGlavni.FK2_2x2, FormaDesniGlavni.FK2_3x2))
                button_FKx2.ForeColor = button_FKx2.FlatAppearance.BorderColor = Color.Red;
            else
                button_FKx2.ForeColor = button_FKx2.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaDesniGlavni.FK1x3, FormaDesniGlavni.FK2x3, FormaDesniGlavni.FK3x3, FormaDesniGlavni.FK2_1x3, FormaDesniGlavni.FK2_2x3, FormaDesniGlavni.FK2_3x3))
                button_FKx3.ForeColor = button_FKx3.FlatAppearance.BorderColor = Color.Red;
            else
                button_FKx3.ForeColor = button_FKx3.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaDesniGlavni.FK1x4, FormaDesniGlavni.FK2x4, FormaDesniGlavni.FK3x4, FormaDesniGlavni.FK2_1x4, FormaDesniGlavni.FK2_2x4, FormaDesniGlavni.FK2_3x4))
                button_FKx4.ForeColor = button_FKx4.FlatAppearance.BorderColor = Color.Red;
            else
                button_FKx4.ForeColor = button_FKx4.FlatAppearance.BorderColor = Color.Black;

            #endregion
        }

        private void IscrtajGrafik()
        {
            g.Clear(Color.White);
            // g.DrawImage(Properties.Resources.placeholder, panel1.Width / 2 - Properties.Resources.placeholder.Width / 2, panel1.Height / 2 - Properties.Resources.placeholder.Height / 2);

            g.DrawString(FormaDesniGlavni.FormaHomeScreen.jezik[176], osaFont, cetkaL1, centarX + 30, 0);
            g.DrawString(FormaDesniGlavni.FormaHomeScreen.jezik[177], osaFont, cetkaL2, centarX + 30, 15);
            g.DrawString(FormaDesniGlavni.FormaHomeScreen.jezik[178], osaFont, cetkaL3, centarX + 30, 30);
            g.DrawString(FormaDesniGlavni.FormaHomeScreen.jezik[179], osaFont, cetkaL4, centarX + 30, 45);
            g.DrawString(FormaDesniGlavni.FormaHomeScreen.jezik[180], osaFont, cetkaL5, centarX + 30, 60);
            g.DrawString(FormaDesniGlavni.FormaHomeScreen.jezik[181], osaFont, cetkaL6, centarX + 30, 75);
            g.DrawString(FormaDesniGlavni.FormaHomeScreen.jezik[182], osaFont, cetkaL7, centarX + 30, 90);
            g.DrawString(FormaDesniGlavni.FormaHomeScreen.jezik[183], osaFont, cetkaL8, centarX + 30, 105);

            g.DrawLine(p, 0, centarY, panel1.Width, centarY);  // iscrtaj x-osu
            g.DrawLine(p, centarX, 0, centarX, panel1.Height); // iscrtaj y-osu

            // iscrtaj strelicu na x-osi
            g.DrawLine(p, panel1.Width, centarY, panel1.Width - 5, centarY - 5);
            g.DrawLine(p, panel1.Width, centarY, panel1.Width - 5, centarY + 5);
            g.DrawString("km/h", osaFont, cetka, panel1.Width - 30, panel1.Height - 55);

            // iscrtaj strelicu na y-osi
            g.DrawLine(p, centarX, 0, centarX - 5, 5);
            g.DrawLine(p, centarX, 0, centarX + 5, 5);
            g.DrawString("Hz", osaFont, cetka, centarX + 6, 0);

            // x-brojaci
            j = 5;
            for (i = centarX + podeljakX; i < panel1.Width; i += podeljakX)
            {
                g.DrawLine(p, i, centarY - 5, i, centarY + 5);
                g.DrawString(j.ToString(), font, cetka, i - 15, centarY + 7);
                j += 5;
            }

            // y-brojaci
            j = 10;
            for (i = centarY - podeljakY; i > 0; i -= podeljakY)
            {
                g.DrawLine(p, centarX - 5, i, centarX + 5, i);
                g.DrawString(j.ToString(), font, cetka, 0, i - 7);
                j += 10;
            }

            if (FormaDesniGlavni.v1unet)
            {
                if (FormaDesniGlavni.F11 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaDesniGlavni.V1 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaDesniGlavni.F11 * konverzijaY) - 16));
                if (FormaDesniGlavni.F12 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaDesniGlavni.V1 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaDesniGlavni.F12 * konverzijaY) - 16));
                if (FormaDesniGlavni.F13 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaDesniGlavni.V1 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaDesniGlavni.F13 * konverzijaY) - 16));
            }

            if (FormaDesniGlavni.v2unet)
            {
                if (FormaDesniGlavni.F21 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaDesniGlavni.V2 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaDesniGlavni.F21 * konverzijaY) - 16));
                if (FormaDesniGlavni.F22 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaDesniGlavni.V2 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaDesniGlavni.F22 * konverzijaY) - 16));
                if (FormaDesniGlavni.F23 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaDesniGlavni.V2 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaDesniGlavni.F23 * konverzijaY) - 16));
            }

            if (FormaDesniGlavni.v3unet)
            {
                if (FormaDesniGlavni.F31 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaDesniGlavni.V3 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaDesniGlavni.F31 * konverzijaY) - 16));
                if (FormaDesniGlavni.F32 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaDesniGlavni.V3 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaDesniGlavni.F32 * konverzijaY) - 16));
                if (FormaDesniGlavni.F33 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaDesniGlavni.V3 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaDesniGlavni.F33 * konverzijaY) - 16));
            }

            #region checkboxovi

            if (checkBox_L1.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FT1;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FT2;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FT3;

                g.DrawLine(p_L1, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L2.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FT1x2;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FT2x2;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FT3x2;

                g.DrawLine(p_L2, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L3.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FT1x3;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FT2x3;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FT3x3;

                g.DrawLine(p_L3, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L4.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FT1x4;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FT2x4;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FT3x4;

                g.DrawLine(p_L4, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L5.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FK1;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FK2;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FK3;

                g.DrawLine(p_L5, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L6.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FK1x2;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FK2x2;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FK3x2;

                g.DrawLine(p_L6, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L7.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FK1x3;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FK2x3;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FK3x3;

                g.DrawLine(p_L7, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L8.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FK1x4;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FK2x4;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FK3x4;

                g.DrawLine(p_L8, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            #endregion

            #region checkboxovi 2 electric boogaloo

            if (checkBox_L21.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FT2_1;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FT2_2;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FT2_3;

                g.DrawLine(p_L21, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L22.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FT2_1x2;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FT2_2x2;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FT2_3x2;

                g.DrawLine(p_L22, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L23.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FT2_1x3;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FT2_2x3;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FT2_3x3;

                g.DrawLine(p_L23, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L24.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FT2_1x4;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FT2_2x4;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FT2_3x4;

                g.DrawLine(p_L24, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L25.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FK2_1;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FK2_2;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FK2_3;

                g.DrawLine(p_L25, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L26.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FK2_1x2;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FK2_2x2;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FK2_3x2;

                g.DrawLine(p_L26, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L27.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FK2_1x3;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FK2_2x3;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FK2_3x3;

                g.DrawLine(p_L27, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L28.Checked)
            {
                if      (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V1) y = FormaDesniGlavni.FK2_1x4;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V2) y = FormaDesniGlavni.FK2_2x4;
                else if (V_Niz[V_Niz.Length - 1] == FormaDesniGlavni.V3) y = FormaDesniGlavni.FK2_3x4;

                g.DrawLine(p_L28, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            #endregion
        }

        private void PozoviIscrtajGrafik(object sender, EventArgs e)
        {
            IscrtajGrafik();
        }

        #region dugmici sa znakom pitanja

        private Boolean provera(Double arg1, Double arg2, Double arg3, Double arg1alt, Double arg2alt, Double arg3alt)
        {
            return ((FormaDesniGlavni.v1unet && ((FormaDesniGlavni.F11 != 0 && (arg1 >= (FormaDesniGlavni.F11 - 1) && arg1 <= (FormaDesniGlavni.F11 + 1))) ||
                                                 (FormaDesniGlavni.F12 != 0 && (arg1 >= (FormaDesniGlavni.F12 - 1) && arg1 <= (FormaDesniGlavni.F12 + 1))) ||
                                                 (FormaDesniGlavni.F13 != 0 && (arg1 >= (FormaDesniGlavni.F13 - 1) && arg1 <= (FormaDesniGlavni.F13 + 1))))) ||

                    (FormaDesniGlavni.v2unet && ((FormaDesniGlavni.F21 != 0 && (arg2 >= (FormaDesniGlavni.F21 - 1) && arg2 <= (FormaDesniGlavni.F21 + 1))) ||
                                                 (FormaDesniGlavni.F22 != 0 && (arg2 >= (FormaDesniGlavni.F22 - 1) && arg2 <= (FormaDesniGlavni.F22 + 1))) ||
                                                 (FormaDesniGlavni.F23 != 0 && (arg2 >= (FormaDesniGlavni.F23 - 1) && arg2 <= (FormaDesniGlavni.F23 + 1))))) ||

                    (FormaDesniGlavni.v3unet && ((FormaDesniGlavni.F31 != 0 && (arg3 >= (FormaDesniGlavni.F31 - 1) && arg3 <= (FormaDesniGlavni.F31 + 1))) ||
                                                 (FormaDesniGlavni.F32 != 0 && (arg3 >= (FormaDesniGlavni.F32 - 1) && arg3 <= (FormaDesniGlavni.F32 + 1))) ||
                                                 (FormaDesniGlavni.F33 != 0 && (arg3 >= (FormaDesniGlavni.F33 - 1) && arg3 <= (FormaDesniGlavni.F33 + 1))))) ||
                (FormaDesniGlavni.checkBox1Checked &&
                    (FormaDesniGlavni.v1unet && ((FormaDesniGlavni.F11 != 0 && (arg1alt >= (FormaDesniGlavni.F11 - 1) && arg1alt <= (FormaDesniGlavni.F11 + 1))) ||
                                                 (FormaDesniGlavni.F12 != 0 && (arg1alt >= (FormaDesniGlavni.F12 - 1) && arg1alt <= (FormaDesniGlavni.F12 + 1))) ||
                                                 (FormaDesniGlavni.F13 != 0 && (arg1alt >= (FormaDesniGlavni.F13 - 1) && arg1alt <= (FormaDesniGlavni.F13 + 1))))) ||

                    (FormaDesniGlavni.v2unet && ((FormaDesniGlavni.F21 != 0 && (arg2alt >= (FormaDesniGlavni.F21 - 1) && arg2alt <= (FormaDesniGlavni.F21 + 1))) ||
                                                 (FormaDesniGlavni.F22 != 0 && (arg2alt >= (FormaDesniGlavni.F22 - 1) && arg2alt <= (FormaDesniGlavni.F22 + 1))) ||
                                                 (FormaDesniGlavni.F23 != 0 && (arg2alt >= (FormaDesniGlavni.F23 - 1) && arg2alt <= (FormaDesniGlavni.F23 + 1))))) ||

                    (FormaDesniGlavni.v3unet && ((FormaDesniGlavni.F31 != 0 && (arg3alt >= (FormaDesniGlavni.F31 - 1) && arg3alt <= (FormaDesniGlavni.F31 + 1))) ||
                                                 (FormaDesniGlavni.F32 != 0 && (arg3alt >= (FormaDesniGlavni.F32 - 1) && arg3alt <= (FormaDesniGlavni.F32 + 1))) ||
                                                 (FormaDesniGlavni.F33 != 0 && (arg3alt >= (FormaDesniGlavni.F33 - 1) && arg3alt <= (FormaDesniGlavni.F33 + 1)))))
                ));
        }

        private void button_FTx1_Click(object sender, EventArgs e)
        {
            if (provera(FormaDesniGlavni.FT1, FormaDesniGlavni.FT2, FormaDesniGlavni.FT3, FormaDesniGlavni.FT2_1, FormaDesniGlavni.FT2_2, FormaDesniGlavni.FT2_3))
                MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[152]);
            else MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[153]);
        }

        private void button_FTx2_Click(object sender, EventArgs e)
        {
            if (provera(FormaDesniGlavni.FT1x2, FormaDesniGlavni.FT2x2, FormaDesniGlavni.FT3x2, FormaDesniGlavni.FT2_1x2, FormaDesniGlavni.FT2_2x2, FormaDesniGlavni.FT2_3x2))
                MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[154]);
            else MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[155]);
        }

        private void button_FTx3_Click(object sender, EventArgs e)
        {
            if (provera(FormaDesniGlavni.FT1x3, FormaDesniGlavni.FT2x3, FormaDesniGlavni.FT3x3, FormaDesniGlavni.FT2_1x3, FormaDesniGlavni.FT2_2x3, FormaDesniGlavni.FT2_3x3))
                MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[156]);
            else MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[157]);
        }

        private void button_FTx4_Click(object sender, EventArgs e)
        {
            if (provera(FormaDesniGlavni.FT1x4, FormaDesniGlavni.FT2x4, FormaDesniGlavni.FT3x4, FormaDesniGlavni.FT2_1x4, FormaDesniGlavni.FT2_2x4, FormaDesniGlavni.FT2_3x4))
                MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[158]);
            else MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[159]);
        }

        private void button_FKx1_Click(object sender, EventArgs e)
        {
            if (provera(FormaDesniGlavni.FK1, FormaDesniGlavni.FK2, FormaDesniGlavni.FK3, FormaDesniGlavni.FK2_1, FormaDesniGlavni.FK2_2, FormaDesniGlavni.FK2_3))
                MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[160]);
            else MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[161]);
        }

        private void button_FKx2_Click(object sender, EventArgs e)
        {
            if (provera(FormaDesniGlavni.FK1x2, FormaDesniGlavni.FK2x2, FormaDesniGlavni.FK3x2, FormaDesniGlavni.FK2_1x2, FormaDesniGlavni.FK2_2x2, FormaDesniGlavni.FK2_3x2))
                MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[162]);
            else MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[163]);
        }

        private void button_FKx3_Click(object sender, EventArgs e)
        {
            if (provera(FormaDesniGlavni.FK1x3, FormaDesniGlavni.FK2x3, FormaDesniGlavni.FK3x3, FormaDesniGlavni.FK2_1x3, FormaDesniGlavni.FK2_2x3, FormaDesniGlavni.FK2_3x3))
                MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[164]);
            else MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[165]);
        }

        private void button_FKx4_Click(object sender, EventArgs e)
        {
            if (provera(FormaDesniGlavni.FK1x4, FormaDesniGlavni.FK2x4, FormaDesniGlavni.FK3x4, FormaDesniGlavni.FK2_1x4, FormaDesniGlavni.FK2_2x4, FormaDesniGlavni.FK2_3x4))
                MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[166]);
            else MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[167]);
        }

        #endregion
    }
}
