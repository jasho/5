﻿using System;

namespace CalculatorConsole
{
    partial class Program
    {
        internal class IncorrentCommandLineArguments : ArgumentException
        {
            private string _message;

            /// <summary>
            /// Auto-implemented property, uses autogenerated backing field
            /// </summary>
            private CommandLineOptions CmdLineCommandLineOptions { get; set; }

            /// <summary>
            /// Property with backing field, may add some inner functionality like input checking
            /// </summary>
            public new string Message
            {
                get { return _message; }
                set
                {
                    if (value == null)
                    {
                        _message = string.Empty;
                    }
                    _message = value;
                }
            }

            public IncorrentCommandLineArguments(string message, CommandLineOptions cmdLineCommandLineOptions): base(message)
            {
                CmdLineCommandLineOptions = cmdLineCommandLineOptions;
            }
        }
    }
}