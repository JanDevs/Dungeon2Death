public class Stats 
{
    public float health;
    public float maxHealth;

    public float attack;
    public float deffense;

    public Stats(float maxHealth, float attack, float deffense){
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.attack = attack;
        this.deffense = deffense;
    }

    public Stats Clone(){
        return new Stats(this.maxHealth, this.attack, this.deffense);
    }
}
