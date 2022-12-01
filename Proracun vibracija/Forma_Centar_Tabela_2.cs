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
    public partial class Forma_Centar_Tabela_2 : Form
    {
        public Forma_Centar_Tabela_1 FormaCentarTabela1;
        public Forma_Centar_Tabela_3 FormaCentarTabela3;

        public Forma_Centar_Tabela_2(Forma_Centar_Tabela_1 konstruktor)
        {
            InitializeComponent();
            FormaCentarTabela1 = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text    = FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[30];
            label1.Text  = FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[31];
            label2.Text  = FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[32];
            label3.Text  = FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[33];
            label4.Text  = FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[34];
            label5.Text  = FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[35];
            label6.Text  = FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[36];
            label7.Text  = FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[37];
            button1.Text = FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[38];
        }

        private void Forma_Centar_Tabela_2_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(FormaCentarTabela1.Left + 20, FormaCentarTabela1.Top + 20);

            textBox_DR_Watermark();
            textBox_D1_Watermark();
            textBox_D2_Watermark();
            textBox_D3_Watermark();
            textBox_D4_Watermark();
            textBox_D5_Watermark();
            textBox_D6_Watermark();
        }

        private void Forma_Centar_Tabela_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaCentarTabela1.FormaCentarTabela2 = null;
            FormaCentarTabela1.button1Enabled = true;
        }

        #region text box sranja

        private void textBox_DR_Enter(object sender, EventArgs e)
        {
            if (textBox_DR.ForeColor == Color.Black)
                return;
            textBox_DR.Text = "";
            textBox_DR.ForeColor = Color.Black;
        }

        private void textBox_DR_Leave(object sender, EventArgs e)
        {
            if (textBox_DR.Text.Trim() == "") textBox_DR_Watermark();
        }

        private void textBox_DR_Watermark()
        {
            this.textBox_DR.Text = "DR";
            textBox_DR.ForeColor = Color.Gray;
        }



        private void textBox_D1_Enter(object sender, EventArgs e)
        {
            if (textBox_D1.ForeColor == Color.Black)
                return;
            textBox_D1.Text = "";
            textBox_D1.ForeColor = Color.Black;
        }

        private void textBox_D1_Leave(object sender, EventArgs e)
        {
            if (textBox_D1.Text.Trim() == "") textBox_D1_Watermark();
        }

        private void textBox_D1_Watermark()
        {
            this.textBox_D1.Text = "D1";
            textBox_D1.ForeColor = Color.Gray;
        }



        private void textBox_D2_Enter(object sender, EventArgs e)
        {
            if (textBox_D2.ForeColor == Color.Black)
                return;
            textBox_D2.Text = "";
            textBox_D2.ForeColor = Color.Black;
        }

        private void textBox_D2_Leave(object sender, EventArgs e)
        {
            if (textBox_D2.Text.Trim() == "") textBox_D2_Watermark();
        }

        private void textBox_D2_Watermark()
        {
            this.textBox_D2.Text = "D2";
            textBox_D2.ForeColor = Color.Gray;
        }



        private void textBox_D3_Enter(object sender, EventArgs e)
        {
            if (textBox_D3.ForeColor == Color.Black)
                return;
            textBox_D3.Text = "";
            textBox_D3.ForeColor = Color.Black;
        }

        private void textBox_D3_Leave(object sender, EventArgs e)
        {
            if (textBox_D3.Text.Trim() == "") textBox_D3_Watermark();
        }

        private void textBox_D3_Watermark()
        {
            this.textBox_D3.Text = "D3";
            textBox_D3.ForeColor = Color.Gray;
        }



        private void textBox_D4_Enter(object sender, EventArgs e)
        {
            if (textBox_D4.ForeColor == Color.Black)
                return;
            textBox_D4.Text = "";
            textBox_D4.ForeColor = Color.Black;
        }

        private void textBox_D4_Leave(object sender, EventArgs e)
        {
            if (textBox_D4.Text.Trim() == "") textBox_D4_Watermark();
        }

        private void textBox_D4_Watermark()
        {
            this.textBox_D4.Text = "D4";
            textBox_D4.ForeColor = Color.Gray;
        }



        private void textBox_D5_Enter(object sender, EventArgs e)
        {
            if (textBox_D5.ForeColor == Color.Black)
                return;
            textBox_D5.Text = "";
            textBox_D5.ForeColor = Color.Black;
        }

        private void textBox_D5_Leave(object sender, EventArgs e)
        {
            if (textBox_D5.Text.Trim() == "") textBox_D5_Watermark();
        }

        private void textBox_D5_Watermark()
        {
            this.textBox_D5.Text = "D5";
            textBox_D5.ForeColor = Color.Gray;
        }



        private void textBox_D6_Enter(object sender, EventArgs e)
        {
            if (textBox_D6.ForeColor == Color.Black)
                return;
            textBox_D6.Text = "";
            textBox_D6.ForeColor = Color.Black;
        }

        private void textBox_D6_Leave(object sender, EventArgs e)
        {
            if (textBox_D6.Text.Trim() == "") textBox_D6_Watermark();
        }

        private void textBox_D6_Watermark()
        {
            this.textBox_D6.Text = "D6";
            textBox_D6.ForeColor = Color.Gray;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            _DR = _D1 = _D2 = _D3 = _D4 = _D5 = _D6 = 0;
            if (textBox_DR.Text != "DR" && (textBox_D1.Text != "D1" || textBox_D2.Text != "D2" || textBox_D3.Text != "D3" || textBox_D4.Text != "D4" || textBox_D5.Text != "D5" || textBox_D6.Text != "D6"))
            {
                if (Ucitavanje())
                {
                    if (FormaCentarTabela3 == null)
                    {
                        Konverzija();
                        FormaCentarTabela3 = new Forma_Centar_Tabela_3(this);
                        FormaCentarTabela3.Owner = this;
                        FormaCentarTabela3.Show();
                    }
                    else
                    {
                        Konverzija();
                        FormaCentarTabela3.Matematika();
                    }
                }
                else MessageBox.Show(FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[40]);
            }
            else MessageBox.Show(FormaCentarTabela1.FormaCentarGlavni.FormaHomeScreen.jezik[39]);
        }

        public Double DR, D1, D2, D3, D4, D5, D6;
        Double _DR, _D1, _D2, _D3, _D4, _D5, _D6;

        private Boolean Ucitavanje()
        {
            //////////////////////////////////////////////////////////
            if (!Double.TryParse(textBox_DR.Text, out _DR)) return false;
            if (_DR <= 0) return false;
            //////////////////////////////////////////////////////////
            if (textBox_D1.Text != "D1")
            {
                if (Double.TryParse(textBox_D1.Text, out _D1))
                {
                    if (_D1 <= 0) return false;
                }
                else return false;
            }
            //////////////////////////////////////////////////////////
            if (textBox_D2.Text != "D2")
            {
                if (Double.TryParse(textBox_D2.Text, out _D2))
                {
                    if (_D2 <= 0) return false;
                }
                else return false;
            }
            //////////////////////////////////////////////////////////
            if (textBox_D3.Text != "D3")
            {
                if (Double.TryParse(textBox_D3.Text, out _D3))
                {
                    if (_D3 <= 0) return false;
                }
                else return false;
            }
            //////////////////////////////////////////////////////////
            if (textBox_D4.Text != "D4")
            {
                if (Double.TryParse(textBox_D4.Text, out _D4))
                {
                    if (_D4 <= 0) return false;
                }
                else return false;
            }
            //////////////////////////////////////////////////////////
            if (textBox_D5.Text != "D5")
            {
                if (Double.TryParse(textBox_D5.Text, out _D5))
                {
                    if (_D5 <= 0) return false;
                }
                else return false;
            }
            //////////////////////////////////////////////////////////
            if (textBox_D6.Text != "D6")
            {
                if (Double.TryParse(textBox_D6.Text, out _D6))
                {
                    if (_D6 <= 0) return false;
                }
                else return false;
            }
            //////////////////////////////////////////////////////////
            return true;
            //////////////////////////////////////////////////////////
        }

        private void Konverzija()
        {
            DR = _DR;
            D1 = _D1;
            D2 = _D2;
            D3 = _D3;
            D4 = _D4;
            D5 = _D5;
            D6 = _D6;
        }
    }
}
