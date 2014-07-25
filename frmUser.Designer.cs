namespace ErpBudgetUser
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.mitemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.dsUser = new System.Data.DataSet();
            this.dtUser = new System.Data.DataTable();
            this.USER_ID = new System.Data.DataColumn();
            this.USER_NAME = new System.Data.DataColumn();
            this.USER_DESCRIPTION = new System.Data.DataColumn();
            this.USER_LOGONNAME = new System.Data.DataColumn();
            this.dtCompany = new System.Data.DataTable();
            this.COMPANY_GUID_ID = new System.Data.DataColumn();
            this.COMPANY_NAME = new System.Data.DataColumn();
            this.dtEmployeePost = new System.Data.DataTable();
            this.EMPLOYEEPOST_GUID_ID = new System.Data.DataColumn();
            this.EMPLOYEEPOST_NAME = new System.Data.DataColumn();
            this.dtEmail = new System.Data.DataTable();
            this.EMAIL_GUID_ID = new System.Data.DataColumn();
            this.EMAIL_ADDRESS = new System.Data.DataColumn();
            this.EMAIL_NOTACTIVE = new System.Data.DataColumn();
            this.dtUserEmail = new System.Data.DataTable();
            this.USEREMAIL_USER_ID = new System.Data.DataColumn();
            this.USERMAIL_EMAIL_GUID_ID = new System.Data.DataColumn();
            this.USERMAIL_EMAIL_ADDRESS = new System.Data.DataColumn();
            this.USERMAIL_EMAIL_MAIN = new System.Data.DataColumn();
            this.USERMAIL_EMAIL_NOTACTIVE = new System.Data.DataColumn();
            this.dtUserCompany = new System.Data.DataTable();
            this.USERCOMPANY_COMPANY_GUID_ID = new System.Data.DataColumn();
            this.USERCOMPANY_EMPLOYEEPOST_GUID_ID = new System.Data.DataColumn();
            this.USERCOMPANY_USER_ID = new System.Data.DataColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridUserList = new DevExpress.XtraGrid.GridControl();
            this.gridViewUserList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstrLogonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemImageEditUser = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.grCtrlProperties = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabCtrlProperties = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageCompany = new DevExpress.XtraTab.XtraTabPage();
            this.btnDelCompany = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCompany = new DevExpress.XtraEditors.SimpleButton();
            this.gridCompany = new DevExpress.XtraGrid.GridControl();
            this.gridViewCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkpCompany = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colEmployeePost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkpEmployeePost = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemImageEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.xtraTabPageEmail = new DevExpress.XtraTab.XtraTabPage();
            this.btnDeleteEmail = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddEmail = new DevExpress.XtraEditors.SimpleButton();
            this.gridEmailList = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmailList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmailChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmailNotActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkEmailNotActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colEmailAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            ( ( System.ComponentModel.ISupportInitialize )( this.barManager ) ).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize )( this.dsUser ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.dtUser ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.dtCompany ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.dtEmployeePost ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.dtEmail ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.dtUserEmail ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.dtUserCompany ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.panelControl1 ) ).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize )( this.splitContainerControl1 ) ).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize )( this.gridUserList ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.gridViewUserList ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.repItemImageEditUser ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.grCtrlProperties ) ).BeginInit();
            this.grCtrlProperties.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize )( this.xtraTabCtrlProperties ) ).BeginInit();
            this.xtraTabCtrlProperties.SuspendLayout();
            this.xtraTabPageCompany.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize )( this.gridCompany ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.gridViewCompany ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.lkpCompany ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.lkpEmployeePost ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.repositoryItemImageEdit2 ) ).BeginInit();
            this.xtraTabPageEmail.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize )( this.gridEmailList ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.gridViewEmailList ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.checkEmailNotActive ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.repositoryItemImageEdit1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange( new DevExpress.XtraBars.Bar[] {
            this.bar2} );
            this.barManager.DockControls.Add( this.barDockControlTop );
            this.barManager.DockControls.Add( this.barDockControlBottom );
            this.barManager.DockControls.Add( this.barDockControlLeft );
            this.barManager.DockControls.Add( this.barDockControlRight );
            this.barManager.Form = this;
            this.barManager.Items.AddRange( new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barBtnRefresh,
            this.barBtnPrint} );
            this.barManager.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 2";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange( new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPrint)} );
            this.bar2.Text = "Custom 2";
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Обновить";
            this.barBtnRefresh.Glyph = global::ErpBudgetUser.Properties.Resources.refresh;
            this.barBtnRefresh.Hint = "Обновить";
            this.barBtnRefresh.Id = 1;
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler( this.barBtnRefresh_ItemClick );
            // 
            // barBtnPrint
            // 
            this.barBtnPrint.Caption = "Печать";
            this.barBtnPrint.Glyph = global::ErpBudgetUser.Properties.Resources.printer2;
            this.barBtnPrint.Hint = "Печать справочника";
            this.barBtnPrint.Id = 4;
            this.barBtnPrint.Name = "barBtnPrint";
            this.barBtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler( this.barBtnPrint_ItemClick );
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mitemRefresh} );
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size( 155, 26 );
            // 
            // mitemRefresh
            // 
            this.mitemRefresh.Name = "mitemRefresh";
            this.mitemRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mitemRefresh.Size = new System.Drawing.Size( 154, 22 );
            this.mitemRefresh.Text = "Обновить";
            this.mitemRefresh.Click += new System.EventHandler( this.mitemRefresh_Click );
            // 
            // dsUser
            // 
            this.dsUser.DataSetName = "dsUser";
            this.dsUser.Relations.AddRange( new System.Data.DataRelation[] {
            new System.Data.DataRelation("rlUserEmail", "dtUser", "dtUserEmail", new string[] {
                        "USER_ID"}, new string[] {
                        "USEREMAIL_USER_ID"}, false),
            new System.Data.DataRelation("rlUserCompany", "dtUser", "dtUserCompany", new string[] {
                        "USER_ID"}, new string[] {
                        "USERCOMPANY_USER_ID"}, false)} );
            this.dsUser.Tables.AddRange( new System.Data.DataTable[] {
            this.dtUser,
            this.dtCompany,
            this.dtEmployeePost,
            this.dtEmail,
            this.dtUserEmail,
            this.dtUserCompany} );
            // 
            // dtUser
            // 
            this.dtUser.Columns.AddRange( new System.Data.DataColumn[] {
            this.USER_ID,
            this.USER_NAME,
            this.USER_DESCRIPTION,
            this.USER_LOGONNAME} );
            this.dtUser.Constraints.AddRange( new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "USER_ID"}, true)} );
            this.dtUser.PrimaryKey = new System.Data.DataColumn[] {
        this.USER_ID};
            this.dtUser.TableName = "dtUser";
            // 
            // USER_ID
            // 
            this.USER_ID.AllowDBNull = false;
            this.USER_ID.ColumnName = "USER_ID";
            this.USER_ID.DataType = typeof( int );
            // 
            // USER_NAME
            // 
            this.USER_NAME.ColumnName = "USER_NAME";
            // 
            // USER_DESCRIPTION
            // 
            this.USER_DESCRIPTION.ColumnName = "USER_DESCRIPTION";
            // 
            // USER_LOGONNAME
            // 
            this.USER_LOGONNAME.ColumnName = "USER_LOGONNAME";
            // 
            // dtCompany
            // 
            this.dtCompany.Columns.AddRange( new System.Data.DataColumn[] {
            this.COMPANY_GUID_ID,
            this.COMPANY_NAME} );
            this.dtCompany.Constraints.AddRange( new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "COMPANY_GUID_ID"}, true)} );
            this.dtCompany.PrimaryKey = new System.Data.DataColumn[] {
        this.COMPANY_GUID_ID};
            this.dtCompany.TableName = "dtCompany";
            // 
            // COMPANY_GUID_ID
            // 
            this.COMPANY_GUID_ID.AllowDBNull = false;
            this.COMPANY_GUID_ID.ColumnName = "COMPANY_GUID_ID";
            this.COMPANY_GUID_ID.DataType = typeof( System.Guid );
            // 
            // COMPANY_NAME
            // 
            this.COMPANY_NAME.ColumnName = "COMPANY_NAME";
            // 
            // dtEmployeePost
            // 
            this.dtEmployeePost.Columns.AddRange( new System.Data.DataColumn[] {
            this.EMPLOYEEPOST_GUID_ID,
            this.EMPLOYEEPOST_NAME} );
            this.dtEmployeePost.Constraints.AddRange( new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "EMPLOYEEPOST_GUID_ID"}, true)} );
            this.dtEmployeePost.PrimaryKey = new System.Data.DataColumn[] {
        this.EMPLOYEEPOST_GUID_ID};
            this.dtEmployeePost.TableName = "dtEmployeePost";
            // 
            // EMPLOYEEPOST_GUID_ID
            // 
            this.EMPLOYEEPOST_GUID_ID.AllowDBNull = false;
            this.EMPLOYEEPOST_GUID_ID.ColumnName = "EMPLOYEEPOST_GUID_ID";
            this.EMPLOYEEPOST_GUID_ID.DataType = typeof( System.Guid );
            // 
            // EMPLOYEEPOST_NAME
            // 
            this.EMPLOYEEPOST_NAME.ColumnName = "EMPLOYEEPOST_NAME";
            // 
            // dtEmail
            // 
            this.dtEmail.Columns.AddRange( new System.Data.DataColumn[] {
            this.EMAIL_GUID_ID,
            this.EMAIL_ADDRESS,
            this.EMAIL_NOTACTIVE} );
            this.dtEmail.TableName = "dtEmail";
            // 
            // EMAIL_GUID_ID
            // 
            this.EMAIL_GUID_ID.ColumnName = "EMAIL_GUID_ID";
            this.EMAIL_GUID_ID.DataType = typeof( System.Guid );
            // 
            // EMAIL_ADDRESS
            // 
            this.EMAIL_ADDRESS.ColumnName = "EMAIL_ADDRESS";
            // 
            // EMAIL_NOTACTIVE
            // 
            this.EMAIL_NOTACTIVE.ColumnName = "EMAIL_NOTACTIVE";
            this.EMAIL_NOTACTIVE.DataType = typeof( bool );
            // 
            // dtUserEmail
            // 
            this.dtUserEmail.Columns.AddRange( new System.Data.DataColumn[] {
            this.USEREMAIL_USER_ID,
            this.USERMAIL_EMAIL_GUID_ID,
            this.USERMAIL_EMAIL_ADDRESS,
            this.USERMAIL_EMAIL_MAIN,
            this.USERMAIL_EMAIL_NOTACTIVE} );
            this.dtUserEmail.Constraints.AddRange( new System.Data.Constraint[] {
            new System.Data.ForeignKeyConstraint("rlUserEmail", "dtUser", new string[] {
                        "USER_ID"}, new string[] {
                        "USEREMAIL_USER_ID"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)} );
            this.dtUserEmail.TableName = "dtUserEmail";
            // 
            // USEREMAIL_USER_ID
            // 
            this.USEREMAIL_USER_ID.ColumnName = "USEREMAIL_USER_ID";
            this.USEREMAIL_USER_ID.DataType = typeof( int );
            // 
            // USERMAIL_EMAIL_GUID_ID
            // 
            this.USERMAIL_EMAIL_GUID_ID.ColumnName = "USERMAIL_EMAIL_GUID_ID";
            this.USERMAIL_EMAIL_GUID_ID.DataType = typeof( System.Guid );
            // 
            // USERMAIL_EMAIL_ADDRESS
            // 
            this.USERMAIL_EMAIL_ADDRESS.ColumnName = "USERMAIL_EMAIL_ADDRESS";
            // 
            // USERMAIL_EMAIL_MAIN
            // 
            this.USERMAIL_EMAIL_MAIN.ColumnName = "USERMAIL_EMAIL_MAIN";
            this.USERMAIL_EMAIL_MAIN.DataType = typeof( bool );
            // 
            // USERMAIL_EMAIL_NOTACTIVE
            // 
            this.USERMAIL_EMAIL_NOTACTIVE.ColumnName = "USERMAIL_EMAIL_NOTACTIVE";
            this.USERMAIL_EMAIL_NOTACTIVE.DataType = typeof( bool );
            // 
            // dtUserCompany
            // 
            this.dtUserCompany.Columns.AddRange( new System.Data.DataColumn[] {
            this.USERCOMPANY_COMPANY_GUID_ID,
            this.USERCOMPANY_EMPLOYEEPOST_GUID_ID,
            this.USERCOMPANY_USER_ID} );
            this.dtUserCompany.Constraints.AddRange( new System.Data.Constraint[] {
            new System.Data.ForeignKeyConstraint("rlUserCompany", "dtUser", new string[] {
                        "USER_ID"}, new string[] {
                        "USERCOMPANY_USER_ID"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)} );
            this.dtUserCompany.TableName = "dtUserCompany";
            // 
            // USERCOMPANY_COMPANY_GUID_ID
            // 
            this.USERCOMPANY_COMPANY_GUID_ID.AllowDBNull = false;
            this.USERCOMPANY_COMPANY_GUID_ID.ColumnName = "USERCOMPANY_COMPANY_GUID_ID";
            this.USERCOMPANY_COMPANY_GUID_ID.DataType = typeof( System.Guid );
            // 
            // USERCOMPANY_EMPLOYEEPOST_GUID_ID
            // 
            this.USERCOMPANY_EMPLOYEEPOST_GUID_ID.AllowDBNull = false;
            this.USERCOMPANY_EMPLOYEEPOST_GUID_ID.ColumnName = "USERCOMPANY_EMPLOYEEPOST_GUID_ID";
            this.USERCOMPANY_EMPLOYEEPOST_GUID_ID.DataType = typeof( System.Guid );
            // 
            // USERCOMPANY_USER_ID
            // 
            this.USERCOMPANY_USER_ID.AllowDBNull = false;
            this.USERCOMPANY_USER_ID.ColumnName = "USERCOMPANY_USER_ID";
            this.USERCOMPANY_USER_ID.DataType = typeof( int );
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add( this.tableLayoutPanel1 );
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point( 0, 26 );
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size( 489, 400 );
            this.panelControl1.TabIndex = 5;
            this.panelControl1.Text = "panelControl1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel1.Controls.Add( this.tableLayoutPanel2, 0, 1 );
            this.tableLayoutPanel1.Controls.Add( this.splitContainerControl1, 0, 0 );
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point( 0, 0 );
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 39F ) );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            this.tableLayoutPanel1.Size = new System.Drawing.Size( 489, 400 );
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 147F ) );
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 147F ) );
            this.tableLayoutPanel2.Controls.Add( this.btnSave, 1, 0 );
            this.tableLayoutPanel2.Controls.Add( this.btnCancel, 2, 0 );
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point( 3, 364 );
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel2.Size = new System.Drawing.Size( 483, 33 );
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnSave.Image = global::ErpBudgetUser.Properties.Resources.disk_blue_ok;
            this.btnSave.Location = new System.Drawing.Point( 192, 4 );
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size( 141, 24 );
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.ToolTip = "Сохранить изменения в БД";
            this.btnSave.Click += new System.EventHandler( this.btnSave_Click );
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnCancel.Image = global::ErpBudgetUser.Properties.Resources.undo;
            this.btnCancel.Location = new System.Drawing.Point( 339, 4 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 141, 24 );
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отменить изменения";
            this.btnCancel.ToolTip = "Отменить изменения";
            this.btnCancel.Click += new System.EventHandler( this.btnCancel_Click );
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point( 3, 3 );
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.splitContainerControl1.Panel1.Controls.Add( this.gridUserList );
            this.splitContainerControl1.Panel1.MinSize = 100;
            this.splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.splitContainerControl1.Panel2.Controls.Add( this.grCtrlProperties );
            this.splitContainerControl1.Panel2.MinSize = 100;
            this.splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size( 483, 355 );
            this.splitContainerControl1.SplitterPosition = 151;
            this.splitContainerControl1.TabIndex = 6;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridUserList
            // 
            this.gridUserList.DataMember = "dtUser";
            this.gridUserList.DataSource = this.dsUser;
            this.gridUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUserList.EmbeddedNavigator.Name = "";
            this.gridUserList.Location = new System.Drawing.Point( 0, 0 );
            this.gridUserList.MainView = this.gridViewUserList;
            this.gridUserList.Name = "gridUserList";
            this.gridUserList.RepositoryItems.AddRange( new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemImageEditUser} );
            this.gridUserList.Size = new System.Drawing.Size( 483, 151 );
            this.gridUserList.TabIndex = 5;
            this.gridUserList.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUserList} );
            // 
            // gridViewUserList
            // 
            this.gridViewUserList.Columns.AddRange( new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstrLogonName,
            this.colstrDescription} );
            this.gridViewUserList.GridControl = this.gridUserList;
            this.gridViewUserList.Name = "gridViewUserList";
            this.gridViewUserList.OptionsPrint.PrintPreview = true;
            this.gridViewUserList.OptionsPrint.UsePrintStyles = true;
            this.gridViewUserList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewUserList.OptionsView.ShowDetailButtons = false;
            this.gridViewUserList.OptionsView.ShowGroupPanel = false;
            // 
            // colstrLogonName
            // 
            this.colstrLogonName.Caption = "Имя";
            this.colstrLogonName.FieldName = "USER_NAME";
            this.colstrLogonName.Name = "colstrLogonName";
            this.colstrLogonName.OptionsColumn.AllowEdit = false;
            this.colstrLogonName.OptionsColumn.AllowFocus = false;
            this.colstrLogonName.OptionsColumn.ReadOnly = true;
            this.colstrLogonName.Visible = true;
            this.colstrLogonName.VisibleIndex = 0;
            this.colstrLogonName.Width = 236;
            // 
            // colstrDescription
            // 
            this.colstrDescription.Caption = "Описание";
            this.colstrDescription.FieldName = "USER_DESCRIPTION";
            this.colstrDescription.Name = "colstrDescription";
            this.colstrDescription.OptionsColumn.AllowEdit = false;
            this.colstrDescription.OptionsColumn.AllowFocus = false;
            this.colstrDescription.OptionsColumn.ReadOnly = true;
            this.colstrDescription.Visible = true;
            this.colstrDescription.VisibleIndex = 1;
            this.colstrDescription.Width = 242;
            // 
            // repItemImageEditUser
            // 
            this.repItemImageEditUser.AutoHeight = false;
            this.repItemImageEditUser.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.repItemImageEditUser.Name = "repItemImageEditUser";
            // 
            // grCtrlProperties
            // 
            this.grCtrlProperties.Controls.Add( this.xtraTabCtrlProperties );
            this.grCtrlProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCtrlProperties.Location = new System.Drawing.Point( 0, 0 );
            this.grCtrlProperties.Name = "grCtrlProperties";
            this.grCtrlProperties.Padding = new System.Windows.Forms.Padding( 3, 0, 3, 3 );
            this.grCtrlProperties.Size = new System.Drawing.Size( 483, 200 );
            this.grCtrlProperties.TabIndex = 6;
            this.grCtrlProperties.Text = "Свойства";
            // 
            // xtraTabCtrlProperties
            // 
            this.xtraTabCtrlProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabCtrlProperties.Location = new System.Drawing.Point( 6, 17 );
            this.xtraTabCtrlProperties.Name = "xtraTabCtrlProperties";
            this.xtraTabCtrlProperties.SelectedTabPage = this.xtraTabPageCompany;
            this.xtraTabCtrlProperties.Size = new System.Drawing.Size( 471, 177 );
            this.xtraTabCtrlProperties.TabIndex = 2;
            this.xtraTabCtrlProperties.TabPages.AddRange( new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageCompany,
            this.xtraTabPageEmail} );
            this.xtraTabCtrlProperties.Text = "xtraTabCtrlProperties";
            // 
            // xtraTabPageCompany
            // 
            this.xtraTabPageCompany.Controls.Add( this.btnDelCompany );
            this.xtraTabPageCompany.Controls.Add( this.btnAddCompany );
            this.xtraTabPageCompany.Controls.Add( this.gridCompany );
            this.xtraTabPageCompany.Name = "xtraTabPageCompany";
            this.xtraTabPageCompany.Padding = new System.Windows.Forms.Padding( 3 );
            this.xtraTabPageCompany.Size = new System.Drawing.Size( 467, 151 );
            this.xtraTabPageCompany.Text = "Должность";
            // 
            // btnDelCompany
            // 
            this.btnDelCompany.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnDelCompany.Image = global::ErpBudgetUser.Properties.Resources.delete2;
            this.btnDelCompany.Location = new System.Drawing.Point( 441, 125 );
            this.btnDelCompany.Name = "btnDelCompany";
            this.btnDelCompany.Size = new System.Drawing.Size( 23, 23 );
            this.btnDelCompany.TabIndex = 6;
            this.btnDelCompany.Text = "simpleButton1";
            this.btnDelCompany.ToolTip = "Удалить должность";
            this.btnDelCompany.Click += new System.EventHandler( this.btnDelCompany_Click );
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnAddCompany.Image = global::ErpBudgetUser.Properties.Resources.add2;
            this.btnAddCompany.Location = new System.Drawing.Point( 414, 125 );
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size( 23, 23 );
            this.btnAddCompany.TabIndex = 5;
            this.btnAddCompany.Text = "simpleButton1";
            this.btnAddCompany.ToolTip = "Добавить новую должность";
            this.btnAddCompany.Click += new System.EventHandler( this.btnAddCompany_Click );
            // 
            // gridCompany
            // 
            this.gridCompany.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.gridCompany.DataMember = "dtUser.rlUserCompany";
            this.gridCompany.DataSource = this.dsUser;
            this.gridCompany.EmbeddedNavigator.Name = "";
            this.gridCompany.Location = new System.Drawing.Point( 3, 3 );
            this.gridCompany.MainView = this.gridViewCompany;
            this.gridCompany.Name = "gridCompany";
            this.gridCompany.RepositoryItems.AddRange( new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit2,
            this.lkpCompany,
            this.lkpEmployeePost} );
            this.gridCompany.Size = new System.Drawing.Size( 461, 118 );
            this.gridCompany.TabIndex = 4;
            this.gridCompany.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCompany} );
            // 
            // gridViewCompany
            // 
            this.gridViewCompany.Columns.AddRange( new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserCompany,
            this.colEmployeePost} );
            this.gridViewCompany.CustomizationFormBounds = new System.Drawing.Rectangle( 1062, 745, 208, 154 );
            this.gridViewCompany.GridControl = this.gridCompany;
            this.gridViewCompany.Name = "gridViewCompany";
            this.gridViewCompany.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewCompany.OptionsPrint.PrintPreview = true;
            this.gridViewCompany.OptionsPrint.UsePrintStyles = true;
            this.gridViewCompany.OptionsView.ShowDetailButtons = false;
            this.gridViewCompany.OptionsView.ShowGroupPanel = false;
            this.gridViewCompany.SortInfo.AddRange( new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEmployeePost, DevExpress.Data.ColumnSortOrder.Descending)} );
            this.gridViewCompany.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler( this.gridViewCompany_BeforeLeaveRow );
            this.gridViewCompany.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler( this.gridViewCompany_CellValueChanging );
            this.gridViewCompany.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler( this.gridViewCompany_InitNewRow );
            this.gridViewCompany.KeyDown += new System.Windows.Forms.KeyEventHandler( this.gridViewCompany_KeyDown );
            this.gridViewCompany.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler( this.gridViewCompany_InvalidRowException );
            // 
            // colUserCompany
            // 
            this.colUserCompany.Caption = "Компания";
            this.colUserCompany.ColumnEdit = this.lkpCompany;
            this.colUserCompany.FieldName = "USERCOMPANY_COMPANY_GUID_ID";
            this.colUserCompany.Name = "colUserCompany";
            this.colUserCompany.Visible = true;
            this.colUserCompany.VisibleIndex = 0;
            this.colUserCompany.Width = 201;
            // 
            // lkpCompany
            // 
            this.lkpCompany.AutoHeight = false;
            this.lkpCompany.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.lkpCompany.Name = "lkpCompany";
            this.lkpCompany.NullText = "";
            this.lkpCompany.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick;
            // 
            // colEmployeePost
            // 
            this.colEmployeePost.Caption = "Должность";
            this.colEmployeePost.ColumnEdit = this.lkpEmployeePost;
            this.colEmployeePost.FieldName = "USERCOMPANY_EMPLOYEEPOST_GUID_ID";
            this.colEmployeePost.Name = "colEmployeePost";
            this.colEmployeePost.Visible = true;
            this.colEmployeePost.VisibleIndex = 1;
            this.colEmployeePost.Width = 255;
            // 
            // lkpEmployeePost
            // 
            this.lkpEmployeePost.AutoHeight = false;
            this.lkpEmployeePost.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.lkpEmployeePost.Name = "lkpEmployeePost";
            this.lkpEmployeePost.NullText = "";
            this.lkpEmployeePost.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick;
            // 
            // repositoryItemImageEdit2
            // 
            this.repositoryItemImageEdit2.AutoHeight = false;
            this.repositoryItemImageEdit2.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.repositoryItemImageEdit2.Name = "repositoryItemImageEdit2";
            // 
            // xtraTabPageEmail
            // 
            this.xtraTabPageEmail.Controls.Add( this.btnDeleteEmail );
            this.xtraTabPageEmail.Controls.Add( this.btnAddEmail );
            this.xtraTabPageEmail.Controls.Add( this.gridEmailList );
            this.xtraTabPageEmail.Name = "xtraTabPageEmail";
            this.xtraTabPageEmail.Padding = new System.Windows.Forms.Padding( 3 );
            this.xtraTabPageEmail.Size = new System.Drawing.Size( 467, 151 );
            this.xtraTabPageEmail.Text = "Email";
            // 
            // btnDeleteEmail
            // 
            this.btnDeleteEmail.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnDeleteEmail.Image = global::ErpBudgetUser.Properties.Resources.delete2;
            this.btnDeleteEmail.Location = new System.Drawing.Point( 441, 125 );
            this.btnDeleteEmail.Name = "btnDeleteEmail";
            this.btnDeleteEmail.Size = new System.Drawing.Size( 23, 23 );
            this.btnDeleteEmail.TabIndex = 8;
            this.btnDeleteEmail.Text = "simpleButton1";
            this.btnDeleteEmail.ToolTip = "Удалить email";
            this.btnDeleteEmail.Click += new System.EventHandler( this.btnDeleteEmail_Click );
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnAddEmail.Image = global::ErpBudgetUser.Properties.Resources.add2;
            this.btnAddEmail.Location = new System.Drawing.Point( 414, 125 );
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size( 23, 23 );
            this.btnAddEmail.TabIndex = 7;
            this.btnAddEmail.Text = "simpleButton1";
            this.btnAddEmail.ToolTip = "Добавить новый email";
            this.btnAddEmail.Click += new System.EventHandler( this.btnAddEmail_Click );
            // 
            // gridEmailList
            // 
            this.gridEmailList.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.gridEmailList.DataMember = "dtUser.rlUserEmail";
            this.gridEmailList.DataSource = this.dsUser;
            this.gridEmailList.EmbeddedNavigator.Name = "";
            this.gridEmailList.Location = new System.Drawing.Point( 3, 3 );
            this.gridEmailList.MainView = this.gridViewEmailList;
            this.gridEmailList.Name = "gridEmailList";
            this.gridEmailList.RepositoryItems.AddRange( new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.checkEmailNotActive} );
            this.gridEmailList.Size = new System.Drawing.Size( 461, 118 );
            this.gridEmailList.TabIndex = 3;
            this.gridEmailList.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmailList} );
            // 
            // gridViewEmailList
            // 
            this.gridViewEmailList.Columns.AddRange( new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmailChecked,
            this.colEmailNotActive,
            this.colEmailAddress} );
            this.gridViewEmailList.GridControl = this.gridEmailList;
            this.gridViewEmailList.Name = "gridViewEmailList";
            this.gridViewEmailList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewEmailList.OptionsPrint.PrintPreview = true;
            this.gridViewEmailList.OptionsPrint.UsePrintStyles = true;
            this.gridViewEmailList.OptionsView.ShowDetailButtons = false;
            this.gridViewEmailList.OptionsView.ShowGroupPanel = false;
            this.gridViewEmailList.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler( this.gridViewEmailList_BeforeLeaveRow );
            this.gridViewEmailList.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler( this.gridViewEmailList_CellValueChanging );
            this.gridViewEmailList.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler( this.gridViewEmailList_InitNewRow );
            this.gridViewEmailList.KeyDown += new System.Windows.Forms.KeyEventHandler( this.gridViewEmailList_KeyDown );
            this.gridViewEmailList.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler( this.gridViewEmailList_InvalidRowException );
            // 
            // colEmailChecked
            // 
            this.colEmailChecked.Caption = "Осн.";
            this.colEmailChecked.FieldName = "USERMAIL_EMAIL_MAIN";
            this.colEmailChecked.Name = "colEmailChecked";
            this.colEmailChecked.Visible = true;
            this.colEmailChecked.VisibleIndex = 0;
            this.colEmailChecked.Width = 25;
            // 
            // colEmailNotActive
            // 
            this.colEmailNotActive.Caption = "Блок.";
            this.colEmailNotActive.ColumnEdit = this.checkEmailNotActive;
            this.colEmailNotActive.FieldName = "USERMAIL_EMAIL_NOTACTIVE";
            this.colEmailNotActive.Name = "colEmailNotActive";
            this.colEmailNotActive.Visible = true;
            this.colEmailNotActive.VisibleIndex = 1;
            this.colEmailNotActive.Width = 25;
            // 
            // checkEmailNotActive
            // 
            this.checkEmailNotActive.AutoHeight = false;
            this.checkEmailNotActive.Name = "checkEmailNotActive";
            // 
            // colEmailAddress
            // 
            this.colEmailAddress.Caption = "Адрес";
            this.colEmailAddress.FieldName = "USERMAIL_EMAIL_ADDRESS";
            this.colEmailAddress.Name = "colEmailAddress";
            this.colEmailAddress.Visible = true;
            this.colEmailAddress.VisibleIndex = 2;
            this.colEmailAddress.Width = 400;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 489, 426 );
            this.Controls.Add( this.panelControl1 );
            this.Controls.Add( this.barDockControlLeft );
            this.Controls.Add( this.barDockControlRight );
            this.Controls.Add( this.barDockControlBottom );
            this.Controls.Add( this.barDockControlTop );
            this.MinimumSize = new System.Drawing.Size( 300, 300 );
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.frmCompany_FormClosing );
            ( ( System.ComponentModel.ISupportInitialize )( this.barManager ) ).EndInit();
            this.contextMenuStrip.ResumeLayout( false );
            ( ( System.ComponentModel.ISupportInitialize )( this.dsUser ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.dtUser ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.dtCompany ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.dtEmployeePost ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.dtEmail ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.dtUserEmail ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.dtUserCompany ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.panelControl1 ) ).EndInit();
            this.panelControl1.ResumeLayout( false );
            this.tableLayoutPanel1.ResumeLayout( false );
            this.tableLayoutPanel2.ResumeLayout( false );
            ( ( System.ComponentModel.ISupportInitialize )( this.splitContainerControl1 ) ).EndInit();
            this.splitContainerControl1.ResumeLayout( false );
            ( ( System.ComponentModel.ISupportInitialize )( this.gridUserList ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.gridViewUserList ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.repItemImageEditUser ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.grCtrlProperties ) ).EndInit();
            this.grCtrlProperties.ResumeLayout( false );
            ( ( System.ComponentModel.ISupportInitialize )( this.xtraTabCtrlProperties ) ).EndInit();
            this.xtraTabCtrlProperties.ResumeLayout( false );
            this.xtraTabPageCompany.ResumeLayout( false );
            ( ( System.ComponentModel.ISupportInitialize )( this.gridCompany ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.gridViewCompany ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.lkpCompany ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.lkpEmployeePost ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.repositoryItemImageEdit2 ) ).EndInit();
            this.xtraTabPageEmail.ResumeLayout( false );
            ( ( System.ComponentModel.ISupportInitialize )( this.gridEmailList ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.gridViewEmailList ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.checkEmailNotActive ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.repositoryItemImageEdit1 ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barBtnPrint;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mitemRefresh;
        private System.Data.DataSet dsUser;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraBars.Bar bar2;
        private System.Data.DataTable dtUser;
        private System.Data.DataColumn USER_ID;
        private System.Data.DataColumn USER_NAME;
        private System.Data.DataColumn USER_DESCRIPTION;
        private System.Data.DataTable dtCompany;
        private System.Data.DataColumn COMPANY_GUID_ID;
        private System.Data.DataColumn COMPANY_NAME;
        private System.Data.DataTable dtEmployeePost;
        private System.Data.DataColumn EMPLOYEEPOST_GUID_ID;
        private System.Data.DataColumn EMPLOYEEPOST_NAME;
        private System.Data.DataTable dtEmail;
        private System.Data.DataColumn EMAIL_GUID_ID;
        private System.Data.DataColumn EMAIL_ADDRESS;
        private System.Data.DataColumn EMAIL_NOTACTIVE;
        private System.Data.DataTable dtUserEmail;
        private System.Data.DataColumn USEREMAIL_USER_ID;
        private System.Data.DataColumn USERMAIL_EMAIL_GUID_ID;
        private System.Data.DataColumn USERMAIL_EMAIL_ADDRESS;
        private System.Data.DataColumn USERMAIL_EMAIL_MAIN;
        private System.Data.DataTable dtUserCompany;
        private System.Data.DataColumn USERCOMPANY_COMPANY_GUID_ID;
        private System.Data.DataColumn USERCOMPANY_EMPLOYEEPOST_GUID_ID;
        private System.Data.DataColumn USERCOMPANY_USER_ID;
        private System.Data.DataColumn USERMAIL_EMAIL_NOTACTIVE;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridUserList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserList;
        private DevExpress.XtraGrid.Columns.GridColumn colstrLogonName;
        private DevExpress.XtraGrid.Columns.GridColumn colstrDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repItemImageEditUser;
        private DevExpress.XtraEditors.GroupControl grCtrlProperties;
        private DevExpress.XtraTab.XtraTabControl xtraTabCtrlProperties;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCompany;
        private DevExpress.XtraGrid.GridControl gridCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCompany;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkpCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeePost;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkpEmployeePost;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageEmail;
        private DevExpress.XtraGrid.GridControl gridEmailList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmailList;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailChecked;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailNotActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkEmailNotActive;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.SimpleButton btnAddCompany;
        private DevExpress.XtraEditors.SimpleButton btnDelCompany;
        private DevExpress.XtraEditors.SimpleButton btnDeleteEmail;
        private DevExpress.XtraEditors.SimpleButton btnAddEmail;
        private System.Data.DataColumn USER_LOGONNAME;
    }
}