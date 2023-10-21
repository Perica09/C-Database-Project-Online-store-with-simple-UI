using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseSeminarska
{
    internal class Database
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Konstruktor
        public Database()
        {
            Initialize();
        }

        //Inicijaliziranje na vrednostite
        private void Initialize()
        {
            server = "localhost";
            database = "customerdatabase";
            uid = "root";
            password = "aCJSN49996@@";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //Otvaranje na konekcija do bazata
        private bool OpenConnection()
        {

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Zatvoranje na konekcija
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert 
        public void Insert(string naslov, string avtor)
        {
            string query = "INSERT INTO wanna(Naslov_Kniga, Avtor_Kniga) VALUES(\"" + naslov + "\", \"" + avtor + "\")";
            Console.WriteLine(query);

            //otvaranje konekcija
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Izvrsuvanje na komandata
                cmd.ExecuteNonQuery();

                //Zatoranje konekcija
                this.CloseConnection();
            }
        }

        
        //Dodavanje vo listata na knigite spored izbraniot zanr
        public List<string[]> ListAllBooksByGenre(string zanr)
        {
            string query = "SELECT Naslov, Avtor FROM books WHERE Zanr = \"" + zanr + "\"";

            //Kreiranje lista za da se dodeli rezultatot
            List<string[]> list = new List<string[]>();
            //Otvaranje konekcija
            if (this.OpenConnection() == true)
            {
                //Kreiranje komanda
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Kreiranje Citac na podatoci i izvrsuvanje na komandata
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Se citaat podatocite i se smestuvaat vo listata
                int currentElement = 0;
                while (dataReader.Read())
                {
                    list.Add(new string[2]);
                    list[currentElement][0] = (string) dataReader["Naslov"];
                    list[currentElement][1] = (string) dataReader["Avtor"];
                    currentElement++;
                }
                //Se zatvora citacot na podatoci
                dataReader.Close();
                //Se zatvora konekcijata
                this.CloseConnection();
                //Se vraka listata so elementi
                return list;
            }
            else
            {
                return list;
            }
        }

        //Se dobivaat kolicinata i cenata na izbranata kniga
        public int[] getBookQuantityAndPrice(string book)
        {
            string bookName = book.Split(',')[0];
            string query = "SELECT Kolicina, Cena FROM books_info WHERE ID = (SELECT ID FROM books WHERE books.Naslov = \"" + bookName + "\")";

            //Se kreira niza za kolicinata i cenata
            int[] availableQuantityAndPrice = { int.MinValue, int.MinValue};
            //Se otvora konekcija
            if (this.OpenConnection() == true)
            {
                //Se kreira komanda
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Se kreira citac na podatoci i se izvrsuva komandata
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Se citaat podatocite i se dodeluvaat vo niza
                while (dataReader.Read())
                {
                    availableQuantityAndPrice[0] = dataReader.GetInt32("Kolicina");
                    availableQuantityAndPrice[1] = dataReader.GetInt32("Cena");
                }
                //Se zatvora citacot
                dataReader.Close();
                //Se zatvora konekcijata
                this.CloseConnection();
                //Se vraka listata so elementi
                return availableQuantityAndPrice;
            }
            else
            {
                return availableQuantityAndPrice;
            }
        }
    }
}
