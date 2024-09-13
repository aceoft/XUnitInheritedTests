namespace ProjectA.V3
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