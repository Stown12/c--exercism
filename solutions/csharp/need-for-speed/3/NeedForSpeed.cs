
class RemoteControlCar(int speed, int batteryDrain)
{
    public int _speed {get; set;} = speed;
    public int _batteryDrain {get; private set;} = batteryDrain;
    public int _battery {get; private set;} = 100;
    private int _distanceTraveled;

    public bool BatteryDrained() => this._battery < this._batteryDrain;

    public int DistanceDriven() => this._distanceTraveled;  

    public void Drive()
    {
        if(this._battery >= this._batteryDrain)
        {
            this._distanceTraveled += this._speed;
            this._battery -= this._batteryDrain;
        }
        

    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);

}


class RaceTrack(int distance)
{
    private int _distance = distance;

    public bool TryFinishTrack(RemoteControlCar car)
    {

        double canFinishTrack = (double)this._distance / car._speed;
        var percentageBattery = car._batteryDrain * canFinishTrack;

        return car._battery >= percentageBattery;
        
    }
}