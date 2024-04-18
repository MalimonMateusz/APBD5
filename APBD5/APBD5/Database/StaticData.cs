using System.Collections.Generic;
using APBD_005.Properties;

namespace Tutorial4.Database;

public static class StaticData
{
    public static List<Animal> Animals { get; } = new List<Animal>();
    public static List<Visit> Visits { get; } = new List<Visit>();

    static StaticData()
    {
        
        Animals.Add(new Animal(101, "Burek", "Pies", 22.5, "brązowy")); 
        Animals.Add(new Animal(102, "Misia", "Kot", 5.0, "czarny"));

         Visits.Add(new Visit(1, new DateTime(2024, 04, 18), 101, "Wizyta kontrolna", 100.0));
         Visits.Add(new Visit(2, new DateTime(2024, 04, 19), 102, "Szczepienie przeciw wściekliźnie", 120.0));


    }

    public static void LoadRelationships()
    {
        foreach (var visit in Visits)
        {
            visit.animal = Animals.FirstOrDefault(a => a.IdAnimal == visit.animalIdVisit);
        }
    }
}