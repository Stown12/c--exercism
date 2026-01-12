
class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        //* la colection expression de arrays se define con corchetes [] y los elementos separados por comas.
        int[] lastWeeksCounts = [0, 2, 5, 3 ,7 ,8, 4];
        return lastWeeksCounts;
    }

    public int Today()
    {
        //* El operador ^1 accede al ultimo elemento de un array o coleccion dando el mismo resultado que: birdsPerDay[birdsPerDay.Length - 1]
        return birdsPerDay[^1];
    }
    
    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;

    }

    public bool HasDayWithoutBirds()
    {
        var existBirds = Array.FindIndex(this.birdsPerDay, b => b == 0);

        return existBirds != -1;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int index = 0;
        int countOfBirds = 0;
        
        foreach (var numberOfBirds in birdsPerDay)
        {
            System.Console.WriteLine(numberOfBirds);
            countOfBirds += numberOfBirds;
            index++;
            if(numberOfDays == index) break;
        }

        return countOfBirds;
    }


    public int BusyDays()
    {
        int countOfBusyDays = 0;

        foreach (var numberOfBirds in birdsPerDay)
        {
            if(numberOfBirds >= 5) countOfBusyDays++;
        }

        return countOfBusyDays;
    }
}