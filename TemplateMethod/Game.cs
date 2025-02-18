namespace TemplateMethod
{
    public abstract class Game
    {
        public void Play()
        {
            Init();
            while (!IsGameOver())
            {
                PlayPlayerOneTurn();
                PlayPlayerTwoTurn();
            }
            ShowResult();
        }

        protected abstract bool IsGameOver();
        protected abstract void Init();
        protected abstract void PlayPlayerOneTurn();
        protected abstract void PlayPlayerTwoTurn();
        protected abstract void ShowResult();
    }

    public class Chess : Game
    {
        private bool _isPlayerOneCheckMate;
        private bool _isPlayerTwoCheckMate;

        private int _turns;

        protected override void Init()
        {
            Console.WriteLine("Init du jeu d'échec");
            _isPlayerOneCheckMate = false;
            _isPlayerTwoCheckMate = false;
        }
        protected override bool IsGameOver() => _isPlayerOneCheckMate || _isPlayerTwoCheckMate;
        protected override void PlayPlayerOneTurn()
        {
            _turns++;
            Console.WriteLine("Tour du joueur 1");
            if (_turns >= 30)
                _isPlayerOneCheckMate = true;
        }
        protected override void PlayPlayerTwoTurn()
        {
            _turns++;
            Console.WriteLine("Tour du joueur 2");
            if (_turns >= 30)
                _isPlayerTwoCheckMate = true;
        }
        protected override void ShowResult() => Console.WriteLine(_isPlayerOneCheckMate ? "Le joueur 1 a gagné" : "Le joueur 2 a gagné");
    }
}