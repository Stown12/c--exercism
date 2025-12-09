static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double rate = 0.0;
        
        if(speed == 0) rate = 0;
        if(speed >= 1 || speed >= 4) rate = 100;
        if(speed >= 5 || speed >= 8) rate = 90;
        if(speed == 9) rate = 80;
        if(speed == 10) rate = 77;

        return rate / 100;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        var carsPerHour = 221;
        var productionPerHour = carsPerHour * speed;
        var ratePerHour = AssemblyLine.SuccessRate(speed);

        return ratePerHour * productionPerHour;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        var productionPerHour = AssemblyLine.ProductionRatePerHour(speed);
        var seconds = 60;
        return (int)productionPerHour / seconds;
    }
}
