namespace Synthèse
{
    partial class Form1Synthèse
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1Nom = new System.Windows.Forms.TextBox();
            this.textBox2Capital = new System.Windows.Forms.TextBox();
            this.radioButton7PC = new System.Windows.Forms.RadioButton();
            this.radioButton8PC = new System.Windows.Forms.RadioButton();
            this.radioButton9PC = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1OK = new System.Windows.Forms.Button();
            this.button2Cancel = new System.Windows.Forms.Button();
            this.label1Nom = new System.Windows.Forms.Label();
            this.label2CapitalEmprunté = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1Duree = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1Periodicite = new System.Windows.Forms.Label();
            this.label1Rembours = new System.Windows.Forms.Label();
            this.label1MontantRemboursement = new System.Windows.Forms.Label();
            this.label1NbrRemb = new System.Windows.Forms.Label();
            this.DureeInt = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1Nom
            // 
            this.textBox1Nom.Location = new System.Drawing.Point(137, 37);
            this.textBox1Nom.Name = "textBox1Nom";
            this.textBox1Nom.Size = new System.Drawing.Size(100, 20);
            this.textBox1Nom.TabIndex = 0;
            // 
            // textBox2Capital
            // 
            this.textBox2Capital.Location = new System.Drawing.Point(137, 78);
            this.textBox2Capital.Name = "textBox2Capital";
            this.textBox2Capital.Size = new System.Drawing.Size(100, 20);
            this.textBox2Capital.TabIndex = 1;
            this.textBox2Capital.TextChanged += new System.EventHandler(this.textBox2Capital_TextChanged);
            this.textBox2Capital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2Capital_KeyPress);
            // 
            // radioButton7PC
            // 
            this.radioButton7PC.AutoSize = true;
            this.radioButton7PC.Location = new System.Drawing.Point(46, 43);
            this.radioButton7PC.Name = "radioButton7PC";
            this.radioButton7PC.Size = new System.Drawing.Size(39, 17);
            this.radioButton7PC.TabIndex = 2;
            this.radioButton7PC.TabStop = true;
            this.radioButton7PC.Tag = "7";
            this.radioButton7PC.Text = "7%";
            this.radioButton7PC.UseVisualStyleBackColor = true;
            this.radioButton7PC.CheckedChanged += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton8PC
            // 
            this.radioButton8PC.AutoSize = true;
            this.radioButton8PC.Location = new System.Drawing.Point(46, 77);
            this.radioButton8PC.Name = "radioButton8PC";
            this.radioButton8PC.Size = new System.Drawing.Size(39, 17);
            this.radioButton8PC.TabIndex = 3;
            this.radioButton8PC.TabStop = true;
            this.radioButton8PC.Tag = "8";
            this.radioButton8PC.Text = "8%";
            this.radioButton8PC.UseVisualStyleBackColor = true;
            this.radioButton8PC.CheckedChanged += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton9PC
            // 
            this.radioButton9PC.AutoSize = true;
            this.radioButton9PC.Location = new System.Drawing.Point(46, 111);
            this.radioButton9PC.Name = "radioButton9PC";
            this.radioButton9PC.Size = new System.Drawing.Size(39, 17);
            this.radioButton9PC.TabIndex = 4;
            this.radioButton9PC.TabStop = true;
            this.radioButton9PC.Tag = "9";
            this.radioButton9PC.Text = "9%";
            this.radioButton9PC.UseVisualStyleBackColor = true;
            this.radioButton9PC.CheckedChanged += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton7PC);
            this.groupBox1.Controls.Add(this.radioButton9PC);
            this.groupBox1.Controls.Add(this.radioButton8PC);
            this.groupBox1.Location = new System.Drawing.Point(318, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 159);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taux d\'intérêt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1OK
            // 
            this.button1OK.Location = new System.Drawing.Point(475, 37);
            this.button1OK.Name = "button1OK";
            this.button1OK.Size = new System.Drawing.Size(75, 23);
            this.button1OK.TabIndex = 6;
            this.button1OK.Text = "OK";
            this.button1OK.UseVisualStyleBackColor = true;
            this.button1OK.Click += new System.EventHandler(this.button1OK_Click);
            // 
            // button2Cancel
            // 
            this.button2Cancel.Location = new System.Drawing.Point(475, 71);
            this.button2Cancel.Name = "button2Cancel";
            this.button2Cancel.Size = new System.Drawing.Size(75, 23);
            this.button2Cancel.TabIndex = 7;
            this.button2Cancel.Text = "Annuler";
            this.button2Cancel.UseVisualStyleBackColor = true;
            this.button2Cancel.Click += new System.EventHandler(this.button2Cancel_Click);
            // 
            // label1Nom
            // 
            this.label1Nom.AutoSize = true;
            this.label1Nom.Location = new System.Drawing.Point(30, 37);
            this.label1Nom.Name = "label1Nom";
            this.label1Nom.Size = new System.Drawing.Size(78, 13);
            this.label1Nom.TabIndex = 8;
            this.label1Nom.Text = "Nom (facultatif)";
            // 
            // label2CapitalEmprunté
            // 
            this.label2CapitalEmprunté.AutoSize = true;
            this.label2CapitalEmprunté.Location = new System.Drawing.Point(30, 81);
            this.label2CapitalEmprunté.Name = "label2CapitalEmprunté";
            this.label2CapitalEmprunté.Size = new System.Drawing.Size(87, 13);
            this.label2CapitalEmprunté.TabIndex = 9;
            this.label2CapitalEmprunté.Text = "Capital Emprunté";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(180, 114);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(113, 17);
            this.hScrollBar1.TabIndex = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1Duree
            // 
            this.label1Duree.AutoSize = true;
            this.label1Duree.Location = new System.Drawing.Point(12, 118);
            this.label1Duree.Name = "label1Duree";
            this.label1Duree.Size = new System.Drawing.Size(165, 13);
            this.label1Duree.TabIndex = 11;
            this.label1Duree.Text = "Durée en mois du remboursement";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1Periodicite
            // 
            this.label1Periodicite.AutoSize = true;
            this.label1Periodicite.Location = new System.Drawing.Point(12, 174);
            this.label1Periodicite.Name = "label1Periodicite";
            this.label1Periodicite.Size = new System.Drawing.Size(146, 13);
            this.label1Periodicite.TabIndex = 13;
            this.label1Periodicite.Text = "Périodicité de remboursement";
            // 
            // label1Rembours
            // 
            this.label1Rembours.AutoSize = true;
            this.label1Rembours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Rembours.Location = new System.Drawing.Point(361, 215);
            this.label1Rembours.Name = "label1Rembours";
            this.label1Rembours.Size = new System.Drawing.Size(103, 13);
            this.label1Rembours.TabIndex = 14;
            this.label1Rembours.Text = "Remboursements";
            // 
            // label1MontantRemboursement
            // 
            this.label1MontantRemboursement.AutoSize = true;
            this.label1MontantRemboursement.Location = new System.Drawing.Point(399, 250);
            this.label1MontantRemboursement.Name = "label1MontantRemboursement";
            this.label1MontantRemboursement.Size = new System.Drawing.Size(0, 13);
            this.label1MontantRemboursement.TabIndex = 15;
            // 
            // label1NbrRemb
            // 
            this.label1NbrRemb.AutoSize = true;
            this.label1NbrRemb.Location = new System.Drawing.Point(315, 215);
            this.label1NbrRemb.Name = "label1NbrRemb";
            this.label1NbrRemb.Size = new System.Drawing.Size(0, 13);
            this.label1NbrRemb.TabIndex = 16;
            // 
            // DureeInt
            // 
            this.DureeInt.AutoSize = true;
            this.DureeInt.Location = new System.Drawing.Point(177, 131);
            this.DureeInt.Name = "DureeInt";
            this.DureeInt.Size = new System.Drawing.Size(0, 13);
            this.DureeInt.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1Synthèse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 301);
            this.Controls.Add(this.DureeInt);
            this.Controls.Add(this.label1NbrRemb);
            this.Controls.Add(this.label1MontantRemboursement);
            this.Controls.Add(this.label1Rembours);
            this.Controls.Add(this.label1Periodicite);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1Duree);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label2CapitalEmprunté);
            this.Controls.Add(this.label1Nom);
            this.Controls.Add(this.button2Cancel);
            this.Controls.Add(this.button1OK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2Capital);
            this.Controls.Add(this.textBox1Nom);
            this.Name = "Form1Synthèse";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Synthèse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Nom;
        private System.Windows.Forms.TextBox textBox2Capital;
        private System.Windows.Forms.RadioButton radioButton7PC;
        private System.Windows.Forms.RadioButton radioButton8PC;
        private System.Windows.Forms.RadioButton radioButton9PC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1OK;
        private System.Windows.Forms.Button button2Cancel;
        private System.Windows.Forms.Label label1Nom;
        private System.Windows.Forms.Label label2CapitalEmprunté;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1Duree;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1Periodicite;
        private System.Windows.Forms.Label label1Rembours;
        private System.Windows.Forms.Label label1MontantRemboursement;
        private System.Windows.Forms.Label label1NbrRemb;
        private System.Windows.Forms.Label DureeInt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

