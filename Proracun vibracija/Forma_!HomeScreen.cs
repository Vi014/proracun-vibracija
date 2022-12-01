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

        public String[] Jezik = {
                                // Forma_HomeScreen
                                "Proračun vibracija",
                                "Saveti za test vožnju",
                                "Motor",
                                "Auto",
                                "PLACEHOLDERSTRING Forma_HomeScreen.dugmeLevo_Click", // obrisati

                                // Forma_Centar_Glavni
                                "Vibracije motora",
                                "Unos podataka",
                                "Decimale se označavaju tačkom, ne zarezom.",
                                "RPM",
                                "Izmerena frekvencija",
                                "Broj cilindara",
                                "Potvrdi podatke",
                                "Vibracije agregata",
                                "Nedovoljan broj polja popunjen. Neophodno je popuniti barem jedno od polja za RPM i uneti barem jednu frekvenciju za to polje.",
                                "U nekom od polja je uneta nevažeća vrednost.",

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
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM_Click", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM2_Click", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM3_Click", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM4_Click", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FB_Click", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FP_Click", // obrisati

                                // Forma_Centar_Grafik
                                "Vibracije motora",
                                "Iscrtaj ponovo",
                                "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM_Click USLOV NE ISPUNJEN", // ne brisati ove za uslov ne ispunjen, one se idalje koriste
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM2_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM2_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM3_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM3_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM4_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM4_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FB_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FB_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FP_Click USLOV ISPUNJEN", // obrisati
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
                                "Potvrdi podatke",
                                "Nedovoljno polja popunjeno. Neophodno je popuniti barem polje za prečnik remenice radilice i još jedno polje.",
                                "U nekom od polja je uneta nevažeća vrednost.",

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
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D1_Click", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D2_Click", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D3_Click", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D4_Click", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D5_Click", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D6_Click", // obrisati

                                // Forma_Centar_Agregat_Grafik
                                "PLACEHOLDERSTRING Forma_Centar_Agregat_Grafik.Text",
                                "Iscrtaj ponovo",
                                "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D1_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D1_Click USLOV NE ISPUNJEN", // ne brisati ove za uslov ne ispunjen, one se idalje koriste
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D2_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D2_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D3_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D3_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D4_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D4_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D5_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D5_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D6_Click USLOV ISPUNJEN", // obrisati
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
                                "Potvrdi podatke",
                                "Nedovoljno polja popunjeno. Neophodno je popuniti barem polja za širinu, visinu i prečnik felne (kao i ista za drugu osovinu u slučaju da su dimenzije za nju različite), i uneti barem jednu brzinu i frekvenciju za tu brzinu.",
                                "U nekom od polja je uneta nevažeća vrednost.",

                                // Forma_Desni_Tabela
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.Text",
                                "Brzina vozila",
                                "Frekvencije točka 1",
                                "Prvog reda",
                                "Drugog reda",
                                "Trećeg reda",
                                "Četvrtog reda",
                                "Frekvencije kardana 1",
                                "Prvog reda",
                                "Drugog reda",
                                "Trećeg reda",
                                "Četvrtog reda",
                                "Izmerene frekvencije",
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx1_Click()", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx2_Click()", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx3_Click()", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FTx4_Click()", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx1_Click()", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx2_Click()", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx3_Click()", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Tabela.button_FKx4_Click()", // obrisati

                                // Forma_Desni_Grafik
                                "PLACEHOLDERSTRING Forma_Desni_Grafik.Text",
                                "Iscrtaj ponovo",
                                "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx1_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx1_Click USLOV NE ISPUNJEN", // ne brisati ove za uslov ne ispunjen, one se idalje koriste
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx2_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx2_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx3_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx3_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx4_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx4_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx1_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx1_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx2_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx2_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx3_Click USLOV ISPUNJEN", // obrisati
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx3_Click USLOV NE ISPUNJEN",
                                "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx4_Click USLOV ISPUNJEN", // obrisati
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
                                "FK4 - frekvencija kardana četvrtog reda",

                                // jezik 2 elektrik bugalu

                                // Forma_Desni_Glavni
                                "Dimenzije pneumatika na drugoj osovini su različite",
                                "Širina 2",
                                "Visina 2",
                                "Prečnik felne 2",
                                "mm",
                                "%",
                                "Inča",

                                // Forma_TestVoznja
                                "PLACEHOLDERSTRING Forma_TestVoznja.Text",

                                // Forma_Desni_Grafik
                                "Dimenzije 1",
                                "Dimenzije 2",
                                "FT",
                                "FT2",
                                "FT3",
                                "FT4",
                                "FK",
                                "FK2",
                                "FK3",
                                "FK4",

                                // Forma_Desni_Tabela
                                "Frekvencije točka 2",
                                "Frekvencije kardana 2",
                                
                                // Forma_TestVoznja
                                "Pre-Road Test inspection",
                                "Road test",
                                "Pre-Road Test inspection \r\nCheck the tires for: \n      - Inflation pressure \r\n      - Proper tire type \r\n      - Verify the tires are uniform in size and brand \r\n      - Abnormal tire wear and correct thread depth \r\nCheck the wheels for: \r\n      - Mud, ice and debris \r\n      - Deformed or bent \r\n      - Missing wheel weights \r\n      - Log nuts tightening torque \r\nCheck the vehicle for: \r\n      - Signs of damaged components \r\n      - Signs of collision damage \r\n      - Added components \r\nNotes: \r\n      - It is important to know which specific concern the customer has with their vehicle \r\n      - Don't be misled by the reported location of the noise or vibration, cause may be in another area of vehicle \r\n      - The vibrating component may only generate a small vibration, but this small vibration may cause a larger vibration or noise. \r\n      - It must be possible to operate the vehicle at the speed in which the condition occurs. \r\n      - Prepare measuring equipment.",
                                "Back",
                                "Road test \r\nIn order to determine engine speed, vehicle speed and frequency of the NVH concern, as well to establish is it a engine \r\nor vehicle speed related vibrations, perform the test drive: ",
                                "Slow Acceleration Test",
                                "Neutral Coast-Down Speed Test",
                                "Downshift Speed Test",
                                "Torque Converter Test",
                                "Steering Test 1",
                                "Steering Test 2",
                                "Neutral Run-Up Test",
                                "Engine Loaded Test",
                                "Engine Accessory Test",
                                "Back",
                                "Slow Acceleration Test",
                                "The first vehicle check to determine a related symptom of an NVH concern is the slow acceleration test. \r\nThis test is used to identify the noise or vibration if a road test with the customer was not possible. \r\nThe steps of the slow acceleration test are: \r\n      1. Slowly accelerate the vehicle to the speed in which the problem occurs. \r\n      2. Note the vehicle speed and the engine RPM. \r\n      3. If possible, determine the frequency of the noise or vibration. \r\n      4. Classify the noise or vibration.",
                                "Back",
                                "Neutral Coast-Down Speed Test",
                                "The next vehicle check when performing the road test is the neutral coast-down speed test. \r\nThis test divides the possible causes of the noise or vibration into two categories: \r\n      - Vehicle speed-related \r\n      - Engine speed-related \r\nThe steps of the neutral coast-down speed test are: \r\n1. Drive the vehicle at a speed higher than the speed in which the noise or vibration was obvious in the slow acceleration test. \r\n2. Place the vehicle in Neutral and coast down through the speed where the concern occurs. \r\n3. Classify the NVH concern as either vehicle speed-related or engine speed-related. \r\n      - If the noise or vibration exists, then the concern is vehicle speed related. \r\n         This eliminats the engine and torque converter as possible causes. \r\n      - If the NVH concern did not occur during the neutral coast-down speed test, \r\n         perform a downshift speed test to confirm the concern as engine speed-related.",
                                "Back",
                                "Downshift Speed Test",
                                "This vehicle check helps to confirm the NVH concern as engine speed-related. The steps of the downshift speed test are: \r\n1. Stop the vehicle and place the transmission in a lower gear. \r\n2. Drive the vehicle at the engine RPM in which the noise or vibration occurs. \r\n      - If the noise or vibration exists, then the concern is engine speed-related. \r\n         This eliminates tires, wheels, brakes, and suspension components. \r\n      - If necessary, repeat the test using other gears and Neutral to confirm the results.",
                                "Back",
                                "Torque Converter Test",
                                "This vehicle check determines how the torque converter contributes to an engine speed-related condition. \r\nThe steps of the torque converter test are: \r\n1. Drive the vehicle at the speed in which the NVH concern exists. \r\n2. Operate the torque converter by taking it in and out of lock-up by lightly depressing the brake pedal, \r\n      while maintaining vehicle speed. \r\n3. Check for noise when the torque converter is not locked up.",
                                "Back",
                                "Steering Test 1",
                                "These test determine if the wheel bearings and other suspension components are contributing to a speed-related condition. \r\nThe steps of the Steering Input Test 1 are:\r\n1. Drive the vehicle at the speed in which the NVH concern exists.\r\n2. Make wide sweeping turns in both directions. \r\nIf the concern goes away or gets worse, wheel bearings, hubs, Universal Joints (U-joints), drive axles, constant velocity joints \r\nand tire tread wear may be the components causing the concern. \r\nIf the noise or vibration exists, the concern is engine speed related.",
                                "Back",
                                "Steering Test 2",
                                "Perform the Steering Input Test 2 if the NVH condition occurs when turning only. The steps of Steering Input Test 2 are: \r\n1. Drive the vehicle at a speed higher than the speed at which the noise or vibration occurs. \r\n2. Place the vehicle in Neutral and coast down through the speed where the NVH concern is obvious, \r\n      while making wide sweeping turns in both directions. \r\nIf the concern exists, check for worn wheel bearings, suspension bushings, \r\nconstant velocity joints and U-joints (contained in the axles of AWD applications). \r\nIf the vibration does not occur, stop the vehicle and engage the transmission/transaxle. \r\nAlternately accelerate and decelerate through the speed at which the NVH concern appears, \r\nwhile making wide sweeping turns in both directions. \r\nIf the concern returns, then the cause is dependent upon engine load. The probable causes are constant velocity joints or U-joints \r\n(contained in the axles of AWD applications) and loose or missing wheel nuts. \r\nIf the noise is a “clunking sound,” engine and transaxle mounts, suspension bushings and U-joints are probable causes.",
                                "Back",
                                "Neutral Run-Up Test",
                                "Perform the Neutral Run-Up Test if the NVH concern is engine speed-related. \r\nUse the test as a follow-up to the downshift test or when the NVH concern occurs at idle. The steps are: \r\n1. Increase the engine RPM while in Park or Neutral. \r\n2. If necessary, make note of the RPM and frequency of the NVH concern.",
                                "Back",
                                "Engine Loaded Test",
                                "Perform the Engine Loaded Test if the NVH concern is engine speed-related. \r\nThis test may help reproduce engine speed-related concerns not evident with the neutral run-up or neutral coast-down speed tests. \r\nThe engine loaded test also identifies noise and vibration sensitive to engine load or torque. \r\nThese NVH concerns often appear during heavy acceleration or when climbing a hill.",
                                "Warning: Block the front and back wheels or injury to personnel may result. \r\nDo not exceed five seconds when performing the engine loaded test or damage to the transmission/transaxle may result.",
                                "The steps of the Engine Loaded Test are: \r\n1. Block the front and back wheels.\r\n2. Apply the parking and service brakes. \r\n3. Put the transmission in Drive while keeping the brakes applied. \r\n4. Increase the engine rpm to the rpm at which the NVH concern occurred. If necessary, \r\n      make note of the RPM and frequency of the NVH concern. \r\n5. Return engine to idle. \r\n6. Put the transmission in Reverse while keeping the brakes applied. \r\n7. Increase the engine RPM to the RPM at which the NVH concern occurred. If necessary, \r\n      make note of the RPM and frequency of the NVH concern. \r\n      If the concern is definitely engine speed-related, \r\n      perform the Engine Accessory Test to narrow down the possible source of the concern.",
                                "Immediately after engine loaded test, run in neutral for 3 minutes at a slightly elevated RPM to cool the transmission.",
                                "Back",
                                "Engine Accessory Test",
                                "Perform the Engine Accessory Test if the NVH concern is engine speed-related. \r\nThis test helps locate faulty belts and accessories that are causing engine speed-related NVH concerns. \r\nThe steps are: \r\n1. Block the front and back wheels. \r\n2. Apply the parking and service brakes. \r\n3. Remove the accessory drive belt(s). \r\n4. Increase engine rpm to the rpm at which the NVH concern occurred. \r\n      - If the vibration occurs, the belts and accessories are not the source of the concern.\r\n      - If the belts and accessories are the source of the NVH concern, \r\n         continue to add or remove specific accessory belts to locate the concern",
                                "Caution: With the accessory belt removed: \r\n      - Do not drive the vehicle\r\n      - Do not operate the engine for more than a few minutes or\r\n            • Water-cooled alternators can fail \r\n            • Engines can overheat",
                                "Back",

                                // Forma_HomeScreen
                                "Uvod",

                                // Forma_Uvod
                                "PLACEHOLDERSTRING Forma_Uvod.Text",
                                "Definitions",
                                "Noise",
                                "is defined as any unpleasant or unexpected sound created by a vibrating object.",
                                "Vibration",
                                "is defined as any objectionable repetitive motion of an object, back-and-forth or up-and-down.",
                                "Harshness",
                                "is defined as an aggressive suspension feel or lack of “give” in response to a single input.",
                                "A",
                                "sound",
                                "is a vibration (pressure fluctuation) of the air.",
                                "Vibrations and sounds are both expressed as waves per second called Hertz (Hz). \r\n      - Vibrations that are felt are under 200 Hz \r\n      - Vibrations between 20 Hz - 20,000 Hz are audible by humans \r\n      - Vibrations over 20,000 Hz are ultrasonic and are not audible by humans",
                                "There are common characteristics of noise and vibrations.",
                                "      - Cycle \r\n      - Frequency \r\n      - Amplitude \r\n      - Order \r\n      - Resonance \r\n      - Transmission of vibrations and sound",
                                "Cycle",
                                "Cycle is the path a wave travels before the wave begins to repeat the path again. \r\ne.g. If the wheel makes 5 full revolutions this is equal to 5 complete cycles.",
                                "Frequency",
                                "Frequency is the number of complete cycles that occur in one second. \r\nSound and vibration waves are measured in Hz, or Cycles Per Second (CPS). \r\nFigure A shows a vibration of 3 Hz, and Figure B a vibration of 8 Hz.",
                                "Figure A",
                                "Figure B",
                                "The higher the vibration, the higher the pitch of the sound \r\ne.g. bearings rotating at a high speed will produce a very high pitched sound",
                                "Amplitude",
                                "Amplitude refers to the vertical measurement between the top and the bottom of a wave. \r\nTwo waves can have the same frequency, but differ in amplitude. \r\nAmplitude is the quantity or amount of energy produced by a vibrating component. \r\nLow amplitude (Figure A) is equal to low intensity, and high amplitude (Figure B) to high intensity",
                                "Figure A",
                                "Figure B",
                                "Frequency order",
                                "Order is number of disturbances created in one revolution of component. \r\nFor example (Figure A), single high spot on tire creates a first order disturbance (one disturbance per revolution) \r\nand therefore vibration of first order. \r\nIf the tire is rotating at the rate of 10 rotations per second it will create first order vibration of 10 Hz. \r\nIf there is a second high spot on tire, second order disturbance would result, so at the same speed, vibration will be 20 Hz. \r\nFor some components or systems third and fourth order of vibrations can develop.",
                                "Figure A",
                                "Resonance",
                                "Resonance is the tendency of a system to respond to a compelling force oscillating at a natural frequency of the system. \r\nAll objects have natural frequencies. \r\nThe amplitude of a vibration is greatest at the point of resonance. \r\nResonance occurs when the vibrating force (external force) on a vibrating system is moving at the same frequency (Hz) \r\nas the natural frequency of that vibrating system. \r\nThe resulting wave that occurs is at the same frequency but with much greater amplitude (Figure A).",
                                "Phenomenon of resonance may cause small vibration to excite very large vibration that can be felt in the vehicle.",
                                "Transmission of vibrations and sound",
                                "Vibrations and sound are transmitted the same way. There has to be a: \r\n      - Vibrating force \r\n      - Resonating system \r\n      - Transmission system (path) \r\n      - Vibrating element (vibration)",
                                "Sources of",
                                "vibrating forces",
                                "in vehicles could be:",
                                "      - Combustion \r\n      - Tires contacting a rough road \r\n      - Imbalance or run-out of a rotating component \r\n      - Fluctuation of friction surfaces",
                                "A",
                                "Resonance System", // 289
                                "is any component on the vehicle that resonates when it recieves a vibrating force.",
                                "All components will resonate if the vibrating force matches the natural frequency. \r\nSome examples are: \r\n      - Tires resonate when vibrated by the road \r\n      - Suspension systems will resonate with an out of balance tire \r\n      - An exhaust system will resonate when vibrated by the engine",
                                "The", // 292, label41
                                "Transmission System",
                                "is the path in the vehicle that carries the vibration from the resonance system to the vibrating element.",
                                "Examples of a transmission system or path are the: \r\n      - Exhaust system \r\n      - Engine mounts",
                                "These components carry engine vibrations through the vehicle.",
                                "The",
                                "Vibrating element",
                                "is the component that generates the vibration or sound that can be sensed.",
                                "Examples of Vibrating elements are: \r\n      - Body \r\n      - Steering wheel \r\n      - Seat \r\n      - Shifter \r\n      - Mirror",
                                "In most of the cases, NVH issue is resolved by fixing the source of the vibrating force, \r\nbut sometimes any change in transmission process can be the repair.",
                                "For example: \r\n      - Vibrating force is engine \r\n      - Resonating system is exhaust \r\n      - Transmission system is contact of the exhaust and body \r\n      - Vibrating element is the body panel",
                                "By repairing elastic contact between exhaust and body, NVH problem will be resolved.",
                                "Measuring the frequency",
                                "In order to find the source of vehicle vibrations it is necessary to measure the vibrating frequency and engine/vehicle speed \r\nat which that vibration frequency occurs. There are many tools as shown in the figures below.",

                                // Forma_Centar_!Glavni
                                "U ovo polje mora biti unet broj između 100 i 8000.", // 306
                                "U ovo polje mora biti unet broj između 1 i 500.", // 307
                                // Forma_Centar_Agregat_Glavni
                                "U ovo polje mora biti unet pozitivan broj.", // 308
                                // Forma_Desni_Glavni
                                "U ovo polje mora biti unet pozitivan broj.", // 309
                                "U ovo polje mora biti unet broj između 5 i 200.", // 310

                                // uopste korisceno
                                "Greška", // 311
                                "Informacije", // 312
                                "Upozorenje", // 
                                "Return to top", // 314 // na Forma_Uvod i Forma_Centar_Tekst

                                // Forma_TestVoznja
                                "Return to top", // 315

                                // Forma_Centar_!Glavni
                                "No preset", // 316
                                "Automobil 1", // 317
                                "Automobil 2", // 318

                                // Forma_Centar_Tekst
                                "PLACEHOLDERSTRING Forma_Centar_Tekst.Text", // 319
                                "Engine speed related vibrations",
                                "Based on the frequency of the vibration and driving conditions, the noise or vibration can be isolated into three component groups: ",
                                "      -",
                                "Engine vibrations",
                                "Engine firing frequency",
                                "Engine accessory vibrations",
                                "Engine vibrations",
                                "First order",
                                "A first-order engine imbalance is created when any component that rotates at crankshaft speed is out-of-balance or has excessive \r\nrunout.",
                                "First order vibrations can be caused by: ",
                                "      - flywheel out of balalnce or excessive runout",
                                "      -",
                                "Crankshaft pulley (Torsional vibration dampener)",
                                "      - Cylinder to cylinder mass difference",
                                "      -",
                                "Torque converter",
                                "      - Imbalanced crankshaft", // 336
                                "Crankshaft pulley (Torsional vibration dampener)",
                                "Out of balance or out of round TVD will transfer engine vibrations to the belt drive. Improper TVD (figure 1) will fail to dampen \r\ncrankshaft vibrations, which will be transferred to the belt drive.",
                                "Figure 1a (TVD as specified)",
                                "Figure 1b (Improper TVD)",
                                "Torque converter",
                                "The torque converter frrequency is the same as the engine frequency. The torque converter can be suspected as the cause of \r\nnoise or vibration when an NVH concern is torque sensitive.",
                                "Refer to torque converter test drive tips.",
                                "Torque converter vibrations can be caused by:",
                                "      -",
                                "The movement of the fluid between the impeller, which is connected to the engine, and the turbine, which connects to the \r\ntransmission (in this case vibration will disappear as soon as the TCC is engaged).",
                                "      - Clutch engagement",
                                "      - Clutch release during downshift or coasting",
                                "      - Torque converter imabalnce or incorrectly installed converter",
                                "Second order",
                                "Second order vibrations are caused either by two first order issues or by the up-and-down motion of the pistons. This reversal of \r\nmass and motion creates a natural vibration.",
                                "On four cylinder engines, second order vibration is equal to",
                                "engine firing frequency",
                                "Third order",
                                "On six cylinder engines, second order vibration is equal to",
                                "engine firing frequency",
                                "Fourth order",
                                "On eight cylinder engines, second order vibration is equal to",
                                "engine firing frequency",
                                "Engine firing frequency",
                                "Firing frequency refers to the force created by the engine each time cylinder fires. This is the natural vibration of the internal \r\ncombustion engine. Firing frequency is load dependent. Higher the engine load is, frequency is more prominent. If there is a \r\nproblem on the engine, which is affecting combustion process, this vibration will increase.",
                                "Even that firing frequency is natural to ICE, it have to be isolated from the vehicle body.",
                                "Firing frequency vibrations could be caused by:",
                                "      -",
                                "Engine mounts",
                                "      -",
                                "Exhaust hangers",
                                "      - Engine problems, affecting combustion process",
                                "Engine mounts",
                                "The first compontents that isolate vibration from the engine to the passenger compartment are engine mounts. Any fault in the \r\nengine mounting system can lead directly to noise and vibration.",
                                "Inspect engine mounts for cracks or damage to the insulator and the bracket (figure 2). Grounded, the engine mounted bracket \r\ncontacting the frame-mounted bracket, or strained engine mounts may not isolate engine vibrations.",
                                "Engine mounts must be installed correctly and tighten with the specific torque. If the mounts are installed incorrectly or incorrect \r\nparts are used, they cannot absorb engine vibration. Pay attention on proper type of engine mount installed. (figure 3)",
                                "Figure 2",
                                "Figure 3",
                                "Exhaust hangers",
                                "The compelling force of exhaust exiting each cylinder creates a pulsation on the exhaust manifold. The pulsating pressure at the \r\nexhaust manifold produces acoustic energy, which is transmitted to the exhaust pipe.",
                                "The pulsating sound waves traveling through the exhaust pipe are a source of vibration for the exhaust system. The combination \r\nof engine and exhaust vibrations within the exhaust system must be isolated to prevent them from acting on the body of the \r\nvehicle. Exhaust hangers (figure 4) are used to suspend the exhaust pipe from the body and to prevent transmission of vibration \r\nto the body.",
                                "Figure 4",
                                "Engine accessory vibrations",
                                "Engine accessories related vibrations can be found either by engine accessory test (refer to test drive section) or by calculation \r\nbased on engine RPM and ratio between accessories and crankshaft pulley.",
                                "Engine acessory vibrations could be caused by: \r\n      - Out of balance component \r\n      - Worn out components \r\n      - Out of round pulley \r\n      - Untightens of pulley \r\n      - Untightens of component \r\n      - Worn out component shaft bearings \r\n      - Pressure fluctuation (e.g. power steering pump) \r\n      - Overcharged refrigerant (AC compressor)",
                                // 381

                                // Forma_Desni_Tekst_Driveline
                                "PLACEHOLDERSTRING Forma_Desni_Tekst_Driveline.Text",
                                "Driveline-related concerns are usually caused by the following conditions: \r\n      - A propeller shaft imbalance \r\n      - A damaged propeller shaft \r\n      - Missing shaft balance weights \r\n      - Improper propeller shaft operating angles \r\n      - Worn universal or CV joint \r\n      - Worn center bearings \r\n      - Loose spring U-bolts \r\n      - Loose or broken springs \r\n      - Damaged axle shaft bearings \r\n      - Loose pinion gear nut \r\n      - Excessive pinion flange runout \r\n      - Pinion and ring gear pitch line variation",
                                "Drive shaft vibrations can be classified into three different orders: first-order, second-order, and fourth-order.",
                                "A first-order vibration may be caused by a: \r\n      - A damaged or bent propeller shaft \r\n      - A damaged driveline components \r\n      - Worn CV or U joint \r\n      - A propeller shaft imbalance \r\n      - Hydromount sliping \r\n      - Driveshaft central bearing damage \r\n      - Loose pinion gear nut \r\n      - Worn pinion gear",
                                "A second-order vibration may be caused by:  \r\n      - Driveshaft angle \r\n      - U-joint cancelation \r\n      - Worn CV or U joint",
                                "A fourth-order vibration may be caused by a: \r\n      - Driveshaft angle \r\n      - Worn CV or U joint",
                                "Check the following:",
                                "      -",
                                "Driveshaft runout",
                                "      -",
                                "Missing balance weights",
                                "      -",
                                "Pinion and ring gear pitch line",
                                "      -",
                                "Driveline operating angles",
                                "Driveshaft runout",
                                "Place the dial indicator at a 90 degree angle from the drive shaft and measure the runout at the ends of the drive shaft (figure 1), as \r\nwell as in the middle of the shaft (figure 2).",
                                "Figure 1",
                                "Figure 2",
                                "PLACEHOLDERSTRING If the measured values are not within vehicle manufacturer specifications (typically 0.5 mm at the ends and \r\n0.6 mm at the middle), preplace (typo? replace?) the driveshaft.",
                                "Back",
                                "Missing balance weights",
                                "Visually check for missing driveshaft balance weights (figure 3).",
                                "Figure 3",
                                "Back",
                                "Pinion and ring gear pitch line",
                                "If the contact between pinion and ring gear is uneven (there is an excessive pitch line runout), ring gear speed will vary and cause \r\nthe drive line vibrations. \r\nRemove the axle cover, and with the aid of special paint, check for correct contact patter between ring and pinion gear (figure 4).",
                                "Figure 4",
                                "Back",
                                "Driveline operating angles",
                                "The operating angle of a universal joint is the difference between the angles formed when two shafts intersect. \r\nIn a one-piece propeller shaft system, there are two operating angles present: the front and the rear.",
                                "The front operating angle is formed by the angle of the propeller shaft and the angle of the transmission output shaft (figure 5).",
                                "Figure 5",
                                "The rear operating angle is formed by the angle of the propeller shaft and the angle of the rear axle pinion.",
                                "To check driveline alignment, raise and support the vehicle at the axles as level as possible. \r\nAllow the wheels and propeller shaft to turn.",
                                "Record the angle A (figure 6). \r\nRotate the shaft until the transmission yoke bearing is facing downward. \r\nPlace the inclinometer on the yoke bearing parallel to the shaft and record the measurement A.",
                                "Record the angle B (figure 6). \r\nRotate the shaft until the pinion yoke bearing is facing downward. \r\nPlace the inclinometer on the yoke bearing parallel to the shaft and record the measurement B.",
                                "Record the angle C (figure 6). \r\nRotate the shaft for 90 degrees until the propeller shaft yoke bearing is facing downward. \r\nPlace the inclinometer on the yoke bearing parallel to the shaft and record the measurement C. Angle C can be measured on both \r\nends, as well as on the shaft itself.",
                                "Figure 6",
                                "Front angle is equal to Angle C - Angle A \r\nRear angle is equal to Angle C - Angle B",
                                "      -",
                                "Both front and rear angles must be within vehicle manufacturers specifications",
                                "      -",
                                "The front and rear angles need to be within one degree of each other (Typical value - check manufacturer specifications)",
                                "      -",
                                "Operating angles should be less than 3 degrees (Typical value - check manufacturer specifications)",
                                "      -",
                                "PLACEHOLDERSTRING (typo) The rear angle has to bigger than the front",
                                "      -",
                                "Neither angle can be zero",
                                "If the driveline is a two piece system additional angle have to be measured. \r\nInput angle of the transmission, transfer shaft angle, drive shaft angle and output angle of the pinion.",
                                "Back",

                                // Forma_Desni_Tekst_Tocak
                                "PLACEHOLDERSTRING Forma_Desni_Tekst_Tocak.Text", // 434
                                "Wheel frequency",
                                "Wheel first odrer frequency is related to vibration caused by wheel or anything which is rotating at the same speed as wheel.",
                                "Some of the causes could be: \r\n      - Wheel and tire imbalance \r\n      - Condition of the wheels and tires \r\n      - Foreign debris in wheel \r\n      - A wheel or tire that is out of round \r\n      - Uniformity \r\n      - Tire dimensions \r\n      - Conicity \r\n      - Radial force variation \r\n      - Brake rotor or brake drum imbalance \r\n      - Constant velocity (CV) shaft \r\n      - Excessive hub runout \r\n      - Axle shaft problems",
                                "Higher order wheel frequency indicates several independent first order issues or problem with: \r\n      - Joint of wheel and driveshaft \r\n      - Non uniform tires on vehicle \r\n      - Radial force variation",
                                "Check the following:",
                                "      -",
                                "Balance the tire/wheel",
                                "      -",
                                "Radial wheel and tire assembly runout",
                                "      -",
                                "Lateral wheel and tire assembly runout",
                                "      -",
                                "Radial wheel runout",
                                "      -",
                                "Lateral wheel runout",
                                "      -",
                                "Hub/Brake disc runout",
                                "      -",
                                "Radial force variation",
                                "      -",
                                "Bent axle shaft",
                                "      -",
                                "Joint of wheel and axle shaft",
                                "Radial wheel and tire assembly runout",
                                "Radial runout can be measured on the vehicle (hub, wheel and tire total runout).",
                                "Raise the vehicle, apply masking tape on tire circumference (figure 1), and check the runout with dial gauge. Measured value should \r\nbe compared to vehicle manufacturer data (typically maximum is 0.8 to 1 mm).",
                                "Radial runout can also be measured off the vehicle. In this case hub is ruled out.",
                                "Figure 1",
                                "If the measured value is above specifications, problem could be in tire, wheel, or hub.",
                                "Proceed with radial runout measurements",
                                "If the measured value is below specifications, proceed with lateral runout measurements.",
                                "Back",
                                "Lateral wheel and tire assembly runout",
                                "Measure the lateral runout with the dial gauge positioned on the flat surface of tire sidewall (figure 2).",
                                "Measured value should be compared to vehicle manufacturer data (typically maximum is 0.8 to 1.2 mm).",
                                "Figure 2",
                                "If the measured value is above specifications, problem could be in tire, wheel, or hub.",
                                "Proceed with lateral runout measurements.",
                                "Back",
                                "Radial wheel runout",
                                "Radial wheel runout could be measured while the wheel is on the vehicle (wheel and hub total runout), or which wheel off the vehicle \r\n(only the wheel runout). Place the dial gauge and measure the runout (figure 3).",
                                "Measured value should be compared to vehicle manufacturer data (typically maximum is 0.25 mm for alloy wheels or 0.5 mm for \r\nsteel wheels).",
                                "Figure 3",
                                "If the measured value is above specifications, problem could be in wheel or hub.",
                                "Proceed with radial runout measurements.",
                                "If the value is within specifications, problem is in the tire.",
                                "Back",
                                "Lateral wheel runout",
                                "Lateral wheel runout could be measured whiel the wheel is on the vehicle (wheel and hub total runout), or with wheel off the vehicle \r\n(only the wheel runout). Place the dial gauge and measure the runout (figure 4).",
                                "Measured value should be compared to vehicle manufacturer data (typically maximum is 0.5 to 0.8 mm).",
                                "Figure 4",
                                "If the measured value is above specifications, problem could be in wheel or hub.",
                                "Proceed with alteral runout measurements.",
                                "If the value is within specifications, problem is in the tire.",
                                "Back",
                                "Hub/Brake disc runout",
                                "Measure the brake disc runout, either on the hub (figure 5) or off the vehicle (figure 6) and compare the measured value with the \r\nvehicle manufacturer specifications.",
                                "If the measured value on the hub is within specifications, problem is on the wheel.",
                                "If the measured value of the vehicle is within specifications, problem is on the hub.",
                                "Figure 5",
                                "Figure 6",
                                "Back",
                                "Radial force variation",
                                "Radial force variation is a term describing the tire unifomity under load, measuring the variation of the load acting on the vehicle \r\nspindle.",
                                "If the sidewall stiffness, of the tire, is not uniform (figure 7), a vertical force is exerted on the axle and makes it move up and down. \r\nThis movement creates vibrations unrelated to wheelbalance.",
                                "Figure 7",
                                "A tire with noticable radial force variation will produce a vibration even though it is perfectly balanced and is within the \r\nradial and lateral runout limits.",
                                "Special equipment should be used to check for radial force variation (figure 8).",
                                "Figure 8",
                                "Back",
                                "Bent axle shaft",
                                "Place the dial indicator at 90 degree angle from the axle shaft and measure the runout at the ends of the axleshaft, as well as in the \r\nmiddle of the shaft (figure 9).",
                                "Figure 9",
                                "If the measured values are not within vehicle manufacturer specifications, replace the shaft."
                                };

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
            Jezik[0]   = "Proračun vibracija";
            Jezik[1]   = "Saveti za test vožnju";
            Jezik[2]   = "Motor";
            Jezik[3]   = "Auto";
            Jezik[4]   = "PLACEHOLDERSTRING Form1.dugmeLevo_Click";

            // Forma_Centar_Glavni
            Jezik[5]   = "Vibracije motora";
            Jezik[6]   = "Unos podataka";
            Jezik[7]   = "Decimale se označavaju tačkom, ne zarezom.";
            Jezik[8]   = "RPM";
            Jezik[9]   = "Izmerena frekvencija";
            Jezik[10]  = "Broj cilindara";
            Jezik[11]  = "Potvrdi podatke";
            Jezik[12]  = "Vibracije agregata";
            Jezik[13]  = "Greška, nedovoljan broj polja popunjen.";
            Jezik[14]  = "Greška, u nekom od polja je uneta nevažeća vrednost.";

            // Forma_Centar_Tabela
            Jezik[15]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.Text";
            Jezik[16]  = "RPM";
            Jezik[17]  = "Frekvencija motora";
            Jezik[18]  = "Frekvencija motora drugog reda";
            Jezik[19]  = "Frekvencija motora trećeg reda";
            Jezik[20]  = "Frekvencija motora četvrtog reda";
            Jezik[21]  = "Frekvencija bregaste";
            Jezik[22]  = "Frekvencija paljenja";
            Jezik[23]  = "Izmerene frekvencije";
            Jezik[24]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM_Click";
            Jezik[25]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM2_Click";
            Jezik[26]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM3_Click";
            Jezik[27]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FM4_Click";
            Jezik[28]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FB_Click";
            Jezik[29]  = "PLACEHOLDERSTRING Forma_Centar_Tabela.button_FP_Click";

            // Forma_Centar_Grafik
            Jezik[30]  = "Vibracije motora";
            Jezik[31]  = "Iscrtaj ponovo";
            Jezik[32]  = "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:";
            Jezik[33]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM_Click USLOV ISPUNJEN";
            Jezik[34]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM_Click USLOV NE ISPUNJEN";
            Jezik[35]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM2_Click USLOV ISPUNJEN";
            Jezik[36]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM2_Click USLOV NE ISPUNJEN";
            Jezik[37]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM3_Click USLOV ISPUNJEN";
            Jezik[38]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM3_Click USLOV NE ISPUNJEN";
            Jezik[39]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM4_Click USLOV ISPUNJEN";
            Jezik[40]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FM4_Click USLOV NE ISPUNJEN";
            Jezik[41]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FB_Click USLOV ISPUNJEN";
            Jezik[42]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FB_Click USLOV NE ISPUNJEN";
            Jezik[43]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FP_Click USLOV ISPUNJEN";
            Jezik[44]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_FP_Click USLOV NE ISPUNJEN";
            Jezik[45]  = "FM";
            Jezik[46]  = "FM2";
            Jezik[47]  = "FM3";
            Jezik[48]  = "FM4";
            Jezik[49]  = "FB";
            Jezik[50]  = "FP";
            Jezik[51]  = "FM - frekvencija motora";
            Jezik[52]  = "FM2 - frekvencija motora drugog reda";
            Jezik[53]  = "FM3 - frekvencija motora trećeg reda";
            Jezik[54]  = "FM4 - frekvencija motora četvrtog reda";
            Jezik[55]  = "FB - frekvencija bregaste";
            Jezik[56]  = "FP - frekvencija paljenja";

            // Forma_Centar_Agregat_Glavni
            Jezik[57]  = "Unos podataka";
            Jezik[58]  = "Decimale se označavaju tačkom, ne zarezom.";
            Jezik[59]  = "Prečnik remenice radilice";
            Jezik[60]  = "Prečnik remenice alternatora";
            Jezik[61]  = "Prečnik remenice kompresora klime";
            Jezik[62]  = "Prečnik remenice servo volana";
            Jezik[63]  = "Prečnik remenice pumpe za vodu";
            Jezik[64]  = "Prečnik remenice dodatnog agregata 1";
            Jezik[65]  = "Prečnik remenice dodatnog agregata 2";
            Jezik[66]  = "Potvrdi podatke"; // nekada je pisalo "izracunaj" ali ja sam promenio cisto da bude u skladu sa onim sto pise na FormaCentarGlavni
            Jezik[67]  = "Greška, nedovoljno polja popunjeno.";
            Jezik[68]  = "Greška, u nekom od polja je uneta nevažeća vrednost.";

            // Forma_Centar_Agregat_Tabela
            Jezik[69]  = "Proračun vibracija agregata";
            Jezik[70]  = "RPM";
            Jezik[71]  = "Frekvencija: ";
            Jezik[72]  = "Alternatora";
            Jezik[73]  = "Kompresora klime";
            Jezik[74]  = "Servo volana";
            Jezik[75]  = "Pumpe za vodu";
            Jezik[76]  = "Dodatnog agregata 1";
            Jezik[77]  = "Dodatnog agregata 2";
            Jezik[78]  = "Izmerene frekvencije";
            Jezik[79]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D1_Click";
            Jezik[80]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D2_Click";
            Jezik[81]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D3_Click";
            Jezik[82]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D4_Click";
            Jezik[83]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D5_Click";
            Jezik[84]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Tabela.button_D6_Click";

            // Forma_Centar_Agregat_Grafik
            Jezik[85]  = "PLACEHOLDERSTRING Forma_Centar_Agregat_Grafik.Text";
            Jezik[86]  = "Iscrtaj ponovo";
            Jezik[87]  = "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:";
            Jezik[88]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D1_Click USLOV ISPUNJEN";
            Jezik[89]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D1_Click USLOV NE ISPUNJEN";
            Jezik[90]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D2_Click USLOV ISPUNJEN";
            Jezik[91]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D2_Click USLOV NE ISPUNJEN";
            Jezik[92]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D3_Click USLOV ISPUNJEN";
            Jezik[93]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D3_Click USLOV NE ISPUNJEN";
            Jezik[94]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D4_Click USLOV ISPUNJEN";
            Jezik[95]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D4_Click USLOV NE ISPUNJEN";
            Jezik[96]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D5_Click USLOV ISPUNJEN";
            Jezik[97]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D5_Click USLOV NE ISPUNJEN";
            Jezik[98]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D6_Click USLOV ISPUNJEN";
            Jezik[99]  = "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D6_Click USLOV NE ISPUNJEN";
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
            Jezik[126] = "Greška, nedovoljno polja popunjeno.";
            Jezik[127] = "Greška, u nekom od polja je uneta nevažeća vrednost.";

            // Forma_Desni_Tabela
            Jezik[128] = "PLACEHOLDERSTRING Forma_Desni_Tabela.Text";
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
            Jezik[149] = "PLACEHOLDERSTRING Forma_Desni_Grafik.Text";
            Jezik[150] = "Iscrtaj ponovo";
            Jezik[151] = "U slučaju da koordinatni sistem nije pravilno iscrtan, poravnajte prozor sa gornjim i levim ivicama ekrana i pritisnite dugme:";
            Jezik[152] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx1_Click USLOV ISPUNJEN";
            Jezik[153] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx1_Click USLOV NE ISPUNJEN";
            Jezik[154] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx2_Click USLOV ISPUNJEN";
            Jezik[155] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx2_Click USLOV NE ISPUNJEN";
            Jezik[156] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx3_Click USLOV ISPUNJEN";
            Jezik[157] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx3_Click USLOV NE ISPUNJEN";
            Jezik[158] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx4_Click USLOV ISPUNJEN";
            Jezik[159] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FTx4_Click USLOV NE ISPUNJEN";
            Jezik[160] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx1_Click USLOV ISPUNJEN";
            Jezik[161] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx1_Click USLOV NE ISPUNJEN";
            Jezik[162] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx2_Click USLOV ISPUNJEN";
            Jezik[163] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx2_Click USLOV NE ISPUNJEN";
            Jezik[164] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx3_Click USLOV ISPUNJEN";
            Jezik[165] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx3_Click USLOV NE ISPUNJEN";
            Jezik[166] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx4_Click USLOV ISPUNJEN";
            Jezik[167] = "PLACEHOLDERSTRING Forma_Desni_Grafik_button_FKx4_Click USLOV NE ISPUNJEN";
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
            Jezik[191] = "PLACEHOLDERSTRING Forma_TestVoznja.Text";

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

            // Forma_TestVoznja
            Jezik[204] = "Pre-Road Test inspection";
            Jezik[205] = "Road test";
            Jezik[206] = "Pre-Road Test inspection \r\nCheck the tires for: \n      - Inflation pressure \r\n      - Proper tire type \r\n      - Verify the tires are uniform in size and brand \r\n      - Abnormal tire wear and correct thread depth \r\nCheck the wheels for: \r\n      - Mud, ice and debris \r\n      - Deformed or bent \r\n      - Missing wheel weights \r\n      - Log nuts tightening torque \r\nCheck the vehicle for: \r\n      - Signs of damaged components \r\n      - Signs of collision damage \r\n      - Added components \r\nNotes: \r\n      - It is important to know which specific concern the customer has with their vehicle \r\n       - Don't be misled by the reported location of the noise or vibration, cause may be in another area of vehicle \r\n      - The vibrating component may only generate a small vibration, but this small vibration may cause a larger vibration or noise. \r\n      - It must be possible to operate the vehicle at the speed in which the condition occurs. \r\n      - Prepare measuring equipment.";
            Jezik[207] = "Back";
            Jezik[208] = "Road test \r\nIn order to determine engine speed, vehicle speed and frequency of the NVH concern, as well to establish is it a engine \r\nor vehicle speed related vibrations, perform the test drive: ";

            promenaJezika();
        }
        
        private void jezikDugme_Engleski_Click(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < Jezik.Length; i++) Jezik[i] = "P ID " + i.ToString();
            /*
            // Forma_HomeScreen
            Jezik[0]   = "Vibration calculator";
            Jezik[1]   = "Test drive tips";
            Jezik[2]   = "Engine";
            Jezik[3]   = "Vehicle";
            Jezik[4]   = "P ID 4";

            // Forma_Centar_Glavni
            Jezik[5]   = "Engine vibrations";  // zasto nije "Engine-related vibrations"?
            Jezik[6]   = "P ID 6";
            Jezik[7]   = "P ID 7";
            Jezik[8]   = "P ID 8";
            Jezik[9]   = "P ID 9";
            Jezik[10]  = "P ID 10";
            Jezik[11]  = "P ID 11";
            Jezik[12]  = "P ID 12";
            Jezik[13]  = "P ID 13";
            Jezik[14]  = "P ID 14";

            // Forma_Centar_Tabela
            Jezik[15]  = "P ID 15";
            Jezik[16]  = "P ID 16";
            Jezik[17]  = "P ID 17";
            Jezik[18]  = "P ID 18";
            Jezik[19]  = "P ID 19";
            Jezik[20]  = "P ID 20";
            Jezik[21]  = "P ID 21";
            Jezik[22]  = "P ID 22";
            Jezik[23]  = "P ID 23";
            Jezik[24]  = "P ID 24";
            Jezik[25]  = "P ID 25";
            Jezik[26]  = "P ID 26";
            Jezik[27]  = "P ID 27";
            Jezik[28]  = "P ID 28";
            Jezik[29]  = "P ID 29";

            // Forma_Centar_Grafik
            Jezik[30]  = "Engine-related vibrations";
            Jezik[31]  = "P ID 31";
            Jezik[32]  = "P ID 32";
            Jezik[33]  = "P ID 33";
            Jezik[34]  = "P ID 34";
            Jezik[35]  = "P ID 35";
            Jezik[36]  = "P ID 36";
            Jezik[37]  = "P ID 37";
            Jezik[38]  = "P ID 38";
            Jezik[39]  = "P ID 39";
            Jezik[40]  = "P ID 40";
            Jezik[41]  = "P ID 41";
            Jezik[42]  = "P ID 42";
            Jezik[43]  = "P ID 43";
            Jezik[44]  = "P ID 44";
            Jezik[45]  = "P ID 45";
            Jezik[46]  = "P ID 46";
            Jezik[47]  = "P ID 47";
            Jezik[48]  = "P ID 48";
            Jezik[49]  = "P ID 49";
            Jezik[50]  = "P ID 50";
            Jezik[51]  = "P ID 51";
            Jezik[52]  = "P ID 52";
            Jezik[53]  = "P ID 53";
            Jezik[54]  = "P ID 54";
            Jezik[55]  = "P ID 55";
            Jezik[56]  = "P ID 56";

            // Forma_Centar_Agregat_Glavni
            Jezik[57]  = "P ID 57";
            Jezik[58]  = "P ID 58";
            Jezik[59]  = "P ID 59";
            Jezik[60]  = "P ID 60";
            Jezik[61]  = "P ID 61";
            Jezik[62]  = "P ID 62";
            Jezik[63]  = "P ID 63";
            Jezik[64]  = "P ID 64";
            Jezik[65]  = "P ID 65";
            Jezik[66]  = "P ID 66";
            Jezik[67]  = "P ID 67";
            Jezik[68]  = "P ID 68";

            // Forma_Centar_Agregat_Tabela
            Jezik[69]  = "P ID 69";
            Jezik[70]  = "P ID 70";
            Jezik[71]  = "P ID 71";
            Jezik[72]  = "P ID 72";
            Jezik[73]  = "P ID 73";
            Jezik[74]  = "P ID 74";
            Jezik[75]  = "P ID 75";
            Jezik[76]  = "P ID 76";
            Jezik[77]  = "P ID 77";
            Jezik[78]  = "P ID 78";
            Jezik[79]  = "P ID 79";
            Jezik[80]  = "P ID 80";
            Jezik[81]  = "P ID 81";
            Jezik[82]  = "P ID 82";
            Jezik[83]  = "P ID 83";
            Jezik[84]  = "P ID 84";

            // Forma_Centar_Agregat_Grafik
            Jezik[85]  = "P ID 85";
            Jezik[86]  = "P ID 86";
            Jezik[87]  = "P ID 87";
            Jezik[88]  = "P ID 88";
            Jezik[89]  = "P ID 89";
            Jezik[90]  = "P ID 90";
            Jezik[91]  = "P ID 91";
            Jezik[92]  = "P ID 92";
            Jezik[93]  = "P ID 93";
            Jezik[94]  = "P ID 94";
            Jezik[95]  = "P ID 95";
            Jezik[96]  = "P ID 96";
            Jezik[97]  = "P ID 97";
            Jezik[98]  = "P ID 98";
            Jezik[99]  = "P ID 99";
            Jezik[100] = "P ID 100";
            Jezik[101] = "P ID 101";
            Jezik[102] = "P ID 102";
            Jezik[103] = "P ID 103";
            Jezik[104] = "P ID 104";
            Jezik[105] = "P ID 105";
            Jezik[106] = "P ID 106";
            Jezik[107] = "P ID 107";
            Jezik[108] = "P ID 108";
            Jezik[109] = "P ID 109";
            Jezik[110] = "P ID 110";
            Jezik[111] = "P ID 111";

            // Forma_Desni_Glavni
            Jezik[112] = "P ID 112";
            Jezik[113] = "P ID 113";
            Jezik[114] = "P ID 114";
            Jezik[115] = "P ID 115";
            Jezik[116] = "P ID 116";
            Jezik[117] = "P ID 117";
            Jezik[118] = "P ID 118";
            Jezik[119] = "P ID 119";
            Jezik[120] = "P ID 120";
            Jezik[121] = "P ID 121";
            Jezik[122] = "P ID 122";
            Jezik[123] = "P ID 123";
            Jezik[124] = "P ID 124";
            Jezik[125] = "P ID 125";
            Jezik[126] = "P ID 126";
            Jezik[127] = "P ID 127";

            // Forma_Desni_Tabela
            Jezik[128] = "P ID 128";
            Jezik[129] = "P ID 129";
            Jezik[130] = "P ID 130";
            Jezik[131] = "P ID 131";
            Jezik[132] = "P ID 132";
            Jezik[133] = "P ID 133";
            Jezik[134] = "P ID 134";
            Jezik[135] = "P ID 135";
            Jezik[136] = "P ID 136";
            Jezik[137] = "P ID 137";
            Jezik[138] = "P ID 138";
            Jezik[139] = "P ID 139";
            Jezik[140] = "P ID 140";
            Jezik[141] = "P ID 141";
            Jezik[142] = "P ID 142";
            Jezik[143] = "P ID 143";
            Jezik[144] = "P ID 144";
            Jezik[145] = "P ID 145";
            Jezik[146] = "P ID 146";
            Jezik[147] = "P ID 147";
            Jezik[148] = "P ID 148";
            Jezik[149] = "P ID 149"; */

            promenaJezika();
        }

        private void jezikDugme_Nemacki_Click(object sender, EventArgs e)
        {
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
            
        }

#pragma warning restore IDE1006
    }
}
