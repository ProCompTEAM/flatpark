using DataCenter.Infrastructure.Subcomponents.Interfaces;
using DataCenter.Infrastructure.Providers;
using DataCenter.Infrastructure.Providers.Interfaces;

namespace DataCenter.Infrastructure.Subcomponents
{
    public class CrashLogger : ICrashLogger
    {
        private const ConsoleColor DefaultCrashColor = ConsoleColor.DarkRed;
        private const string CrashFolder = "./dumps";

        private IDateTimeProvider dateTimeProvider;

        public CrashLogger()
        {
            dateTimeProvider = Module.Container.Resolve<DateTimeProvider>();

            Directory.CreateDirectory(CrashFolder);
        }

        public void Crash(string description, string[] traces)
        {
            string errorMessage = GenerateErrorMessage(description, traces);

            SetConsoleColor(DefaultCrashColor);

            Console.WriteLine(errorMessage);

            SaveCrash(errorMessage);
        }

        private string GenerateErrorMessage(string description, string[] traces)
        {
            string result = $"[{dateTimeProvider.Now}][Crash] {description}";

            foreach(var trace in traces)
            {
                result += $"\n - {trace}";
            }

            return result;
        }

        private void SetConsoleColor(ConsoleColor color)
        {
            if (Console.ForegroundColor == color) 
            {
                return;
            }

            Console.ForegroundColor = color;
        }

        private void SaveCrash(string message)
        {
            string filename = GenerateCrashFilename();

            using StreamWriter sw = File.AppendText(filename);
            sw.WriteLine(message);
        }

        private string GenerateCrashFilename()
        {
            DateTime now = dateTimeProvider.Now;

            string filename = $"{now.Month}.{now.Day} {now.Hour}-{now.Minute}-{now.Second}";

            return $"{CrashFolder}/{filename}.txt";
        }
    }
}