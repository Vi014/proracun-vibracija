namespace Proracun_vibracija
{
    partial class Forma_Desni_Glavni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_Upozorenje = new System.Windows.Forms.Label();
            this.label_DimenzijePneumatika = new System.Windows.Forms.Label();
            this.label_Sirina = new System.Windows.Forms.Label();
            this.textBox_W = new System.Windows.Forms.TextBox();
            this.label_Visina = new System.Windows.Forms.Label();
            this.textBox_H = new System.Windows.Forms.TextBox();
            this.label_PrecnikFelne = new System.Windows.Forms.Label();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.label_POD = new System.Windows.Forms.Label();
            this.textBox_I = new System.Windows.Forms.TextBox();
            this.label_mm = new System.Windows.Forms.Label();
            this.label_Posto = new System.Windows.Forms.Label();
            this.label_Inches = new System.Windows.Forms.Label();
            this.label_IzmereneVrednosti = new System.Windows.Forms.Label();
            this.label_BrzinaVozila = new System.Windows.Forms.Label();
            this.textBox_V1 = new System.Windows.Forms.TextBox();
            this.textBox_V2 = new System.Windows.Forms.TextBox();
            this.textBox_V3 = new System.Windows.Forms.TextBox();
            this.label_Frekvencija = new System.Windows.Forms.Label();
            this.textBox_F11 = new System.Windows.Forms.TextBox();
            this.textBox_F21 = new System.Windows.Forms.TextBox();
            this.textBox_F31 = new System.Windows.Forms.TextBox();
            this.textBox_F12 = new System.Windows.Forms.TextBox();
            this.textBox_F22 = new System.Windows.Forms.TextBox();
            this.textBox_F32 = new System.Windows.Forms.TextBox();
            this.textBox_F13 = new System.Windows.Forms.TextBox();
            this.textBox_F23 = new System.Windows.Forms.TextBox();
            this.textBox_F33 = new System.Windows.Forms.TextBox();
            this.button_Racun = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_mm2 = new System.Windows.Forms.Label();
            this.label_Posto2 = new System.Windows.Forms.Label();
            this.label_Inches2 = new System.Windows.Forms.Label();
            this.label_Sirina2 = new System.Windows.Forms.Label();
            this.label_Visina2 = new System.Windows.Forms.Label();
            this.textBox_W2 = new System.Windows.Forms.TextBox();
            this.label_PrecnikFelne2 = new System.Windows.Forms.Label();
            this.textBox_H2 = new System.Windows.Forms.TextBox();
            this.textBox_R2 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_Grafik = new System.Windows.Forms.Button();
            this.button_Tabela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Upozorenje
            // 
            this.label_Upozorenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Upozorenje.ForeColor = System.Drawing.Color.Red;
            this.label_Upozorenje.Location = new System.Drawing.Point(183, 12);
            this.label_Upozorenje.Name = "label_Upozorenje";
            this.label_Upozorenje.Size = new System.Drawing.Size(439, 20);
            this.label_Upozorenje.TabIndex = 22;
            this.label_Upozorenje.Text = "Decimale se označavaju tačkom, ne zarezom.";
            this.label_Upozorenje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_DimenzijePneumatika
            // 
            this.label_DimenzijePneumatika.AutoSize = true;
            this.label_DimenzijePneumatika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DimenzijePneumatika.Location = new System.Drawing.Point(12, 9);
            this.label_DimenzijePneumatika.Name = "label_DimenzijePneumatika";
            this.label_DimenzijePneumatika.Size = new System.Drawing.Size(165, 20);
            this.label_DimenzijePneumatika.TabIndex = 22;
            this.label_DimenzijePneumatika.Text = "Dimenzije pneumatika";
            // 
            // label_Sirina
            // 
            this.label_Sirina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sirina.Location = new System.Drawing.Point(12, 44);
            this.label_Sirina.Name = "label_Sirina";
            this.label_Sirina.Size = new System.Drawing.Size(240, 20);
            this.label_Sirina.TabIndex = 22;
            this.label_Sirina.Text = "Širina";
            this.label_Sirina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_W
            // 
            this.textBox_W.Location = new System.Drawing.Point(258, 44);
            this.textBox_W.Name = "textBox_W";
            this.textBox_W.Size = new System.Drawing.Size(54, 20);
            this.textBox_W.TabIndex = 0;
            this.textBox_W.Enter += new System.EventHandler(this.textBox_W_Enter);
            this.textBox_W.Leave += new System.EventHandler(this.textBox_W_Leave);
            // 
            // label_Visina
            // 
            this.label_Visina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Visina.Location = new System.Drawing.Point(12, 70);
            this.label_Visina.Name = "label_Visina";
            this.label_Visina.Size = new System.Drawing.Size(240, 20);
            this.label_Visina.TabIndex = 22;
            this.label_Visina.Text = "Visina";
            this.label_Visina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_H
            // 
            this.textBox_H.Location = new System.Drawing.Point(258, 70);
            this.textBox_H.Name = "textBox_H";
            this.textBox_H.Size = new System.Drawing.Size(54, 20);
            this.textBox_H.TabIndex = 1;
            this.textBox_H.Enter += new System.EventHandler(this.textBox_H_Enter);
            this.textBox_H.Leave += new System.EventHandler(this.textBox_H_Leave);
            // 
            // label_PrecnikFelne
            // 
            this.label_PrecnikFelne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PrecnikFelne.Location = new System.Drawing.Point(12, 96);
            this.label_PrecnikFelne.Name = "label_PrecnikFelne";
            this.label_PrecnikFelne.Size = new System.Drawing.Size(240, 20);
            this.label_PrecnikFelne.TabIndex = 22;
            this.label_PrecnikFelne.Text = "Prečnik felne";
            this.label_PrecnikFelne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_R
            // 
            this.textBox_R.Location = new System.Drawing.Point(258, 96);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(54, 20);
            this.textBox_R.TabIndex = 2;
            this.textBox_R.Enter += new System.EventHandler(this.textBox_R_Enter);
            this.textBox_R.Leave += new System.EventHandler(this.textBox_R_Leave);
            // 
            // label_POD
            // 
            this.label_POD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_POD.Location = new System.Drawing.Point(12, 150);
            this.label_POD.Name = "label_POD";
            this.label_POD.Size = new System.Drawing.Size(240, 20);
            this.label_POD.TabIndex = 22;
            this.label_POD.Text = "Prenosni odnos diferencijala";
            this.label_POD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_I
            // 
            this.textBox_I.Location = new System.Drawing.Point(258, 150);
            this.textBox_I.Name = "textBox_I";
            this.textBox_I.Size = new System.Drawing.Size(54, 20);
            this.textBox_I.TabIndex = 3;
            this.textBox_I.Enter += new System.EventHandler(this.textBox_I_Enter);
            this.textBox_I.Leave += new System.EventHandler(this.textBox_I_Leave);
            // 
            // label_mm
            // 
            this.label_mm.AutoSize = true;
            this.label_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mm.Location = new System.Drawing.Point(318, 44);
            this.label_mm.Name = "label_mm";
            this.label_mm.Size = new System.Drawing.Size(35, 20);
            this.label_mm.TabIndex = 22;
            this.label_mm.Text = "mm";
            // 
            // label_Posto
            // 
            this.label_Posto.AutoSize = true;
            this.label_Posto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Posto.Location = new System.Drawing.Point(318, 70);
            this.label_Posto.Name = "label_Posto";
            this.label_Posto.Size = new System.Drawing.Size(23, 20);
            this.label_Posto.TabIndex = 22;
            this.label_Posto.Text = "%";
            // 
            // label_Inches
            // 
            this.label_Inches.AutoSize = true;
            this.label_Inches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Inches.Location = new System.Drawing.Point(318, 96);
            this.label_Inches.Name = "label_Inches";
            this.label_Inches.Size = new System.Drawing.Size(40, 20);
            this.label_Inches.TabIndex = 22;
            this.label_Inches.Text = "Inča";
            // 
            // label_IzmereneVrednosti
            // 
            this.label_IzmereneVrednosti.AutoSize = true;
            this.label_IzmereneVrednosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IzmereneVrednosti.Location = new System.Drawing.Point(12, 179);
            this.label_IzmereneVrednosti.Name = "label_IzmereneVrednosti";
            this.label_IzmereneVrednosti.Size = new System.Drawing.Size(144, 20);
            this.label_IzmereneVrednosti.TabIndex = 22;
            this.label_IzmereneVrednosti.Text = "Izmerene vrednosti";
            // 
            // label_BrzinaVozila
            // 
            this.label_BrzinaVozila.AutoSize = true;
            this.label_BrzinaVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BrzinaVozila.Location = new System.Drawing.Point(12, 214);
            this.label_BrzinaVozila.Name = "label_BrzinaVozila";
            this.label_BrzinaVozila.Size = new System.Drawing.Size(145, 20);
            this.label_BrzinaVozila.TabIndex = 22;
            this.label_BrzinaVozila.Text = "Brzina vozila (km/h)";
            // 
            // textBox_V1
            // 
            this.textBox_V1.Location = new System.Drawing.Point(16, 237);
            this.textBox_V1.Name = "textBox_V1";
            this.textBox_V1.Size = new System.Drawing.Size(54, 20);
            this.textBox_V1.TabIndex = 7;
            this.textBox_V1.Enter += new System.EventHandler(this.textBox_V1_Enter);
            this.textBox_V1.Leave += new System.EventHandler(this.textBox_V1_Leave);
            // 
            // textBox_V2
            // 
            this.textBox_V2.Location = new System.Drawing.Point(16, 263);
            this.textBox_V2.Name = "textBox_V2";
            this.textBox_V2.Size = new System.Drawing.Size(54, 20);
            this.textBox_V2.TabIndex = 11;
            this.textBox_V2.Enter += new System.EventHandler(this.textBox_V2_Enter);
            this.textBox_V2.Leave += new System.EventHandler(this.textBox_V2_Leave);
            // 
            // textBox_V3
            // 
            this.textBox_V3.Location = new System.Drawing.Point(16, 289);
            this.textBox_V3.Name = "textBox_V3";
            this.textBox_V3.Size = new System.Drawing.Size(54, 20);
            this.textBox_V3.TabIndex = 15;
            this.textBox_V3.Enter += new System.EventHandler(this.textBox_V3_Enter);
            this.textBox_V3.Leave += new System.EventHandler(this.textBox_V3_Leave);
            // 
            // label_Frekvencija
            // 
            this.label_Frekvencija.AutoSize = true;
            this.label_Frekvencija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Frekvencija.Location = new System.Drawing.Point(233, 214);
            this.label_Frekvencija.Name = "label_Frekvencija";
            this.label_Frekvencija.Size = new System.Drawing.Size(89, 20);
            this.label_Frekvencija.TabIndex = 22;
            this.label_Frekvencija.Text = "Frekvencija";
            // 
            // textBox_F11
            // 
            this.textBox_F11.Location = new System.Drawing.Point(237, 237);
            this.textBox_F11.Name = "textBox_F11";
            this.textBox_F11.Size = new System.Drawing.Size(54, 20);
            this.textBox_F11.TabIndex = 8;
            this.textBox_F11.Enter += new System.EventHandler(this.textBox_F11_Enter);
            this.textBox_F11.Leave += new System.EventHandler(this.textBox_F11_Leave);
            // 
            // textBox_F21
            // 
            this.textBox_F21.Location = new System.Drawing.Point(237, 263);
            this.textBox_F21.Name = "textBox_F21";
            this.textBox_F21.Size = new System.Drawing.Size(54, 20);
            this.textBox_F21.TabIndex = 12;
            this.textBox_F21.Enter += new System.EventHandler(this.textBox_F21_Enter);
            this.textBox_F21.Leave += new System.EventHandler(this.textBox_F21_Leave);
            // 
            // textBox_F31
            // 
            this.textBox_F31.Location = new System.Drawing.Point(237, 289);
            this.textBox_F31.Name = "textBox_F31";
            this.textBox_F31.Size = new System.Drawing.Size(54, 20);
            this.textBox_F31.TabIndex = 16;
            this.textBox_F31.Enter += new System.EventHandler(this.textBox_F31_Enter);
            this.textBox_F31.Leave += new System.EventHandler(this.textBox_F31_Leave);
            // 
            // textBox_F12
            // 
            this.textBox_F12.Location = new System.Drawing.Point(311, 237);
            this.textBox_F12.Name = "textBox_F12";
            this.textBox_F12.Size = new System.Drawing.Size(54, 20);
            this.textBox_F12.TabIndex = 9;
            this.textBox_F12.Enter += new System.EventHandler(this.textBox_F12_Enter);
            this.textBox_F12.Leave += new System.EventHandler(this.textBox_F12_Leave);
            // 
            // textBox_F22
            // 
            this.textBox_F22.Location = new System.Drawing.Point(311, 263);
            this.textBox_F22.Name = "textBox_F22";
            this.textBox_F22.Size = new System.Drawing.Size(54, 20);
            this.textBox_F22.TabIndex = 13;
            this.textBox_F22.Enter += new System.EventHandler(this.textBox_F22_Enter);
            this.textBox_F22.Leave += new System.EventHandler(this.textBox_F22_Leave);
            // 
            // textBox_F32
            // 
            this.textBox_F32.Location = new System.Drawing.Point(311, 289);
            this.textBox_F32.Name = "textBox_F32";
            this.textBox_F32.Size = new System.Drawing.Size(54, 20);
            this.textBox_F32.TabIndex = 17;
            this.textBox_F32.Enter += new System.EventHandler(this.textBox_F32_Enter);
            this.textBox_F32.Leave += new System.EventHandler(this.textBox_F32_Leave);
            // 
            // textBox_F13
            // 
            this.textBox_F13.Location = new System.Drawing.Point(385, 237);
            this.textBox_F13.Name = "textBox_F13";
            this.textBox_F13.Size = new System.Drawing.Size(54, 20);
            this.textBox_F13.TabIndex = 10;
            this.textBox_F13.Enter += new System.EventHandler(this.textBox_F13_Enter);
            this.textBox_F13.Leave += new System.EventHandler(this.textBox_F13_Leave);
            // 
            // textBox_F23
            // 
            this.textBox_F23.Location = new System.Drawing.Point(385, 263);
            this.textBox_F23.Name = "textBox_F23";
            this.textBox_F23.Size = new System.Drawing.Size(54, 20);
            this.textBox_F23.TabIndex = 14;
            this.textBox_F23.Enter += new System.EventHandler(this.textBox_F23_Enter);
            this.textBox_F23.Leave += new System.EventHandler(this.textBox_F23_Leave);
            // 
            // textBox_F33
            // 
            this.textBox_F33.Location = new System.Drawing.Point(385, 289);
            this.textBox_F33.Name = "textBox_F33";
            this.textBox_F33.Size = new System.Drawing.Size(54, 20);
            this.textBox_F33.TabIndex = 18;
            this.textBox_F33.Enter += new System.EventHandler(this.textBox_F33_Enter);
            this.textBox_F33.Leave += new System.EventHandler(this.textBox_F33_Leave);
            // 
            // button_Racun
            // 
            this.button_Racun.Location = new System.Drawing.Point(482, 150);
            this.button_Racun.Name = "button_Racun";
            this.button_Racun.Size = new System.Drawing.Size(151, 84);
            this.button_Racun.TabIndex = 19;
            this.button_Racun.Text = "Potvrdi podatke";
            this.button_Racun.UseVisualStyleBackColor = true;
            this.button_Racun.Click += new System.EventHandler(this.button_Racun_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(48, 124);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(264, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Dimenzije pneumatika na drugoj osovini su različite";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label_mm2
            // 
            this.label_mm2.AutoSize = true;
            this.label_mm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mm2.Location = new System.Drawing.Point(582, 44);
            this.label_mm2.Name = "label_mm2";
            this.label_mm2.Size = new System.Drawing.Size(35, 20);
            this.label_mm2.TabIndex = 22;
            this.label_mm2.Text = "mm";
            this.label_mm2.Visible = false;
            // 
            // label_Posto2
            // 
            this.label_Posto2.AutoSize = true;
            this.label_Posto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Posto2.Location = new System.Drawing.Point(582, 70);
            this.label_Posto2.Name = "label_Posto2";
            this.label_Posto2.Size = new System.Drawing.Size(23, 20);
            this.label_Posto2.TabIndex = 22;
            this.label_Posto2.Text = "%";
            this.label_Posto2.Visible = false;
            // 
            // label_Inches2
            // 
            this.label_Inches2.AutoSize = true;
            this.label_Inches2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Inches2.Location = new System.Drawing.Point(582, 96);
            this.label_Inches2.Name = "label_Inches2";
            this.label_Inches2.Size = new System.Drawing.Size(40, 20);
            this.label_Inches2.TabIndex = 22;
            this.label_Inches2.Text = "Inča";
            this.label_Inches2.Visible = false;
            // 
            // label_Sirina2
            // 
            this.label_Sirina2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sirina2.Location = new System.Drawing.Point(366, 44);
            this.label_Sirina2.Name = "label_Sirina2";
            this.label_Sirina2.Size = new System.Drawing.Size(150, 20);
            this.label_Sirina2.TabIndex = 22;
            this.label_Sirina2.Text = "Širina 2";
            this.label_Sirina2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Sirina2.Visible = false;
            // 
            // label_Visina2
            // 
            this.label_Visina2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Visina2.Location = new System.Drawing.Point(366, 70);
            this.label_Visina2.Name = "label_Visina2";
            this.label_Visina2.Size = new System.Drawing.Size(150, 20);
            this.label_Visina2.TabIndex = 22;
            this.label_Visina2.Text = "Visina 2";
            this.label_Visina2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Visina2.Visible = false;
            // 
            // textBox_W2
            // 
            this.textBox_W2.Location = new System.Drawing.Point(522, 44);
            this.textBox_W2.Name = "textBox_W2";
            this.textBox_W2.Size = new System.Drawing.Size(54, 20);
            this.textBox_W2.TabIndex = 3;
            this.textBox_W2.Visible = false;
            this.textBox_W2.Enter += new System.EventHandler(this.textBox_W2_Enter);
            this.textBox_W2.Leave += new System.EventHandler(this.textBox_W2_Leave);
            // 
            // label_PrecnikFelne2
            // 
            this.label_PrecnikFelne2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PrecnikFelne2.Location = new System.Drawing.Point(366, 96);
            this.label_PrecnikFelne2.Name = "label_PrecnikFelne2";
            this.label_PrecnikFelne2.Size = new System.Drawing.Size(150, 20);
            this.label_PrecnikFelne2.TabIndex = 22;
            this.label_PrecnikFelne2.Text = "Prečnik felne 2";
            this.label_PrecnikFelne2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_PrecnikFelne2.Visible = false;
            // 
            // textBox_H2
            // 
            this.textBox_H2.Location = new System.Drawing.Point(522, 70);
            this.textBox_H2.Name = "textBox_H2";
            this.textBox_H2.Size = new System.Drawing.Size(54, 20);
            this.textBox_H2.TabIndex = 4;
            this.textBox_H2.Visible = false;
            this.textBox_H2.Enter += new System.EventHandler(this.textBox_H2_Enter);
            this.textBox_H2.Leave += new System.EventHandler(this.textBox_H2_Leave);
            // 
            // textBox_R2
            // 
            this.textBox_R2.Location = new System.Drawing.Point(522, 96);
            this.textBox_R2.Name = "textBox_R2";
            this.textBox_R2.Size = new System.Drawing.Size(54, 20);
            this.textBox_R2.TabIndex = 5;
            this.textBox_R2.Visible = false;
            this.textBox_R2.Enter += new System.EventHandler(this.textBox_R2_Enter);
            this.textBox_R2.Leave += new System.EventHandler(this.textBox_R2_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button_Grafik
            // 
            this.button_Grafik.BackgroundImage = global::Proracun_vibracija.Properties.Resources.graph;
            this.button_Grafik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Grafik.Enabled = false;
            this.button_Grafik.Location = new System.Drawing.Point(564, 240);
            this.button_Grafik.Name = "button_Grafik";
            this.button_Grafik.Size = new System.Drawing.Size(69, 69);
            this.button_Grafik.TabIndex = 21;
            this.button_Grafik.UseVisualStyleBackColor = true;
            this.button_Grafik.Click += new System.EventHandler(this.button_Grafik_Click);
            // 
            // button_Tabela
            // 
            this.button_Tabela.BackgroundImage = global::Proracun_vibracija.Properties.Resources.tabela;
            this.button_Tabela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Tabela.Enabled = false;
            this.button_Tabela.Location = new System.Drawing.Point(482, 240);
            this.button_Tabela.Name = "button_Tabela";
            this.button_Tabela.Size = new System.Drawing.Size(69, 69);
            this.button_Tabela.TabIndex = 20;
            this.button_Tabela.UseVisualStyleBackColor = true;
            this.button_Tabela.Click += new System.EventHandler(this.button_Tabela_Click);
            // 
            // Forma_Desni_Glavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 317);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_Racun);
            this.Controls.Add(this.button_Grafik);
            this.Controls.Add(this.button_Tabela);
            this.Controls.Add(this.textBox_F33);
            this.Controls.Add(this.textBox_F32);
            this.Controls.Add(this.textBox_F31);
            this.Controls.Add(this.textBox_V3);
            this.Controls.Add(this.textBox_F23);
            this.Controls.Add(this.textBox_F22);
            this.Controls.Add(this.textBox_F21);
            this.Controls.Add(this.textBox_V2);
            this.Controls.Add(this.textBox_F13);
            this.Controls.Add(this.textBox_F12);
            this.Controls.Add(this.textBox_F11);
            this.Controls.Add(this.textBox_V1);
            this.Controls.Add(this.textBox_I);
            this.Controls.Add(this.textBox_R2);
            this.Controls.Add(this.textBox_R);
            this.Controls.Add(this.label_POD);
            this.Controls.Add(this.textBox_H2);
            this.Controls.Add(this.label_PrecnikFelne2);
            this.Controls.Add(this.textBox_H);
            this.Controls.Add(this.textBox_W2);
            this.Controls.Add(this.label_PrecnikFelne);
            this.Controls.Add(this.label_Visina2);
            this.Controls.Add(this.textBox_W);
            this.Controls.Add(this.label_Visina);
            this.Controls.Add(this.label_Sirina2);
            this.Controls.Add(this.label_Upozorenje);
            this.Controls.Add(this.label_Inches2);
            this.Controls.Add(this.label_Sirina);
            this.Controls.Add(this.label_Posto2);
            this.Controls.Add(this.label_Inches);
            this.Controls.Add(this.label_mm2);
            this.Controls.Add(this.label_Posto);
            this.Controls.Add(this.label_mm);
            this.Controls.Add(this.label_Frekvencija);
            this.Controls.Add(this.label_BrzinaVozila);
            this.Controls.Add(this.label_IzmereneVrednosti);
            this.Controls.Add(this.label_DimenzijePneumatika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Forma_Desni_Glavni";
            this.Text = "~";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Forma_Desni_Glavni_FormClosed);
            this.Load += new System.EventHandler(this.Forma_Desni_Glavni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Upozorenje;
        private System.Windows.Forms.Label label_DimenzijePneumatika;
        private System.Windows.Forms.Label label_Sirina;
        private System.Windows.Forms.TextBox textBox_W;
        private System.Windows.Forms.Label label_Visina;
        private System.Windows.Forms.TextBox textBox_H;
        private System.Windows.Forms.Label label_PrecnikFelne;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.Label label_POD;
        private System.Windows.Forms.TextBox textBox_I;
        private System.Windows.Forms.Label label_mm;
        private System.Windows.Forms.Label label_Posto;
        private System.Windows.Forms.Label label_Inches;
        private System.Windows.Forms.Label label_IzmereneVrednosti;
        private System.Windows.Forms.Label label_BrzinaVozila;
        private System.Windows.Forms.TextBox textBox_V1;
        private System.Windows.Forms.TextBox textBox_V2;
        private System.Windows.Forms.TextBox textBox_V3;
        private System.Windows.Forms.Label label_Frekvencija;
        private System.Windows.Forms.TextBox textBox_F11;
        private System.Windows.Forms.TextBox textBox_F21;
        private System.Windows.Forms.TextBox textBox_F31;
        private System.Windows.Forms.TextBox textBox_F12;
        private System.Windows.Forms.TextBox textBox_F22;
        private System.Windows.Forms.TextBox textBox_F32;
        private System.Windows.Forms.TextBox textBox_F13;
        private System.Windows.Forms.TextBox textBox_F23;
        private System.Windows.Forms.TextBox textBox_F33;
        private System.Windows.Forms.Button button_Racun;
        private System.Windows.Forms.Button button_Grafik;
        private System.Windows.Forms.Button button_Tabela;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_mm2;
        private System.Windows.Forms.Label label_Posto2;
        private System.Windows.Forms.Label label_Inches2;
        private System.Windows.Forms.Label label_Sirina2;
        private System.Windows.Forms.Label label_Visina2;
        private System.Windows.Forms.TextBox textBox_W2;
        private System.Windows.Forms.Label label_PrecnikFelne2;
        private System.Windows.Forms.TextBox textBox_H2;
        private System.Windows.Forms.TextBox textBox_R2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}