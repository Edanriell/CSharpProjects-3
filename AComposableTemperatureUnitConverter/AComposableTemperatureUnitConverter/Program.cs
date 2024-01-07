using AComposableTemperatureUnitConverter;

ITemperatureConverter[] converters =
{
    new FahrenheitConverter(),
    new KelvinConverter(),
    new CelsiusConverter()
};
var composableConverter = new ComposableTemperatureConverter(converters);

var celsius = new Temperature(20.00001, TemperatureUnit.C);

var celsius1 = composableConverter.Convert(celsius, TemperatureUnit.C);
var fahrenheit = composableConverter.Convert(celsius1, TemperatureUnit.F);
var kelvin = composableConverter.Convert(fahrenheit, TemperatureUnit.K);
var celsiusBack = composableConverter.Convert(kelvin, TemperatureUnit.C);

WriteLine($"{celsius} = {fahrenheit}");
WriteLine($"{fahrenheit} = {kelvin}");
WriteLine($"{kelvin} = {celsiusBack}");
