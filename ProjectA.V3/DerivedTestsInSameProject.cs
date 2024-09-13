namespace ProjectA.V3
{
	public class DerivedTestsInSameProject : AbstractTests
	{
		[Fact]
		public void DirectTest()
		{
			Assert.True(true);
		}
	}
}