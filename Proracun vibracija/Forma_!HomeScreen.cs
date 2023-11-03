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
#pragma warning disable IDE1006 // dobijam upozorenje ako koristim PascalCasing za public promenljive i camelCasing za private promenljive, a ne ako uradim suprotno???
        public Forma_TestVoznja    FormaTestVoznja;
        public Forma_Centar_Glavni FormaCentarGlavni;
        public Forma_Desni_Glavni  FormaDesniGlavni;
        public Forma_Uvod          FormaUvod;

        public Forma_HomeScreen()
        {
            InitializeComponent();
        }

        #region Jezik

        public String[] Jezik = new String[511];

        private void promenaJezika()
        {
            this.Text         = Jezik[0];
            dugmeLevo.Text    = Jezik[1];
            dugmeCentar.Text  = Jezik[2];
            dugmeDesno.Text   = Jezik[3];
            dugmeDodatno.Text = Jezik[250];

            if (FormaUvod != null)       FormaUvod.PromenaJezika();

            if (FormaTestVoznja != null) FormaTestVoznja.PromenaJezika();

            if (FormaCentarGlavni != null) 
            {
                FormaCentarGlavni.PromenaJezika();
                if (FormaCentarGlavni.FormaCentarTabela != null) FormaCentarGlavni.FormaCentarTabela.PromenaJezika();
                if (FormaCentarGlavni.FormaCentarGrafik != null) FormaCentarGlavni.FormaCentarGrafik.PromenaJezika();
                if (FormaCentarGlavni.FormaCentarTekst  != null) FormaCentarGlavni.FormaCentarTekst.PromenaJezika();

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
                if (FormaDesniGlavni.FormaDesniTekstTocak     != null) FormaDesniGlavni.FormaDesniTekstTocak.PromenaJezika();
                if (FormaDesniGlavni.FormaDesniTekstDriveline != null) FormaDesniGlavni.FormaDesniTekstDriveline.PromenaJezika();
            }
        }

        private void jezikDugme_Srpski_Click(object sender, EventArgs e)
        {
            // Forma_HomeScreen
            Jezik[0] = "Proračun vibracija";
            Jezik[1] = "Saveti za test vožnju";
            Jezik[2] = "Motor";
            Jezik[3] = "Auto";
            Jezik[4] = "PLACEHOLDERSTRING Form1.dugmeLevo_Click";

            // Forma_Centar_Glavni
            Jezik[5] = "Vibracije motora";
            Jezik[6] = "Unos podataka";
            Jezik[7] = "Decimale se označavaju tačkom, ne zarezom.";
            Jezik[8] = "RPM";
            Jezik[9] = "Izmerena frekvencija";
            Jezik[10] = "Broj cilindara";
            Jezik[11] = "Potvrdi podatke";
            Jezik[12] = "Vibracije agregata";
            Jezik[13] = "Greška, nedovoljan broj polja popunjen. Neophodno je popuniti barem jedno od polja za RPM i uneti barem jednu frekvenciju za to polje.";
            Jezik[14] = "Greška, u nekom od polja je uneta nevažeća vrednost.";

            // Forma_Centar_Tabela
            Jezik[15] = "Vibracije motora";
            Jezik[16] = "RPM";
            Jezik[17] = "Prvog reda";
            Jezik[18] = "Drugog reda";
            Jezik[19] = "Trećeg reda";
            Jezik[20] = "Četvrtog reda";
            Jezik[21] = "Frekvencija bregaste";
            Jezik[22] = "Frekvencija paljenja";
            Jezik[23] = "Izmerene frekvencije";
            Jezik[24] = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM_Click";
            Jezik[25] = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM2_Click";
            Jezik[26] = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM3_Click";
            Jezik[27] = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM4_Click";
            Jezik[28] = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FB_Click";
            Jezik[29] = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FP_Click";

            // Forma_Centar_Grafik
            Jezik[30] = "Vibracije motora";
            Jezik[31] = "Iscrtaj ponovo";
            Jezik[32] = "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:";
            Jezik[33] = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM_Click USLOV ISPUNJEN";
            Jezik[34] = "Uslov nije ispunjen";
            Jezik[35] = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM2_Click USLOV ISPUNJEN";
            Jezik[36] = "Uslov nije ispunjen";
            Jezik[37] = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM3_Click USLOV ISPUNJEN";
            Jezik[38] = "Uslov nije ispunjen";
            Jezik[39] = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM4_Click USLOV ISPUNJEN";
            Jezik[40] = "Uslov nije ispunjen";
            Jezik[41] = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FB_Click USLOV ISPUNJEN";
            Jezik[42] = "Uslov nije ispunjen";
            Jezik[43] = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FP_Click USLOV ISPUNJEN";
            Jezik[44] = "Uslov nije ispunjen";
            Jezik[45] = "FM";
            Jezik[46] = "FM2";
            Jezik[47] = "FM3";
            Jezik[48] = "FM4";
            Jezik[49] = "FB";
            Jezik[50] = "FP";
            Jezik[51] = "FM - frekvencija motora";
            Jezik[52] = "FM2 - frekvencija motora drugog reda";
            Jezik[53] = "FM3 - frekvencija motora trećeg reda";
            Jezik[54] = "FM4 - frekvencija motora četvrtog reda";
            Jezik[55] = "FB - frekvencija bregaste";
            Jezik[56] = "FP - frekvencija paljenja";

            // Forma_Centar_Agregat_Glavni
            Jezik[57] = "Unos podataka";
            Jezik[58] = "Decimale se označavaju tačkom, ne zarezom.";
            Jezik[59] = "Radilice";
            Jezik[60] = "Alternatora";
            Jezik[61] = "Kompresora klime";
            Jezik[62] = "Servo volana";
            Jezik[63] = "Pumpe za vodu";
            Jezik[64] = "Dodatnog agregata 1";
            Jezik[65] = "Dodatnog agregata 2";
            Jezik[66] = "Potvrdi podatke";
            Jezik[67] = "Greška, nedovoljno polja popunjeno.  Neophodno je popuniti barem polje za prečnik remenice radilice i još jedno polje.";
            Jezik[68] = "Greška, u nekom od polja je uneta nevažeća vrednost.";

            // Forma_Centar_Agregat_Tabela
            Jezik[69] = "Proračun vibracija agregata";
            Jezik[70] = "RPM";
            Jezik[71] = "Frekvencija: ";
            Jezik[72] = "Alternatora";
            Jezik[73] = "Kompresora klime";
            Jezik[74] = "Servo volana";
            Jezik[75] = "Pumpe za vodu";
            Jezik[76] = "Dodatnog agregata 1";
            Jezik[77] = "Dodatnog agregata 2";
            Jezik[78] = "Izmerene frekvencije";
            Jezik[79] = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D1_Click";
            Jezik[80] = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D2_Click";
            Jezik[81] = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D3_Click";
            Jezik[82] = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D4_Click";
            Jezik[83] = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D5_Click";
            Jezik[84] = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D6_Click";

            // Forma_Centar_Agregat_Grafik
            Jezik[85] = "PLACEHOLDERSTRING Forma_Centar_Agregat_Grafik.Text";
            Jezik[86] = "Iscrtaj ponovo";
            Jezik[87] = "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:";
            Jezik[88] = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D1_Click USLOV ISPUNJEN";
            Jezik[89] = "Uslov nije ispunjen";
            Jezik[90] = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D2_Click USLOV ISPUNJEN";
            Jezik[91] = "Uslov nije ispunjen";
            Jezik[92] = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D3_Click USLOV ISPUNJEN";
            Jezik[93] = "Uslov nije ispunjen";
            Jezik[94] = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D4_Click USLOV ISPUNJEN";
            Jezik[95] = "Uslov nije ispunjen";
            Jezik[96] = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D5_Click USLOV ISPUNJEN";
            Jezik[97] = "Uslov nije ispunjen";
            Jezik[98] = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D6_Click USLOV ISPUNJEN";
            Jezik[99] = "Uslov nije ispunjen";
            Jezik[100] = "D1";
            Jezik[101] = "D2";
            Jezik[102] = "D3";
            Jezik[103] = "D4";
            Jezik[104] = "D5";
            Jezik[105] = "D6";
            Jezik[106] = "D1 - frekvencija alternatora";
            Jezik[107] = "D2 - frekvencija kompresora klime";
            Jezik[108] = "D3 - frekvencija servo volana";
            Jezik[109] = "D4 - frekvencija pumpe za vodu";
            Jezik[110] = "D5 - frekvencija dodatnog agregata 1";
            Jezik[111] = "D6 - frekvencija dodatnog agregata 2";

            // Forma_Desni_Glavni
            Jezik[112] = "Vibracije vozila";
            Jezik[113] = "Decimale se označavaju tačkom, ne zarezom.";
            Jezik[114] = "Dimenzije pneumatika";
            Jezik[115] = "Širina";
            Jezik[116] = "Visina";
            Jezik[117] = "Prečnik felne";
            Jezik[118] = "Prenosni odnos diferencijala";
            Jezik[119] = "mm";
            Jezik[120] = "%";
            Jezik[121] = "Inča";
            Jezik[122] = "Izmerene vrednosti";
            Jezik[123] = "Brzina vozila (km/h)";
            Jezik[124] = "Frekvencija";
            Jezik[125] = "Potvrdi podatke";
            Jezik[126] = "Greška, nedovoljno polja popunjeno. Neophodno je popuniti barem polja za širinu, visinu i prečnik felne (kao i ista za drugu osovinu u slučaju da su dimenzije za nju različite), i uneti barem jednu brzinu i frekvenciju za tu brzinu.";
            Jezik[127] = "Greška, u nekom od polja je uneta nevažeća vrednost.";

            // Forma_Desni_Tabela
            Jezik[128] = "Vibracije vozila";
            Jezik[129] = "Brzina vozila";
            Jezik[130] = "Frekvencije točka 1";
            Jezik[131] = "Prvog reda";
            Jezik[132] = "Drugog reda";
            Jezik[133] = "Trećeg reda";
            Jezik[134] = "Četvrtog reda";
            Jezik[135] = "Frekvencije kardana 1";
            Jezik[136] = "Prvog reda";
            Jezik[137] = "Drugog reda";
            Jezik[138] = "Trećeg reda";
            Jezik[139] = "Četvrtog reda";
            Jezik[140] = "Izmerene frekvencije";
            Jezik[141] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx1_Click()";
            Jezik[142] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx2_Click()";
            Jezik[143] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx3_Click()";
            Jezik[144] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx4_Click()";
            Jezik[145] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx1_Click()";
            Jezik[146] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx2_Click()";
            Jezik[147] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx3_Click()";
            Jezik[148] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx4_Click()";

            // Forma_Desni_Grafik
            Jezik[149] = "Vibracije vozila";
            Jezik[150] = "Iscrtaj ponovo";
            Jezik[151] = "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:";
            Jezik[152] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx1_Click USLOV ISPUNJEN";
            Jezik[153] = "Uslov nije ispunjen";
            Jezik[154] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx2_Click USLOV ISPUNJEN";
            Jezik[155] = "Uslov nije ispunjen";
            Jezik[156] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx3_Click USLOV ISPUNJEN";
            Jezik[157] = "Uslov nije ispunjen";
            Jezik[158] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx4_Click USLOV ISPUNJEN";
            Jezik[159] = "Uslov nije ispunjen";
            Jezik[160] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx1_Click USLOV ISPUNJEN";
            Jezik[161] = "Uslov nije ispunjen";
            Jezik[162] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx2_Click USLOV ISPUNJEN";
            Jezik[163] = "Uslov nije ispunjen";
            Jezik[164] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx3_Click USLOV ISPUNJEN";
            Jezik[165] = "Uslov nije ispunjen";
            Jezik[166] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx4_Click USLOV ISPUNJEN";
            Jezik[167] = "Uslov nije ispunjen";
            Jezik[168] = "FT";
            Jezik[169] = "FT2";
            Jezik[170] = "FT3";
            Jezik[171] = "FT4";
            Jezik[172] = "FK";
            Jezik[173] = "FK2";
            Jezik[174] = "FK3";
            Jezik[175] = "FK4";
            Jezik[176] = "FT - frekvencija točka prvog reda";
            Jezik[177] = "FT2 - frekvencija točka drugog reda";
            Jezik[178] = "FT3 - frekvencija točka trećeg reda";
            Jezik[179] = "FT4 - frekvencija točka četvrtog reda";
            Jezik[180] = "FK - frekvencija kardana prvog reda";
            Jezik[181] = "FK2 - frekvencija kardana drugog reda";
            Jezik[182] = "FK3 - frekvencija kardana trećeg reda";
            Jezik[183] = "FK4 - frekvencija kardana četvrtog reda";

            // jezik 2 elektrik bugalu

            // Forma_Desni_Glavni
            Jezik[184] = "Dimenzije pneumatika na drugoj osovini su različite";
            Jezik[185] = "Širina 2";
            Jezik[186] = "Visina 2";
            Jezik[187] = "Prečnik felne 2";
            Jezik[188] = "mm";
            Jezik[189] = "%";
            Jezik[190] = "Inča";

            // Forma_TestVoznja
            Jezik[191] = "Saveti za test vožnju";

            // Forma_Desni_Grafik
            Jezik[192] = "Dimenzije 1";
            Jezik[193] = "Dimenzije 2";
            Jezik[194] = "FT";
            Jezik[195] = "FT2";
            Jezik[196] = "FT3";
            Jezik[197] = "FT4";
            Jezik[198] = "FK";
            Jezik[199] = "FK2";
            Jezik[200] = "FK3";
            Jezik[201] = "FK4";

            // Forma_Desni_Tabela
            Jezik[202] = "Frekvencije točka 2";
            Jezik[203] = "Frekvencije kardana 2";

            // Forma_TestVoznja -- NA ENGLESKOM
            Jezik[204] = "Pre-Road Test inspection";
            Jezik[205] = "Road test";
            Jezik[206] = "Pre-Road Test inspection \r\nCheck the tires for: \n      - Inflation pressure \r\n      - Proper tire type \r\n      - Verify the tires are uniform in size and brand \r\n      - Abnormal tire wear and correct thread depth \r\nCheck the wheels for: \r\n      - Mud, ice and debris \r\n      - Deformed or bent \r\n      - Missing wheel weights \r\n      - Log nuts tightening torque \r\nCheck the vehicle for: \r\n      - Signs of damaged components \r\n      - Signs of collision damage \r\n      - Added components \r\nNotes: \r\n      - It is important to know which specific concern the customer has with their vehicle \r\n       - Don't be misled by the reported location of the noise or vibration, cause may be in another area of vehicle \r\n      - The vibrating component may only generate a small vibration, but this small vibration may cause a larger vibration or noise. \r\n      - It must be possible to operate the vehicle at the speed in which the condition occurs. \r\n      - Prepare measuring equipment.";
            Jezik[207] = "Back";
            Jezik[208] = "Road test \r\nIn order to determine engine speed, vehicle speed and frequency of the NVH concern, as well to establish is it a engine \r\nor vehicle speed related vibrations, perform the test drive: ";
            Jezik[209] = "Slow Acceleration Test";
            Jezik[210] = "Neutral Coast-Down Speed Test";
            Jezik[211] = "Downshift Speed Test";
            Jezik[212] = "Torque Converter Test";
            Jezik[213] = "Steering Test 1";
            Jezik[214] = "Steering Test 2";
            Jezik[215] = "Neutral Run-Up Test";
            Jezik[216] = "Engine Loaded Test";
            Jezik[217] = "Engine Accessory Test";
            Jezik[218] = "Back";
            Jezik[219] = "Slow Acceleration Test";
            Jezik[220] = "The first vehicle check to determine a related symptom of an NVH concern is the slow acceleration test. \r\nThis test is used to identify the noise or vibration if a road test with the customer was not possible. \r\nThe steps of the slow acceleration test are: \r\n      1. Slowly accelerate the vehicle to the speed at which the problem occurs. \r\n      2. Note the vehicle speed and the engine RPM. \r\n      3. If possible, determine the frequency of the noise or vibration. \r\n      4. Classify the noise or vibration.";
            Jezik[221] = "Back";
            Jezik[222] = "Neutral Coast-Down Speed Test";
            Jezik[223] = "The next vehicle check when performing the road test is the neutral coast-down speed test. \r\nThis test divides the possible causes of the noise or vibration into two categories: \r\n      - Vehicle speed-related \r\n      - Engine speed-related \r\nThe steps of the neutral coast-down speed test are: \r\n1. Drive the vehicle at a speed higher than the speed in which the noise or vibration was obvious during the slow acceleration test. \r\n2. Place the vehicle in Neutral and coast down through the speed at which the concern occurs. \r\n3. Classify the NVH concern as either vehicle speed-related or engine speed-related. \r\n      - If the noise or vibration exists, then the concern is vehicle speed related. \r\n         This eliminats the engine and torque converter as possible causes. \r\n      - If the NVH concern did not occur during the neutral coast-down speed test, \r\n         perform a downshift speed test to confirm the concern as engine speed-related.";
            Jezik[224] = "Back";
            Jezik[225] = "Downshift Speed Test";
            Jezik[226] = "This vehicle check helps to confirm the NVH concern as engine speed-related. The steps of the downshift speed test are: \r\n1. Stop the vehicle and place the transmission in a lower gear. \r\n2. Drive the vehicle at the engine RPM at which the noise or vibration occurs. \r\n      - If the noise or vibration exists, then the concern is engine speed-related. \r\n         This eliminates tires, wheels, brakes, and suspension components. \r\n      - If necessary, repeat the test using other gears and Neutral to confirm the results.";
            Jezik[227] = "Back";
            Jezik[228] = "Torque Converter Test";
            Jezik[229] = "This vehicle check determines how the torque converter contributes to an engine speed-related condition. \r\nThe steps of the torque converter test are: \r\n1. Drive the vehicle at the speed at which the NVH concern exists. \r\n2. Operate the torque converter by taking it in and out of lock-up by lightly depressing the brake pedal, \r\n      while maintaining vehicle speed. \r\n3. Check for noise when the torque converter is not locked up.";
            Jezik[230] = "Back";
            Jezik[231] = "Steering Test 1";
            Jezik[232] = "These tests determine if the wheel bearings and other suspension components are contributing to a speed-related condition. \r\nThe steps of the Steering Input Test 1 are:\r\n1. Drive the vehicle at the speed at which the NVH concern exists.\r\n2. Make wide sweeping turns in both directions. \r\nIf the concern goes away or gets worse, wheel bearings, hubs, Universal Joints (U-joints), drive axles, constant velocity joints and \r\ntire tread wear may be the components causing the concern. \r\nIf the noise or vibration exists, the concern is engine speed related.";
            Jezik[233] = "Back";
            Jezik[234] = "Steering Test 2";
            Jezik[235] = "Perform the Steering Input Test 2 if the NVH condition occurs when turning only. The steps of Steering Input Test 2 are: \r\n1. Drive the vehicle at a speed higher than the speed at which the noise or vibration occurs. \r\n2. Place the vehicle in Neutral and coast down through the speed at which the NVH concern is obvious, while making wide sweeping \r\n      turns in both directions. \r\nIf the concern exists, check for worn wheel bearings, suspension bushings, constant velocity joints and U-joints (contained in the \r\naxles of AWD applications). \r\nIf the vibration does not occur, stop the vehicle and engage the transmission/transaxle. \r\nAlternately accelerate and decelerate through the speed at which the NVH concern appears, while making wide sweeping turns in \r\nboth directions. \r\nIf the concern returns, then the cause is dependent upon engine load. The probable causes are constant velocity joints or U-joints \r\n(contained in the axles of AWD applications) and loose or missing wheel nuts. \r\nIf the noise is a “clunking sound,” engine and transaxle mounts, suspension bushings and U-joints are probable causes.";
            Jezik[236] = "Back";
            Jezik[237] = "Neutral Run-Up Test";
            Jezik[238] = "Perform the Neutral Run-Up Test if the NVH concern is engine speed-related. \r\nUse the test as a follow-up to the downshift test or when the NVH concern occurs at idle. The steps are: \r\n1. Increase the engine RPM while in Park or Neutral. \r\n2. If necessary, make note of the RPM and frequency of the NVH concern.";
            Jezik[239] = "Back";
            Jezik[240] = "Engine Loaded Test";
            Jezik[241] = "Perform the Engine Loaded Test if the NVH concern is engine speed-related. \r\nThis test may help reproduce engine speed-related concerns not evident with the neutral run-up or neutral coast-down speed tests. \r\nThe engine loaded test also identifies noise and vibration sensitive to engine load or torque. \r\nThese NVH concerns often appear during heavy acceleration or when climbing a hill.";
            Jezik[242] = "Warning: Block the front and back wheels or injury to personnel may result. \r\nDo not exceed five seconds when performing the engine loaded test or damage to the transmission/transaxle may result.";
            Jezik[243] = "The steps of the Engine Loaded Test are: \r\n1. Block the front and back wheels.\r\n2. Apply the parking and service brakes. \r\n3. Put the transmission in Drive while keeping the brakes applied. \r\n4. Increase the engine rpm to the rpm at which the NVH concern occurred. If necessary, make note of the RPM and frequency \r\n      of the NVH concern. \r\n5. Return the engine to idle. \r\n6. Put the transmission in Reverse while keeping the brakes applied. \r\n7. Increase the engine RPM to the RPM at which the NVH concern occurred. If necessary, make note of the RPM and frequency \r\n      of the NVH concern. \r\n      If the concern is definitely engine speed-related, perform the Engine Accessory Test to narrow down the possible source of the \r\n      concern.";
            Jezik[244] = "Immediately after doing an engine loaded test, run in neutral for 3 minutes at a slightly elevated RPM to cool the \r\ntransmission.";
            Jezik[245] = "Back";
            Jezik[246] = "Engine Accessory Test";
            Jezik[247] = "Perform the Engine Accessory Test if the NVH concern is engine speed-related. \r\nThis test helps locate faulty belts and accessories that are causing engine speed-related NVH concerns. \r\nThe steps are: \r\n1. Block the front and back wheels. \r\n2. Apply the parking and service brakes. \r\n3. Remove the accessory drive belt(s). \r\n4. Increase engine rpm to the rpm at which the NVH concern occurred. \r\n      - If the vibration occurs, the belts and accessories are not the source of the concern.\r\n      - If the belts and accessories are the source of the NVH concern, continue to add or remove specific accessory belts to locate \r\n         the concern";
            Jezik[248] = "Caution: With the accessory belt removed: \r\n      - Do not drive the vehicle\r\n      - Do not operate the engine for more than a few minutes or\r\n            • Water-cooled alternators can fail \r\n            • Engines can overheat";
            Jezik[249] = "Back";

            // Forma_HomeScreen
            Jezik[250] = "Uvod";

            // Forma_Uvod -- NA ENGLESKOM
            Jezik[251] = "Uvod";
            Jezik[252] = "Definitions";
            Jezik[253] = "Noise";
            Jezik[254] = "is defined as any unpleasant or unexpected sound created by a vibrating object.";
            Jezik[255] = "Vibration";
            Jezik[256] = "is defined as any objectionable repetitive motion of an object, back-and-forth or up-and-down.";
            Jezik[257] = "Harshness";
            Jezik[258] = "is defined as an aggressive suspension feel or lack of “give” in response to a single input.";
            Jezik[259] = "A";
            Jezik[260] = "sound";
            Jezik[261] = "is a vibration (pressure fluctuation) of the air.";
            Jezik[262] = "Vibrations and sounds are both expressed as waves per second called Hertz (Hz). \r\n      - Vibrations that are felt are under 200 Hz \r\n      - Vibrations between 20 Hz - 20,000 Hz are audible by humans \r\n      - Vibrations over 20,000 Hz are ultrasonic and are not audible by humans";
            Jezik[263] = "Noise and vibrations have some characteristics in common:";
            Jezik[264] = "      - Cycle \r\n      - Frequency \r\n      - Amplitude \r\n      - Order \r\n      - Resonance \r\n      - Transmission of vibrations and sound";
            Jezik[265] = "Cycle";
            Jezik[266] = "Cycle is the path a wave travels before the wave begins to repeat the path again. \r\ne.g. If the wheel makes 5 full revolutions this is equal to 5 complete cycles.";
            Jezik[267] = "Frequency";
            Jezik[268] = "Frequency is the number of complete cycles that occur in one second. \r\nSound and vibration waves are measured in Hz, or Cycles Per Second (CPS). \r\nFigure A shows a vibration of 3 Hz, and Figure B a vibration of 8 Hz.";
            Jezik[269] = "Figure A";
            Jezik[270] = "Figure B";
            Jezik[271] = "The higher the vibration, the higher the pitch of the sound will be. \r\ne.g. bearings rotating at a high speed will produce a very high pitched sound";
            Jezik[272] = "Amplitude";
            Jezik[273] = "Amplitude refers to the vertical measurement between the top and the bottom of a wave. \r\nTwo waves can have the same frequency, but differ in amplitude. \r\nAmplitude is the quantity or amount of energy produced by a vibrating component. \r\nLow amplitude (Figure A) is equal to low intensity, and high amplitude (Figure B) to high intensity";
            Jezik[274] = "Figure A";
            Jezik[275] = "Figure B";
            Jezik[276] = "Frequency order";
            Jezik[277] = "Order is number of disturbances created in one revolution of component. \r\nFor example (Figure A), a single high spot on a tire creates a first order disturbance (one disturbance per revolution) and therefore a \r\nfirst order vibration. \r\nIf the tire is rotating at a rate of 10 rotations per second it will create first order vibration of 10 Hz. \r\nA second high spot on tire would result in a second order disturbance, meaning that at the same speed, the vibration will be 20 Hz. \r\nSome components or systems may develop third and fourth order vibrations as well.";
            Jezik[278] = "Figure A";
            Jezik[279] = "Resonance";
            Jezik[280] = "Resonance is the tendency of a system to respond to a compelling force oscillating at a natural frequency of the system. \r\nAll objects have natural frequencies. \r\nThe amplitude of a vibration is greatest at the point of resonance. \r\nResonance occurs when the vibrating force (external force) on a vibrating system is moving at the same frequency (Hz) as the \r\nnatural frequency of that vibrating system. \r\nThe resulting wave that occurs is at the same frequency but with much greater amplitude (Figure A).";
            Jezik[281] = "The phenomenon of resonance means that the presence of one small vibration may create another very large vibration that can be \r\nfelt in the vehicle.";
            Jezik[282] = "Transmission of vibrations and sound";
            Jezik[283] = "Vibrations and sound are transmitted the same way. There has to be a: \r\n      - Vibrating force \r\n      - Resonating system \r\n      - Transmission system (path) \r\n      - Vibrating element (vibration)";
            Jezik[284] = "Sources of";
            Jezik[285] = "vibrating forces";
            Jezik[286] = "in vehicles could be:";
            Jezik[287] = "      - Combustion \r\n      - Tires contacting a rough road \r\n      - Imbalance or run-out of a rotating component \r\n      - Fluctuation of friction surfaces";
            Jezik[288] = "A";
            Jezik[289] = "Resonance System"; // 289
            Jezik[290] = "is any component on the vehicle that resonates when it recieves a vibrating force.";
            Jezik[291] = "All components will resonate if the vibrating force matches the natural frequency. \r\nSome examples are: \r\n      - Tires resonate when vibrated by the road \r\n      - Suspension systems will resonate with an out of balance tire \r\n      - An exhaust system will resonate when vibrated by the engine";
            Jezik[292] = "The"; // 292, label41
            Jezik[293] = "Transmission System";
            Jezik[294] = "is the path in the vehicle that carries the vibration from the resonance system to the vibrating element.";
            Jezik[295] = "Examples of a transmission system or path are the: \r\n      - Exhaust system \r\n      - Engine mounts";
            Jezik[296] = "These components carry engine vibrations through the vehicle.";
            Jezik[297] = "The";
            Jezik[298] = "Vibrating element";
            Jezik[299] = "is the component that generates the vibration or sound that can be sensed.";
            Jezik[300] = "Examples of Vibrating elements are: \r\n      - Body \r\n      - Steering wheel \r\n      - Seat \r\n      - Shifter \r\n      - Mirror";
            Jezik[301] = "In most cases, the NVH issue is resolved by fixing the source of the vibrating force, but sometimes any change in transmission \r\nprocess can solve the issue.";
            Jezik[302] = "For example: \r\n      - Vibrating force is engine \r\n      - Resonating system is exhaust \r\n      - Transmission system is contact of the exhaust and body \r\n      - Vibrating element is the body panel";
            Jezik[303] = "By repairing elastic contact between exhaust and body, the NVH problem will be resolved.";
            Jezik[304] = "Measuring the frequency";
            Jezik[305] = "In order to find the source of vehicle vibrations it is necessary to measure the vibrating frequency and engine/vehicle speed at which \r\nthat vibration frequency occurs. There are many tools for this purpose as shown in the figures below.";

            // Forma_Centar_!Glavni
            Jezik[306] = "U ovo polje mora biti unet broj između 100 i 8000."; // 306
            Jezik[307] = "U ovo polje mora biti unet broj između 1 i 500."; // 307
            // Forma_Centar_Agregat_Glavni
            Jezik[308] = "U ovo polje mora biti unet pozitivan broj."; // 308
            // Forma_Desni_Glavni
            Jezik[309] = "U ovo polje mora biti unet pozitivan broj."; // 309
            Jezik[310] = "U ovo polje mora biti unet broj između 5 i 200."; // 310

            // uopste korisceno
            Jezik[311] = "Greška"; // 311
            Jezik[312] = "Informacije"; // 312
            Jezik[313] = "Upozorenje"; // 
            Jezik[314] = "Povratak na vrh"; // 314 // na Forma_Uvod i Forma_Centar_Tekst

            // Forma_TestVoznja
            Jezik[315] = "Povratak na vrh"; // 315

            // Forma_Centar_!Glavni
            Jezik[316] = "Bez preseta"; // 316
            Jezik[317] = "Automobil 1"; // 317
            Jezik[318] = "Automobil 2"; // 318

            // Forma_Centar_Tekst -- NA ENGLESKOM
            Jezik[319] = "Vibracije motora"; // 319
            Jezik[320] = "Engine speed related vibrations";
            Jezik[321] = "Based on the frequency of the vibration and driving conditions, the noise or vibration can be isolated into three component groups: ";
            Jezik[322] = "      -";
            Jezik[323] = "Engine vibrations";
            Jezik[324] = "Engine firing frequency";
            Jezik[325] = "Engine accessory vibrations";
            Jezik[326] = "Engine vibrations";
            Jezik[327] = "First order";
            Jezik[328] = "A first-order engine imbalance is created when any component that rotates at crankshaft speed is out-of-balance or has excessive \r\nrunout.";
            Jezik[329] = "First order vibrations can be caused by: ";
            Jezik[330] = "      - an out    f balance flywheel or excesisve runout";
            Jezik[331] = "      -";
            Jezik[332] = "Crankshaft pulley (Torsional vibration dampener)";
            Jezik[333] = "      - Cylinder to cylinder mass difference";
            Jezik[334] = "      -";
            Jezik[335] = "Torque converter";
            Jezik[336] = "      - an imbalanced crankshaft"; // 336
            Jezik[337] = "Crankshaft pulley (Torsional vibration dampener)";
            Jezik[338] = "An out of balance or out of round TVD will transfer engine vibrations to the belt drive. An improper TVD (figure 1) will fail to dampen \r\ncrankshaft vibrations, which will be transferred to the belt drive.";
            Jezik[339] = "Figure 1a (TVD as specified)";
            Jezik[340] = "Figure 1b (Improper TVD)";
            Jezik[341] = "Torque converter";
            Jezik[342] = "The torque converter frrequency is equal to the engine frequency. The torque converter can be suspected as the cause of noise or \r\nvibration when an NVH concern is torque sensitive.";
            Jezik[343] = "Refer to torque converter test drive tips.";
            Jezik[344] = "Torque converter vibrations can be caused by:";
            Jezik[345] = "      -";
            Jezik[346] = "The movement of the fluid between the impeller, which is connected to the engine, and the turbine, which connects to the \r\ntransmission (in this case the vibration will disappear as soon as the TCC is engaged).";
            Jezik[347] = "      - Clutch engagement";
            Jezik[348] = "      - Clutch release during downshift or coasting";
            Jezik[349] = "      - Torque converter imabalnce or an incorrectly installed converter";
            Jezik[350] = "Second order";
            Jezik[351] = "Second order vibrations are caused either by two first order issues or by the up-and-down motion of the pistons. This reversal of \r\nmass and motion creates a natural vibration.";
            Jezik[352] = "On four cylinder engines, second order vibration is equal to";
            Jezik[353] = "engine firing frequency";
            Jezik[354] = "Third order";
            Jezik[355] = "On six cylinder engines, second order vibration is equal to";
            Jezik[356] = "engine firing frequency";
            Jezik[357] = "Fourth order";
            Jezik[358] = "On eight cylinder engines, second order vibration is equal to";
            Jezik[359] = "engine firing frequency";
            Jezik[360] = "Engine firing frequency";
            Jezik[361] = "Firing frequency refers to the force created by the engine each time the cylinder fires. This is the natural vibration of the internal \r\ncombustion engine. Firing frequency is load dependent. The higher the engine load is, the more prominent the frequency will be. \r\nIf there is a problem on the engine, which is affecting the combustion process, this vibration will increase.";
            Jezik[362] = "Even though firing frequency is natural to ICE, it has to be isolated from the vehicle body.";
            Jezik[363] = "Firing frequency vibrations could be caused by:";
            Jezik[364] = "      -";
            Jezik[365] = "Engine mounts";
            Jezik[366] = "      -";
            Jezik[367] = "Exhaust hangers";
            Jezik[368] = "      - Engine problems, affecting the combustion process";
            Jezik[369] = "Engine mounts";
            Jezik[370] = "The first components that isolate the passenger comprartment from engine vibrations are engine mounts. Any fault in the engine \r\nmounting system can directly lead to noise and vibration.";
            Jezik[371] = "Inspect the engine mounts for cracks or damage to the insulator and the bracket (figure 2). Grounded, the engine mount bracket \r\ncontacting the frame-mounted bracket, or strained engine mounts may not isolate engine vibrations.";
            Jezik[372] = "Engine mounts must be installed correctly and tightened with the specific torque. If the mounts are installed incorrectly or incorrect \r\nparts are used, they won't be able to absorb engine vibrations. Make sure the proper type of engine mount is installed. (figure 3)";
            Jezik[373] = "Figure 2";
            Jezik[374] = "Figure 3";
            Jezik[375] = "Exhaust hangers";
            Jezik[376] = "The compelling force of exhaust exiting each cylinder creates a pulsation on the exhaust manifold. The pulsating pressure at the \r\nexhaust manifold produces acoustic energy, which is transmitted to the exhaust pipe.";
            Jezik[377] = "The pulsating sound waves traveling through the exhaust pipe are a source of vibration from the exhaust system. The combined \r\nengine and exhaust vibrations within the exhaust system must be isolated to prevent them from acting on the body of the vehicle. \r\nExhaust hangers (figure 4) are used to suspend the exhaust pipe from the body and to prevent transmission of vibration to the body.";
            Jezik[378] = "Figure 4";
            Jezik[379] = "Engine accessory vibrations";
            Jezik[380] = "Engine accessory related vibrations can be found either by doing an engine accessory test (refer to test drive section) or by doing a \r\ncalculation based on engine RPM and the ratio between accessories and crankshaft pulley.";
            Jezik[381] = "Engine acessory vibrations could be caused by: \r\n      - An out of balance component \r\n      - Worn out components \r\n      - An out of round pulley \r\n      - An untigthened pulley \r\n      - An untightened component \r\n      - Worn out component shaft bearings \r\n      - Pressure fluctuation (e.g. power steering pump) \r\n      - Overcharged refrigerant (AC compressor)";
            // 38

            // Forma_Desni_Tekst_Driveline -- NA ENGLESKOM
            Jezik[382] = "Vibracije vozila";
            Jezik[383] = "Driveline-related concerns are usually caused by the following conditions: \r\n      - A propeller shaft imbalance \r\n      - A damaged propeller shaft \r\n      - Missing shaft balance weights \r\n      - Improper propeller shaft operating angles \r\n      - Worn universal or CV joint \r\n      - Worn center bearings \r\n      - Loose spring U-bolts \r\n      - Loose or broken springs \r\n      - Damaged axle shaft bearings \r\n      - A loose pinion gear nut \r\n      - Excessive pinion flange runout \r\n      - Pinion and ring gear pitch line variation";
            Jezik[384] = "Driveshaft vibrations can be classified into three different orders: first-order, second-order, and fourth-order.";
            Jezik[385] = "A first-order vibration may be caused by a: \r\n      - A damaged or bent propeller shaft \r\n      - Damaged driveline components \r\n      - Worn CV or U joint \r\n      - Propeller shaft imbalance \r\n      - Hydromount slipping \r\n      - Driveshaft central bearing damage \r\n      - Loose pinion gear nut \r\n      - Worn pinion gear";
            Jezik[386] = "A second-order vibration may be caused by a:  \r\n      - Driveshaft angle \r\n      - U-joint cancelation \r\n      - Worn CV or U joint";
            Jezik[387] = "A fourth-order vibration may be caused by a: \r\n      - Driveshaft angle \r\n      - Worn CV or U joint";
            Jezik[388] = "Check the following:";
            Jezik[389] = "      -";
            Jezik[390] = "Driveshaft runout";
            Jezik[391] = "      -";
            Jezik[392] = "Missing balance weights";
            Jezik[393] = "      -";
            Jezik[394] = "Pinion and ring gear pitch line";
            Jezik[395] = "      -";
            Jezik[396] = "Driveline operating angles";
            Jezik[397] = "Driveshaft runout";
            Jezik[398] = "Place the dial indicator at a 90 degree angle from the driveshaft and measure the runout at the ends of the driveshaft (figure 1), as \r\nwell as in the middle of the shaft (figure 2).";
            Jezik[399] = "Figure 1";
            Jezik[400] = "Figure 2";
            Jezik[401] = "If the measured values are not within vehicle manufacturer specifications (typically 0.5 mm at the ends and 0.6 mm at the middle), \r\nreplace the driveshaft.";
            Jezik[402] = "Back";
            Jezik[403] = "Missing balance weights";
            Jezik[404] = "Visually check for missing driveshaft balance weights (figure 3).";
            Jezik[405] = "Figure 3";
            Jezik[406] = "Back";
            Jezik[407] = "Pinion and ring gear pitch line";
            Jezik[408] = "If the contact between pinion and ring gear is uneven (there is an excessive pitch line runout), the ring gear speed will vary and \r\ncause the driveline vibrations. \r\nRemove the axle cover, and with the aid of special paint, check for the correct contact patter between the ring and pinion gear \r\n(figure 4).";
            Jezik[409] = "Figure 4";
            Jezik[410] = "Back";
            Jezik[411] = "Driveline operating angles";
            Jezik[412] = "The operating angle of a universal joint is the difference between the angles formed when two shafts intersect. \r\nIn a one-piece propeller shaft system, there are two operating angles present: the front and the rear.";
            Jezik[413] = "The front operating angle is formed by the angle of the propeller shaft and the angle of the transmission output shaft (figure 5).";
            Jezik[414] = "Figure 5";
            Jezik[415] = "The rear operating angle is formed by the angle of the propeller shaft and the angle of the rear axle pinion.";
            Jezik[416] = "To check driveline alignment, raise and support the vehicle at the axles as level as possible. \r\nAllow the wheels and propeller shaft to turn.";
            Jezik[417] = "Record angle A (figure 6). \r\nRotate the shaft until the transmission yoke bearing is facing downwards. \r\nPlace the inclinometer on the yoke bearing parallel to the shaft and record measurement A.";
            Jezik[418] = "Record angle B (figure 6). \r\nRotate the shaft until the pinion yoke bearing is facing downwards. \r\nPlace the inclinometer on the yoke bearing parallel to the shaft and record measurement B.";
            Jezik[419] = "Record angle C (figure 6). \r\nRotate the shaft for 90 degrees until the propeller shaft yoke bearing is facing downwards. \r\nPlace the inclinometer on the yoke bearing parallel to the shaft and record measurement C. Angle C can be measured on both ends, \r\nas well as on the shaft itself.";
            Jezik[420] = "Figure 6";
            Jezik[421] = "Front angle is equal to Angle C - Angle A \r\nRear angle is equal to Angle C - Angle B";
            Jezik[422] = "      -";
            Jezik[423] = "Both the front and rear angles must be within the vehicle manufacturer's specifications";
            Jezik[424] = "      -";
            Jezik[425] = "The front and rear angles need to be within one degree of each other (Typical value - check manufacturer specifications)";
            Jezik[426] = "      -";
            Jezik[427] = "The operating angles should be less than 3 degrees (Typical value - check manufacturer specifications)";
            Jezik[428] = "      -";
            Jezik[429] = "The rear angle has to be bigger than the front angle";
            Jezik[430] = "      -";
            Jezik[431] = "Neither angle can equal zero";
            Jezik[432] = "If the driveline is a two piece system additional angles have to be measured: \r\nthe input angle of the transmission, the transfer shaft angle, the driveshaft angle and the output angle of the pinion.";
            Jezik[433] = "Back";

            // Forma_Desni_Tekst_Tocak -- NA ENGLESKOM
            Jezik[434] = "Vibracije vozila"; // 434
            Jezik[435] = "Wheel frequency";
            Jezik[436] = "Wheel first odrer frequency is related to vibration caused by the wheels or anything which is rotating at the same speed as them.";
            Jezik[437] = "Some of the causes could be: \r\n      - Wheel and tire imbalance \r\n      - The condition of the wheels and tires \r\n      - Foreign debris in a wheel \r\n      - A wheel or tire that is out of round \r\n      - Uniformity \r\n      - Tire dimensions \r\n      - Conicity \r\n      - Radial force variation \r\n      - Brake rotor or brake drum imbalance \r\n      - Constant velocity (CV) shaft \r\n      - Excessive hub runout \r\n      - Axle shaft problems";
            Jezik[438] = "A higher order wheel frequency indicates several independent first order issues or a problem with: \r\n      - The joint between the wheels and the driveshaft \r\n      - Non-uniform tires on the vehicle \r\n      - Radial force variation";
            Jezik[439] = "Check the following:";
            Jezik[440] = "      -";
            Jezik[441] = "Balance the tire/wheel";
            Jezik[442] = "      -";
            Jezik[443] = "Radial wheel and tire assembly runout";
            Jezik[444] = "      -";
            Jezik[445] = "Lateral wheel and tire assembly runout";
            Jezik[446] = "      -";
            Jezik[447] = "Radial wheel runout";
            Jezik[448] = "      -";
            Jezik[449] = "Lateral wheel runout";
            Jezik[450] = "      -";
            Jezik[451] = "Hub/Brake disc runout";
            Jezik[452] = "      -";
            Jezik[453] = "Radial force variation";
            Jezik[454] = "      -";
            Jezik[455] = "Bent axle shaft";
            Jezik[456] = "      -";
            Jezik[457] = "The joint between the wheels and the axle shaft";
            Jezik[458] = "Radial wheel and tire assembly runout";
            Jezik[459] = "Radial runout can be measured on the vehicle (hub, wheel and tire total runout).";
            Jezik[460] = "Raise the vehicle, apply masking tape on the circumference of the tire (figure 1), and check the runout with a dial gauge. \r\nThe measured value should be compared to the vehicle manufacturer's data (the maximum is typically 0.8 to 1 mm).";
            Jezik[461] = "Radial runout can also be measured off the vehicle. In this case the hub can be ruled out.";
            Jezik[462] = "Figure 1";
            Jezik[463] = "If the measured value is above specifications, the problem could be in the tire, wheel, or hub.";
            Jezik[464] = "Proceed with radial runout measurements";
            Jezik[465] = "If the measured value is below specifications, proceed with lateral runout measurements.";
            Jezik[466] = "Back";
            Jezik[467] = "Lateral wheel and tire assembly runout";
            Jezik[468] = "Measure the lateral runout with the dial gauge positioned on the flat surface of the tire sidewall (figure 2).";
            Jezik[469] = "The measured value should be compared to the vehicle manufacturer's data (the maximum is typically 0.8 to 1.2 mm).";
            Jezik[470] = "Figure 2";
            Jezik[471] = "If the measured value is above specifications, the problem could be in the tire, wheel, or hub.";
            Jezik[472] = "Proceed with lateral runout measurements.";
            Jezik[473] = "Back";
            Jezik[474] = "Radial wheel runout";
            Jezik[475] = "Radial wheel runout could be measured while the wheel is on the vehicle (wheel and hub total runout), or with the wheel off the \r\nvehicle (only the wheel runout). Place the dial gauge and measure the runout (figure 3).";
            Jezik[476] = "The measured value should be compared to the vehicle manufacturer's data (the maximum is typically 0.25 mm for alloy wheels and \r\n0.5 mm for steel wheels).";
            Jezik[477] = "Figure 3";
            Jezik[478] = "If the measured value is above specifications, the problem could be in the wheel or the hub.";
            Jezik[479] = "Proceed with radial runout measurements.";
            Jezik[480] = "If the value is within specifications, the problem is in the tire.";
            Jezik[481] = "Back";
            Jezik[482] = "Lateral wheel runout";
            Jezik[483] = "Lateral wheel runout could be measured whiel the wheel is on the vehicle (wheel and hub total runout), or with the wheel off the \r\nvehicle (only the wheel runout). Place the dial gauge and measure the runout (figure 4).";
            Jezik[484] = "The measured value should be compared to the vehicle manufacturer's data (the maximum is typically 0.5 to 0.8 mm).";
            Jezik[485] = "Figure 4";
            Jezik[486] = "If the measured value is above specifications, the problem could be in the wheel or the hub.";
            Jezik[487] = "Proceed with alteral runout measurements.";
            Jezik[488] = "If the value is within specifications, the problem is in the tire.";
            Jezik[489] = "Back";
            Jezik[490] = "Hub/Brake disc runout";
            Jezik[491] = "Measure the brake disc runout, either on the hub (figure 5) or off the vehicle (figure 6) and compare the measured value with the \r\nvehicle manufacturer's specifications.";
            Jezik[492] = "If the measured value on the hub is within specifications, the problem is on the wheel.";
            Jezik[493] = "If the measured value of the vehicle is within specifications, the problem is on the hub.";
            Jezik[494] = "Figure 5";
            Jezik[495] = "Figure 6";
            Jezik[496] = "Back";
            Jezik[497] = "Radial force variation";
            Jezik[498] = "Radial force variation is a term describing the tire unifomity under load, measuring the variation of the load acting on the vehicle \r\nspindle.";
            Jezik[499] = "If the sidewall stiffness of the tire is not uniform (figure 7), a vertical force is exerted on the axle making it move up and down. \r\nThis movement creates vibrations unrelated to wheel balance.";
            Jezik[500] = "Figure 7";
            Jezik[501] = "A tire with noticable radial force variation will produce a vibration even though it is perfectly balanced and is within the \r\nradial and lateral runout limits.";
            Jezik[502] = "Special equipment should be used to check for radial force variation (figure 8).";
            Jezik[503] = "Figure 8";
            Jezik[505] = "Back";
            Jezik[506] = "Bent axle shaft";
            Jezik[507] = "Place the dial indicator at a 90 degree angle from the axle shaft and measure the runout at the ends of the axle shaft, as well as in \r\nthe middle of the shaft (figure 9).";
            Jezik[508] = "Figure 9";
            Jezik[509] = "If the measured values are not within the vehicle manufacturer's specifications, replace the shaft.";

            promenaJezika();
        }
        
        private void jezikDugme_Engleski_Click(object sender, EventArgs e)
        {
            // Forma_HomeScreen
            Jezik[0]   = "Vibration calculator";
            Jezik[1]   = "Test drive tips";
            Jezik[2]   = "Engine";
            Jezik[3]   = "Vehicle";
            Jezik[4]   = "PLACEHOLDERSTRING Form1.dugmeLevo_Click";

            // Forma_Centar_Glavni
            Jezik[5]   = "Engine vibrations";
            Jezik[6]   = "Data entry";
            Jezik[7]   = "Decimals are denoted with a period, not a comma.";
            Jezik[8]   = "RPM";
            Jezik[9]   = "Measured frequency";
            Jezik[10]  = "No. of cylinders";
            Jezik[11]  = "Confirm";
            Jezik[12]  = "Accesories";
            Jezik[13]  = "An error has ocurred: you haven't filled in enough data fields. The minimum is at least one RPM field and one frequency for it.";
            Jezik[14]  = "An error has ocurred: you entered an invalid value in one or more of the fields.";

            // Forma_Centar_Tabela
            Jezik[15]  = "Engine vibrations";
            Jezik[16]  = "RPM";
            Jezik[17]  = "First order";
            Jezik[18]  = "Second order";
            Jezik[19]  = "Third order";
            Jezik[20]  = "Fourth order";
            Jezik[21]  = "Crankshaft frequency";
            Jezik[22]  = "Firing frequency";
            Jezik[23]  = "Measured frequencies";
            Jezik[24]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM_Click";
            Jezik[25]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM2_Click";
            Jezik[26]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM3_Click";
            Jezik[27]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM4_Click";
            Jezik[28]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FB_Click";
            Jezik[29]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FP_Click";

            // Forma_Centar_Grafik
            Jezik[30]  = "Engine vibrations";
            Jezik[31]  = "Redraw";
            Jezik[32]  = "In case the graph isn't properly drawn, line this window up with the top left corner of your screen and press the button:";
            Jezik[33]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM_Click USLOV ISPUNJEN";
            Jezik[34]  = "Frequency does not match";
            Jezik[35]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM2_Click USLOV ISPUNJEN";
            Jezik[36]  = "Frequency does not match";
            Jezik[37]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM3_Click USLOV ISPUNJEN";
            Jezik[38]  = "Frequency does not match";
            Jezik[39]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM4_Click USLOV ISPUNJEN";
            Jezik[40]  = "Frequency does not match";
            Jezik[41]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FB_Click USLOV ISPUNJEN";
            Jezik[42]  = "Frequency does not match";
            Jezik[43]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FP_Click USLOV ISPUNJEN";
            Jezik[44]  = "Frequency does not match";
            Jezik[45]  = "EF";
            Jezik[46]  = "EF2";
            Jezik[47]  = "EF3";
            Jezik[48]  = "EF4";
            Jezik[49]  = "CF";
            Jezik[50]  = "FF";
            Jezik[51]  = "EF - engine frequency first order";
            Jezik[52]  = "EF2 - engine frequency second order";
            Jezik[53]  = "EF3 - engine frequency third order";
            Jezik[54]  = "EF4 - engine frequency fourth order";
            Jezik[55]  = "CF - crankshaft frequency";
            Jezik[56]  = "FF - firing frequency";

            // Forma_Centar_Agregat_Glavni
            Jezik[57]  = "Data entry";
            Jezik[58]  = "Decimals are denoted with a period, not a comma.";
            Jezik[59]  = "Crankshaft";
            Jezik[60]  = "Alternator";
            Jezik[61]  = "AC compressor";
            Jezik[62]  = "Power steering";
            Jezik[63]  = "Water pump";
            Jezik[64]  = "Additional accessory 1";
            Jezik[65]  = "Additional accessory 2";
            Jezik[66]  = "Confirm";
            Jezik[67]  = "An error has ocurred: you haven't filled in enough fields. The minimum is at least the pulley diameter of the crankshaft and another field alongside it.";
            Jezik[68]  = "An error has ocurred: you entered an invalid value in one or more of the fields.";

            // Forma_Centar_Agregat_Tabela
            Jezik[69]  = "Accessory vibrations";
            Jezik[70]  = "RPM";
            Jezik[71]  = "Frequency of: ";
            Jezik[72]  = "Alternator";
            Jezik[73]  = "AC compressor";
            Jezik[74]  = "Power steering";
            Jezik[75]  = "Water pump";
            Jezik[76]  = "Additional accessory 1";
            Jezik[77]  = "Additional accessory 2";
            Jezik[78]  = "Measured frequencies";
            Jezik[79]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D1_Click";
            Jezik[80]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D2_Click";
            Jezik[81]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D3_Click";
            Jezik[82]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D4_Click";
            Jezik[83]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D5_Click";
            Jezik[84]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D6_Click";

            // Forma_Centar_Agregat_Grafik
            Jezik[85]  = "Accessory vibrations";
            Jezik[86]  = "Redraw";
            Jezik[87]  = "In case the graph isn't properly drawn, line this window up with the top left corner of your screen and press the button:";
            Jezik[88]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D1_Click USLOV ISPUNJEN";
            Jezik[89]  = "Frequency does not match";
            Jezik[90]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D2_Click USLOV ISPUNJEN";
            Jezik[91]  = "Frequency does not match";
            Jezik[92]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D3_Click USLOV ISPUNJEN";
            Jezik[93]  = "Frequency does not match";
            Jezik[94]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D4_Click USLOV ISPUNJEN";
            Jezik[95]  = "Frequency does not match";
            Jezik[96]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D5_Click USLOV ISPUNJEN";
            Jezik[97]  = "Frequency does not match";
            Jezik[98]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D6_Click USLOV ISPUNJEN";
            Jezik[99]  = "Frequency does not match";
            Jezik[100] = "D1";
            Jezik[101] = "D2";
            Jezik[102] = "D3";
            Jezik[103] = "D4";
            Jezik[104] = "D5";
            Jezik[105] = "D6";
            Jezik[106] = "D1 - alternator frequency";
            Jezik[107] = "D2 - AC compressor frequency";
            Jezik[108] = "D3 - power steering frequency";
            Jezik[109] = "D4 - water pump frequency";
            Jezik[110] = "D5 - additional accessory 1 frequency";
            Jezik[111] = "D6 - additional accessory 2 frequency";

            // Forma_Desni_Glavni
            Jezik[112] = "Vehicle vibrations";
            Jezik[113] = "Decimals are denoted with a period, not a comma.";
            Jezik[114] = "Tire dimensions";
            Jezik[115] = "Width";
            Jezik[116] = "Height";
            Jezik[117] = "Rim";
            Jezik[118] = "Differential gear ratio";
            Jezik[119] = "mm";
            Jezik[120] = "%";
            Jezik[121] = "Inches";
            Jezik[122] = "Measured values";
            Jezik[123] = "Vehicle speed (km/h)";
            Jezik[124] = "Frequency";
            Jezik[125] = "Confirm";
            Jezik[126] = "An error has ocurred: you haven't filled in enough fields. The minimum is height, width, and rim (as well as their equivalents for the other axle, if dimensions differ) as well as at least one speed and one frequency for it.";
            Jezik[127] = "An error has ocurred: you entered an invalid value in one or more of the fields.";

            // Forma_Desni_Tabela
            Jezik[128] = "Vehicle vibrations";
            Jezik[129] = "Vehicle speed";
            Jezik[130] = "Wheel 1 frequencies";
            Jezik[131] = "First order";
            Jezik[132] = "Second order";
            Jezik[133] = "Third order";
            Jezik[134] = "Fourth order";
            Jezik[135] = "Propeller shaft 1 frequencies";
            Jezik[136] = "First order";
            Jezik[137] = "Second order";
            Jezik[138] = "Third order";
            Jezik[139] = "Fourth order";
            Jezik[140] = "Measured frequencies";
            Jezik[141] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx1_Click()";
            Jezik[142] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx2_Click()";
            Jezik[143] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx3_Click()";
            Jezik[144] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx4_Click()";
            Jezik[145] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx1_Click()";
            Jezik[146] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx2_Click()";
            Jezik[147] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx3_Click()";
            Jezik[148] = "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx4_Click()";

            // Forma_Desni_Grafik
            Jezik[149] = "PLACEHOLDERSTRING Forma_Desni_Grafik.Text";
            Jezik[150] = "Redraw";
            Jezik[151] = "In case the graph isn't properly drawn, line this window up with the top left corner of your screen and press the button:";
            Jezik[152] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx1_Click USLOV ISPUNJEN";
            Jezik[153] = "Frequency does not match";
            Jezik[154] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx2_Click USLOV ISPUNJEN";
            Jezik[155] = "Frequency does not match";
            Jezik[156] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx3_Click USLOV ISPUNJEN";
            Jezik[157] = "Frequency does not match";
            Jezik[158] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx4_Click USLOV ISPUNJEN";
            Jezik[159] = "Frequency does not match";
            Jezik[160] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx1_Click USLOV ISPUNJEN";
            Jezik[161] = "Frequency does not match";
            Jezik[162] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx2_Click USLOV ISPUNJEN";
            Jezik[163] = "Frequency does not match";
            Jezik[164] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx3_Click USLOV ISPUNJEN";
            Jezik[165] = "Frequency does not match";
            Jezik[166] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx4_Click USLOV ISPUNJEN";
            Jezik[167] = "Frequency does not match";
            Jezik[168] = "WF";
            Jezik[169] = "WF2";
            Jezik[170] = "WF3";
            Jezik[171] = "WF4";
            Jezik[172] = "PS";
            Jezik[173] = "PS2";
            Jezik[174] = "PS3";
            Jezik[175] = "PS4";
            Jezik[176] = "WF - wheel frequency first order";
            Jezik[177] = "WF2 - wheel frequency second order";
            Jezik[178] = "WF3 - wheel frequency third order";
            Jezik[179] = "WF4 - wheel frequency fourth order";
            Jezik[180] = "PS - propeller shaft frequency first order";
            Jezik[181] = "PS2 - propeller shaft frequency second order";
            Jezik[182] = "PS3 - propeller shaft frequency third order";
            Jezik[183] = "PS4 - propeller shaft frequency fourth order";

            // jezik 2 elektrik bugalu

            // Forma_Desni_Glavni
            Jezik[184] = "Different tire dimensions on the other axle";
            Jezik[185] = "Width 2";
            Jezik[186] = "Height 2";
            Jezik[187] = "Rim 2";
            Jezik[188] = "mm";
            Jezik[189] = "%";
            Jezik[190] = "Inches";

            // Forma_TestVoznja
            Jezik[191] = "Test drive tips";

            // Forma_Desni_Grafik
            Jezik[192] = "Dimensions 1";
            Jezik[193] = "Dimensions 2";
            Jezik[194] = "WF";
            Jezik[195] = "WF2";
            Jezik[196] = "WF3";
            Jezik[197] = "WF4";
            Jezik[198] = "PS";
            Jezik[199] = "PS2";
            Jezik[200] = "PS3";
            Jezik[201] = "PS4";

            // Forma_Desni_Tabela
            Jezik[202] = "Wheel 2 frequencies";
            Jezik[203] = "Propeller shaft 2 frequencies";

            // Forma_TestVoznja
            Jezik[204] = "Pre-Road Test inspection";
            Jezik[205] = "Road test";
            Jezik[206] = "Pre-Road Test inspection \r\nCheck the tires for: \n      - Inflation pressure \r\n      - Proper tire type \r\n      - Verify the tires are uniform in size and brand \r\n      - Abnormal tire wear and correct thread depth \r\nCheck the wheels for: \r\n      - Mud, ice and debris \r\n      - Deformed or bent \r\n      - Missing wheel weights \r\n      - Log nuts tightening torque \r\nCheck the vehicle for: \r\n      - Signs of damaged components \r\n      - Signs of collision damage \r\n      - Added components \r\nNotes: \r\n      - It is important to know which specific concern the customer has with their vehicle \r\n       - Don't be misled by the reported location of the noise or vibration, cause may be in another area of vehicle \r\n      - The vibrating component may only generate a small vibration, but this small vibration may cause a larger vibration or noise. \r\n      - It must be possible to operate the vehicle at the speed in which the condition occurs. \r\n      - Prepare measuring equipment.";
            Jezik[207] = "Back";
            Jezik[208] = "Road test \r\nIn order to determine engine speed, vehicle speed and frequency of the NVH concern, as well to establish is it a engine \r\nor vehicle speed related vibrations, perform the test drive: ";
            Jezik[209] = "Slow Acceleration Test";
            Jezik[210] = "Neutral Coast-Down Speed Test";
            Jezik[211] = "Downshift Speed Test";
            Jezik[212] = "Torque Converter Test";
            Jezik[213] = "Steering Test 1";
            Jezik[214] = "Steering Test 2";
            Jezik[215] = "Neutral Run-Up Test";
            Jezik[216] = "Engine Loaded Test";
            Jezik[217] = "Engine Accessory Test";
            Jezik[218] = "Back";
            Jezik[219] = "Slow Acceleration Test";
            Jezik[220] = "The first vehicle check to determine a related symptom of an NVH concern is the slow acceleration test. \r\nThis test is used to identify the noise or vibration if a road test with the customer was not possible. \r\nThe steps of the slow acceleration test are: \r\n      1. Slowly accelerate the vehicle to the speed at which the problem occurs. \r\n      2. Note the vehicle speed and the engine RPM. \r\n      3. If possible, determine the frequency of the noise or vibration. \r\n      4. Classify the noise or vibration.";
            Jezik[221] = "Back";
            Jezik[222] = "Neutral Coast-Down Speed Test";
            Jezik[223] = "The next vehicle check when performing the road test is the neutral coast-down speed test. \r\nThis test divides the possible causes of the noise or vibration into two categories: \r\n      - Vehicle speed-related \r\n      - Engine speed-related \r\nThe steps of the neutral coast-down speed test are: \r\n1. Drive the vehicle at a speed higher than the speed in which the noise or vibration was obvious during the slow acceleration test. \r\n2. Place the vehicle in Neutral and coast down through the speed at which the concern occurs. \r\n3. Classify the NVH concern as either vehicle speed-related or engine speed-related. \r\n      - If the noise or vibration exists, then the concern is vehicle speed related. \r\n         This eliminats the engine and torque converter as possible causes. \r\n      - If the NVH concern did not occur during the neutral coast-down speed test, \r\n         perform a downshift speed test to confirm the concern as engine speed-related.";
            Jezik[224] = "Back";
            Jezik[225] = "Downshift Speed Test";
            Jezik[226] = "This vehicle check helps to confirm the NVH concern as engine speed-related. The steps of the downshift speed test are: \r\n1. Stop the vehicle and place the transmission in a lower gear. \r\n2. Drive the vehicle at the engine RPM at which the noise or vibration occurs. \r\n      - If the noise or vibration exists, then the concern is engine speed-related. \r\n         This eliminates tires, wheels, brakes, and suspension components. \r\n      - If necessary, repeat the test using other gears and Neutral to confirm the results.";
            Jezik[227] = "Back";
            Jezik[228] = "Torque Converter Test";
            Jezik[229] = "This vehicle check determines how the torque converter contributes to an engine speed-related condition. \r\nThe steps of the torque converter test are: \r\n1. Drive the vehicle at the speed at which the NVH concern exists. \r\n2. Operate the torque converter by taking it in and out of lock-up by lightly depressing the brake pedal, \r\n      while maintaining vehicle speed. \r\n3. Check for noise when the torque converter is not locked up.";
            Jezik[230] = "Back";
            Jezik[231] = "Steering Test 1";
            Jezik[232] = "These tests determine if the wheel bearings and other suspension components are contributing to a speed-related condition. \r\nThe steps of the Steering Input Test 1 are:\r\n1. Drive the vehicle at the speed at which the NVH concern exists.\r\n2. Make wide sweeping turns in both directions. \r\nIf the concern goes away or gets worse, wheel bearings, hubs, Universal Joints (U-joints), drive axles, constant velocity joints and \r\ntire tread wear may be the components causing the concern. \r\nIf the noise or vibration exists, the concern is engine speed related.";
            Jezik[233] = "Back";
            Jezik[234] = "Steering Test 2";
            Jezik[235] = "Perform the Steering Input Test 2 if the NVH condition occurs when turning only. The steps of Steering Input Test 2 are: \r\n1. Drive the vehicle at a speed higher than the speed at which the noise or vibration occurs. \r\n2. Place the vehicle in Neutral and coast down through the speed at which the NVH concern is obvious, while making wide sweeping \r\n      turns in both directions. \r\nIf the concern exists, check for worn wheel bearings, suspension bushings, constant velocity joints and U-joints (contained in the \r\naxles of AWD applications). \r\nIf the vibration does not occur, stop the vehicle and engage the transmission/transaxle. \r\nAlternately accelerate and decelerate through the speed at which the NVH concern appears, while making wide sweeping turns in \r\nboth directions. \r\nIf the concern returns, then the cause is dependent upon engine load. The probable causes are constant velocity joints or U-joints \r\n(contained in the axles of AWD applications) and loose or missing wheel nuts. \r\nIf the noise is a “clunking sound,” engine and transaxle mounts, suspension bushings and U-joints are probable causes.";
            Jezik[236] = "Back";
            Jezik[237] = "Neutral Run-Up Test";
            Jezik[238] = "Perform the Neutral Run-Up Test if the NVH concern is engine speed-related. \r\nUse the test as a follow-up to the downshift test or when the NVH concern occurs at idle. The steps are: \r\n1. Increase the engine RPM while in Park or Neutral. \r\n2. If necessary, make note of the RPM and frequency of the NVH concern.";
            Jezik[239] = "Back";
            Jezik[240] = "Engine Loaded Test";
            Jezik[241] = "Perform the Engine Loaded Test if the NVH concern is engine speed-related. \r\nThis test may help reproduce engine speed-related concerns not evident with the neutral run-up or neutral coast-down speed tests. \r\nThe engine loaded test also identifies noise and vibration sensitive to engine load or torque. \r\nThese NVH concerns often appear during heavy acceleration or when climbing a hill.";
            Jezik[242] = "Warning: Block the front and back wheels or injury to personnel may result. \r\nDo not exceed five seconds when performing the engine loaded test or damage to the transmission/transaxle may result.";
            Jezik[243] = "The steps of the Engine Loaded Test are: \r\n1. Block the front and back wheels.\r\n2. Apply the parking and service brakes. \r\n3. Put the transmission in Drive while keeping the brakes applied. \r\n4. Increase the engine rpm to the rpm at which the NVH concern occurred. If necessary, make note of the RPM and frequency \r\n      of the NVH concern. \r\n5. Return the engine to idle. \r\n6. Put the transmission in Reverse while keeping the brakes applied. \r\n7. Increase the engine RPM to the RPM at which the NVH concern occurred. If necessary, make note of the RPM and frequency \r\n      of the NVH concern. \r\n      If the concern is definitely engine speed-related, perform the Engine Accessory Test to narrow down the possible source of the \r\n      concern.";
            Jezik[244] = "Immediately after doing an engine loaded test, run in neutral for 3 minutes at a slightly elevated RPM to cool the \r\ntransmission.";
            Jezik[245] = "Back";
            Jezik[246] = "Engine Accessory Test";
            Jezik[247] = "Perform the Engine Accessory Test if the NVH concern is engine speed-related. \r\nThis test helps locate faulty belts and accessories that are causing engine speed-related NVH concerns. \r\nThe steps are: \r\n1. Block the front and back wheels. \r\n2. Apply the parking and service brakes. \r\n3. Remove the accessory drive belt(s). \r\n4. Increase engine rpm to the rpm at which the NVH concern occurred. \r\n      - If the vibration occurs, the belts and accessories are not the source of the concern.\r\n      - If the belts and accessories are the source of the NVH concern, continue to add or remove specific accessory belts to locate \r\n         the concern";
            Jezik[248] = "Caution: With the accessory belt removed: \r\n      - Do not drive the vehicle\r\n      - Do not operate the engine for more than a few minutes or\r\n            • Water-cooled alternators can fail \r\n            • Engines can overheat";
            Jezik[249] = "Back";

            // Forma_HomeScreen
            Jezik[250] = "Intro";

            // Forma_Uvod
            Jezik[251] = "Intro";
            Jezik[252] = "Definitions";
            Jezik[253] = "Noise";
            Jezik[254] = "is defined as any unpleasant or unexpected sound created by a vibrating object.";
            Jezik[255] = "Vibration";
            Jezik[256] = "is defined as any objectionable repetitive motion of an object, back-and-forth or up-and-down.";
            Jezik[257] = "Harshness";
            Jezik[258] = "is defined as an aggressive suspension feel or lack of “give” in response to a single input.";
            Jezik[259] = "A";
            Jezik[260] = "sound";
            Jezik[261] = "is a vibration (pressure fluctuation) of the air.";
            Jezik[262] = "Vibrations and sounds are both expressed as waves per second called Hertz (Hz). \r\n      - Vibrations that are felt are under 200 Hz \r\n      - Vibrations between 20 Hz - 20,000 Hz are audible by humans \r\n      - Vibrations over 20,000 Hz are ultrasonic and are not audible by humans";
            Jezik[263] = "Noise and vibrations have some characteristics in common:";
            Jezik[264] = "      - Cycle \r\n      - Frequency \r\n      - Amplitude \r\n      - Order \r\n      - Resonance \r\n      - Transmission of vibrations and sound";
            Jezik[265] = "Cycle";
            Jezik[266] = "Cycle is the path a wave travels before the wave begins to repeat the path again. \r\ne.g. If the wheel makes 5 full revolutions this is equal to 5 complete cycles.";
            Jezik[267] = "Frequency";
            Jezik[268] = "Frequency is the number of complete cycles that occur in one second. \r\nSound and vibration waves are measured in Hz, or Cycles Per Second (CPS). \r\nFigure A shows a vibration of 3 Hz, and Figure B a vibration of 8 Hz.";
            Jezik[269] = "Figure A";
            Jezik[270] = "Figure B";
            Jezik[271] = "The higher the vibration, the higher the pitch of the sound will be. \r\ne.g. bearings rotating at a high speed will produce a very high pitched sound";
            Jezik[272] = "Amplitude";
            Jezik[273] = "Amplitude refers to the vertical measurement between the top and the bottom of a wave. \r\nTwo waves can have the same frequency, but differ in amplitude. \r\nAmplitude is the quantity or amount of energy produced by a vibrating component. \r\nLow amplitude (Figure A) is equal to low intensity, and high amplitude (Figure B) to high intensity";
            Jezik[274] = "Figure A";
            Jezik[275] = "Figure B";
            Jezik[276] = "Frequency order";
            Jezik[277] = "Order is number of disturbances created in one revolution of component. \r\nFor example (Figure A), a single high spot on a tire creates a first order disturbance (one disturbance per revolution) and therefore a \r\nfirst order vibration. \r\nIf the tire is rotating at a rate of 10 rotations per second it will create first order vibration of 10 Hz. \r\nA second high spot on tire would result in a second order disturbance, meaning that at the same speed, the vibration will be 20 Hz. \r\nSome components or systems may develop third and fourth order vibrations as well.";
            Jezik[278] = "Figure A";
            Jezik[279] = "Resonance";
            Jezik[280] = "Resonance is the tendency of a system to respond to a compelling force oscillating at a natural frequency of the system. \r\nAll objects have natural frequencies. \r\nThe amplitude of a vibration is greatest at the point of resonance. \r\nResonance occurs when the vibrating force (external force) on a vibrating system is moving at the same frequency (Hz) as the \r\nnatural frequency of that vibrating system. \r\nThe resulting wave that occurs is at the same frequency but with much greater amplitude (Figure A).";
            Jezik[281] = "The phenomenon of resonance means that the presence of one small vibration may create another very large vibration that can be \r\nfelt in the vehicle.";
            Jezik[282] = "Transmission of vibrations and sound";
            Jezik[283] = "Vibrations and sound are transmitted the same way. There has to be a: \r\n      - Vibrating force \r\n      - Resonating system \r\n      - Transmission system (path) \r\n      - Vibrating element (vibration)";
            Jezik[284] = "Sources of";
            Jezik[285] = "vibrating forces";
            Jezik[286] = "in vehicles could be:";
            Jezik[287] = "      - Combustion \r\n      - Tires contacting a rough road \r\n      - Imbalance or run-out of a rotating component \r\n      - Fluctuation of friction surfaces";
            Jezik[288] = "A";
            Jezik[289] = "Resonance System"; // 289
            Jezik[290] = "is any component on the vehicle that resonates when it recieves a vibrating force.";
            Jezik[291] = "All components will resonate if the vibrating force matches the natural frequency. \r\nSome examples are: \r\n      - Tires resonate when vibrated by the road \r\n      - Suspension systems will resonate with an out of balance tire \r\n      - An exhaust system will resonate when vibrated by the engine";
            Jezik[292] = "The"; // 292, label41
            Jezik[293] = "Transmission System";
            Jezik[294] = "is the path in the vehicle that carries the vibration from the resonance system to the vibrating element.";
            Jezik[295] = "Examples of a transmission system or path are the: \r\n      - Exhaust system \r\n      - Engine mounts";
            Jezik[296] = "These components carry engine vibrations through the vehicle.";
            Jezik[297] = "The";
            Jezik[298] = "Vibrating element";
            Jezik[299] = "is the component that generates the vibration or sound that can be sensed.";
            Jezik[300] = "Examples of Vibrating elements are: \r\n      - Body \r\n      - Steering wheel \r\n      - Seat \r\n      - Shifter \r\n      - Mirror";
            Jezik[301] = "In most cases, the NVH issue is resolved by fixing the source of the vibrating force, but sometimes any change in transmission \r\nprocess can solve the issue.";
            Jezik[302] = "For example: \r\n      - Vibrating force is engine \r\n      - Resonating system is exhaust \r\n      - Transmission system is contact of the exhaust and body \r\n      - Vibrating element is the body panel";
            Jezik[303] = "By repairing elastic contact between exhaust and body, the NVH problem will be resolved.";
            Jezik[304] = "Measuring the frequency";
            Jezik[305] = "In order to find the source of vehicle vibrations it is necessary to measure the vibrating frequency and engine/vehicle speed at which \r\nthat vibration frequency occurs. There are many tools for this purpose as shown in the figures below.";

            // Forma_Centar_!Glavni
            Jezik[306] = "The value in this field must be between 100 and 8000."; // 306
            Jezik[307] = "The value in this field must be between 1 and 500."; // 307
            // Forma_Centar_Agregat_Glavni
            Jezik[308] = "The value in this field must be positive."; // 308
            // Forma_Desni_Glavni
            Jezik[309] = "The value in this field must be positive."; // 309
            Jezik[310] = "The value in this field must be between 5 i 200."; // 310

            // uopste korisceno
            Jezik[311] = "Error"; // 311
            Jezik[312] = "Information"; // 312
            Jezik[313] = "Warning"; // 
            Jezik[314] = "Return to top"; // 314 // na Forma_Uvod i Forma_Centar_Tekst

            // Forma_TestVoznja
            Jezik[315] = "Return to top"; // 315

            // Forma_Centar_!Glavni
            Jezik[316] = "No preset"; // 316
            Jezik[317] = "Vehicle 1"; // 317
            Jezik[318] = "Vehicle 2"; // 318

            // Forma_Centar_Tekst
            Jezik[319] = "Engine vibrations"; // 319
            Jezik[320] = "Engine speed related vibrations";
            Jezik[321] = "Based on the frequency of the vibration and driving conditions, the noise or vibration can be isolated into three component groups: ";
            Jezik[322] = "      -";
            Jezik[323] = "Engine vibrations";
            Jezik[324] = "Engine firing frequency";
            Jezik[325] = "Engine accessory vibrations";
            Jezik[326] = "Engine vibrations";
            Jezik[327] = "First order";
            Jezik[328] = "A first-order engine imbalance is created when any component that rotates at crankshaft speed is out-of-balance or has excessive \r\nrunout.";
            Jezik[329] = "First order vibrations can be caused by: ";
            Jezik[330] = "      - an out of balance flywheel or excesisve runout";
            Jezik[331] = "      -";
            Jezik[332] = "Crankshaft pulley (Torsional vibration dampener)";
            Jezik[333] = "      - Cylinder to cylinder mass difference";
            Jezik[334] = "      -";
            Jezik[335] = "Torque converter";
            Jezik[336] = "      - an imbalanced crankshaft"; // 336
            Jezik[337] = "Crankshaft pulley (Torsional vibration dampener)";
            Jezik[338] = "An out of balance or out of round TVD will transfer engine vibrations to the belt drive. An improper TVD (figure 1) will fail to dampen \r\ncrankshaft vibrations, which will be transferred to the belt drive.";
            Jezik[339] = "Figure 1a (TVD as specified)";
            Jezik[340] = "Figure 1b (Improper TVD)";
            Jezik[341] = "Torque converter";
            Jezik[342] = "The torque converter frrequency is equal to the engine frequency. The torque converter can be suspected as the cause of noise or \r\nvibration when an NVH concern is torque sensitive.";
            Jezik[343] = "Refer to torque converter test drive tips.";
            Jezik[344] = "Torque converter vibrations can be caused by:";
            Jezik[345] = "      -";
            Jezik[346] = "The movement of the fluid between the impeller, which is connected to the engine, and the turbine, which connects to the \r\ntransmission (in this case the vibration will disappear as soon as the TCC is engaged).";
            Jezik[347] = "      - Clutch engagement";
            Jezik[348] = "      - Clutch release during downshift or coasting";
            Jezik[349] = "      - Torque converter imabalnce or an incorrectly installed converter";
            Jezik[350] = "Second order";
            Jezik[351] = "Second order vibrations are caused either by two first order issues or by the up-and-down motion of the pistons. This reversal of \r\nmass and motion creates a natural vibration.";
            Jezik[352] = "On four cylinder engines, second order vibration is equal to";
            Jezik[353] = "engine firing frequency";
            Jezik[354] = "Third order";
            Jezik[355] = "On six cylinder engines, second order vibration is equal to";
            Jezik[356] = "engine firing frequency";
            Jezik[357] = "Fourth order";
            Jezik[358] = "On eight cylinder engines, second order vibration is equal to";
            Jezik[359] = "engine firing frequency";
            Jezik[360] = "Engine firing frequency";
            Jezik[361] = "Firing frequency refers to the force created by the engine each time the cylinder fires. This is the natural vibration of the internal \r\ncombustion engine. Firing frequency is load dependent. The higher the engine load is, the more prominent the frequency will be. \r\nIf there is a problem on the engine, which is affecting the combustion process, this vibration will increase.";
            Jezik[362] = "Even though firing frequency is natural to ICE, it has to be isolated from the vehicle body.";
            Jezik[363] = "Firing frequency vibrations could be caused by:";
            Jezik[364] = "      -";
            Jezik[365] = "Engine mounts";
            Jezik[366] = "      -";
            Jezik[367] = "Exhaust hangers";
            Jezik[368] = "      - Engine problems, affecting the combustion process";
            Jezik[369] = "Engine mounts";
            Jezik[370] = "The first components that isolate the passenger comprartment from engine vibrations are engine mounts. Any fault in the engine \r\nmounting system can directly lead to noise and vibration.";
            Jezik[371] = "Inspect the engine mounts for cracks or damage to the insulator and the bracket (figure 2). Grounded, the engine mount bracket \r\ncontacting the frame-mounted bracket, or strained engine mounts may not isolate engine vibrations.";
            Jezik[372] = "Engine mounts must be installed correctly and tightened with the specific torque. If the mounts are installed incorrectly or incorrect \r\nparts are used, they won't be able to absorb engine vibrations. Make sure the proper type of engine mount is installed. (figure 3)";
            Jezik[373] = "Figure 2";
            Jezik[374] = "Figure 3";
            Jezik[375] = "Exhaust hangers";
            Jezik[376] = "The compelling force of exhaust exiting each cylinder creates a pulsation on the exhaust manifold. The pulsating pressure at the \r\nexhaust manifold produces acoustic energy, which is transmitted to the exhaust pipe.";
            Jezik[377] = "The pulsating sound waves traveling through the exhaust pipe are a source of vibration from the exhaust system. The combined \r\nengine and exhaust vibrations within the exhaust system must be isolated to prevent them from acting on the body of the vehicle. \r\nExhaust hangers (figure 4) are used to suspend the exhaust pipe from the body and to prevent transmission of vibration to the body.";
            Jezik[378] = "Figure 4";
            Jezik[379] = "Engine accessory vibrations";
            Jezik[380] = "Engine accessory related vibrations can be found either by doing an engine accessory test (refer to test drive section) or by doing a \r\ncalculation based on engine RPM and the ratio between accessories and crankshaft pulley.";
            Jezik[381] = "Engine acessory vibrations could be caused by: \r\n      - An out of balance component \r\n      - Worn out components \r\n      - An out of round pulley \r\n      - An untigthened pulley \r\n      - An untightened component \r\n      - Worn out component shaft bearings \r\n      - Pressure fluctuation (e.g. power steering pump) \r\n      - Overcharged refrigerant (AC compressor)";
            // 38

            // Forma_Desni_Tekst_Driveline
            Jezik[382] = "Vehicle vibrations";
            Jezik[383] = "Driveline-related concerns are usually caused by the following conditions: \r\n      - A propeller shaft imbalance \r\n      - A damaged propeller shaft \r\n      - Missing shaft balance weights \r\n      - Improper propeller shaft operating angles \r\n      - Worn universal or CV joint \r\n      - Worn center bearings \r\n      - Loose spring U-bolts \r\n      - Loose or broken springs \r\n      - Damaged axle shaft bearings \r\n      - A loose pinion gear nut \r\n      - Excessive pinion flange runout \r\n      - Pinion and ring gear pitch line variation";
            Jezik[384] = "Driveshaft vibrations can be classified into three different orders: first-order, second-order, and fourth-order.";
            Jezik[385] = "A first-order vibration may be caused by a: \r\n      - A damaged or bent propeller shaft \r\n      - Damaged driveline components \r\n      - Worn CV or U joint \r\n      - Propeller shaft imbalance \r\n      - Hydromount slipping \r\n      - Driveshaft central bearing damage \r\n      - Loose pinion gear nut \r\n      - Worn pinion gear";
            Jezik[386] = "A second-order vibration may be caused by a:  \r\n      - Driveshaft angle \r\n      - U-joint cancelation \r\n      - Worn CV or U joint";
            Jezik[387] = "A fourth-order vibration may be caused by a: \r\n      - Driveshaft angle \r\n      - Worn CV or U joint";
            Jezik[388] = "Check the following:";
            Jezik[389] = "      -";
            Jezik[390] = "Driveshaft runout";
            Jezik[391] = "      -";
            Jezik[392] = "Missing balance weights";
            Jezik[393] = "      -";
            Jezik[394] = "Pinion and ring gear pitch line";
            Jezik[395] = "      -";
            Jezik[396] = "Driveline operating angles";
            Jezik[397] = "Driveshaft runout";
            Jezik[398] = "Place the dial indicator at a 90 degree angle from the driveshaft and measure the runout at the ends of the driveshaft (figure 1), as \r\nwell as in the middle of the shaft (figure 2).";
            Jezik[399] = "Figure 1";
            Jezik[400] = "Figure 2";
            Jezik[401] = "If the measured values are not within vehicle manufacturer specifications (typically 0.5 mm at the ends and 0.6 mm at the middle), \r\nreplace the driveshaft.";
            Jezik[402] = "Back";
            Jezik[403] = "Missing balance weights";
            Jezik[404] = "Visually check for missing driveshaft balance weights (figure 3).";
            Jezik[405] = "Figure 3";
            Jezik[406] = "Back";
            Jezik[407] = "Pinion and ring gear pitch line";
            Jezik[408] = "If the contact between pinion and ring gear is uneven (there is an excessive pitch line runout), the ring gear speed will vary and \r\ncause the driveline vibrations. \r\nRemove the axle cover, and with the aid of special paint, check for the correct contact patter between the ring and pinion gear \r\n(figure 4).";
            Jezik[409] = "Figure 4";
            Jezik[410] = "Back";
            Jezik[411] = "Driveline operating angles";
            Jezik[412] = "The operating angle of a universal joint is the difference between the angles formed when two shafts intersect. \r\nIn a one-piece propeller shaft system, there are two operating angles present: the front and the rear.";
            Jezik[413] = "The front operating angle is formed by the angle of the propeller shaft and the angle of the transmission output shaft (figure 5).";
            Jezik[414] = "Figure 5";
            Jezik[415] = "The rear operating angle is formed by the angle of the propeller shaft and the angle of the rear axle pinion.";
            Jezik[416] = "To check driveline alignment, raise and support the vehicle at the axles as level as possible. \r\nAllow the wheels and propeller shaft to turn.";
            Jezik[417] = "Record angle A (figure 6). \r\nRotate the shaft until the transmission yoke bearing is facing downwards. \r\nPlace the inclinometer on the yoke bearing parallel to the shaft and record measurement A.";
            Jezik[418] = "Record angle B (figure 6). \r\nRotate the shaft until the pinion yoke bearing is facing downwards. \r\nPlace the inclinometer on the yoke bearing parallel to the shaft and record measurement B.";
            Jezik[419] = "Record angle C (figure 6). \r\nRotate the shaft for 90 degrees until the propeller shaft yoke bearing is facing downwards. \r\nPlace the inclinometer on the yoke bearing parallel to the shaft and record measurement C. Angle C can be measured on both ends, \r\nas well as on the shaft itself.";
            Jezik[420] = "Figure 6";
            Jezik[421] = "Front angle is equal to Angle C - Angle A \r\nRear angle is equal to Angle C - Angle B";
            Jezik[422] = "      -";
            Jezik[423] = "Both the front and rear angles must be within the vehicle manufacturer's specifications";
            Jezik[424] = "      -";
            Jezik[425] = "The front and rear angles need to be within one degree of each other (Typical value - check manufacturer specifications)";
            Jezik[426] = "      -";
            Jezik[427] = "The operating angles should be less than 3 degrees (Typical value - check manufacturer specifications)";
            Jezik[428] = "      -";
            Jezik[429] = "The rear angle has to be bigger than the front angle";
            Jezik[430] = "      -";
            Jezik[431] = "Neither angle can equal zero";
            Jezik[432] = "If the driveline is a two piece system additional angles have to be measured: \r\nthe input angle of the transmission, the transfer shaft angle, the driveshaft angle and the output angle of the pinion.";
            Jezik[433] = "Back";

            // Forma_Desni_Tekst_Tocak
            Jezik[434] = "Vehicle vibrations"; // 434
            Jezik[435] = "Wheel frequency";
            Jezik[436] = "Wheel first odrer frequency is related to vibration caused by the wheels or anything which is rotating at the same speed as them.";
            Jezik[437] = "Some of the causes could be: \r\n      - Wheel and tire imbalance \r\n      - The condition of the wheels and tires \r\n      - Foreign debris in a wheel \r\n      - A wheel or tire that is out of round \r\n      - Uniformity \r\n      - Tire dimensions \r\n      - Conicity \r\n      - Radial force variation \r\n      - Brake rotor or brake drum imbalance \r\n      - Constant velocity (CV) shaft \r\n      - Excessive hub runout \r\n      - Axle shaft problems";
            Jezik[438] = "A higher order wheel frequency indicates several independent first order issues or a problem with: \r\n      - The joint between the wheels and the driveshaft \r\n      - Non-uniform tires on the vehicle \r\n      - Radial force variation";
            Jezik[439] = "Check the following:";
            Jezik[440] = "      -";
            Jezik[441] = "Balance the tire/wheel";
            Jezik[442] = "      -";
            Jezik[443] = "Radial wheel and tire assembly runout";
            Jezik[444] = "      -";
            Jezik[445] = "Lateral wheel and tire assembly runout";
            Jezik[446] = "      -";
            Jezik[447] = "Radial wheel runout";
            Jezik[448] = "      -";
            Jezik[449] = "Lateral wheel runout";
            Jezik[450] = "      -";
            Jezik[451] = "Hub/Brake disc runout";
            Jezik[452] = "      -";
            Jezik[453] = "Radial force variation";
            Jezik[454] = "      -";
            Jezik[455] = "Bent axle shaft";
            Jezik[456] = "      -";
            Jezik[457] = "The joint between the wheels and the axle shaft";
            Jezik[458] = "Radial wheel and tire assembly runout";
            Jezik[459] = "Radial runout can be measured on the vehicle (hub, wheel and tire total runout).";
            Jezik[460] = "Raise the vehicle, apply masking tape on the circumference of the tire (figure 1), and check the runout with a dial gauge. \r\nThe measured value should be compared to the vehicle manufacturer's data (the maximum is typically 0.8 to 1 mm).";
            Jezik[461] = "Radial runout can also be measured off the vehicle. In this case the hub can be ruled out.";
            Jezik[462] = "Figure 1";
            Jezik[463] = "If the measured value is above specifications, the problem could be in the tire, wheel, or hub.";
            Jezik[464] = "Proceed with radial runout measurements";
            Jezik[465] = "If the measured value is below specifications, proceed with lateral runout measurements.";
            Jezik[466] = "Back";
            Jezik[467] = "Lateral wheel and tire assembly runout";
            Jezik[468] = "Measure the lateral runout with the dial gauge positioned on the flat surface of the tire sidewall (figure 2).";
            Jezik[469] = "The measured value should be compared to the vehicle manufacturer's data (the maximum is typically 0.8 to 1.2 mm).";
            Jezik[470] = "Figure 2";
            Jezik[471] = "If the measured value is above specifications, the problem could be in the tire, wheel, or hub.";
            Jezik[472] = "Proceed with lateral runout measurements.";
            Jezik[473] = "Back";
            Jezik[474] = "Radial wheel runout";
            Jezik[475] = "Radial wheel runout could be measured while the wheel is on the vehicle (wheel and hub total runout), or with the wheel off the \r\nvehicle (only the wheel runout). Place the dial gauge and measure the runout (figure 3).";
            Jezik[476] = "The measured value should be compared to the vehicle manufacturer's data (the maximum is typically 0.25 mm for alloy wheels and \r\n0.5 mm for steel wheels).";
            Jezik[477] = "Figure 3";
            Jezik[478] = "If the measured value is above specifications, the problem could be in the wheel or the hub.";
            Jezik[479] = "Proceed with radial runout measurements.";
            Jezik[480] = "If the value is within specifications, the problem is in the tire.";
            Jezik[481] = "Back";
            Jezik[482] = "Lateral wheel runout";
            Jezik[483] = "Lateral wheel runout could be measured whiel the wheel is on the vehicle (wheel and hub total runout), or with the wheel off the \r\nvehicle (only the wheel runout). Place the dial gauge and measure the runout (figure 4).";
            Jezik[484] = "The measured value should be compared to the vehicle manufacturer's data (the maximum is typically 0.5 to 0.8 mm).";
            Jezik[485] = "Figure 4";
            Jezik[486] = "If the measured value is above specifications, the problem could be in the wheel or the hub.";
            Jezik[487] = "Proceed with alteral runout measurements.";
            Jezik[488] = "If the value is within specifications, the problem is in the tire.";
            Jezik[489] = "Back";
            Jezik[490] = "Hub/Brake disc runout";
            Jezik[491] = "Measure the brake disc runout, either on the hub (figure 5) or off the vehicle (figure 6) and compare the measured value with the \r\nvehicle manufacturer's specifications.";
            Jezik[492] = "If the measured value on the hub is within specifications, the problem is on the wheel.";
            Jezik[493] = "If the measured value of the vehicle is within specifications, the problem is on the hub.";
            Jezik[494] = "Figure 5";
            Jezik[495] = "Figure 6";
            Jezik[496] = "Back";
            Jezik[497] = "Radial force variation";
            Jezik[498] = "Radial force variation is a term describing the tire unifomity under load, measuring the variation of the load acting on the vehicle \r\nspindle.";
            Jezik[499] = "If the sidewall stiffness of the tire is not uniform (figure 7), a vertical force is exerted on the axle making it move up and down. \r\nThis movement creates vibrations unrelated to wheel balance.";
            Jezik[500] = "Figure 7";
            Jezik[501] = "A tire with noticable radial force variation will produce a vibration even though it is perfectly balanced and is within the \r\nradial and lateral runout limits.";
            Jezik[502] = "Special equipment should be used to check for radial force variation (figure 8).";
            Jezik[503] = "Figure 8";
            Jezik[504] = "Back";
            Jezik[505] = "Bent axle shaft";
            Jezik[506] = "Place the dial indicator at a 90 degree angle from the axle shaft and measure the runout at the ends of the axle shaft, as well as in \r\nthe middle of the shaft (figure 9).";
            Jezik[507] = "Figure 9";
            Jezik[508] = "If the measured values are not within the vehicle manufacturer's specifications, replace the shaft.";
            Jezik[509] = "Engine frequency"; // FormaCentarTabela
            Jezik[510] = "Pulley diameter"; // FormaCentarAgregatGlavni

            promenaJezika();
        }

        private void jezikDugme_Nemacki_Click(object sender, EventArgs e)
        {
            // for (Int32 i = 0; i < Jezik.Length; i++) Jezik[i] = "P ID " + i.ToString();
            MessageBox.Show("German language support hasn't been added yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private void dugmeLevo_Click(object sender, EventArgs e)
        {
            FormaTestVoznja = new Forma_TestVoznja(this);
            FormaTestVoznja.Owner = this;
            FormaTestVoznja.Show();

            dugmeLevo.Enabled = false;
        }

        public Boolean DugmeLevoEnabled
        {
            get { return dugmeLevo.Enabled;  }
            set { dugmeLevo.Enabled = value; }
        }

        private void dugmeCentar_Click(object sender, EventArgs e)
        {
            FormaCentarGlavni = new Forma_Centar_Glavni(this);
            FormaCentarGlavni.Owner = this;
            FormaCentarGlavni.Show();

            dugmeCentar.Enabled = false;
        }

        public Boolean DugmeCentarEnabled
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

        public Boolean DugmeDesnoEnabled
        {
            get { return dugmeDesno.Enabled;  }
            set { dugmeDesno.Enabled = value; }
        }

        private void dugmeDodatno_Click(object sender, EventArgs e)
        {
            FormaUvod = new Forma_Uvod(this);
            FormaUvod.Owner = this;
            FormaUvod.Show();

            dugmeDodatno.Enabled = false;
        }

        public Boolean DugmeDodatnoEnabled
        {
            get { return dugmeDodatno.Enabled;  }
            set { dugmeDodatno.Enabled = value; }
        }

        private void Forma_HomeScreen_Load(object sender, EventArgs e)
        {
            // MessageBox.Show($"{Jezik.Length}");
            jezikDugme_Engleski.PerformClick();
        }

#pragma warning restore IDE1006
    }
}
