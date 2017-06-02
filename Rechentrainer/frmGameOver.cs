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
    public partial class frmGameOver : Form
    {

        string punkte;
        public frmGameOver()
        {
            InitializeComponent();
        }

        public void setPunkte(string anzahlPunkte)
        {
            // Definiere anzahlPunkte als punkte 
            punkte = anzahlPunkte;
        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {
            // Wenn frmGameOver gestartet wird, so wird Text mit erreichten Punkten ausgegeben
            lblGameOver.Text = "Herzliche Gratulation zur Ereichung von " + punkte + " Punkten!";           
        }

        private void btnzurueck_Click(object sender, EventArgs e)
        {
            // frmGameOver beenden wenn auf zurückButton Button geklickt wird
            Close();
        }
    }
}
