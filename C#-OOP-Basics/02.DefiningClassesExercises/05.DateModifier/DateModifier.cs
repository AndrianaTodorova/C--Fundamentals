using System;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

public class DateModifier
{
    public static double GetDifference(string first, string second)
    {
        var firstDate = DateTime.ParseExact(first, "yyyy MM dd", CultureInfo.InvariantCulture);
        var secondDate = DateTime.ParseExact(second, "yyyy MM dd", CultureInfo.InvariantCulture);

        if (firstDate > secondDate)
        {
            return GetDifference(second, first);
        }

        return (secondDate - firstDate).Days;
    }
}
