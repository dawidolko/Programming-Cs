namespace Lab10; 

public class Mage : ICharacter {
    private string Name { get; set; }
    private int Strength { get; set; }
    private double HealthPoints { get; set; }
    private int Magic { get; set; }

    public Mage() {
        Random rand = new Random();
        
        Name = "Xardas";
        Strength = rand.Next(1, 6);
        HealthPoints = 100;
        Magic = rand.Next(2, 12);
    }

    public Mage(string name, int strength, int magic) {
        Name = name;
        Strength = strength;
        Magic = magic;
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
        return (1.5 * Magic + 0.5*Strength) * HealthPoints;
    }

    public string ToString() {
        return ("Mage: " + Name +
                "      \tHealth Points: " + HealthPoints.ToString("0.00") +
                "\tCombat Power: " + CombatPower().ToString("0.00"));
    }
}