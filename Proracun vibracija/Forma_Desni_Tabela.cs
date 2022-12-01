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
        public Forma_Desni_Glavni FormaDesniGlavni;

        public Forma_Desni_Tabela(Forma_Desni_Glavni konstruktor)
        {
            InitializeComponent();
            FormaDesniGlavni = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text               = FormaDesniGlavni.FormaHomeScreen.jezik[128];
            label_BrzinaVozila.Text = FormaDesniGlavni.FormaHomeScreen.jezik[129];
            label_FT.Text           = FormaDesniGlavni.FormaHomeScreen.jezik[130];
            label_FTx1.Text         = FormaDesniGlavni.FormaHomeScreen.jezik[131];
            label_FTx2.Text         = FormaDesniGlavni.FormaHomeScreen.jezik[132];
            label_FTx3.Text         = FormaDesniGlavni.FormaHomeScreen.jezik[133];
            label_FTx4.Text         = FormaDesniGlavni.FormaHomeScreen.jezik[134];
            label_FK.Text           = FormaDesniGlavni.FormaHomeScreen.jezik[135];
            label_FKx1.Text         = FormaDesniGlavni.FormaHomeScreen.jezik[136];
            label_FKx2.Text         = FormaDesniGlavni.FormaHomeScreen.jezik[137];
            label_FKx3.Text         = FormaDesniGlavni.FormaHomeScreen.jezik[138];
            label_FKx4.Text         = FormaDesniGlavni.FormaHomeScreen.jezik[139];
            label_IzmFrek.Text      = FormaDesniGlavni.FormaHomeScreen.jezik[140];
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
            FormaDesniGlavni.buttonTabelaEnabled = true;
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

            if (FormaDesniGlavni.v1unet)
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

            if (FormaDesniGlavni.v2unet)
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

            if (FormaDesniGlavni.v3unet)
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
        }

        #region dugmici sa znakom pitanja

        private void button_FTx1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[141]);
        }

        private void button_FTx2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[142]);
        }

        private void button_FTx3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[143]);
        }

        private void button_FTx4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[144]);
        }

        private void button_FKx1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[145]);
        }

        private void button_FKx2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[146]);
        }

        private void button_FKx3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[147]);
        }

        private void button_FKx4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormaDesniGlavni.FormaHomeScreen.jezik[148]);
        }

        #endregion
    }
}
