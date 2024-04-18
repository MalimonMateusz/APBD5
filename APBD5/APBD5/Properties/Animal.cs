namespace APBD_005.Properties;

public class Animal
{
    public int IdAnimal  {  set; get; }
    public string NameAnimal  {  set; get; }
    public string KategoryAnimal  {  set; get; }
    public double MassAnimal  {  set; get; }
    public string ColorsAnimal  {  set; get; }
    

    public Animal(int idAnimal, string nameAnimal, string kategoryAnimal, double massAnimal, string colorsAnimal)
    {
        IdAnimal = idAnimal;
        NameAnimal = nameAnimal;
        KategoryAnimal = kategoryAnimal;
        MassAnimal = massAnimal;
        ColorsAnimal = colorsAnimal;
        
    }
}