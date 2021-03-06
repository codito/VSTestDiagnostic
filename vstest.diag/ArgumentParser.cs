﻿namespace VSTest.Diag
{
    public class ArgumentParser
    {
        public DiagnosticTask Parse(string args)
        {
            var t = DiagnosticTask.Help;
            switch (args.ToLower())
            {
                default:
                case "/Help":
                    t = DiagnosticTask.Help;
                    break;

                case "/enablelogs":
                    t = DiagnosticTask.EnableLogs;
                    break;

                case "/disablelogs":
                    t = DiagnosticTask.DisableLogs;
                    break;

                case "/runtests":
                    t = DiagnosticTask.RunTests;
                    break;
            }
            return t;
        }
    }
}