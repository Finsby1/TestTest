using System.Data.Common;
using System.Security.Cryptography;

namespace TestTest;

public enum AgeGroups
{
    PUSLING,
    TUMLING,
    PILT,
    VÆBNER,
    SENIORVÆBNER
}
                          
public class ChildrensGroup
{
    
    public string ID { get; set; }

    public string Name { get; set; }

    public AgeGroups AgeGroup { get; set; }

    public int NoOfParticipants { get; set; }
    
    
    public ChildrensGroup(string iD, string name, AgeGroups ageGroup, int noOfParticipants)
    {
        ID = iD;
        Name = name;
        AgeGroup = ageGroup;
        NoOfParticipants = noOfParticipants;
    }
        

    public override string ToString()
    {
        string msg = "børnegruppe " + ID + " " + Name + " består af " + NoOfParticipants + " børn, i aldersgruppen " + AgeGroup;
        return msg;
    }
    
}
