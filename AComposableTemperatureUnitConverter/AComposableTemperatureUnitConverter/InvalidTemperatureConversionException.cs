namespace AComposableTemperatureUnitConverter
{
    public class InvalidTemperatureConversionException : Exception
    {
        public InvalidTemperatureConversionException(TemperatureUnit unitTo)
            : base($"No supported conversion to {unitTo}") { }
    }
}
