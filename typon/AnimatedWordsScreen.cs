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
        private int lives = 1;

        public AnimatedWordsScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

		public void drawInitialScreen()
		{
			for (int h = 0; h < height; h++)
			{
				for (int w = 0; w < width; w++)
				{
					Console.Write(" ");
				}
				Console.Write("\n");
			}
			int left = Console.CursorLeft;
			int top = Console.CursorTop;
			string message = "Typon";
			Console.SetCursorPosition((width - message.Length) / 2, height / 2 - 1);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
			Console.Write(message);
			message = "Get freaking fast at typing!";
			Console.SetCursorPosition((width - message.Length) / 2, height / 2 + 1);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Cyan;
			Console.Write(message);
			Console.SetCursorPosition(left, top);
			Console.ResetColor();
			Console.WriteLine("Press enter to start");
		}

        public void drawScreen()
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
            Console.WriteLine("Number of lives left: {0}", lives);
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
                if(((int[])de.Value)[1] == height){
                    looseOneLive();
                }
			}

        }

        public void checkAndRemoveWordInGame(string word)
        {
            if(wordsInGame.Contains(word)){
                wordsInGame.Remove(word);
            }
        }

        public void looseOneLive()
        {
            lives -= 1;
        }

        public int livesLeft()
        {
            return lives;
        }

        public int numberOfWordsInGame()
        {
            return wordsInGame.Count;
        }

        public bool gameOver()
        {
            return (!(lives > 0));
        }

		public void drawGameOver()
		{
			for (int h = 0; h < height; h++)
			{
				for (int w = 0; w < width; w++)
				{
					Console.Write(" ");
				}
				Console.Write("\n");
			}
			int left = Console.CursorLeft;
			int top = Console.CursorTop;
            string message = "Game Over";
            Console.SetCursorPosition((width - message.Length) / 2, height / 2);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(message);
            Console.SetCursorPosition(left, top);
            Console.ResetColor();
            Console.WriteLine("Write quit to exit:");
		}
    }
}
