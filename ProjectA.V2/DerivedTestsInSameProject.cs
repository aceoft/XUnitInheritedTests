namespace ProjectA.V2
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