namespace ZooLogic;

public class Zoo
{
    public Animals[] Animals {get; set;}
    public Zoo() {
        Animals = new Animals[1024];
    }
}

public class Animals {
    public string Name {get; set;}
    public string Species {get; set;}
}