using Abstract;

namespace DerivedTests
{
	public class DerivedTests : AbstractTests
	{
		[Fact]
		public void DirectTestA()
		{
			Assert.True(true);
		}
	}
}