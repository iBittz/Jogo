namespace Jogo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.HP = 100;
        }

        public Wizard(string name, int level)
        {
            this.name = name;
            this.level = level;
            this.heroType = "Unknown";
            this.HP = 100;
        }

        public Wizard(){
            this.name = "Unknown";
            this.level = 1;
            this.heroType = "Unknown";
            this.HP = 100;
        }
        public override string Attack()
        {
            return $"{this.name} casts a spell!";
        }

        public string Attack(int damage, Hero hero)
        {
            hero.HP -= damage;
            return $"{this.name} casts a spell with {damage} damage!";
        }

        public string Heal(int heal)
        {
            return $"{this.name} casts a spell to heal himself for {heal} points!";
        }
    }
}