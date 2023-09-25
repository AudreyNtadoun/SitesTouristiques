namespace SitesTouristiques
{
    partial class SitesTouristiquesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SitesTouristiquesForm));
            this.sitesLabel = new System.Windows.Forms.Label();
            this.classificationLabel = new System.Windows.Forms.Label();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.sitesWebLabel = new System.Windows.Forms.Label();
            this.sitesWebListBox = new System.Windows.Forms.ListBox();
            this.impressionGroupBox = new System.Windows.Forms.GroupBox();
            this.imprimerButton = new System.Windows.Forms.Button();
            this.impressionImageRadioButton = new System.Windows.Forms.RadioButton();
            this.impressionLogoRadioButton = new System.Windows.Forms.RadioButton();
            this.fermerButton = new System.Windows.Forms.Button();
            this.sitesPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.sitesPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.programmeurLabel = new System.Windows.Forms.Label();
            this.sitesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.impressionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sitesLabel
            // 
            this.sitesLabel.AutoSize = true;
            this.sitesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.sitesLabel.Font = new System.Drawing.Font("Poor Richard", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sitesLabel.ForeColor = System.Drawing.Color.Teal;
            this.sitesLabel.Location = new System.Drawing.Point(128, 37);
            this.sitesLabel.Name = "sitesLabel";
            this.sitesLabel.Size = new System.Drawing.Size(552, 49);
            this.sitesLabel.TabIndex = 0;
            this.sitesLabel.Text = "Sites touristiques du Cameroun";
            this.sitesLabel.UseWaitCursor = true;
            // 
            // classificationLabel
            // 
            this.classificationLabel.AutoSize = true;
            this.classificationLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classificationLabel.ForeColor = System.Drawing.Color.Red;
            this.classificationLabel.Location = new System.Drawing.Point(29, 124);
            this.classificationLabel.Name = "classificationLabel";
            this.classificationLabel.Size = new System.Drawing.Size(126, 22);
            this.classificationLabel.TabIndex = 2;
            this.classificationLabel.Text = "Classification:";
            this.classificationLabel.UseWaitCursor = true;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Image = global::SitesTouristiques.Properties.Resources.parcWaza;
            this.imagePictureBox.Location = new System.Drawing.Point(33, 284);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(167, 113);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 4;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.UseWaitCursor = true;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::SitesTouristiques.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(44, 37);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(63, 57);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.UseWaitCursor = true;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(218, 284);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(465, 139);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            this.descriptionLabel.UseWaitCursor = true;
            // 
            // sitesWebLabel
            // 
            this.sitesWebLabel.AutoSize = true;
            this.sitesWebLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sitesWebLabel.ForeColor = System.Drawing.Color.Red;
            this.sitesWebLabel.Location = new System.Drawing.Point(29, 441);
            this.sitesWebLabel.Name = "sitesWebLabel";
            this.sitesWebLabel.Size = new System.Drawing.Size(161, 22);
            this.sitesWebLabel.TabIndex = 6;
            this.sitesWebLabel.Text = "Sites Web d\'appui:";
            this.sitesWebLabel.UseWaitCursor = true;
            // 
            // sitesWebListBox
            // 
            this.sitesWebListBox.FormattingEnabled = true;
            this.sitesWebListBox.ItemHeight = 16;
            this.sitesWebListBox.Items.AddRange(new object[] {
            "https://whc.unesco.org/fr/activites/414/",
            "https://museemaritime.cm/fr_fr/",
            "https://fr.wikipedia.org/wiki/Parc_national_de_Waza",
            "https://generationvoyage.fr/endroits-visiter-cameroun/",
            "https://www.camerounweb.com/CameroonHomePage/tourism/attraction.php"});
            this.sitesWebListBox.Location = new System.Drawing.Point(34, 489);
            this.sitesWebListBox.Name = "sitesWebListBox";
            this.sitesWebListBox.Size = new System.Drawing.Size(467, 100);
            this.sitesWebListBox.TabIndex = 7;
            this.sitesWebListBox.UseWaitCursor = true;
            // 
            // impressionGroupBox
            // 
            this.impressionGroupBox.Controls.Add(this.imprimerButton);
            this.impressionGroupBox.Controls.Add(this.impressionImageRadioButton);
            this.impressionGroupBox.Controls.Add(this.impressionLogoRadioButton);
            this.impressionGroupBox.ForeColor = System.Drawing.Color.Black;
            this.impressionGroupBox.Location = new System.Drawing.Point(507, 441);
            this.impressionGroupBox.Name = "impressionGroupBox";
            this.impressionGroupBox.Size = new System.Drawing.Size(201, 162);
            this.impressionGroupBox.TabIndex = 8;
            this.impressionGroupBox.TabStop = false;
            this.impressionGroupBox.Text = "Impression";
            this.impressionGroupBox.UseWaitCursor = true;
            // 
            // imprimerButton
            // 
            this.imprimerButton.Location = new System.Drawing.Point(46, 117);
            this.imprimerButton.Name = "imprimerButton";
            this.imprimerButton.Size = new System.Drawing.Size(130, 31);
            this.imprimerButton.TabIndex = 2;
            this.imprimerButton.Text = "&Imprimer";
            this.imprimerButton.UseVisualStyleBackColor = true;
            this.imprimerButton.UseWaitCursor = true;
            this.imprimerButton.Click += new System.EventHandler(this.imprimerButton_Click);
            // 
            // impressionImageRadioButton
            // 
            this.impressionImageRadioButton.AutoSize = true;
            this.impressionImageRadioButton.Location = new System.Drawing.Point(29, 75);
            this.impressionImageRadioButton.Name = "impressionImageRadioButton";
            this.impressionImageRadioButton.Size = new System.Drawing.Size(67, 21);
            this.impressionImageRadioButton.TabIndex = 1;
            this.impressionImageRadioButton.TabStop = true;
            this.impressionImageRadioButton.Text = "Image";
            this.impressionImageRadioButton.UseVisualStyleBackColor = true;
            this.impressionImageRadioButton.UseWaitCursor = true;
            // 
            // impressionLogoRadioButton
            // 
            this.impressionLogoRadioButton.AutoSize = true;
            this.impressionLogoRadioButton.Location = new System.Drawing.Point(29, 38);
            this.impressionLogoRadioButton.Name = "impressionLogoRadioButton";
            this.impressionLogoRadioButton.Size = new System.Drawing.Size(61, 21);
            this.impressionLogoRadioButton.TabIndex = 0;
            this.impressionLogoRadioButton.TabStop = true;
            this.impressionLogoRadioButton.Text = "Logo";
            this.impressionLogoRadioButton.UseVisualStyleBackColor = true;
            this.impressionLogoRadioButton.UseWaitCursor = true;
            // 
            // fermerButton
            // 
            this.fermerButton.ForeColor = System.Drawing.Color.Black;
            this.fermerButton.Location = new System.Drawing.Point(578, 625);
            this.fermerButton.Name = "fermerButton";
            this.fermerButton.Size = new System.Drawing.Size(130, 31);
            this.fermerButton.TabIndex = 9;
            this.fermerButton.Text = "Fermer";
            this.fermerButton.UseVisualStyleBackColor = true;
            this.fermerButton.UseWaitCursor = true;
            this.fermerButton.Click += new System.EventHandler(this.fermerButton_Click);
            // 
            // sitesPrintDocument
            // 
            this.sitesPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.sitesPrintDocument_PrintPage);
            // 
            // sitesPrintPreviewDialog
            // 
            this.sitesPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.sitesPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.sitesPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.sitesPrintPreviewDialog.Document = this.sitesPrintDocument;
            this.sitesPrintPreviewDialog.Enabled = true;
            this.sitesPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("sitesPrintPreviewDialog.Icon")));
            this.sitesPrintPreviewDialog.Name = "sitesPrintPreviewDialog";
            this.sitesPrintPreviewDialog.Visible = false;
            // 
            // programmeurLabel
            // 
            this.programmeurLabel.AutoSize = true;
            this.programmeurLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmeurLabel.ForeColor = System.Drawing.Color.Red;
            this.programmeurLabel.Location = new System.Drawing.Point(30, 615);
            this.programmeurLabel.Name = "programmeurLabel";
            this.programmeurLabel.Size = new System.Drawing.Size(311, 22);
            this.programmeurLabel.TabIndex = 10;
            this.programmeurLabel.Text = "Programmeurs: Merveilles et Audrey";
            this.programmeurLabel.UseWaitCursor = true;
            // 
            // sitesTextBox
            // 
            this.sitesTextBox.Location = new System.Drawing.Point(34, 159);
            this.sitesTextBox.Multiline = true;
            this.sitesTextBox.Name = "sitesTextBox";
            this.sitesTextBox.Size = new System.Drawing.Size(413, 110);
            this.sitesTextBox.TabIndex = 11;
            this.sitesTextBox.Text = resources.GetString("sitesTextBox.Text");
            this.sitesTextBox.UseWaitCursor = true;
            // 
            // SitesTouristiquesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 668);
            this.Controls.Add(this.sitesTextBox);
            this.Controls.Add(this.programmeurLabel);
            this.Controls.Add(this.fermerButton);
            this.Controls.Add(this.impressionGroupBox);
            this.Controls.Add(this.sitesWebListBox);
            this.Controls.Add(this.sitesWebLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.classificationLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.sitesLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SitesTouristiquesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sites touristiques";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.SitesTouristiquesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.impressionGroupBox.ResumeLayout(false);
            this.impressionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sitesLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label classificationLabel;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label sitesWebLabel;
        private System.Windows.Forms.ListBox sitesWebListBox;
        private System.Windows.Forms.GroupBox impressionGroupBox;
        private System.Windows.Forms.Button imprimerButton;
        private System.Windows.Forms.RadioButton impressionImageRadioButton;
        private System.Windows.Forms.RadioButton impressionLogoRadioButton;
        private System.Windows.Forms.Button fermerButton;
        private System.Drawing.Printing.PrintDocument sitesPrintDocument;
        private System.Windows.Forms.PrintPreviewDialog sitesPrintPreviewDialog;
        private System.Windows.Forms.Label programmeurLabel;
        private System.Windows.Forms.TextBox sitesTextBox;
    }
}

