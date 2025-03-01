namespace LeetCodeDotNet.Assessments
{
    /// <summary>
    /// https://leetcode.com/assessment/1/
    /// Returns: "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
    /// </summary>
    public class DayOfWeek1
    {
        public string DayOfTheWeek(int day, int month, int year)
        {
            var date = new DateOnly(year, month, day);

            return date.DayOfWeek.ToString();
        }
    }
}
