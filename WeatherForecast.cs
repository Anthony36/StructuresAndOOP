using System;

namespace ProgrammingPractices
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }
        //Farenheit to celcius: c = 5(f - 32)/9
        //pg 7 of data structures book
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
