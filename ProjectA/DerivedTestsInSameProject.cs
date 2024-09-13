namespace ProjectA
{
	public class DerivedTestsInSameProject : AbstractTests
	{
		[Fact]
		public void DirectTestInSameProject()
		{
			Assert.True(true);
		}
	}
}