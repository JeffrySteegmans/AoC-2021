using System.ComponentModel;
using System.Globalization;

namespace AoC.Common.IO
{
    public static class InputHelper
    {
        public static async Task<List<T>> ReadTextFile<T>(string path)
        {
            var lines = await File.ReadAllLinesAsync(path);
            var parsedLines = new List<T>();

            foreach (string line in lines)
            {
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
                
                T parsedLine;
                try
                {
                    parsedLine = (T)converter.ConvertFromString(null, CultureInfo.InvariantCulture, line);
                }
                catch (Exception _)
                {
                    continue;
                }

                if (parsedLine != null)
                {
                    parsedLines.Add(parsedLine);
                }
            }

            return parsedLines;
        }
    }
}
