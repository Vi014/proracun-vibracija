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
    public partial class Forma_Centar_Grafik : Form
    {
        public Forma_Centar_Glavni FormaCentarGlavni;

        Graphics g;
        Pen p = new Pen(Color.Black, 2);

        Pen p_L1 = new Pen(Color.Blue,          2);
        Pen p_L2 = new Pen(Color.DarkGoldenrod, 2);
        Pen p_L3 = new Pen(Color.Green,         2);
        Pen p_L4 = new Pen(Color.Orange,        2);
        Pen p_L5 = new Pen(Color.Purple,        2);
        Pen p_L6 = new Pen(Color.Black,         2);

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
 
        Stack<Double> RPM_Stek         = new Stack<Double>();
        Stack<Double> Frekvencije_Stek = new Stack<Double>();
        Double[] RPM_Niz, Frekvencije_Niz;

        Int32 i, j;
        Int32 brPodeljakaX, brPodeljakaY, podeljakX, podeljakY;
        Int32 centarX, centarY;

        Double pom;
        Double Xmax, Ymax;
        Double X_Razdaljina_Piksel, Y_Razdaljina_Piksel;
        Double konverzijaX, konverzijaY;

        Double y;

        public Forma_Centar_Grafik(Forma_Centar_Glavni konstruktor)
        {
            InitializeComponent();
            FormaCentarGlavni = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text        = FormaCentarGlavni.FormaHomeScreen.jezik[30];
            button1.Text     = FormaCentarGlavni.FormaHomeScreen.jezik[31];
            label1.Text      = FormaCentarGlavni.FormaHomeScreen.jezik[32];
            checkBox_L1.Text = FormaCentarGlavni.FormaHomeScreen.jezik[45];
            checkBox_L2.Text = FormaCentarGlavni.FormaHomeScreen.jezik[46];
            checkBox_L3.Text = FormaCentarGlavni.FormaHomeScreen.jezik[47];
            checkBox_L4.Text = FormaCentarGlavni.FormaHomeScreen.jezik[48];
            checkBox_L5.Text = FormaCentarGlavni.FormaHomeScreen.jezik[49];
            checkBox_L6.Text = FormaCentarGlavni.FormaHomeScreen.jezik[50];

            IscrtajGrafik();
        }

        private void Forma_Centar_Grafik_1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

            g = panel1.CreateGraphics();

            centarX = 30;
            centarY = panel1.Height - 30;
        }

        private void Forma_Centar_Grafik_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaCentarGlavni.FormaCentarGrafik   = null;
            FormaCentarGlavni.buttonGrafikEnabled = true;
        }

        private void Forma_Centar_Grafik_1_Shown(object sender, EventArgs e)
        {
            Racun();
            PromenaJezika();
        }

        public void Racun()
        {
            checkBox_L1.Checked = checkBox_L2.Checked = checkBox_L3.Checked = checkBox_L4.Checked = checkBox_L5.Checked = checkBox_L6.Checked = false;

            RPM_Stek.Clear();
            Frekvencije_Stek.Clear();

            if (FormaCentarGlavni.rpm1unet)
            {
                RPM_Stek.Push(FormaCentarGlavni.RPM1);
                if (FormaCentarGlavni.F11 != 0) Frekvencije_Stek.Push(FormaCentarGlavni.F11);
                if (FormaCentarGlavni.F12 != 0) Frekvencije_Stek.Push(FormaCentarGlavni.F12);
                if (FormaCentarGlavni.F13 != 0) Frekvencije_Stek.Push(FormaCentarGlavni.F13);
                Frekvencije_Stek.Push(FormaCentarGlavni.FM1);
                Frekvencije_Stek.Push(FormaCentarGlavni.FM12);
                Frekvencije_Stek.Push(FormaCentarGlavni.FM13);
                Frekvencije_Stek.Push(FormaCentarGlavni.FM14);
                Frekvencije_Stek.Push(FormaCentarGlavni.FB1);
                Frekvencije_Stek.Push(FormaCentarGlavni.FP1);
            }
            if (FormaCentarGlavni.rpm2unet)
            {
                RPM_Stek.Push(FormaCentarGlavni.RPM2);
                if (FormaCentarGlavni.F21 != 0) Frekvencije_Stek.Push(FormaCentarGlavni.F21);
                if (FormaCentarGlavni.F22 != 0) Frekvencije_Stek.Push(FormaCentarGlavni.F22);
                if (FormaCentarGlavni.F23 != 0) Frekvencije_Stek.Push(FormaCentarGlavni.F23);
                Frekvencije_Stek.Push(FormaCentarGlavni.FM2);
                Frekvencije_Stek.Push(FormaCentarGlavni.FM22);
                Frekvencije_Stek.Push(FormaCentarGlavni.FM23);
                Frekvencije_Stek.Push(FormaCentarGlavni.FM24);
                Frekvencije_Stek.Push(FormaCentarGlavni.FB2);
                Frekvencije_Stek.Push(FormaCentarGlavni.FP2);
            }
            if (FormaCentarGlavni.rpm3unet)
            {
                RPM_Stek.Push(FormaCentarGlavni.RPM3);
                if (FormaCentarGlavni.F31 != 0) Frekvencije_Stek.Push(FormaCentarGlavni.F31);
                if (FormaCentarGlavni.F32 != 0) Frekvencije_Stek.Push(FormaCentarGlavni.F32);
                if (FormaCentarGlavni.F33 != 0) Frekvencije_Stek.Push(FormaCentarGlavni.F33);
                Frekvencije_Stek.Push(FormaCentarGlavni.FM3);
                Frekvencije_Stek.Push(FormaCentarGlavni.FM32);
                Frekvencije_Stek.Push(FormaCentarGlavni.FM33);
                Frekvencije_Stek.Push(FormaCentarGlavni.FM34);
                Frekvencije_Stek.Push(FormaCentarGlavni.FB3);
                Frekvencije_Stek.Push(FormaCentarGlavni.FP3);
            }

            RPM_Niz         = RPM_Stek.ToArray();
            Frekvencije_Niz = Frekvencije_Stek.ToArray();

            #region sortiraj RPM_Niz
            for (i = 0; i < RPM_Niz.Length - 1; i++)
            {
                for (j = i + 1; j < RPM_Niz.Length; j++)
                {
                    if (RPM_Niz[i] > RPM_Niz[j])
                    {
                        pom = RPM_Niz[i];
                        RPM_Niz[i] = RPM_Niz[j];
                        RPM_Niz[j] = pom;
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

            //Xmax = RPM_Niz[RPM_Niz.Length - 1] + 200;
            Xmax = RPM_Niz[RPM_Niz.Length - 1];
            Ymax = Frekvencije_Niz[Frekvencije_Niz.Length - 1];

            X_Razdaljina_Piksel = panel1.Width - centarX;
            Y_Razdaljina_Piksel = centarY;

            konverzijaX = (Double)X_Razdaljina_Piksel / Xmax;
            konverzijaY = (Double)Y_Razdaljina_Piksel / Ymax;

            brPodeljakaX = Convert.ToInt32(Xmax / 100);
            if (Ymax >= 10)
            {
                brPodeljakaY = Convert.ToInt32(Ymax / 10);
            }
            else
            {
                brPodeljakaY = Convert.ToInt32(Ymax); // ovaj kod je tu da u slucaju da je Ymax ispod 10 se ne desi divide by zero greska na liniji gde se podeljakY racuna - evkivalenta nije potrebna za Xmax jer je na Forma_Centar_Glavni 100 minimum za RPM
                                                      // takodje je tu da jednostavno ulepsa grafik, u slucaju da nam je najveca frekvencija manja od 10 program bi normalno napravio samo jedan odeljak od 10; ovako ce napraviti vise odeljaka od po 1
            }

            podeljakX = Convert.ToInt32(X_Razdaljina_Piksel) / brPodeljakaX;
            podeljakY = Convert.ToInt32(Y_Razdaljina_Piksel) / brPodeljakaY;

            IscrtajGrafik();

            #region boje na dugmicima sa znakom pitanja

            if (provera(FormaCentarGlavni.FM1, FormaCentarGlavni.FM2, FormaCentarGlavni.FM3))
                button_FM.ForeColor = button_FM.FlatAppearance.BorderColor = Color.Red;
            else
                button_FM.ForeColor = button_FM.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaCentarGlavni.FM12, FormaCentarGlavni.FM22, FormaCentarGlavni.FM32))
                button_FM2.ForeColor = button_FM2.FlatAppearance.BorderColor = Color.Red;
            else
                button_FM2.ForeColor = button_FM2.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaCentarGlavni.FM13, FormaCentarGlavni.FM23, FormaCentarGlavni.FM33))
                button_FM3.ForeColor = button_FM3.FlatAppearance.BorderColor = Color.Red;
            else
                button_FM3.ForeColor = button_FM3.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaCentarGlavni.FM14, FormaCentarGlavni.FM24, FormaCentarGlavni.FM34))
                button_FM4.ForeColor = button_FM4.FlatAppearance.BorderColor = Color.Red;
            else
                button_FM4.ForeColor = button_FM4.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaCentarGlavni.FB1, FormaCentarGlavni.FB2, FormaCentarGlavni.FB3))
                button_FB.ForeColor = button_FB.FlatAppearance.BorderColor = Color.Red;
            else
                button_FB.ForeColor = button_FB.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaCentarGlavni.FP1, FormaCentarGlavni.FP2, FormaCentarGlavni.FP3))
                button_FP.ForeColor = button_FP.FlatAppearance.BorderColor = Color.Red;
            else
                button_FP.ForeColor = button_FP.FlatAppearance.BorderColor = Color.Black;

            #endregion
        }

        private void IscrtajGrafik()
        {
            g.Clear(Color.White);
            // g.DrawImage(Properties.Resources.placeholder, panel1.Width / 2 - Properties.Resources.placeholder.Width / 2, panel1.Height / 2 - Properties.Resources.placeholder.Height / 2);

            g.DrawString(FormaCentarGlavni.FormaHomeScreen.jezik[51], osaFont, cetkaL1, centarX + 30, 0);
            g.DrawString(FormaCentarGlavni.FormaHomeScreen.jezik[52], osaFont, cetkaL2, centarX + 30, 15);
            g.DrawString(FormaCentarGlavni.FormaHomeScreen.jezik[53], osaFont, cetkaL3, centarX + 30, 30);
            g.DrawString(FormaCentarGlavni.FormaHomeScreen.jezik[54], osaFont, cetkaL4, centarX + 30, 45);
            g.DrawString(FormaCentarGlavni.FormaHomeScreen.jezik[55], osaFont, cetkaL5, centarX + 30, 60);
            g.DrawString(FormaCentarGlavni.FormaHomeScreen.jezik[56], osaFont, cetkaL6, centarX + 30, 75);

            g.DrawLine(p, 0, centarY, panel1.Width, centarY);  // iscrtaj x-osu
            g.DrawLine(p, centarX, 0, centarX, panel1.Height); // iscrtaj y-osu

            // iscrtaj strelicu na x-osi
            g.DrawLine(p, panel1.Width, centarY, panel1.Width - 5, centarY - 5);
            g.DrawLine(p, panel1.Width, centarY, panel1.Width - 5, centarY + 5);
            g.DrawString("RPM", osaFont, cetka, panel1.Width - 30, panel1.Height - 55);

            // iscrtaj strelicu na y-osi
            g.DrawLine(p, centarX, 0, centarX - 5, 5);
            g.DrawLine(p, centarX, 0, centarX + 5, 5);
            g.DrawString("Hz", osaFont, cetka, centarX + 6, 0);

            // x-brojaci
            j = 100;
            for (i = centarX + podeljakX; i < panel1.Width; i += podeljakX)
            {
                g.DrawLine(p, i, centarY - 5, i, centarY + 5);
                g.DrawString(j.ToString(), font, cetka, i - 15, centarY + 7);
                j += 100;
            }

            // y-brojaci
            Int32 yOdeljak; // vrsimo proveru toga da li je najveca frekvencija manja od 10 ili nije, ako jeste, stavljamo odeljke od po 1, ako nije, stavljamo odeljke od po 10
            if (Ymax >= 10) yOdeljak = 10;
            else yOdeljak = 1;
            j = yOdeljak;
            for (i = centarY - podeljakY; i > 0; i -= podeljakY)
            {
                g.DrawLine(p, centarX - 5, i, centarX + 5, i);
                g.DrawString(j.ToString(), font, cetka, 0, i - 7);
                j += yOdeljak;
            }

            if (FormaCentarGlavni.rpm1unet)
            {
                if (FormaCentarGlavni.F11 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarGlavni.RPM1 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarGlavni.F11 * konverzijaY) - 16));
                if (FormaCentarGlavni.F12 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarGlavni.RPM1 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarGlavni.F12 * konverzijaY) - 16));
                if (FormaCentarGlavni.F13 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarGlavni.RPM1 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarGlavni.F13 * konverzijaY) - 16));
            }

            if (FormaCentarGlavni.rpm2unet)
            {
                if (FormaCentarGlavni.F21 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarGlavni.RPM2 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarGlavni.F21 * konverzijaY) - 16));
                if (FormaCentarGlavni.F22 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarGlavni.RPM2 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarGlavni.F22 * konverzijaY) - 16));
                if (FormaCentarGlavni.F23 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarGlavni.RPM2 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarGlavni.F23 * konverzijaY) - 16));
            }

            if (FormaCentarGlavni.rpm3unet)
            {
                if (FormaCentarGlavni.F31 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarGlavni.RPM3 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarGlavni.F31 * konverzijaY) - 16));
                if (FormaCentarGlavni.F32 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarGlavni.RPM3 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarGlavni.F32 * konverzijaY) - 16));
                if (FormaCentarGlavni.F33 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarGlavni.RPM3 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarGlavni.F33 * konverzijaY) - 16));
            }

            #region checkboxovi

            if (checkBox_L1.Checked)
            {
                if      (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM1) y = FormaCentarGlavni.FM1;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM2) y = FormaCentarGlavni.FM2;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM3) y = FormaCentarGlavni.FM3;

                g.DrawLine(p_L1, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L2.Checked)
            {
                if      (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM1) y = FormaCentarGlavni.FM12;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM2) y = FormaCentarGlavni.FM22;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM3) y = FormaCentarGlavni.FM32;

                g.DrawLine(p_L2, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L3.Checked)
            {
                if      (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM1) y = FormaCentarGlavni.FM13;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM2) y = FormaCentarGlavni.FM23;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM3) y = FormaCentarGlavni.FM33;

                g.DrawLine(p_L3, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L4.Checked)
            {
                if      (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM1) y = FormaCentarGlavni.FM14;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM2) y = FormaCentarGlavni.FM24;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM3) y = FormaCentarGlavni.FM34;

                g.DrawLine(p_L4, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L5.Checked)
            {
                if      (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM1) y = FormaCentarGlavni.FB1;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM2) y = FormaCentarGlavni.FB2;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM3) y = FormaCentarGlavni.FB3;

                g.DrawLine(p_L5, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L6.Checked)
            {
                if      (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM1) y = FormaCentarGlavni.FP1;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM2) y = FormaCentarGlavni.FP2;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarGlavni.RPM3) y = FormaCentarGlavni.FP3;

                g.DrawLine(p_L6, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            #endregion
        }

        private void PozoviIscrtajGrafik(object sender, EventArgs e)
        {
            IscrtajGrafik();
        }

        #region dugmici sa znakom pitanja

        private Boolean provera(Double arg1, Double arg2, Double arg3)
        {
            return ((FormaCentarGlavni.rpm1unet && ((FormaCentarGlavni.F11 != 0 && (arg1 >= (FormaCentarGlavni.F11 - 1) && arg1 <= (FormaCentarGlavni.F11 + 1))) ||
                                                    (FormaCentarGlavni.F12 != 0 && (arg1 >= (FormaCentarGlavni.F12 - 1) && arg1 <= (FormaCentarGlavni.F12 + 1))) ||
                                                    (FormaCentarGlavni.F13 != 0 && (arg1 >= (FormaCentarGlavni.F13 - 1) && arg1 <= (FormaCentarGlavni.F13 + 1))))) ||

                    (FormaCentarGlavni.rpm2unet && ((FormaCentarGlavni.F21 != 0 && (arg2 >= (FormaCentarGlavni.F21 - 1) && arg2 <= (FormaCentarGlavni.F21 + 1))) ||
                                                    (FormaCentarGlavni.F22 != 0 && (arg2 >= (FormaCentarGlavni.F22 - 1) && arg2 <= (FormaCentarGlavni.F22 + 1))) ||
                                                    (FormaCentarGlavni.F23 != 0 && (arg2 >= (FormaCentarGlavni.F23 - 1) && arg2 <= (FormaCentarGlavni.F23 + 1))))) ||

                    (FormaCentarGlavni.rpm3unet && ((FormaCentarGlavni.F31 != 0 && (arg3 >= (FormaCentarGlavni.F31 - 1) && arg3 <= (FormaCentarGlavni.F31 + 1))) ||
                                                    (FormaCentarGlavni.F32 != 0 && (arg3 >= (FormaCentarGlavni.F32 - 1) && arg3 <= (FormaCentarGlavni.F32 + 1))) ||
                                                    (FormaCentarGlavni.F33 != 0 && (arg3 >= (FormaCentarGlavni.F33 - 1) && arg3 <= (FormaCentarGlavni.F33 + 1))))));
        }

        private void otvoriTekst()
        {
            if (FormaCentarGlavni.FormaCentarTekst == null)
            {
                FormaCentarGlavni.FormaCentarTekst = new Forma_Centar_Tekst(FormaCentarGlavni);
                FormaCentarGlavni.FormaCentarTekst.Owner = FormaCentarGlavni;
                FormaCentarGlavni.FormaCentarTekst.Show();
            }
            else
            {
                FormaCentarGlavni.FormaCentarTekst.PanelScrollPos = new Point(0, 0);
                FormaCentarGlavni.FormaCentarTekst.WindowState = FormWindowState.Normal;
                FormaCentarGlavni.FormaCentarTekst.Focus();
            }
        }

        private void otvoriTekstAlt()
        {
            if (FormaCentarGlavni.FormaCentarTekst == null)
            {
                FormaCentarGlavni.FormaCentarTekst = new Forma_Centar_Tekst(FormaCentarGlavni);
                FormaCentarGlavni.FormaCentarTekst.Owner = FormaCentarGlavni;
                FormaCentarGlavni.FormaCentarTekst.Show();

                FormaCentarGlavni.FormaCentarTekst.PanelScrollPos = new Point(0, FormaCentarGlavni.FormaCentarTekst.EngineFiringFrequency);
            }
            else
            {
                FormaCentarGlavni.FormaCentarTekst.PanelScrollPos = new Point(0, FormaCentarGlavni.FormaCentarTekst.EngineFiringFrequency);
                FormaCentarGlavni.FormaCentarTekst.WindowState = FormWindowState.Normal;
                FormaCentarGlavni.FormaCentarTekst.Focus();
            }
        }

        private void button_FM_Click(object sender, EventArgs e)
        {
            if (provera(FormaCentarGlavni.FM1, FormaCentarGlavni.FM2, FormaCentarGlavni.FM3))
                otvoriTekst();
            else MessageBox.Show(FormaCentarGlavni.FormaHomeScreen.jezik[34]);
        }

        private void button_FM2_Click(object sender, EventArgs e)
        {
            if (provera(FormaCentarGlavni.FM12, FormaCentarGlavni.FM22, FormaCentarGlavni.FM32))
                otvoriTekst();
            else MessageBox.Show(FormaCentarGlavni.FormaHomeScreen.jezik[36]);
        }

        private void button_FM3_Click(object sender, EventArgs e)
        {
            if (provera(FormaCentarGlavni.FM13, FormaCentarGlavni.FM23, FormaCentarGlavni.FM33))
                otvoriTekst();
            else MessageBox.Show(FormaCentarGlavni.FormaHomeScreen.jezik[38]);
        }

        private void button_FM4_Click(object sender, EventArgs e)
        {
            if (provera(FormaCentarGlavni.FM14, FormaCentarGlavni.FM24, FormaCentarGlavni.FM34))
                otvoriTekst();
            else MessageBox.Show(FormaCentarGlavni.FormaHomeScreen.jezik[40]);
        }

        private void button_FB_Click(object sender, EventArgs e)
        {
            if (provera(FormaCentarGlavni.FB1, FormaCentarGlavni.FB2, FormaCentarGlavni.FB3))
                otvoriTekst();
            else MessageBox.Show(FormaCentarGlavni.FormaHomeScreen.jezik[42]);
        }

        private void button_FP_Click(object sender, EventArgs e)
        {
            if (provera(FormaCentarGlavni.FP1, FormaCentarGlavni.FP2, FormaCentarGlavni.FP3))
                otvoriTekstAlt();
            else MessageBox.Show(FormaCentarGlavni.FormaHomeScreen.jezik[44]);
        }

        #endregion
    }
}
