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
    public partial class Forma_HomeScreen : Form
    {
        public Forma_HomeScreen()
        {
            InitializeComponent();
        }

        // todo: prebaci forma_centar_tabela_2 na pravo mesto

        public Forma_Centar_Glavni FormaCentarGlavni;

        #region Jezik

        public String[] jezik = {
                                // Forma_HomeScreen
                                "Proračun vibracija",
                                "Saveti za test vožnju",
                                "Motor",
                                "Auto",
                                "PLACEHOLDERSTRING Form1.dugmeLevo_Click",

                                // Forma_Centar_Glavni
                                "Vibracije motora",
                                "Unos podataka",
                                "RPM",
                                "Izmerena frekvencija",
                                "Broj cilindara",
                                "Izvrši racun",
                                "Greška, nedovoljan broj polja popunjen.",
                                "Greška, u nekom od polja je uneta vrednost koja nije broj.",
                                "Decimale se označavaju tačkom, ne zarezom.",

                                // Forma_Centar_Tabela_1
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_1.Text",
                                "RPM",
                                "Frekvencija motora",
                                "Frekvencija motora drugog reda",
                                "Frekvencija motora trećeg reda",
                                "Frekvencija motora četvrtog reda",
                                "Frekvencija bregaste",
                                "Frekvencija paljenja",
                                "Izmerene frekvencije",
                                "Vibracije agregata",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_1.button_FM_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_1.button_FM2_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_1.button_FM3_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_1.button_FM4_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_1.button_FB_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_1.button_FP_Click",

                                // Forma_Centar_Tabela_2
                                "Unos podataka",
                                "Prečnik remenice radilice",
                                "Prečnik remenice alternatora",
                                "Prečnik remenice kompresora klime",
                                "Prečnik remenice servo volana",
                                "Prečnik remenice pumpe za vodu",
                                "Prečnik remenice dodatnog agregata 1",
                                "Prečnik remenice dodatnog agregata 2",
                                "Izračunaj",
                                "Greška, nedovoljno polja popunjeno.",
                                "Greška, u nekom od polja je uneta vrednost koja nije broj.",

                                // Forma_Centar_Tabela_3
                                "Proračun vibracija agregata",
                                "RPM",
                                "Frekvencija: ",
                                "Alternatora",
                                "Kompresora klime",
                                "Servo volana",
                                "Pumpe za vodu",
                                "Dodatnog agregata 1",
                                "Dodatnog agregata 2",
                                "Izmerene frekvencije",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_3.button_D1_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_3.button_D2_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_3.button_D3_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_3.button_D4_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_3.button_D5_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela_3.button_D6_Click",

                                // Forma_Centar_Grafik_1
                                "Vibracije motora",
                                "Vibracije agregata",
                                "Iscrtaj ponovo",
                                "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM2_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM2_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM3_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM3_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM4_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM4_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FB_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FB_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FP_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FP_Click USLOV NE ISPUNJEN",
                                "FM",
                                "FM2",
                                "FM3",
                                "FM4",
                                "FB",
                                "FP",
                                "FM - frekvencija motora",
                                "FM2 - frekvencija motora drugog reda",
                                "FM3 - frekvencija motora trećeg reda",
                                "FM4 - frekvencija motora četvrtog reda",
                                "FB - frekvencija bregaste",
                                "FP - frekvencija paljenja"
                                };

        //public String jezik

        private void PromenaJezika()
        {
            this.Text = jezik[0];
            dugmeLevo.Text = jezik[1];
            dugmeCentar.Text = jezik[2];
            dugmeDesno.Text = jezik[3];

            if (FormaCentarGlavni != null) 
            {
                FormaCentarGlavni.PromenaJezika();
                if (FormaCentarGlavni.FormaCentarTabela1 != null)
                {
                    FormaCentarGlavni.FormaCentarTabela1.PromenaJezika();
                    if (FormaCentarGlavni.FormaCentarTabela1.FormaCentarTabela2 != null)
                    {
                        FormaCentarGlavni.FormaCentarTabela1.FormaCentarTabela2.PromenaJezika();
                        if (FormaCentarGlavni.FormaCentarTabela1.FormaCentarTabela2.FormaCentarTabela3 != null) FormaCentarGlavni.FormaCentarTabela1.FormaCentarTabela2.FormaCentarTabela3.PromenaJezika();
                    }
                }
                if (FormaCentarGlavni.FormaCentarGrafik1 != null)
                {
                    FormaCentarGlavni.FormaCentarGrafik1.PromenaJezika();
                }
            }
        }

        private void jezikDugme_Srpski_Click(object sender, EventArgs e)
        {
            // Forma_HomeScreen
            jezik[0]  = "Proračun vibracija";
            jezik[1]  = "Saveti za test vožnju";
            jezik[2]  = "Motor";
            jezik[3]  = "Auto";
            jezik[4]  = "PLACEHOLDERSTRING Form1.dugmeLevo_Click";

            // Forma_Centar_Glavni
            jezik[5]  = "Vibracije motora";
            jezik[6]  = "Unos podataka";
            jezik[7]  = "RPM";
            jezik[8]  = "Izmerena frekvencija";
            jezik[9]  = "Broj cilindara";
            jezik[10] = "Izvrši racun";
            jezik[11] = "Greška, nedovoljan broj polja popunjen.";
            jezik[12] = "Greška, u nekom od polja je uneta vrednost koja nije broj.";
            jezik[13] = "Decimale se označavaju tačkom, ne zarezom.";
            
            // Forma_Centar_Tabela_1
            jezik[14] = "PLACEHOLDERSTRING Forma_Centar_Tabela_1.Text";
            jezik[15] = "RPM";
            jezik[16] = "Frekvencija motora";
            jezik[17] = "Frekvencija motora drugog reda";
            jezik[18] = "Frekvencija motora trećeg reda";
            jezik[19] = "Frekvencija motora četvrtog reda";
            jezik[20] = "Frekvencija bregaste";
            jezik[21] = "Frekvencija paljenja";
            jezik[22] = "Izmerene frekvencije";
            jezik[23] = "Vibracije agregata";
            jezik[24] = "PLACEHOLDERSTRING Forma_Centar_Tabela_1.button_FM_Click";
            jezik[25] = "PLACEHOLDERSTRING Forma_Centar_Tabela_1.button_FM2_Click";
            jezik[26] = "PLACEHOLDERSTRING Forma_Centar_Tabela_1.button_FM3_Click";
            jezik[27] = "PLACEHOLDERSTRING Forma_Centar_Tabela_1.button_FM4_Click";
            jezik[28] = "PLACEHOLDERSTRING Forma_Centar_Tabela_1.button_FB_Click";
            jezik[29] = "PLACEHOLDERSTRING Forma_Centar_Tabela_1.button_FP_Click";

            // Forma_Centar_Tabela_2
            jezik[30] = "Unos podataka";
            jezik[31] = "Prečnik remenice radilice";
            jezik[32] = "Prečnik remenice alternatora";
            jezik[33] = "Prečnik remenice kompresora klime";
            jezik[34] = "Prečnik remenice servo volana";
            jezik[35] = "Prečnik remenice pumpe za vodu";
            jezik[36] = "Prečnik remenice dodatnog agregata 1";
            jezik[37] = "Prečnik remenice dodatnog agregata 2";
            jezik[38] = "Izračunaj";
            jezik[39] = "Greška, nedovoljan broj polja popunjen.";
            jezik[40] = "Greška, u nekom od polja je uneta vrednost koja nije broj.";

            // Forma_Centar_Tabela_3
            jezik[41] = "Proračun vibracija agregata";
            jezik[42] = "RPM";
            jezik[43] = "Frekvencija: ";
            jezik[44] = "Alternatora";
            jezik[45] = "Kompresora klime";
            jezik[46] = "Servo volana";
            jezik[47] = "Pumpe za vodu";
            jezik[48] = "Dodatnog agregata 1";
            jezik[49] = "Dodatnog agregata 2";
            jezik[50] = "Izmerene frekvencije";
            jezik[51] = "PLACEHOLDERSTRING Forma_Centar_Tabela_3.button_D1_Click";
            jezik[52] = "PLACEHOLDERSTRING Forma_Centar_Tabela_3.button_D2_Click";
            jezik[53] = "PLACEHOLDERSTRING Forma_Centar_Tabela_3.button_D3_Click";
            jezik[54] = "PLACEHOLDERSTRING Forma_Centar_Tabela_3.button_D4_Click";
            jezik[55] = "PLACEHOLDERSTRING Forma_Centar_Tabela_3.button_D5_Click";
            jezik[56] = "PLACEHOLDERSTRING Forma_Centar_Tabela_3.button_D6_Click";

            // Forma_Centar_Grafik_1
            jezik[57] = "Vibracije motora";
            jezik[58] = "Vibracije agregata";
            jezik[59] = "Iscrtaj ponovo";
            jezik[60] = "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:";
            jezik[61] = "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM_Click USLOV ISPUNJEN";
            jezik[62] = "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM_Click USLOV NE ISPUNJEN";
            jezik[63] = "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM2_Click USLOV ISPUNJEN";
            jezik[64] = "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM2_Click USLOV NE ISPUNJEN";
            jezik[65] = "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM3_Click USLOV ISPUNJEN";
            jezik[66] = "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM3_Click USLOV NE ISPUNJEN";
            jezik[67] = "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM3_Click USLOV ISPUNJEN";
            jezik[68] = "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FM3_Click USLOV NE ISPUNJEN";
            jezik[69] = "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FB_Click USLOV ISPUNJEN";
            jezik[70] = "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FB_Click USLOV NE ISPUNJEN";
            jezik[71] = "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FP_Click USLOV ISPUNJEN";
            jezik[72] = "PLACEHOLDERSTRING Forma_Centar_Grafik_1.button_FP_Click USLOV NE ISPUNJEN";
            jezik[73] = "FM";
            jezik[74] = "FM2";
            jezik[75] = "FM3";
            jezik[76] = "FM4";
            jezik[77] = "FB";
            jezik[78] = "FP";
            jezik[79] = "FM - frekvencija motora";
            jezik[80] = "FM2 - frekvencija motora drugog reda";
            jezik[81] = "FM3 - frekvencija motora trećeg reda";
            jezik[82] = "FM4 - frekvencija motora četvrtog reda";
            jezik[83] = "FB - frekvencija bregaste";
            jezik[84] = "FP - frekvencija paljenja";

            PromenaJezika();
        }

        private void jezikDugme_Engleski_Click(object sender, EventArgs e)
        {
            // Forma_HomeScreen
            jezik[0]  = "Vibration calculator";
            jezik[1]  = "Test drive tips";
            jezik[2]  = "Engine";
            jezik[3]  = "Vehicle";
            jezik[4]  = "P ID 4";

            // Forma_CentarGlavni
            jezik[5]  = "Engine vibrations";
            jezik[6]  = "P ID 6";
            jezik[7]  = "P ID 7";
            jezik[8]  = "P ID 8";
            jezik[9]  = "P ID 9";
            jezik[10] = "P ID 10";
            jezik[11] = "P ID 11";
            jezik[12] = "P ID 12";
            jezik[13] = "P ID 13";

            // Forma_Centar_Tabela_1
            jezik[14] = "P ID 14";
            jezik[15] = "P ID 15";
            jezik[16] = "P ID 16";
            jezik[17] = "P ID 17";
            jezik[18] = "P ID 18";
            jezik[19] = "P ID 19";
            jezik[20] = "P ID 20";
            jezik[21] = "P ID 21";
            jezik[22] = "P ID 22";
            jezik[23] = "P ID 23";
            jezik[24] = "P ID 24";
            jezik[25] = "P ID 25";
            jezik[26] = "P ID 26";
            jezik[27] = "P ID 27";
            jezik[28] = "P ID 28";
            jezik[29] = "P ID 29";

            // Forma_Centar_Tabela_2
            jezik[30] = "P ID 30";
            jezik[31] = "P ID 31";
            jezik[32] = "P ID 32";
            jezik[33] = "P ID 33";
            jezik[34] = "P ID 34";
            jezik[35] = "P ID 35";
            jezik[36] = "P ID 36";
            jezik[37] = "P ID 37";
            jezik[38] = "P ID 38";
            jezik[39] = "P ID 39";
            jezik[40] = "P ID 40";

            // Forma_Centar_Tabela_3
            jezik[41] = "P ID 41";
            jezik[42] = "P ID 42";
            jezik[43] = "P ID 43";
            jezik[44] = "P ID 44";
            jezik[45] = "P ID 45";
            jezik[46] = "P ID 46";
            jezik[47] = "P ID 47";
            jezik[48] = "P ID 48";
            jezik[49] = "P ID 49";
            jezik[50] = "P ID 50";
            jezik[51] = "P ID 51";
            jezik[52] = "P ID 52";
            jezik[53] = "P ID 53";
            jezik[54] = "P ID 54";
            jezik[55] = "P ID 55";
            jezik[56] = "P ID 56";

            // Forma_Centar_Grafik_1
            jezik[57] = "Engine-related vibrations";
            jezik[58] = "P ID 58";
            jezik[59] = "P ID 59";
            jezik[60] = "P ID 60";
            jezik[61] = "P ID 61";
            jezik[62] = "P ID 62";
            jezik[63] = "P ID 63";
            jezik[64] = "P ID 64";
            jezik[65] = "P ID 65";
            jezik[66] = "P ID 66";
            jezik[67] = "P ID 67";
            jezik[68] = "P ID 68";
            jezik[69] = "P ID 69";
            jezik[70] = "P ID 70";
            jezik[71] = "P ID 71";
            jezik[72] = "P ID 72";
            jezik[73] = "P ID 73";
            jezik[74] = "P ID 74";
            jezik[75] = "P ID 75";
            jezik[76] = "P ID 76";
            jezik[77] = "P ID 77";
            jezik[78] = "P ID 78";
            jezik[79] = "P ID 79";
            jezik[80] = "P ID 80";
            jezik[81] = "P ID 81";
            jezik[82] = "P ID 82";
            jezik[83] = "P ID 83";
            jezik[84] = "P ID 84";

            PromenaJezika();
        }

        private void jezikDugme_Nemacki_Click(object sender, EventArgs e)
        {
            MessageBox.Show("German language support hasn't been added yet.");
        }

        #endregion

        private void dugmeLevo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jezik[4]);
        }

        private void dugmeCentar_Click(object sender, EventArgs e)
        {
            FormaCentarGlavni = new Forma_Centar_Glavni(this);
            FormaCentarGlavni.Owner = this;
            FormaCentarGlavni.Show();

            dugmeCentar.Enabled = false;
        }

        public Boolean dugmeCentarEnabled
        {
            get { return dugmeCentar.Enabled;  }
            set { dugmeCentar.Enabled = value; }
        }
    }
}
