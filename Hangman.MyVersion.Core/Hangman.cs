using Hangman.Core.Adaptor;
using System;

namespace Hangman.MyVersion.Core
{
    public class Hangman : IHangman
    {
        public Hangman(string secretWord, int maxNrOfGuesses)
        {
            throw new NotImplementedException();
        }

        public object Guess(string s)
        {
            throw new NotImplementedException();
        }
    }
}



using Ardalis.SmartEnum;

namespace Hangman.Version01.Core
{
    public abstract class GameState : SmartEnum<GameState>
    {
        public static readonly GameState GameIsOn = new Response("GameIsOn", 1, "", Feeling.Neutral);
        public static readonly GameState GameWon = new Response("GameWon", 2, "You won!", Feeling.Positive);
        public static readonly GameState GameLost = new Response("GameLost", 3, "You lost!", Feeling.Negative);

        public string Message { get; private set; }
        public Feeling Feeling { get; private set; }

        private GameState(string name, int value) : base(name, value)
        {
        }

        private sealed class Response : GameState
        {
            public Response(string name, int nr, string message, Feeling feeling) : base(name, nr)
            {
                Message = message;
                Feeling = feeling;
            }
        }
    }

}
