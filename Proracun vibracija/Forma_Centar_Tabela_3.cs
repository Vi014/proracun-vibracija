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
    public partial class Forma_Centar_Tabela_3 : Form
    {
        public Forma_Centar_Tabela_2 FormaCentarTabela2;

        public Forma_Centar_Tabela_3(Forma_Centar_Tabela_2 konstruktor)
        {
            InitializeComponent();
            FormaCentarTabela2 = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text   = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[41];
            label1.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[42];
            label2.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[43];
            label3.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[44];
            label4.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[45];
            label5.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[46];
            label6.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[47];
            label7.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[48];
            label8.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[49];
            label9.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[50];
        }

        private void Forma_Centar_Tabela_3_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(FormaCentarTabela2.Left + 20, FormaCentarTabela2.Top + 20);

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

            Matematika();
        }

        private void Forma_Centar_Tabela_3_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaCentarTabela2.FormaCentarTabela3 = null;
        }

        Double  D11, D21, D31, D41, D51, D61,
                D12, D22, D32, D42, D52, D62,
                D13, D23, D33, D43, D53, D63;

        public void Matematika()
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
            if (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.rpm1unet)
            {
                //////////////////////////////////////////////////////////
                textBox_RPM1.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM1.ToString();
                if (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 != 0) textBox_F11.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11.ToString();
                if (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 != 0) textBox_F12.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12.ToString();
                if (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 != 0) textBox_F13.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13.ToString();
                //////////////////////////////////////////////////////////
                if (FormaCentarTabela2.D1 != 0)
                {
                    D11 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM1 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D1);
                    D11 = Math.Round(D11, 1, MidpointRounding.AwayFromZero);
                    textBox_D11.Text = D11.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 != 0 && D11 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 - 1) && D11 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 != 0 && D11 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 - 1) && D11 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 != 0 && D11 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 - 1) && D11 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 + 1)))
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
                if (FormaCentarTabela2.D2 != 0)
                {
                    D21 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM1 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D2);
                    D21 = Math.Round(D21, 1, MidpointRounding.AwayFromZero);
                    textBox_D21.Text = D21.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 != 0 && D21 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 - 1) && D21 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 != 0 && D21 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 - 1) && D21 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 != 0 && D21 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 - 1) && D21 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 + 1)))
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
                if (FormaCentarTabela2.D3 != 0)
                {
                    D31 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM1 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D3);
                    D31 = Math.Round(D31, 1, MidpointRounding.AwayFromZero);
                    textBox_D31.Text = D31.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 != 0 && D31 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 - 1) && D31 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 != 0 && D31 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 - 1) && D31 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 != 0 && D31 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 - 1) && D31 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 + 1)))
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
                if (FormaCentarTabela2.D4 != 0)
                {
                    D41 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM1 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D4);
                    D41 = Math.Round(D41, 1, MidpointRounding.AwayFromZero);
                    textBox_D41.Text = D41.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 != 0 && D41 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 - 1) && D41 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 != 0 && D41 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 - 1) && D41 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 != 0 && D41 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 - 1) && D41 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 + 1)))
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
                if (FormaCentarTabela2.D5 != 0)
                {
                    D51 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM1 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D5);
                    D51 = Math.Round(D51, 1, MidpointRounding.AwayFromZero);
                    textBox_D51.Text = D51.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 != 0 && D51 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 - 1) && D51 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 != 0 && D51 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 - 1) && D51 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 != 0 && D51 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 - 1) && D51 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 + 1)))
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
                if (FormaCentarTabela2.D6 != 0)
                {
                    D61 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM1 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D6);
                    D61 = Math.Round(D61, 1, MidpointRounding.AwayFromZero);
                    textBox_D61.Text = D61.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 != 0 && D61 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 - 1) && D61 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F11 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 != 0 && D61 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 - 1) && D61 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F12 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 != 0 && D61 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 - 1) && D61 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F13 + 1)))
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

            if (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.rpm2unet)
            {
                //////////////////////////////////////////////////////////
                textBox_RPM2.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM2.ToString();
                if (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 != 0) textBox_F21.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21.ToString();
                if (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 != 0) textBox_F22.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22.ToString();
                if (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 != 0) textBox_F23.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23.ToString();
                //////////////////////////////////////////////////////////
                if (FormaCentarTabela2.D1 != 0)
                {
                    D12 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM2 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D1);
                    D12 = Math.Round(D12, 1, MidpointRounding.AwayFromZero);
                    textBox_D12.Text = D12.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 != 0 && D12 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 - 1) && D12 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 != 0 && D12 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 - 1) && D12 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 != 0 && D12 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 - 1) && D12 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 + 1)))
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
                if (FormaCentarTabela2.D2 != 0)
                {
                    D22 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM2 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D2);
                    D22 = Math.Round(D22, 1, MidpointRounding.AwayFromZero);
                    textBox_D22.Text = D22.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 != 0 && D22 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 - 1) && D22 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 != 0 && D22 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 - 1) && D22 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 != 0 && D22 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 - 1) && D22 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 + 1)))
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
                if (FormaCentarTabela2.D3 != 0)
                {
                    D32 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM2 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D3);
                    D32 = Math.Round(D32, 1, MidpointRounding.AwayFromZero);
                    textBox_D32.Text = D32.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 != 0 && D32 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 - 1) && D32 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 != 0 && D32 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 - 1) && D32 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 != 0 && D32 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 - 1) && D32 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 + 1)))
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
                if (FormaCentarTabela2.D4 != 0)
                {
                    D42 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM2 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D4);
                    D42 = Math.Round(D42, 1, MidpointRounding.AwayFromZero);
                    textBox_D42.Text = D42.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 != 0 && D42 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 - 1) && D42 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 != 0 && D42 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 - 1) && D42 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 != 0 && D42 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 - 1) && D42 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 + 1)))
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
                if (FormaCentarTabela2.D5 != 0)
                {
                    D52 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM2 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D5);
                    D52 = Math.Round(D52, 1, MidpointRounding.AwayFromZero);
                    textBox_D52.Text = D52.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 != 0 && D52 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 - 1) && D52 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 != 0 && D52 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 - 1) && D52 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 != 0 && D52 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 - 1) && D52 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 + 1)))
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
                if (FormaCentarTabela2.D6 != 0)
                {
                    D62 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM2 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D6);
                    D62 = Math.Round(D62, 1, MidpointRounding.AwayFromZero);
                    textBox_D62.Text = D62.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 != 0 && D62 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 - 1) && D62 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F21 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 != 0 && D62 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 - 1) && D62 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F22 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 != 0 && D62 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 - 1) && D62 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F23 + 1)))
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

            if (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.rpm3unet)
            {
                //////////////////////////////////////////////////////////
                textBox_RPM3.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM3.ToString();
                if (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 != 0) textBox_F31.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31.ToString();
                if (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 != 0) textBox_F32.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32.ToString();
                if (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 != 0) textBox_F33.Text = FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33.ToString();
                //////////////////////////////////////////////////////////
                if (FormaCentarTabela2.D1 != 0)
                {
                    D13 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM3 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D1);
                    D13 = Math.Round(D13, 1, MidpointRounding.AwayFromZero);
                    textBox_D13.Text = D13.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 != 0 && D13 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 - 1) && D13 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 != 0 && D13 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 - 1) && D13 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 != 0 && D13 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 - 1) && D13 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 + 1)))
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
                if (FormaCentarTabela2.D2 != 0)
                {
                    D23 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM3 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D2);
                    D23 = Math.Round(D23, 1, MidpointRounding.AwayFromZero);
                    textBox_D23.Text = D23.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 != 0 && D23 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 - 1) && D23 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 != 0 && D23 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 - 1) && D23 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 != 0 && D23 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 - 1) && D23 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 + 1)))
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
                if (FormaCentarTabela2.D3 != 0)
                {
                    D33 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM3 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D3);
                    D33 = Math.Round(D33, 1, MidpointRounding.AwayFromZero);
                    textBox_D33.Text = D33.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 != 0 && D33 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 - 1) && D33 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 != 0 && D33 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 - 1) && D33 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 != 0 && D33 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 - 1) && D33 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 + 1)))
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
                if (FormaCentarTabela2.D4 != 0)
                {
                    D43 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM3 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D4);
                    D43 = Math.Round(D43, 1, MidpointRounding.AwayFromZero);
                    textBox_D43.Text = D43.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 != 0 && D43 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 - 1) && D43 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 != 0 && D43 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 - 1) && D43 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 != 0 && D43 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 - 1) && D43 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 + 1)))
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
                if (FormaCentarTabela2.D5 != 0)
                {
                    D53 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM3 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D5);
                    D53 = Math.Round(D53, 1, MidpointRounding.AwayFromZero);
                    textBox_D53.Text = D53.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 != 0 && D53 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 - 1) && D53 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 != 0 && D53 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 - 1) && D53 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 != 0 && D53 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 - 1) && D53 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 + 1)))
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
                if (FormaCentarTabela2.D6 != 0)
                {
                    D63 = (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.RPM3 / 60) * (FormaCentarTabela2.DR / FormaCentarTabela2.D6);
                    D63 = Math.Round(D63, 1, MidpointRounding.AwayFromZero);
                    textBox_D63.Text = D63.ToString();
                    if ((FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 != 0 && D63 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 - 1) && D63 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F31 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 != 0 && D63 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 - 1) && D63 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F32 + 1)) ||
                        (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 != 0 && D63 >= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 - 1) && D63 <= (FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.F33 + 1)))
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
            MessageBox.Show(FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[51]);
        }

        private void button_D2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[52]);
        }

        private void button_D3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[53]);
        }

        private void button_D4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[54]);
        }

        private void button_D5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[55]);
        }

        private void button_D6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarTabela2.FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[56]);
        }

        #endregion
    }
}
