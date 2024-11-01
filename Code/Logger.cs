﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Colossal.Logging;


namespace IndustriesExtendedDLC
{
    public static class Logger
    {
        private static ILog _log = LogManager.GetLogger($"{nameof(IndustriesExtendedDLC)}.{nameof(Mod)}");
        public static DateTime nextLogTime = DateTime.MinValue;

        public static void Info(string message, [CallerMemberName] string methodName = null)
        {
            _log.Info(message);
        }

        [Conditional("DEBUG_TOOL")]
        public static void DebugTool(string message)
        {
            _log.Info(message);
        }

        [Conditional("DEBUG_CONNECTIONS")]
        public static void DebugConnections(string message)
        {
            _log.Info(message);
        }

        [Conditional("DEBUG_CONNECTIONS_SYNC")]
        public static void DebugConnectionsSync(string message)
        {
            _log.Info(message);
        }

        [Conditional("DEBUG")]
        public static void Debug(string message)
        {
            _log.Info(message);
        }

        [Conditional("DEBUG_LOCALE")]
        public static void DebugLocale(string message)
        {
            _log.Info(message);
        }

        [Conditional("DEBUG")]
        public static void DebugError(string message)
        {
            _log.Error(message);
        }

        [Conditional("DEBUG_LANE_SYS")]
        public static void DebugLaneSystem(string message)
        {
            _log.Info(message);
        }

        [Conditional("SERIALIZATION")]
        public static void Serialization(string message)
        {
            _log.Info(message);
        }

        public static void Warning(string message)
        {
            _log.Warn(message);
        }

        public static void Error(string message)
        {
            _log.Error(message);
        }
    }
}