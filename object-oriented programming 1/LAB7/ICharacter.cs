namespace Lab10; 

public interface ICharacter {
    double CombatPower();
    string ToString();
    void ChangeLife(double hit);
}