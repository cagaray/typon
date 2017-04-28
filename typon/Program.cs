using System;

namespace typon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AnimatedWordsScreen animatedScreen = new AnimatedWordsScreen(60, 20);
            animatedScreen.DrawScreen();
            WordCollection words = new WordCollection();

            var timer = new System.Timers.Timer(3000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(delegate
            {
                Console.Clear();
                animatedScreen.addWordToGame(words.getOneRandomWord());
                animatedScreen.DrawScreen();
                animatedScreen.moveWordsOneRow();
            });
            timer.Start();
            string userResponse = string.Empty;
            while(userResponse != "quit"){
                userResponse = Console.ReadLine();
                animatedScreen.checkAndRemoveWordInGame(userResponse);
            }
        }
    }
}
