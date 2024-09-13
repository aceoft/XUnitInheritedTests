using ProjectA.V2;

namespace ProjectB.V2
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