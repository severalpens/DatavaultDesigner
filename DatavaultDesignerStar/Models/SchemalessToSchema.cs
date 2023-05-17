using System.IO;
using System.Linq;
using DatavaultDesignerStar.Pages;
using Microsoft.Extensions.Logging;

public class SchemalessToSchema
{

    private ILogger<AdfcView> Logger { get; set; }

    public SchemalessToSchema(ILogger<AdfcView> logger)
    {
        Logger = logger;
        Logger.LogInformation($"SchemalessToSchema");



        //var schemalessArray = JArray.Parse(File.ReadAllText("Schemaless.json"));

        //var objectArray = ConvertSchemalessArrayToObjectArray(schemalessArray);

        //Console.WriteLine(objectArray.ToString());
    }

    public void Run(string jsn)
    {


    }
}
