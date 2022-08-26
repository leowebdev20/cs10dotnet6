using System.Diagnostics;
using Microsoft.Extensions.Configuration;

Trace.Listeners.Add(new TextWriterTraceListener(
    File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "logs.txt"))
));

Trace.AutoFlush = true;

Debug.WriteLine("Debug: I am a debugger!"); //This won't appear in release configuration only in debug
Trace.WriteLine("Trace: I am a debugger!");

ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();
TraceSwitch ts = new(displayName: "PacktSwitch", description: "This switch is set via json config");

configuration.GetSection("PacktSwitch").Bind(ts);

Trace.WriteLineIf(ts.TraceError, "Trace Error");
Trace.WriteLineIf(ts.TraceWarning, "Trace Warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace Info");
Trace.WriteLineIf(ts.TraceVerbose, "Trace Verbose");
