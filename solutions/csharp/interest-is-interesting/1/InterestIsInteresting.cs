static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float rate = 0.0f;
        
        if(balance < 0)
        {
            rate = 3.213f;
        }else if(balance < 1000)
        {
            rate = 0.5f;
        }else if ((balance >= 1000) && (balance < 5000) )
        {
            rate = 1.621f;
        }else if(balance >= 5000)
        {
            rate = 2.475f;
        }


        return rate;
    }

    public static decimal Interest(decimal balance)
    {
        float interestPercentage = InterestRate(balance) / 100;
        decimal valuePercentage = (decimal)interestPercentage * balance;
        return valuePercentage;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal interest = Interest(balance);

        return balance + interest;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
