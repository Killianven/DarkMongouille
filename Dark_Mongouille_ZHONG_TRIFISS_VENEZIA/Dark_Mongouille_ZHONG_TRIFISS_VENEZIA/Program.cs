using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core;

namespace Dark_Mongouille_ZHONG_TRIFISS_VENEZIA
{
    class Program
    {
        static void Main(string[] args)
        {

            int choice;
            //  MainAsync().Wait();
            do
            {
                Console.Write(getMainMenu());
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(getStandarUserMenu());
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        switch (choice2)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;

                            default:
                                break;
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                    default:
                        break;
                }
            } while (choice != 5);

            Console.ReadLine();
        }

        static async Task MainAsync()
        {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);

            var database = client.GetDatabase("Database Name");

            var collection = database.GetCollection<Movie>("movies");
            //InsertOneAsync(new Person { Name = "Jack" }).Wait();

            // var list = collection.Find(x => x.Name == "Jack")
            //           .ToListAsync().Result;


        }

        public static string getMainMenu()
        {
            return " ******Menue * *****\n "
                + " 1 – Standar User\n "
                + " 2 – Analyst\n "
                + " 3 – Admin\n "
                + " 5 – Quit\n "
                + " Choice ? : ";
        }

        public static string getStandarUserMenu()
        {
            return " ****** STANDAR USER Menue * *****\n "
                + " 1 – Request 1\n "
                + " 2 – Request 2\n "
                + " 3 – Request 3\n "
                + " 5 – Quit\n "
                + " Choice ? : ";
        }
        public static string getAnalystMenu()
        {
            return " ****** ANALYST Menue * *****\n "
                + " 1 – Request 1\n "
                + " 2 – Request 2\n "
                + " 3 – Request 3\n "
                + " 5 – Quit\n "
                + " Choice ? : ";
        }
        public static string getAdminMenu()
        {
            return " ****** ADMIN Menue * *****\n "
                + " 1 – Request 1\n "
                + " 2 – Request 2\n "
                + " 3 – Request 3\n "
                + " 5 – Quit\n "
                + " Choice ? : ";
        }
    }
}
