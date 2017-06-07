﻿namespace miniProjet2017
{
    partial class frmModiTransac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModiTransac));
            this.btnModifier = new System.Windows.Forms.Button();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.lblRecette = new System.Windows.Forms.Label();
            this.chkPerçu = new System.Windows.Forms.CheckBox();
            this.chkRecette = new System.Windows.Forms.CheckBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.lblDescTransac = new System.Windows.Forms.Label();
            this.lblTransac = new System.Windows.Forms.Label();
            this.calTransac = new System.Windows.Forms.MonthCalendar();
            this.lblAideDate = new System.Windows.Forms.Label();
            this.lblAideDescri = new System.Windows.Forms.Label();
            this.lblAideMontant = new System.Windows.Forms.Label();
            this.lblAideRecette = new System.Windows.Forms.Label();
            this.lblAideType = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboListeTransaction = new System.Windows.Forms.ComboBox();
            this.lblListeTransaction = new System.Windows.Forms.Label();
            this.lblChoixPersonne = new System.Windows.Forms.Label();
            this.btnChoixPersonne = new System.Windows.Forms.Button();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.txtDescTran = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.picBarreVerte2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBordure = new System.Windows.Forms.PictureBox();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.btnAide = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarreVerte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModifier.Location = new System.Drawing.Point(49, 476);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(103, 66);
            this.btnModifier.TabIndex = 28;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.ModifierLaTransaction);
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.lblRecette);
            this.grb1.Controls.Add(this.chkPerçu);
            this.grb1.Controls.Add(this.chkRecette);
            this.grb1.Location = new System.Drawing.Point(49, 331);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(281, 43);
            this.grb1.TabIndex = 27;
            this.grb1.TabStop = false;
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.Enabled = false;
            this.lblRecette.ForeColor = System.Drawing.Color.Gray;
            this.lblRecette.Location = new System.Drawing.Point(26, 18);
            this.lblRecette.Name = "lblRecette";
            this.lblRecette.Size = new System.Drawing.Size(50, 13);
            this.lblRecette.TabIndex = 10;
            this.lblRecette.Text = "Dépense";
            // 
            // chkPerçu
            // 
            this.chkPerçu.AutoSize = true;
            this.chkPerçu.Location = new System.Drawing.Point(190, 17);
            this.chkPerçu.Name = "chkPerçu";
            this.chkPerçu.Size = new System.Drawing.Size(54, 17);
            this.chkPerçu.TabIndex = 9;
            this.chkPerçu.Text = "Perçu";
            this.chkPerçu.UseVisualStyleBackColor = true;
            // 
            // chkRecette
            // 
            this.chkRecette.AutoSize = true;
            this.chkRecette.Location = new System.Drawing.Point(95, 17);
            this.chkRecette.Name = "chkRecette";
            this.chkRecette.Size = new System.Drawing.Size(73, 17);
            this.chkRecette.TabIndex = 8;
            this.chkRecette.Text = "• Recette";
            this.chkRecette.UseVisualStyleBackColor = true;
            this.chkRecette.Click += new System.EventHandler(this.CliquerSurChkRecette);
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(132, 389);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 26;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblType.Location = new System.Drawing.Point(38, 389);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 25;
            this.lblType.Text = "Type";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMontant.Location = new System.Drawing.Point(38, 304);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 24;
            this.lblMontant.Text = "Montant";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(185, 297);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 20);
            this.txtMontant.TabIndex = 23;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisirUnMontant);
            // 
            // lblDescTransac
            // 
            this.lblDescTransac.AutoSize = true;
            this.lblDescTransac.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescTransac.Location = new System.Drawing.Point(38, 245);
            this.lblDescTransac.Name = "lblDescTransac";
            this.lblDescTransac.Size = new System.Drawing.Size(141, 13);
            this.lblDescTransac.TabIndex = 22;
            this.lblDescTransac.Text = "Description de la transaction";
            // 
            // lblTransac
            // 
            this.lblTransac.AutoSize = true;
            this.lblTransac.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTransac.Location = new System.Drawing.Point(38, 52);
            this.lblTransac.Name = "lblTransac";
            this.lblTransac.Size = new System.Drawing.Size(111, 13);
            this.lblTransac.TabIndex = 20;
            this.lblTransac.Text = "Date de la transaction";
            // 
            // calTransac
            // 
            this.calTransac.Location = new System.Drawing.Point(197, 52);
            this.calTransac.MaxSelectionCount = 1;
            this.calTransac.Name = "calTransac";
            this.calTransac.TabIndex = 19;
            // 
            // lblAideDate
            // 
            this.lblAideDate.AutoSize = true;
            this.lblAideDate.Location = new System.Drawing.Point(525, 245);
            this.lblAideDate.Name = "lblAideDate";
            this.lblAideDate.Size = new System.Drawing.Size(35, 13);
            this.lblAideDate.TabIndex = 37;
            this.lblAideDate.Tag = "Aidelbl1";
            this.lblAideDate.Text = "label1";
            this.lblAideDate.Visible = false;
            // 
            // lblAideDescri
            // 
            this.lblAideDescri.AutoSize = true;
            this.lblAideDescri.Location = new System.Drawing.Point(525, 266);
            this.lblAideDescri.Name = "lblAideDescri";
            this.lblAideDescri.Size = new System.Drawing.Size(35, 13);
            this.lblAideDescri.TabIndex = 38;
            this.lblAideDescri.Tag = "Aidelbl2";
            this.lblAideDescri.Text = "label1";
            this.lblAideDescri.Visible = false;
            // 
            // lblAideMontant
            // 
            this.lblAideMontant.AutoSize = true;
            this.lblAideMontant.Location = new System.Drawing.Point(525, 297);
            this.lblAideMontant.Name = "lblAideMontant";
            this.lblAideMontant.Size = new System.Drawing.Size(35, 13);
            this.lblAideMontant.TabIndex = 39;
            this.lblAideMontant.Tag = "Aidelbl3";
            this.lblAideMontant.Text = "label1";
            this.lblAideMontant.Visible = false;
            // 
            // lblAideRecette
            // 
            this.lblAideRecette.AutoSize = true;
            this.lblAideRecette.Location = new System.Drawing.Point(525, 331);
            this.lblAideRecette.Name = "lblAideRecette";
            this.lblAideRecette.Size = new System.Drawing.Size(35, 13);
            this.lblAideRecette.TabIndex = 40;
            this.lblAideRecette.Tag = "Aidelbl4";
            this.lblAideRecette.Text = "label1";
            this.lblAideRecette.Visible = false;
            // 
            // lblAideType
            // 
            this.lblAideType.AutoSize = true;
            this.lblAideType.Location = new System.Drawing.Point(525, 361);
            this.lblAideType.Name = "lblAideType";
            this.lblAideType.Size = new System.Drawing.Size(35, 13);
            this.lblAideType.TabIndex = 41;
            this.lblAideType.Tag = "Aidelbl5";
            this.lblAideType.Text = "label1";
            this.lblAideType.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cboListeTransaction
            // 
            this.cboListeTransaction.FormattingEnabled = true;
            this.cboListeTransaction.Location = new System.Drawing.Point(291, 476);
            this.cboListeTransaction.Name = "cboListeTransaction";
            this.cboListeTransaction.Size = new System.Drawing.Size(269, 21);
            this.cboListeTransaction.TabIndex = 42;
            this.cboListeTransaction.SelectedIndexChanged += new System.EventHandler(this.ChangerIndexCboListeTransaction);
            // 
            // lblListeTransaction
            // 
            this.lblListeTransaction.AutoSize = true;
            this.lblListeTransaction.Location = new System.Drawing.Point(170, 479);
            this.lblListeTransaction.Name = "lblListeTransaction";
            this.lblListeTransaction.Size = new System.Drawing.Size(115, 13);
            this.lblListeTransaction.TabIndex = 43;
            this.lblListeTransaction.Text = "Liste des transactions :";
            // 
            // lblChoixPersonne
            // 
            this.lblChoixPersonne.AutoSize = true;
            this.lblChoixPersonne.Location = new System.Drawing.Point(628, 230);
            this.lblChoixPersonne.Name = "lblChoixPersonne";
            this.lblChoixPersonne.Size = new System.Drawing.Size(71, 13);
            this.lblChoixPersonne.TabIndex = 55;
            this.lblChoixPersonne.Text = "participant : 0";
            // 
            // btnChoixPersonne
            // 
            this.btnChoixPersonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoixPersonne.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChoixPersonne.Location = new System.Drawing.Point(611, 175);
            this.btnChoixPersonne.Name = "btnChoixPersonne";
            this.btnChoixPersonne.Size = new System.Drawing.Size(88, 39);
            this.btnChoixPersonne.TabIndex = 54;
            this.btnChoixPersonne.Text = "Choisir les participants...";
            this.btnChoixPersonne.UseVisualStyleBackColor = true;
            this.btnChoixPersonne.Click += new System.EventHandler(this.AjouterPersonneATransaction);
            // 
            // pic5
            // 
            this.pic5.Location = new System.Drawing.Point(590, 397);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(100, 21);
            this.pic5.TabIndex = 36;
            this.pic5.TabStop = false;
            this.pic5.Tag = "Aide2";
            // 
            // pic4
            // 
            this.pic4.Location = new System.Drawing.Point(590, 367);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(100, 21);
            this.pic4.TabIndex = 35;
            this.pic4.TabStop = false;
            this.pic4.Tag = "Aide2";
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(631, 305);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(100, 20);
            this.pic3.TabIndex = 34;
            this.pic3.TabStop = false;
            this.pic3.Tag = "Aide2";
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(590, 331);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(100, 20);
            this.pic2.TabIndex = 33;
            this.pic2.TabStop = false;
            this.pic2.Tag = "Aide2";
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(590, 263);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(100, 50);
            this.pic1.TabIndex = 32;
            this.pic1.TabStop = false;
            this.pic1.Tag = "Aide";
            // 
            // txtDescTran
            // 
            this.txtDescTran.Location = new System.Drawing.Point(185, 242);
            this.txtDescTran.Name = "txtDescTran";
            this.txtDescTran.Size = new System.Drawing.Size(145, 20);
            this.txtDescTran.TabIndex = 21;
            this.txtDescTran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaisieDescription);
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(288, 300);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(13, 13);
            this.lblEuro.TabIndex = 56;
            this.lblEuro.Text = "€";
            // 
            // picBarreVerte2
            // 
            this.picBarreVerte2.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.picBarreVerte2.Location = new System.Drawing.Point(197, 216);
            this.picBarreVerte2.Name = "picBarreVerte2";
            this.picBarreVerte2.Size = new System.Drawing.Size(206, 25);
            this.picBarreVerte2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarreVerte2.TabIndex = 59;
            this.picBarreVerte2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.pictureBox1.Location = new System.Drawing.Point(197, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::miniProjet2017.Properties.Resources.ligneVerte;
            this.pictureBox2.Location = new System.Drawing.Point(197, 428);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // picBordure
            // 
            this.picBordure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBordure.Image = ((System.Drawing.Image)(resources.GetObject("picBordure.Image")));
            this.picBordure.Location = new System.Drawing.Point(0, 0);
            this.picBordure.Name = "picBordure";
            this.picBordure.Size = new System.Drawing.Size(786, 575);
            this.picBordure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBordure.TabIndex = 62;
            this.picBordure.TabStop = false;
            // 
            // picQuitter
            // 
            this.picQuitter.BackColor = System.Drawing.Color.Transparent;
            this.picQuitter.Image = global::miniProjet2017.Properties.Resources.flecheRetour;
            this.picQuitter.Location = new System.Drawing.Point(611, 452);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(79, 71);
            this.picQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuitter.TabIndex = 63;
            this.picQuitter.TabStop = false;
            this.picQuitter.Click += new System.EventHandler(this.picQuitter_Click);
            // 
            // btnAide
            // 
            this.btnAide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAide.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAide.Location = new System.Drawing.Point(631, 108);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(75, 23);
            this.btnAide.TabIndex = 64;
            this.btnAide.Text = "Aide";
            this.btnAide.UseVisualStyleBackColor = true;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTitre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitre.Location = new System.Drawing.Point(442, 34);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(303, 31);
            this.lblTitre.TabIndex = 65;
            this.lblTitre.Text = "Modifier une transaction";
            // 
            // frmModiTransac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(786, 575);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.picQuitter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBarreVerte2);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblChoixPersonne);
            this.Controls.Add(this.btnChoixPersonne);
            this.Controls.Add(this.lblListeTransaction);
            this.Controls.Add(this.cboListeTransaction);
            this.Controls.Add(this.lblAideType);
            this.Controls.Add(this.lblAideRecette);
            this.Controls.Add(this.lblAideMontant);
            this.Controls.Add(this.lblAideDescri);
            this.Controls.Add(this.lblAideDate);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblDescTransac);
            this.Controls.Add(this.txtDescTran);
            this.Controls.Add(this.lblTransac);
            this.Controls.Add(this.calTransac);
            this.Controls.Add(this.picBordure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(786, 575);
            this.MinimumSize = new System.Drawing.Size(786, 575);
            this.Name = "frmModiTransac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "1";
            this.Text = "Modification d\'une transaction";
            this.Load += new System.EventHandler(this.LancementDuFormulaire);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarreVerte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBordure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.CheckBox chkPerçu;
        private System.Windows.Forms.CheckBox chkRecette;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label lblDescTransac;
        private System.Windows.Forms.Label lblTransac;
        private System.Windows.Forms.MonthCalendar calTransac;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.Label lblAideDate;
        private System.Windows.Forms.Label lblAideDescri;
        private System.Windows.Forms.Label lblAideMontant;
        private System.Windows.Forms.Label lblAideRecette;
        private System.Windows.Forms.Label lblAideType;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblRecette;
        private System.Windows.Forms.Label lblListeTransaction;
        private System.Windows.Forms.ComboBox cboListeTransaction;
        private System.Windows.Forms.Label lblChoixPersonne;
        private System.Windows.Forms.Button btnChoixPersonne;
        private System.Windows.Forms.TextBox txtDescTran;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBarreVerte2;
        private System.Windows.Forms.PictureBox picBordure;
        private System.Windows.Forms.PictureBox picQuitter;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.Label lblTitre;
    }
}