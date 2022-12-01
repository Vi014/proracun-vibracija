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
    public partial class Forma_Centar_Agregat_Grafik : Form
    {
        public Forma_Centar_Agregat_Glavni FormaCentarAgregatGlavni;

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

        public Forma_Centar_Agregat_Grafik(Forma_Centar_Agregat_Glavni konstruktor)
        {
            InitializeComponent();
            FormaCentarAgregatGlavni = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text        = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[85];
            button1.Text     = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[86];
            label1.Text      = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[87];
            checkBox_L1.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[100];
            checkBox_L2.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[101];
            checkBox_L3.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[102];
            checkBox_L4.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[103];
            checkBox_L5.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[104];
            checkBox_L6.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[105];

            IscrtajGrafik();
        }

        private void Forma_Centar_Agregat_Grafik_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

            g = panel1.CreateGraphics();

            centarX = 30;
            centarY = panel1.Height - 30;
        }

        private void Forma_Centar_Agregat_Grafik_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaCentarAgregatGlavni.FormaCentarAgregatGrafik = null;
            FormaCentarAgregatGlavni.buttonGrafikEnabled      = true;
        }

        private void Forma_Centar_Agregat_Grafik_Shown(object sender, EventArgs e)
        {
            Racun();
            PromenaJezika();
        }

        public void Racun()
        {
            checkBox_L1.Enabled     = button_D1.Enabled =
                checkBox_L2.Enabled = button_D2.Enabled =
                checkBox_L3.Enabled = button_D3.Enabled =
                checkBox_L4.Enabled = button_D4.Enabled =
                checkBox_L5.Enabled = button_D5.Enabled =
                checkBox_L6.Enabled = button_D6.Enabled = 
                checkBox_L1.Checked = checkBox_L2.Checked = checkBox_L3.Checked = checkBox_L4.Checked = checkBox_L5.Checked = checkBox_L6.Checked = false;

            if (FormaCentarAgregatGlavni.D1 != 0) checkBox_L1.Enabled = button_D1.Enabled = true;
            if (FormaCentarAgregatGlavni.D2 != 0) checkBox_L2.Enabled = button_D2.Enabled = true;
            if (FormaCentarAgregatGlavni.D3 != 0) checkBox_L3.Enabled = button_D3.Enabled = true;
            if (FormaCentarAgregatGlavni.D4 != 0) checkBox_L4.Enabled = button_D4.Enabled = true;
            if (FormaCentarAgregatGlavni.D5 != 0) checkBox_L5.Enabled = button_D5.Enabled = true;
            if (FormaCentarAgregatGlavni.D6 != 0) checkBox_L6.Enabled = button_D6.Enabled = true;

            RPM_Stek.Clear();
            Frekvencije_Stek.Clear();

            if (FormaCentarAgregatGlavni.FormaCentarGlavni.rpm1unet)
            {
                RPM_Stek.Push(FormaCentarAgregatGlavni.FormaCentarGlavni.RPM1);
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.FormaCentarGlavni.F11);
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.FormaCentarGlavni.F12);
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.FormaCentarGlavni.F13);

                if (FormaCentarAgregatGlavni.D1 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D11);
                if (FormaCentarAgregatGlavni.D2 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D21);
                if (FormaCentarAgregatGlavni.D3 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D31);
                if (FormaCentarAgregatGlavni.D4 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D41);
                if (FormaCentarAgregatGlavni.D5 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D51);
                if (FormaCentarAgregatGlavni.D6 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D61);
            }
            if (FormaCentarAgregatGlavni.FormaCentarGlavni.rpm2unet)
            {
                RPM_Stek.Push(FormaCentarAgregatGlavni.FormaCentarGlavni.RPM2);
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.FormaCentarGlavni.F21);
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.FormaCentarGlavni.F22);
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.FormaCentarGlavni.F23);

                if (FormaCentarAgregatGlavni.D1 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D12);
                if (FormaCentarAgregatGlavni.D2 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D22);
                if (FormaCentarAgregatGlavni.D3 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D32);
                if (FormaCentarAgregatGlavni.D4 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D42);
                if (FormaCentarAgregatGlavni.D5 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D52);
                if (FormaCentarAgregatGlavni.D6 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D62);
            }
            if (FormaCentarAgregatGlavni.FormaCentarGlavni.rpm3unet)
            {
                RPM_Stek.Push(FormaCentarAgregatGlavni.FormaCentarGlavni.RPM3);
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.FormaCentarGlavni.F31);
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.FormaCentarGlavni.F32);
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.FormaCentarGlavni.F33);

                if (FormaCentarAgregatGlavni.D1 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D13);
                if (FormaCentarAgregatGlavni.D2 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D23);
                if (FormaCentarAgregatGlavni.D3 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D33);
                if (FormaCentarAgregatGlavni.D4 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D43);
                if (FormaCentarAgregatGlavni.D5 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D53);
                if (FormaCentarAgregatGlavni.D6 != 0) Frekvencije_Stek.Push(FormaCentarAgregatGlavni.D63);
            }

            RPM_Niz = RPM_Stek.ToArray();
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

            if (provera(FormaCentarAgregatGlavni.D11, FormaCentarAgregatGlavni.D12, FormaCentarAgregatGlavni.D13))
                button_D1.ForeColor = button_D1.FlatAppearance.BorderColor = Color.Red;
            else
                button_D1.ForeColor = button_D1.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaCentarAgregatGlavni.D21, FormaCentarAgregatGlavni.D22, FormaCentarAgregatGlavni.D23))
                button_D2.ForeColor = button_D2.FlatAppearance.BorderColor = Color.Red;
            else
                button_D2.ForeColor = button_D2.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaCentarAgregatGlavni.D31, FormaCentarAgregatGlavni.D32, FormaCentarAgregatGlavni.D33))
                button_D3.ForeColor = button_D3.FlatAppearance.BorderColor = Color.Red;
            else
                button_D3.ForeColor = button_D3.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaCentarAgregatGlavni.D41, FormaCentarAgregatGlavni.D42, FormaCentarAgregatGlavni.D43))
                button_D4.ForeColor = button_D4.FlatAppearance.BorderColor = Color.Red;
            else
                button_D4.ForeColor = button_D4.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaCentarAgregatGlavni.D51, FormaCentarAgregatGlavni.D52, FormaCentarAgregatGlavni.D53))
                button_D5.ForeColor = button_D5.FlatAppearance.BorderColor = Color.Red;
            else
                button_D5.ForeColor = button_D5.FlatAppearance.BorderColor = Color.Black;

            if (provera(FormaCentarAgregatGlavni.D61, FormaCentarAgregatGlavni.D62, FormaCentarAgregatGlavni.D63))
                button_D6.ForeColor = button_D6.FlatAppearance.BorderColor = Color.Red;
            else
                button_D6.ForeColor = button_D6.FlatAppearance.BorderColor = Color.Black;

            #endregion
        }

        private void IscrtajGrafik()
        {
            g.Clear(Color.White);
            // g.DrawImage(Properties.Resources.placeholder, panel1.Width / 2 - Properties.Resources.placeholder.Width / 2, panel1.Height / 2 - Properties.Resources.placeholder.Height / 2);

            g.DrawString(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[106], osaFont, cetkaL1, centarX + 30, 0);
            g.DrawString(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[107], osaFont, cetkaL2, centarX + 30, 15);
            g.DrawString(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[108], osaFont, cetkaL3, centarX + 30, 30);
            g.DrawString(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[109], osaFont, cetkaL4, centarX + 30, 45);
            g.DrawString(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[110], osaFont, cetkaL5, centarX + 30, 60);
            g.DrawString(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[111], osaFont, cetkaL6, centarX + 30, 75);

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

            if (FormaCentarAgregatGlavni.FormaCentarGlavni.rpm1unet)
            {
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.RPM1 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.F11 * konverzijaY) - 16));
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.RPM1 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.F12 * konverzijaY) - 16));
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.RPM1 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.F13 * konverzijaY) - 16));
            }

            if (FormaCentarAgregatGlavni.FormaCentarGlavni.rpm2unet)
            {
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.RPM2 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.F21 * konverzijaY) - 16));
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.RPM2 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.F22 * konverzijaY) - 16));
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.RPM2 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.F23 * konverzijaY) - 16));
            }

            if (FormaCentarAgregatGlavni.FormaCentarGlavni.rpm3unet)
            {
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.RPM3 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.F31 * konverzijaY) - 16));
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.RPM3 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.F32 * konverzijaY) - 16));
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 != 0) g.DrawString("●", fontX, cetkaError, (centarX + Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.RPM3 * konverzijaX) - 18), (centarY - Convert.ToInt32(FormaCentarAgregatGlavni.FormaCentarGlavni.F33 * konverzijaY) - 16));
            }

            #region checkboxovi

            if (checkBox_L1.Checked)
            {
                if      (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM1) y = FormaCentarAgregatGlavni.D11;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM2) y = FormaCentarAgregatGlavni.D12;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM3) y = FormaCentarAgregatGlavni.D13;

                g.DrawLine(p_L1, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L2.Checked)
            {
                if      (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM1) y = FormaCentarAgregatGlavni.D21;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM2) y = FormaCentarAgregatGlavni.D22;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM3) y = FormaCentarAgregatGlavni.D23;

                g.DrawLine(p_L2, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L3.Checked)
            {
                if      (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM1) y = FormaCentarAgregatGlavni.D31;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM2) y = FormaCentarAgregatGlavni.D32;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM3) y = FormaCentarAgregatGlavni.D33;

                g.DrawLine(p_L3, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L4.Checked)
            {
                if      (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM1) y = FormaCentarAgregatGlavni.D41;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM2) y = FormaCentarAgregatGlavni.D42;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM3) y = FormaCentarAgregatGlavni.D43;

                g.DrawLine(p_L4, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L5.Checked)
            {
                if      (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM1) y = FormaCentarAgregatGlavni.D51;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM2) y = FormaCentarAgregatGlavni.D52;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM3) y = FormaCentarAgregatGlavni.D53;

                g.DrawLine(p_L5, centarX, centarY, (centarX + Convert.ToInt32(Xmax * konverzijaX)), (centarY - Convert.ToInt32(y * konverzijaY)));
            }

            if (checkBox_L6.Checked)
            {
                if      (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM1) y = FormaCentarAgregatGlavni.D61;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM2) y = FormaCentarAgregatGlavni.D62;
                else if (RPM_Niz[RPM_Niz.Length - 1] == FormaCentarAgregatGlavni.FormaCentarGlavni.RPM3) y = FormaCentarAgregatGlavni.D63;

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
            return ((FormaCentarAgregatGlavni.FormaCentarGlavni.rpm1unet && ((FormaCentarAgregatGlavni.FormaCentarGlavni.F11 != 0 && (arg1 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 - 1) && arg1 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 + 1))) ||
                                                                             (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 != 0 && (arg1 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 - 1) && arg1 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 + 1))) ||
                                                                             (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 != 0 && (arg1 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 - 1) && arg1 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 + 1))))) ||

                    (FormaCentarAgregatGlavni.FormaCentarGlavni.rpm2unet && ((FormaCentarAgregatGlavni.FormaCentarGlavni.F21 != 0 && (arg2 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 - 1) && arg2 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 + 1))) ||
                                                                             (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 != 0 && (arg2 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 - 1) && arg2 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 + 1))) ||
                                                                             (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 != 0 && (arg2 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 - 1) && arg2 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 + 1))))) ||

                    (FormaCentarAgregatGlavni.FormaCentarGlavni.rpm3unet && ((FormaCentarAgregatGlavni.FormaCentarGlavni.F31 != 0 && (arg3 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 - 1) && arg3 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 + 1))) ||
                                                                             (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 != 0 && (arg3 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 - 1) && arg3 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 + 1))) ||
                                                                             (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 != 0 && (arg3 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 - 1) && arg3 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 + 1))))));
        }

        private void otvoriTekst()
        {
            if(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaCentarTekst == null)
            {
                FormaCentarAgregatGlavni.FormaCentarGlavni.FormaCentarTekst = new Forma_Centar_Tekst(FormaCentarAgregatGlavni.FormaCentarGlavni);
                FormaCentarAgregatGlavni.FormaCentarGlavni.FormaCentarTekst.Owner = FormaCentarAgregatGlavni.FormaCentarGlavni;
                FormaCentarAgregatGlavni.FormaCentarGlavni.FormaCentarTekst.Show();

                FormaCentarAgregatGlavni.FormaCentarGlavni.FormaCentarTekst.PanelScrollPos = new Point(0, FormaCentarAgregatGlavni.FormaCentarGlavni.FormaCentarTekst.EngineAccessoryVibrations);
            }
            else
            {
                FormaCentarAgregatGlavni.FormaCentarGlavni.FormaCentarTekst.PanelScrollPos = new Point(0, FormaCentarAgregatGlavni.FormaCentarGlavni.FormaCentarTekst.EngineAccessoryVibrations);
                FormaCentarAgregatGlavni.FormaCentarGlavni.FormaCentarTekst.WindowState = FormWindowState.Normal;
                FormaCentarAgregatGlavni.FormaCentarGlavni.FormaCentarTekst.Focus();
            }
        }

        private void button_D1_Click(object sender, EventArgs e)
        {
            if (provera(FormaCentarAgregatGlavni.D11, FormaCentarAgregatGlavni.D12, FormaCentarAgregatGlavni.D13))
                otvoriTekst();
            else MessageBox.Show(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[89]);
        }

        private void button_D2_Click(object sender, EventArgs e)
        {
            if (provera(FormaCentarAgregatGlavni.D21, FormaCentarAgregatGlavni.D22, FormaCentarAgregatGlavni.D23))
                otvoriTekst();
            else MessageBox.Show(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[91]);
        }

        private void button_D3_Click(object sender, EventArgs e)
        {
            if (provera(FormaCentarAgregatGlavni.D31, FormaCentarAgregatGlavni.D32, FormaCentarAgregatGlavni.D33))
                otvoriTekst();
            else MessageBox.Show(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[93]);
        }

        private void button_D4_Click(object sender, EventArgs e)
        {
            if (provera(FormaCentarAgregatGlavni.D41, FormaCentarAgregatGlavni.D42, FormaCentarAgregatGlavni.D43))
                otvoriTekst();
            else MessageBox.Show(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[95]);
        }

        private void button_D5_Click(object sender, EventArgs e)
        {
            if (provera(FormaCentarAgregatGlavni.D51, FormaCentarAgregatGlavni.D52, FormaCentarAgregatGlavni.D53))
                otvoriTekst();
            else MessageBox.Show(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[97]);
        }

        private void button_D6_Click(object sender, EventArgs e)
        {
            if (provera(FormaCentarAgregatGlavni.D61, FormaCentarAgregatGlavni.D62, FormaCentarAgregatGlavni.D63))
                otvoriTekst();
            else MessageBox.Show(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[99]);
        }

        #endregion
    }
}