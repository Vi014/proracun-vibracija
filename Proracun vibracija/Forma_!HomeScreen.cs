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
        public Forma_Centar_Glavni FormaCentarGlavni;
        public Forma_Desni_Glavni  FormaDesniGlavni;

        public Forma_HomeScreen()
        {
            InitializeComponent();
        }

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
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D6_Click",

                                // Forma_Centar_Agregat_Grafik
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Grafik.Text",
                                "Iscrtaj ponovo",
                                "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D1_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D1_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D2_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D2_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D3_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D3_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D4_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D4_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D5_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D5_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D6_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D6_Click USLOV NE ISPUNJEN",
                                "D1",
                                "D2",
                                "D3",
                                "D4",
                                "D5",
                                "D6",
                                "D1 - frekvencija alternatora",
                                "D2 - frekvencija kompresora klime",
                                "D3 - frekvencija servo volana",
                                "D4 - frekvencija pumpe za vodu",
                                "D5 - frekvencija dodatnog agregata 1",
                                "D6 - frekvencija dodatnog agregata 2",

                                // Forma_Desni_Glavni
                                "Vibracije vozila",
                                "Decimale se označavaju tačkom, ne zarezom.",
                                "Dimenzije pneumatika",
                                "Širina",
                                "Visina",
                                "Prečnik felne",
                                "Prenosni odnos diferencijala",
                                "mm",
                                "%",
                                "Inča",
                                "Izmerene vrednosti",
                                "Brzina vozila (km/h)",
                                "Frekvencija",
                                "Izvrši racun",
                                "Greška, nedovoljno polja popunjeno.",
                                "Greška, u nekom od polja je uneta nevažeća vrednost.",

                                // Forma_Desni_Tabela
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.Text",
                                "Brzina vozila",
                                "Frekvencije točka",
                                "Prvog reda",
                                "Drugog reda",
                                "Trećeg reda",
                                "Četvrtog reda",
                                "Frekvencije kardana",
                                "Prvog reda",
                                "Drugog reda",
                                "Trećeg reda",
                                "Četvrtog reda",
                                "Izmerene frekvencije",
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx1_Click()",
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx2_Click()",
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx3_Click()",
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx4_Click()",
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx1_Click()",
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx2_Click()",
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx3_Click()",
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx4_Click()",

                                // Forma_Desni_Grafik
                                "PLACEHOLDERSTRING Forma_Desni_Grafik.Text",
                                "Iscrtaj ponovo",
                                "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx1_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx1_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx2_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx2_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx3_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx3_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx4_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx4_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx1_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx1_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx2_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx2_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx3_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx3_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx4_Click USLOV ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx4_Click USLOV NE ISPUNJEN",
                                "FT",
                                "FT2",
                                "FT3",
                                "FT4",
                                "FK",
                                "FK2",
                                "FK3",
                                "FK4",
                                "FT - frekvencija točka prvog reda",
                                "FT2 - frekvencija točka drugog reda",
                                "FT3 - frekvencija točka trećeg reda",
                                "FT4 - frekvencija točka četvrtog reda",
                                "FK - frekvencija kardana prvog reda",
                                "FK2 - frekvencija kardana drugog reda",
                                "FK3 - frekvencija kardana trećeg reda",
                                "FK4 - frekvencija kardana četvrtog reda"
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
                    if (FormaCentarGlavni.FormaCentarAgregatGlavni.FormaCentarAgregatGrafik != null) FormaCentarGlavni.FormaCentarAgregatGlavni.FormaCentarAgregatGrafik.PromenaJezika();
                }
            }

            if (FormaDesniGlavni != null)
            {
                FormaDesniGlavni.PromenaJezika();
                if (FormaDesniGlavni.FormaDesniTabela != null) FormaDesniGlavni.FormaDesniTabela.PromenaJezika();
                if (FormaDesniGlavni.FormaDesniGrafik != null) FormaDesniGlavni.FormaDesniGrafik.PromenaJezika();
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

            // Forma_Centar_Agregat_Grafik
            jezik[85]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Grafik.Text";
            jezik[86]  = "Iscrtaj ponovo";
            jezik[87]  = "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:";
            jezik[88]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D1_Click USLOV ISPUNJEN";
            jezik[89]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D1_Click USLOV NE ISPUNJEN";
            jezik[90]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D2_Click USLOV ISPUNJEN";
            jezik[91]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D2_Click USLOV NE ISPUNJEN";
            jezik[92]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D3_Click USLOV ISPUNJEN";
            jezik[93]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D3_Click USLOV NE ISPUNJEN";
            jezik[94]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D4_Click USLOV ISPUNJEN";
            jezik[95]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D4_Click USLOV NE ISPUNJEN";
            jezik[96]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D5_Click USLOV ISPUNJEN";
            jezik[97]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D5_Click USLOV NE ISPUNJEN";
            jezik[98]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D6_Click USLOV ISPUNJEN";
            jezik[99]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D6_Click USLOV NE ISPUNJEN";
            jezik[100] = "D1";
            jezik[101] = "D2";
            jezik[102] = "D3";
            jezik[103] = "D4";
            jezik[104] = "D5";
            jezik[105] = "D6";
            jezik[106] = "D1 - frekvencija alternatora";
            jezik[107] = "D2 - frekvencija kompresora klime";
            jezik[108] = "D3 - frekvencija servo volana";
            jezik[109] = "D4 - frekvencija pumpe za vodu";
            jezik[110] = "D5 - frekvencija dodatnog agregata 1";
            jezik[111] = "D6 - frekvencija dodatnog agregata 2";

            // Forma_Desni_Glavni
            jezik[112] = "Vibracije vozila";
            jezik[113] = "Decimale se označavaju tačkom, ne zarezom.";
            jezik[114] = "Dimenzije pneumatika";
            jezik[115] = "Širina";
            jezik[116] = "Visina";
            jezik[117] = "Prečnik felne";
            jezik[118] = "Prenosni odnos diferencijala";
            jezik[119] = "mm";
            jezik[120] = "%";
            jezik[121] = "Inča";
            jezik[122] = "Izmerene vrednosti";
            jezik[123] = "Brzina vozila (km/h)";
            jezik[124] = "Frekvencija";
            jezik[125] = "Izvrši racun";
            jezik[126] = "Greška, nedovoljno polja popunjeno.";
            jezik[127] = "Greška, u nekom od polja je uneta nevažeća vrednost.";

            // Forma_Desni_Tabela
            jezik[128] = "PLACEHOLDERSTRING Forma_Desni_Tabela.Text";
            jezik[129] = "Brzina vozila";
            jezik[130] = "Frekvencije točka";
            jezik[131] = "Prvog reda";
            jezik[132] = "Drugog reda";
            jezik[133] = "Trećeg reda";
            jezik[134] = "Četvrtog reda";
            jezik[135] = "Frekvencije kardana";
            jezik[136] = "Prvog reda";
            jezik[137] = "Drugog reda";
            jezik[138] = "Trećeg reda";
            jezik[139] = "Četvrtog reda";
            jezik[140] = "Izmerene frekvencije";
            jezik[141] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx1_Click()";
            jezik[142] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx2_Click()";
            jezik[143] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx3_Click()";
            jezik[144] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx4_Click()";
            jezik[145] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx1_Click()";
            jezik[146] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx2_Click()";
            jezik[147] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx3_Click()";
            jezik[148] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx4_Click()";

            // Forma_Desni_Grafik
            jezik[149] = "PLACEHOLDERSTRING Forma_Desni_Grafik.Text";
            jezik[150] = "Iscrtaj ponovo";
            jezik[151] = "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:";
            jezik[152] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx1_Click USLOV ISPUNJEN";
            jezik[153] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx1_Click USLOV NE ISPUNJEN";
            jezik[154] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx2_Click USLOV ISPUNJEN";
            jezik[155] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx2_Click USLOV NE ISPUNJEN";
            jezik[156] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx3_Click USLOV ISPUNJEN";
            jezik[157] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx3_Click USLOV NE ISPUNJEN";
            jezik[158] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx4_Click USLOV ISPUNJEN";
            jezik[159] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx4_Click USLOV NE ISPUNJEN";
            jezik[160] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx1_Click USLOV ISPUNJEN";
            jezik[161] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx1_Click USLOV NE ISPUNJEN";
            jezik[162] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx2_Click USLOV ISPUNJEN";
            jezik[163] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx2_Click USLOV NE ISPUNJEN";
            jezik[164] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx3_Click USLOV ISPUNJEN";
            jezik[165] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx3_Click USLOV NE ISPUNJEN";
            jezik[166] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx4_Click USLOV ISPUNJEN";
            jezik[167] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx4_Click USLOV NE ISPUNJEN";
            jezik[168] = "FT";
            jezik[169] = "FT2";
            jezik[170] = "FT3";
            jezik[171] = "FT4";
            jezik[172] = "FK";
            jezik[173] = "FK2";
            jezik[174] = "FK3";
            jezik[175] = "FK4";
            jezik[176] = "FT - frekvencija točka prvog reda";
            jezik[177] = "FT2 - frekvencija točka drugog reda";
            jezik[178] = "FT3 - frekvencija točka trećeg reda";
            jezik[179] = "FT4 - frekvencija točka četvrtog reda";
            jezik[180] = "FK - frekvencija kardana prvog reda";
            jezik[181] = "FK2 - frekvencija kardana drugog reda";
            jezik[182] = "FK3 - frekvencija kardana trećeg reda";
            jezik[183] = "FK4 - frekvencija kardana četvrtog reda";

            PromenaJezika();
        }

        private void jezikDugme_Engleski_Click(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < jezik.Length; i++) jezik[i] = "P ID " + i.ToString();
            /*
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

            // Forma_Centar_Agregat_Grafik
            jezik[85]  = "P ID 85";
            jezik[86]  = "P ID 86";
            jezik[87]  = "P ID 87";
            jezik[88]  = "P ID 88";
            jezik[89]  = "P ID 89";
            jezik[90]  = "P ID 90";
            jezik[91]  = "P ID 91";
            jezik[92]  = "P ID 92";
            jezik[93]  = "P ID 93";
            jezik[94]  = "P ID 94";
            jezik[95]  = "P ID 95";
            jezik[96]  = "P ID 96";
            jezik[97]  = "P ID 97";
            jezik[98]  = "P ID 98";
            jezik[99]  = "P ID 99";
            jezik[100] = "P ID 100";
            jezik[101] = "P ID 101";
            jezik[102] = "P ID 102";
            jezik[103] = "P ID 103";
            jezik[104] = "P ID 104";
            jezik[105] = "P ID 105";
            jezik[106] = "P ID 106";
            jezik[107] = "P ID 107";
            jezik[108] = "P ID 108";
            jezik[109] = "P ID 109";
            jezik[110] = "P ID 110";
            jezik[111] = "P ID 111";

            // Forma_Desni_Glavni
            jezik[112] = "P ID 112";
            jezik[113] = "P ID 113";
            jezik[114] = "P ID 114";
            jezik[115] = "P ID 115";
            jezik[116] = "P ID 116";
            jezik[117] = "P ID 117";
            jezik[118] = "P ID 118";
            jezik[119] = "P ID 119";
            jezik[120] = "P ID 120";
            jezik[121] = "P ID 121";
            jezik[122] = "P ID 122";
            jezik[123] = "P ID 123";
            jezik[124] = "P ID 124";
            jezik[125] = "P ID 125";
            jezik[126] = "P ID 126";
            jezik[127] = "P ID 127";

            // Forma_Desni_Tabela
            jezik[128] = "P ID 128";
            jezik[129] = "P ID 129";
            jezik[130] = "P ID 130";
            jezik[131] = "P ID 131";
            jezik[132] = "P ID 132";
            jezik[133] = "P ID 133";
            jezik[134] = "P ID 134";
            jezik[135] = "P ID 135";
            jezik[136] = "P ID 136";
            jezik[137] = "P ID 137";
            jezik[138] = "P ID 138";
            jezik[139] = "P ID 139";
            jezik[140] = "P ID 140";
            jezik[141] = "P ID 141";
            jezik[142] = "P ID 142";
            jezik[143] = "P ID 143";
            jezik[144] = "P ID 144";
            jezik[145] = "P ID 145";
            jezik[146] = "P ID 146";
            jezik[147] = "P ID 147";
            jezik[148] = "P ID 148";
            jezik[149] = "P ID 149"; */

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

        private void dugmeDesno_Click(object sender, EventArgs e)
        {
            FormaDesniGlavni = new Forma_Desni_Glavni(this);
            FormaDesniGlavni.Owner = this;
            FormaDesniGlavni.Show();

            dugmeDesno.Enabled = false;
        }

        public Boolean dugmeDesnoEnabled
        {
            get { return dugmeDesno.Enabled;  }
            set { dugmeDesno.Enabled = value; }
        }
    }
}
