using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "tAylOr SwIFT, tHe WeEknD, TRaVis sCoTt, aRiANa gRAndE, bIlLiE eiLiSh";
            Console.WriteLine(message);

            //string newMess = message.ToUpper()[0] + message.Substring(1).ToLower();

            string[] artists = message.Split(',');
            for (int i = 0; i < artists.Length; i++)
            {
                string artist = artists[i].Trim();

                string[] names = artist.Split(' ');
                string first = names[0];
                string last = names[1];

                string newArtist= first.ToUpper()[0] + first.Substring(1).ToLower() + " " + last.ToUpper()[0] + last.Substring(1).ToLower();
                Console.WriteLine(newArtist);
                
            }


        }
    }
}
