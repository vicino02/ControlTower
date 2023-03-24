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
            Console.WriteLine("tutto riuscio correttamente");
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
        }



    }
}
