namespace Live_performance
{
    partial class Producten_edit
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
            this.lb_producten = new System.Windows.Forms.ListBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tb_naam = new System.Windows.Forms.TextBox();
            this.tb_inkoop = new System.Windows.Forms.TextBox();
            this.tb_verkoop = new System.Windows.Forms.TextBox();
            this.tb_btw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_ingredient = new System.Windows.Forms.CheckBox();
            this.cb_vega = new System.Windows.Forms.CheckBox();
            this.cb_halal = new System.Windows.Forms.CheckBox();
            this.cb_drank = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_producten
            // 
            this.lb_producten.FormattingEnabled = true;
            this.lb_producten.Location = new System.Drawing.Point(13, 13);
            this.lb_producten.Name = "lb_producten";
            this.lb_producten.Size = new System.Drawing.Size(120, 95);
            this.lb_producten.TabIndex = 0;
            this.lb_producten.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(388, 130);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tb_naam
            // 
            this.tb_naam.Location = new System.Drawing.Point(209, 12);
            this.tb_naam.Name = "tb_naam";
            this.tb_naam.Size = new System.Drawing.Size(100, 20);
            this.tb_naam.TabIndex = 3;
            // 
            // tb_inkoop
            // 
            this.tb_inkoop.Location = new System.Drawing.Point(209, 39);
            this.tb_inkoop.Name = "tb_inkoop";
            this.tb_inkoop.Size = new System.Drawing.Size(100, 20);
            this.tb_inkoop.TabIndex = 4;
            // 
            // tb_verkoop
            // 
            this.tb_verkoop.Location = new System.Drawing.Point(209, 66);
            this.tb_verkoop.Name = "tb_verkoop";
            this.tb_verkoop.Size = new System.Drawing.Size(100, 20);
            this.tb_verkoop.TabIndex = 5;
            // 
            // tb_btw
            // 
            this.tb_btw.Location = new System.Drawing.Point(209, 92);
            this.tb_btw.Name = "tb_btw";
            this.tb_btw.Size = new System.Drawing.Size(100, 20);
            this.tb_btw.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Inkoopprijs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Verkoopprijs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "BTW";
            // 
            // cb_ingredient
            // 
            this.cb_ingredient.AutoSize = true;
            this.cb_ingredient.Location = new System.Drawing.Point(388, 41);
            this.cb_ingredient.Name = "cb_ingredient";
            this.cb_ingredient.Size = new System.Drawing.Size(100, 17);
            this.cb_ingredient.TabIndex = 18;
            this.cb_ingredient.Text = "Pizza ingrediënt";
            this.cb_ingredient.UseVisualStyleBackColor = true;
            // 
            // cb_vega
            // 
            this.cb_vega.AutoSize = true;
            this.cb_vega.Location = new System.Drawing.Point(388, 69);
            this.cb_vega.Name = "cb_vega";
            this.cb_vega.Size = new System.Drawing.Size(86, 17);
            this.cb_vega.TabIndex = 20;
            this.cb_vega.Text = "Veganistisch";
            this.cb_vega.UseVisualStyleBackColor = true;
            // 
            // cb_halal
            // 
            this.cb_halal.AutoSize = true;
            this.cb_halal.Location = new System.Drawing.Point(388, 95);
            this.cb_halal.Name = "cb_halal";
            this.cb_halal.Size = new System.Drawing.Size(50, 17);
            this.cb_halal.TabIndex = 21;
            this.cb_halal.Text = "Halal";
            this.cb_halal.UseVisualStyleBackColor = true;
            // 
            // cb_drank
            // 
            this.cb_drank.AutoSize = true;
            this.cb_drank.Location = new System.Drawing.Point(388, 11);
            this.cb_drank.Name = "cb_drank";
            this.cb_drank.Size = new System.Drawing.Size(55, 17);
            this.cb_drank.TabIndex = 22;
            this.cb_drank.Text = "Drank";
            this.cb_drank.UseVisualStyleBackColor = true;
            // 
            // Producten_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 174);
            this.Controls.Add(this.cb_drank);
            this.Controls.Add(this.cb_halal);
            this.Controls.Add(this.cb_vega);
            this.Controls.Add(this.cb_ingredient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_btw);
            this.Controls.Add(this.tb_verkoop);
            this.Controls.Add(this.tb_inkoop);
            this.Controls.Add(this.tb_naam);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lb_producten);
            this.Name = "Producten_edit";
            this.Text = "Producten_edit";
            this.Load += new System.EventHandler(this.Producten_edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_producten;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox tb_naam;
        private System.Windows.Forms.TextBox tb_inkoop;
        private System.Windows.Forms.TextBox tb_verkoop;
        private System.Windows.Forms.TextBox tb_btw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_ingredient;
        private System.Windows.Forms.CheckBox cb_vega;
        private System.Windows.Forms.CheckBox cb_halal;
        private System.Windows.Forms.CheckBox cb_drank;
    }
}