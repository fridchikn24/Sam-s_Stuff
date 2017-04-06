using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace main
{
    class Program
    {

        public static void Main(string[] args)
        {
            Champion AJ_Styles = new Champion();
            AJ_Styles.Name = "AJ Styles";
            AJ_Styles.World = 0;
            AJ_Styles.TV = 0;
            AJ_Styles.TagTeam = 1;
            AJ_Styles.Pure = 1;
            Dictionary<string, Champion> Wrestlers = new Dictionary<string, Champion>();
            
            Wrestlers.Add("AJ Styles", AJ_Styles);
            Boys(Wrestlers);
            int y = Wrestlers.Count;
            while (1 > 0)
            {
                Console.WriteLine("Type in the name of an ROH wrestler to see their accolades");
                string x = Console.ReadLine();

                if (Wrestlers.ContainsKey(x) == true)
                {
                    Console.WriteLine("{0}:" + " World Titles: {1}" +
                        " TV Titles: {2}" + " Tag Team Titles: {3}" + " Pure Titles: {4}", Wrestlers[x].Name, Wrestlers[x].World, Wrestlers[x].TV, Wrestlers[x].TagTeam, Wrestlers[x].Pure);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That Wrestler has not won gold in Ring of Honor, try someone else");
                    x = Console.ReadLine();

                }
            }
        }
        public static void Boys(Dictionary<string, Champion> arg)
        {
            Champion Samoa_Joe = new Champion() { Name = "Samoa Joe", World = 1, TV = 0, TagTeam = 0, Pure = 1 };
            arg.Add("Samoa Joe",Samoa_Joe);
            Champion Jay_Lethal = new Champion() { Name = "Jay Lethal", World = 1, TV = 2, TagTeam = 0, Pure = 1 };
            arg.Add("Jay Lethal", Jay_Lethal);
        }
    }


    public class Champion
    {       
        public string Name { get; set; }
        public int World { get; set; }
        public int TV { get; set; }
        public int TagTeam { get; set; }
        public int Pure { get; set; }
    }


    
}
