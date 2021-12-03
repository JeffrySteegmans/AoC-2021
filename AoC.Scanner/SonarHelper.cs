namespace AoC.Scanner
{
    public static class SonarHelper
    {
        public static Task<int> DepthMeasurementIncreases(List<int> measurements)
        {
            var numberOfIncreases = 0;
            int previousMeasurement = measurements.FirstOrDefault();

            foreach(var measurement in measurements)
            {
                if (measurement > previousMeasurement)
                {
                    numberOfIncreases++;
                }

                previousMeasurement = measurement;
            }

            return Task.FromResult(numberOfIncreases);
        }

        public static Task<List<int>> CalculateThreeMeasurementSums(List<int> measurements)
        {
            var threeMeasurementsSum = new List<int>();

            for (int i = 0; i < measurements.Count; i++)
            {
                if (i + 2 >= measurements.Count)
                {
                    break;
                }

                var measurement1 = measurements[i];
                var measurement2 = measurements[i+1];
                var measurement3 = measurements[i+2];

                var sum = measurement1 + measurement2 + measurement3;

                threeMeasurementsSum.Add(sum);
            }

            return Task.FromResult(threeMeasurementsSum);
        }
    }
}
