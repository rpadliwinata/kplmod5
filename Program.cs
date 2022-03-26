// See https://aka.ms/new-console-template for more information
using System;

namespace MOD5
{
    class Program
    {
        public static void Main(string[] args)
        {
            SayaTubeUser Rama = new SayaTubeUser("Rama");

            SayaTubeVideo f1 = new SayaTubeVideo("Good Will Hunting");
            SayaTubeVideo f2 = new SayaTubeVideo("A Beautiful Mind");
            SayaTubeVideo f3 = new SayaTubeVideo("The Man Who Knew Infinity");
            SayaTubeVideo f4 = new SayaTubeVideo("Hacksaw Ridge");
            SayaTubeVideo f5 = new SayaTubeVideo("Interstellar");
            SayaTubeVideo f6 = new SayaTubeVideo("Eternal Sunshine of The Spotless Mind");
            SayaTubeVideo f7 = new SayaTubeVideo("Fury");
            SayaTubeVideo f8 = new SayaTubeVideo("Saving Private Ryan");
            SayaTubeVideo f9 = new SayaTubeVideo("Tenet");
            SayaTubeVideo f10 = new SayaTubeVideo("The Pursuit of Happyness");

            Rama.AddVideo(f1);
            Rama.AddVideo(f2);
            Rama.AddVideo(f3);
            Rama.AddVideo(f4);
            Rama.AddVideo(f5);
            Rama.AddVideo(f6);
            Rama.AddVideo(f7);
            Rama.AddVideo(f8);
            Rama.AddVideo(f9);
            Rama.AddVideo(f10);

            Rama.PrintAllVideoPlaycount();
        }
    }
}

