using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedCrapsForm {

    public class SimpliedCraps {

        public enum GameStatuses { Win, Lose, Point };

        private static Random rnd = new Random((int)DateTime.Now.Ticks);
        public static GameStatuses GameStatus;
        public static int GamesPlayed { get; private set; } = 0;
        public static int Wins { get; private set; } = 0;
        public static int Loses { get => GamesPlayed - Wins; }
        public static int RollNumber { get; private set; } = 0;
        public static int LastRoll { get; private set; }
        public static int Point { get; private set; } = 0;

        private static GameStatuses CheckForWinOrLoss() {
            if(RollNumber == 1) {
                Point = 0;
                if(new int[] { 7, 11 }.Contains(LastRoll)) {
                    GameStatus = GameStatuses.Win;
                } else if(new int[] { 2, 3, 12 }.Contains(LastRoll)) {
                    GameStatus = GameStatuses.Lose;
                } else {
                    GameStatus = GameStatuses.Point;
                    Point = LastRoll;
                }
            } else {
                if(LastRoll == 7) {
                    GameStatus = GameStatuses.Lose;
                } else if (LastRoll == Point) {
                    GameStatus = GameStatuses.Win;
                }
            }
            return GameStatus;
        }
        private static void ResetGame() {
            RollNumber = 0;
        }
        private static void Winner() {
            Wins++;
            GamesPlayed++;
        }
        private static void Loser() {
            GamesPlayed++;
        }
        public static void Roll() {
            LastRoll = RollTheDice();
            var gameStatus = CheckForWinOrLoss();
            if(gameStatus == GameStatuses.Win) {
                Winner();
                ResetGame();
            } else if (gameStatus == GameStatuses.Lose) {
                Loser();
                ResetGame();
            }
        }
        private static int RollTheDice() {
            RollNumber++;
            return rnd.Next(2, 13);
        }
        

        static SimpliedCraps() {
            ResetGame();
        }
    }
}
