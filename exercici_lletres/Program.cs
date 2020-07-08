using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace exercici_lletres
{
    class Program
    {
        static void Main(string[] args)
        {
            Fase1();

            Fase2();

            Fase3();

            Fase4();
        }

        public static void Fase1()
        {
            Console.WriteLine("_____FASE 1_____");

            char[] nameArray = new char[] { 'O', 'f', 'e', 'l', 'i', 'a' };

            for (int i = 0; i < nameArray.Length; i++)
            {
                Console.WriteLine(nameArray[i]);
            }
        }

        public static void Fase2()
        {
            Console.WriteLine("_____FASE 2_____");

            string name = "Of3lia";

            List<char> nameList = new List<char>();

            foreach (char letter in name) { nameList.Add(letter); }

            Regex vocals = new Regex("[aeiou]", RegexOptions.IgnoreCase);

            Regex numbers = new Regex("[0-9]");

            foreach (char letter in nameList)
            {
                if (vocals.IsMatch(letter.ToString()))
                {
                    Console.WriteLine(letter + "__VOCAL");
                }
                else if (numbers.IsMatch(letter.ToString()))
                {
                    Console.WriteLine(letter + "__Els noms de persones no contenen números!");
                }
                else
                {
                    Console.WriteLine(letter + "__CONSONANT");
                }
            }
        }

        public static void Fase3()
        {
            Console.WriteLine("_____FASE 3_____");

            string name = "Off3liiiiaa";

            Dictionary<string, int> lettersDictionary = new Dictionary<string, int>();

            List<char> nameList = new List<char>();

            foreach (char letter in name) { nameList.Add(letter); }

            foreach (char letter in nameList)
            {
                if (lettersDictionary.ContainsKey(letter.ToString())) // If letter is repeated
                {
                    lettersDictionary[letter.ToString()]++;
                }
                else
                {
                    lettersDictionary.Add(letter.ToString(), 1);
                }
            }

            foreach (KeyValuePair<string, int> kvp in lettersDictionary)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine($"La letra {kvp.Key} se repite {kvp.Value} veces");
                }
                else
                {
                    Console.WriteLine($"La letra {kvp.Key} no se repite");
                }
            }
        }

        public static void Fase4()
        {
            Console.WriteLine("_____FASE 4_____");

            string name = "Ofelia";
            string surname = "Cocucci";

            List<char> nameList = new List<char>();
            foreach (char letter in name) { nameList.Add(letter); }

            List<char> surnameList = new List<char>();
            foreach(char letter in surname) { surnameList.Add(letter); }

            List<char> fullName = new List<char>();

            fullName.AddRange(nameList);
            fullName.Add(' ');
            fullName.AddRange(surnameList);

            Console.WriteLine(string.Format(string.Join("",fullName)));
        }
    }
}
