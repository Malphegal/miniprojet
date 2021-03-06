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

namespace miniProjet2017
{
    public partial class frmRecap : Form
    {
        BindingSource bs = new BindingSource();
        DataSet ds = new DataSet();

        IDictionary<int, string> typeTranscation; // Relation typeTransaction -> nomTypeTransaction

        bool premierTransaction = true,
             premierPersonne = true;

        public frmRecap()
        {
            InitializeComponent();
            Scale(new SizeF(frmMain.resolutionScale, frmMain.resolutionScale));
            frmMain.RedimensionnerLesControls(this, frmMain.resolutionScale);
        }

        /* Chargement du formulaire */
        private void ChargementDeFrmRecap(object sender, EventArgs e)
        {
            picQuitter.Parent = picBordure;
            lblTitre.Parent = picBordure;
        }

        /* Ferme le formulaire frmRecap */
        private void picQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Lance la liaison de donnée vers les transactions */
        private void CliquerSurLiaisonTransaction(object sender, EventArgs e)
        {
                // Changer le titre de la fenêtre, et changer le tab (a suppr ? si y'a plus de titre ?)

            lblTitre.Text = "Récapitulatif : Transactions";
            lblTitre.Left = Width / 2 - lblTitre.Width / 2;
            tabControl1.SelectedTab = tabTransaction;
            btnTransaction.BackColor = Color.Red;
            btnTransaction.Font = new Font(btnTransaction.Font, FontStyle.Bold);
            btnPersonne.BackColor = Color.White;
            btnPersonne.Font = new Font(btnPersonne.Font, FontStyle.Regular);

                // Retirer les autres liaisons en cours

            lblIdPersonne.DataBindings.Clear();
            lblNom.DataBindings.Clear();
            lblPrenom.DataBindings.Clear();
            lblTelephone.DataBindings.Clear();

            if (premierTransaction)
            {
                premierTransaction = false;

                    // Création de la source de donnée pour les transactions

                new OleDbDataAdapter(new CMD(@"SELECT * FROM [Transaction]", frmMain.con)).Fill(ds, "_Transaction");

                typeTranscation = new Dictionary<int, string>();

                new OleDbDataAdapter(new CMD(@"SELECT * FROM TypeTransaction", frmMain.con)).Fill(ds, "_TypeTransaction");
                foreach (DataRow row in ds.Tables["_TypeTransaction"].Rows)
                    typeTranscation.Add((int)row[0], (string)row[1]);

                    // Activation des boutons de navigation

                btnLL.Enabled = true;
                btnL.Enabled = true;
                btnR.Enabled = true;
                btnRR.Enabled = true;
            }

            if (ds.Tables["_Transaction"].Rows.Count != 0)
            {
                bs.DataSource = ds.Tables["_Transaction"];

                    // Liaison de donnée

                lblId.DataBindings.Clear(); lblId.DataBindings.Add("Text", bs, "codeTransaction");
                lblDate.DataBindings.Clear(); lblDate.DataBindings.Add("Text", bs, "dateTransaction");
                lblDescription.DataBindings.Clear(); lblDescription.DataBindings.Add("Text", bs, "description");
                lblMontant.DataBindings.Clear(); lblMontant.DataBindings.Add("Text", bs, "montant");
                /**/lblMontant.Text = frmAjoutTransac.FormatDuMontant(lblMontant.Text); lblMontant.Text += " €";
                chkRecette.DataBindings.Clear(); chkRecette.DataBindings.Add("Checked", bs, "recetteON");
                chkPercu.DataBindings.Clear(); chkPercu.DataBindings.Add("Checked", bs, "percuON");

                lblType.Text = typeTranscation[(int)ds.Tables["_Transaction"].Rows[0][6]];
                lblEnregistrement.Text = "Enregistrement " + 1 + " / " + bs.Count;

                bs.MoveFirst();
            }
            else
                MessageBox.Show("Il n'y a pas de transaction dans la base de donnée !");
        }

