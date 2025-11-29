public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool newYork = false;
        bool fake = false;
        string local = phoneNumber.Split("-")[2];

        if(string.IsNullOrEmpty(phoneNumber))
        {
            return (false, false, "");
        }

        var arrayNumber = phoneNumber.Split('-');

        if(arrayNumber[0] == "212") newYork = true;

        if(arrayNumber[1] == "555") fake = true;
        return (newYork, fake, local);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
