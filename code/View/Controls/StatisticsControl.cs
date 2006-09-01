using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using PTM.Business;
using PTM.Data;
using PTM.View.Controls.TreeListViewComponents;
using PTM.View.Forms;

namespace PTM.View.Controls
{
	/// <summary>
	/// Summary description for Statistics.
	/// </summary>
	public class StatisticsControl : UserControl
	{
		private TreeListView applicationsList;
		private ColumnHeader colName;
		private ColumnHeader colActiveTime;
		private ColumnHeader colProcessId;
		private Label label3;
		private GroupBox groupBox3;
		private GroupBox groupBox4;
		private Label label1;
		private ColumnHeader colAppPercent;
		private Label label8;
		private DateTimePicker dateTimePicker;
		private Label totalTasksLoggedValue;
		private Label AppsActiveTimeValue;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.ComboBox parentTaskComboBox;
		private System.Windows.Forms.Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		private PTMDataset.TasksDataTable parentTasksTable = new PTMDataset.TasksDataTable();

		public StatisticsControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			ManagementDataset.ConfigurationRow[] defaultgroups = ConfigurationHelper.GetExistingGroups();
			foreach (ManagementDataset.ConfigurationRow defaultgroup in defaultgroups)
			{
				PTMDataset.TasksRow parentTaskRow;
				parentTaskRow = parentTasksTable.NewTasksRow();
				PTMDataset.TasksRow taskRow;
				taskRow = Tasks.FindById(Convert.ToInt32(defaultgroup.ConfigValue,CultureInfo.InvariantCulture));
				if(taskRow == null)
					continue;
				parentTaskRow.ItemArray = taskRow.ItemArray;
				parentTaskRow.Description = ViewHelper.FixTaskPath(Tasks.GetFullPath(parentTaskRow),this.parentTaskComboBox.MaxLength);
				parentTasksTable.AddTasksRow(parentTaskRow);
			}
			this.parentTaskComboBox.DataSource = parentTasksTable;
			this.parentTaskComboBox.DisplayMember = parentTasksTable.DescriptionColumn.ColumnName;
			this.parentTaskComboBox.ValueMember = parentTasksTable.IdColumn.ColumnName;
			
			this.dateTimePicker.Value = DateTime.Today;
			
