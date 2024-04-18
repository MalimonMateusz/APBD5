namespace APBD_005.Properties;

public class Visit
{
    public int id { get; set; }
    public DateTime dateVisit { get; set; }
    public int animalIdVisit { get; set; }
    public string describtionVisit { get; set; }
    public double priceVisit { get; set; }
    public Animal animal {  set; get; }

    public Visit(int Id, DateTime dateVisit, int animalIdVisit, string describtionVisit, double priceVisit)
    {
        this.id = Id;
        this.dateVisit = dateVisit;
        this.animalIdVisit = animalIdVisit;
        this.describtionVisit = describtionVisit;
        this.priceVisit = priceVisit;
    }
}