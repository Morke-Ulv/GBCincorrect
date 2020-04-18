using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Badge_Challenge
{
    class Games
    {
        public enum MaturityRating
        {
            E=1, E10, T, M, Ao, RP
        }

        public enum TypeofGame
        {
            RPG=1, MMORPG, MOBA, FPS, TPS, Adventure, Casual, Idle, Strategy, Action, Puzzle, Card, Party
        }
        public string Title { get; set; }
        public MaturityRating Rating { get; set; }
        public string Description { get; set; }
        public TypeofGame TypeGame { get; set; }
        public Games() { }
        public Games(
            string title,
            MaturityRating rating,
            string description,
            TypeofGame typeofGame)
        {
            Title = title;
            Rating = rating;
            Description = description;
            TypeGame = typeofGame;
        }
    }
}
