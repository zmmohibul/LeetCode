namespace DesignParkingSystem;

public class ParkingSystem
{
    public Dictionary<int, int> CarSlotSize { get; set; }
    
    public ParkingSystem(int big, int medium, int small)
    {
        CarSlotSize = new Dictionary<int, int>();
        CarSlotSize[1] = big;
        CarSlotSize[2] = medium;
        CarSlotSize[3] = small;
    }
    
    public bool AddCar(int carType) 
    {
        if (CarSlotSize[carType] == 0)
        {
            return false;
        }
        
        CarSlotSize[carType] -= 1;
        return true;
    }
}