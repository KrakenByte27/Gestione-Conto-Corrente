using Gestione_Calciatori.Classi;

namespace Gestione_Conto_Corrente
{
    public partial class homeForm : Form
    {
        private Cliente cliente1;

        public homeForm()
        {
            InitializeComponent();
        }

        #region Bottoni

        private void azzeraButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Sei sciuro di voler azzerare tutti i campi?",
                         "Attenzione",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Warning))
            {
                nomeTextBox.Texts = "";
                cognomeTextBox.Texts = "";
                indirizzoTextBox.Texts = "";
            }
        }

        private void aggiugniButton_Click(object sender, EventArgs e)
        {
            bool checkNome,
                checkCognome,
                checkIndirizzo;

            if (nomeTextBox.Texts == "")
            {
                nomeTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checkNome = false;
            }
            else checkNome = true;

            if (cognomeTextBox.Texts == "")
            {
                cognomeTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checkCognome = false;
            }
            else checkCognome = true;

            if (indirizzoTextBox.Texts == "")
            {
                indirizzoTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checkIndirizzo = false;
            }
            else checkIndirizzo = true;

            if(checkNome&&checkCognome&&checkIndirizzo)
            {
                cliente1 = new Cliente(nomeTextBox.Texts,
                                       cognomeTextBox.Texts,
                                       indirizzoTextBox.Texts);

                nomeTextBox.Enabled = false;
                cognomeTextBox.Enabled = false;
                indirizzoTextBox.Enabled = false;
                azzeraButton.Enabled = false;
                aggiugniButton.Enabled = false;

                importoTextBox.Enabled = true;
                versamentoButton.Enabled = true;
                prelievoButton.Enabled = true;
            }
        }

        private void versamentoButton_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(importoTextBox.Texts, out _) || importoTextBox.Texts == "")
            {
                importoTextBox.BackColor = Color.FromArgb(255, 159, 67);
            }
            else
            {
                cliente1.Saldo += (Convert.ToDecimal(importoTextBox.Texts));
                saldoLabel.Text = "Saldo: " + cliente1.Saldo.ToString() + "€";
            }
        }

        private void prelievoButton_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(importoTextBox.Texts, out _) || importoTextBox.Texts == "")
            {
                importoTextBox.BackColor = Color.FromArgb(255, 159, 67);
            }
            else
            {
                decimal bozza = cliente1.Saldo - (Convert.ToDecimal(importoTextBox.Texts));
                if (bozza < 0)
                {
                    MessageBox.Show("Non è possibile prelevare più del saldo disponibile",
                                    "Avviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    cliente1.Saldo -= (Convert.ToDecimal(importoTextBox.Texts));
                    saldoLabel.Text = "Saldo: " + cliente1.Saldo.ToString() + "€";
                }
            }
        }

        private void nuovoButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Sei sciuro di voler creare un nuovo cliente?\n" +
                "Tutti i dati verranno cancellati",
             "Attenzione",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning))
            {
                nomeTextBox.Texts = "";
                cognomeTextBox.Texts = "";
                indirizzoTextBox.Texts = "";
                importoTextBox.Texts = "";
                saldoLabel.Text = "Saldo: 0,00€";

                nomeTextBox.Enabled = true;
                cognomeTextBox.Enabled = true;
                indirizzoTextBox.Enabled = true;
                azzeraButton.Enabled = true;
                aggiugniButton.Enabled = true;

                importoTextBox.Enabled = false;
                versamentoButton.Enabled = false;
                prelievoButton.Enabled = false;
            }
        }

        private void esciButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Sei sciuro di voler uscire?",
                                     "Attenzione",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning))
                Application.Exit();
        }

        #endregion

        #region TextBox

        private void nomeTextBox__TextChanged(object sender, EventArgs e)
        {
            nomeTextBox.BackColor = Color.FromArgb(56, 79, 140);
        }

        private void cognomeTextBox__TextChanged(object sender, EventArgs e)
        {
            cognomeTextBox.BackColor = Color.FromArgb(56, 79, 140);
        }

        private void indirizzoTextBox__TextChanged(object sender, EventArgs e)
        {
            indirizzoTextBox.BackColor = Color.FromArgb(56, 79, 140);
        }

        private void importoTextBox__TextChanged(object sender, EventArgs e)
        {
            importoTextBox.BackColor = Color.FromArgb(56, 79, 140);
        }

        #endregion
    }
}