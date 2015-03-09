# vstest.diag - Diagnostic tool for the Visual Studio Unit Test platform

[![Build status](https://ci.appveyor.com/api/projects/status/spe9wpff038fcb6p?svg=true)](https://ci.appveyor.com/project/codito/vstest-diag)

This tool enables diagnostic log collection for various unit test framework components. It modifies configuration files (*.exe.config) of several binaries in VS install directory, please remember to run `vstest.diag /disableLogs` after log collection is complete. 

## Installation
Get the latest release from [here](https://github.com/codito/vstest.diag/releases). Unzip it to `c:\tmp\vstest.diag`.

## Usage

```
$ # open VS Developer Command Prompt
$ cd c:\tmp\vstest.diag
$ vstest.diag /enableLogs
$ # run your tests
$ # for example, vstest.console.exe mytests.dll /settings:my.runsettings /logger:trx
$ vstest.diag /disableLogs
$ # analyze/share the logs for diagnosis
```

### Options

/EnableLogs     Enables various diagnostic logs for unit test framework. 

    Post this you can execute the test platform scenarios, the details will be captured by the logs.
    Run this tool again with /DisableLogs to stop collecting the verbose logs.
    Leaving logs enabled will cause slow performance.

/DisableLogs    Disables the logs if enabled earlier.

# Share the logs
Copy following logs from %temp% and share them for diagnosis:

* DiagnosticsLog.txt (The log for this tool)
* WCFEtwTrace.etl (WCF log)
* *.TpTrace.log

## License
Apache License v2.0.

## Development
Clone the project, run `nuget restore`, patch and send a pull request!

We (VS Unit Testing team at Microsoft) developed this tool as a side project. It
collates the numerous diagnostics switches for test platform from various MSDN
blog posts into a single tool.

Hope it helps! <3
