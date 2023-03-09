namespace Tennis
{
    public class Tennis
    {
        private int scorePlayer1 = 0;
        private int scorePlayer2 = 0;

        public string GetScore()
        {
            if (scorePlayer1 == 4 && scorePlayer2 == 4)
            {
                return "Égalité.";
            } else if (scorePlayer1 >= 4 && scorePlayer1 >= scorePlayer2 + 2)
            {
                return "Joueur 1 a gagné la partie.";
            } else if (scorePlayer2 >= 4 && scorePlayer2 >= scorePlayer1 + 2)
            {
                return "Joueur 2 a gagné la partie.";
            } else if (scorePlayer1 >= 3 && scorePlayer2 >= 3)
            {
                if (scorePlayer1 == scorePlayer2)
                {
                    return "Égalité.";
                }
                else if (scorePlayer1 > scorePlayer2)
                {
                    return "Avantage Joueur 1.";
                }
                else
                {
                    return "Avantage Joueur 2.";
                }
            }
            else
            {
                return $"{GetPlayerScore(scorePlayer1)} - {GetPlayerScore(scorePlayer2)}";
            }
        }

        private string GetPlayerScore(int score)
        {
            switch (score)
            {
                case 0:
                    return "0";
                case 1:
                    return "15";
                case 2:
                    return "30";
                case 3:
                    return "40";
                default:
                    return "";
            }
        }

        public void PlayerOneMarkPoint()
        {
            scorePlayer1++;
        }

        public void PlayerTwoMarkPoint()
        {
            scorePlayer2++;
        }
    }
}