class Subcommand{
    private string subcommandName;
    private string description;
    public delegate int Command(string[] args);
    private Command commandFunction;
    public Subcommand(string subcommandName,Command commandFunction, string description)
    {
        this.subcommandName=subcommandName;
        this.description=description;
        this.commandFunction=commandFunction;
    }

    public Command CommandFunction{get=>commandFunction;}
    public string SubcommandName{get=>subcommandName;}
    public string Description{get=>description;}
    
}
