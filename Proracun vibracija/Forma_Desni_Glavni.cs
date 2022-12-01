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
    public partial class Forma_Desni_Glavni : Form
    {
#pragma warning disable IDE1006

        public Forma_HomeScreen   FormaHomeScreen;
        public Forma_Desni_Tabela FormaDesniTabela;
        public Forma_Desni_Grafik FormaDesniGrafik;
        public Forma_Desni_Tekst_Driveline FormaDesniTekstDriveline;
        public Forma_Desni_Tekst_Tocak     FormaDesniTekstTocak;

        public Forma_Desni_Glavni(Forma_HomeScreen konstruktor)
        {
            InitializeComponent();
            FormaHomeScreen = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text                      = FormaHomeScreen.Jezik[112];
            label_Upozorenje.Text          = FormaHomeScreen.Jezik[113];
            label_DimenzijePneumatika.Text = FormaHomeScreen.Jezik[114];
            label_Sirina.Text              = FormaHomeScreen.Jezik[115];
            label_Visina.Text              = FormaHomeScreen.Jezik[116];
            label_PrecnikFelne.Text        = FormaHomeScreen.Jezik[117];
            label_POD.Text                 = FormaHomeScreen.Jezik[118];
            label_mm.Text                  = FormaHomeScreen.Jezik[119];
            label_Posto.Text               = FormaHomeScreen.Jezik[120];
            label_Inches.Text              = FormaHomeScreen.Jezik[121];
            label_IzmereneVrednosti.Text   = FormaHomeScreen.Jezik[122];
            label_BrzinaVozila.Text        = FormaHomeScreen.Jezik[123];
            label_Frekvencija.Text         = FormaHomeScreen.Jezik[124];
            button_Racun.Text              = FormaHomeScreen.Jezik[125];

            checkBox1.Text = FormaHomeScreen.Jezik[184];
            label_Sirina2.Text = FormaHomeScreen.Jezik[185];
            label_Visina2.Text = FormaHomeScreen.Jezik[186];
            label_PrecnikFelne2.Text = FormaHomeScreen.Jezik[187];
            label_mm2.Text = FormaHomeScreen.Jezik[188];
            label_Posto2.Text = FormaHomeScreen.Jezik[189];
            label_Inches2.Text = FormaHomeScreen.Jezik[190];
        }

        private void Forma_Desni_Glavni_Load(object sender, EventArgs e)
        {
            /* FormaDesniTekstDriveline = new Forma_Desni_Tekst_Driveline(this);
            FormaDesniTekstDriveline.Owner = this;
            FormaDesniTekstDriveline.Show();
            //
            FormaDesniTekstTocak = new Forma_Desni_Tekst_Tocak(this);
            FormaDesniTekstTocak.Owner = this;
            FormaDesniTekstTocak.Show(); */

            PromenaJezika();
            this.Location = new Point(FormaHomeScreen.Left + 20, FormaHomeScreen.Top + 20);

            textBox_W_Watermark();
            textBox_H_Watermark();
            textBox_R_Watermark();

            textBox_W2_Watermark();
            textBox_H2_Watermark();
            textBox_R2_Watermark();

            textBox_I_Watermark();

            textBox_V1_Watermark();
            textBox_V2_Watermark();
            textBox_V3_Watermark();

            textBox_F11_Watermark();
            textBox_F12_Watermark();
            textBox_F13_Watermark();

            textBox_F21_Watermark();
            textBox_F22_Watermark();
            textBox_F23_Watermark();

            textBox_F31_Watermark();
            textBox_F32_Watermark();
            textBox_F33_Watermark();
        }

        private void Forma_Desni_Glavni_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaHomeScreen.FormaDesniGlavni  = null;
            FormaHomeScreen.DugmeDesnoEnabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label_Sirina2.Visible = label_Visina2.Visible = label_PrecnikFelne2.Visible =
                    label_mm2.Visible = label_Posto2.Visible = label_Inches2.Visible =
                    textBox_W2.Visible = textBox_H2.Visible = textBox_R2.Visible = checkBox1.Checked;

            /* if (checkBox1.Checked)
            {
                label_Sirina2.Visible = label_Visina2.Visible = label_PrecnikFelne2.Visible =
                    label_mm2.Visible = label_Posto2.Visible = label_Inches2.Visible =
                    textBox_W2.Visible = textBox_H2.Visible = textBox_R2.Visible = true;
                    textBox_W2.Enabled = textBox_H2.Enabled = textBox_R2.Enabled = true;
                if (textBox_W2.Text == "") textBox_W2_Watermark();
                if (textBox_H2.Text == "") textBox_H2_Watermark();
                if (textBox_R2.Text == "") textBox_R2_Watermark();
            }
            else
            {
                label_Sirina2.Visible = label_Visina2.Visible = label_PrecnikFelne2.Visible =
                    label_mm2.Visible = label_Posto2.Visible = label_Inches2.Visible =
                    textBox_W2.Visible = textBox_H2.Visible = textBox_R2.Visible = false;
                    textBox_W2.Enabled = textBox_H2.Enabled = textBox_R2.Enabled = false;
                if (textBox_W2.Text == "W2") textBox_W2.Text = "";
                if (textBox_H2.Text == "H2") textBox_H2.Text = "";
                if (textBox_R2.Text == "R2") textBox_R2.Text = "";
            } */
        }

        #region text box sranja

        private void textBox_W_Enter(object sender, EventArgs e)
        {
            if (textBox_W.ForeColor == Color.Black)
                return;
            textBox_W.Text = "";
            textBox_W.ForeColor = Color.Black;
        }

        private void textBox_W_Leave(object sender, EventArgs e)
        {
            if (textBox_W.Text.Trim() == "") textBox_W_Watermark();
        }

        private void textBox_W_Watermark()
        {
            this.textBox_W.Text = "W";
            textBox_W.ForeColor = Color.Gray;
        }



        private void textBox_H_Enter(object sender, EventArgs e)
        {
            if (textBox_H.ForeColor == Color.Black)
                return;
            textBox_H.Text = "";
            textBox_H.ForeColor = Color.Black;
        }

        private void textBox_H_Leave(object sender, EventArgs e)
        {
            if (textBox_H.Text.Trim() == "") textBox_H_Watermark();
        }

        private void textBox_H_Watermark()
        {
            this.textBox_H.Text = "H";
            textBox_H.ForeColor = Color.Gray;
        }



        private void textBox_R_Enter(object sender, EventArgs e)
        {
            if (textBox_R.ForeColor == Color.Black)
                return;
            textBox_R.Text = "";
            textBox_R.ForeColor = Color.Black;
        }

        private void textBox_R_Leave(object sender, EventArgs e)
        {
            if (textBox_R.Text.Trim() == "") textBox_R_Watermark();
        }

        private void textBox_R_Watermark()
        {
            this.textBox_R.Text = "R";
            textBox_R.ForeColor = Color.Gray;
        }



        #region AAAAAAAA
        private void textBox_W2_Enter(object sender, EventArgs e)
        {
            if (textBox_W2.ForeColor == Color.Black)
                return;
            textBox_W2.Text = "";
            textBox_W2.ForeColor = Color.Black;
        }

        private void textBox_W2_Leave(object sender, EventArgs e)
        {
            if (textBox_W2.Text.Trim() == "") textBox_W2_Watermark();
        }

        private void textBox_W2_Watermark()
        {
            this.textBox_W2.Text = "W2";
            textBox_W2.ForeColor = Color.Gray;
        }



        private void textBox_H2_Enter(object sender, EventArgs e)
        {
            if (textBox_H2.ForeColor == Color.Black)
                return;
            textBox_H2.Text = "";
            textBox_H2.ForeColor = Color.Black;
        }

        private void textBox_H2_Leave(object sender, EventArgs e)
        {
            if (textBox_H2.Text.Trim() == "") textBox_H2_Watermark();
        }

        private void textBox_H2_Watermark()
        {
            this.textBox_H2.Text = "H2";
            textBox_H2.ForeColor = Color.Gray;
        }



        private void textBox_R2_Enter(object sender, EventArgs e)
        {
            if (textBox_R2.ForeColor == Color.Black)
                return;
            textBox_R2.Text = "";
            textBox_R2.ForeColor = Color.Black;
        }

        private void textBox_R2_Leave(object sender, EventArgs e)
        {
            if (textBox_R2.Text.Trim() == "") textBox_R2_Watermark();
        }

        private void textBox_R2_Watermark()
        {
            this.textBox_R2.Text = "R2";
            textBox_R2.ForeColor = Color.Gray;
        }
        #endregion



        private void textBox_I_Enter(object sender, EventArgs e)
        {
            if (textBox_I.ForeColor == Color.Black)
                return;
            textBox_I.Text = "";
            textBox_I.ForeColor = Color.Black;
        }

        private void textBox_I_Leave(object sender, EventArgs e)
        {
            if (textBox_I.Text.Trim() == "") textBox_I_Watermark();
        }

        private void textBox_I_Watermark()
        {
            this.textBox_I.Text = "I";
            textBox_I.ForeColor = Color.Gray;
        }



        private void textBox_V1_Enter(object sender, EventArgs e)
        {
            if (textBox_V1.ForeColor == Color.Black)
                return;
            textBox_V1.Text = "";
            textBox_V1.ForeColor = Color.Black;
        }

        private void textBox_V1_Leave(object sender, EventArgs e)
        {
            if (textBox_V1.Text.Trim() == "") textBox_V1_Watermark();
        }

        private void textBox_V1_Watermark()
        {
            this.textBox_V1.Text = "V1";
            textBox_V1.ForeColor = Color.Gray;
        }



        private void textBox_V2_Enter(object sender, EventArgs e)
        {
            if (textBox_V2.ForeColor == Color.Black)
                return;
            textBox_V2.Text = "";
            textBox_V2.ForeColor = Color.Black;
        }

        private void textBox_V2_Leave(object sender, EventArgs e)
        {
            if (textBox_V2.Text.Trim() == "") textBox_V2_Watermark();
        }

        private void textBox_V2_Watermark()
        {
            this.textBox_V2.Text = "V2";
            textBox_V2.ForeColor = Color.Gray;
        }



        private void textBox_V3_Enter(object sender, EventArgs e)
        {
            if (textBox_V3.ForeColor == Color.Black)
                return;
            textBox_V3.Text = "";
            textBox_V3.ForeColor = Color.Black;
        }

        private void textBox_V3_Leave(object sender, EventArgs e)
        {
            if (textBox_V3.Text.Trim() == "") textBox_V3_Watermark();
        }

        private void textBox_V3_Watermark()
        {
            this.textBox_V3.Text = "V3";
            textBox_V3.ForeColor = Color.Gray;
        }



        private void textBox_F11_Enter(object sender, EventArgs e)
        {
            if (textBox_F11.ForeColor == Color.Black)
                return;
            textBox_F11.Text = "";
            textBox_F11.ForeColor = Color.Black;
        }

        private void textBox_F11_Leave(object sender, EventArgs e)
        {
            if (textBox_F11.Text.Trim() == "") textBox_F11_Watermark();
        }

        private void textBox_F11_Watermark()
        {
            this.textBox_F11.Text = "F11";
            textBox_F11.ForeColor = Color.Gray;
        }



        private void textBox_F12_Enter(object sender, EventArgs e)
        {
            if (textBox_F12.ForeColor == Color.Black)
                return;
            textBox_F12.Text = "";
            textBox_F12.ForeColor = Color.Black;
        }

        private void textBox_F12_Leave(object sender, EventArgs e)
        {
            if (textBox_F12.Text.Trim() == "") textBox_F12_Watermark();
        }

        private void textBox_F12_Watermark()
        {
            this.textBox_F12.Text = "F12";
            textBox_F12.ForeColor = Color.Gray;
        }



        private void textBox_F13_Enter(object sender, EventArgs e)
        {
            if (textBox_F13.ForeColor == Color.Black)
                return;
            textBox_F13.Text = "";
            textBox_F13.ForeColor = Color.Black;
        }

        private void textBox_F13_Leave(object sender, EventArgs e)
        {
            if (textBox_F13.Text.Trim() == "") textBox_F13_Watermark();
        }

        private void textBox_F13_Watermark()
        {
            this.textBox_F13.Text = "F13";
            textBox_F13.ForeColor = Color.Gray;
        }



        private void textBox_F21_Enter(object sender, EventArgs e)
        {
            if (textBox_F21.ForeColor == Color.Black)
                return;
            textBox_F21.Text = "";
            textBox_F21.ForeColor = Color.Black;
        }

        private void textBox_F21_Leave(object sender, EventArgs e)
        {
            if (textBox_F21.Text.Trim() == "") textBox_F21_Watermark();
        }

        private void textBox_F21_Watermark()
        {
            this.textBox_F21.Text = "F21";
            textBox_F21.ForeColor = Color.Gray;
        }



        private void textBox_F22_Enter(object sender, EventArgs e)
        {
            if (textBox_F22.ForeColor == Color.Black)
                return;
            textBox_F22.Text = "";
            textBox_F22.ForeColor = Color.Black;
        }

        private void textBox_F22_Leave(object sender, EventArgs e)
        {
            if (textBox_F22.Text.Trim() == "") textBox_F22_Watermark();
        }

        private void textBox_F22_Watermark()
        {
            this.textBox_F22.Text = "F22";
            textBox_F22.ForeColor = Color.Gray;
        }



        private void textBox_F23_Enter(object sender, EventArgs e)
        {
            if (textBox_F23.ForeColor == Color.Black)
                return;
            textBox_F23.Text = "";
            textBox_F23.ForeColor = Color.Black;
        }

        private void textBox_F23_Leave(object sender, EventArgs e)
        {
            if (textBox_F23.Text.Trim() == "") textBox_F23_Watermark();
        }

        private void textBox_F23_Watermark()
        {
            this.textBox_F23.Text = "F23";
            textBox_F23.ForeColor = Color.Gray;
        }



        private void textBox_F31_Enter(object sender, EventArgs e)
        {
            if (textBox_F31.ForeColor == Color.Black)
                return;
            textBox_F31.Text = "";
            textBox_F31.ForeColor = Color.Black;
        }

        private void textBox_F31_Leave(object sender, EventArgs e)
        {
            if (textBox_F31.Text.Trim() == "") textBox_F31_Watermark();
        }

        private void textBox_F31_Watermark()
        {
            this.textBox_F31.Text = "F31";
            textBox_F31.ForeColor = Color.Gray;
        }



        private void textBox_F32_Enter(object sender, EventArgs e)
        {
            if (textBox_F32.ForeColor == Color.Black)
                return;
            textBox_F32.Text = "";
            textBox_F32.ForeColor = Color.Black;
        }

        private void textBox_F32_Leave(object sender, EventArgs e)
        {
            if (textBox_F32.Text.Trim() == "") textBox_F32_Watermark();
        }

        private void textBox_F32_Watermark()
        {
            this.textBox_F32.Text = "F32";
            textBox_F32.ForeColor = Color.Gray;
        }



        private void textBox_F33_Enter(object sender, EventArgs e)
        {
            if (textBox_F33.ForeColor == Color.Black)
                return;
            textBox_F33.Text = "";
            textBox_F33.ForeColor = Color.Black;
        }

        private void textBox_F33_Leave(object sender, EventArgs e)
        {
            if (textBox_F33.Text.Trim() == "") textBox_F33_Watermark();
        }

        private void textBox_F33_Watermark()
        {
            this.textBox_F33.Text = "F33";
            textBox_F33.ForeColor = Color.Gray;
        }

        #endregion

        #region matematika

        Boolean _v1unet, _v2unet, _v3unet;
        public Boolean V1Unet, V2Unet, V3Unet;
        Int32 _W, _H, _R;
        public Int32 W, H, R;
        Int32 _W2, _H2, _R2;
        public Int32 W2, H2, R2;
        Double _I,
                _V1,  _V2,  _V3,
                _F11, _F12, _F13,
                _F21, _F22, _F23,
                _F31, _F32, _F33;

        public Double I,
                        V1,  V2,  V3,
                        F11, F12, F13,
                        F21, F22, F23,
                        F31, F32, F33;
        public Double DT,
                        FT1,   FT2,   FT3,
                        FT1x2, FT2x2, FT3x2,
                        FT1x3, FT2x3, FT3x3,
                        FT1x4, FT2x4, FT3x4,
                        FK1,   FK2,   FK3,
                        FK1x2, FK2x2, FK3x2,
                        FK1x3, FK2x3, FK3x3,
                        FK1x4, FK2x4, FK3x4;
        public Double DT2,
                        FT2_1, FT2_2, FT2_3,
                        FT2_1x2, FT2_2x2, FT2_3x2,
                        FT2_1x3, FT2_2x3, FT2_3x3,
                        FT2_1x4, FT2_2x4, FT2_3x4,
                        FK2_1, FK2_2, FK2_3,
                        FK2_1x2, FK2_2x2, FK2_3x2,
                        FK2_1x3, FK2_2x3, FK2_3x3,
                        FK2_1x4, FK2_2x4, FK2_3x4;

        private void resetVrednosti()
        {
            errorProvider1.SetError(textBox_W, "");
            errorProvider1.SetError(textBox_H, "");
            errorProvider1.SetError(textBox_R, "");
            errorProvider1.SetError(textBox_W2, "");
            errorProvider1.SetError(textBox_H2, "");
            errorProvider1.SetError(textBox_R2, "");
            errorProvider1.SetError(textBox_I, "");
            errorProvider1.SetError(textBox_V1, "");
            errorProvider1.SetError(textBox_V2, "");
            errorProvider1.SetError(textBox_V3, "");
            errorProvider1.SetError(textBox_F11, "");
            errorProvider1.SetError(textBox_F12, "");
            errorProvider1.SetError(textBox_F13, "");
            errorProvider1.SetError(textBox_F21, "");
            errorProvider1.SetError(textBox_F22, "");
            errorProvider1.SetError(textBox_F23, "");
            errorProvider1.SetError(textBox_F31, "");
            errorProvider1.SetError(textBox_F32, "");
            errorProvider1.SetError(textBox_F33, "");

            if (label_mm.Location.X - textBox_W.Location.X == 68) label_mm.Location = new Point(label_mm.Location.X - 8, label_mm.Location.Y);
            if (label_Posto.Location.X - textBox_H.Location.X == 68) label_Posto.Location = new Point(label_Posto.Location.X - 8, label_Posto.Location.Y);
            if (label_Inches.Location.X - textBox_R.Location.X == 68) label_Inches.Location = new Point(label_Inches.Location.X - 8, label_Inches.Location.Y);
            if (label_mm2.Location.X - textBox_W2.Location.X == 68) label_mm2.Location = new Point(label_mm2.Location.X - 8, label_mm2.Location.Y);
            if (label_Posto2.Location.X - textBox_H2.Location.X == 68) label_Posto2.Location = new Point(label_Posto2.Location.X - 8, label_Posto2.Location.Y);
            if (label_Inches2.Location.X - textBox_R2.Location.X == 68) label_Inches2.Location = new Point(label_Inches2.Location.X - 8, label_Inches2.Location.Y);

            _v1unet = _v2unet = _v3unet = false;
            _W = _H = _R = _W2 = _H2 = _R2 = 0;
            _I = _V1 = _V2 = _V3 = _F11 = _F12 = _F13 = _F21 = _F22 = _F23 = _F31 = _F32 = _F33 = 0;
        }

        private Boolean provera()
        {
            if (textBox_W.Text == "W") return false;
            if (textBox_H.Text == "H") return false;
            if (textBox_R.Text == "R") return false;

            if (checkBox1.Checked)
            {
                if (textBox_W2.Text == "W2") return false;
                if (textBox_H2.Text == "H2") return false;
                if (textBox_R2.Text == "R2") return false;
            }

            if (textBox_V1.Text != "V1" && (textBox_F11.Text != "F11" || textBox_F12.Text != "F12" || textBox_F13.Text != "F13")) _v1unet = true;
            if (textBox_V2.Text != "V2" && (textBox_F21.Text != "F21" || textBox_F22.Text != "F22" || textBox_F23.Text != "F23")) _v2unet = true;
            if (textBox_V3.Text != "V3" && (textBox_F31.Text != "F31" || textBox_F32.Text != "F32" || textBox_F33.Text != "F33")) _v3unet = true;

            if (_v1unet || _v2unet || _v3unet) return true;
            else return false;
        }

        private Boolean ucitavanje()
        {
            Boolean uspeh = true;

            if (!Int32.TryParse(textBox_W.Text, out _W) || _W <= 0)
            {
                errorProvider1.SetError(textBox_W, FormaHomeScreen.Jezik[309]);
                if(label_mm.Location.X - textBox_W.Location.X == 60) label_mm.Location = new Point(label_mm.Location.X + 8, label_mm.Location.Y);
                uspeh = false;
            }

            if (!Int32.TryParse(textBox_H.Text, out _H) || _H <= 0)
            {
                errorProvider1.SetError(textBox_H, FormaHomeScreen.Jezik[309]);
                if (label_Posto.Location.X - textBox_H.Location.X == 60) label_Posto.Location = new Point(label_Posto.Location.X + 8, label_Posto.Location.Y);
                uspeh = false;
            }

            if (!Int32.TryParse(textBox_R.Text, out _R) || _R <= 0)
            {
                errorProvider1.SetError(textBox_R, FormaHomeScreen.Jezik[309]);
                if (label_Inches.Location.X - textBox_R.Location.X == 60) label_Inches.Location = new Point(label_Inches.Location.X + 8, label_Inches.Location.Y);
                uspeh = false;
            }

            if (checkBox1.Checked)
            {
                if (!Int32.TryParse(textBox_W2.Text, out _W2) || _W2 <= 0)
                {
                    errorProvider1.SetError(textBox_W2, FormaHomeScreen.Jezik[309]);
                    if (label_mm2.Location.X - textBox_W2.Location.X == 60) label_mm2.Location = new Point(label_mm2.Location.X + 8, label_mm2.Location.Y);
                    uspeh = false;
                }

                if (!Int32.TryParse(textBox_H2.Text, out _H2) || _H2 <= 0)
                {
                    errorProvider1.SetError(textBox_H2, FormaHomeScreen.Jezik[309]);
                    if (label_Posto2.Location.X - textBox_H2.Location.X == 60) label_Posto2.Location = new Point(label_Posto2.Location.X + 8, label_Posto2.Location.Y);
                    uspeh = false;
                }

                if (!Int32.TryParse(textBox_R2.Text, out _R2) || _R2 <= 0)
                {
                    errorProvider1.SetError(textBox_R2, FormaHomeScreen.Jezik[309]);
                    if (label_Inches2.Location.X - textBox_R2.Location.X == 60) label_Inches2.Location = new Point(label_Inches2.Location.X + 8, label_Inches2.Location.Y);
                    uspeh = false;
                }
            }

            if (textBox_I.Text != "I")
            {
                if (!Double.TryParse(textBox_I.Text, out _I) || _I <= 0)
                {
                    errorProvider1.SetError(textBox_I, FormaHomeScreen.Jezik[309]);
                    uspeh = false;
                }
            }

            if(_v1unet)
            {
                if (!Double.TryParse(textBox_V1.Text, out _V1) || _V1 < 5 || _V1 > 200)
                {
                    errorProvider1.SetError(textBox_V1, FormaHomeScreen.Jezik[310]);
                    uspeh = false;
                }

                if(textBox_F11.Text != "F11")
                {
                    if (!Double.TryParse(textBox_F11.Text, out _F11) || _F11 <= 0)
                    {
                        errorProvider1.SetError(textBox_F11, FormaHomeScreen.Jezik[309]);
                        uspeh = false;
                    }
                }
                if(textBox_F12.Text != "F12")
                {
                    if (!Double.TryParse(textBox_F12.Text, out _F12) || _F12 <= 0)
                    {
                        errorProvider1.SetError(textBox_F12, FormaHomeScreen.Jezik[309]);
                        uspeh = false;
                    }
                }
                if(textBox_F13.Text != "F13")
                {
                    if (!Double.TryParse(textBox_F13.Text, out _F13) || _F13 <= 0)
                    {
                        errorProvider1.SetError(textBox_F13, FormaHomeScreen.Jezik[309]);
                        uspeh = false;
                    }
                }
            }
            if (_v2unet)
            {
                if (!Double.TryParse(textBox_V2.Text, out _V2) || _V2 < 5 || _V2 > 200)
                {
                    errorProvider1.SetError(textBox_V2, FormaHomeScreen.Jezik[310]);
                    uspeh = false;
                }

                if (textBox_F21.Text != "F21")
                {
                    if (!Double.TryParse(textBox_F21.Text, out _F21) || _F21 <= 0)
                    {
                        errorProvider1.SetError(textBox_F21, FormaHomeScreen.Jezik[309]);
                        uspeh = false;
                    }
                }
                if (textBox_F22.Text != "F22")
                {
                    if (!Double.TryParse(textBox_F22.Text, out _F22) || _F22 <= 0)
                    {
                        errorProvider1.SetError(textBox_F22, FormaHomeScreen.Jezik[309]);
                        uspeh = false;
                    }
                }
                if (textBox_F23.Text != "F23")
                {
                    if (!Double.TryParse(textBox_F23.Text, out _F23) || _F23 <= 0)
                    {
                        errorProvider1.SetError(textBox_F23, FormaHomeScreen.Jezik[309]);
                        uspeh = false;
                    }
                }
            }
            if (_v3unet)
            {
                if (!Double.TryParse(textBox_V3.Text, out _V3) || _V3 < 5 || _V3 > 200)
                {
                    errorProvider1.SetError(textBox_V3, FormaHomeScreen.Jezik[310]);
                    uspeh = false;
                }

                if (textBox_F31.Text != "F31")
                {
                    if (!Double.TryParse(textBox_F31.Text, out _F31) || _F31 <= 0)
                    {
                        errorProvider1.SetError(textBox_F31, FormaHomeScreen.Jezik[309]);
                        uspeh = false;
                    }
                }
                if (textBox_F32.Text != "F32")
                {
                    if (!Double.TryParse(textBox_F32.Text, out _F32) || _F32 <= 0)
                    {
                        errorProvider1.SetError(textBox_F32, FormaHomeScreen.Jezik[309]);
                        uspeh = false;
                    }
                }
                if (textBox_F33.Text != "F33")
                {
                    if (!Double.TryParse(textBox_F33.Text, out _F33) || _F33 <= 0)
                    {
                        errorProvider1.SetError(textBox_F33, FormaHomeScreen.Jezik[309]);
                        uspeh = false;
                    }
                }
            }

            return uspeh;
        }

        private void konvertovanje()
        {
            V1Unet = _v1unet;
            V2Unet = _v2unet;
            V3Unet = _v3unet;
            W = _W;
            H = _H;
            R = _R;
            W2 = _W2;
            H2 = _H2;
            R2 = _R2;
            I = _I;
            V1 = _V1;
            V2 = _V2;
            V3 = _V3;
            F11 = _F11;
            F12 = _F12;
            F13 = _F13;
            F21 = _F21;
            F22 = _F22;
            F23 = _F23;
            F31 = _F31;
            F32 = _F32;
            F33 = _F33;
        }

        private void racun()
        {
            DT = (((Double)2 * H * W) / 2540) + R;

            if (V1Unet)
            {
                FT1   = (V1 / 8) * (((20800 / DT) * 5) / 3600);
                FT1x2 = FT1 * 2;
                FT1x3 = FT1 * 3;
                FT1x4 = FT1 * 4;
                if (I != 0)
                {
                    FK1   = FT1 * I;
                    FK1x2 = FK1 * 2;
                    FK1x3 = FK1 * 3;
                    FK1x4 = FK1 * 4;

                    FK1   = Math.Round(FK1,   1, MidpointRounding.AwayFromZero);
                    FK1x2 = Math.Round(FK1x2, 1, MidpointRounding.AwayFromZero);
                    FK1x3 = Math.Round(FK1x3, 1, MidpointRounding.AwayFromZero);
                    FK1x4 = Math.Round(FK1x4, 1, MidpointRounding.AwayFromZero);
                }

                FT1   = Math.Round(FT1,   1, MidpointRounding.AwayFromZero);
                FT1x2 = Math.Round(FT1x2, 1, MidpointRounding.AwayFromZero);
                FT1x3 = Math.Round(FT1x3, 1, MidpointRounding.AwayFromZero);
                FT1x4 = Math.Round(FT1x4, 1, MidpointRounding.AwayFromZero);
            }

            if (V2Unet)
            {
                FT2   = (V2 / 8) * (((20800 / DT) * 5) / 3600);
                FT2x2 = FT2 * 2;
                FT2x3 = FT2 * 3;
                FT2x4 = FT2 * 4;
                if (I != 0)
                {
                    FK2   = FT2 * I;
                    FK2x2 = FK2 * 2;
                    FK2x3 = FK2 * 3;
                    FK2x4 = FK2 * 4;

                    FK2   = Math.Round(FK2,   1, MidpointRounding.AwayFromZero);
                    FK2x2 = Math.Round(FK2x2, 1, MidpointRounding.AwayFromZero);
                    FK2x3 = Math.Round(FK2x3, 1, MidpointRounding.AwayFromZero);
                    FK2x4 = Math.Round(FK2x4, 1, MidpointRounding.AwayFromZero);
                }

                FT2   = Math.Round(FT2,   1, MidpointRounding.AwayFromZero);
                FT2x2 = Math.Round(FT2x2, 1, MidpointRounding.AwayFromZero);
                FT2x3 = Math.Round(FT2x3, 1, MidpointRounding.AwayFromZero);
                FT2x4 = Math.Round(FT2x4, 1, MidpointRounding.AwayFromZero);
            }

            if (V3Unet)
            {
                FT3   = (V3 / 8) * (((20800 / DT) * 5) / 3600);
                FT3x2 = FT3 * 2;
                FT3x3 = FT3 * 3;
                FT3x4 = FT3 * 4;
                if (I != 0)
                {
                    FK3   = FT3 * I;
                    FK3x2 = FK3 * 2;
                    FK3x3 = FK3 * 3;
                    FK3x4 = FK3 * 4;

                    FK3   = Math.Round(FK3,   1, MidpointRounding.AwayFromZero);
                    FK3x2 = Math.Round(FK3x2, 1, MidpointRounding.AwayFromZero);
                    FK3x3 = Math.Round(FK3x3, 1, MidpointRounding.AwayFromZero);
                    FK3x4 = Math.Round(FK3x4, 1, MidpointRounding.AwayFromZero);
                }

                FT3   = Math.Round(FT3,   1, MidpointRounding.AwayFromZero);
                FT3x2 = Math.Round(FT3x2, 1, MidpointRounding.AwayFromZero);
                FT3x3 = Math.Round(FT3x3, 1, MidpointRounding.AwayFromZero);
                FT3x4 = Math.Round(FT3x4, 1, MidpointRounding.AwayFromZero);
            }

            if (checkBox1.Checked)
            {
                DT2 = (((Double)2 * H2 * W2) / 2540) + R2;

                if (V1Unet)
                {
                    FT2_1   = (V1 / 8) * (((20800 / DT2) * 5) / 3600);
                    FT2_1x2 = FT2_1 * 2;
                    FT2_1x3 = FT2_1 * 3;
                    FT2_1x4 = FT2_1 * 4;
                    if (I != 0)
                    {
                        FK2_1   = FT2_1 * I;
                        FK2_1x2 = FK2_1 * 2;
                        FK2_1x3 = FK2_1 * 3;
                        FK2_1x4 = FK2_1 * 4;

                        FK2_1   = Math.Round(FK2_1,   1, MidpointRounding.AwayFromZero);
                        FK2_1x2 = Math.Round(FK2_1x2, 1, MidpointRounding.AwayFromZero);
                        FK2_1x3 = Math.Round(FK2_1x3, 1, MidpointRounding.AwayFromZero);
                        FK2_1x4 = Math.Round(FK2_1x4, 1, MidpointRounding.AwayFromZero);
                    }

                    FT2_1   = Math.Round(FT2_1,   1, MidpointRounding.AwayFromZero);
                    FT2_1x2 = Math.Round(FT2_1x2, 1, MidpointRounding.AwayFromZero);
                    FT2_1x3 = Math.Round(FT2_1x3, 1, MidpointRounding.AwayFromZero);
                    FT2_1x4 = Math.Round(FT2_1x4, 1, MidpointRounding.AwayFromZero);
                }

                if (V2Unet)
                {
                    FT2_2   = (V2 / 8) * (((20800 / DT2) * 5) / 3600);
                    FT2_2x2 = FT2_2 * 2;
                    FT2_2x3 = FT2_2 * 3;
                    FT2_2x4 = FT2_2 * 4;
                    if (I != 0)
                    {
                        FK2_2   = FT2_2 * I;
                        FK2_2x2 = FK2_2 * 2;
                        FK2_2x3 = FK2_2 * 3;
                        FK2_2x4 = FK2_2 * 4;

                        FK2_2   = Math.Round(FK2_2,   1, MidpointRounding.AwayFromZero);
                        FK2_2x2 = Math.Round(FK2_2x2, 1, MidpointRounding.AwayFromZero);
                        FK2_2x3 = Math.Round(FK2_2x3, 1, MidpointRounding.AwayFromZero);
                        FK2_2x4 = Math.Round(FK2_2x4, 1, MidpointRounding.AwayFromZero);
                    }

                    FT2_2   = Math.Round(FT2_2,   1, MidpointRounding.AwayFromZero);
                    FT2_2x2 = Math.Round(FT2_2x2, 1, MidpointRounding.AwayFromZero);
                    FT2_2x3 = Math.Round(FT2_2x3, 1, MidpointRounding.AwayFromZero);
                    FT2_2x4 = Math.Round(FT2_2x4, 1, MidpointRounding.AwayFromZero);
                }

                if (V3Unet)
                {
                    FT2_3   = (V3 / 8) * (((20800 / DT2) * 5) / 3600);
                    FT2_3x2 = FT2_3 * 2;
                    FT2_3x3 = FT2_3 * 3;
                    FT2_3x4 = FT2_3 * 4;
                    if (I != 0)
                    {
                        FK2_3   = FT2_3 * I;
                        FK2_3x2 = FK2_3 * 2;
                        FK2_3x3 = FK2_3 * 3;
                        FK2_3x4 = FK2_3 * 4;

                        FK2_3   = Math.Round(FK2_3,   1, MidpointRounding.AwayFromZero);
                        FK2_3x2 = Math.Round(FK2_3x2, 1, MidpointRounding.AwayFromZero);
                        FK2_3x3 = Math.Round(FK2_3x3, 1, MidpointRounding.AwayFromZero);
                        FK2_3x4 = Math.Round(FK2_3x4, 1, MidpointRounding.AwayFromZero);
                    }

                    FT2_3   = Math.Round(FT2_3,   1, MidpointRounding.AwayFromZero);
                    FT2_3x2 = Math.Round(FT2_3x2, 1, MidpointRounding.AwayFromZero);
                    FT2_3x3 = Math.Round(FT2_3x3, 1, MidpointRounding.AwayFromZero);
                    FT2_3x4 = Math.Round(FT2_3x4, 1, MidpointRounding.AwayFromZero);
                }
            }
        }

        #endregion

        private void button_Racun_Click(object sender, EventArgs e)
        {
            resetVrednosti();
            if (provera())
            {
                if (ucitavanje())
                {
                    konvertovanje();
                    racun();
                    if (FormaDesniTabela == null && FormaDesniGrafik == null) button_Tabela.Enabled = button_Grafik.Enabled = true;
                    if (FormaDesniTabela != null) FormaDesniTabela.IspisVrednosti();
                    if (FormaDesniGrafik != null) FormaDesniGrafik.Racun();
                }
                else MessageBox.Show(FormaHomeScreen.Jezik[127], FormaHomeScreen.Jezik[311], MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show(FormaHomeScreen.Jezik[126], FormaHomeScreen.Jezik[311], MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Tabela_Click(object sender, EventArgs e)
        {
            FormaDesniTabela = new Forma_Desni_Tabela(this);
            FormaDesniTabela.Owner = this;
            FormaDesniTabela.Show();

            button_Tabela.Enabled = false;
        }

        public Boolean ButtonTabelaEnabled
        {
            get { return button_Tabela.Enabled;  }
            set { button_Tabela.Enabled = value; }
        }

        private void button_Grafik_Click(object sender, EventArgs e)
        {
            FormaDesniGrafik = new Forma_Desni_Grafik(this);
            FormaDesniGrafik.Owner = this;
            FormaDesniGrafik.Show();

            button_Grafik.Enabled = false;
        }

        public Boolean ButtonGrafikEnabled
        {
            get { return button_Grafik.Enabled;  }
            set { button_Grafik.Enabled = value; }
        }

        /* public Boolean CheckBox1Checked
        {
            get { return checkBox1.Checked;  }
            set { checkBox1.Checked = value; }
        } */

#pragma warning restore IDE1006
    }
}
