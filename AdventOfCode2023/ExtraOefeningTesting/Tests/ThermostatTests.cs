using Classes;

namespace Tests
{
	public class ThermostatTests
	{
		[Fact]
		public void IfSetpointPlusOffsetIsLowerThanCurrenTempSetHeatingOff()
		{
			IThermometer thermometer = new Mock<IThermometer>();
			Classes.Thermostat.
		}
		[Fact]
		public void IfSetpointMinusOffsetIsHigherThanCurrenTempSetHeatingOn()
		{

		}
		[Fact]
		public void IfTemperatureReadingFailsMoreThan2TimesInARowSetHeatingOff()
		{

		}
	}
}