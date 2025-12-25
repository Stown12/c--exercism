
class RemoteControlCar
{
    public int _speed {get; set;}
    public int _batteryDrain {get; private set;}
    public int _battery {get; private set;} = 100;
    private int _distanceTraveled;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
    }

   public bool BatteryDrained()
    {
        return this._battery < this._batteryDrain;
    } 

    public int DistanceDriven()
    {
        return this._distanceTraveled;
    }   

    public void Drive()
    {
        if(this._battery >= this._batteryDrain)
        {
            this._distanceTraveled += this._speed;
            this._battery -= this._batteryDrain;
        }
        

    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}


class RaceTrack
{
    private int _distance;
    public RaceTrack(int distance)
    {
        this._distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {

        double canFinishTrack = (double)this._distance / car._speed;
        var percentageBattery = car._batteryDrain * canFinishTrack;

        return car._battery >= percentageBattery;
        
    }
}