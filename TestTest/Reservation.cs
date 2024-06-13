namespace TestTest;

public class Reservation
{
    
    public int ID { get; set; }

    public DateTime Time { get; set; }

    public ChildrensGroup ChildrensGroup { get; set; }
    
    public Reservation(int iD, DateTime time, ChildrensGroup childrensGroup)
    {
        ID = iD;
        Time = time;
        ChildrensGroup = childrensGroup;
    }
    

    public override string ToString()
    {
        string msg = "Du har reserveret bålhytten med ID" + ID + "i tidsrummet" + Time + "til børnegruppen" +
                     ChildrensGroup;
        return msg;
    }
    
}