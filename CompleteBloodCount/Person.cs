using System;
using System.IO;
using Newtonsoft.Json;

namespace CompleteBloodCount
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool Pregnant { get; set; }
        public bool Gender { get; set; }
        public static int UserID { get; set; }
        public Person(string firstName, string lastName, int age, bool gender, bool pregnant)
        {
            Random random = new Random();
            UserID = random.Next();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Pregnant = pregnant;
        }
        public Person() { }
        public void save()
        {
            var jsonSerializerSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };
            var json = JsonConvert.SerializeObject(this);
            File.WriteAllText($"{Person.UserID}.json", json);
        }
        public Person getPerson()
        {
            try
            {
                string json = File.ReadAllText($"{Person.UserID}.json");
                return JsonConvert.DeserializeObject<Person>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
