﻿using Modding;

// ReSharper disable file UnusedMember.Global

namespace SeanprCore
{
    internal static class LogHelper
    {
        private static readonly SimpleLogger Logger = new SimpleLogger(nameof(SeanprCore));

        public static void Log(string message)
        {
            Logger.Log(message);
        }

        public static void Log(object message)
        {
            Logger.Log(message);
        }

        public static void LogDebug(string message)
        {
            Logger.LogDebug(message);
        }

        public static void LogDebug(object message)
        {
            Logger.LogDebug(message);
        }

        public static void LogError(string message)
        {
            Logger.LogError(message);
        }

        public static void LogError(object message)
        {
            Logger.LogError(message);
        }

        public static void LogFine(string message)
        {
            Logger.LogFine(message);
        }

        public static void LogFine(object message)
        {
            Logger.LogFine(message);
        }

        public static void LogWarn(string message)
        {
            Logger.LogWarn(message);
        }

        public static void LogWarn(object message)
        {
            Logger.LogWarn(message);
        }
    }
}
