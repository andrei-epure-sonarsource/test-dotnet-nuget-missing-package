using Newtonsoft.Json;

var readings = new[]
{
    new Reading("Berlin", 18.4m),
    new Reading("Zurich", 16.9m),
    new Reading("Paris", 20.1m)
};

var warmest = readings.MaxBy(x => x.Celsius)!;
Console.WriteLine(JsonConvert.SerializeObject(warmest));

internal sealed record Reading(string City, decimal Celsius);
