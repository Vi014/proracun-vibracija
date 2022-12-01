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
    public partial class Forma_Centar_Glavni : Form
    {
        public Forma_HomeScreen      FormaHomeScreen;
        public Forma_Centar_Tabela_1 FormaCentarTabela1;

        public Forma_Centar_Glavni(Forma_HomeScreen konstruktor)
        {
            InitializeComponent();
            FormaHomeScreen = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text                = FormaHomeScreen.jezik[5];
            label_UnosPodataka.Text  = FormaHomeScreen.jezik[6];
            label_RPM.Text           = FormaHomeScreen.jezik[7];
            label_IzmFrek.Text       = FormaHomeScreen.jezik[8];
            label_BrojCilindara.Text = FormaHomeScreen.jezik[9];
            button3.Text             = FormaHomeScreen.jezik[10];
            label_Upozorenje.Text    = FormaHomeScreen.jezik[13];
        }

        private void Forma_Centar_Glavni_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(FormaHomeScreen.Right, FormaHomeScreen.Bottom);

            textBox_RPM1_Watermark();
            textBox_RPM2_Watermark();
            textBox_RPM3_Watermark();

            textBox_F11_Watermark();
            textBox_F12_Watermark();
            textBox_F13_Watermark();

            textBox_F21_Watermark();
            textBox_F22_Watermark();
            textBox_F23_Watermark();

            textBox_F31_Watermark();
            textBox_F32_Watermark();
            textBox_F33_Watermark();

            comboBox_BrojCilindara.SelectedIndex = 0;
        }

        private void Forma_Centar_Glavni_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaHomeScreen.FormaCentarGlavni  = null;
            FormaHomeScreen.dugmeCentarEnabled = true;
        }

        #region text box sranja

        private void textBox_RPM1_Enter(object sender, EventArgs e)
        {
            if (textBox_RPM1.ForeColor == Color.Black)
                return;
            textBox_RPM1.Text = "";
            textBox_RPM1.ForeColor = Color.Black;
        }

        private void textBox_RPM1_Leave(object sender, EventArgs e)
        {
            if (textBox_RPM1.Text.Trim() == "") textBox_RPM1_Watermark();
        }

        private void textBox_RPM1_Watermark()
        {
            this.textBox_RPM1.Text = "RPM1";
            textBox_RPM1.ForeColor = Color.Gray;
        }



        private void textBox_RPM2_Enter(object sender, EventArgs e)
        {
            if (textBox_RPM2.ForeColor == Color.Black)
                return;
            textBox_RPM2.Text = "";
            textBox_RPM2.ForeColor = Color.Black;
        }

        private void textBox_RPM2_Leave(object sender, EventArgs e)
        {
            if (textBox_RPM2.Text.Trim() == "") textBox_RPM2_Watermark();
        }

        private void textBox_RPM2_Watermark()
        {
            this.textBox_RPM2.Text = "RPM2";
            textBox_RPM2.ForeColor = Color.Gray;
        }



        private void textBox_RPM3_Enter(object sender, EventArgs e)
        {
            if (textBox_RPM3.ForeColor == Color.Black)
                return;
            textBox_RPM3.Text = "";
            textBox_RPM3.ForeColor = Color.Black;
        }

        private void textBox_RPM3_Leave(object sender, EventArgs e)
        {
            if (textBox_RPM3.Text.Trim() == "") textBox_RPM3_Watermark();
        }

        private void textBox_RPM3_Watermark()
        {
            this.textBox_RPM3.Text = "RPM3";
            textBox_RPM3.ForeColor = Color.Gray;
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

        public Boolean rpm1unet, rpm2unet, rpm3unet, unosUspesan;
        public Int32 brojCilindara;
        public Double  RPM1, RPM2, RPM3,
                        F11, F12, F13,
                        F21, F22, F23,
                        F31, F32, F33,
                        FM1, FM12, FM13, FM14, FB1, FP1,
                        FM2, FM22, FM23, FM24, FB2, FP2,
                        FM3, FM32, FM33, FM34, FB3, FP3;

        private void ResetVrednosti()
        {
            rpm1unet = rpm2unet = rpm3unet = unosUspesan = button1.Enabled = button2.Enabled = false;
            brojCilindara = 0;
            RPM1 = RPM2 = RPM3 = F11 = F12 = F13 = F21 = F22 = F23 = F31 = F32 = F33 = 0; // Double cija je vrednost null zapravo ima vrednost 0 tako da je ovo OK.
        }

        private Boolean Provera()
        {
            if (textBox_RPM1.Text != "RPM1" && textBox_RPM1.Text != "0")
                if ((textBox_F11.Text != "F11" && textBox_F11.Text != "0") || (textBox_F12.Text != "F12" && textBox_F12.Text != "0") || (textBox_F13.Text != "F13" && textBox_F13.Text != "0")) rpm1unet = true;
                else rpm1unet = false;
            if (textBox_RPM2.Text != "RPM2" && textBox_RPM2.Text != "0")
                if ((textBox_F21.Text != "F21" && textBox_F21.Text != "0") || (textBox_F22.Text != "F22" && textBox_F22.Text != "0") || (textBox_F23.Text != "F23" && textBox_F23.Text != "0")) rpm2unet = true;
                else rpm2unet = false;
            if (textBox_RPM3.Text != "RPM3" && textBox_RPM3.Text != "0")
                if ((textBox_F31.Text != "F31" && textBox_F31.Text != "0") || (textBox_F32.Text != "F32" && textBox_F32.Text != "0") || (textBox_F33.Text != "F33" && textBox_F33.Text != "0")) rpm3unet = true;
                else rpm3unet = false;

            if (rpm1unet || rpm2unet || rpm3unet) return true;
            else return false;
        }

        private Boolean Ucitavanje()
        {
            brojCilindara = Convert.ToInt32(comboBox_BrojCilindara.Text); // radi kako treba

            if (rpm1unet)
            {
                if (!Double.TryParse(textBox_RPM1.Text, out RPM1)) return false;
                if (textBox_F11.Text != "F11" && !Double.TryParse(textBox_F11.Text, out F11)) return false;
                if (textBox_F12.Text != "F12" && !Double.TryParse(textBox_F12.Text, out F12)) return false;
                if (textBox_F13.Text != "F13" && !Double.TryParse(textBox_F13.Text, out F13)) return false;
            }
            if (rpm2unet)
            {
                if (!Double.TryParse(textBox_RPM2.Text, out RPM2)) return false;
                if (textBox_F21.Text != "F21" && !Double.TryParse(textBox_F21.Text, out F21)) return false;
                if (textBox_F22.Text != "F22" && !Double.TryParse(textBox_F22.Text, out F22)) return false;
                if (textBox_F23.Text != "F23" && !Double.TryParse(textBox_F23.Text, out F23)) return false;
            }
            if (rpm3unet)
            {
                if (!Double.TryParse(textBox_RPM3.Text, out RPM3)) return false;
                if (textBox_F31.Text != "F31" && !Double.TryParse(textBox_F31.Text, out F31)) return false;
                if (textBox_F32.Text != "F32" && !Double.TryParse(textBox_F32.Text, out F32)) return false;
                if (textBox_F33.Text != "F33" && !Double.TryParse(textBox_F33.Text, out F33)) return false;
                //if (textBox_F33.Text != "F33") if (!Double.TryParse(textBox_F33.Text, out F33)) return false;
            }

            return true;
        }

        private void Racun()
        {
            if (rpm1unet)
            {
                FM1  = Math.Round((RPM1 / 60),                 1, MidpointRounding.AwayFromZero);
                FM12 = Math.Round((FM1 * 2),                   1, MidpointRounding.AwayFromZero);
                FM13 = Math.Round((FM1 * 3),                   1, MidpointRounding.AwayFromZero);
                FM14 = Math.Round((FM1 * 4),                   1, MidpointRounding.AwayFromZero);
                FB1  = Math.Round((FM1 / 2),                   1, MidpointRounding.AwayFromZero);
                FP1  = Math.Round((0.5 * FM1 * brojCilindara), 1, MidpointRounding.AwayFromZero);
            }
            if (rpm2unet)
            {
                FM2  = Math.Round((RPM2 / 60),                 1, MidpointRounding.AwayFromZero);
                FM22 = Math.Round((FM2 * 2),                   1, MidpointRounding.AwayFromZero);
                FM23 = Math.Round((FM2 * 3),                   1, MidpointRounding.AwayFromZero);
                FM24 = Math.Round((FM2 * 4),                   1, MidpointRounding.AwayFromZero);
                FB2  = Math.Round((FM2 / 2),                   1, MidpointRounding.AwayFromZero);
                FP2  = Math.Round((0.5 * FM2 * brojCilindara), 1, MidpointRounding.AwayFromZero);
            }
            if (rpm3unet)
            {
                FM3  = Math.Round((RPM3 / 60),                 1, MidpointRounding.AwayFromZero);
                FM32 = Math.Round((FM3 * 2),                   1, MidpointRounding.AwayFromZero);
                FM33 = Math.Round((FM3 * 3),                   1, MidpointRounding.AwayFromZero);
                FM34 = Math.Round((FM3 * 4),                   1, MidpointRounding.AwayFromZero);
                FB3  = Math.Round((FM3 / 2),                   1, MidpointRounding.AwayFromZero);
                FP3  = Math.Round((0.5 * FM3 * brojCilindara), 1, MidpointRounding.AwayFromZero);
            }
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            ResetVrednosti();
            if (Provera())
            {
                if (Ucitavanje())
                {
                    Racun();
                    if (FormaCentarTabela1 == null /* && forma4 == null */)
                        button1.Enabled = button2.Enabled = true;
                    if (FormaCentarTabela1 != null) 
                    {
                        FormaCentarTabela1.IspisVrednosti();
                        if (FormaCentarTabela1.FormaCentarTabela2 != null && FormaCentarTabela1.FormaCentarTabela2.FormaCentarTabela3 != null) FormaCentarTabela1.FormaCentarTabela2.FormaCentarTabela3.Matematika();
                    }
                    //if(forma4 != null) forma4.Azuriraj();
                }
                else
                {
                    ResetVrednosti();
                    MessageBox.Show(FormaHomeScreen.jezik[12]);
                }
            }
            else
            {
                ResetVrednosti();
                MessageBox.Show(FormaHomeScreen.jezik[11]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaCentarTabela1 = new Forma_Centar_Tabela_1(this);
            FormaCentarTabela1.Owner = this;
            FormaCentarTabela1.Show();

            button1.Enabled = false;
        }

        public Boolean button1Enabled
        {
            get { return button1.Enabled;  }
            set { button1.Enabled = value; }
        }
    }
}
