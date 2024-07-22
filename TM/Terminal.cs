class Terminal{
    public static Subcommand[] subcommands={
        new Subcommand("show", Show,"Shows client configuration."),
        new Subcommand("showchats",Show,"Shows client's chats."),
        new Subcommand("showtasks",Show,"Shows all tasks applied to client."),
        new Subcommand("genconf",Show,"Create config."),
        new Subcommand("setconf",Show,"Applies a configuration file."),
        new Subcommand("set",Show,"Change the current configuration."),
        new Subcommand("start",Show,"Starts the selected client with it's tasks.")
    };

    public static int Show(string[] args)
    {
        if(args.Length==0)
        {
            Console.Write("No arguments!\n");   
        }
        if(args.Length==1&&(args[0]=="-h"||args[0]=="help"||args[0]=="--help"))
        {
            ShowSubcommandShowHelp();
            return 0;
        }
        Console.WriteLine("Showing you some shit!");
        return 0;
    }

    public static void ShowError(string errorMessage)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine(errorMessage);
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
        Console.Write("Usage: show [filename]\n");
        Console.Write("Show command allows you to see the client's config stored in a configuration file");
    }
}