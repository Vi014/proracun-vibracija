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
    public partial class Forma_Centar_Tabela : Form
    {
#pragma warning disable IDE1006

        public Forma_Centar_Glavni FormaCentarGlavni;

        public Forma_Centar_Tabela(Forma_Centar_Glavni konstruktor)
        {
            InitializeComponent();
            FormaCentarGlavni = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text             = FormaCentarGlavni.FormaHomeScreen.Jezik[15];
            label_RPM.Text        = FormaCentarGlavni.FormaHomeScreen.Jezik[16];
            label_FrMotora.Text   = FormaCentarGlavni.FormaHomeScreen.Jezik[17];
            label_FrMotora2.Text  = FormaCentarGlavni.FormaHomeScreen.Jezik[18];
            label_FrMotora3.Text  = FormaCentarGlavni.FormaHomeScreen.Jezik[19];
            label_FrMotora4.Text  = FormaCentarGlavni.FormaHomeScreen.Jezik[20];
            label_FrBregaste.Text = FormaCentarGlavni.FormaHomeScreen.Jezik[21];
            label_FrPaljenja.Text = FormaCentarGlavni.FormaHomeScreen.Jezik[22];
            label_IzmFrek.Text    = FormaCentarGlavni.FormaHomeScreen.Jezik[23];
        }

        private void Forma_Centar_Tabela_1_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(FormaCentarGlavni.Left + 20, FormaCentarGlavni.Top + 20);

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

        private void Forma_Centar_Tabela_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaCentarGlavni.FormaCentarTabela = null;
            FormaCentarGlavni.ButtonTabelaEnabled = true;
        }

        public void IspisVrednosti()
        {
            textBox_RPM1.Text     = textBox_RPM2.Text = textBox_RPM3.Text =
                textBox_FM1.Text  = textBox_FM2.Text  = textBox_FM3.Text  =
                textBox_FM12.Text = textBox_FM22.Text = textBox_FM32.Text =
                textBox_FM13.Text = textBox_FM23.Text = textBox_FM33.Text =
                textBox_FM14.Text = textBox_FM24.Text = textBox_FM34.Text =
                textBox_FB1.Text  = textBox_FB2.Text  = textBox_FB3.Text  =
                textBox_FP1.Text  = textBox_FP2.Text  = textBox_FP3.Text  =
                textBox_F11.Text  = textBox_F12.Text  = textBox_F13.Text  =
                textBox_F21.Text  = textBox_F22.Text  = textBox_F23.Text  =
                textBox_F31.Text  = textBox_F32.Text  = textBox_F33.Text  = "";

            button_FM.Visible      = button_FM.Enabled  =
                button_FM2.Visible = button_FM2.Enabled =
                button_FM3.Visible = button_FM3.Enabled =
                button_FM4.Visible = button_FM4.Enabled =
                button_FB.Visible  = button_FB.Enabled  =
                button_FP.Visible  = button_FP.Enabled  = false;

            #region rpm1

            if (FormaCentarGlavni.RPM1Unet)
            {
                //////////////////////////////////////////////////////////
                textBox_RPM1.Text = FormaCentarGlavni.RPM1.ToString();
                if (FormaCentarGlavni.F11 != 0) textBox_F11.Text = FormaCentarGlavni.F11.ToString();
                if (FormaCentarGlavni.F12 != 0) textBox_F12.Text = FormaCentarGlavni.F12.ToString();
                if (FormaCentarGlavni.F13 != 0) textBox_F13.Text = FormaCentarGlavni.F13.ToString();
                //////////////////////////////////////////////////////////
                textBox_FM1.Text = FormaCentarGlavni.FM1.ToString();
                if ((FormaCentarGlavni.F11 != 0 && FormaCentarGlavni.FM1 >= (FormaCentarGlavni.F11 - 1) && FormaCentarGlavni.FM1 <= (FormaCentarGlavni.F11 + 1)) ||
                    (FormaCentarGlavni.F12 != 0 && FormaCentarGlavni.FM1 >= (FormaCentarGlavni.F12 - 1) && FormaCentarGlavni.FM1 <= (FormaCentarGlavni.F12 + 1)) ||
                    (FormaCentarGlavni.F13 != 0 && FormaCentarGlavni.FM1 >= (FormaCentarGlavni.F13 - 1) && FormaCentarGlavni.FM1 <= (FormaCentarGlavni.F13 + 1)))
                {
                    button_FM.Visible = button_FM.Enabled = true;
                    textBox_FM1.BackColor = textBox_FM1.BackColor;
                    textBox_FM1.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FM1.BackColor = textBox_FM1.BackColor;
                    textBox_FM1.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FM12.Text = FormaCentarGlavni.FM12.ToString();
                if ((FormaCentarGlavni.F11 != 0 && FormaCentarGlavni.FM12 >= (FormaCentarGlavni.F11 - 1) && FormaCentarGlavni.FM12 <= (FormaCentarGlavni.F11 + 1)) ||
                    (FormaCentarGlavni.F12 != 0 && FormaCentarGlavni.FM12 >= (FormaCentarGlavni.F12 - 1) && FormaCentarGlavni.FM12 <= (FormaCentarGlavni.F12 + 1)) ||
                    (FormaCentarGlavni.F13 != 0 && FormaCentarGlavni.FM12 >= (FormaCentarGlavni.F13 - 1) && FormaCentarGlavni.FM12 <= (FormaCentarGlavni.F13 + 1)))
                {
                    button_FM2.Visible = button_FM2.Enabled = true;
                    textBox_FM12.BackColor = textBox_FM12.BackColor;
                    textBox_FM12.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FM12.BackColor = textBox_FM12.BackColor;
                    textBox_FM12.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FM13.Text = FormaCentarGlavni.FM13.ToString();
                if ((FormaCentarGlavni.F11 != 0 && FormaCentarGlavni.FM13 >= (FormaCentarGlavni.F11 - 1) && FormaCentarGlavni.FM13 <= (FormaCentarGlavni.F11 + 1)) ||
                    (FormaCentarGlavni.F12 != 0 && FormaCentarGlavni.FM13 >= (FormaCentarGlavni.F12 - 1) && FormaCentarGlavni.FM13 <= (FormaCentarGlavni.F12 + 1)) ||
                    (FormaCentarGlavni.F13 != 0 && FormaCentarGlavni.FM13 >= (FormaCentarGlavni.F13 - 1) && FormaCentarGlavni.FM13 <= (FormaCentarGlavni.F13 + 1)))
                {
                    button_FM3.Visible = button_FM3.Enabled = true;
                    textBox_FM13.BackColor = textBox_FM13.BackColor;
                    textBox_FM13.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FM13.BackColor = textBox_FM13.BackColor;
                    textBox_FM13.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FM14.Text = FormaCentarGlavni.FM14.ToString();
                if ((FormaCentarGlavni.F11 != 0 && FormaCentarGlavni.FM14 >= (FormaCentarGlavni.F11 - 1) && FormaCentarGlavni.FM14 <= (FormaCentarGlavni.F11 + 1)) ||
                    (FormaCentarGlavni.F12 != 0 && FormaCentarGlavni.FM14 >= (FormaCentarGlavni.F12 - 1) && FormaCentarGlavni.FM14 <= (FormaCentarGlavni.F12 + 1)) ||
                    (FormaCentarGlavni.F13 != 0 && FormaCentarGlavni.FM14 >= (FormaCentarGlavni.F13 - 1) && FormaCentarGlavni.FM14 <= (FormaCentarGlavni.F13 + 1)))
                {
                    button_FM4.Visible = button_FM4.Enabled = true;
                    textBox_FM14.BackColor = textBox_FM14.BackColor;
                    textBox_FM14.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FM14.BackColor = textBox_FM14.BackColor;
                    textBox_FM14.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FB1.Text = FormaCentarGlavni.FB1.ToString();
                if ((FormaCentarGlavni.F11 != 0 && FormaCentarGlavni.FB1 >= (FormaCentarGlavni.F11 - 1) && FormaCentarGlavni.FB1 <= (FormaCentarGlavni.F11 + 1)) ||
                    (FormaCentarGlavni.F12 != 0 && FormaCentarGlavni.FB1 >= (FormaCentarGlavni.F12 - 1) && FormaCentarGlavni.FB1 <= (FormaCentarGlavni.F12 + 1)) ||
                    (FormaCentarGlavni.F13 != 0 && FormaCentarGlavni.FB1 >= (FormaCentarGlavni.F13 - 1) && FormaCentarGlavni.FB1 <= (FormaCentarGlavni.F13 + 1)))
                {
                    button_FB.Visible = button_FB.Enabled = true;
                    textBox_FB1.BackColor = textBox_FB1.BackColor;
                    textBox_FB1.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FB1.BackColor = textBox_FB1.BackColor;
                    textBox_FB1.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FP1.Text = FormaCentarGlavni.FP1.ToString();
                if ((FormaCentarGlavni.F11 != 0 && FormaCentarGlavni.FP1 >= (FormaCentarGlavni.F11 - 1) && FormaCentarGlavni.FP1 <= (FormaCentarGlavni.F11 + 1)) ||
                    (FormaCentarGlavni.F12 != 0 && FormaCentarGlavni.FP1 >= (FormaCentarGlavni.F12 - 1) && FormaCentarGlavni.FP1 <= (FormaCentarGlavni.F12 + 1)) ||
                    (FormaCentarGlavni.F13 != 0 && FormaCentarGlavni.FP1 >= (FormaCentarGlavni.F13 - 1) && FormaCentarGlavni.FP1 <= (FormaCentarGlavni.F13 + 1)))
                {
                    button_FP.Visible = button_FP.Enabled = true;
                    textBox_FP1.BackColor = textBox_FP1.BackColor;
                    textBox_FP1.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FP1.BackColor = textBox_FP1.BackColor;
                    textBox_FP1.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
            }

            #endregion

            #region rpm2

            if (FormaCentarGlavni.RPM2Unet)
            {
                //////////////////////////////////////////////////////////
                textBox_RPM2.Text = FormaCentarGlavni.RPM2.ToString();
                if (FormaCentarGlavni.F21 != 0) textBox_F21.Text = FormaCentarGlavni.F21.ToString();
                if (FormaCentarGlavni.F22 != 0) textBox_F22.Text = FormaCentarGlavni.F22.ToString();
                if (FormaCentarGlavni.F23 != 0) textBox_F23.Text = FormaCentarGlavni.F23.ToString();
                //////////////////////////////////////////////////////////
                textBox_FM2.Text = FormaCentarGlavni.FM2.ToString();
                if ((FormaCentarGlavni.F21 != 0 && FormaCentarGlavni.FM2 >= (FormaCentarGlavni.F21 - 1) && FormaCentarGlavni.FM2 <= (FormaCentarGlavni.F21 + 1)) ||
                    (FormaCentarGlavni.F22 != 0 && FormaCentarGlavni.FM2 >= (FormaCentarGlavni.F22 - 1) && FormaCentarGlavni.FM2 <= (FormaCentarGlavni.F22 + 1)) ||
                    (FormaCentarGlavni.F23 != 0 && FormaCentarGlavni.FM2 >= (FormaCentarGlavni.F23 - 1) && FormaCentarGlavni.FM2 <= (FormaCentarGlavni.F23 + 1)))
                {
                    button_FM.Visible = button_FM.Enabled = true;
                    textBox_FM2.BackColor = textBox_FM2.BackColor;
                    textBox_FM2.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FM2.BackColor = textBox_FM2.BackColor;
                    textBox_FM2.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FM22.Text = FormaCentarGlavni.FM22.ToString();
                if ((FormaCentarGlavni.F21 != 0 && FormaCentarGlavni.FM22 >= (FormaCentarGlavni.F21 - 1) && FormaCentarGlavni.FM22 <= (FormaCentarGlavni.F21 + 1)) ||
                    (FormaCentarGlavni.F22 != 0 && FormaCentarGlavni.FM22 >= (FormaCentarGlavni.F22 - 1) && FormaCentarGlavni.FM22 <= (FormaCentarGlavni.F22 + 1)) ||
                    (FormaCentarGlavni.F23 != 0 && FormaCentarGlavni.FM22 >= (FormaCentarGlavni.F23 - 1) && FormaCentarGlavni.FM22 <= (FormaCentarGlavni.F23 + 1)))
                {
                    button_FM2.Visible = button_FM2.Enabled = true;
                    textBox_FM22.BackColor = textBox_FM22.BackColor;
                    textBox_FM22.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FM22.BackColor = textBox_FM22.BackColor;
                    textBox_FM22.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FM23.Text = FormaCentarGlavni.FM23.ToString();
                if ((FormaCentarGlavni.F21 != 0 && FormaCentarGlavni.FM23 >= (FormaCentarGlavni.F21 - 1) && FormaCentarGlavni.FM23 <= (FormaCentarGlavni.F21 + 1)) ||
                    (FormaCentarGlavni.F22 != 0 && FormaCentarGlavni.FM23 >= (FormaCentarGlavni.F22 - 1) && FormaCentarGlavni.FM23 <= (FormaCentarGlavni.F22 + 1)) ||
                    (FormaCentarGlavni.F23 != 0 && FormaCentarGlavni.FM23 >= (FormaCentarGlavni.F23 - 1) && FormaCentarGlavni.FM23 <= (FormaCentarGlavni.F23 + 1)))
                {
                    button_FM3.Visible = button_FM3.Enabled = true;
                    textBox_FM23.BackColor = textBox_FM23.BackColor;
                    textBox_FM23.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FM23.BackColor = textBox_FM23.BackColor;
                    textBox_FM23.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FM24.Text = FormaCentarGlavni.FM24.ToString();
                if ((FormaCentarGlavni.F21 != 0 && FormaCentarGlavni.FM24 >= (FormaCentarGlavni.F21 - 1) && FormaCentarGlavni.FM24 <= (FormaCentarGlavni.F21 + 1)) ||
                    (FormaCentarGlavni.F22 != 0 && FormaCentarGlavni.FM24 >= (FormaCentarGlavni.F22 - 1) && FormaCentarGlavni.FM24 <= (FormaCentarGlavni.F22 + 1)) ||
                    (FormaCentarGlavni.F23 != 0 && FormaCentarGlavni.FM24 >= (FormaCentarGlavni.F23 - 1) && FormaCentarGlavni.FM24 <= (FormaCentarGlavni.F23 + 1)))
                {
                    button_FM4.Visible = button_FM4.Enabled = true;
                    textBox_FM24.BackColor = textBox_FM24.BackColor;
                    textBox_FM24.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FM24.BackColor = textBox_FM24.BackColor;
                    textBox_FM24.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FB2.Text = FormaCentarGlavni.FB2.ToString();
                if ((FormaCentarGlavni.F21 != 0 && FormaCentarGlavni.FB2 >= (FormaCentarGlavni.F21 - 1) && FormaCentarGlavni.FB2 <= (FormaCentarGlavni.F21 + 1)) ||
                    (FormaCentarGlavni.F22 != 0 && FormaCentarGlavni.FB2 >= (FormaCentarGlavni.F22 - 1) && FormaCentarGlavni.FB2 <= (FormaCentarGlavni.F22 + 1)) ||
                    (FormaCentarGlavni.F23 != 0 && FormaCentarGlavni.FB2 >= (FormaCentarGlavni.F23 - 1) && FormaCentarGlavni.FB2 <= (FormaCentarGlavni.F23 + 1)))
                {
                    button_FB.Visible = button_FB.Enabled = true;
                    textBox_FB2.BackColor = textBox_FB2.BackColor;
                    textBox_FB2.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FB2.BackColor = textBox_FB2.BackColor;
                    textBox_FB2.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FP2.Text = FormaCentarGlavni.FP2.ToString();
                if ((FormaCentarGlavni.F21 != 0 && FormaCentarGlavni.FP2 >= (FormaCentarGlavni.F21 - 1) && FormaCentarGlavni.FP2 <= (FormaCentarGlavni.F21 + 1)) ||
                    (FormaCentarGlavni.F22 != 0 && FormaCentarGlavni.FP2 >= (FormaCentarGlavni.F22 - 1) && FormaCentarGlavni.FP2 <= (FormaCentarGlavni.F22 + 1)) ||
                    (FormaCentarGlavni.F23 != 0 && FormaCentarGlavni.FP2 >= (FormaCentarGlavni.F23 - 1) && FormaCentarGlavni.FP2 <= (FormaCentarGlavni.F23 + 1)))
                {
                    button_FP.Visible = button_FP.Enabled = true;
                    textBox_FP2.BackColor = textBox_FP2.BackColor;
                    textBox_FP2.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FP2.BackColor = textBox_FP2.BackColor;
                    textBox_FP2.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
            }

            #endregion

            #region rpm3

            if (FormaCentarGlavni.RPM3Unet)
            {
                //////////////////////////////////////////////////////////
                textBox_RPM3.Text = FormaCentarGlavni.RPM3.ToString();
                if (FormaCentarGlavni.F31 != 0) textBox_F31.Text = FormaCentarGlavni.F31.ToString();
                if (FormaCentarGlavni.F32 != 0) textBox_F32.Text = FormaCentarGlavni.F32.ToString();
                if (FormaCentarGlavni.F33 != 0) textBox_F33.Text = FormaCentarGlavni.F33.ToString();
                //////////////////////////////////////////////////////////
                textBox_FM3.Text = FormaCentarGlavni.FM3.ToString();
                if ((FormaCentarGlavni.F31 != 0 && FormaCentarGlavni.FM3 >= (FormaCentarGlavni.F31 - 1) && FormaCentarGlavni.FM3 <= (FormaCentarGlavni.F31 + 1)) ||
                    (FormaCentarGlavni.F32 != 0 && FormaCentarGlavni.FM3 >= (FormaCentarGlavni.F32 - 1) && FormaCentarGlavni.FM3 <= (FormaCentarGlavni.F32 + 1)) ||
                    (FormaCentarGlavni.F33 != 0 && FormaCentarGlavni.FM3 >= (FormaCentarGlavni.F33 - 1) && FormaCentarGlavni.FM3 <= (FormaCentarGlavni.F33 + 1)))
                {
                    button_FM.Visible = button_FM.Enabled = true;
                    textBox_FM3.BackColor = textBox_FM3.BackColor;
                    textBox_FM3.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FM3.BackColor = textBox_FM3.BackColor;
                    textBox_FM3.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FM32.Text = FormaCentarGlavni.FM32.ToString();
                if ((FormaCentarGlavni.F31 != 0 && FormaCentarGlavni.FM32 >= (FormaCentarGlavni.F31 - 1) && FormaCentarGlavni.FM32 <= (FormaCentarGlavni.F31 + 1)) ||
                    (FormaCentarGlavni.F32 != 0 && FormaCentarGlavni.FM32 >= (FormaCentarGlavni.F32 - 1) && FormaCentarGlavni.FM32 <= (FormaCentarGlavni.F32 + 1)) ||
                    (FormaCentarGlavni.F33 != 0 && FormaCentarGlavni.FM32 >= (FormaCentarGlavni.F33 - 1) && FormaCentarGlavni.FM32 <= (FormaCentarGlavni.F33 + 1)))
                {
                    button_FM2.Visible = button_FM2.Enabled = true;
                    textBox_FM32.BackColor = textBox_FM32.BackColor;
                    textBox_FM32.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FM32.BackColor = textBox_FM32.BackColor;
                    textBox_FM32.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FM33.Text = FormaCentarGlavni.FM33.ToString();
                if ((FormaCentarGlavni.F31 != 0 && FormaCentarGlavni.FM33 >= (FormaCentarGlavni.F31 - 1) && FormaCentarGlavni.FM33 <= (FormaCentarGlavni.F31 + 1)) ||
                    (FormaCentarGlavni.F32 != 0 && FormaCentarGlavni.FM33 >= (FormaCentarGlavni.F32 - 1) && FormaCentarGlavni.FM33 <= (FormaCentarGlavni.F32 + 1)) ||
                    (FormaCentarGlavni.F33 != 0 && FormaCentarGlavni.FM33 >= (FormaCentarGlavni.F33 - 1) && FormaCentarGlavni.FM33 <= (FormaCentarGlavni.F33 + 1)))
                {
                    button_FM3.Visible = button_FM3.Enabled = true;
                    textBox_FM33.BackColor = textBox_FM33.BackColor;
                    textBox_FM33.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FM33.BackColor = textBox_FM33.BackColor;
                    textBox_FM33.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FM34.Text = FormaCentarGlavni.FM34.ToString();
                if ((FormaCentarGlavni.F31 != 0 && FormaCentarGlavni.FM34 >= (FormaCentarGlavni.F31 - 1) && FormaCentarGlavni.FM34 <= (FormaCentarGlavni.F31 + 1)) ||
                    (FormaCentarGlavni.F32 != 0 && FormaCentarGlavni.FM34 >= (FormaCentarGlavni.F32 - 1) && FormaCentarGlavni.FM34 <= (FormaCentarGlavni.F32 + 1)) ||
                    (FormaCentarGlavni.F33 != 0 && FormaCentarGlavni.FM34 >= (FormaCentarGlavni.F33 - 1) && FormaCentarGlavni.FM34 <= (FormaCentarGlavni.F33 + 1)))
                {
                    button_FM4.Visible = button_FM4.Enabled = true;
                    textBox_FM34.BackColor = textBox_FM34.BackColor;
                    textBox_FM34.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FM34.BackColor = textBox_FM34.BackColor;
                    textBox_FM34.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FB3.Text = FormaCentarGlavni.FB3.ToString();
                if ((FormaCentarGlavni.F31 != 0 && FormaCentarGlavni.FB3 >= (FormaCentarGlavni.F31 - 1) && FormaCentarGlavni.FB3 <= (FormaCentarGlavni.F31 + 1)) ||
                    (FormaCentarGlavni.F32 != 0 && FormaCentarGlavni.FB3 >= (FormaCentarGlavni.F32 - 1) && FormaCentarGlavni.FB3 <= (FormaCentarGlavni.F32 + 1)) ||
                    (FormaCentarGlavni.F33 != 0 && FormaCentarGlavni.FB3 >= (FormaCentarGlavni.F33 - 1) && FormaCentarGlavni.FB3 <= (FormaCentarGlavni.F33 + 1)))
                {
                    button_FB.Visible = button_FB.Enabled = true;
                    textBox_FB3.BackColor = textBox_FB3.BackColor;
                    textBox_FB3.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FB3.BackColor = textBox_FB3.BackColor;
                    textBox_FB3.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FP3.Text = FormaCentarGlavni.FP3.ToString();
                if ((FormaCentarGlavni.F31 != 0 && FormaCentarGlavni.FP3 >= (FormaCentarGlavni.F31 - 1) && FormaCentarGlavni.FP3 <= (FormaCentarGlavni.F31 + 1)) ||
                    (FormaCentarGlavni.F32 != 0 && FormaCentarGlavni.FP3 >= (FormaCentarGlavni.F32 - 1) && FormaCentarGlavni.FP3 <= (FormaCentarGlavni.F32 + 1)) ||
                    (FormaCentarGlavni.F33 != 0 && FormaCentarGlavni.FP3 >= (FormaCentarGlavni.F33 - 1) && FormaCentarGlavni.FP3 <= (FormaCentarGlavni.F33 + 1)))
                {
                    button_FP.Visible = button_FP.Enabled = true;
                    textBox_FP3.BackColor = textBox_FP3.BackColor;
                    textBox_FP3.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FP3.BackColor = textBox_FP3.BackColor;
                    textBox_FP3.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
            }

            #endregion
        }


        private void otvoriTekst(object sender, EventArgs e)
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

        private void otvoriTekstAlt(object sender, EventArgs e)
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

#pragma warning restore IDE1006
    }
}
