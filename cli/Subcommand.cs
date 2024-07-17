class Subcommand{
    private string subcommandName;
    private string description;
    private Command commandFunction;
    public delegate int Command(string[] args);
    public Command CommandFunction{get=>commandFunction;}
    public string SubcommandName{get=>subcommandName;}
    public string Description{get=>description;}
    public Subcommand(string subcommandName,Command commandFunction, string description)
    {
        this.subcommandName=subcommandName;
        this.description=description;
        this.commandFunction=commandFunction;
    }
}