class Configuration{
    public string ApiHash{get=>apiHash;set{apiHash=value;}}
    public string ApiId{get=>apiId;set{apiId=value;}}
    private string id;
    private string apiHash;
    private string apiId;
    private string phoneNumber;
    private string session;
    public Configuration()
    {

    }

    public static Configuration GetConfigurationFromFile(string filename)
    {
        return new Configuration();
    }

    public static bool IsFileAvailable(string filename)
    {
        return true;
    }

    
}