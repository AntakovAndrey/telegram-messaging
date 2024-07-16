using System.Drawing;

class Subcommand{
    private string subcommandName;
    private string description;
    
    public Subcommand(string subcommandName,string description)
    {
        this.subcommandName=subcommandName;
        this.description=description;
    }

    public string SubcommandName{get=>subcommandName;}
    public string Description{get=>description;}
}

class Program{
    private static Subcommand[] subcommands={
        new Subcommand("show",""),
        new Subcommand("",""),
    };
    public static void ShowHelp()
    {
        Console.Write("Usage: <cmd> [<args>]\n\n");
        foreach(var subcommand in subcommands)
        {
            Console.WriteLine($"{subcommand.SubcommandName} {subcommand.Description}");
        }
        Console.WriteLine("You may pass --help to any of this subcommands to view usage.");
    }
    public static int Main(string[] args)
    {
        if(args.Length==1&&(args[0]=="-v"||args[0]=="version"||args[0]=="--version"))
        {
            Console.WriteLine("Telegram-messaging CLI\nv 1.0.0");
            return 0;
        }
        if(args.Length==1&&(args[0]=="-h"||args[0]=="help"||args[0]=="--help"))
        {
            ShowHelp();
            return 0;
        }
        
        var defaultColor = Console.ForegroundColor;
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Invalid subcommand "+args[0]);
        Console.ForegroundColor = defaultColor;
        ShowHelp();

        return 1;
    }
}