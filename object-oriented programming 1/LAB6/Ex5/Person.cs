namespace Lab9.Ex5; 

public class Person : ICloneable {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person() {
        FirstName = "";
        LastName = "";
        Age = 0;
    }

    public Person(string firstName, string lastName, int yearsOld) {
        FirstName = firstName;
        LastName = lastName;
        Age = yearsOld;
    }


    public object Clone() {
        return this.MemberwiseClone();
    }
}