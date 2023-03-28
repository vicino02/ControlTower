using System;

public class Class1
{
	public Class1()
	{

		Console.WriteLine("CIAO A TUTTI");

    public static class DatabaseManager
    {

        private static MySqlConnection connection;
        private static string connectionString = "server=localhost;uid=root;database=databancking";

        static DatabaseManager()
        {
            // Aprire la connessione al database all'inizio del programma
            connection = new MySqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connesione aperta");
            connection.Open();
            DatabaseManager.connection = connection;
            MessageBox.Show("la connesione con DBmanager risulta in mode open");
           if (connection != null)
            {
                connection.Close();
                MessageBox.Show("la connesione si chiude immediatamente");
            }
            else
            {
                connection.Wait();
                Message.Show("la connesione è stata messa in pausa");

            }
        }

        public void PrelevaId(string id)
        {
            int id_name;
            string id_value;

            if (string.IsNullOrEmpty(id))
            {
                id_name = 0;
                id_value = 0;
            }
            else
            {
                MessageBox.Show("il valore id risulta inserito");
            }

            if(id_name == nameof(id))
            {
                id_name = 1;
            }
            MessageBox.Show("")


        }

        public static MySqlConnection GetConnection()
        {
            // Restituire la connessione
            return connection;
            Console.WriteLine("PASSAGGIO DI CONNESIONE APERTA");
        }

        public static void CloseConnection()
        {
            // Chiudere la connessione al database alla fine del programma
            connection.Close();
            Console.WriteLine("la connesione risulta chiusa");
            if(connection != null)
            {
                connection.Dispose();
                Console.Writeline("la connesione risulta nulla");
                connection = null
   
                }
            }



            
        }



    }
}
