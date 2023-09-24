using Microsoft.Extensions.Configuration;


namespace SpecFlowIndividualProject.Support
{
    public class ReadJsonData
    {
        public IConfigurationRoot configuration;
        public ReadJsonData()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("jsconfig.json");
            configuration = builder.Build();
        }

        public string readData(string Key) => configuration[Key]!;
    }
}
