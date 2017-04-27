using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace typon
{
    public class WordCollection
    {
		Assembly assembly;
		StreamReader textStreamReader;
        private List<string> wordsInFile = new List<string>();
        private Random randomGenerator;


        public WordCollection()
        {
            //TODO: don't read the whole thing to memory, read each word when needed.
            //TODO: what happens when could not read the file?
            assembly = Assembly.GetExecutingAssembly();
            using (textStreamReader = new StreamReader(assembly.GetManifestResourceStream("typon.words.txt")))
			{
				string line;
                while ((line = textStreamReader.ReadLine()) != null)
				{
                    wordsInFile.Add(line);
				}
			}
            randomGenerator = new Random();
        }

        public double getTotalWordsInCollection()
        {
            return wordsInFile.Count;
        }

        public string getOneRandomWord()
        {
            //TODO: check if list has words.
            return wordsInFile[randomGenerator.Next(wordsInFile.Count)];
        }
    }
}
