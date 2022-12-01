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
    public partial class Forma_Uvod : Form
    {
        Forma_HomeScreen FormaHomeScreen;

        public Forma_Uvod(Forma_HomeScreen konstruktor)
        {
            InitializeComponent();
            FormaHomeScreen = konstruktor;
        }

        public void PromenaJezika()
        {
            this.Text = FormaHomeScreen.jezik[251];
        }

        private void Forma_Uvod_Load(object sender, EventArgs e)
        {
            PromenaJezika();
            this.Location = new Point(0, 0);
        }
    }
}
