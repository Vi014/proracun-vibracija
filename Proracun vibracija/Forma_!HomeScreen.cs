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

        public Forma_Centar_Glavni FormaCentarGlavni;

        #region Jezik

        public String[] jezik = {
                                // Forma_HomeScreen
                                "Proračun vibracija",
                                "Saveti za test vožnju",
                                "Motor",
                                "Auto",
                                "PLACEHOLDERSTRING Forma_HomeScreen.dugmeLevo_Click",

                                // Forma_Centar_Glavni
                                "Vibracije motora",
                                "Unos podataka",
                                "Decimale se označavaju tačkom, ne zarezom.",
                                "RPM",
                                "Izmerena frekvencija",
                                "Broj cilindara",
                                "Izvrši račun",
                                "Vibracije agregata",
                                "Greška, nedovoljan broj polja popunjen.",
                                "Greška, u nekom od polja je uneta nevažeća vrednost.",

                                // Forma_Centar_Tabela
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.Text",
                                "RPM",
                                "Frekvencija motora",
                                "Frekvencija motora drugog reda",
                                "Frekvencija motora trećeg reda",
                                "Frekvencija motora četvrtog reda",
                                "Frekvencija bregaste",
                                "Frekvencija paljenja",
                                "Izmerene frekvencije",                               
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM2_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM3_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM4_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FB_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FP_Click",

                                // Forma_Centar_Grafik
                                "Vibracije motora",
                                "Iscrtaj ponovo",
                                "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM2_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM2_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM3_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM3_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM4_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM4_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FB_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FB_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FP_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FP_Click USLOV NE ISPUNJEN",
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
                                "FP - frekvencija paljenja",

                                // Forma_Centar_Agregat_Glavni
                                "Unos podataka",
                                "Decimale se označavaju tačkom, ne zarezom.",
                                "Prečnik remenice radilice",
                                "Prečnik remenice alternatora",
                                "Prečnik remenice kompresora klime",
                                "Prečnik remenice servo volana",
                                "Prečnik remenice pumpe za vodu",
                                "Prečnik remenice dodatnog agregata 1",
                                "Prečnik remenice dodatnog agregata 2",
                                "Izvrši račun",
                                "Greška, nedovoljno polja popunjeno.",
                                "Greška, u nekom od polja je uneta nevažeća vrednost.",

                                // Forma_Centar_Agregat_Tabela
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
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D1_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D2_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D3_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D4_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D5_Click",
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D6_Click"
                                };

        private void PromenaJezika()
        {
            this.Text = jezik[0];
            dugmeLevo.Text = jezik[1];
            dugmeCentar.Text = jezik[2];
            dugmeDesno.Text = jezik[3];

            if (FormaCentarGlavni != null) 
            {
                FormaCentarGlavni.PromenaJezika();
                if (FormaCentarGlavni.FormaCentarTabela != null) FormaCentarGlavni.FormaCentarTabela.PromenaJezika();
                if (FormaCentarGlavni.FormaCentarGrafik != null) FormaCentarGlavni.FormaCentarGrafik.PromenaJezika();
                if (FormaCentarGlavni.FormaCentarAgregatGlavni != null)
                {
                    FormaCentarGlavni.FormaCentarAgregatGlavni.PromenaJezika();
                    if (FormaCentarGlavni.FormaCentarAgregatGlavni.FormaCentarAgregatTabela != null) FormaCentarGlavni.FormaCentarAgregatGlavni.FormaCentarAgregatTabela.PromenaJezika();
                    // if (FormaCentarGlavni.FormaCentarAgregatGlavni.FormaCentarAgregatGrafik != null) FormaCentarGlavni.FormaCentarAgregatGlavni.FormaCentarAgregatGrafik.PromenaJezika();
                }
            }
        }

        private void jezikDugme_Srpski_Click(object sender, EventArgs e)
        {
            // Forma_HomeScreen
            jezik[0]   = "Proračun vibracija";
            jezik[1]   = "Saveti za test vožnju";
            jezik[2]   = "Motor";
            jezik[3]   = "Auto";
            jezik[4]   = "PLACEHOLDERSTRING Form1.dugmeLevo_Click";

            // Forma_Centar_Glavni
            jezik[5]   = "Vibracije motora";
            jezik[6]   = "Unos podataka";
            jezik[7]   = "Decimale se označavaju tačkom, ne zarezom.";
            jezik[8]   = "RPM";
            jezik[9]   = "Izmerena frekvencija";
            jezik[10]  = "Broj cilindara";
            jezik[11]  = "Izvrši račun";
            jezik[12]  = "Vibracije agregata";
            jezik[13]  = "Greška, nedovoljan broj polja popunjen.";
            jezik[14]  = "Greška, u nekom od polja je uneta nevažeća vrednost.";

            // Forma_Centar_Tabela
            jezik[15]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.Text";
            jezik[16]  = "RPM";
            jezik[17]  = "Frekvencija motora";
            jezik[18]  = "Frekvencija motora drugog reda";
            jezik[19]  = "Frekvencija motora trećeg reda";
            jezik[20]  = "Frekvencija motora četvrtog reda";
            jezik[21]  = "Frekvencija bregaste";
            jezik[22]  = "Frekvencija paljenja";
            jezik[23]  = "Izmerene frekvencije";
            jezik[24]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM_Click";
            jezik[25]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM2_Click";
            jezik[26]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM3_Click";
            jezik[27]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM4_Click";
            jezik[28]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FB_Click";
            jezik[29]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FP_Click";

            // Forma_Centar_Grafik
            jezik[30]  = "Vibracije motora";
            jezik[31]  = "Iscrtaj ponovo";
            jezik[32]  = "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:";
            jezik[33]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM_Click USLOV ISPUNJEN";
            jezik[34]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM_Click USLOV NE ISPUNJEN";
            jezik[35]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM2_Click USLOV ISPUNJEN";
            jezik[36]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM2_Click USLOV NE ISPUNJEN";
            jezik[37]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM3_Click USLOV ISPUNJEN";
            jezik[38]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM3_Click USLOV NE ISPUNJEN";
            jezik[39]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM4_Click USLOV ISPUNJEN";
            jezik[40]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM4_Click USLOV NE ISPUNJEN";
            jezik[41]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FB_Click USLOV ISPUNJEN";
            jezik[42]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FB_Click USLOV NE ISPUNJEN";
            jezik[43]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FP_Click USLOV ISPUNJEN";
            jezik[44]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FP_Click USLOV NE ISPUNJEN";
            jezik[45]  = "FM";
            jezik[46]  = "FM2";
            jezik[47]  = "FM3";
            jezik[48]  = "FM4";
            jezik[49]  = "FB";
            jezik[50]  = "FP";
            jezik[51]  = "FM - frekvencija motora";
            jezik[52]  = "FM2 - frekvencija motora drugog reda";
            jezik[53]  = "FM3 - frekvencija motora trećeg reda";
            jezik[54]  = "FM4 - frekvencija motora četvrtog reda";
            jezik[55]  = "FB - frekvencija bregaste";
            jezik[56]  = "FP - frekvencija paljenja";

            // Forma_Centar_Agregat_Glavni
            jezik[57]  = "Unos podataka";
            jezik[58]  = "Decimale se označavaju tačkom, ne zarezom.";
            jezik[59]  = "Prečnik remenice radilice";
            jezik[60]  = "Prečnik remenice alternatora";
            jezik[61]  = "Prečnik remenice kompresora klime";
            jezik[62]  = "Prečnik remenice servo volana";
            jezik[63]  = "Prečnik remenice pumpe za vodu";
            jezik[64]  = "Prečnik remenice dodatnog agregata 1";
            jezik[65]  = "Prečnik remenice dodatnog agregata 2";
            jezik[66]  = "Izvrši račun"; // nekada je pisalo "izracunaj" ali ja sam promenio cisto da bude u skladu sa onim sto pise na FormaCentarGlavni
            jezik[67]  = "Greška, nedovoljno polja popunjeno.";
            jezik[68]  = "Greška, u nekom od polja je uneta nevažeća vrednost.";

            // Forma_Centar_Agregat_Tabela
            jezik[69]  = "Proračun vibracija agregata";
            jezik[70]  = "RPM";
            jezik[71]  = "Frekvencija: ";
            jezik[72]  = "Alternatora";
            jezik[73]  = "Kompresora klime";
            jezik[74]  = "Servo volana";
            jezik[75]  = "Pumpe za vodu";
            jezik[76]  = "Dodatnog agregata 1";
            jezik[77]  = "Dodatnog agregata 2";
            jezik[78]  = "Izmerene frekvencije";
            jezik[79]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D1_Click";
            jezik[80]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D2_Click";
            jezik[81]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D3_Click";
            jezik[82]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D4_Click";
            jezik[83]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D5_Click";
            jezik[84]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D6_Click";

            PromenaJezika();
        }

        private void jezikDugme_Engleski_Click(object sender, EventArgs e)
        {
            // Forma_HomeScreen
            jezik[0]   = "Vibration calculator";
            jezik[1]   = "Test drive tips";
            jezik[2]   = "Engine";
            jezik[3]   = "Vehicle";
            jezik[4]   = "P ID 4";

            // Forma_Centar_Glavni
            jezik[5]   = "Engine vibrations";  // zasto nije "Engine-related vibrations"?
            jezik[6]   = "P ID 6";
            jezik[7]   = "P ID 7";
            jezik[8]   = "P ID 8";
            jezik[9]   = "P ID 9";
            jezik[10]  = "P ID 10";
            jezik[11]  = "P ID 11";
            jezik[12]  = "P ID 12";
            jezik[13]  = "P ID 13";
            jezik[14]  = "P ID 14";

            // Forma_Centar_Tabela
            jezik[15]  = "P ID 15";
            jezik[16]  = "P ID 16";
            jezik[17]  = "P ID 17";
            jezik[18]  = "P ID 18";
            jezik[19]  = "P ID 19";
            jezik[20]  = "P ID 20";
            jezik[21]  = "P ID 21";
            jezik[22]  = "P ID 22";
            jezik[23]  = "P ID 23";
            jezik[24]  = "P ID 24";
            jezik[25]  = "P ID 25";
            jezik[26]  = "P ID 26";
            jezik[27]  = "P ID 27";
            jezik[28]  = "P ID 28";
            jezik[29]  = "P ID 29";

            // Forma_Centar_Grafik
            jezik[30]  = "Engine-related vibrations";
            jezik[31]  = "P ID 31";
            jezik[32]  = "P ID 32";
            jezik[33]  = "P ID 33";
            jezik[34]  = "P ID 34";
            jezik[35]  = "P ID 35";
            jezik[36]  = "P ID 36";
            jezik[37]  = "P ID 37";
            jezik[38]  = "P ID 38";
            jezik[39]  = "P ID 39";
            jezik[40]  = "P ID 40";
            jezik[41]  = "P ID 41";
            jezik[42]  = "P ID 42";
            jezik[43]  = "P ID 43";
            jezik[44]  = "P ID 44";
            jezik[45]  = "P ID 45";
            jezik[46]  = "P ID 46";
            jezik[47]  = "P ID 47";
            jezik[48]  = "P ID 48";
            jezik[49]  = "P ID 49";
            jezik[50]  = "P ID 50";
            jezik[51]  = "P ID 51";
            jezik[52]  = "P ID 52";
            jezik[53]  = "P ID 53";
            jezik[54]  = "P ID 54";
            jezik[55]  = "P ID 55";
            jezik[56]  = "P ID 56";

            // Forma_Centar_Agregat_Glavni
            jezik[57]  = "P ID 57";
            jezik[58]  = "P ID 58";
            jezik[59]  = "P ID 59";
            jezik[60]  = "P ID 60";
            jezik[61]  = "P ID 61";
            jezik[62]  = "P ID 62";
            jezik[63]  = "P ID 63";
            jezik[64]  = "P ID 64";
            jezik[65]  = "P ID 65";
            jezik[66]  = "P ID 66";
            jezik[67]  = "P ID 67";
            jezik[68]  = "P ID 68";

            // Forma_Centar_Agregat_Tabela
            jezik[69]  = "P ID 69";
            jezik[70]  = "P ID 70";
            jezik[71]  = "P ID 71";
            jezik[72]  = "P ID 72";
            jezik[73]  = "P ID 73";
            jezik[74]  = "P ID 74";
            jezik[75]  = "P ID 75";
            jezik[76]  = "P ID 76";
            jezik[77]  = "P ID 77";
            jezik[78]  = "P ID 78";
            jezik[79]  = "P ID 79";
            jezik[80]  = "P ID 80";
            jezik[81]  = "P ID 81";
            jezik[82]  = "P ID 82";
            jezik[83]  = "P ID 83";
            jezik[84]  = "P ID 84";

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
