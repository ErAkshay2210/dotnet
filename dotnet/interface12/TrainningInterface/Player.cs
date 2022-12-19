namespace IPL
{
    public class Player : IComparable
    {

    
        public string playerName;

        public int run;
        public int matches;

        public int age;

        public int bestScore;

        public Player()
        {
            
        }
       public Player(string playerName,int run, int matches , int age , int bestScore )
       {
        this.playerName=playerName;
        this.run=run;
        this.matches=matches;
        this.age=age;
        this.bestScore=bestScore;
       }

        public int CompareTo(object? obj)
        {
           
            Player  anotherPlayer = (Player) obj;
            if (this.run < anotherPlayer.run)
             {
               return 1;
             }
             else if (this.run > anotherPlayer.run)
             {
               return -1;
             }
        else
        return 0;
            }


        

        public override string ToString()
        {
            string str =string.Format("{0}{1}{2}{3}{4}", this.playerName,this.run,this.matches,this.age,this.bestScore);
            return str;
        }

 }
}








    