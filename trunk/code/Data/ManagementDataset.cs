﻿using System.Globalization;
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace PTM.Data {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class ManagementDataset : DataSet {
        
        private ConfigurationDataTable tableConfiguration;
        
        private DefaultTasksDataTable tableDefaultTasks;
        
        private ListDataTable tableList;
        
        public ManagementDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected ManagementDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Configuration"] != null)) {
                    this.Tables.Add(new ConfigurationDataTable(ds.Tables["Configuration"]));
                }
                if ((ds.Tables["DefaultTasks"] != null)) {
                    this.Tables.Add(new DefaultTasksDataTable(ds.Tables["DefaultTasks"]));
                }
                if ((ds.Tables["List"] != null)) {
                    this.Tables.Add(new ListDataTable(ds.Tables["List"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ConfigurationDataTable Configuration {
            get {
                return this.tableConfiguration;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public DefaultTasksDataTable DefaultTasks {
            get {
                return this.tableDefaultTasks;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ListDataTable List {
            get {
                return this.tableList;
            }
        }
        
        public override DataSet Clone() {
            ManagementDataset cln = ((ManagementDataset)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["Configuration"] != null)) {
                this.Tables.Add(new ConfigurationDataTable(ds.Tables["Configuration"]));
            }
            if ((ds.Tables["DefaultTasks"] != null)) {
                this.Tables.Add(new DefaultTasksDataTable(ds.Tables["DefaultTasks"]));
            }
            if ((ds.Tables["List"] != null)) {
                this.Tables.Add(new ListDataTable(ds.Tables["List"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableConfiguration = ((ConfigurationDataTable)(this.Tables["Configuration"]));
            if ((this.tableConfiguration != null)) {
                this.tableConfiguration.InitVars();
            }
            this.tableDefaultTasks = ((DefaultTasksDataTable)(this.Tables["DefaultTasks"]));
            if ((this.tableDefaultTasks != null)) {
                this.tableDefaultTasks.InitVars();
            }
            this.tableList = ((ListDataTable)(this.Tables["List"]));
            if ((this.tableList != null)) {
                this.tableList.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "ManagementDataset";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/ConfigurationDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableConfiguration = new ConfigurationDataTable();
            this.Tables.Add(this.tableConfiguration);
            this.tableDefaultTasks = new DefaultTasksDataTable();
            this.Tables.Add(this.tableDefaultTasks);
            this.tableList = new ListDataTable();
            this.Tables.Add(this.tableList);
        }
        
        private bool ShouldSerializeConfiguration() {
            return false;
        }
        
        private bool ShouldSerializeDefaultTasks() {
            return false;
        }
        
        private bool ShouldSerializeList() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void ConfigurationRowChangeEventHandler(object sender, ConfigurationRowChangeEvent e);
        
        public delegate void DefaultTasksRowChangeEventHandler(object sender, DefaultTasksRowChangeEvent e);
        
        public delegate void ListRowChangeEventHandler(object sender, ListRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ConfigurationDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnConfigValue;
            
            private DataColumn columnDescription;
            
            private DataColumn columnId;
            
            private DataColumn columnKeyValue;
            
            private DataColumn columnListValue;
            
            internal ConfigurationDataTable() : 
                    base("Configuration") {
                this.InitClass();
            }
            
            internal ConfigurationDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn ConfigValueColumn {
                get {
                    return this.columnConfigValue;
                }
            }
            
            internal DataColumn DescriptionColumn {
                get {
                    return this.columnDescription;
                }
            }
            
            internal DataColumn IdColumn {
                get {
                    return this.columnId;
                }
            }
            
            internal DataColumn KeyValueColumn {
                get {
                    return this.columnKeyValue;
                }
            }
            
            internal DataColumn ListValueColumn {
                get {
                    return this.columnListValue;
                }
            }
            
            public ConfigurationRow this[int index] {
                get {
                    return ((ConfigurationRow)(this.Rows[index]));
                }
            }
            
            public event ConfigurationRowChangeEventHandler ConfigurationRowChanged;
            
            public event ConfigurationRowChangeEventHandler ConfigurationRowChanging;
            
            public event ConfigurationRowChangeEventHandler ConfigurationRowDeleted;
            
            public event ConfigurationRowChangeEventHandler ConfigurationRowDeleting;
            
            public void AddConfigurationRow(ConfigurationRow row) {
                this.Rows.Add(row);
            }
            
            public ConfigurationRow AddConfigurationRow(string ConfigValue, string Description, int KeyValue, string ListValue) {
                ConfigurationRow rowConfigurationRow = ((ConfigurationRow)(this.NewRow()));
                rowConfigurationRow.ItemArray = new object[] {
                        ConfigValue,
                        Description,
                        null,
                        KeyValue,
                        ListValue};
                this.Rows.Add(rowConfigurationRow);
                return rowConfigurationRow;
            }
            
            public ConfigurationRow FindById(int Id) {
                return ((ConfigurationRow)(this.Rows.Find(new object[] {
                            Id})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                ConfigurationDataTable cln = ((ConfigurationDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new ConfigurationDataTable();
            }
            
            internal void InitVars() {
                this.columnConfigValue = this.Columns["ConfigValue"];
                this.columnDescription = this.Columns["Description"];
                this.columnId = this.Columns["Id"];
                this.columnKeyValue = this.Columns["KeyValue"];
                this.columnListValue = this.Columns["ListValue"];
            }
            
            private void InitClass() {
                this.columnConfigValue = new DataColumn("ConfigValue", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnConfigValue);
                this.columnDescription = new DataColumn("Description", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescription);
                this.columnId = new DataColumn("Id", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnId);
                this.columnKeyValue = new DataColumn("KeyValue", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnKeyValue);
                this.columnListValue = new DataColumn("ListValue", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnListValue);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnId}, true));
                this.columnId.AutoIncrement = true;
                this.columnId.AllowDBNull = false;
                this.columnId.Unique = true;
            }
            
            public ConfigurationRow NewConfigurationRow() {
                return ((ConfigurationRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new ConfigurationRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(ConfigurationRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ConfigurationRowChanged != null)) {
                    this.ConfigurationRowChanged(this, new ConfigurationRowChangeEvent(((ConfigurationRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ConfigurationRowChanging != null)) {
                    this.ConfigurationRowChanging(this, new ConfigurationRowChangeEvent(((ConfigurationRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ConfigurationRowDeleted != null)) {
                    this.ConfigurationRowDeleted(this, new ConfigurationRowChangeEvent(((ConfigurationRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ConfigurationRowDeleting != null)) {
                    this.ConfigurationRowDeleting(this, new ConfigurationRowChangeEvent(((ConfigurationRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveConfigurationRow(ConfigurationRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ConfigurationRow : DataRow {
            
            private ConfigurationDataTable tableConfiguration;
            
            internal ConfigurationRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableConfiguration = ((ConfigurationDataTable)(this.Table));
            }
            
            public string ConfigValue {
                get {
                    try {
                        return ((string)(this[this.tableConfiguration.ConfigValueColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableConfiguration.ConfigValueColumn] = value;
                }
            }
            
            public string Description {
                get {
                    try {
                        return ((string)(this[this.tableConfiguration.DescriptionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableConfiguration.DescriptionColumn] = value;
                }
            }
            
            public int Id {
                get {
                    return ((int)(this[this.tableConfiguration.IdColumn]));
                }
                set {
                    this[this.tableConfiguration.IdColumn] = value;
                }
            }
            
            public int KeyValue {
                get {
                    try {
                        return ((int)(this[this.tableConfiguration.KeyValueColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableConfiguration.KeyValueColumn] = value;
                }
            }
            
            public string ListValue {
                get {
                    try {
                        return ((string)(this[this.tableConfiguration.ListValueColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableConfiguration.ListValueColumn] = value;
                }
            }
            
            public bool IsConfigValueNull() {
                return this.IsNull(this.tableConfiguration.ConfigValueColumn);
            }
            
            public void SetConfigValueNull() {
                this[this.tableConfiguration.ConfigValueColumn] = System.Convert.DBNull;
            }
            
            public bool IsDescriptionNull() {
                return this.IsNull(this.tableConfiguration.DescriptionColumn);
            }
            
            public void SetDescriptionNull() {
                this[this.tableConfiguration.DescriptionColumn] = System.Convert.DBNull;
            }
            
            public bool IsKeyValueNull() {
                return this.IsNull(this.tableConfiguration.KeyValueColumn);
            }
            
            public void SetKeyValueNull() {
                this[this.tableConfiguration.KeyValueColumn] = System.Convert.DBNull;
            }
            
            public bool IsListValueNull() {
                return this.IsNull(this.tableConfiguration.ListValueColumn);
            }
            
            public void SetListValueNull() {
                this[this.tableConfiguration.ListValueColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ConfigurationRowChangeEvent : EventArgs {
            
            private ConfigurationRow eventRow;
            
            private DataRowAction eventAction;
            
            public ConfigurationRowChangeEvent(ConfigurationRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public ConfigurationRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class DefaultTasksDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnDescription;
            
            private DataColumn columnId;
            
            internal DefaultTasksDataTable() : 
                    base("DefaultTasks") {
                this.InitClass();
            }
            
            internal DefaultTasksDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn DescriptionColumn {
                get {
                    return this.columnDescription;
                }
            }
            
            internal DataColumn IdColumn {
                get {
                    return this.columnId;
                }
            }
            
            public DefaultTasksRow this[int index] {
                get {
                    return ((DefaultTasksRow)(this.Rows[index]));
                }
            }
            
            public event DefaultTasksRowChangeEventHandler DefaultTasksRowChanged;
            
            public event DefaultTasksRowChangeEventHandler DefaultTasksRowChanging;
            
            public event DefaultTasksRowChangeEventHandler DefaultTasksRowDeleted;
            
            public event DefaultTasksRowChangeEventHandler DefaultTasksRowDeleting;
            
            public void AddDefaultTasksRow(DefaultTasksRow row) {
                this.Rows.Add(row);
            }
            
            public DefaultTasksRow AddDefaultTasksRow(string Description, int Id) {
                DefaultTasksRow rowDefaultTasksRow = ((DefaultTasksRow)(this.NewRow()));
                rowDefaultTasksRow.ItemArray = new object[] {
                        Description,
                        Id};
                this.Rows.Add(rowDefaultTasksRow);
                return rowDefaultTasksRow;
            }
            
            public DefaultTasksRow FindById(int Id) {
                return ((DefaultTasksRow)(this.Rows.Find(new object[] {
                            Id})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                DefaultTasksDataTable cln = ((DefaultTasksDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new DefaultTasksDataTable();
            }
            
            internal void InitVars() {
                this.columnDescription = this.Columns["Description"];
                this.columnId = this.Columns["Id"];
            }
            
            private void InitClass() {
                this.columnDescription = new DataColumn("Description", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescription);
                this.columnId = new DataColumn("Id", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnId);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnId}, true));
                this.columnId.AllowDBNull = false;
                this.columnId.Unique = true;
            }
            
            public DefaultTasksRow NewDefaultTasksRow() {
                return ((DefaultTasksRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new DefaultTasksRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(DefaultTasksRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.DefaultTasksRowChanged != null)) {
                    this.DefaultTasksRowChanged(this, new DefaultTasksRowChangeEvent(((DefaultTasksRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.DefaultTasksRowChanging != null)) {
                    this.DefaultTasksRowChanging(this, new DefaultTasksRowChangeEvent(((DefaultTasksRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.DefaultTasksRowDeleted != null)) {
                    this.DefaultTasksRowDeleted(this, new DefaultTasksRowChangeEvent(((DefaultTasksRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.DefaultTasksRowDeleting != null)) {
                    this.DefaultTasksRowDeleting(this, new DefaultTasksRowChangeEvent(((DefaultTasksRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveDefaultTasksRow(DefaultTasksRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class DefaultTasksRow : DataRow {
            
            private DefaultTasksDataTable tableDefaultTasks;
            
            internal DefaultTasksRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableDefaultTasks = ((DefaultTasksDataTable)(this.Table));
            }
            
            public string Description {
                get {
                    try {
                        return ((string)(this[this.tableDefaultTasks.DescriptionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDefaultTasks.DescriptionColumn] = value;
                }
            }
            
            public int Id {
                get {
                    return ((int)(this[this.tableDefaultTasks.IdColumn]));
                }
                set {
                    this[this.tableDefaultTasks.IdColumn] = value;
                }
            }
            
            public bool IsDescriptionNull() {
                return this.IsNull(this.tableDefaultTasks.DescriptionColumn);
            }
            
            public void SetDescriptionNull() {
                this[this.tableDefaultTasks.DescriptionColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class DefaultTasksRowChangeEvent : EventArgs {
            
            private DefaultTasksRow eventRow;
            
            private DataRowAction eventAction;
            
            public DefaultTasksRowChangeEvent(DefaultTasksRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public DefaultTasksRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ListDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnId;
            
            private DataColumn columnDescription;
            
            internal ListDataTable() : 
                    base("List") {
                this.InitClass();
            }
            
            internal ListDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn IdColumn {
                get {
                    return this.columnId;
                }
            }
            
            internal DataColumn DescriptionColumn {
                get {
                    return this.columnDescription;
                }
            }
            
            public ListRow this[int index] {
                get {
                    return ((ListRow)(this.Rows[index]));
                }
            }
            
            public event ListRowChangeEventHandler ListRowChanged;
            
            public event ListRowChangeEventHandler ListRowChanging;
            
            public event ListRowChangeEventHandler ListRowDeleted;
            
            public event ListRowChangeEventHandler ListRowDeleting;
            
            public void AddListRow(ListRow row) {
                this.Rows.Add(row);
            }
            
            public ListRow AddListRow(int Id, string Description) {
                ListRow rowListRow = ((ListRow)(this.NewRow()));
                rowListRow.ItemArray = new object[] {
                        Id,
                        Description};
                this.Rows.Add(rowListRow);
                return rowListRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                ListDataTable cln = ((ListDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new ListDataTable();
            }
            
            internal void InitVars() {
                this.columnId = this.Columns["Id"];
                this.columnDescription = this.Columns["Description"];
            }
            
            private void InitClass() {
                this.columnId = new DataColumn("Id", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnId);
                this.columnDescription = new DataColumn("Description", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescription);
                this.Constraints.Add(new UniqueConstraint("ConfigurationDatasetKey1", new DataColumn[] {
                                this.columnId}, false));
                this.columnId.AllowDBNull = false;
                this.columnId.Unique = true;
            }
            
            public ListRow NewListRow() {
                return ((ListRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new ListRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(ListRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ListRowChanged != null)) {
                    this.ListRowChanged(this, new ListRowChangeEvent(((ListRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ListRowChanging != null)) {
                    this.ListRowChanging(this, new ListRowChangeEvent(((ListRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ListRowDeleted != null)) {
                    this.ListRowDeleted(this, new ListRowChangeEvent(((ListRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ListRowDeleting != null)) {
                    this.ListRowDeleting(this, new ListRowChangeEvent(((ListRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveListRow(ListRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ListRow : DataRow {
            
            private ListDataTable tableList;
            
            internal ListRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableList = ((ListDataTable)(this.Table));
            }
            
            public int Id {
                get {
                    return ((int)(this[this.tableList.IdColumn]));
                }
                set {
                    this[this.tableList.IdColumn] = value;
                }
            }
            
            public string Description {
                get {
                    try {
                        return ((string)(this[this.tableList.DescriptionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableList.DescriptionColumn] = value;
                }
            }
            
            public bool IsDescriptionNull() {
                return this.IsNull(this.tableList.DescriptionColumn);
            }
            
            public void SetDescriptionNull() {
                this[this.tableList.DescriptionColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ListRowChangeEvent : EventArgs {
            
            private ListRow eventRow;
            
            private DataRowAction eventAction;
            
            public ListRowChangeEvent(ListRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public ListRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
