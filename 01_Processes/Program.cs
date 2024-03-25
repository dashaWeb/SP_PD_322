using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Process current = Process.GetCurrentProcess();
        current.PriorityClass = ProcessPriorityClass.High;
        Console.WriteLine("------ Current process info -------------");
        Console.WriteLine($"PriorityClass :: {current.PriorityClass}");
        Console.WriteLine($"ProcessName :: {current.ProcessName}");
        Console.WriteLine($"Id :: {current.Id}");
        Console.WriteLine($"MachineName :: {current.MachineName}");
        Console.WriteLine($"PrivateMemorySize(kb) :: {current.PrivateMemorySize64 / 1024}");
        Console.WriteLine($"StartTime :: {current.StartTime}");
        Console.WriteLine($"TotalProcessorTime :: {current.TotalProcessorTime}");
        Console.WriteLine($"UserProcessorTime :: {current.UserProcessorTime}");
        Console.ReadKey();*/

        // All Processes
        /*Process[] processes = Process.GetProcesses();
        foreach (var p in processes)
        {
            try
            {
                Console.WriteLine($"{p.ProcessName,-20} {p.Id,-5} {p.PriorityClass,-10} {p.StartTime}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error with {p.ProcessName}");
                Console.ResetColor();
            }
        }
        Console.ReadKey();*/

        // Start Processe

        //Process.Start("Calc.exe");
        //Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "google.com stackoverflow.com");
        ProcessStartInfo info = new ProcessStartInfo()
        {
            FileName = "notepad",
            Arguments = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\777.txt",
            WindowStyle = ProcessWindowStyle.Maximized
        };
        Process pr = Process.Start(info);
        Console.ReadKey();

        //pr.Close(); // clear resources
        pr.CloseMainWindow(); // alt + F4
        //pr.Kill();
        Console.WriteLine("Wait for exit ...");
        pr.WaitForExit();
        Console.WriteLine("Process was exited");
        Console.WriteLine($"ExitCode :: {pr.ExitCode}");
        Console.WriteLine($"ExitTime :: {pr.ExitTime}");
    }
}