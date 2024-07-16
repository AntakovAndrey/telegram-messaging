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
        new Subcommand("show","Shows client configuration."),
        new Subcommand("showchats","Shows client's chats."),
        new Subcommand("showtasks","Shows all tasks applied to client."),
        new Subcommand("genconf","Create config."),
        new Subcommand("setconf","Applies a configuration file."),
        new Subcommand("set","Change the current configuration.")
    };
    public static void ShowHelp()
    {
        Console.Write("Usage: <cmd> [<args>]\n\n");
        Console.Write("Available subcommands:\n");
        foreach(var subcommand in subcommands)
        {
            Console.WriteLine($"{subcommand.SubcommandName}: {subcommand.Description}");
        }
        Console.WriteLine("\nYou may pass --help to any of this subcommands to view usage.");
    }
    public static int Main(string[] args)
    {
        Console.ForegroundColor=ConsoleColor.Gray;
        if(args.Length==0)
        {
            ShowHelp();
            return 1;
        }
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
        foreach(var subcommand in subcommands)
        {
            if(subcommand.SubcommandName==args[0])
            {
                Console.WriteLine(subcommand.Description);
                return 0;
            }
        }
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Invalid subcommand "+args[0]+"\n");
        Console.ForegroundColor = ConsoleColor.Gray;
        ShowHelp();

        return 1;
    }
}