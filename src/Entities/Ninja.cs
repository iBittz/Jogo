namespace Jogo.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.HP = 100;
        }

        public Ninja(string name, int level)
        {
            this.name = name;
            this.level = level;
            this.heroType = "Unknown";
            this.HP = 100;
        }

        public Ninja(){
            this.name = "Unknown";
            this.level = 1;
            this.heroType = "Unknown";
            this.HP = 100;
        }
        public override string Attack()
        {
            return $"{this.name} attacks with a sword!";
        }
        public string Attack(int damage)
        {
            return $"{this.name} attacks with a sword with {damage} damage!";
        }       
    }
}