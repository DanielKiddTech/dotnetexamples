// See https://aka.ms/new-console-template for more information
using dynamics_are_bad;

Console.WriteLine("Enter number of times to loop:");

string? timesToLoop = Console.ReadLine();

Console.WriteLine("Enter number of times to parallel threads:");

string? parallelThreads = Console.ReadLine();

int parsedParallelThreads = int.Parse(parallelThreads);
int parsedTimesToLoop = int.Parse(timesToLoop);

AppDomain.CurrentDomain.FirstChanceException += (sender, eventArgs) =>
{
    System.IO.File.AppendAllLines(".\\errorlog.txt",
                    new List<string> { $"{DateTime.Now.ToString("dd/MM/yy HH:mm:ss")}: {eventArgs.Exception.Message}. {eventArgs.Exception.StackTrace} {Environment.NewLine}" });

    Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yy HH:mm:ss")}: {eventArgs.Exception.Message}. {eventArgs.Exception.StackTrace} {Environment.NewLine}");
};

Process.Run(parsedTimesToLoop, parsedParallelThreads);