using static System.Console;
namespace Jogo.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.HP = 100;
        }

        public Hero(string name, int level)
        {
            this.name = name;
            this.level = level;
            this.heroType = "Unknown";
            this.HP = 100;
        }

        public Hero(){
            this.name = "Unknown";
            this.level = 1;
            this.heroType = "Unknown";
            this.HP = 100;
        }

        public string name { get; set; }
        public int level { get; set; }  
        public string heroType { get; set; }
        public int HP { get; set; }

        public override string ToString()
        {
            return $@"
            Nome: {this.name}
            Level: {this.level}
            Classe: {this.heroType}
            HP: {this.HP}";
        }

        public void LevelUp()
        {
            this.level++;
        }
        public virtual string Attack()
        {
            return ($"{this.name} attacks!");
        }

    }
}