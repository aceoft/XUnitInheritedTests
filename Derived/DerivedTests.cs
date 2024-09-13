using Abstract;

namespace Derived
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