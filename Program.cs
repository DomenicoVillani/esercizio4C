namespace esercizioc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("********OPERAZIONI DISPONIBILI********");
                Console.WriteLine("1- lOGIN");
                Console.WriteLine("2- lOGOUT");
                Console.WriteLine("3- LISTA ACCESSI");
                Console.WriteLine("4- DATI PROFILO");
                Console.WriteLine("5- CHIUDI IL PROGRAMMA");
                Console.WriteLine("COSA VUOI FARE?");
                string sceltaSwitch = Console.ReadLine();
                Console.Clear();
                switch (sceltaSwitch)
                {
                    case "1":
                        Console.Clear();
                        User.Registrazione();
                        break;
                    case "2":
                        Console.Clear();
                        User.Logout();
                        break; 
                    case "3":
                        Console.Clear();
                        User.MostraDati();
                        break;
                    case "4":
                        Console.Clear();
                        User.VediDatiProfilo();
                        break;
                    case "5":
                        Console.WriteLine("\r\n                     _               _               _ \r\n     /\\             (_)             | |             (_)\r\n    /  \\   _ __ _ __ ___   _____  __| | ___ _ __ ___ _ \r\n   / /\\ \\ | '__| '__| \\ \\ / / _ \\/ _` |/ _ \\ '__/ __| |\r\n  / ____ \\| |  | |  | |\\ V /  __/ (_| |  __/ | | (__| |\r\n /_/    \\_\\_|  |_|  |_| \\_/ \\___|\\__,_|\\___|_|  \\___|_|\r\n                                                       \r\n                                                       \r\n");
                        Console.WriteLine("\r\n   _____               _                                                   _                _ _        \r\n  / ____|             (_)                                                 (_)              | | |       \r\n | |  __ _ __ __ _ _____  ___   _ __   ___ _ __    __ ___   _____ _ __ ___ _   ___  ___ ___| | |_ ___  \r\n | | |_ | '__/ _` |_  / |/ _ \\ | '_ \\ / _ \\ '__|  / _` \\ \\ / / _ \\ '__/ __| | / __|/ __/ _ \\ | __/ _ \\ \r\n | |__| | | | (_| |/ /| |  __/ | |_) |  __/ |    | (_| |\\ V /  __/ | | (__| | \\__ \\ (_|  __/ | || (_) |\r\n  \\_____|_|  \\__,_/___|_|\\___| | .__/ \\___|_|     \\__,_| \\_/ \\___|_|  \\___|_| |___/\\___\\___|_|\\__\\___/ \r\n                               | |                                                                     \r\n                               |_|                                                                     \r\n");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("\r\n  _______          _         \r\n |__   __|        | |        \r\n    | | ___  _ __ | |_ ___   \r\n    | |/ _ \\| '_ \\| __/ _ \\  \r\n    | | (_) | | | | || (_) | \r\n    |_|\\___/|_| |_|\\__\\___/  \r\n                             \r\n                             \r\n");
                        Console.WriteLine("ti ho detto solo quelle 5 opzioni non quella che hai messo tu");
                        break;
                }
            }
            
        }

        public static class User
        {

            public static string username;
            public static string password;
            public static bool login;
            public static List<DateTime> listAccessi = new List<DateTime>();

            public static void Registrazione()
            {
                Console.WriteLine("\r\n   ____  U _____ u _   _  __     __ U _____ u _   _       _   _  _____   U  ___ u \r\nU | __\")u\\| ___\"|/| \\ |\"| \\ \\   /\"/u\\| ___\"|/| \\ |\"|   U |\"|u| ||_ \" _|   \\/\"_ \\/ \r\n \\|  _ \\/ |  _|\" <|  \\| |> \\ \\ / //  |  _|\" <|  \\| |>   \\| |\\| |  | |     | | | | \r\n  | |_) | | |___ U| |\\  |u /\\ V /_,-.| |___ U| |\\  |u    | |_| | /| |\\.-,_| |_| | \r\n  |____/  |_____| |_| \\_| U  \\_/-(_/ |_____| |_| \\_|    <<\\___/ u |_|U \\_)-\\___/  \r\n _|| \\\\_  <<   >> ||   \\\\,-.//       <<   >> ||   \\\\,-.(__) )(  _// \\\\_     \\\\    \r\n(__) (__)(__) (__)(_\")  (_/(__)     (__) (__)(_\")  (_/     (__)(__) (__)   (__)   \r\n");
                Console.WriteLine("Inserisci un username ");
                User.username = Console.ReadLine();
                Console.WriteLine("Inserisci una password ");
                User.password = Console.ReadLine();
                Console.WriteLine("Ri-inserisci la password per confermarla ");
                string confermaPass = Console.ReadLine();
                if(password == confermaPass)
                {
                    User.login = true;
                    listAccessi.Add(DateTime.Now);
                    Console.WriteLine("\r\n                                                                   _ _        \r\n     /\\                                                           (_) |       \r\n    /  \\   ___ ___ ___  ___ ___  ___     ___  ___  ___  __ _ _   _ _| |_ ___  \r\n   / /\\ \\ / __/ __/ _ \\/ __/ __|/ _ \\   / _ \\/ __|/ _ \\/ _` | | | | | __/ _ \\ \r\n  / ____ \\ (_| (_|  __/\\__ \\__ \\ (_) | |  __/\\__ \\  __/ (_| | |_| | | || (_) |\r\n /_/    \\_\\___\\___\\___||___/___/\\___/   \\___||___/\\___|\\__, |\\__,_|_|\\__\\___/ \r\n                                                        __/ |                 \r\n                                                       |___/                  \r\n");
                    Console.WriteLine("Benvenuto " +User.username);
                }
                else
                {
                    Console.WriteLine("\r\n ______  ______   ______   ______   ______  \r\n| |     | |  | \\ | |  | \\ / |  | \\ | |  | \\ \r\n| |---- | |__| | | |__| | | |  | | | |__| | \r\n|_|____ |_|  \\_\\ |_|  \\_\\ \\_|__|_/ |_|  \\_\\ \r\n                                            \r\n");
                    Console.WriteLine("Password non corretta!");
                    return;
                }
            }

            public static void Logout()
            {
                if(login)
                {
                    User.username = "";
                    User.password = "";
                    User.login = false;
                }
                else
                {
                    Console.WriteLine("impossibile fare il logOut nessuno ha effettuato l'accesso!");
                }
                
            }
        
            public static void MostraDati()
            {
                foreach (var data in listAccessi)
                {
                     Console.WriteLine(data);
                }
            }

            public static void VediDatiProfilo()
            {
                if (login)
                {
                    Console.WriteLine("\r\n  _____            __ _ _                                               _      \r\n |  __ \\          / _(_) |                                             | |     \r\n | |__) | __ ___ | |_ _| | ___    _ __   ___ _ __ ___  ___  _ __   __ _| | ___ \r\n |  ___/ '__/ _ \\|  _| | |/ _ \\  | '_ \\ / _ \\ '__/ __|/ _ \\| '_ \\ / _` | |/ _ \\\r\n | |   | | | (_) | | | | | (_) | | |_) |  __/ |  \\__ \\ (_) | | | | (_| | |  __/\r\n |_|   |_|  \\___/|_| |_|_|\\___/  | .__/ \\___|_|  |___/\\___/|_| |_|\\__,_|_|\\___|\r\n                                 | |                                           \r\n                                 |_|                                           \r\n");
                    Console.WriteLine("\r\n  _     _               _          _       _   _ \r\n (_)   | |             (_)        | |     | | (_)\r\n  _    | |_ _   _  ___  _       __| | __ _| |_ _ \r\n | |   | __| | | |/ _ \\| |     / _` |/ _` | __| |\r\n | |   | |_| |_| | (_) | |    | (_| | (_| | |_| |\r\n |_|    \\__|\\__,_|\\___/|_|     \\__,_|\\__,_|\\__|_|\r\n                                                 \r\n                                                 \r\n");
                    Console.WriteLine("Username: " + User.username);
                    int asterischi = User.password.Length;
                    string passCens = "";
                    for (int i = 0; i < asterischi; i++)
                    {
                        passCens += "*";
                    }
                    Console.WriteLine("Password: " + passCens);
                    Console.WriteLine("Vuoi visualizzare la tua password? (Y / N)");
                    string scelta = Console.ReadLine();
                    if (scelta == "y")
                    {
                        Console.WriteLine("Ecco la tua password! mi raccomando non dirla a nessuno!");
                        Console.WriteLine("Password: " + User.password);
                    }
                }
                else
                {
                    Console.WriteLine("Nessun accesso effettuato");
                }
                
            }
        }
    }
}
