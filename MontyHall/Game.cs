using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public class Game
    {


        public enum Cups
        {
            Left = 1,
            Middle = 2,
            Right = 3
        };


        private List<Cups> GameCups;
        public Game(int gameNumber, Cups cup) //We do not want to start a game without first choosing a cup
        {
            GameNumber = gameNumber;
            SelectedCup = cup;
            PrizedCup = (Cups)new Random().Next(1, 3);
            InitializeCups();
       
        }

        private void InitializeCups()
        {
            
            GameCups = new List<Cups>();
            GameCups.Add(Cups.Left);
            GameCups.Add(Cups.Middle);
            GameCups.Add(Cups.Right);
        }

        private int GameNumber;
        public Cups SelectedCup { get; private set; }


        //METHODS---------------------------------------------------------------------------------
        public Cups RemoveCup()
        {
            return Cups.Middle;
        }

        public bool Result()
        {
            return true;
        }

        public void ReassignCup(bool didUserChange)
        {

        }

        private readonly Cups PrizedCup;


        private void FindLeftOverCups()
        {

        }




    }


}

