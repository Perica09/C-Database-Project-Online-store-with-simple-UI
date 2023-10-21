using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseSeminarska
{
    public partial class Online_Knizarnica : Form
    { 
        Database db = new Database();
        Dictionary<string, int> currentBookQuantity = new Dictionary<string, int>();
        
        public Online_Knizarnica()
        {
            InitializeComponent();
           
        }

        private void Isprati_Click(object sender, EventArgs e)
        {
            if (Naslov_Predlog.Text == String.Empty || Avtor_Predlog.Text == String.Empty)
            {
                MessageBox.Show("Vnesi avtor i naslov na kniga");
                return;
            }
            db.Insert(Naslov_Predlog.Text, Avtor_Predlog.Text);
            MessageBox.Show("Uspesno isprateno");
        }

        private void Triler_Button_CheckedChanged(object sender, EventArgs e)
        {
            selectAndAddToBooksList("Triler");
        }

        private void Romansa_Button_CheckedChanged(object sender, EventArgs e)
        {
            selectAndAddToBooksList("Romansa");
        }

        private void Drama_Button_CheckedChanged(object sender, EventArgs e)
        {
            selectAndAddToBooksList("Drama");
        }

        private void selectAndAddToBooksList(string zanr)
        {
            Books_List.Items.Clear();
            List<string[]> booksList = db.ListAllBooksByGenre(zanr);
            foreach (string[] item in booksList)
            {
                Books_List.Items.Add(item[0] + ", " + item[1]);
            }
        }

        private void Dodadi_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(Kolicina_Box.Text);
            string selectedBook = Books_List.GetItemText(Books_List.SelectedItem);
            if (selectedBook == String.Empty)
            {
                MessageBox.Show("Odberi kniga");
                return;
            }
            if (Kolicina_Box.Text == String.Empty)
            {
                MessageBox.Show("Vnesi kolicina");
                return;
            }
            string bookName = selectedBook.Split(',')[0];
            int[] availableQuantityAndPrice = db.getBookQuantityAndPrice(selectedBook);
            int availableQuantity = availableQuantityAndPrice[0];
            int price = availableQuantityAndPrice[1];
            if (!currentBookQuantity.ContainsKey(bookName))
            {
                currentBookQuantity[bookName] = 0;
            }
            int bookCount = currentBookQuantity[bookName];
            if (availableQuantity == int.MinValue || availableQuantity - bookCount < quantity)
            {
                MessageBox.Show("Nema dovolno kolicina");
            } else
            {
                Kosnicka_Box.Items.Add(selectedBook + ", " + quantity + ", " + (quantity * price));
                currentBookQuantity[bookName] = bookCount += quantity;
                int currentPrice = int.Parse(Vkupno_Box.Text);
                Vkupno_Box.Text = (currentPrice += (quantity * price)).ToString();
            }

        }

        private void Izbrisi_Click(object sender, EventArgs e)
        {
            removeLastElementFromCart();
        }

        private void Izbrisi_se_Click(object sender, EventArgs e)
        {
            while (Kosnicka_Box.Items.Count > 0)
            {
                removeLastElementFromCart();
            }
        }

        private void removeLastElementFromCart()
        {
            if (Kosnicka_Box.Items.Count == 0)
            {
                return;
            }
            object lastObject = Kosnicka_Box.Items[Kosnicka_Box.Items.Count - 1];
            string lastItem = Kosnicka_Box.GetItemText(lastObject);
            string[] lastItemSplit = lastItem.Split(',');
            string lastItemBookName = lastItemSplit[0];
            int lastItemQuantity = int.Parse(lastItemSplit[2]);
            int lastItemPrice = int.Parse(lastItemSplit[3]);
            int currentPrice = int.Parse(Vkupno_Box.Text);
            int bookCount = currentBookQuantity[lastItemBookName];
            currentBookQuantity[lastItemBookName] = bookCount -= lastItemQuantity;
            Vkupno_Box.Text = (currentPrice -= lastItemPrice).ToString();
            Kosnicka_Box.Items.Remove(lastItem);
        }

        private void Plati_Click(object sender, EventArgs e)
        {
            if (int.Parse(Vkupno_Box.Text) == 0)
            {
                MessageBox.Show("Kosnickata e prazna");
                return;
            }
            if (Kes_Button.Checked)
            {
                MessageBox.Show("Plakanjeto ke go napravite na vrata pri dostava");
            }
            else if (Karticka_Button.Checked)
            {
                Form3 form3 = new Form3(this);
                form3.Show();
            } else
            {
                MessageBox.Show("Odberi nacin na plakanje");
            }
                
        }
    }  
}
