namespace EasyTest.Domain
{
    public class AdditionalInformation
    {
        public int Id { get; set; }
        public WeeklyAvailability WeeklyAvailability { get; set; }
        public PreferredPeriod PreferredPeriod { get; set; }
        public string HourlySalaryPretension { get; set; }
    }

    public class WeeklyAvailability
    {
        public bool UpTo4HoursPerDay { get; set; }
        public bool From4To6HoursPerDay { get; set; }
        public bool From6To8HoursPerDay { get; set; }
        public bool MoreThan8HoursPerDay { get; set; }
        public bool OnlyWeekends { get; set; }
    }

    public class PreferredPeriod
    {
        public bool MorningPeriod { get; set; }
        public bool AfternoonPeriod { get; set; }
        public bool NightPeriod { get; set; }
        public bool DawnPeriod { get; set; }
        public bool BusinessPeriod { get; set; }
    }
}
