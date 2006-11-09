using NUnit.Framework;
using PTM.Framework;
using PTM.Data;

namespace PTM.Test.Business
{
	/// <summary>
	/// Descripci�n breve de DefaultTasksTest.
	/// </summary>
	[TestFixture]
	public class DefaultTasksTest
	{
		public DefaultTasksTest()
		{
		}

		[SetUp]
		public void SetUp()
		{
			DbHelper.Initialize("test");
			DbHelper.DeleteDataSource();
			PTMDataset ds = new PTMDataset();
			MainModule.Initialize(ds, "test");
		}

		[Test]
		public void InitializeTest()
		{
			Assert.IsTrue(DefaultTasks.Table.Count > 0);
		}

		[TearDown]
		public void TearDown()
		{
			Logs.StopLogging();
			DbHelper.DeleteDataSource();
		}
	}
}