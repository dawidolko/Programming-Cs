namespace Lab10; 

public class Warrior : ICharacter {
    private string Name { get; set; }
    private int Strength { get; set; }
    private double HealthPoints { get; set; }

    public Warrior() {
        Random rand = new Random();
        
        Name = "Geralt";
        Strength = rand.Next(3, 18);
        HealthPoints = 100;
    }

    public Warrior(string name, int strength) {
        Name = name;
        Strength = strength;
        HealthPoints = 100;
    }

    public void ChangeLife(double hit) {
        if (HealthPoints - hit <= 0) {
            Console.WriteLine(Name + " died");
            HealthPoints = 0;
        }
        else HealthPoints -= hit;
    }

    public double CombatPower() {
        if (HealthPoints > 5) return Strength * HealthPoints;
        else if (HealthPoints > 1) return Math.Pow(HealthPoints+3, HealthPoints) * Strength;
        else if (HealthPoints > 0) return Strength;
        else return 0;
    }

    public string ToString() {
        return ("Warrior: " + Name +
                "   \tHealth Points: " + HealthPoints.ToString("0.00") +
                "\tCombat Power: " + CombatPower().ToString("0.00"));
    }
}