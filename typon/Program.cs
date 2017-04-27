using System;

namespace typon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AnimatedWordsScreen animatedScreen = new AnimatedWordsScreen(60, 20);
            WordCollection words = new WordCollection();
            string userResponse;
            do
            {
                Console.Clear();
                animatedScreen.addWordToGame(words.getOneRandomWord());
				animatedScreen.DrawScreen();

				//int left = Console.CursorLeft;
				//int top = Console.CursorTop;
				//Console.SetCursorPosition(0, 0);
				//Console.SetCursorPosition(0, 0);
				//Console.Write("test");
				//Console.SetCursorPosition(left, top);

				//TODO: implement lives.
				Console.WriteLine("Number of lives left: 8");
				Console.WriteLine("Write the words on the screen (quit to exit):");
                userResponse = Console.ReadLine();
            } while (userResponse != "quit");
        }
    }
}
