using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var xLabels = new string[30];
            var yLabels = new string[12];
            var heat = new double[xLabels.Length, yLabels.Length];

            for (int i = 0; i < xLabels.Length; i++)
                xLabels[i] = (i + 2).ToString();

            for (int i = 0; i < yLabels.Length; i++)
                yLabels[i] = (i + 1).ToString();

            for (int i = 0; i < names.Length; i++)
                if (names[i].BirthDate.Day != 1)
                    heat[names[i].BirthDate.Day - 2, names[i].BirthDate.Month - 1]++;

            return new HeatmapData(
                "Пример карты интенсивностей",
                heat,
                xLabels,
                yLabels);
        }
    }
}