using System;
using System.Collections;

namespace PTM.Infos
{
	/// <summary>
	/// Descripción breve de ApplicationLog.
	/// </summary>
	public class ApplicationLog
	{
		public ApplicationLog()
		{
		}

		public int ActiveTime
		{
			get { return activeTime; }
			set { activeTime = value; }
		}

		public string Caption
		{
			get { return caption; }
			set { caption = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public string ApplicationFullPath
		{
			get { return applicationFullPath; }
			set { applicationFullPath = value; }
		}

		int activeTime;
		string caption;
		string name;
		int id;
		string applicationFullPath;

		public int TaskLogId
		{
			get { return taskLogId; }
			set { taskLogId = value; }
		}

		public int ProcessId
		{
			get { return processId; }
			set {processId = value; }
		}

		public DateTime LastUpdateTime
		{
			get { return lastUpdateTime; }
			set { lastUpdateTime= value; }
		}

		int taskLogId;
		int processId;
		DateTime lastUpdateTime;


		
	}
}
