using Newtonsoft.Json;

namespace Lab5.Ex5; 

public class FilePersonRepository : IPersonRepository {
    public List<Person> GetAll() {
        List<Person> list = JsonConvert.DeserializeObject<List<Person>>("repository.json");
        return list;
    }

    public Person GetById(int id) {
        List<Person> list = JsonConvert.DeserializeObject<List<Person>>("repository.json");

        if (id < 0 || id >= list.Count) return null;
        return list[id];
    }

    public void Add(Person personToAdd) {
        List<Person> list = JsonConvert.DeserializeObject<List<Person>>("repository.json");
        list.Add(personToAdd);
        string ser = JsonConvert.SerializeObject(list);
        using (var sw = new StreamWriter("repository.json")) {
            sw.Write(ser);
        }
    }

    public void Update(Person personToUpdate) {
        throw new NotImplementedException();
    }

    public void Remove(int id) {
        List<Person> list = JsonConvert.DeserializeObject<List<Person>>("repository.json");

        if (!(id < 0 || id >= list.Count)) {
            list.RemoveAt(id);
            string ser = JsonConvert.SerializeObject(list);
            using (var sw = new StreamWriter("repository.json")) {
                sw.Write(ser);
            }
        }
    }

    public int CountPersonOverYrs(int yearsFromCount) {
        List<Person> list = JsonConvert.DeserializeObject<List<Person>>("repository.json");

        int counter = 0;
        for (int i = 0; i < list.Count; i++) {
            string sYear = "";
            sYear += list[i].Pesel[0];
            sYear += list[i].Pesel[1];

            int year = int.Parse(sYear);

            if (year == yearsFromCount) counter++;
        }

        return counter;
    }
}