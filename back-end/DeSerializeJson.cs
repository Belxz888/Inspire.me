using System.Text.Json;

namespace Main
{
    public class Deserialize : Program
    {
        public static void DeserializeMain()
        {
            string jsonDeString =
            @"{
            ""Date"": ""2019-08-01T00:00:00-07:00"",
            ""TemperatureCelsius"": 25,
            ""Summary"": ""Hot""
            }
            ";

            File.WriteAllText("JsonDeSerialize.json", jsonDeString);
            Console.WriteLine(jsonDeString);  
        }
    }
}