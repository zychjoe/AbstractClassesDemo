namespace ConsoleUI
{
    interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int NumberOfTires { get; set; }
        int Year { get; set; }
    }
}