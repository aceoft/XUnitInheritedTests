using ProjectA.MSTest;

namespace ProjectB.MSTest
{
	[TestClass]
	public class DerivedTestsInDifferentProject : AbstractTests
	{
		[TestMethod]
		public void DirectTestInDifferentProject()
		{
			Assert.IsTrue(true);
		}
	}
}