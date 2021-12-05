namespace AoC.Diagnostics
{
    public class ReportParser
    {
        private readonly List<string> _report;
        private int? _gammaRate;
        private int? _epsilonRate;

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
                    gammaRateBitFormat += GetMostCommonBit(i);
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
                    epsilonRateBitFormat += GetLeastCommonBit(i);
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

        private int GetMostCommonBit(int position)
        {
            int onCounter = 0;
            int offCounter = 0;

            foreach (var reportLine in _report)
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

            return onCounter > offCounter ? 1 : 0;
        }

        private int GetLeastCommonBit(int position)
        {
            int onCounter = 0;
            int offCounter = 0;

            foreach (var reportLine in _report)
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
