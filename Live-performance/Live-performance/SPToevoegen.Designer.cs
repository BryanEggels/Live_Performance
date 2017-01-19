namespace Live_performance
{
    partial class SPToevoegen
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
            this.lb_ingredienten = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_rond = new System.Windows.Forms.RadioButton();
            this.rb_vierkant = new System.Windows.Forms.RadioButton();
            this.rb_driehoek = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_oppervlakte = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_toevoegen = new System.Windows.Forms.Button();
            this.tb_naam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_bodem = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_oppervlakte)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_ingredienten
            // 
            this.lb_ingredienten.FormattingEnabled = true;
            this.lb_ingredienten.Location = new System.Drawing.Point(148, 25);
            this.lb_ingredienten.Name = "lb_ingredienten";
            this.lb_ingredienten.Size = new System.Drawing.Size(128, 121);
            this.lb_ingredienten.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrediënten:";
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
            // rb_vierkant
            // 
            this.rb_vierkant.AutoSize = true;
            this.rb_vierkant.Location = new System.Drawing.Point(17, 42);
            this.rb_vierkant.Name = "rb_vierkant";
            this.rb_vierkant.Size = new System.Drawing.Size(64, 17);
            this.rb_vierkant.TabIndex = 8;
            this.rb_vierkant.Text = "Vierkant";
            this.rb_vierkant.UseVisualStyleBackColor = true;
            this.rb_vierkant.CheckedChanged += new System.EventHandler(this.rb_vierkant_CheckedChanged);
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
            this.rb_driehoek.CheckedChanged += new System.EventHandler(this.rb_driehoek_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_rond);
            this.groupBox1.Controls.Add(this.rb_driehoek);
            this.groupBox1.Controls.Add(this.rb_vierkant);
            this.groupBox1.Location = new System.Drawing.Point(299, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vorm";
            // 
            // num_oppervlakte
            // 
            this.num_oppervlakte.Location = new System.Drawing.Point(367, 133);
            this.num_oppervlakte.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.num_oppervlakte.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.num_oppervlakte.Name = "num_oppervlakte";
            this.num_oppervlakte.Size = new System.Drawing.Size(44, 20);
            this.num_oppervlakte.TabIndex = 12;
            this.num_oppervlakte.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Oppervlakte";
            // 
            // btn_toevoegen
            // 
            this.btn_toevoegen.Location = new System.Drawing.Point(316, 195);
            this.btn_toevoegen.Name = "btn_toevoegen";
            this.btn_toevoegen.Size = new System.Drawing.Size(75, 23);
            this.btn_toevoegen.TabIndex = 14;
            this.btn_toevoegen.Text = "Toevoegen";
            this.btn_toevoegen.UseVisualStyleBackColor = true;
            this.btn_toevoegen.Click += new System.EventHandler(this.btn_toevoegen_Click);
            // 
            // tb_naam
            // 
            this.tb_naam.Location = new System.Drawing.Point(29, 195);
            this.tb_naam.Name = "tb_naam";
            this.tb_naam.Size = new System.Drawing.Size(100, 20);
            this.tb_naam.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Naam pizza:";
            // 
            // lb_bodem
            // 
            this.lb_bodem.FormattingEnabled = true;
            this.lb_bodem.Location = new System.Drawing.Point(9, 25);
            this.lb_bodem.Name = "lb_bodem";
            this.lb_bodem.Size = new System.Drawing.Size(133, 121);
            this.lb_bodem.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bodem:";
            // 
            // SPToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 239);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_bodem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_naam);
            this.Controls.Add(this.btn_toevoegen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_oppervlakte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_ingredienten);
            this.Name = "SPToevoegen";
            this.Text = "SPToevoegen";
            this.Load += new System.EventHandler(this.SPToevoegen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_oppervlakte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lb_ingredienten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_rond;
        private System.Windows.Forms.RadioButton rb_vierkant;
        private System.Windows.Forms.RadioButton rb_driehoek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_oppervlakte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_toevoegen;
        private System.Windows.Forms.TextBox tb_naam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_bodem;
        private System.Windows.Forms.Label label4;
    }
}