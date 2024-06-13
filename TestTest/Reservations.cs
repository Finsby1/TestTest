namespace TestTest;

public class Reservations
{
    private Dictionary<int, Reservation> _reservations; //hvis en dictionary skal have et instansfelt
    //private List<Dog> _dogList; //hvis en liste skal have et instansfelt
    

    public int ID { get; set; }

    public Reservations(int id)
    {
        _reservations = new Dictionary<int, Reservation>();
        ID = id;
    }
    
    public Reservations()
    {
        _reservations = new Dictionary<int,Reservation>();
    }
    
    public void RegisterReservation(Reservation reservation)
    {
        if (!_reservations.ContainsKey(reservation.ID))
        {
            _reservations.Add(reservation.ID, reservation);
        }
    }

    public void PrintReservations()
    {
        foreach (Reservation reservation in _reservations.Values)
        {
            Console.WriteLine(reservation);
        }
    }

    public void DeleteReservation(Reservation reservation)
    {
        if (_reservations.ContainsKey(reservation.ID))
        {
            _reservations.Remove(reservation.ID);
        }
    }
}