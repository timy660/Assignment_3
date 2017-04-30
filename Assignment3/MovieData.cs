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
    class MovieData
    {
        /**
     *  This functions returns the IMDB rating using the OMDb API
     *  for the given movie.
     *  @param movie - Represents the movie given
     *  @return returns the score of the movie
     */
        public static double GetScore(string movie)
        {
            WebClient webclient = new WebClient();
            string data = webclient.DownloadString("http://www.omdbapi.com/?t=" + movie);
            JObject json = JObject.Parse(data);

            return (double)json["imdbRating"];
        }

        /**
     *  This functions returns the Release year using the OMDb API
     *  for the given movie.
     *  @param movie - Represents the movie given
     *  @return returns the year of the movievrelease
     */
        public static string GetReleaseYear(string movie)
        {
            WebClient webclient = new WebClient();
            string data = webclient.DownloadString("http://www.omdbapi.com/?t=" + movie);
            JObject json = JObject.Parse(data);
            string j = (string)json["Year"];

            return ExtractNumers(j);
        }
        /**
          *  This functions returns the time duration using the OMDb API
          *  for the given movie.
          *  @param movie - Represents the movie given
          *  @return returns the duration of the movie
          */
        public static string GetDuration(string movie)
        {
            WebClient webclient = new WebClient();
            string data = webclient.DownloadString("http://www.omdbapi.com/?t=" + movie);
            JObject json = JObject.Parse(data);
            string j = (string)json["Runtime"];

            return ExtractNumers(j);

        }
        /**
     *  This functions returns the IMDB rating using the OMDb API
     *  for the given movie.
     *  @param movie - Represents the movie given
     *  @return returns the score of the movie
     */
        public static string GetOsacrs(string movie)
        {
            WebClient webclient = new WebClient();
            string data = webclient.DownloadString("http://www.omdbapi.com/?t=" + movie);
            JObject json = JObject.Parse(data);
            string j = (string)json["Awards"];

            return ExtractNumers(j);
        }
        /**
        *  This functions returns the Actors of the movie using the OMDb API
        *  for the given movie.
        *  @param movie - Represents the movie given
        *  @return returns Actors of the movie
         */
        public static string GetActors(string movie)
        {
            WebClient webclient = new WebClient();
            string data = webclient.DownloadString("http://www.omdbapi.com/?t=" + movie);
            JObject json = JObject.Parse(data);
            string j = (string)json["Actors"];

            return j;
        }
        /**
          *  This functions returns the string without characters and letters 
          *  @param movie - Represents the movie given
          *  @return returns string of nubmers of 
        */
        public static string GetGener(string movie)
        {
            WebClient webclient = new WebClient();
            string data = webclient.DownloadString("http://www.omdbapi.com/?t=" + movie);
            JObject json = JObject.Parse(data);
            string j = (string)json["Gener"];

            return j;
        }
        public static string ExtractNumers(string str)
        {
            string var = new String(str.ToCharArray().Where(c => Char.IsDigit(c)).ToArray());


            return var;
        }
    }
}
