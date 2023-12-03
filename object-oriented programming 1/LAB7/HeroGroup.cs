using System.Net;

namespace Lab10; 

public class HeroGroup : ICloneable {
    private List<ICharacter> List;
    private string Name;

    public HeroGroup(string name) {
        Name = name;
        List = new List<ICharacter>();
    }

    public void Add(ICharacter character) {
        List.Add(character);
    }

    public ICharacter? getCharacter(int index) {
        if (index >= 0 && index < List.Count) return List[index];
        else return null;
    }

    public object Clone() {
        return this.MemberwiseClone();
    }

    public double CombatPower() {
        double power = 0;

        foreach (var p in List) {
            power += p.CombatPower();
        }

        return power;
    }

    public string ToString() {
        string text =  "Hero's Group: " + Name + "\n";
        foreach (var p in List) text += p.ToString() +"\n";
        text += "Group Combat Power: " + CombatPower().ToString("0.00");

        return text;
    }
}