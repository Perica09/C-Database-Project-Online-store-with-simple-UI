using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace DataBaseSeminarska
{
    public partial class Form3 : Form
    {

        Online_Knizarnica onlineKnizarnica;
        Regex nameRegex = new Regex("[a-zA-Z ]");
        Regex cardNumberRegex = new Regex("[0-9]{4} [0-9]{4} [0-9]{4} [0-9]{4}");
        Regex cvcRegex = new Regex("[0-9]{3}");

        public Form3(Online_Knizarnica onlineKnizarnica)
        {
            InitializeComponent();
            this.onlineKnizarnica = onlineKnizarnica;
        }

        private void Plati_Karticka_Click(object sender, EventArgs e)
        {
            if (nameRegex.Matches(Nositel.Text).Count == 0)
            {
                MessageBox.Show("Vnesete tocno ime i prezime");
                return;
            }
            if (cardNumberRegex.Matches(Broj_Karticka.Text).Count == 0)
            {
                MessageBox.Show("Vnesete validen broj na karticka");
                return;
            }
            if (cvcRegex.Matches(CVC.Text).Count == 0)
            {
                MessageBox.Show("Vnesete validen CVC");
                return;
            }
            DateTime expirationDate;
            try
            {
                expirationDate = DateTime.ParseExact(Datum_Istekuvanje.Text, "dd/MM/yyyy", null);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vnesete validen datum na istekuvanje so format \"den/mesec/godina\"");
                return;
            }
            if (expirationDate < DateTime.Now)
            {
                MessageBox.Show("Vasata karticka e izminata");
                return;
            }
            MessageBox.Show("Uspesno plakanje");
        }
    }
}
