namespace dio_rpg.src.entities{
    public class Ninja : Hero{
        public Ninja(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " usou ataque furtivo";
        }
    }
}