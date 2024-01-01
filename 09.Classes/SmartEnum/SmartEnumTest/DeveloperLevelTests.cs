using Ardalis.SmartEnum;
using FluentAssertions;

namespace SmartEnumTest;

public class DeveloperLevelTests
{
	[Theory]
	[InlineData("Junior", 75)]
	[InlineData("Regular", 125)]
	[InlineData("Senior", 175)]
	public void GivenValidLevel_WhenDeveloperIsCreated_ThenCorrectProductivityIsReturned(string level, double productivity)
	{
		var dev = DeveloperLevel.FromName(level);

		dev.Should().NotBeNull();
		dev.Productivity.Should().Be(productivity);
	}

	[Fact]
	public void GivenInvalidLevel_WhenDeveloperIsCreated_ThenSmartEnumNotFoundExceptionIsThrown()
	{
		Action action = () => DeveloperLevel.FromName("Developer");

		action.Should().Throw<SmartEnumNotFoundException>();
	}
}