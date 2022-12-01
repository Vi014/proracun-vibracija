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
    public partial class Forma_Centar_Tekst : Form
    {
        public Forma_Centar_Tabela FormaCentarTabela;
        public Forma_Centar_Grafik FormaCentarGrafik;
        public Forma_Centar_Agregat_Tabela FormaCentarAgregatTabela;
        public Forma_Centar_Agregat_Grafik FormaCentarAgregatGrafik;
        Int32 parentForm; // vrednost ove promenljive odgovara formi koja je stvorila ovu formu
        // 0 - FormaCentarTabela
        // 1 - FormaCentarGrafik
        // 2 - FormaCentarAgregatTabela
        // 3 - FormaCentarAgregatGrafik

        public Forma_Centar_Tekst(Forma_Centar_Tabela konstruktor)
        {
            InitializeComponent();
            FormaCentarTabela = konstruktor;
            parentForm = 0;
        }

        public Forma_Centar_Tekst(Forma_Centar_Grafik konstruktor)
        {
            InitializeComponent();
            FormaCentarGrafik = konstruktor;
            parentForm = 1;
        }

        public Forma_Centar_Tekst(Forma_Centar_Agregat_Tabela konstruktor)
        {
            InitializeComponent();
            FormaCentarAgregatTabela = konstruktor;
            parentForm = 2;
        }

        public Forma_Centar_Tekst(Forma_Centar_Agregat_Grafik konstruktor)
        {
            InitializeComponent();
            FormaCentarAgregatGrafik = konstruktor;
            parentForm = 3;
        }

        public void PromenaJezika()
        {
            switch (parentForm)
            {
                case 0:
                    {
                        this.Text = FormaCentarTabela.FormaCentarGlavni.FormaHomeScreen.jezik[319];
                        break;
                    }
                case 1:
                    {
                        this.Text = FormaCentarGrafik.FormaCentarGlavni.FormaHomeScreen.jezik[319];
                        break;
                    }
                case 2:
                    {
                        this.Text = FormaCentarAgregatTabela.FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[319];
                        break;
                    }
                case 3:
                    {
                        this.Text = FormaCentarAgregatGrafik.FormaCentarAgregatGlavni.FormaCentarGlavni.FormaHomeScreen.jezik[319];
                        break;
                    }
                default: break;
            }
        }

        private void Forma_Centar_Tekst_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(0, 0);
        }

        private void Forma_Centar_Tekst_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch(parentForm)
            {
                case 0:
                    {
                        FormaCentarTabela.FormaCentarTekst = null;
                        break;
                    }
                case 1:
                    {
                        FormaCentarGrafik.FormaCentarTekst = null;
                        break;
                    }
                case 2:
                    {
                        FormaCentarAgregatTabela.FormaCentarTekst = null;
                        break;
                    }
                case 3:
                    {
                        FormaCentarAgregatGrafik.FormaCentarTekst = null;
                        break;
                    }
                default: break;
            }
        }

        private void zoom(object sender, EventArgs e)
        {
            (sender as ZoomablePictureBox).Zoom(zoomPicture, button1, panel1, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zoomPicture.Visible = button1.Visible = false;
            panel1.Enabled = true;
        }
    }
}
