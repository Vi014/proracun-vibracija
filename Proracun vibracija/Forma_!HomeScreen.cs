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
        public Forma_TestVoznja    FormaTestVoznja;
        public Forma_Centar_Glavni FormaCentarGlavni;
        public Forma_Desni_Glavni  FormaDesniGlavni;
        public Forma_Uvod          FormaUvod;

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
                                "PLACEHOLDERSTRING Forma_Centar_Grafik.button_D1_Click USLOV NE ISPUNJEN", // ne brisati ove za uslov ne ispunjen
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
                                "Engine acessory vibrations could be caused by: \r\n      - Out of balance component \r\n      - Worn out components \r\n      - Out of round pulley \r\n      - Untightens of pulley \r\n      - Untightens of component \r\n      - Worn out component shaft bearings \r\n      - Pressure fluctuation (e.g. power steering pump) \r\n      - Overcharged refrigerant (AC compressor)"
                                // 381
                                };

        private void PromenaJezika()
        {
            this.Text         = jezik[0];
            dugmeLevo.Text    = jezik[1];
            dugmeCentar.Text  = jezik[2];
            dugmeDesno.Text   = jezik[3];
            dugmeDodatno.Text = jezik[250];

            if (FormaUvod != null)       FormaUvod.PromenaJezika();

            if (FormaTestVoznja != null) FormaTestVoznja.PromenaJezika();

            if (FormaCentarGlavni != null) 
            {
                FormaCentarGlavni.PromenaJezika();
                if (FormaCentarGlavni.FormaCentarTabela != null) FormaCentarGlavni.FormaCentarTabela.PromenaJezika();
                if (FormaCentarGlavni.FormaCentarGrafik != null) FormaCentarGlavni.FormaCentarGrafik.PromenaJezika();
                if (FormaCentarGlavni.FormaCentarTekst != null)  FormaCentarGlavni.FormaCentarTekst.PromenaJezika();

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
            jezik[11]  = "Potvrdi podatke";
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
            jezik[66]  = "Potvrdi podatke"; // nekada je pisalo "izracunaj" ali ja sam promenio cisto da bude u skladu sa onim sto pise na FormaCentarGlavni
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
            jezik[125] = "Potvrdi podatke";
            jezik[126] = "Greška, nedovoljno polja popunjeno.";
            jezik[127] = "Greška, u nekom od polja je uneta nevažeća vrednost.";

            // Forma_Desni_Tabela
            jezik[128] = "PLACEHOLDERSTRING Forma_Desni_Tabela.Text";
            jezik[129] = "Brzina vozila";
            jezik[130] = "Frekvencije točka 1";
            jezik[131] = "Prvog reda";
            jezik[132] = "Drugog reda";
            jezik[133] = "Trećeg reda";
            jezik[134] = "Četvrtog reda";
            jezik[135] = "Frekvencije kardana 1";
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

            // jezik 2 elektrik bugalu

            // Forma_Desni_Glavni
            jezik[184] = "Dimenzije pneumatika na drugoj osovini su različite";
            jezik[185] = "Širina 2";
            jezik[186] = "Visina 2";
            jezik[187] = "Prečnik felne 2";
            jezik[188] = "mm";
            jezik[189] = "%";
            jezik[190] = "Inča";

            // Forma_TestVoznja
            jezik[191] = "PLACEHOLDERSTRING Forma_TestVoznja.Text";

            // Forma_Desni_Grafik
            jezik[192] = "Dimenzije 1";
            jezik[193] = "Dimenzije 2";
            jezik[194] = "FT";
            jezik[195] = "FT2";
            jezik[196] = "FT3";
            jezik[197] = "FT4";
            jezik[198] = "FK";
            jezik[199] = "FK2";
            jezik[200] = "FK3";
            jezik[201] = "FK4";

            // Forma_Desni_Tabela
            jezik[202] = "Frekvencije točka 2";
            jezik[203] = "Frekvencije kardana 2";

            // Forma_TestVoznja
            jezik[204] = "Pre-Road Test inspection";
            jezik[205] = "Road test";
            jezik[206] = "Pre-Road Test inspection \r\nCheck the tires for: \n      - Inflation pressure \r\n      - Proper tire type \r\n      - Verify the tires are uniform in size and brand \r\n      - Abnormal tire wear and correct thread depth \r\nCheck the wheels for: \r\n      - Mud, ice and debris \r\n      - Deformed or bent \r\n      - Missing wheel weights \r\n      - Log nuts tightening torque \r\nCheck the vehicle for: \r\n      - Signs of damaged components \r\n      - Signs of collision damage \r\n      - Added components \r\nNotes: \r\n      - It is important to know which specific concern the customer has with their vehicle \r\n       - Don't be misled by the reported location of the noise or vibration, cause may be in another area of vehicle \r\n      - The vibrating component may only generate a small vibration, but this small vibration may cause a larger vibration or noise. \r\n      - It must be possible to operate the vehicle at the speed in which the condition occurs. \r\n      - Prepare measuring equipment.";
            jezik[207] = "Back";
            jezik[208] = "Road test \r\nIn order to determine engine speed, vehicle speed and frequency of the NVH concern, as well to establish is it a engine \r\nor vehicle speed related vibrations, perform the test drive: ";

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

        public Boolean dugmeLevoEnabled
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

        private void dugmeDodatno_Click(object sender, EventArgs e)
        {
            FormaUvod = new Forma_Uvod(this);
            FormaUvod.Owner = this;
            FormaUvod.Show();

            dugmeDodatno.Enabled = false;
        }

        public Boolean dugmeDodatnoEnabled
        {
            get { return dugmeDodatno.Enabled;  }
            set { dugmeDodatno.Enabled = value; }
        }

        private void Forma_HomeScreen_Load(object sender, EventArgs e)
        {
            
        }
    }
}
