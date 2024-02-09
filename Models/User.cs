namespace Parking_Lot.Models;

public class User {
    public int Id { get; set; }
    public string LicensePlate { get; set; }
    public string CarType { get; set; }
    public DateTime Date { get; set; }
    public DateTime Time { get; set; }
}

