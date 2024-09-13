using ProjectA;

namespace ProjectB
{
	public class DerivedTestsInDifferentProject : AbstractTests
	{
		[Fact]
		public void DirectTestInDifferentProject()
		{
			Assert.True(true);
		}
	}
}