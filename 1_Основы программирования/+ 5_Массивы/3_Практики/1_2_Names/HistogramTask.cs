using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var xLabels = new string[31];

            for (int i = 0; i < xLabels.Length; i++)
                xLabels[i] = (i+1).ToString();

            var yValues = new double[31];

            foreach (var _name in names)
                if (_name.BirthDate.Day != 1 && _name.Name == name)
                    yValues[_name.BirthDate.Day - 1]++;

            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name),
                xLabels,
                yValues);
        }
    }
}