        /* Lance la liaison de donnée vers les personnes*/
        private void CliquerSurLiaisonPersonne(object sender, EventArgs e)
        {
                // Changer le titre de la fenêtre, et changer le tab (a suppr ? si y'a plus de titre ?)

            lblTitre.Text = "Récapitulatif : Personnes";
            lblTitre.Left = Width / 2 - lblTitre.Width / 2;
            tabControl1.SelectedTab = tabPersonne;
            btnPersonne.BackColor = Color.Red;
            btnPersonne.Font = new Font(btnPersonne.Font, FontStyle.Bold);
            btnTransaction.BackColor = Color.White;
            btnTransaction.Font = new Font(btnTransaction.Font, FontStyle.Regular);

                // Retirer les autres liaisons en cours

            lblId.DataBindings.Clear();
            lblDate.DataBindings.Clear();
            lblDescription.DataBindings.Clear();
            lblMontant.DataBindings.Clear();
            chkRecette.DataBindings.Clear();
            chkPercu.DataBindings.Clear();
            lblType.DataBindings.Clear();

            if (premierPersonne)
            {
                premierPersonne = false;

                    // Création de la source de donnée pour les personnes

                new OleDbDataAdapter(new CMD(@"SELECT * FROM Personne", frmMain.con)).Fill(ds, "_Personne");

                    // Activation des boutons de navigation

                _btnLL.Enabled = true;
                _btnL.Enabled = true;
                _btnR.Enabled = true;
                _btnRR.Enabled = true;
            }

            if (ds.Tables["_Personne"].Rows.Count != 0)
            {
                bs.DataSource = ds.Tables["_Personne"];

                    // Liaison de donnée

                lblIdPersonne.DataBindings.Clear(); lblIdPersonne.DataBindings.Add("Text", bs, "codePersonne");
                lblNom.DataBindings.Clear(); lblNom.DataBindings.Add("Text", bs, "nomPersonne");
                lblPrenom.DataBindings.Clear(); lblPrenom.DataBindings.Add("Text", bs, "pnPersonne");
                lblTelephone.DataBindings.Clear(); lblTelephone.DataBindings.Add("Text", bs, "telMobile");

                _lblEnregistrement.Text = "Enregistrement " + 1 + " / " + bs.Count;

                bs.MoveFirst();
            }
            else
                 MessageBox.Show("Il n'y a pas de transaction dans la base de donnée !");
        }

        // ----------------------------------
        // ---Déplacement du BindingSource---
        // ----------------------------------

            // TODO: fusion ?
            // Transaction

        private void CliquerSurPremierTransaction(object sender, EventArgs e)
        {
            bs.MoveFirst();
            lblType.Text = typeTranscation[(int)ds.Tables["_Transaction"].Rows[0][6]];
            lblMontant.Text += !lblMontant.Text.Contains('€') ? " €" : "";
            lblEnregistrement.Text = "Enregistrement " + (bs.Position + 1) + " / " + bs.Count;
        }

        private void CliquerSurPrecedentTransaction(object sender, EventArgs e)
        {
            bs.MovePrevious();
            lblType.Text = typeTranscation[(int)ds.Tables["_Transaction"].Rows[bs.Position][6]];
            lblMontant.Text += " €";
            lblEnregistrement.Text = "Enregistrement " + (bs.Position + 1) + " / " + bs.Count;
        }

        private void CliquerSurSuivantTransaction(object sender, EventArgs e)
        {
            bs.MoveNext();
            lblType.Text = typeTranscation[(int)ds.Tables["_Transaction"].Rows[bs.Position][6]];
            lblMontant.Text += " €";
            lblEnregistrement.Text = "Enregistrement " + (bs.Position + 1) + " / " + bs.Count;
        }

        private void CliquerSurDernierTransaction(object sender, EventArgs e)
        {
            bs.MoveLast();
            lblType.Text = typeTranscation[(int)ds.Tables["_Transaction"].Rows[bs.Position][6]];
            lblMontant.Text += !lblMontant.Text.Contains('€') ? " €" : "";
            lblEnregistrement.Text = "Enregistrement " + (bs.Position + 1) + " / " + bs.Count;
        }

            // Personne

        private void CliquerSurPremierPersonne(object sender, EventArgs e)
        {
            bs.MoveFirst();
            _lblEnregistrement.Text = "Enregistrement " + (bs.Position + 1) + " / " + bs.Count;
        }

        private void CliquerSurPrecedentPersonne(object sender, EventArgs e)
        {
            bs.MovePrevious();
            _lblEnregistrement.Text = "Enregistrement " + (bs.Position + 1) + " / " + bs.Count;
        }

        private void CliquerSurSuivantPersonne(object sender, EventArgs e)
        {
            bs.MoveNext();
            _lblEnregistrement.Text = "Enregistrement " + (bs.Position + 1) + " / " + bs.Count;
        }

        private void CliquerSurDernierPersonne(object sender, EventArgs e)
        {
            bs.MoveLast();
            _lblEnregistrement.Text = "Enregistrement " + (bs.Position + 1) + " / " + bs.Count;
        }
    }
}
