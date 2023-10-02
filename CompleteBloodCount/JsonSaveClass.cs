using System;
using System.IO;
using Newtonsoft.Json;

namespace CompleteBloodCount
{
    public class JsonSaveClass
    {
        public Person Person { get; set; }
        public CBCTest CBCTest { get; set; }
        public BloodTests BloodTests { get; set; }
        public JsonSaveClass() { }
        public void save()
        {
            var jsonSerializerSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };
            var json = JsonConvert.SerializeObject(this);
            File.WriteAllText($"{Person.UserID}.json", json);
        }
    }
}
