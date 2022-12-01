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
    public partial class Forma_Centar_Tabela_1 : Form
    {
        public Forma_Centar_Glavni   FormaCentarGlavni;
        public Forma_Centar_Tabela_2 FormaCentarTabela2;

        public Forma_Centar_Tabela_1(Forma_Centar_Glavni konstruktor)
        {
            InitializeComponent();
            FormaCentarGlavni = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text             = FormaCentarGlavni.FormaHomeScreen.jezik[14];
            label_RPM.Text        = FormaCentarGlavni.FormaHomeScreen.jezik[15];
            label_FrMotora.Text   = FormaCentarGlavni.FormaHomeScreen.jezik[16];
            label_FrMotora2.Text  = FormaCentarGlavni.FormaHomeScreen.jezik[17];
            label_FrMotora3.Text  = FormaCentarGlavni.FormaHomeScreen.jezik[18];
            label_FrMotora4.Text  = FormaCentarGlavni.FormaHomeScreen.jezik[19];
            label_FrBregaste.Text = FormaCentarGlavni.FormaHomeScreen.jezik[20];
            label_FrPaljenja.Text = FormaCentarGlavni.FormaHomeScreen.jezik[21];
            label_IzmFrek.Text    = FormaCentarGlavni.FormaHomeScreen.jezik[22];
            button1.Text          = FormaCentarGlavni.FormaHomeScreen.jezik[23];
        }

        private void Forma_Centar_Tabela_1_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(FormaCentarGlavni.Right, FormaCentarGlavni.Bottom);

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
            FormaCentarGlavni.FormaCentarTabela1 = null;
            FormaCentarGlavni.button1Enabled = true;
        }

        public void IspisVrednosti()
        {
            #region rpm1

            if (FormaCentarGlavni.rpm1unet)
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
                    button_FM.Visible = button_FM.Enabled = false;
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
                    button_FM2.Visible = button_FM2.Enabled = false;
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
                    button_FM3.Visible = button_FM3.Enabled = false;
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
                    button_FM4.Visible = button_FM4.Enabled = false;
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
                    button_FB.Visible = button_FB.Enabled = false;
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
                    button_FP.Visible = button_FP.Enabled = false;
                    textBox_FP1.BackColor = textBox_FP1.BackColor;
                    textBox_FP1.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
            }

            #endregion

            #region rpm2

            if (FormaCentarGlavni.rpm2unet)
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

            if (FormaCentarGlavni.rpm3unet)
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

        #region dugmici sa znakom pitanja

        private void button_FM_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarGlavni.FormaHomeScreen.jezik[24]);
        }

        private void button_FM2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarGlavni.FormaHomeScreen.jezik[25]);
        }

        private void button_FM3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarGlavni.FormaHomeScreen.jezik[26]);
        }

        private void button_FM4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarGlavni.FormaHomeScreen.jezik[27]);
        }

        private void button_FB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarGlavni.FormaHomeScreen.jezik[28]);
        }

        private void button_FP_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaCentarGlavni.FormaHomeScreen.jezik[29]);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            FormaCentarTabela2 = new Forma_Centar_Tabela_2(this);
            FormaCentarTabela2.Owner = this;
            FormaCentarTabela2.Show();

            button1.Enabled = false;
        }

        public Boolean button1Enabled
        {
            get { return button1.Enabled; }
            set { button1.Enabled = value; }
        }
    }
}
