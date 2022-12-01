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
    public partial class Forma_Desni_Tabela : Form
    {
#pragma warning disable IDE1006

        public Forma_Desni_Glavni FormaDesniGlavni;

        public Forma_Desni_Tabela(Forma_Desni_Glavni konstruktor)
        {
            InitializeComponent();
            FormaDesniGlavni = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text               = FormaDesniGlavni.FormaHomeScreen.Jezik[128];
            label_BrzinaVozila.Text = FormaDesniGlavni.FormaHomeScreen.Jezik[129];
            label_FT.Text           = FormaDesniGlavni.FormaHomeScreen.Jezik[130];
            label_FTx1.Text         = FormaDesniGlavni.FormaHomeScreen.Jezik[131];
            label_FTx2.Text         = FormaDesniGlavni.FormaHomeScreen.Jezik[132];
            label_FTx3.Text         = FormaDesniGlavni.FormaHomeScreen.Jezik[133];
            label_FTx4.Text         = FormaDesniGlavni.FormaHomeScreen.Jezik[134];
            label_FK.Text           = FormaDesniGlavni.FormaHomeScreen.Jezik[135];
            label_FKx1.Text         = FormaDesniGlavni.FormaHomeScreen.Jezik[136];
            label_FKx2.Text         = FormaDesniGlavni.FormaHomeScreen.Jezik[137];
            label_FKx3.Text         = FormaDesniGlavni.FormaHomeScreen.Jezik[138];
            label_FKx4.Text         = FormaDesniGlavni.FormaHomeScreen.Jezik[139];
            label_IzmFrek.Text      = FormaDesniGlavni.FormaHomeScreen.Jezik[140];

            label_FT2.Text = FormaDesniGlavni.FormaHomeScreen.Jezik[202];
            label_FK2.Text = FormaDesniGlavni.FormaHomeScreen.Jezik[203];
        }

        private void Forma_Desni_Tabela_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(FormaDesniGlavni.Left + 20, FormaDesniGlavni.Top + 20);

            #region text box sranja

            textBox_V1.BackColor = textBox_V1.BackColor;
            textBox_V1.ForeColor = Color.Gray;
            textBox_V2.BackColor = textBox_V2.BackColor;
            textBox_V2.ForeColor = Color.Gray;
            textBox_V3.BackColor = textBox_V3.BackColor;
            textBox_V3.ForeColor = Color.Gray;

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

        private void Forma_Desni_Tabela_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaDesniGlavni.FormaDesniTabela    = null;
            FormaDesniGlavni.ButtonTabelaEnabled = true;
        }

        public void IspisVrednosti()
        {
            textBox_V1.Text        = textBox_V2.Text    = textBox_V3.Text    =
                textBox_FT1.Text   = textBox_FT2.Text   = textBox_FT3.Text   =
                textBox_FT1x2.Text = textBox_FT2x2.Text = textBox_FT3x2.Text =
                textBox_FT1x3.Text = textBox_FT2x3.Text = textBox_FT3x3.Text =
                textBox_FT1x4.Text = textBox_FT2x4.Text = textBox_FT3x4.Text =
                textBox_FK1.Text   = textBox_FK2.Text   = textBox_FK3.Text   =
                textBox_FK1x2.Text = textBox_FK2x2.Text = textBox_FK3x2.Text =
                textBox_FK1x3.Text = textBox_FK2x3.Text = textBox_FK3x3.Text =
                textBox_FK1x4.Text = textBox_FK2x4.Text = textBox_FK3x4.Text =
                textBox_F11.Text   = textBox_F12.Text   = textBox_F13.Text   =
                textBox_F21.Text   = textBox_F22.Text   = textBox_F23.Text   =
                textBox_F31.Text   = textBox_F32.Text   = textBox_F33.Text   = "";

            button_FTx1.Visible     = button_FTx1.Enabled =
                button_FTx2.Visible = button_FTx2.Enabled =
                button_FTx3.Visible = button_FTx3.Enabled =
                button_FTx4.Visible = button_FTx4.Enabled =
                button_FKx1.Visible = button_FKx1.Enabled =
                button_FKx2.Visible = button_FKx2.Enabled =
                button_FKx3.Visible = button_FKx3.Enabled =
                button_FKx4.Visible = button_FKx4.Enabled = false;

            #region v1unet

            if (FormaDesniGlavni.V1Unet)
            {
                //////////////////////////////////////////////////////////
                textBox_V1.Text = FormaDesniGlavni.V1.ToString();
                if (FormaDesniGlavni.F11 != 0) textBox_F11.Text = FormaDesniGlavni.F11.ToString();
                if (FormaDesniGlavni.F12 != 0) textBox_F12.Text = FormaDesniGlavni.F12.ToString();
                if (FormaDesniGlavni.F13 != 0) textBox_F13.Text = FormaDesniGlavni.F13.ToString();
                //////////////////////////////////////////////////////////
                textBox_FT1.Text = FormaDesniGlavni.FT1.ToString();
                if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FT1 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FT1 <= (FormaDesniGlavni.F11 + 1)) ||
                    (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FT1 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FT1 <= (FormaDesniGlavni.F12 + 1)) ||
                    (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FT1 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FT1 <= (FormaDesniGlavni.F13 + 1)))
                {
                    button_FTx1.Visible = button_FTx1.Enabled = true;
                    textBox_FT1.BackColor = textBox_FT1.BackColor;
                    textBox_FT1.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FT1.BackColor = textBox_FT1.BackColor;
                    textBox_FT1.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FT1x2.Text = FormaDesniGlavni.FT1x2.ToString();
                if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FT1x2 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FT1x2 <= (FormaDesniGlavni.F11 + 1)) ||
                    (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FT1x2 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FT1x2 <= (FormaDesniGlavni.F12 + 1)) ||
                    (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FT1x2 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FT1x2 <= (FormaDesniGlavni.F13 + 1)))
                {
                    button_FTx2.Visible = button_FTx2.Enabled = true;
                    textBox_FT1x2.BackColor = textBox_FT1x2.BackColor;
                    textBox_FT1x2.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FT1x2.BackColor = textBox_FT1x2.BackColor;
                    textBox_FT1x2.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FT1x3.Text = FormaDesniGlavni.FT1x3.ToString();
                if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FT1x3 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FT1x3 <= (FormaDesniGlavni.F11 + 1)) ||
                    (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FT1x3 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FT1x3 <= (FormaDesniGlavni.F12 + 1)) ||
                    (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FT1x3 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FT1x3 <= (FormaDesniGlavni.F13 + 1)))
                {
                    button_FTx3.Visible = button_FTx3.Enabled = true;
                    textBox_FT1x3.BackColor = textBox_FT1x3.BackColor;
                    textBox_FT1x3.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FT1x3.BackColor = textBox_FT1x3.BackColor;
                    textBox_FT1x3.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FT1x4.Text = FormaDesniGlavni.FT1x4.ToString();
                if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FT1x4 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FT1x4 <= (FormaDesniGlavni.F11 + 1)) ||
                    (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FT1x4 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FT1x4 <= (FormaDesniGlavni.F12 + 1)) ||
                    (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FT1x4 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FT1x4 <= (FormaDesniGlavni.F13 + 1)))
                {
                    button_FTx4.Visible = button_FTx4.Enabled = true;
                    textBox_FT1x4.BackColor = textBox_FT1x4.BackColor;
                    textBox_FT1x4.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FT1x4.BackColor = textBox_FT1x4.BackColor;
                    textBox_FT1x4.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                if (FormaDesniGlavni.I != 0)
                {
                    //////////////////////////////////////////////////////////
                    textBox_FK1.Text = FormaDesniGlavni.FK1.ToString();
                    if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FK1 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FK1 <= (FormaDesniGlavni.F11 + 1)) ||
                        (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FK1 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FK1 <= (FormaDesniGlavni.F12 + 1)) ||
                        (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FK1 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FK1 <= (FormaDesniGlavni.F13 + 1)))
                    {
                        button_FKx1.Visible = button_FKx1.Enabled = true;
                        textBox_FK1.BackColor = textBox_FK1.BackColor;
                        textBox_FK1.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FK1.BackColor = textBox_FK1.BackColor;
                        textBox_FK1.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FK1x2.Text = FormaDesniGlavni.FK1x2.ToString();
                    if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FK1x2 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FK1x2 <= (FormaDesniGlavni.F11 + 1)) ||
                        (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FK1x2 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FK1x2 <= (FormaDesniGlavni.F12 + 1)) ||
                        (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FK1x2 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FK1x2 <= (FormaDesniGlavni.F13 + 1)))
                    {
                        button_FKx2.Visible = button_FKx2.Enabled = true;
                        textBox_FK1x2.BackColor = textBox_FK1x2.BackColor;
                        textBox_FK1x2.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FK1x2.BackColor = textBox_FK1x2.BackColor;
                        textBox_FK1x2.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FK1x3.Text = FormaDesniGlavni.FK1x3.ToString();
                    if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FK1x3 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FK1x3 <= (FormaDesniGlavni.F11 + 1)) ||
                        (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FK1x3 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FK1x3 <= (FormaDesniGlavni.F12 + 1)) ||
                        (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FK1x3 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FK1x3 <= (FormaDesniGlavni.F13 + 1)))
                    {
                        button_FKx3.Visible = button_FKx3.Enabled = true;
                        textBox_FK1x3.BackColor = textBox_FK1x3.BackColor;
                        textBox_FK1x3.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FK1x3.BackColor = textBox_FK1x3.BackColor;
                        textBox_FK1x3.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FK1x4.Text = FormaDesniGlavni.FK1x4.ToString();
                    if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FK1x4 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FK1x4 <= (FormaDesniGlavni.F11 + 1)) ||
                        (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FK1x4 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FK1x4 <= (FormaDesniGlavni.F12 + 1)) ||
                        (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FK1x4 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FK1x4 <= (FormaDesniGlavni.F13 + 1)))
                    {
                        button_FKx4.Visible = button_FKx4.Enabled = true;
                        textBox_FK1x4.BackColor = textBox_FK1x4.BackColor;
                        textBox_FK1x4.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FK1x4.BackColor = textBox_FK1x4.BackColor;
                        textBox_FK1x4.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                }
                //////////////////////////////////////////////////////////
            }

            #endregion

            #region v2unet

            if (FormaDesniGlavni.V2Unet)
            {
                //////////////////////////////////////////////////////////
                textBox_V2.Text = FormaDesniGlavni.V2.ToString();
                if (FormaDesniGlavni.F21 != 0) textBox_F21.Text = FormaDesniGlavni.F21.ToString();
                if (FormaDesniGlavni.F22 != 0) textBox_F22.Text = FormaDesniGlavni.F22.ToString();
                if (FormaDesniGlavni.F23 != 0) textBox_F23.Text = FormaDesniGlavni.F23.ToString();
                //////////////////////////////////////////////////////////
                textBox_FT2.Text = FormaDesniGlavni.FT2.ToString();
                if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FT2 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FT2 <= (FormaDesniGlavni.F21 + 1)) ||
                    (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FT2 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FT2 <= (FormaDesniGlavni.F22 + 1)) ||
                    (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FT2 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FT2 <= (FormaDesniGlavni.F23 + 1)))
                {
                    button_FTx1.Visible = button_FTx1.Enabled = true;
                    textBox_FT2.BackColor = textBox_FT2.BackColor;
                    textBox_FT2.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FT2.BackColor = textBox_FT2.BackColor;
                    textBox_FT2.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FT2x2.Text = FormaDesniGlavni.FT2x2.ToString();
                if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FT2x2 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FT2x2 <= (FormaDesniGlavni.F21 + 1)) ||
                    (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FT2x2 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FT2x2 <= (FormaDesniGlavni.F22 + 1)) ||
                    (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FT2x2 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FT2x2 <= (FormaDesniGlavni.F23 + 1)))
                {
                    button_FTx2.Visible = button_FTx2.Enabled = true;
                    textBox_FT2x2.BackColor = textBox_FT2x2.BackColor;
                    textBox_FT2x2.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FT2x2.BackColor = textBox_FT2x2.BackColor;
                    textBox_FT2x2.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FT2x3.Text = FormaDesniGlavni.FT2x3.ToString();
                if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FT2x3 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FT2x3 <= (FormaDesniGlavni.F21 + 1)) ||
                    (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FT2x3 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FT2x3 <= (FormaDesniGlavni.F22 + 1)) ||
                    (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FT2x3 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FT2x3 <= (FormaDesniGlavni.F23 + 1)))
                {
                    button_FTx3.Visible = button_FTx3.Enabled = true;
                    textBox_FT2x3.BackColor = textBox_FT2x3.BackColor;
                    textBox_FT2x3.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FT2x3.BackColor = textBox_FT2x3.BackColor;
                    textBox_FT2x3.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FT2x4.Text = FormaDesniGlavni.FT2x4.ToString();
                if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FT2x4 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FT2x4 <= (FormaDesniGlavni.F21 + 1)) ||
                    (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FT2x4 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FT2x4 <= (FormaDesniGlavni.F22 + 1)) ||
                    (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FT2x4 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FT2x4 <= (FormaDesniGlavni.F23 + 1)))
                {
                    button_FTx4.Visible = button_FTx4.Enabled = true;
                    textBox_FT2x4.BackColor = textBox_FT2x4.BackColor;
                    textBox_FT2x4.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FT2x4.BackColor = textBox_FT2x4.BackColor;
                    textBox_FT2x4.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                if (FormaDesniGlavni.I != 0)
                {
                    //////////////////////////////////////////////////////////
                    textBox_FK2.Text = FormaDesniGlavni.FK2.ToString();
                    if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FK2 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FK2 <= (FormaDesniGlavni.F21 + 1)) ||
                        (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FK2 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FK2 <= (FormaDesniGlavni.F22 + 1)) ||
                        (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FK2 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FK2 <= (FormaDesniGlavni.F23 + 1)))
                    {
                        button_FKx1.Visible = button_FKx1.Enabled = true;
                        textBox_FK2.BackColor = textBox_FK2.BackColor;
                        textBox_FK2.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FK2.BackColor = textBox_FK2.BackColor;
                        textBox_FK2.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FK2x2.Text = FormaDesniGlavni.FK2x2.ToString();
                    if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FK2x2 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FK2x2 <= (FormaDesniGlavni.F21 + 1)) ||
                        (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FK2x2 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FK2x2 <= (FormaDesniGlavni.F22 + 1)) ||
                        (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FK2x2 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FK2x2 <= (FormaDesniGlavni.F23 + 1)))
                    {
                        button_FKx2.Visible = button_FKx2.Enabled = true;
                        textBox_FK2x2.BackColor = textBox_FK2x2.BackColor;
                        textBox_FK2x2.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FK2x2.BackColor = textBox_FK2x2.BackColor;
                        textBox_FK2x2.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FK2x3.Text = FormaDesniGlavni.FK2x3.ToString();
                    if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FK2x3 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FK2x3 <= (FormaDesniGlavni.F21 + 1)) ||
                        (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FK2x3 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FK2x3 <= (FormaDesniGlavni.F22 + 1)) ||
                        (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FK2x3 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FK2x3 <= (FormaDesniGlavni.F23 + 1)))
                    {
                        button_FKx3.Visible = button_FKx3.Enabled = true;
                        textBox_FK2x3.BackColor = textBox_FK2x3.BackColor;
                        textBox_FK2x3.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FK2x3.BackColor = textBox_FK2x3.BackColor;
                        textBox_FK2x3.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FK2x4.Text = FormaDesniGlavni.FK2x4.ToString();
                    if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FK2x4 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FK2x4 <= (FormaDesniGlavni.F21 + 1)) ||
                        (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FK2x4 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FK2x4 <= (FormaDesniGlavni.F22 + 1)) ||
                        (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FK2x4 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FK2x4 <= (FormaDesniGlavni.F23 + 1)))
                    {
                        button_FKx4.Visible = button_FKx4.Enabled = true;
                        textBox_FK2x4.BackColor = textBox_FK2x4.BackColor;
                        textBox_FK2x4.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FK2x4.BackColor = textBox_FK2x4.BackColor;
                        textBox_FK2x4.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                }
                //////////////////////////////////////////////////////////
            }

            #endregion

            #region v3unet

            if (FormaDesniGlavni.V3Unet)
            {
                //////////////////////////////////////////////////////////
                textBox_V3.Text = FormaDesniGlavni.V3.ToString();
                if (FormaDesniGlavni.F31 != 0) textBox_F31.Text = FormaDesniGlavni.F31.ToString();
                if (FormaDesniGlavni.F32 != 0) textBox_F32.Text = FormaDesniGlavni.F32.ToString();
                if (FormaDesniGlavni.F33 != 0) textBox_F33.Text = FormaDesniGlavni.F33.ToString();
                //////////////////////////////////////////////////////////
                textBox_FT3.Text = FormaDesniGlavni.FT3.ToString();
                if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FT3 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FT3 <= (FormaDesniGlavni.F31 + 1)) ||
                    (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FT3 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FT3 <= (FormaDesniGlavni.F32 + 1)) ||
                    (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FT3 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FT3 <= (FormaDesniGlavni.F33 + 1)))
                {
                    button_FTx1.Visible = button_FTx1.Enabled = true;
                    textBox_FT3.BackColor = textBox_FT3.BackColor;
                    textBox_FT3.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FT3.BackColor = textBox_FT3.BackColor;
                    textBox_FT3.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FT3x2.Text = FormaDesniGlavni.FT3x2.ToString();
                if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FT3x2 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FT3x2 <= (FormaDesniGlavni.F31 + 1)) ||
                    (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FT3x2 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FT3x2 <= (FormaDesniGlavni.F32 + 1)) ||
                    (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FT3x2 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FT3x2 <= (FormaDesniGlavni.F33 + 1)))
                {
                    button_FTx2.Visible = button_FTx2.Enabled = true;
                    textBox_FT3x2.BackColor = textBox_FT3x2.BackColor;
                    textBox_FT3x2.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FT3x2.BackColor = textBox_FT3x2.BackColor;
                    textBox_FT3x2.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FT3x3.Text = FormaDesniGlavni.FT3x3.ToString();
                if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FT3x3 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FT3x3 <= (FormaDesniGlavni.F31 + 1)) ||
                    (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FT3x3 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FT3x3 <= (FormaDesniGlavni.F32 + 1)) ||
                    (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FT3x3 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FT3x3 <= (FormaDesniGlavni.F33 + 1)))
                {
                    button_FTx3.Visible = button_FTx3.Enabled = true;
                    textBox_FT3x3.BackColor = textBox_FT3x3.BackColor;
                    textBox_FT3x3.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FT3x3.BackColor = textBox_FT3x3.BackColor;
                    textBox_FT3x3.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                textBox_FT3x4.Text = FormaDesniGlavni.FT3x4.ToString();
                if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FT3x4 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FT3x4 <= (FormaDesniGlavni.F31 + 1)) ||
                    (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FT3x4 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FT3x4 <= (FormaDesniGlavni.F32 + 1)) ||
                    (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FT3x4 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FT3x4 <= (FormaDesniGlavni.F33 + 1)))
                {
                    button_FTx4.Visible = button_FTx4.Enabled = true;
                    textBox_FT3x4.BackColor = textBox_FT3x4.BackColor;
                    textBox_FT3x4.ForeColor = Color.Red;
                }
                else
                {
                    textBox_FT3x4.BackColor = textBox_FT3x4.BackColor;
                    textBox_FT3x4.ForeColor = Color.Gray;
                }
                //////////////////////////////////////////////////////////
                if (FormaDesniGlavni.I != 0)
                {
                    //////////////////////////////////////////////////////////
                    textBox_FK3.Text = FormaDesniGlavni.FK3.ToString();
                    if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FK3 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FK3 <= (FormaDesniGlavni.F31 + 1)) ||
                        (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FK3 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FK3 <= (FormaDesniGlavni.F32 + 1)) ||
                        (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FK3 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FK3 <= (FormaDesniGlavni.F33 + 1)))
                    {
                        button_FKx1.Visible = button_FKx1.Enabled = true;
                        textBox_FK3.BackColor = textBox_FK3.BackColor;
                        textBox_FK3.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FK3.BackColor = textBox_FK3.BackColor;
                        textBox_FK3.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FK3x2.Text = FormaDesniGlavni.FK3x2.ToString();
                    if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FK3x2 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FK3x2 <= (FormaDesniGlavni.F31 + 1)) ||
                        (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FK3x2 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FK3x2 <= (FormaDesniGlavni.F32 + 1)) ||
                        (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FK3x2 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FK3x2 <= (FormaDesniGlavni.F33 + 1)))
                    {
                        button_FKx2.Visible = button_FKx2.Enabled = true;
                        textBox_FK3x2.BackColor = textBox_FK3x2.BackColor;
                        textBox_FK3x2.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FK3x2.BackColor = textBox_FK3x2.BackColor;
                        textBox_FK3x2.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FK3x3.Text = FormaDesniGlavni.FK3x3.ToString();
                    if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FK3x3 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FK3x3 <= (FormaDesniGlavni.F31 + 1)) ||
                        (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FK3x3 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FK3x3 <= (FormaDesniGlavni.F32 + 1)) ||
                        (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FK3x3 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FK3x3 <= (FormaDesniGlavni.F33 + 1)))
                    {
                        button_FKx3.Visible = button_FKx3.Enabled = true;
                        textBox_FK3x3.BackColor = textBox_FK3x3.BackColor;
                        textBox_FK3x3.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FK3x3.BackColor = textBox_FK3x3.BackColor;
                        textBox_FK3x3.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FK3x4.Text = FormaDesniGlavni.FK3x4.ToString();
                    if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FK3x4 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FK3x4 <= (FormaDesniGlavni.F31 + 1)) ||
                        (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FK3x4 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FK3x4 <= (FormaDesniGlavni.F32 + 1)) ||
                        (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FK3x4 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FK3x4 <= (FormaDesniGlavni.F33 + 1)))
                    {
                        button_FKx4.Visible = button_FKx4.Enabled = true;
                        textBox_FK3x4.BackColor = textBox_FK3x4.BackColor;
                        textBox_FK3x4.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FK3x4.BackColor = textBox_FK3x4.BackColor;
                        textBox_FK3x4.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                }
                //////////////////////////////////////////////////////////
            }

            #endregion

            #region checkBox1Checked

            if (FormaDesniGlavni.W2 != 0)
            {
                label_FT2.Enabled     = label_FT2.Visible =
                    label_FK2.Enabled = label_FK2.Visible =

                    textBox_FT2_1.Enabled   = textBox_FT2_1.Visible   =
                    textBox_FT2_1x2.Enabled = textBox_FT2_1x2.Visible =
                    textBox_FT2_1x3.Enabled = textBox_FT2_1x3.Visible =
                    textBox_FT2_1x4.Enabled = textBox_FT2_1x4.Visible =
                    textBox_FK2_1.Enabled   = textBox_FK2_1.Visible   =
                    textBox_FK2_1x2.Enabled = textBox_FK2_1x2.Visible =
                    textBox_FK2_1x3.Enabled = textBox_FK2_1x3.Visible =
                    textBox_FK2_1x4.Enabled = textBox_FK2_1x4.Visible =

                    textBox_FT2_2.Enabled   = textBox_FT2_2.Visible   =
                    textBox_FT2_2x2.Enabled = textBox_FT2_2x2.Visible =
                    textBox_FT2_2x3.Enabled = textBox_FT2_2x3.Visible =
                    textBox_FT2_2x4.Enabled = textBox_FT2_2x4.Visible =
                    textBox_FK2_2.Enabled   = textBox_FK2_2.Visible   =
                    textBox_FK2_2x2.Enabled = textBox_FK2_2x2.Visible =
                    textBox_FK2_2x3.Enabled = textBox_FK2_2x3.Visible =
                    textBox_FK2_2x4.Enabled = textBox_FK2_2x4.Visible =

                    textBox_FT2_3.Enabled   = textBox_FT2_3.Visible   =
                    textBox_FT2_3x2.Enabled = textBox_FT2_3x2.Visible =
                    textBox_FT2_3x3.Enabled = textBox_FT2_3x3.Visible =
                    textBox_FT2_3x4.Enabled = textBox_FT2_3x4.Visible =
                    textBox_FK2_3.Enabled   = textBox_FK2_3.Visible   =
                    textBox_FK2_3x2.Enabled = textBox_FK2_3x2.Visible =
                    textBox_FK2_3x3.Enabled = textBox_FK2_3x3.Visible =
                    textBox_FK2_3x4.Enabled = textBox_FK2_3x4.Visible = true;

                this.Size = new Size(820, 525);

                button_FTx1.Location = new Point(771, 75);
                button_FTx2.Location = new Point(771, 108);
                button_FTx3.Location = new Point(771, 141);
                button_FTx4.Location = new Point(771, 174);

                button_FKx1.Location = new Point(771, 240);
                button_FKx2.Location = new Point(771, 273);
                button_FKx3.Location = new Point(771, 306);
                button_FKx4.Location = new Point(771, 339);

                #region v1unet

                if (FormaDesniGlavni.V1Unet)
                {
                    //////////////////////////////////////////////////////////
                    textBox_V1.Text = FormaDesniGlavni.V1.ToString();
                    if (FormaDesniGlavni.F11 != 0) textBox_F11.Text = FormaDesniGlavni.F11.ToString();
                    if (FormaDesniGlavni.F12 != 0) textBox_F12.Text = FormaDesniGlavni.F12.ToString();
                    if (FormaDesniGlavni.F13 != 0) textBox_F13.Text = FormaDesniGlavni.F13.ToString();
                    //////////////////////////////////////////////////////////
                    textBox_FT2_1.Text = FormaDesniGlavni.FT2_1.ToString();
                    if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FT2_1 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FT2_1 <= (FormaDesniGlavni.F11 + 1)) ||
                        (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FT2_1 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FT2_1 <= (FormaDesniGlavni.F12 + 1)) ||
                        (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FT2_1 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FT2_1 <= (FormaDesniGlavni.F13 + 1)))
                    {
                        button_FTx1.Visible = button_FTx1.Enabled = true;
                        textBox_FT2_1.BackColor = textBox_FT2_1.BackColor;
                        textBox_FT2_1.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FT2_1.BackColor = textBox_FT2_1.BackColor;
                        textBox_FT2_1.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FT2_1x2.Text = FormaDesniGlavni.FT2_1x2.ToString();
                    if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FT2_1x2 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FT2_1x2 <= (FormaDesniGlavni.F11 + 1)) ||
                        (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FT2_1x2 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FT2_1x2 <= (FormaDesniGlavni.F12 + 1)) ||
                        (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FT2_1x2 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FT2_1x2 <= (FormaDesniGlavni.F13 + 1)))
                    {
                        button_FTx2.Visible = button_FTx2.Enabled = true;
                        textBox_FT2_1x2.BackColor = textBox_FT2_1x2.BackColor;
                        textBox_FT2_1x2.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FT2_1x2.BackColor = textBox_FT2_1x2.BackColor;
                        textBox_FT2_1x2.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FT2_1x3.Text = FormaDesniGlavni.FT2_1x3.ToString();
                    if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FT2_1x3 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FT2_1x3 <= (FormaDesniGlavni.F11 + 1)) ||
                        (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FT2_1x3 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FT2_1x3 <= (FormaDesniGlavni.F12 + 1)) ||
                        (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FT2_1x3 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FT2_1x3 <= (FormaDesniGlavni.F13 + 1)))
                    {
                        button_FTx3.Visible = button_FTx3.Enabled = true;
                        textBox_FT2_1x3.BackColor = textBox_FT2_1x3.BackColor;
                        textBox_FT2_1x3.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FT2_1x3.BackColor = textBox_FT2_1x3.BackColor;
                        textBox_FT2_1x3.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FT2_1x4.Text = FormaDesniGlavni.FT2_1x4.ToString();
                    if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FT2_1x4 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FT2_1x4 <= (FormaDesniGlavni.F11 + 1)) ||
                        (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FT2_1x4 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FT2_1x4 <= (FormaDesniGlavni.F12 + 1)) ||
                        (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FT2_1x4 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FT2_1x4 <= (FormaDesniGlavni.F13 + 1)))
                    {
                        button_FTx4.Visible = button_FTx4.Enabled = true;
                        textBox_FT2_1x4.BackColor = textBox_FT2_1x4.BackColor;
                        textBox_FT2_1x4.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FT2_1x4.BackColor = textBox_FT2_1x4.BackColor;
                        textBox_FT2_1x4.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    if (FormaDesniGlavni.I != 0)
                    {
                        //////////////////////////////////////////////////////////
                        textBox_FK2_1.Text = FormaDesniGlavni.FK2_1.ToString();
                        if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FK2_1 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FK2_1 <= (FormaDesniGlavni.F11 + 1)) ||
                            (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FK2_1 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FK2_1 <= (FormaDesniGlavni.F12 + 1)) ||
                            (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FK2_1 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FK2_1 <= (FormaDesniGlavni.F13 + 1)))
                        {
                            button_FKx1.Visible = button_FKx1.Enabled = true;
                            textBox_FK2_1.BackColor = textBox_FK2_1.BackColor;
                            textBox_FK2_1.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBox_FK2_1.BackColor = textBox_FK2_1.BackColor;
                            textBox_FK2_1.ForeColor = Color.Gray;
                        }
                        //////////////////////////////////////////////////////////
                        textBox_FK2_1x2.Text = FormaDesniGlavni.FK2_1x2.ToString();
                        if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FK2_1x2 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FK2_1x2 <= (FormaDesniGlavni.F11 + 1)) ||
                            (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FK2_1x2 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FK2_1x2 <= (FormaDesniGlavni.F12 + 1)) ||
                            (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FK2_1x2 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FK2_1x2 <= (FormaDesniGlavni.F13 + 1)))
                        {
                            button_FKx2.Visible = button_FKx2.Enabled = true;
                            textBox_FK2_1x2.BackColor = textBox_FK2_1x2.BackColor;
                            textBox_FK2_1x2.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBox_FK2_1x2.BackColor = textBox_FK2_1x2.BackColor;
                            textBox_FK2_1x2.ForeColor = Color.Gray;
                        }
                        //////////////////////////////////////////////////////////
                        textBox_FK2_1x3.Text = FormaDesniGlavni.FK2_1x3.ToString();
                        if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FK2_1x3 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FK2_1x3 <= (FormaDesniGlavni.F11 + 1)) ||
                            (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FK2_1x3 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FK2_1x3 <= (FormaDesniGlavni.F12 + 1)) ||
                            (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FK2_1x3 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FK2_1x3 <= (FormaDesniGlavni.F13 + 1)))
                        {
                            button_FKx3.Visible = button_FKx3.Enabled = true;
                            textBox_FK2_1x3.BackColor = textBox_FK2_1x3.BackColor;
                            textBox_FK2_1x3.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBox_FK2_1x3.BackColor = textBox_FK2_1x3.BackColor;
                            textBox_FK2_1x3.ForeColor = Color.Gray;
                        }
                        //////////////////////////////////////////////////////////
                        textBox_FK2_1x4.Text = FormaDesniGlavni.FK2_1x4.ToString();
                        if ((FormaDesniGlavni.F11 != 0 && FormaDesniGlavni.FK2_1x4 >= (FormaDesniGlavni.F11 - 1) && FormaDesniGlavni.FK2_1x4 <= (FormaDesniGlavni.F11 + 1)) ||
                            (FormaDesniGlavni.F12 != 0 && FormaDesniGlavni.FK2_1x4 >= (FormaDesniGlavni.F12 - 1) && FormaDesniGlavni.FK2_1x4 <= (FormaDesniGlavni.F12 + 1)) ||
                            (FormaDesniGlavni.F13 != 0 && FormaDesniGlavni.FK2_1x4 >= (FormaDesniGlavni.F13 - 1) && FormaDesniGlavni.FK2_1x4 <= (FormaDesniGlavni.F13 + 1)))
                        {
                            button_FKx4.Visible = button_FKx4.Enabled = true;
                            textBox_FK2_1x4.BackColor = textBox_FK2_1x4.BackColor;
                            textBox_FK2_1x4.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBox_FK2_1x4.BackColor = textBox_FK2_1x4.BackColor;
                            textBox_FK2_1x4.ForeColor = Color.Gray;
                        }
                        //////////////////////////////////////////////////////////
                    }
                    //////////////////////////////////////////////////////////
                }

                #endregion

                #region v2unet

                if (FormaDesniGlavni.V2Unet)
                {
                    //////////////////////////////////////////////////////////
                    textBox_V2.Text = FormaDesniGlavni.V2.ToString();
                    if (FormaDesniGlavni.F21 != 0) textBox_F21.Text = FormaDesniGlavni.F21.ToString();
                    if (FormaDesniGlavni.F22 != 0) textBox_F22.Text = FormaDesniGlavni.F22.ToString();
                    if (FormaDesniGlavni.F23 != 0) textBox_F23.Text = FormaDesniGlavni.F23.ToString();
                    //////////////////////////////////////////////////////////
                    textBox_FT2_2.Text = FormaDesniGlavni.FT2_2.ToString();
                    if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FT2_2 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FT2_2 <= (FormaDesniGlavni.F21 + 1)) ||
                        (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FT2_2 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FT2_2 <= (FormaDesniGlavni.F22 + 1)) ||
                        (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FT2_2 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FT2_2 <= (FormaDesniGlavni.F23 + 1)))
                    {
                        button_FTx1.Visible = button_FTx1.Enabled = true;
                        textBox_FT2_2.BackColor = textBox_FT2_2.BackColor;
                        textBox_FT2_2.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FT2_2.BackColor = textBox_FT2_2.BackColor;
                        textBox_FT2_2.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FT2_2x2.Text = FormaDesniGlavni.FT2_2x2.ToString();
                    if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FT2_2x2 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FT2_2x2 <= (FormaDesniGlavni.F21 + 1)) ||
                        (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FT2_2x2 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FT2_2x2 <= (FormaDesniGlavni.F22 + 1)) ||
                        (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FT2_2x2 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FT2_2x2 <= (FormaDesniGlavni.F23 + 1)))
                    {
                        button_FTx2.Visible = button_FTx2.Enabled = true;
                        textBox_FT2_2x2.BackColor = textBox_FT2_2x2.BackColor;
                        textBox_FT2_2x2.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FT2_2x2.BackColor = textBox_FT2_2x2.BackColor;
                        textBox_FT2_2x2.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FT2_2x3.Text = FormaDesniGlavni.FT2_2x3.ToString();
                    if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FT2_2x3 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FT2_2x3 <= (FormaDesniGlavni.F21 + 1)) ||
                        (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FT2_2x3 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FT2_2x3 <= (FormaDesniGlavni.F22 + 1)) ||
                        (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FT2_2x3 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FT2_2x3 <= (FormaDesniGlavni.F23 + 1)))
                    {
                        button_FTx3.Visible = button_FTx3.Enabled = true;
                        textBox_FT2_2x3.BackColor = textBox_FT2_2x3.BackColor;
                        textBox_FT2_2x3.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FT2_2x3.BackColor = textBox_FT2_2x3.BackColor;
                        textBox_FT2_2x3.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FT2_2x4.Text = FormaDesniGlavni.FT2_2x4.ToString();
                    if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FT2_2x4 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FT2_2x4 <= (FormaDesniGlavni.F21 + 1)) ||
                        (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FT2_2x4 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FT2_2x4 <= (FormaDesniGlavni.F22 + 1)) ||
                        (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FT2_2x4 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FT2_2x4 <= (FormaDesniGlavni.F23 + 1)))
                    {
                        button_FTx4.Visible = button_FTx4.Enabled = true;
                        textBox_FT2_2x4.BackColor = textBox_FT2_2x4.BackColor;
                        textBox_FT2_2x4.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FT2_2x4.BackColor = textBox_FT2_2x4.BackColor;
                        textBox_FT2_2x4.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    if (FormaDesniGlavni.I != 0)
                    {
                        //////////////////////////////////////////////////////////
                        textBox_FK2_2.Text = FormaDesniGlavni.FK2_2.ToString();
                        if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FK2_2 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FK2_2 <= (FormaDesniGlavni.F21 + 1)) ||
                            (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FK2_2 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FK2_2 <= (FormaDesniGlavni.F22 + 1)) ||
                            (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FK2_2 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FK2_2 <= (FormaDesniGlavni.F23 + 1)))
                        {
                            button_FKx1.Visible = button_FKx1.Enabled = true;
                            textBox_FK2_2.BackColor = textBox_FK2_2.BackColor;
                            textBox_FK2_2.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBox_FK2_2.BackColor = textBox_FK2_2.BackColor;
                            textBox_FK2_2.ForeColor = Color.Gray;
                        }
                        //////////////////////////////////////////////////////////
                        textBox_FK2_2x2.Text = FormaDesniGlavni.FK2_2x2.ToString();
                        if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FK2_2x2 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FK2_2x2 <= (FormaDesniGlavni.F21 + 1)) ||
                            (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FK2_2x2 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FK2_2x2 <= (FormaDesniGlavni.F22 + 1)) ||
                            (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FK2_2x2 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FK2_2x2 <= (FormaDesniGlavni.F23 + 1)))
                        {
                            button_FKx2.Visible = button_FKx2.Enabled = true;
                            textBox_FK2_2x2.BackColor = textBox_FK2_2x2.BackColor;
                            textBox_FK2_2x2.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBox_FK2_2x2.BackColor = textBox_FK2_2x2.BackColor;
                            textBox_FK2_2x2.ForeColor = Color.Gray;
                        }
                        //////////////////////////////////////////////////////////
                        textBox_FK2_2x3.Text = FormaDesniGlavni.FK2_2x3.ToString();
                        if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FK2_2x3 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FK2_2x3 <= (FormaDesniGlavni.F21 + 1)) ||
                            (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FK2_2x3 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FK2_2x3 <= (FormaDesniGlavni.F22 + 1)) ||
                            (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FK2_2x3 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FK2_2x3 <= (FormaDesniGlavni.F23 + 1)))
                        {
                            button_FKx3.Visible = button_FKx3.Enabled = true;
                            textBox_FK2_2x3.BackColor = textBox_FK2_2x3.BackColor;
                            textBox_FK2_2x3.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBox_FK2_2x3.BackColor = textBox_FK2_2x3.BackColor;
                            textBox_FK2_2x3.ForeColor = Color.Gray;
                        }
                        //////////////////////////////////////////////////////////
                        textBox_FK2_2x4.Text = FormaDesniGlavni.FK2_2x4.ToString();
                        if ((FormaDesniGlavni.F21 != 0 && FormaDesniGlavni.FK2_2x4 >= (FormaDesniGlavni.F21 - 1) && FormaDesniGlavni.FK2_2x4 <= (FormaDesniGlavni.F21 + 1)) ||
                            (FormaDesniGlavni.F22 != 0 && FormaDesniGlavni.FK2_2x4 >= (FormaDesniGlavni.F22 - 1) && FormaDesniGlavni.FK2_2x4 <= (FormaDesniGlavni.F22 + 1)) ||
                            (FormaDesniGlavni.F23 != 0 && FormaDesniGlavni.FK2_2x4 >= (FormaDesniGlavni.F23 - 1) && FormaDesniGlavni.FK2_2x4 <= (FormaDesniGlavni.F23 + 1)))
                        {
                            button_FKx4.Visible = button_FKx4.Enabled = true;
                            textBox_FK2_2x4.BackColor = textBox_FK2_2x4.BackColor;
                            textBox_FK2_2x4.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBox_FK2_2x4.BackColor = textBox_FK2_2x4.BackColor;
                            textBox_FK2_2x4.ForeColor = Color.Gray;
                        }
                        //////////////////////////////////////////////////////////
                    }
                    //////////////////////////////////////////////////////////
                }

                #endregion

                #region v3unet

                if (FormaDesniGlavni.V3Unet)
                {
                    //////////////////////////////////////////////////////////
                    textBox_V3.Text = FormaDesniGlavni.V3.ToString();
                    if (FormaDesniGlavni.F31 != 0) textBox_F31.Text = FormaDesniGlavni.F31.ToString();
                    if (FormaDesniGlavni.F32 != 0) textBox_F32.Text = FormaDesniGlavni.F32.ToString();
                    if (FormaDesniGlavni.F33 != 0) textBox_F33.Text = FormaDesniGlavni.F33.ToString();
                    //////////////////////////////////////////////////////////
                    textBox_FT2_3.Text = FormaDesniGlavni.FT2_3.ToString();
                    if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FT2_3 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FT2_3 <= (FormaDesniGlavni.F31 + 1)) ||
                        (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FT2_3 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FT2_3 <= (FormaDesniGlavni.F32 + 1)) ||
                        (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FT2_3 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FT2_3 <= (FormaDesniGlavni.F33 + 1)))
                    {
                        button_FTx1.Visible = button_FTx1.Enabled = true;
                        textBox_FT2_3.BackColor = textBox_FT2_3.BackColor;
                        textBox_FT2_3.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FT2_3.BackColor = textBox_FT2_3.BackColor;
                        textBox_FT2_3.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FT2_3x2.Text = FormaDesniGlavni.FT2_3x2.ToString();
                    if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FT2_3x2 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FT2_3x2 <= (FormaDesniGlavni.F31 + 1)) ||
                        (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FT2_3x2 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FT2_3x2 <= (FormaDesniGlavni.F32 + 1)) ||
                        (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FT2_3x2 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FT2_3x2 <= (FormaDesniGlavni.F33 + 1)))
                    {
                        button_FTx2.Visible = button_FTx2.Enabled = true;
                        textBox_FT2_3x2.BackColor = textBox_FT2_3x2.BackColor;
                        textBox_FT2_3x2.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FT2_3x2.BackColor = textBox_FT2_3x2.BackColor;
                        textBox_FT2_3x2.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FT2_3x3.Text = FormaDesniGlavni.FT2_3x3.ToString();
                    if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FT2_3x3 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FT2_3x3 <= (FormaDesniGlavni.F31 + 1)) ||
                        (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FT2_3x3 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FT2_3x3 <= (FormaDesniGlavni.F32 + 1)) ||
                        (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FT2_3x3 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FT2_3x3 <= (FormaDesniGlavni.F33 + 1)))
                    {
                        button_FTx3.Visible = button_FTx3.Enabled = true;
                        textBox_FT2_3x3.BackColor = textBox_FT2_3x3.BackColor;
                        textBox_FT2_3x3.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FT2_3x3.BackColor = textBox_FT2_3x3.BackColor;
                        textBox_FT2_3x3.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    textBox_FT2_3x4.Text = FormaDesniGlavni.FT2_3x4.ToString();
                    if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FT2_3x4 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FT2_3x4 <= (FormaDesniGlavni.F31 + 1)) ||
                        (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FT2_3x4 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FT2_3x4 <= (FormaDesniGlavni.F32 + 1)) ||
                        (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FT2_3x4 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FT2_3x4 <= (FormaDesniGlavni.F33 + 1)))
                    {
                        button_FTx4.Visible = button_FTx4.Enabled = true;
                        textBox_FT2_3x4.BackColor = textBox_FT2_3x4.BackColor;
                        textBox_FT2_3x4.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox_FT2_3x4.BackColor = textBox_FT2_3x4.BackColor;
                        textBox_FT2_3x4.ForeColor = Color.Gray;
                    }
                    //////////////////////////////////////////////////////////
                    if (FormaDesniGlavni.I != 0)
                    {
                        //////////////////////////////////////////////////////////
                        textBox_FK2_3.Text = FormaDesniGlavni.FK2_3.ToString();
                        if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FK2_3 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FK2_3 <= (FormaDesniGlavni.F31 + 1)) ||
                            (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FK2_3 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FK2_3 <= (FormaDesniGlavni.F32 + 1)) ||
                            (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FK2_3 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FK2_3 <= (FormaDesniGlavni.F33 + 1)))
                        {
                            button_FKx1.Visible = button_FKx1.Enabled = true;
                            textBox_FK2_3.BackColor = textBox_FK2_3.BackColor;
                            textBox_FK2_3.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBox_FK2_3.BackColor = textBox_FK2_3.BackColor;
                            textBox_FK2_3.ForeColor = Color.Gray;
                        }
                        //////////////////////////////////////////////////////////
                        textBox_FK2_3x2.Text = FormaDesniGlavni.FK2_3x2.ToString();
                        if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FK2_3x2 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FK2_3x2 <= (FormaDesniGlavni.F31 + 1)) ||
                            (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FK2_3x2 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FK2_3x2 <= (FormaDesniGlavni.F32 + 1)) ||
                            (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FK2_3x2 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FK2_3x2 <= (FormaDesniGlavni.F33 + 1)))
                        {
                            button_FKx2.Visible = button_FKx2.Enabled = true;
                            textBox_FK2_3x2.BackColor = textBox_FK2_3x2.BackColor;
                            textBox_FK2_3x2.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBox_FK2_3x2.BackColor = textBox_FK2_3x2.BackColor;
                            textBox_FK2_3x2.ForeColor = Color.Gray;
                        }
                        //////////////////////////////////////////////////////////
                        textBox_FK2_3x3.Text = FormaDesniGlavni.FK2_3x3.ToString();
                        if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FK2_3x3 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FK2_3x3 <= (FormaDesniGlavni.F31 + 1)) ||
                            (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FK2_3x3 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FK2_3x3 <= (FormaDesniGlavni.F32 + 1)) ||
                            (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FK2_3x3 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FK2_3x3 <= (FormaDesniGlavni.F33 + 1)))
                        {
                            button_FKx3.Visible = button_FKx3.Enabled = true;
                            textBox_FK2_3x3.BackColor = textBox_FK2_3x3.BackColor;
                            textBox_FK2_3x3.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBox_FK2_3x3.BackColor = textBox_FK2_3x3.BackColor;
                            textBox_FK2_3x3.ForeColor = Color.Gray;
                        }
                        //////////////////////////////////////////////////////////
                        textBox_FK2_3x4.Text = FormaDesniGlavni.FK2_3x4.ToString();
                        if ((FormaDesniGlavni.F31 != 0 && FormaDesniGlavni.FK2_3x4 >= (FormaDesniGlavni.F31 - 1) && FormaDesniGlavni.FK2_3x4 <= (FormaDesniGlavni.F31 + 1)) ||
                            (FormaDesniGlavni.F32 != 0 && FormaDesniGlavni.FK2_3x4 >= (FormaDesniGlavni.F32 - 1) && FormaDesniGlavni.FK2_3x4 <= (FormaDesniGlavni.F32 + 1)) ||
                            (FormaDesniGlavni.F33 != 0 && FormaDesniGlavni.FK2_3x4 >= (FormaDesniGlavni.F33 - 1) && FormaDesniGlavni.FK2_3x4 <= (FormaDesniGlavni.F33 + 1)))
                        {
                            button_FKx4.Visible = button_FKx4.Enabled = true;
                            textBox_FK2_3x4.BackColor = textBox_FK2_3x4.BackColor;
                            textBox_FK2_3x4.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBox_FK2_3x4.BackColor = textBox_FK2_3x4.BackColor;
                            textBox_FK2_3x4.ForeColor = Color.Gray;
                        }
                        //////////////////////////////////////////////////////////
                    }
                    //////////////////////////////////////////////////////////
                }

                #endregion
            }
            else
            {
                label_FT2.Enabled     = label_FT2.Visible =
                    label_FK2.Enabled = label_FK2.Visible =

                    textBox_FT2_1.Enabled   = textBox_FT2_1.Visible   =
                    textBox_FT2_1x2.Enabled = textBox_FT2_1x2.Visible =
                    textBox_FT2_1x3.Enabled = textBox_FT2_1x3.Visible =
                    textBox_FT2_1x4.Enabled = textBox_FT2_1x4.Visible =
                    textBox_FK2_1.Enabled   = textBox_FK2_1.Visible   =
                    textBox_FK2_1x2.Enabled = textBox_FK2_1x2.Visible =
                    textBox_FK2_1x3.Enabled = textBox_FK2_1x3.Visible =
                    textBox_FK2_1x4.Enabled = textBox_FK2_1x4.Visible =

                    textBox_FT2_2.Enabled   = textBox_FT2_2.Visible   =
                    textBox_FT2_2x2.Enabled = textBox_FT2_2x2.Visible =
                    textBox_FT2_2x3.Enabled = textBox_FT2_2x3.Visible =
                    textBox_FT2_2x4.Enabled = textBox_FT2_2x4.Visible =
                    textBox_FK2_2.Enabled   = textBox_FK2_2.Visible   =
                    textBox_FK2_2x2.Enabled = textBox_FK2_2x2.Visible =
                    textBox_FK2_2x3.Enabled = textBox_FK2_2x3.Visible =
                    textBox_FK2_2x4.Enabled = textBox_FK2_2x4.Visible =

                    textBox_FT2_3.Enabled   = textBox_FT2_3.Visible   =
                    textBox_FT2_3x2.Enabled = textBox_FT2_3x2.Visible =
                    textBox_FT2_3x3.Enabled = textBox_FT2_3x3.Visible =
                    textBox_FT2_3x4.Enabled = textBox_FT2_3x4.Visible =
                    textBox_FK2_3.Enabled   = textBox_FK2_3.Visible   =
                    textBox_FK2_3x2.Enabled = textBox_FK2_3x2.Visible =
                    textBox_FK2_3x3.Enabled = textBox_FK2_3x3.Visible =
                    textBox_FK2_3x4.Enabled = textBox_FK2_3x4.Visible = false;

                this.Size = new Size(510, 525);

                button_FTx1.Location = new Point(466, 75);
                button_FTx2.Location = new Point(466, 108);
                button_FTx3.Location = new Point(466, 141);
                button_FTx4.Location = new Point(466, 174);

                button_FKx1.Location = new Point(466, 240);
                button_FKx2.Location = new Point(466, 273);
                button_FKx3.Location = new Point(466, 306);
                button_FKx4.Location = new Point(466, 339);
            }

            #endregion
        }

        private void otvoriTekstTocak(object sender, EventArgs e)
        {
            if (FormaDesniGlavni.FormaDesniTekstTocak == null)
            {
                FormaDesniGlavni.FormaDesniTekstTocak = new Forma_Desni_Tekst_Tocak(FormaDesniGlavni);
                FormaDesniGlavni.FormaDesniTekstTocak.Owner = FormaDesniGlavni;
                FormaDesniGlavni.FormaDesniTekstTocak.Show();
            }
            else
            {
                FormaDesniGlavni.FormaDesniTekstTocak.PanelScrollPos = new Point(0, 0);
                FormaDesniGlavni.FormaDesniTekstTocak.WindowState = FormWindowState.Normal;
                FormaDesniGlavni.FormaDesniTekstTocak.Focus();
            }
        }

        private void otvoriTekstDriveline(object sender, EventArgs e)
        {
            if (FormaDesniGlavni.FormaDesniTekstDriveline == null)
            {
                FormaDesniGlavni.FormaDesniTekstDriveline = new Forma_Desni_Tekst_Driveline(FormaDesniGlavni);
                FormaDesniGlavni.FormaDesniTekstDriveline.Owner = FormaDesniGlavni;
                FormaDesniGlavni.FormaDesniTekstDriveline.Show();
            }
            else
            {
                FormaDesniGlavni.FormaDesniTekstDriveline.PanelScrollPos = new Point(0, 0);
                FormaDesniGlavni.FormaDesniTekstDriveline.WindowState = FormWindowState.Normal;
                FormaDesniGlavni.FormaDesniTekstDriveline.Focus();
            }
        }

#pragma warning restore IDE1006
    }
}
