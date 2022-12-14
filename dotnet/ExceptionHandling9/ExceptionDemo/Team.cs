using System.Collections.Generic;
namespace CollectionsDemo
{
    class Team
    {
        public string Name { get; set; }                           
        public List<Player> players = new List<Player>();
        public Team(string name)
        {
            this.Name = name;
        }
       
       public Player this[int index]
        {
            get
            {
                return players[index];
            }
            set
            {
            this.players.Add(value);
            }
        }
    }
}