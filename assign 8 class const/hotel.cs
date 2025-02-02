using System;
class HotelBooking
{
    public string guestName;
    public string roomType;
    public int nights;

    
    public HotelBooking() // default constructor
    {
        guestName = "lisalisa";
        roomType = "standard";
        nights = 1;
    }

    public HotelBooking(string guestName, string roomType, int nights)    // parameterized constructor

    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    //copy constructor
    public HotelBooking(HotelBooking other)
    {
        this.guestName = other.guestName;
        this.roomType = other.roomType;
        this.nights = other.nights;
    }

    public void display()
    {
        Console.WriteLine($"guest name: {guestName}, room type: {roomType}, nights: {nights}");
    }

    static void Main()
    {
        HotelBooking booking1 = new HotelBooking();
        booking1.display();

        HotelBooking booking2 = new HotelBooking("chris brown", "suite", 5);
        booking2.display();

        HotelBooking booking3 = new HotelBooking(booking2);  // copy constructor
        booking3.display();
    }
}
