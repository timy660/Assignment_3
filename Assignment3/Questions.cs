using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment3
{
    class Questions
    {
        public static string ScoreQuestion()
        {
            return "Name a movie that has a higher IMBD score.";

        }
        public static string YearQuestion()
        {
            return "Name a movie that is older.";

        }
        public static string DurationQuestion()
        {
            return "Name a movie that lasts longer.";

        }
        public static string OscarQuestion()
        {
            return "Name a movie that have won more oscars";

        }
        public static string ActorQuestion()
        {
            return "Name a movie that has " + GetRandomActor() + "playing a main role.";

        }
        public static string GenerQuestion()
        {
            return "Name a name thats gener is " + GetRandomGener();
        }

       
        static string[] gener = { "Action", "Comedy", "Drama", "Fantasy" };

        static string[] actors ={"Matthew McConaughey",
                                         "Eddie Redmayne",
                                         "Leonardo DiCaprio",
                                         "Colin Firth",
                                         "Forest Whitaker ",
                                         "Denzel Washington",
                                         "Jennifer Lawrence",
                                         "Dylan O'Brien",
                                          "Will Smith"};

        public static string GetRandomActor()
        {

            Random random = new Random();
            int rnd = random.Next(0, actors.Length - 1);

            return actors[rnd];
        }

        private static string GetRandomGener()
        {
            Random random = new Random();
            int rnd = random.Next(0, gener.Length - 1);
            return gener[rnd];

        }
    }
}
