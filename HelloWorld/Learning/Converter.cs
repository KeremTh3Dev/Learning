using System;

namespace Learning
{
    public static class Converter
    {
        public static float CelsiusToFahrenheit(float celsius)
        {
            return (1.8f * celsius) + 32;
        }
        public static float FahrenheitToCelsius(float fahrenheit)
        {
            return (fahrenheit - 32) / 1.8f;
        }
        public static float KilometerToMile(float kilometer)
        {
            return kilometer * 0.621371f;
        }
        public static float MileToKilometer(float mile)
        {
            return mile * 1.60934f;
        }
    }
}
