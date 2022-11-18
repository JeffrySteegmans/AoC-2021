namespace AoC.Diagnostics
{
    public class ReportParser
    {
        private readonly List<string> _report;
        private int? _gammaRate;
        private int? _epsilonRate;
        private int? _oxygenGeneratorRating;
        private int? _co2ScrubberRating;

        public ReportParser(List<string> report)
        {
            _report = report;
        }

        public Task<int> CalculateGammaRate()
        {
            if (_gammaRate == null)
            {
                var gammaRateBitFormat = string.Empty;

                for (int i = 0; i < _report.FirstOrDefault()?.Length; i++)
                {
                    gammaRateBitFormat += GetMostCommonBit(i, _report);
                }

                _gammaRate = Convert.ToInt32(gammaRateBitFormat, 2);
            }

            return Task.FromResult(_gammaRate.Value);
        }

        public Task<int> CalculateEpsilonRate()
        {
            if (_epsilonRate == null)
            {
                var epsilonRateBitFormat = string.Empty;

                for (int i = 0; i < _report.FirstOrDefault()?.Length; i++)
                {
                    epsilonRateBitFormat += GetLeastCommonBit(i, _report);
                }

                _epsilonRate = Convert.ToInt32(epsilonRateBitFormat, 2);
            }

            return Task.FromResult(_epsilonRate.Value);
        }

        public async Task<int> CalculatePowerUsage()
        {
            var gammaRate = await CalculateGammaRate();
            var epsilonRate = await CalculateEpsilonRate();

            return gammaRate * epsilonRate;
        }

        public Task<int> CalculateOxygenGeneratorRating()
        {
            if (_oxygenGeneratorRating == null)
            {
                var filteredReport = _report;

                for (int i = 0; i < _report.FirstOrDefault()?.Length; i++)
                {
                    var mostCommonBit = GetMostCommonBit(i, filteredReport);
                    filteredReport = FilterBits(filteredReport, mostCommonBit, i);
                    if (filteredReport.Count == 1)
                    {
                        break;
                    }
                }

                _oxygenGeneratorRating = Convert.ToInt32(filteredReport.Single(), 2);
            }

            return Task.FromResult(_oxygenGeneratorRating.Value);
        }

        public Task<int> CalculateCo2ScrubberRating()
        {
            if (_co2ScrubberRating == null)
            {
                var filteredReport = _report;

                for (int i = 0; i < _report.FirstOrDefault()?.Length; i++)
                {
                    var mostCommonBit = GetLeastCommonBit(i, filteredReport);
                    filteredReport = FilterBits(filteredReport, mostCommonBit, i);
                    if (filteredReport.Count == 1)
                    {
                        break;
                    }
                }

                _co2ScrubberRating = Convert.ToInt32(filteredReport.Single(), 2);
            }

            return Task.FromResult(_co2ScrubberRating.Value);
        }

        public async Task<int> CalculateLifeSupportRating()
        {
            var oxygenGeneratorRating = await CalculateOxygenGeneratorRating();
            var co2ScrubberRating = await CalculateCo2ScrubberRating();

            return oxygenGeneratorRating * co2ScrubberRating;
        }

        private List<string> FilterBits(List<string> report, int bitValue, int position)
        {
            return report
                .Where(x => x[position].ToString() == bitValue.ToString())
                .ToList();
        }

        private static int GetMostCommonBit(int position, List<string> report)
        {
            int onCounter = 0;
            int offCounter = 0;

            foreach (var reportLine in report)
            {
                var bit = reportLine[position];

                if (bit == '1')
                {
                    onCounter++;
                }
                else
                {
                    offCounter++;
                }
            }

            return onCounter >= offCounter ? 1 : 0;
        }

        private static int GetLeastCommonBit(int position, List<string> report)
        {
            int onCounter = 0;
            int offCounter = 0;

            foreach (var reportLine in report)
            {
                var bit = reportLine[position];

                if (bit == '1')
                {
                    onCounter++;
                }
                else
                {
                    offCounter++;
                }
            }

            return onCounter < offCounter ? 1 : 0;
        }
    }
}
