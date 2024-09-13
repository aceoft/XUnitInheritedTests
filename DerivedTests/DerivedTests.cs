using Abstract;

namespace DerivedTests
{
	public class DerivedTests : AbstractTests
	{
		[Fact]
		public void DirectTest()
		{
			Assert.True(true);
		}
	}
}