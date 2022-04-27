using NUnit.Framework;
using TapeEquilibrium;

namespace TapeEquilibriumTests
{
	public class SolutionTests
	{
		private Solution _solution { get; set; } = null!;

		[SetUp]
		public void Setup()
		{
			_solution = new Solution();
		}

		[Test]
		public void TapeEquilibrium_Test1()
		{
			int result = _solution.solution(new int[] { 3, 1, 2, 4, 3 });
			Assert.AreEqual(1, result);
		}

		[Test]
		public void TapeEquilibrium_Test2()
		{
			int result = _solution.solution(new int[] { 5, 2, 7, 3, 4 });
			Assert.AreEqual(7, result);
		}

		[Test]
		public void TapeEquilibrium_Test3()
		{
			int result = _solution.solution(new int[] { 5, 7 });
			Assert.AreEqual(2, result);
		}
	}
}