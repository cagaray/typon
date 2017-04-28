using System;
using System.Collections;

namespace typon
{
    public class AnimatedWordsScreen
    {
        private int width;
        private int height;
        Hashtable wordsInGame = new Hashtable(); //stores words on the screen and their position on the screen now.
        Random random = new Random();

        public AnimatedWordsScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void DrawScreen()
        {
            for (int h = 0; h < height; h++){
                for (int w = 0; w < width; w++){
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            for (int w = 0; w < width; w++){
                Console.Write("*");
            }
            Console.Write("\n");
			Console.WriteLine("Number of lives left: 8");
			Console.WriteLine("Write the words on the screen (quit to exit):");
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            foreach(DictionaryEntry de in wordsInGame){
                if(((int[])de.Value)[1] < height){
					Console.SetCursorPosition(((int[])de.Value)[0], ((int[])de.Value)[1]);
					Console.Write(de.Key);
                }
            }
            Console.SetCursorPosition(left, top);
        }

        public bool checkWordInGame(string word)
        {
            return (wordsInGame.Contains(word) && ((int[])wordsInGame[word])[1] < height);
        }

        public void addWordToGame(string word)
        {
            //TODO: check word.
            wordsInGame.Add(word, new[] { random.Next(width - word.Length + 1), 0 });
        }

        public void moveWordsOneRow()
        {
			foreach (DictionaryEntry de in wordsInGame)
            {
                ((int[])de.Value)[1] += 1;
			}

        }

        public void checkAndRemoveWordInGame(string word)
        {
            if(wordsInGame.Contains(word)){
                wordsInGame.Remove(word);
            }
        }

        public int numberOfWordsInGame()
        {
            return wordsInGame.Count;
        }
    }
}
