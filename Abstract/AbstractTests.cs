namespace Abstract
{
	public abstract class AbstractTests
	{
		[Fact]
		public void InheritedTestA()
		{
			Assert.True(true);
		}

		[Fact]
		public void InheritedTestB()
		{
			Assert.True(false);
		}
	}
}