namespace TM
{
    internal class ConfigurationManager
    {
        public static string[] GetConfigurationPropertiesNames()
        {
            Type configurationType = typeof(Configuration);
            List<string> propertieNames = new List<string>();
            foreach (var field in configurationType.GetProperties())
            {
                propertieNames.Add(field.Name);
            }
            return propertieNames.ToArray();
        }

        public static Configuration GetConfigurationFromFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            Configuration configuration = new Configuration();
            for (int i = 0; i < lines.Length; i++)
            {
                string param, value;
                param = lines[i].Split('=')[0];
                value= lines[i].Split("=")[1];
                if (lines[i].StartsWith("Task"))
                {
                    //ToDo: add tasks parsing logic
                }
                foreach(var propertie in GetConfigurationPropertiesNames())
                {
                    if(propertie==param)
                    {
                        typeof(Configuration).GetProperty(propertie).SetValue(configuration, value);
                    }
                }
            }
            return configuration;
        }
    }
}
