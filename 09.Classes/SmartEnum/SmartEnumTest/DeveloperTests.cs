using FluentAssertions;

namespace SmartEnumTest;

public class DeveloperTests
{
	[Fact]
	public void GivenValidParameters_WhenConstructorIsInvoked_ThenValidObjectIsCreated()
	{
		string name = "Regular";
		var level = DeveloperLevel.Regular;

		var developer = new Developer(name, level);

		developer.Should().NotBeNull();
		developer.Name.Should().Be(name);
		developer.Level.Should().Be(level);
		developer.Level.Productivity.Should().Be(level.Productivity);
	}

	[Fact]
	public void GivenValidParameters_WhenWriteCodeIsInvoked_ThenValidResultIsReturned()
	{
		string name = "Senior";
		var level = DeveloperLevel.Senior;
		var linesOfCode = 500;

		var developer = new Developer(name, level);

		developer.WriteCode(linesOfCode).Should().Be(linesOfCode / developer.Level.Productivity);
	}
}