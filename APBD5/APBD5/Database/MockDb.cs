using APBD_005.Properties;


namespace Tutorial4.Database;

public class MockDb
{
    public List<Animal> Animals = new List<Animal>();
    public List<Visit> Visits = new List<Visit>();
        

    public MockDb()
    {
        Animals.Add(new Animal(1, "Fido", "Pies", 30.0, "Czarny"));
        Visits.Add(new Visit (1, new DateTime(2021, 02, 02), 1, "Roczne szczepienie", 150.0));
    }
}