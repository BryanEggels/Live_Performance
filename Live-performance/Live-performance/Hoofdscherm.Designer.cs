namespace Live_performance
{
    partial class Hoofdscherm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nieuwebestelling = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_toevoegen = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_editform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoofdscherm";
            // 
            // btn_nieuwebestelling
            // 
            this.btn_nieuwebestelling.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_nieuwebestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nieuwebestelling.Location = new System.Drawing.Point(1, 55);
            this.btn_nieuwebestelling.Name = "btn_nieuwebestelling";
            this.btn_nieuwebestelling.Size = new System.Drawing.Size(280, 78);
            this.btn_nieuwebestelling.TabIndex = 1;
            this.btn_nieuwebestelling.Text = "Nieuwe bestelling..";
            this.btn_nieuwebestelling.UseVisualStyleBackColor = false;
            this.btn_nieuwebestelling.Click += new System.EventHandler(this.btn_nieuwebestelling_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bestelhistorie";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_toevoegen
            // 
            this.btn_toevoegen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_toevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toevoegen.Location = new System.Drawing.Point(1, 223);
            this.btn_toevoegen.Name = "btn_toevoegen";
            this.btn_toevoegen.Size = new System.Drawing.Size(280, 78);
            this.btn_toevoegen.TabIndex = 3;
            this.btn_toevoegen.Text = "Toevoegen..";
            this.btn_toevoegen.UseVisualStyleBackColor = false;
            this.btn_toevoegen.Click += new System.EventHandler(this.btn_toevoegen_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 78);
            this.button4.TabIndex = 4;
            this.button4.Text = "Meest verkocht";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(280, 78);
            this.button5.TabIndex = 5;
            this.button5.Text = "Huidige bestellingen";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btn_editform
            // 
            this.btn_editform.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_editform.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editform.Location = new System.Drawing.Point(1, 475);
            this.btn_editform.Name = "btn_editform";
            this.btn_editform.Size = new System.Drawing.Size(280, 78);
            this.btn_editform.TabIndex = 6;
            this.btn_editform.Text = "Producten wijzigen / verwijderen";
            this.btn_editform.UseVisualStyleBackColor = false;
            this.btn_editform.Click += new System.EventHandler(this.btn_editform_Click);
            // 
            // Hoofdscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(282, 554);
            this.Controls.Add(this.btn_editform);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_toevoegen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_nieuwebestelling);
            this.Controls.Add(this.label1);
            this.Name = "Hoofdscherm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nieuwebestelling;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_toevoegen;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_editform;
    }
}

