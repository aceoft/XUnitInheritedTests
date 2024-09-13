namespace ProjectA.MSTest
{
	[TestClass]
	public class DerivedTestsInSameProject : AbstractTests
	{
		[TestMethod]
		public void DirectTestInSameProject()
		{
			Assert.IsTrue(true);
		}
	}
}