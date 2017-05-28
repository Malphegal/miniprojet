﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMD = System.Data.OleDb.OleDbCommand;
using CON = System.Data.OleDb.OleDbConnection;

namespace miniProjet2017
{
    public partial class frmModiTransac : Form
    {
        public frmModiTransac()
        {
            InitializeComponent();
            Scale(new SizeF(frmMain.resolutionScale, frmMain.resolutionScale));
            frmMain.RedimensionnerLesControls(this, frmMain.resolutionScale);
        }

        /* Affiche ou retire l'aide du formulaire */
        private void CliquerSurAideModif(object sender, EventArgs e)
        {
            new Classes.Aide().AideTransac(this);
        }

        // TODO: Si il n'y a pas de transaction dans la table, MessageBox.Show ?
        /* Création de la table Transaction en local */
        private void LancementDuFormulaire(object sender, EventArgs e)
        {
                // Remplir la table locale

            CON con = new CON("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget1.mdb");
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(new CMD("SELECT * FROM [Transaction]", con));
            DataSet ds = new DataSet();
            da.Fill(ds, "_Transaction");

                // Affichage de la première transaction, si il y en a une
            
            if (ds.Tables["_Transaction"].Rows.Count > 0)
            {
                string[] date = ds.Tables["_Transaction"].Rows[0][1].ToString().Split('/');
                calTransac.SelectionStart = new DateTime(int.Parse(date[2].Substring(0, 4)), int.Parse(date[1]), int.Parse(date[0]));

                txtDescTran.Text = ds.Tables["_Transaction"].Rows[0][2].ToString();
                txtMontant.Text = ds.Tables["_Transaction"].Rows[0][3].ToString();

                if (Convert.ToBoolean(ds.Tables["_Transaction"].Rows[0][4]))
                {
                    chkRecette.Checked = true;
                    CliquerSurChkRecette(chkRecette, e);
                }
                else
                    chkPerçu.Checked = Convert.ToBoolean(ds.Tables["_Transaction"].Rows[0][5]);

                da = new OleDbDataAdapter(new CMD("SELECT * FROM TypeTransaction", con));
                da.Fill(ds, "_TypeTransaction");

                foreach (var row in ds.Tables["_TypeTransaction"].Rows.Cast<DataRow>().Select((row, i) => new { Row = row, Index = i }))
                {
                    cboType.Items.Add(row.Row["libType"]);
                    if (Convert.ToInt32(row.Row[0]) == Convert.ToInt32(ds.Tables["_Transaction"].Rows[0][6]))
                        cboType.SelectedIndex = row.Index;
                }
            }
        }

        // TODO: Check comment ajouter l'heure dans la table Transaction, ajout du TRY CATCH, ajout dans d'autre table (Beneficiaire ?)
        /* Bouton valider, vérification des valeurs avant la modification */
        private void ModifierLaTransaction(object sender, EventArgs e)
        {
                // Sera 'false' si au moins une erreur se produit

            bool toutEstOk = true;

                // Position des erreurs

            errorProvider.SetIconPadding(cboType, 11);
            errorProvider.SetIconPadding(txtDescTran, 11);
            errorProvider.SetIconPadding(txtMontant, 11);

                // Les vérifications au cas par cas

            if (cboType.SelectedIndex == -1)
            {
                errorProvider.SetError(cboType, "Il faut séléctionner un type pour cette transaction !");
                toutEstOk = false;
            }
            else errorProvider.SetError(cboType, "");

            if (txtMontant.Text == "" || double.Parse(txtMontant.Text) < 0.01D)
            {
                errorProvider.SetError(txtMontant, "Il faut indiquer un montant non nul (ou inférieur à 1 centime) pour cette transaction !");
                toutEstOk = false;
            }
            else errorProvider.SetError(txtMontant, "");

            if (txtDescTran.Text == "")
            {
                errorProvider.SetError(txtDescTran, "Il faut décrire cette transaction !");
                toutEstOk = false;
            }
            else errorProvider.SetError(txtDescTran, "");

                // Si aucune erreur est présente, on peut modifier la transaction
        }

        /* Saisie de la description, ne doit pas dépasser 30 caractères */
        private void SaisieDescription(object sender, KeyPressEventArgs e)
        {
            if (txtDescTran.Text.Length == 30)
            {
                e.Handled = true;
                errorProvider.SetError(txtDescTran, "La description ne doit pas dépasser 30 caractères !");
            }
            else
                errorProvider.SetError(txtDescTran, "");
        }

        /* Contrôle de saisie pour le montant */
        private void SaisirUnMontant(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else if (e.KeyChar == ',' && !txtMontant.Text.Contains(","))
                e.Handled = false;
            else if (e.KeyChar == '.' && !txtMontant.Text.Contains(","))
            {
                e.KeyChar = ',';
                e.Handled = false;
            }
        }

        /* Change le texte de chkRecette en fonction de son état checked ou non */
        private void CliquerSurChkRecette(object sender, EventArgs e)
        {
            CheckBox _sender = (CheckBox)sender;
            if (_sender.Checked)
            {
                _sender.ForeColor = Color.Gray;
                lblRecette.ForeColor = Color.Black;
                chkPerçu.Checked = true;
                chkPerçu.Enabled = false;
            }
            else {
                _sender.ForeColor = Color.Black;
                lblRecette.ForeColor = Color.Gray;
                chkPerçu.Checked = false;
                chkPerçu.Enabled = true;
            }
        }
    }
}
