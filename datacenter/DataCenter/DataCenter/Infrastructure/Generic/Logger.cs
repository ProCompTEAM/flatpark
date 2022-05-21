﻿using System;
using System.IO;
using DataCenter.Common;
using DataCenter.Infrastructure.Generic.Interfaces;
using DataCenter.Infrastructure.Providers;
using DataCenter.Infrastructure.Providers.Interfaces;

namespace DataCenter.Infrastructure.Generic
{
    class Logger : ILogger
    {
        private const ConsoleColor DefaultConsoleColor = ConsoleColor.White;

        private IDateTimeProvider dateTimeProvider;

        public Logger()
        {
            dateTimeProvider = Resolver.Container.Resolve<DateTimeProvider>();
        }

        public void Info(string message, string prefix = "Info", ConsoleColor color = DefaultConsoleColor)
        {
            SetConsoleColor(color);

            string generatedMessage = $"[{dateTimeProvider.Now}][{prefix}] {message}";

            Console.WriteLine(generatedMessage);
            SaveToFile(generatedMessage, Defaults.LogFilename);
        }

        public void Error(string message)
        {
            Info(message, "Error", ConsoleColor.Red);
        }

        private void SetConsoleColor(ConsoleColor color)
        {
            if (Console.ForegroundColor == color)
            {
                return;
            }

            Console.ForegroundColor = color;
        }

        private void SaveToFile(string logMessage, string fileName)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(logMessage);
            }
        }
    }
}