			if(parentTaskComboBox.Items.Count>0)
				parentTaskComboBox.SelectedIndex = 0;
			this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
			this.parentTaskComboBox.SelectedIndexChanged+=new EventHandler(parentTaskComboBox_SelectedIndexChanged);


		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.applicationsList = new PTM.View.Controls.TreeListViewComponents.TreeListView();
			this.colName = new System.Windows.Forms.ColumnHeader();
			this.colActiveTime = new System.Windows.Forms.ColumnHeader();
			this.colAppPercent = new System.Windows.Forms.ColumnHeader();
			this.colProcessId = new System.Windows.Forms.ColumnHeader();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.AppsActiveTimeValue = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.totalTasksLoggedValue = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.browseButton = new System.Windows.Forms.Button();
			this.parentTaskComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// applicationsList
			// 
			this.applicationsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.applicationsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																														 this.colName,
																														 this.colActiveTime,
																														 this.colAppPercent,
																														 this.colProcessId});
			this.applicationsList.Location = new System.Drawing.Point(8, 16);
			this.applicationsList.MultiSelect = false;
			this.applicationsList.Name = "applicationsList";
			this.applicationsList.Size = new System.Drawing.Size(376, 136);
			this.applicationsList.TabIndex = 2;
			// 
			// colName
			// 
			this.colName.Text = "Name";
			this.colName.Width = 233;
			// 
			// colActiveTime
			// 
			this.colActiveTime.Text = "Active Time";
			this.colActiveTime.Width = 78;
			// 
			// colAppPercent
			// 
			this.colAppPercent.Text = "Percent";
			// 
			// colProcessId
			// 
			this.colProcessId.Text = "Process Id";
			this.colProcessId.Width = 0;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(80, 9);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Date:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.applicationsList);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.ForeColor = System.Drawing.Color.Blue;
			this.groupBox3.Location = new System.Drawing.Point(8, 64);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(392, 160);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Applications";
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.AppsActiveTimeValue);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.totalTasksLoggedValue);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.ForeColor = System.Drawing.Color.Blue;
			this.groupBox4.Location = new System.Drawing.Point(8, 232);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(392, 48);
			this.groupBox4.TabIndex = 10;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Totals";
			// 
			// AppsActiveTimeValue
			// 
			this.AppsActiveTimeValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.AppsActiveTimeValue.ForeColor = System.Drawing.Color.Black;
			this.AppsActiveTimeValue.Location = new System.Drawing.Point(112, 16);
			this.AppsActiveTimeValue.Name = "AppsActiveTimeValue";
			this.AppsActiveTimeValue.Size = new System.Drawing.Size(48, 23);
			this.AppsActiveTimeValue.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(8, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 23);
			this.label8.TabIndex = 4;
			this.label8.Text = "Apps. Active Time:";
			// 
			// totalTasksLoggedValue
			// 
			this.totalTasksLoggedValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.totalTasksLoggedValue.ForeColor = System.Drawing.Color.Black;
			this.totalTasksLoggedValue.Location = new System.Drawing.Point(336, 16);
			this.totalTasksLoggedValue.Name = "totalTasksLoggedValue";
			this.totalTasksLoggedValue.Size = new System.Drawing.Size(48, 23);
			this.totalTasksLoggedValue.TabIndex = 2;
			this.totalTasksLoggedValue.Visible = false;
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(232, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Total Task Logged:";
			this.label1.Visible = false;
			// 
			// browseButton
			// 
			this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.browseButton.Location = new System.Drawing.Point(320, 34);
			this.browseButton.Name = "browseButton";
			this.browseButton.TabIndex = 14;
			this.browseButton.Text = "Browse...";
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// parentTaskComboBox
			// 
			this.parentTaskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.parentTaskComboBox.Location = new System.Drawing.Point(80, 35);
			this.parentTaskComboBox.MaxLength = 50;
			this.parentTaskComboBox.Name = "parentTaskComboBox";
			this.parentTaskComboBox.Size = new System.Drawing.Size(232, 21);
			this.parentTaskComboBox.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "Detail Level:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// StatisticsControl
			// 
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.parentTaskComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePicker);
			this.Name = "StatisticsControl";
			this.Size = new System.Drawing.Size(408, 288);
			this.Load += new System.EventHandler(this.Statistics_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		//private SummaryDataset.TasksSummaryDataTable tasksSummaryDataset;
		private SummaryDataset.ApplicationsSummaryDataTable appsSummaryDataset;

		private void Statistics_Load(object sender, EventArgs e)
		{
			//this.dateTimePicker.Value = DateTime.Today;
			//this.dateTimePicker.ValueChanged+=new EventHandler(dateTimePicker_ValueChanged);
			//this.taskComboBox.SelectedIndexChanged+=new EventHandler(taskComboBox_SelectedIndexChanged);
			this.applicationsList.SmallImageList = IconsManager.IconsList;
			this.parentTaskComboBox.Focus();
		}

		private void ClearContent()
		{

			this.totalTasksLoggedValue.Text = "";
			this.AppsActiveTimeValue.Text = "";
			this.applicationsList.Items.Clear();
		}

		public void UpdateStatistics()
		{
			if(this.dateTimePicker.Value != DateTime.Today)
				this.dateTimePicker.Value = DateTime.Today;
			else
			{
				GetTaskDetail(this.dateTimePicker.Value);
			}
		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			GetTaskDetail(dateTimePicker.Value);
		}

		private void GetTaskDetail(DateTime day)
		{
			try
			{

				ClearContent();
				this.Refresh();
				System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

				appsSummaryDataset = Summary.GetApplicationsSummary(
					Tasks.FindById((int)this.parentTaskComboBox.SelectedValue), 
					day, day.AddDays(1));
				int appActiveTime = 0;
				foreach (SummaryDataset.ApplicationsSummaryRow applicationsSummaryRow in appsSummaryDataset.Rows)
				{
					appActiveTime+= (int)applicationsSummaryRow.TotalActiveTime;
				}
				foreach (SummaryDataset.ApplicationsSummaryRow applicationsSummaryRow in appsSummaryDataset.Rows)
				{
					TimeSpan active =  new TimeSpan(0,0,(int) applicationsSummaryRow.TotalActiveTime);
					string activeTime = ViewHelper.TimeSpanToTimeString(active);
					double percent = 0;
					if(appActiveTime>0)
						percent =  applicationsSummaryRow.TotalActiveTime / appActiveTime;
					TreeListViewItem lvi = new TreeListViewItem(applicationsSummaryRow.Name, new string[]{activeTime, percent.ToString("0.0%", CultureInfo.InvariantCulture), applicationsSummaryRow.TaskId.ToString(CultureInfo.InvariantCulture)});
					lvi.ImageIndex = IconsManager.AddIconFromFile(applicationsSummaryRow.ApplicationFullPath);
					this.applicationsList.Items.Add(lvi);
				}
				AppsActiveTimeValue.Text =  ViewHelper.TimeSpanToTimeString(new TimeSpan(0,0,appActiveTime));
				
			}
			finally
			{
				System.Windows.Forms.Cursor.Current = Cursors.Default;
			}
			}


		private void parentTaskComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(parentTaskComboBox.SelectedIndex == -1)
				return;

			GetTaskDetail(dateTimePicker.Value);
		}

		private void browseButton_Click(object sender, System.EventArgs e)
		{
			TasksHierarchyForm tgForm = new TasksHierarchyForm();
			tgForm.ShowDialog(this);
			if(tgForm.SelectedTaskRow == null)
				return;

			if(parentTasksTable.FindById(tgForm.SelectedTaskRow.Id)==null)
			{
				PTMDataset.TasksRow parentRow = this.parentTasksTable.NewTasksRow();
				parentRow.ItemArray = tgForm.SelectedTaskRow.ItemArray;
				parentRow.Description = ViewHelper.FixTaskPath(Tasks.GetFullPath(parentRow), this.parentTaskComboBox.MaxLength);
				this.parentTasksTable.Rows.InsertAt(parentRow, 0 );
			}
			this.parentTaskComboBox.SelectedValue= tgForm.SelectedTaskRow.Id;
		}
	}
}
