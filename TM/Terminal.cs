class Terminal{
    public static Subcommand[] subcommands={
        new Subcommand("show", onShow,"Shows client configuration."),
        new Subcommand("showchats",onShow,"Shows client's chats."),
        new Subcommand("showtasks",onShow,"Shows all tasks applied to client."),
        new Subcommand("genconf",onShow,"Create config."),
        new Subcommand("setconf",onShow,"Applies a configuration file."),
        new Subcommand("set",onShow,"Change the current configuration."),
        new Subcommand("start",onStart,"Starts the selected client with it's tasks.")
    };

    public static int onShow(string[] args)
    {
        if(args.Length==0)
        {
            Console.Write("No arguments!\n");  
            return -1; 
        }
        if(args.Length==1&&(args[0]=="-h"||args[0]=="help"||args[0]=="--help"))
        {
            ShowSubcommandShowHelp();
            return 0;
        }
        Console.WriteLine("Showing you some shit!");
        return 0;
    }

    public static int onStart(string[] args){
        if(args.Length==0)
        {
            Console.Write("No arguments!\n");
            return -1;
        }
        if(args.Length==1&&(args[0]=="-h"||args[0]=="help"||args[0]=="--help"))
        {
            StartSubcommandShowHelp();
            return 0;
        }
        if(args.Length==1)
        {
            if(!File.Exists(args[0]))
            {
                ShowError("File not exists or you typed the wrong parameter.\n\n");
                ShowSubcommands();
                return 1;
            }
            

            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);
            
            return 0;
        }
        ShowSubcommands();
        return 1;
    }

    public static void ShowError(string errorMessage)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.Write(errorMessage);
        Console.ForegroundColor=ConsoleColor.Gray;
    }

    public static void ShowSubcommands()
    {
        Console.Write("Usage: <cmd> [<args>]\n\n");
        Console.Write("Available subcommands:\n");
        foreach(var subcommand in subcommands)
        {
            Console.WriteLine($"{subcommand.SubcommandName}: {subcommand.Description}");
        }
        Console.WriteLine("\nYou may pass --help to any of this subcommands to view usage.");
    }

    public static void ShowSubcommandShowHelp()
    {
        Console.Write("Usage: show [PATH|FILENAME]\n");
        Console.Write("Show command allows you to see the client's config stored in a configuration file.");
    }

    public static void StartSubcommandShowHelp()
    {
        Console.Write("Usage: start [PATH|FILENAME]");
    }
}