class RemoteControlCar
{
    private int _meters;
    private int _bateryPercentage = 100;

    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_meters} meters";
    }

    public string BatteryDisplay()
    {
        string message;

        if(_bateryPercentage == 0)
        {
            message = "Battery empty";
        }else
        {
            message = $"Battery at {_bateryPercentage}%";
        }
        
        return message;
    }

    public void Drive()
    {
        if(_bateryPercentage > 0)
        {
            _meters += 20;
            _bateryPercentage--;
        }
        
    }
}
