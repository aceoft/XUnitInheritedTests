namespace ProjectA.MSTest
{
	[TestClass]
	public abstract class AbstractTests
	{
		[TestMethod]
		public void InheritedTest()
		{
			Assert.IsTrue(true);
		}
	}
}