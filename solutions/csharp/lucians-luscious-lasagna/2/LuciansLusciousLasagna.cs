class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        var minutesToCook = 40;
        return minutesToCook;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutes) => this.ExpectedMinutesInOven() - minutes;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers){
        int timeCooking = 2;
        return layers * timeCooking;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutes){
        return minutes + this.PreparationTimeInMinutes(layers);
    }
}
