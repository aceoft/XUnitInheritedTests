﻿namespace ProjectA.V2
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