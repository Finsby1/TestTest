namespace TestTest;

class Program
{
    static void Main(string[] args)
    {
        ChildrensGroup Tigerbo = new ChildrensGroup("1", "Tigerbo", AgeGroups.PILT, 16);
        ChildrensGroup Lyngens = new ChildrensGroup("2", "Bumsestuen", AgeGroups.TUMLING, 9);
        Console.WriteLine(Tigerbo.ToString());
        Console.WriteLine(Lyngens.ToString());

        Reservation r1 = new Reservation(3, new DateTime(2024, 6, 14, 12, 30, 0), Tigerbo);
        Console.WriteLine(r1);
        
        
        Reservations resList = new Reservations();

        Console.WriteLine("Register a reservation");
        resList.RegisterReservation(r1);
        resList.PrintReservations();
        Console.WriteLine();
        
        Console.WriteLine("Remove a reservation");            
        resList.DeleteReservation(r1);
        resList.PrintReservations();
        Console.WriteLine();




    }
}