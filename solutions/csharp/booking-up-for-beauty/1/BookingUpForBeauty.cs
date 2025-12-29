static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        var dateValue = DateTime.Parse(appointmentDateDescription);
        return dateValue;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        var currentDate = DateTime.Now;
        
        return appointmentDate < currentDate;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
       return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
         return $"You have an appointment on {appointmentDate}.";
    }

    public static DateTime AnniversaryDate()
    {
        var dateTime =  DateTime.Now;

        return new DateTime(dateTime.Year, 9, 15, 0, 0, 0);
    }
}
