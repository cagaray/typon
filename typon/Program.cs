using System;

namespace typon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WordCollection words = new WordCollection();
            AnimatedWordsScreen animatedScreen = new AnimatedWordsScreen(60, 20);
			animatedScreen.drawInitialScreen();
			Console.ReadLine();
            animatedScreen.drawScreen();
            var timer = new System.Timers.Timer(3000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(delegate
            {
                Console.Clear();
                if(!animatedScreen.gameOver()){
					animatedScreen.addWordToGame(words.getOneRandomWord());
					animatedScreen.drawScreen();
					animatedScreen.moveWordsOneRow();
                }
                else{
                    animatedScreen.drawGameOver();
                    timer.Stop();
                }
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
