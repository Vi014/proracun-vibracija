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
    public partial class Forma_Centar_Agregat_Tabela : Form
    {
        public Forma_Centar_Agregat_Glavni FormaCentarAgregatGlavni;
        public Forma_Centar_Tekst FormaCentarTekst;

        public Forma_Centar_Agregat_Tabela(Forma_Centar_Agregat_Glavni konstruktor)
        {
            InitializeComponent();
            FormaCentarAgregatGlavni = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text   = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[69];
            label1.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[70];
            label2.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[71];
            label3.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[72];
            label4.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[73];
            label5.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[74];
            label6.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[75];
            label7.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[76];
            label8.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[77];
            label9.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[78];
        }

        private void Forma_Centar_Agregat_Tabela_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(FormaCentarAgregatGlavni.Left + 20, FormaCentarAgregatGlavni.Top + 20);

            #region text box sranja

            textBox_RPM1.BackColor = textBox_RPM1.BackColor;
            textBox_RPM1.ForeColor = Color.Gray;
            textBox_RPM2.BackColor = textBox_RPM2.BackColor;
            textBox_RPM2.ForeColor = Color.Gray;
            textBox_RPM3.BackColor = textBox_RPM3.BackColor;
            textBox_RPM3.ForeColor = Color.Gray;

            textBox_F11.BackColor = textBox_F11.BackColor;
            textBox_F11.ForeColor = Color.Gray;
            textBox_F12.BackColor = textBox_F12.BackColor;
            textBox_F12.ForeColor = Color.Gray;
            textBox_F13.BackColor = textBox_F13.BackColor;
            textBox_F13.ForeColor = Color.Gray;

            textBox_F21.BackColor = textBox_F21.BackColor;
            textBox_F21.ForeColor = Color.Gray;
            textBox_F22.BackColor = textBox_F22.BackColor;
            textBox_F22.ForeColor = Color.Gray;
            textBox_F23.BackColor = textBox_F23.BackColor;
            textBox_F23.ForeColor = Color.Gray;

            textBox_F31.BackColor = textBox_F31.BackColor;
            textBox_F31.ForeColor = Color.Gray;
            textBox_F32.BackColor = textBox_F32.BackColor;
            textBox_F32.ForeColor = Color.Gray;
            textBox_F33.BackColor = textBox_F33.BackColor;
            textBox_F33.ForeColor = Color.Gray;

            #endregion

            IspisVrednosti();
        }

        private void Forma_Centar_Agregat_Tabela_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaCentarAgregatGlavni.FormaCentarAgregatTabela = null;
            FormaCentarAgregatGlavni.buttonTabelaEnabled      = true;
        }

        public void IspisVrednosti()
        {
            
            textBox_RPM1.Text    = textBox_RPM2.Text = textBox_RPM3.Text =
                textBox_D11.Text = textBox_D12.Text  = textBox_D13.Text  =
                textBox_D21.Text = textBox_D22.Text  = textBox_D23.Text  =
                textBox_D31.Text = textBox_D32.Text  = textBox_D33.Text  =
                textBox_D41.Text = textBox_D42.Text  = textBox_D43.Text  =
                textBox_D51.Text = textBox_D52.Text  = textBox_D53.Text  =
                textBox_D61.Text = textBox_D62.Text  = textBox_D63.Text  =
                textBox_F11.Text = textBox_F12.Text  = textBox_F13.Text  =
                textBox_F21.Text = textBox_F22.Text  = textBox_F23.Text  =
                textBox_F31.Text = textBox_F32.Text  = textBox_F33.Text  = "";

            button_D1.Visible     = button_D1.Enabled =
                button_D2.Visible = button_D2.Enabled =
                button_D3.Visible = button_D3.Enabled =
                button_D4.Visible = button_D4.Enabled =
                button_D5.Visible = button_D5.Enabled =
                button_D6.Visible = button_D6.Enabled = false;

            #region rpm1unet
            if (FormaCentarAgregatGlavni.FormaCentarGlavni.rpm1unet)
            {
                //////////////////////////////////////////////////////////
                textBox_RPM1.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.RPM1.ToString();
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 != 0) textBox_F11.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.F11.ToString();
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 != 0) textBox_F12.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.F12.ToString();
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 != 0) textBox_F13.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.F13.ToString();
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D1 != 0)
                {
                    textBox_D11.Text = FormaCentarAgregatGlavni.D11.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F11 != 0 && FormaCentarAgregatGlavni.D11 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 - 1) && FormaCentarAgregatGlavni.D11 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 != 0 && FormaCentarAgregatGlavni.D11 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 - 1) && FormaCentarAgregatGlavni.D11 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 != 0 && FormaCentarAgregatGlavni.D11 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 - 1) && FormaCentarAgregatGlavni.D11 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 + 1)))
                    {
                        button_D1.Visible = button_D1.Enabled = true;
                        textBox_D11.BackColor = textBox_D11.BackColor;
                        textBox_D11.ForeColor = Color.Red;
                    }
                    else
                    {
                        button_D1.Visible = button_D1.Enabled = false;
                        textBox_D11.BackColor = textBox_D11.BackColor;
                        textBox_D11.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D2 != 0)
                {
                    textBox_D21.Text = FormaCentarAgregatGlavni.D21.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F11 != 0 && FormaCentarAgregatGlavni.D21 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 - 1) && FormaCentarAgregatGlavni.D21 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 != 0 && FormaCentarAgregatGlavni.D21 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 - 1) && FormaCentarAgregatGlavni.D21 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 != 0 && FormaCentarAgregatGlavni.D21 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 - 1) && FormaCentarAgregatGlavni.D21 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 + 1)))
                    {
                        button_D2.Visible = button_D2.Enabled = true;
                        textBox_D21.BackColor = textBox_D21.BackColor;
                        textBox_D21.ForeColor = Color.Red;
                    }
                    else
                    {
                        button_D2.Visible = button_D2.Enabled = false;
                        textBox_D21.BackColor = textBox_D21.BackColor;
                        textBox_D21.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D3 != 0)
                {
                    textBox_D31.Text = FormaCentarAgregatGlavni.D31.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F11 != 0 && FormaCentarAgregatGlavni.D31 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 - 1) && FormaCentarAgregatGlavni.D31 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 != 0 && FormaCentarAgregatGlavni.D31 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 - 1) && FormaCentarAgregatGlavni.D31 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 != 0 && FormaCentarAgregatGlavni.D31 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 - 1) && FormaCentarAgregatGlavni.D31 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 + 1)))
                    {
                        button_D3.Visible = button_D3.Enabled = true;
                        textBox_D31.BackColor = textBox_D31.BackColor;
                        textBox_D31.ForeColor = Color.Red;
                    }
                    else
                    {
                        button_D3.Visible = button_D3.Enabled = false;
                        textBox_D31.BackColor = textBox_D31.BackColor;
                        textBox_D31.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D4 != 0)
                {
                    textBox_D41.Text = FormaCentarAgregatGlavni.D41.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F11 != 0 && FormaCentarAgregatGlavni.D41 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 - 1) && FormaCentarAgregatGlavni.D41 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 != 0 && FormaCentarAgregatGlavni.D41 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 - 1) && FormaCentarAgregatGlavni.D41 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 != 0 && FormaCentarAgregatGlavni.D41 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 - 1) && FormaCentarAgregatGlavni.D41 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 + 1)))
                    {
                        button_D4.Visible = button_D4.Enabled = true;
                        textBox_D41.BackColor = textBox_D41.BackColor;
                        textBox_D41.ForeColor = Color.Red;
                    }
                    else
                    {
                        button_D4.Visible = button_D4.Enabled = false;
                        textBox_D41.BackColor = textBox_D41.BackColor;
                        textBox_D41.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D5 != 0)
                {
                    textBox_D51.Text = FormaCentarAgregatGlavni.D51.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F11 != 0 && FormaCentarAgregatGlavni.D51 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 - 1) && FormaCentarAgregatGlavni.D51 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 != 0 && FormaCentarAgregatGlavni.D51 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 - 1) && FormaCentarAgregatGlavni.D51 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 != 0 && FormaCentarAgregatGlavni.D51 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 - 1) && FormaCentarAgregatGlavni.D51 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 + 1)))
                    {
                        button_D5.Visible = button_D5.Enabled = true;
                        textBox_D51.BackColor = textBox_D51.BackColor;
                        textBox_D51.ForeColor = Color.Red;
                    }
                    else
                    {
                        button_D5.Visible = button_D5.Enabled = false;
                        textBox_D51.BackColor = textBox_D51.BackColor;
                        textBox_D51.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D6 != 0)
                {
                    textBox_D61.Text = FormaCentarAgregatGlavni.D61.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F11 != 0 && FormaCentarAgregatGlavni.D61 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 - 1) && FormaCentarAgregatGlavni.D61 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F11 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 != 0 && FormaCentarAgregatGlavni.D61 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 - 1) && FormaCentarAgregatGlavni.D61 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F12 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 != 0 && FormaCentarAgregatGlavni.D61 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 - 1) && FormaCentarAgregatGlavni.D61 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F13 + 1)))
                    {
                        button_D6.Visible = button_D6.Enabled = true;
                        textBox_D61.BackColor = textBox_D61.BackColor;
                        textBox_D61.ForeColor = Color.Red;
                    }
                    else
                    {
                        button_D6.Visible = button_D6.Enabled = false;
                        textBox_D61.BackColor = textBox_D61.BackColor;
                        textBox_D61.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
            }

            #endregion

            #region rpm2unet

            if (FormaCentarAgregatGlavni.FormaCentarGlavni.rpm2unet)
            {
                //////////////////////////////////////////////////////////
                textBox_RPM2.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.RPM2.ToString();
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 != 0) textBox_F21.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.F21.ToString();
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 != 0) textBox_F22.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.F22.ToString();
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 != 0) textBox_F23.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.F23.ToString();
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D1 != 0)
                {
                    textBox_D12.Text = FormaCentarAgregatGlavni.D12.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F21 != 0 && FormaCentarAgregatGlavni.D12 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 - 1) && FormaCentarAgregatGlavni.D12 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 != 0 && FormaCentarAgregatGlavni.D12 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 - 1) && FormaCentarAgregatGlavni.D12 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 != 0 && FormaCentarAgregatGlavni.D12 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 - 1) && FormaCentarAgregatGlavni.D12 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 + 1)))
                    {
                        button_D1.Visible = button_D1.Enabled = true;
                        textBox_D12.BackColor = textBox_D12.BackColor;
                        textBox_D12.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_D12.BackColor = textBox_D12.BackColor;
                        textBox_D12.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D2 != 0)
                {
                    textBox_D22.Text = FormaCentarAgregatGlavni.D22.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F21 != 0 && FormaCentarAgregatGlavni.D22 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 - 1) && FormaCentarAgregatGlavni.D22 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 != 0 && FormaCentarAgregatGlavni.D22 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 - 1) && FormaCentarAgregatGlavni.D22 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 != 0 && FormaCentarAgregatGlavni.D22 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 - 1) && FormaCentarAgregatGlavni.D22 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 + 1)))
                    {
                        button_D2.Visible = button_D2.Enabled = true;
                        textBox_D22.BackColor = textBox_D22.BackColor;
                        textBox_D22.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_D22.BackColor = textBox_D22.BackColor;
                        textBox_D22.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D3 != 0)
                {
                    textBox_D32.Text = FormaCentarAgregatGlavni.D32.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F21 != 0 && FormaCentarAgregatGlavni.D32 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 - 1) && FormaCentarAgregatGlavni.D32 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 != 0 && FormaCentarAgregatGlavni.D32 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 - 1) && FormaCentarAgregatGlavni.D32 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 != 0 && FormaCentarAgregatGlavni.D32 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 - 1) && FormaCentarAgregatGlavni.D32 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 + 1)))
                    {
                        button_D3.Visible = button_D3.Enabled = true;
                        textBox_D32.BackColor = textBox_D32.BackColor;
                        textBox_D32.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_D32.BackColor = textBox_D32.BackColor;
                        textBox_D32.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D4 != 0)
                {
                    textBox_D42.Text = FormaCentarAgregatGlavni.D42.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F21 != 0 && FormaCentarAgregatGlavni.D42 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 - 1) && FormaCentarAgregatGlavni.D42 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 != 0 && FormaCentarAgregatGlavni.D42 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 - 1) && FormaCentarAgregatGlavni.D42 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 != 0 && FormaCentarAgregatGlavni.D42 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 - 1) && FormaCentarAgregatGlavni.D42 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 + 1)))
                    {
                        button_D4.Visible = button_D4.Enabled = true;
                        textBox_D42.BackColor = textBox_D42.BackColor;
                        textBox_D42.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_D42.BackColor = textBox_D42.BackColor;
                        textBox_D42.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D5 != 0)
                {
                    textBox_D52.Text = FormaCentarAgregatGlavni.D52.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F21 != 0 && FormaCentarAgregatGlavni.D52 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 - 1) && FormaCentarAgregatGlavni.D52 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 != 0 && FormaCentarAgregatGlavni.D52 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 - 1) && FormaCentarAgregatGlavni.D52 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 != 0 && FormaCentarAgregatGlavni.D52 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 - 1) && FormaCentarAgregatGlavni.D52 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 + 1)))
                    {
                        button_D5.Visible = button_D5.Enabled = true;
                        textBox_D52.BackColor = textBox_D52.BackColor;
                        textBox_D52.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_D52.BackColor = textBox_D52.BackColor;
                        textBox_D52.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D6 != 0)
                {
                    textBox_D62.Text = FormaCentarAgregatGlavni.D62.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F21 != 0 && FormaCentarAgregatGlavni.D62 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 - 1) && FormaCentarAgregatGlavni.D62 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F21 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 != 0 && FormaCentarAgregatGlavni.D62 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 - 1) && FormaCentarAgregatGlavni.D62 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F22 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 != 0 && FormaCentarAgregatGlavni.D62 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 - 1) && FormaCentarAgregatGlavni.D62 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F23 + 1)))
                    {
                        button_D6.Visible = button_D6.Enabled = true;
                        textBox_D62.BackColor = textBox_D62.BackColor;
                        textBox_D62.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_D62.BackColor = textBox_D62.BackColor;
                        textBox_D62.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
            }

            #endregion

            #region rpm3unet

            if (FormaCentarAgregatGlavni.FormaCentarGlavni.rpm3unet)
            {
                //////////////////////////////////////////////////////////
                textBox_RPM3.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.RPM3.ToString();
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 != 0) textBox_F31.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.F31.ToString();
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 != 0) textBox_F32.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.F32.ToString();
                if (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 != 0) textBox_F33.Text = FormaCentarAgregatGlavni.FormaCentarGlavni.F33.ToString();
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D1 != 0)
                {
                    textBox_D13.Text = FormaCentarAgregatGlavni.D13.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F31 != 0 && FormaCentarAgregatGlavni.D13 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 - 1) && FormaCentarAgregatGlavni.D13 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 != 0 && FormaCentarAgregatGlavni.D13 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 - 1) && FormaCentarAgregatGlavni.D13 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 != 0 && FormaCentarAgregatGlavni.D13 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 - 1) && FormaCentarAgregatGlavni.D13 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 + 1)))
                    {
                        button_D1.Visible = button_D1.Enabled = true;
                        textBox_D13.BackColor = textBox_D13.BackColor;
                        textBox_D13.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_D13.BackColor = textBox_D13.BackColor;
                        textBox_D13.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D2 != 0)
                {
                    textBox_D23.Text = FormaCentarAgregatGlavni.D23.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F31 != 0 && FormaCentarAgregatGlavni.D23 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 - 1) && FormaCentarAgregatGlavni.D23 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 != 0 && FormaCentarAgregatGlavni.D23 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 - 1) && FormaCentarAgregatGlavni.D23 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 != 0 && FormaCentarAgregatGlavni.D23 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 - 1) && FormaCentarAgregatGlavni.D23 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 + 1)))
                    {
                        button_D2.Visible = button_D2.Enabled = true;
                        textBox_D23.BackColor = textBox_D23.BackColor;
                        textBox_D23.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_D23.BackColor = textBox_D23.BackColor;
                        textBox_D23.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D3 != 0)
                {
                    textBox_D33.Text = FormaCentarAgregatGlavni.D33.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F31 != 0 && FormaCentarAgregatGlavni.D33 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 - 1) && FormaCentarAgregatGlavni.D33 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 != 0 && FormaCentarAgregatGlavni.D33 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 - 1) && FormaCentarAgregatGlavni.D33 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 != 0 && FormaCentarAgregatGlavni.D33 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 - 1) && FormaCentarAgregatGlavni.D33 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 + 1)))
                    {
                        button_D3.Visible = button_D3.Enabled = true;
                        textBox_D33.BackColor = textBox_D33.BackColor;
                        textBox_D33.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_D33.BackColor = textBox_D33.BackColor;
                        textBox_D33.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D4 != 0)
                {
                    textBox_D43.Text = FormaCentarAgregatGlavni.D43.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F31 != 0 && FormaCentarAgregatGlavni.D43 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 - 1) && FormaCentarAgregatGlavni.D43 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 != 0 && FormaCentarAgregatGlavni.D43 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 - 1) && FormaCentarAgregatGlavni.D43 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 != 0 && FormaCentarAgregatGlavni.D43 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 - 1) && FormaCentarAgregatGlavni.D43 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 + 1)))
                    {
                        button_D4.Visible = button_D4.Enabled = true;
                        textBox_D43.BackColor = textBox_D43.BackColor;
                        textBox_D43.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_D43.BackColor = textBox_D43.BackColor;
                        textBox_D43.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D5 != 0)
                {
                    textBox_D53.Text = FormaCentarAgregatGlavni.D53.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F31 != 0 && FormaCentarAgregatGlavni.D53 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 - 1) && FormaCentarAgregatGlavni.D53 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 != 0 && FormaCentarAgregatGlavni.D53 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 - 1) && FormaCentarAgregatGlavni.D53 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 != 0 && FormaCentarAgregatGlavni.D53 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 - 1) && FormaCentarAgregatGlavni.D53 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 + 1)))
                    {
                        button_D5.Visible = button_D5.Enabled = true;
                        textBox_D53.BackColor = textBox_D53.BackColor;
                        textBox_D53.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_D53.BackColor = textBox_D53.BackColor;
                        textBox_D53.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
                if (FormaCentarAgregatGlavni.D6 != 0)
                {
                    textBox_D63.Text = FormaCentarAgregatGlavni.D63.ToString();
                    if ((FormaCentarAgregatGlavni.FormaCentarGlavni.F31 != 0 && FormaCentarAgregatGlavni.D63 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 - 1) && FormaCentarAgregatGlavni.D63 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F31 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 != 0 && FormaCentarAgregatGlavni.D63 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 - 1) && FormaCentarAgregatGlavni.D63 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F32 + 1)) ||
                        (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 != 0 && FormaCentarAgregatGlavni.D63 >= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 - 1) && FormaCentarAgregatGlavni.D63 <= (FormaCentarAgregatGlavni.FormaCentarGlavni.F33 + 1)))
                    {
                        button_D6.Visible = button_D6.Enabled = true;
                        textBox_D63.BackColor = textBox_D63.BackColor;
                        textBox_D63.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_D63.BackColor = textBox_D63.BackColor;
                        textBox_D63.ForeColor = Color.Gray;
                    }
                }
                //////////////////////////////////////////////////////////
            }

            #endregion
        }

        #region dugmici sa znakom pitanja

        private void button_D1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[79]);
        }

        private void button_D2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[80]);
        }

        private void button_D3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[81]);
        }

        private void button_D4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[82]);
        }

        private void button_D5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[83]);
        }

        private void button_D6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[84]);
        }

        #endregion
    }
}
