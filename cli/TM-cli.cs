class Program{
    public static int Main(string[] args)
    {
        Console.ForegroundColor=ConsoleColor.Gray;
        if(args.Length==0)
        {
            Terminal.ShowSubcommands();
            return 1;
        }
        if(args.Length==1&&(args[0]=="-v"||args[0]=="version"||args[0]=="--version"))
        {
            Console.WriteLine("Telegram-messaging CLI\nv 1.0.0");
            return 0;
        }
        if(args.Length==1&&(args[0]=="-h"||args[0]=="help"||args[0]=="--help"))
        {
            Terminal.ShowSubcommands();
            return 0;
        }
        foreach(var subcommand in Terminal.subcommands)
        {
            if(subcommand.SubcommandName==args[0])
            {
                return subcommand.CommandFunction(args.Skip(1).ToArray());
            }
        }
        Terminal.ShowError("Invalid subcommand "+args[0]+"\n");
        Terminal.ShowSubcommands();
        return 1;
    }
}