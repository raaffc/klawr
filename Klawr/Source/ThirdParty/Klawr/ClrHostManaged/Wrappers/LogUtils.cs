﻿//
// The MIT License (MIT)
//
// Copyright (c) 2014 Vadim Macagon
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//

namespace Klawr.ClrHost.Managed{
    /// <summary>
    /// Logging functions that output text to the UE console and log file.
    /// </summary>
    public class LogUtils{
        private static LogUtilsProxy _proxy;

        internal LogUtils(ref LogUtilsProxy proxy){
            _proxy = proxy;
        }

        /// <summary>
        /// Print an error to the UE console and log file, then crash (even if logging is disabled).
        /// </summary>
        public static void LogFatalError(string text){
            _proxy.LogFatalError?.Invoke(text);
        }

        /// <summary>
        /// Print an error to the UE console and log file.
        /// </summary>
        public static void LogError(string text){
            _proxy.LogError?.Invoke(text);
        }

        /// <summary>
        /// Print a warning to the UE console and log file.
        /// </summary>
        public static void LogWarning(string text){
            _proxy.LogWarning?.Invoke(text);
        }

        /// <summary>
        /// Print a message to the UE console and log file.
        /// </summary>
        public static void Display(string text){
            _proxy.Display?.Invoke(text);
        }

        /// <summary>
        /// Print a message to the log file, but not to the UE console.
        /// </summary>
        public static void Log(string text){
            _proxy.Log?.Invoke(text);
        }

        /// <summary>
        /// Print a verbose message to a log file (if Verbose logging is enabled).
        /// </summary>
        public static void LogVerbose(string text){
            _proxy.LogVerbose?.Invoke(text);
        }

        /// <summary>
        /// Print a verbose message to a log file (if VeryVerbose logging is enabled).
        /// </summary>
        public static void LogVeryVerbose(string text){
            _proxy.LogVeryVerbose?.Invoke(text);
        }
    }
}