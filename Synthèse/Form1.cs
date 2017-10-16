using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synthèse
{
    public partial class Form1Synthèse : Form
    {
        double tauxInterets;
        int K;
        int n;
        double montant;
        public Form1Synthèse()
        {
            InitializeComponent();
        }

        private void Form1Synthèse_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Mensuelle");
            comboBox1.Items.Add("Bimestrielle");
            comboBox1.Items.Add("Trimestrielle");
            comboBox1.Items.Add("Semestrielle");
            comboBox1.Items.Add("Annuelle");
            radioButton7PC.Checked = true;
            hScrollBar1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = string.Empty;
            hScrollBar1.Enabled = true;
            if (comboBox1.SelectedItem.ToString() == "Annuelle")
            {
                hScrollBar1.SmallChange = 12;
                hScrollBar1.LargeChange = 24;
                hScrollBar1.Value = 0;
            }
            else if (comboBox1.SelectedItem.ToString() == "Mensuelle")
            {
                hScrollBar1.SmallChange = 1;
                hScrollBar1.LargeChange = 2;
                hScrollBar1.Value = 0;
            }
            else if (comboBox1.SelectedItem.ToString() == "Bimestrielle")
            {
                hScrollBar1.SmallChange = 2;
                hScrollBar1.LargeChange = 4;
                hScrollBar1.Value = 0;
            }
            else if (comboBox1.SelectedItem.ToString() == "Trimestrielle")
            {
                hScrollBar1.SmallChange = 3;
                hScrollBar1.LargeChange = 6;
                hScrollBar1.Value = 0;
            }
            else if (comboBox1.SelectedItem.ToString() == "Semestrielle")
            {
                hScrollBar1.SmallChange = 6;
                hScrollBar1.LargeChange = 12;
                hScrollBar1.Value = 0;
            }
            DureeInt.ResetText();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            RadioButton radioButton = sender as RadioButton;

            if (radioButton.Tag != null)
            {
                if (radioButton.Tag.ToString() == "7")
                    tauxInterets = 0.07;
                else if (radioButton.Tag.ToString() == "8")
                    tauxInterets = 0.08;
                else if (radioButton.Tag.ToString() == "9")
                    tauxInterets = 0.09;
            }
            else
                errorProvider1.SetError(groupBox1, "Veuillez saisir un champ");
        }

        private void textBox2Capital_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2Capital_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 200;
            n = hScrollBar1.Value;
            DureeInt.Text = n.ToString();
        }

        private void button1OK_Click(object sender, EventArgs e)
        {
            if (
                (textBox2Capital.Text != string.Empty)
                && (comboBox1.Text != null)
                && (hScrollBar1.Value != 0)
                )
            {
                K = Convert.ToInt32(textBox2Capital.Text);
                if (comboBox1.SelectedItem.ToString() == "Annuelle")
                {
                    n = n / 12;
                    montant = K * (tauxInterets / (1 - (Math.Pow(1 + tauxInterets, -n))));
                }
                else if (comboBox1.SelectedItem.ToString() == "Mensuelle")
                {
                    tauxInterets = tauxInterets / 12;
                    montant = K * (tauxInterets / (1 - (Math.Pow(1 + tauxInterets, -n))));
                }
                else if (comboBox1.SelectedItem.ToString() == "Bimestrielle")
                {
                    n = n / 2;
                    tauxInterets = tauxInterets / 6;
                    montant = K * (tauxInterets / (1 - (Math.Pow(1 + tauxInterets, -n))));
                }
                else if (comboBox1.SelectedItem.ToString() == "Trimestrielle")
                {
                    n = n / 3;
                    tauxInterets = tauxInterets / 4;
                    montant = K * (tauxInterets / (1 - (Math.Pow(1 + tauxInterets, -n))));
                }
                else if (comboBox1.SelectedItem.ToString() == "Semestrielle")
                {
                    n = n / 6;
                    tauxInterets = tauxInterets / 2;
                    montant = K * (tauxInterets / (1 - (Math.Pow(1 + tauxInterets, -n))));
                }
                label1MontantRemboursement.Text = montant.ToString();
                label1NbrRemb.Text = n.ToString();
            }
            else
                errorProvider1.SetError(button1OK, "Veuillez remplir tous les champs demandés");
        }

        private void button2Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
