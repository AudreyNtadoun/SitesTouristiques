/*
        Programmeurs:   Merveilles et Audrey
        
        Solution:       SitesTouristiques.sln
        Projet:         SitesTouristiques.csproj
        Classe:         SitesTouristiquesForm.cs

        But:            Pratiquer l'impression et la centralisation 
                        d'une image sur un formulaire.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SitesTouristiques
{
    public partial class SitesTouristiquesForm : Form
    {
        #region Constructeur

        public SitesTouristiquesForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Init
        private void SitesTouristiquesForm_Load(object sender, EventArgs e)
        {
            impressionLogoRadioButton.Checked = true;
            sitesPrintPreviewDialog.PrintPreviewControl.Zoom = 1;
            sitesPrintPreviewDialog.UseAntiAlias = true;
        }

        #endregion

        #region Déclaration des membres

        float hauteurImage;
        float largeurImage;

        Font enteteFont;
        Font titreFont;
        Font detailFont;

        float xFloat;
        float yFloat;

        float hauteurPoliceEnteteFloat;
        float hauteurPoliceDetailFloat;
        float hauteurPoliceTitreFloat;

        String enteteString;
        
        String titreString;
        float largeurTitreFloat;

        int indiceSiteInterger;
        string detailSiteString;

        int n = 8;

        #endregion

        #region PrintPage
        private void sitesPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            xFloat = e.MarginBounds.X;
            yFloat = e.MarginBounds.Y;

            if (impressionLogoRadioButton.Checked)
            {
                xFloat = (e.PageBounds.Width - logoPictureBox.Image.Width) / 2;
                e.Graphics.DrawImage(logoPictureBox.Image, xFloat, yFloat);
                yFloat += logoPictureBox.Image.Height + 20;
            }
            else
            {
                xFloat = (e.PageBounds.Width - imagePictureBox.Image.Width) / 2;
                e.Graphics.DrawImage(imagePictureBox.Image, xFloat, yFloat);
                yFloat += imagePictureBox.Image.Height + 20;
            }


            // Definition des polices pour l'entete, le titre  et les lignes

            enteteFont = new Font("Calibri", 16.0F, FontStyle.Bold);
            titreFont = new Font("Calibri", 14.0F, FontStyle.Bold);
            detailFont = new Font("Calibri", 11.0F);

            hauteurPoliceEnteteFloat = enteteFont.GetHeight();
            hauteurPoliceTitreFloat = enteteFont.GetHeight();
            hauteurPoliceDetailFloat = detailFont.GetHeight();

            enteteString = "Les differents sites touristiques - Merveilles et Audrey";
            largeurTitreFloat = e.Graphics.MeasureString(enteteString, enteteFont).Width;

            titreString = "Liste des sites";

            // Position initiale du crayon : Coin supérieur gauche à l'intérieur des marges
            xFloat = (e.PageBounds.Width - largeurTitreFloat) / 2;
            e.Graphics.DrawString(enteteString, enteteFont, Brushes.Black, xFloat, yFloat);
            xFloat = e.MarginBounds.X;

            yFloat += hauteurPoliceEnteteFloat * 2.0F;
            e.Graphics.DrawString(titreString, titreFont, Brushes.Black, xFloat, yFloat);

            yFloat += hauteurPoliceTitreFloat;
            
            e.Graphics.DrawLine(new Pen(Color.Green, 3.0F), xFloat, yFloat, xFloat + e.MarginBounds.Width, yFloat);

            // Changement position de y
            yFloat += hauteurPoliceDetailFloat;

            string space2 = new string(' ', n);
            for (indiceSiteInterger = 0; indiceSiteInterger <= sitesWebListBox.Items.Count - 1; indiceSiteInterger++)
            {
                detailSiteString = (indiceSiteInterger + 1) + space2 +
                                    sitesWebListBox.Items[indiceSiteInterger].ToString();

                e.Graphics.DrawString(detailSiteString, detailFont, Brushes.Blue, xFloat, yFloat);

                yFloat += hauteurPoliceDetailFloat;
            }
        }

        #endregion

        #region Imprimer

        private void imprimerButton_Click(object sender, EventArgs e)
        {
            sitesPrintPreviewDialog.ShowDialog();
        }

        #endregion

        #region Quitter

        private void fermerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
