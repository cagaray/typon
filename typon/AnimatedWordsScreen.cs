using System;
using System.Collections;

namespace typon
{
    public class AnimatedWordsScreen
    {
        private int width;
        private int height;
        Hashtable wordsInGame = new Hashtable();

        public AnimatedWordsScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void DrawScreen()
        {
            for (int h = 0; h < height; h++){
                for (int w = 0; w < width; w++){
                    Console.Write("0");
                }
                Console.Write("\n");
            }
        }

        public void addWordToGame(string word)
        {
            //TODO: check word.
            wordsInGame.Add(word, new[] { 0, 0 });
        }
    }
}
