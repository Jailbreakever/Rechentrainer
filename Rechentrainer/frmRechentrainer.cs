// Programm Rechentrainer
// Version 1.0
// 30.05.2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace M404_Rechentrainer_Leuenberger_Adrian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Definiere neue Zufallsvariable mit Namen Zufallszahl
        Random Zufallszahl = new Random();
        frmGameOver gameOver = new frmGameOver();
        int Zufallswert1;
        int Zufallswert2;
        int Berechnen;
        int breiteBasisZeitNachStart;

        private void NeueRechnung(int zahl1, int zahl2)
        {
            // Löscht den Text von txtErgebnis
            txtErgebnis.Clear();
            if (rdb212.Checked)
            {
                if (rdbLeicht.Checked)
                {
                    do
                    {
                        // Wenn rdb212 und rdbLeicht ausgewählt sind, so werden zwei neue Zufallswerte generiert.
                        // Falls das Ergebnis der Multiplikation der generierten Zufallswerte über 100 ist, so werden neue Zufallswerte generiert. 
                        // Dies wird solange ausgeführt, bis zu Bedinung nicht mehr zutrifft.
                        // Quelle hinzufügen der Zufallszahlen: https://msdn.microsoft.com/de-de/library/dd492147.aspx 
                        Zufallswert1 = Zufallszahl.Next(zahl1, zahl2);
                        Zufallswert2 = Zufallszahl.Next(zahl1, zahl2);
                    } while ((Zufallswert1 * Zufallswert2) > 100);
                }
                else if (rdbSchwer.Checked)
                {
                    do
                    {
                        // Wenn rbd12 und rdbSchwer ausgewählt sind, so werden zwei neue Zufallswerte generiert.
                        // Wenn das Ergebnis der Multiplikation der beiden Zufallswerte kleiner als 10 ist soll er zwei neue Zufallswerte generieren 
                        // Wenn Zufallswert1 oder Zufallswert2 10 ist, so soll er zwei neue Zufallswerte generieren.
                        // Dies wird solange durchgeführt, bis zu Bedinung nicht mehr zutrifft.
                        Zufallswert1 = Zufallszahl.Next(zahl1, zahl2);
                        Zufallswert2 = Zufallszahl.Next(zahl1, zahl2);
                    } while ((Zufallswert1 * Zufallswert2) < 10 || Zufallswert1 == 10 || Zufallswert2 == 10);
                }
            }
            else if (rdb219.Checked)
            {
                if (rdbLeicht.Checked)
                {
                    do
                    {
                        // Wenn rdb219 und rdbLeicht ausgewählt sind, so generiere zwei neue Zufallswerte
                        // Wenn Zufallswert1 grösser als 5 und nicht 10 ist, so generiere zwei neue Zufallswerte
                        // Dies wird solange durchgeführt, bis zu Bedinung nicht mehr zutrifft.
                        Zufallswert1 = Zufallszahl.Next(zahl1, zahl2);
                        Zufallswert2 = Zufallszahl.Next(zahl1, zahl2);
                    } while ((Zufallswert1 > 5 && Zufallswert1 != 10));
                }
                else if (rdbSchwer.Checked)
                {
                    do
                    {
                        // Wenn rdb219 und rbdSchwer ausgewählt sind, so generiere zwei neue Zufallswerte
                        // Wenn Zufallswert1 2 oder 10 ist, so generiere zwei neue Zufallswerte
                        // Wenn Zufallswert2 2 oder 10 ist, so generiere zwei neue Zufallswerte
                        // Dies wird solange durchgeführt, bis zu Bedinung nicht mehr zutrifft.
                        Zufallswert1 = Zufallszahl.Next(zahl1, zahl2);
                        Zufallswert2 = Zufallszahl.Next(zahl1, zahl2);
                    } while (Zufallswert1 == 2 || Zufallswert1 == 10 || Zufallswert2 == 2 || Zufallswert2 == 10);
                }
            }                      
            Zufallswert1 = Zufallszahl.Next(zahl1, zahl2);
            Zufallswert2 = Zufallszahl.Next(zahl1, zahl2);
            // Schreibe die Zufallswerte in lblRechnung getrennt mit einem "*" und konventiere in strings.
            lblRechnung.Text = Convert.ToString(Zufallswert1) + "*" + Convert.ToString(Zufallswert2);
            // Definiere der Variable Berechnen die Multiplikation der beiden Zufallswerte
            Berechnen = Zufallswert1 * Zufallswert2;
        }

        private void BasisBonuszeitBreite(int basisbreite, int bonusbreite)
        {
            lblBasiszeit.Width = basisbreite;
            lblBonuszeit.Width = bonusbreite;
        }

        private void btnNeuesTraining_Click(object sender, EventArgs e)
        {                    
            if (rdb212.Checked && rdbLeicht.Checked)
            {
                // Wenn auf Button btnNeuesTraining gedrückt wird und rdb212 sowie rdbLeicht ausgewählt ist:  
                // füge den Text 0 in txtPunkte ein
                // Setze die Breite der Label Basis- und Bonuszeit auf 50 und 0
                // Starte den Timer tmrBasiszeit
                // Generiere eine neue Rechnung mit der Methode NeueRechnung, Generiere die Zufallszahlen im Bereich von 2-12
                txtPunkte.Text = "0";
                BasisBonuszeitBreite(50, 0);
                tmrBasiszeit.Start();
                NeueRechnung(2,12);
            }
            else if (rdb212.Checked && rdbGemischt.Checked)
            {
                txtPunkte.Text = "0";
                BasisBonuszeitBreite(100, 0);
                tmrBasiszeit.Start();
                NeueRechnung(2, 12);
            }
            else if (rdb212.Checked && rdbSchwer.Checked)
            {
                txtPunkte.Text = "0";
                BasisBonuszeitBreite(100, 0);
                tmrBasiszeit.Start();
                NeueRechnung(2, 12);
            }
            else if (rdb219.Checked && rdbLeicht.Checked)
            {
                txtPunkte.Text = "0";
                BasisBonuszeitBreite(100, 0);
                tmrBasiszeit.Start();
                NeueRechnung(2, 19);
            }
            else if (rdb219.Checked && rdbGemischt.Checked)
            {
                txtPunkte.Text = "0";
                BasisBonuszeitBreite(150, 70);
                tmrBasiszeit.Start();
                NeueRechnung(2, 19);
            }
            else if (rdb219.Checked && rdbSchwer.Checked)
            {
                txtPunkte.Text = "0";
                BasisBonuszeitBreite(150, 0);
                tmrBasiszeit.Start();
                NeueRechnung(2, 19);
            }
            breiteBasisZeitNachStart = lblBasiszeit.Width;       
        }

            private void tmrBasiszeit_Tick(object sender, EventArgs e)
            {
                if (lblBasiszeit.Size == lblBasiszeit.MinimumSize)
                {
                // Wenn die Grösse des Labels lblBasiszeit der Minimumgrösse entspricht, so soll er den Timer
                // tmrBasiszeit stoppen, Punkte mit sendPunkteToGameOver nach frmGameOver senden und frmGameOver anzeigen
                tmrBasiszeit.Stop();
                sendPunkteToGameOver();
                // Ich habe Show.Dialog(); eingefügt, da das Ganze mit .Show(); nicht funktionierte
                gameOver.ShowDialog();
                }
                else
                {
                    // Wenn das Label lblBaiszeit nicht der Minimumgrösse enspricht, so soll sich das Basiszeitlabel in der Breite ändern.
                    // immer -5 der Breite der momentanen Grösse
                    lblBasiszeit.Size = lblBasiszeit.Size - new Size(5, 0);
                }
            }

        private void tmrBonuszeit_Tick(object sender, EventArgs e)
        {
            if (lblBonuszeit.Size == lblBonuszeit.MinimumSize)
            {
                // Wenn das Bonuszeit Label die Minimumgrösse erreicht hat, so soll er den Bonuszeittimer stoppen und den 
                // Basiszeit Timer starten.
                tmrBonuszeit.Stop();
                tmrBasiszeit.Start();
            }
            else
            {
                // Wenn das Label lblBaiszeit nicht der Minimumgrösse enspricht, so soll sich das Basiszeitlabel in der Breite ändern.
                // immer -5 der Breite von der momentanen Grösse
                lblBonuszeit.Size = lblBonuszeit.Size - new Size(5, 0);
            }
        }

        private void rdbLeicht_Click(object sender, EventArgs e)
        {
            if (rdb212.Checked & rdbLeicht.Checked)
            {
                // Wenn rbd212 und rdbLeicht ausgewählt sind, so soll sich das Basiszeit sowie das Bonuszeit Label in der Breite anpassen.
                // Der Button Neues Training wird auf Aktiv gesetzt.
                BasisBonuszeitBreite(50, 10);
                btnNeuesTraining.Enabled = true;
            }
            else if (rdb219.Checked & rdbLeicht.Checked)
            {
                BasisBonuszeitBreite(100, 25);
                btnNeuesTraining.Enabled = true;
            }
        }

        private void rdbGemischt_Click(object sender, EventArgs e)
        {
            if (rdb212.Checked & rdbGemischt.Checked)
            {
                BasisBonuszeitBreite(100, 25);
                btnNeuesTraining.Enabled = true;
            }
            else if (rdb219.Checked & rdbGemischt.Checked)
            {
                BasisBonuszeitBreite(150, 70);           
                btnNeuesTraining.Enabled = true;
            }
        }

        private void rdbSchwer_Click(object sender, EventArgs e)
        {
            if (rdb212.Checked & rdbSchwer.Checked)
            {
                BasisBonuszeitBreite(100, 50);
                btnNeuesTraining.Enabled = true;
            }
            else if (rdb219.Checked & rdbSchwer.Checked)
            {
                BasisBonuszeitBreite(150, 100);
                btnNeuesTraining.Enabled = true;
            }
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            // Programm beenden sobald auf den Beenden Button geklickt wird
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Wenn Programm startet, so Button Neues Training deaktivieren
            btnNeuesTraining.Enabled = false;
        }

        public void starteBonuszeit(int breite)
        {        
            if (lblBasiszeit.Width >= (breiteBasisZeitNachStart/2))
            {
                // Wenn Die Breite des Basiszeitlabels grösser oder gleich die Hälfte der Basiszeit ist so soll er den Basiszeit Timer stoppen und die Bonuszeit Starten
                // Wenn die Breite des Bonuszeitlabels kleiner oder gleich 150 (maximale Breite) ist, so soll er die Breite addieren.
                // Wenn die Breite des Bonuszeitlabels grösser als 150 ist, so soll er die Breite auf 150 setzen.
                // Bonuszeit timer starten
                tmrBasiszeit.Stop();
                
                if (lblBonuszeit.Width + breite <= 150)
                {
                    lblBonuszeit.Width += breite; // Immer breite addieren += ist wie breite + breite + ... etc.
                } else
                {
                    lblBonuszeit.Width = 150;
                }
                tmrBonuszeit.Start();
            }           
        }


        private void txtErgebnis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtErgebnis.Text == Berechnen.ToString()) {

                    if (rdb212.Checked && rdbLeicht.Checked)
                    {
                        // Wenn beim Textfeld Ergebnis die Enter Taste gedrückt wird, so wird mit der Variable Berechnen überprüft,
                        // ob das Resultat korrekt ist. Wenn dies korrekt ist und rdb212 und rdbLeicht ausgewählt wurden,
                        // so wird ins Textfeld txtPunkte die Punktezahl eingetragen. Diese ist bei rdb212 und rbdLeicht +1.
                        // Durch Methode NeueRechnung wird eine neue Rechnung im Bereich der Zahlenwerte 2-12 generiert. 
                        // starteBonuszeit wird ausgeführt.
                        txtPunkte.Text = (Convert.ToInt32(txtPunkte.Text) + 1).ToString();                                               
                        NeueRechnung(2, 12);
                        starteBonuszeit(10);
                    }

                    else if (rdb212.Checked && rdbGemischt.Checked)
                    {
                        txtPunkte.Text = (Convert.ToInt32(txtPunkte.Text) + 2).ToString();                      
                        NeueRechnung(2, 12);
                        starteBonuszeit(25);
                    }

                   else  if (rdb212.Checked && rdbSchwer.Checked)
                    {
                        txtPunkte.Text = (Convert.ToInt32(txtPunkte.Text) + 2).ToString();                      
                        NeueRechnung(2, 12);
                        starteBonuszeit(50);
                    }

                   else if (rdb219.Checked && rdbLeicht.Checked)
                    {
                        txtPunkte.Text = (Convert.ToInt32(txtPunkte.Text) + 3).ToString();                        
                        NeueRechnung(2, 19);
                        starteBonuszeit(25);
                    }

                   else if (rdb219.Checked && rdbGemischt.Checked)
                    {
                        txtPunkte.Text = (Convert.ToInt32(txtPunkte.Text) + 4).ToString();                       
                        NeueRechnung(2, 19);
                        starteBonuszeit(75);
                    }

                   else if (rdb219.Checked && rdbSchwer.Checked)
                    {
                        txtPunkte.Text = (Convert.ToInt32(txtPunkte.Text) + 5).ToString();                       
                        NeueRechnung(3,19) ;
                        starteBonuszeit(100);
                    }
                }
            }
        }

        private void sendPunkteToGameOver()
        {
            // Sende erreichte Punkte von txtPunkte nach frmGameOver zur Variable setPunkte
            // sendPunkteToGameOver Quelle: Philippe Krüttli --> gefragt, wie ich meine Punkte von txt.Punkte.Text in frmGameOver anzeigen lassen kann.
            gameOver.setPunkte(txtPunkte.Text);
        }
    }
}
