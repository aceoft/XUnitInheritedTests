using ProjectA.V3;

namespace ProjectB.V3
{
	public class DerivedTestsInDifferentProject : AbstractTests
	{
		[Fact]
		public void DirectTest()
		{
			Assert.True(true);
		}
	}
}