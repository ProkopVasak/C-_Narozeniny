
Console.Write("Zadejte datum narození (ve formátu DD.MM.RRRR): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

  
int age = DateTime.Now.Year - birthDate.Year;
if (DateTime.Now.Month < birthDate.Month || (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
{
        age--;
}
Console.WriteLine("Je Vám {0} let.", age);

TimeSpan ageTimeSpan = DateTime.Now - birthDate;
int years = ageTimeSpan.Days / 365;
int months = (ageTimeSpan.Days % 365) / 30;
int days = ageTimeSpan.Days % 30;
int hours = ageTimeSpan.Hours;
int minutes = ageTimeSpan.Minutes;
Console.WriteLine("Staráte se {0} let, {1} měsíců, {2} dnů, {3} hodin a {4} minut.", years, months, days, hours, minutes);


TimeSpan ageDuration = DateTime.Now - birthDate;
long totalDays = ageDuration.Days;
long totalSeconds = Convert.ToInt64(ageDuration.TotalSeconds);
long totalTicks = ageDuration.Ticks;
Console.WriteLine("Bylo Vám {0} dní, {1} vteřin a {2} tiků.", totalDays, totalSeconds, totalTicks);

DateTime nextBirthday = birthDate.AddYears(age + 1);
TimeSpan daysUntilNextBirthday = nextBirthday - DateTime.Today;
Console.WriteLine("Do Vašich dalších narozenin zbývá {0} dní.", daysUntilNextBirthday.Days);

   
int daysUntilNext1000days = ((DateTime.Today - birthDate).Days / 1000 + 1) * 1000 - (DateTime.Today - birthDate).Days;
Console.WriteLine("Do Vašich dalších 1000denní zbývá {0} dní.", daysUntilNext1000days);

Console.ReadLine();
