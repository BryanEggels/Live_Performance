namespace Live_performance
{
    partial class Bestellingform
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
            this.lb_standaardpizzas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_producten = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_bodem = new System.Windows.Forms.ListBox();
            this.btn_toevoegen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.num_oppervlakte = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_rond = new System.Windows.Forms.RadioButton();
            this.rb_driehoek = new System.Windows.Forms.RadioButton();
            this.rb_vierkant = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_ingredienten = new System.Windows.Forms.ListBox();
            this.lb_pizzabestelling = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_overigebestelling = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_pizzaAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_bestel = new System.Windows.Forms.Button();
            this.tb_naam = new System.Windows.Forms.TextBox();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_oppervlakte)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_standaardpizzas
            // 
            this.lb_standaardpizzas.FormattingEnabled = true;
            this.lb_standaardpizzas.Location = new System.Drawing.Point(12, 25);
            this.lb_standaardpizzas.Name = "lb_standaardpizzas";
            this.lb_standaardpizzas.Size = new System.Drawing.Size(120, 95);
            this.lb_standaardpizzas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Standaard Pizza\'s";
            // 
            // lb_producten
            // 
            this.lb_producten.FormattingEnabled = true;
            this.lb_producten.Location = new System.Drawing.Point(153, 25);
            this.lb_producten.Name = "lb_producten";
            this.lb_producten.Size = new System.Drawing.Size(120, 95);
            this.lb_producten.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Overige producten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Bodem:";
            // 
            // lb_bodem
            // 
            this.lb_bodem.FormattingEnabled = true;
            this.lb_bodem.Location = new System.Drawing.Point(59, 60);
            this.lb_bodem.Name = "lb_bodem";
            this.lb_bodem.Size = new System.Drawing.Size(133, 121);
            this.lb_bodem.TabIndex = 27;
            // 
            // btn_toevoegen
            // 
            this.btn_toevoegen.Location = new System.Drawing.Point(386, 203);
            this.btn_toevoegen.Name = "btn_toevoegen";
            this.btn_toevoegen.Size = new System.Drawing.Size(75, 23);
            this.btn_toevoegen.TabIndex = 24;
            this.btn_toevoegen.Text = "Toevoegen";
            this.btn_toevoegen.UseVisualStyleBackColor = true;
            this.btn_toevoegen.Click += new System.EventHandler(this.btn_toevoegen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Oppervlakte";
            // 
            // num_oppervlakte
            // 
            this.num_oppervlakte.Location = new System.Drawing.Point(417, 168);
            this.num_oppervlakte.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.num_oppervlakte.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.num_oppervlakte.Name = "num_oppervlakte";
            this.num_oppervlakte.Size = new System.Drawing.Size(44, 20);
            this.num_oppervlakte.TabIndex = 22;
            this.num_oppervlakte.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_rond);
            this.groupBox1.Controls.Add(this.rb_driehoek);
            this.groupBox1.Controls.Add(this.rb_vierkant);
            this.groupBox1.Location = new System.Drawing.Point(349, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vorm";
            // 
            // rb_rond
            // 
            this.rb_rond.AutoSize = true;
            this.rb_rond.Checked = true;
            this.rb_rond.Location = new System.Drawing.Point(17, 19);
            this.rb_rond.Name = "rb_rond";
            this.rb_rond.Size = new System.Drawing.Size(51, 17);
            this.rb_rond.TabIndex = 5;
            this.rb_rond.TabStop = true;
            this.rb_rond.Text = "Rond";
            this.rb_rond.UseVisualStyleBackColor = true;
            this.rb_rond.Click += new System.EventHandler(this.rb_rond_Click);
            // 
            // rb_driehoek
            // 
            this.rb_driehoek.AutoSize = true;
            this.rb_driehoek.Location = new System.Drawing.Point(17, 65);
            this.rb_driehoek.Name = "rb_driehoek";
            this.rb_driehoek.Size = new System.Drawing.Size(68, 17);
            this.rb_driehoek.TabIndex = 9;
            this.rb_driehoek.Text = "Driehoek";
            this.rb_driehoek.UseVisualStyleBackColor = true;
            this.rb_driehoek.Click += new System.EventHandler(this.rb_driehoek_Click);
            // 
            // rb_vierkant
            // 
            this.rb_vierkant.AutoSize = true;
            this.rb_vierkant.Location = new System.Drawing.Point(17, 42);
            this.rb_vierkant.Name = "rb_vierkant";
            this.rb_vierkant.Size = new System.Drawing.Size(64, 17);
            this.rb_vierkant.TabIndex = 8;
            this.rb_vierkant.Text = "Vierkant";
            this.rb_vierkant.UseVisualStyleBackColor = true;
            this.rb_vierkant.Click += new System.EventHandler(this.rb_vierkant_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ingrediënten:";
            // 
            // lb_ingredienten
            // 
            this.lb_ingredienten.FormattingEnabled = true;
            this.lb_ingredienten.Location = new System.Drawing.Point(198, 60);
            this.lb_ingredienten.Name = "lb_ingredienten";
            this.lb_ingredienten.Size = new System.Drawing.Size(128, 121);
            this.lb_ingredienten.TabIndex = 19;
            // 
            // lb_pizzabestelling
            // 
            this.lb_pizzabestelling.FormattingEnabled = true;
            this.lb_pizzabestelling.Items.AddRange(new object[] {
            "-"});
            this.lb_pizzabestelling.Location = new System.Drawing.Point(12, 228);
            this.lb_pizzabestelling.Name = "lb_pizzabestelling";
            this.lb_pizzabestelling.Size = new System.Drawing.Size(120, 95);
            this.lb_pizzabestelling.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Huidige bestelling:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Pizzas";
            // 
            // lb_overigebestelling
            // 
            this.lb_overigebestelling.FormattingEnabled = true;
            this.lb_overigebestelling.Items.AddRange(new object[] {
            "-"});
            this.lb_overigebestelling.Location = new System.Drawing.Point(153, 228);
            this.lb_overigebestelling.Name = "lb_overigebestelling";
            this.lb_overigebestelling.Size = new System.Drawing.Size(120, 95);
            this.lb_overigebestelling.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Overige producten";
            // 
            // btn_pizzaAdd
            // 
            this.btn_pizzaAdd.Location = new System.Drawing.Point(12, 127);
            this.btn_pizzaAdd.Name = "btn_pizzaAdd";
            this.btn_pizzaAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_pizzaAdd.TabIndex = 35;
            this.btn_pizzaAdd.Text = "Toevoegen";
            this.btn_pizzaAdd.UseVisualStyleBackColor = true;
            this.btn_pizzaAdd.Click += new System.EventHandler(this.btn_pizzaAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Toevoegen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lb_bodem);
            this.groupBox2.Controls.Add(this.lb_ingredienten);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.num_oppervlakte);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_toevoegen);
            this.groupBox2.Location = new System.Drawing.Point(279, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 235);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza samenstellen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Bodem";
            // 
            // btn_bestel
            // 
            this.btn_bestel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bestel.Location = new System.Drawing.Point(518, 276);
            this.btn_bestel.Name = "btn_bestel";
            this.btn_bestel.Size = new System.Drawing.Size(237, 50);
            this.btn_bestel.TabIndex = 38;
            this.btn_bestel.Text = "Bestellen";
            this.btn_bestel.UseVisualStyleBackColor = true;
            this.btn_bestel.Click += new System.EventHandler(this.btn_bestel_Click);
            // 
            // tb_naam
            // 
            this.tb_naam.Location = new System.Drawing.Point(371, 264);
            this.tb_naam.Name = "tb_naam";
            this.tb_naam.Size = new System.Drawing.Size(100, 20);
            this.tb_naam.TabIndex = 39;
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(371, 290);
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.Size = new System.Drawing.Size(100, 20);
            this.tb_adres.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Naam";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Adres";
            // 
            // Bestellingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 338);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_adres);
            this.Controls.Add(this.tb_naam);
            this.Controls.Add(this.btn_bestel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_pizzaAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_overigebestelling);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_pizzabestelling);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_producten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_standaardpizzas);
            this.Name = "Bestellingform";
            this.Text = "Bestellingform";
            this.Load += new System.EventHandler(this.Bestellingform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_oppervlakte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_standaardpizzas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_producten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_bodem;
        private System.Windows.Forms.Button btn_toevoegen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_oppervlakte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_rond;
        private System.Windows.Forms.RadioButton rb_driehoek;
        private System.Windows.Forms.RadioButton rb_vierkant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lb_ingredienten;
        private System.Windows.Forms.ListBox lb_pizzabestelling;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lb_overigebestelling;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_pizzaAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_bestel;
        private System.Windows.Forms.TextBox tb_naam;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}