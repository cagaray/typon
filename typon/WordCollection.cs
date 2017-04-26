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
        //private string filePath = @"/Users/cgaray/Documents/mims_berkeley/2017_spring/info_290t_agile_engineering_practices/final_project/typon/typon/resources/words.txt";
        private List<string> wordsInFile = new List<string>();
        private Random randomGenerator;
        private int numberOfWordsInFile;


        public WordCollection()
        {
            assembly = Assembly.GetExecutingAssembly();
            using (textStreamReader = new StreamReader(assembly.GetManifestResourceStream("typon.words.txt")))
			{
				string line;
                while ((line = textStreamReader.ReadLine()) != null)
				{
                    wordsInFile.Add(line);
				}
                numberOfWordsInFile = wordsInFile.Count;
			}
            //wordsInFile = File.ReadAllLines(filePath);
            //numberOfWordsInFile = wordsInFile.Length;
            randomGenerator = new Random();
        }
          
        public string getOneRandomWord()
        {
            //Console.WriteLine("word: {0}", wordsInFile[randomGenerator.Next(numberOfWordsInFile)]);
            //Console.WriteLine("word: {0}", wordsInFile[randomGenerator.Next(numberOfWordsInFile)]);
            return wordsInFile[randomGenerator.Next(numberOfWordsInFile)];
        }
    }
}
