using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ErpBudgetUser
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        #region ����������, ��������, ���������
        UniXP.Common.CProfile m_objProfile;
        #endregion

        public frmUser( UniXP.Common.CProfile objProfile )
        {
            InitializeComponent();
            m_objProfile = objProfile;
            // ������� ���������� �������
            CreateIndx();
            // ����������� ������ �������������
            bLoadUserList( 0 );
        }

        #region ���������� ������ �������������
        /// <summary>
        /// ������� ���������� ������� � ������
        /// </summary>
        private void CreateIndx()
        {
            try
            {
                // ���������� ������ "������������ - �������� �����"
                this.dtUserEmail.Constraints.Add( "indxUserEmail", 
                    new System.Data.DataColumn[] {this.dtUserEmail.Columns[ "USEREMAIL_USER_ID" ], 
                        this.dtUserEmail.Columns[ "USERMAIL_EMAIL_ADDRESS" ]}, false );
                // ���������� ������ "������������ - ���������"
                this.dtUserCompany.Constraints.Add( "indxCompanyPost",
                    new System.Data.DataColumn[] {
                        this.dtUserCompany.Columns[ "USERCOMPANY_COMPANY_GUID_ID" ],
                        this.dtUserCompany.Columns[ "USERCOMPANY_EMPLOYEEPOST_GUID_ID" ],
                        this.dtUserCompany.Columns[ "USERCOMPANY_USER_ID" ]}, false );
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ �������� ��������\n " + f.Message,
                    "������", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }

            return;

        }

        /// <summary>
        /// ����������� ������ ������������� �� ��
        /// </summary>
        /// <param name="iRowHandle">��������� �� ������ � ���������</param>
        /// <returns>true - �������� ����������; false - ������</returns>
        private System.Boolean bLoadUserList( System.Int32 iRowHandle )
        {
            System.Boolean bRes = false;
            dsUserCancelEvents();
            try
            {
                // ���������� �������� ������ ������������� ������� "������"
                ERP_Budget.Common.CUser objUser = new ERP_Budget.Common.CUser();
                ERP_Budget.Common.CBaseList<ERP_Budget.Common.CUser> objUserList = objUser.GetUserList( m_objProfile );
                if( objUserList == null ) { return bRes; }
                // ��������� ����� ������
                dsUser.Tables[ "dtUserEmail" ].Rows.Clear();
                dsUser.Tables[ "dtUserCompany" ].Rows.Clear();
                dsUser.Tables[ "dtCompany" ].Rows.Clear();
                dsUser.Tables[ "dtEmail" ].Rows.Clear();
                dsUser.Tables[ "dtEmployeePost" ].Rows.Clear();
                dsUser.Tables[ "dtUser" ].Rows.Clear();
                System.Int32 iItemsCount = objUserList.GetCountItems();
                if( iItemsCount > 0 )
                {
                    System.Data.DataRow newRow = null;
                    System.Data.DataRow newRowEmail = null;
                    System.Data.DataRow newRowCompany = null;
                    ERP_Budget.Common.CUser objItemUser = null;

                    for( System.Int32 i = 0; i< iItemsCount; i++ )
                    {
                        objItemUser = objUserList.GetByIndex( i );
                        newRow = dsUser.Tables[ "dtUser" ].NewRow();
                        newRow[ "USER_ID" ] = objItemUser.ulID;
                        newRow[ "USER_NAME" ] = objItemUser.UserLastName + " " + objItemUser.UserFirstName;
                        newRow[ "USER_LOGONNAME" ] = objItemUser.Name;
                        newRow[ "USER_DESCRIPTION" ] = objItemUser.UserDescription;
                        
                        dsUser.Tables[ "dtUser" ].Rows.Add( newRow );
                        // ������ email ������� ������������
                        if( objItemUser.EmailList.GetCountItems() > 0 )
                        {
                            for( System.Int32 i2 = 0; i2< objItemUser.EmailList.GetCountItems(); i2++ )
                            {
                                newRowEmail = dsUser.Tables[ "dtUserEmail" ].NewRow();
                                newRowEmail[ "USEREMAIL_USER_ID" ] = objItemUser.ulID;
                                newRowEmail[ "USERMAIL_EMAIL_GUID_ID" ] = objItemUser.EmailList.GetByIndex( i2 ).uuidID;
                                newRowEmail[ "USERMAIL_EMAIL_ADDRESS" ] = objItemUser.EmailList.GetByIndex( i2 ).Adress;
                                newRowEmail[ "USERMAIL_EMAIL_MAIN" ] = objItemUser.EmailList.GetByIndex( i2 ).IsMain;
                                newRowEmail[ "USERMAIL_EMAIL_NOTACTIVE" ] = !( objItemUser.EmailList.GetByIndex( i2 ).IsActive );
                                dsUser.Tables[ "dtUserEmail" ].Rows.Add( newRowEmail );
                                newRowEmail = null;
                            }
                        }
                        // ������ ���������� ������� ������������
                        if( objItemUser.EmployeePostList.GetCountItems() > 0 )
                        {
                            for( System.Int32 i3 = 0; i3< objItemUser.EmployeePostList.GetCountItems(); i3++ )
                            {
                                newRowCompany = dsUser.Tables[ "dtUserCompany" ].NewRow();
                                newRowCompany[ "USERCOMPANY_COMPANY_GUID_ID" ] = objItemUser.EmployeePostList.GetByIndex( i3 ).Company.uuidID;
                                newRowCompany[ "USERCOMPANY_EMPLOYEEPOST_GUID_ID" ] = objItemUser.EmployeePostList.GetByIndex( i3 ).EmploeePost.uuidID;
                                newRowCompany[ "USERCOMPANY_USER_ID" ] = objItemUser.ulID;
                                dsUser.Tables[ "dtUserCompany" ].Rows.Add( newRowCompany );
                                newRowCompany = null;
                            }
                        }
                    }
                    // ������ ���������� ��������� ���������� ������ ����������, ��������, email
                    // ��������
                    ERP_Budget.Common.CCompany objCompany = new ERP_Budget.Common.CCompany();
                    ERP_Budget.Common.CBaseList<ERP_Budget.Common.CCompany> objCompanyList = objCompany.GetCompanyList( m_objProfile, true, System.Guid.Empty );
                    if( ( objCompanyList != null ) && ( objCompanyList.GetCountItems() > 0 ) )
                    {
                        System.Data.DataRow newRowCompanyList = null;
                        for( System.Int32 i4 = 0; i4< objCompanyList.GetCountItems(); i4++ )
                        {
                            newRowCompanyList = dsUser.Tables[ "dtCompany" ].NewRow();
                            newRowCompanyList[ "COMPANY_GUID_ID" ] = objCompanyList.GetByIndex( i4 ).uuidID;
                            newRowCompanyList[ "COMPANY_NAME" ] = objCompanyList.GetByIndex( i4 ).Name;
                            dsUser.Tables[ "dtCompany" ].Rows.Add( newRowCompanyList );
                            newRowCompanyList = null;
                        }
                    }
                    // ���������� ������
                    this.lkpCompany.DataSource = this.dtCompany;
                    this.lkpCompany.DisplayMember = "COMPANY_NAME";
                    this.lkpCompany.ValueMember = "COMPANY_GUID_ID";
                    this.lkpCompany.Columns.Clear();
                    this.lkpCompany.Columns.AddRange( new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
		            new DevExpress.XtraEditors.Controls.LookUpColumnInfo( "COMPANY_NAME", "��������", 100, 
                        DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, 
                        DevExpress.Data.ColumnSortOrder.None ) } );

                    // ���������
                    ERP_Budget.Common.CEmployeePost objEmployeePost = new ERP_Budget.Common.CEmployeePost();
                    ERP_Budget.Common.CBaseList<ERP_Budget.Common.CEmployeePost> objEmployeePostList = objEmployeePost.GetEmployeePostList( m_objProfile, true, System.Guid.Empty );
                    if( ( objEmployeePostList != null ) && ( objEmployeePostList.GetCountItems() > 0 ) )
                    {
                        System.Data.DataRow newRowEmployeePostList = null;
                        for( System.Int32 i5 = 0; i5< objEmployeePostList.GetCountItems(); i5++ )
                        {
                            newRowEmployeePostList = dsUser.Tables[ "dtEmployeePost" ].NewRow();
                            newRowEmployeePostList[ "EMPLOYEEPOST_GUID_ID" ] = objEmployeePostList.GetByIndex( i5 ).uuidID;
                            newRowEmployeePostList[ "EMPLOYEEPOST_NAME" ] = objEmployeePostList.GetByIndex( i5 ).Name;
                            dsUser.Tables[ "dtEmployeePost" ].Rows.Add( newRowEmployeePostList );
                            newRowEmployeePostList = null;
                        }
                    }
                    // ���������� ������
                    this.lkpEmployeePost.DataSource = this.dtEmployeePost;
                    this.lkpEmployeePost.DisplayMember = "EMPLOYEEPOST_NAME";
                    this.lkpEmployeePost.ValueMember = "EMPLOYEEPOST_GUID_ID";
                    this.lkpEmployeePost.Columns.Clear();
                    this.lkpEmployeePost.Columns.AddRange( new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
		            new DevExpress.XtraEditors.Controls.LookUpColumnInfo( "EMPLOYEEPOST_NAME", "���������", 100, 
                        DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, 
                        DevExpress.Data.ColumnSortOrder.None ) } );

                    // email
                    ERP_Budget.Common.CEmail objEmail = new ERP_Budget.Common.CEmail();
                    ERP_Budget.Common.CBaseList<ERP_Budget.Common.CEmail> objEmailList = objEmail.GetEmailList( m_objProfile, 0 );
                    if( ( objEmailList != null ) && ( objEmailList.GetCountItems() > 0 ) )
                    {
                        System.Data.DataRow newRowEmailList = null;
                        for( System.Int32 i6 = 0; i6< objEmailList.GetCountItems(); i6++ )
                        {
                            newRowEmailList = dsUser.Tables[ "dtEmail" ].NewRow();
                            newRowEmailList[ "EMAIL_GUID_ID" ] = objEmailList.GetByIndex( i6 ).uuidID;
                            newRowEmailList[ "EMAIL_ADDRESS" ] = objEmailList.GetByIndex( i6 ).Adress;
                            newRowEmailList[ "EMAIL_NOTACTIVE" ] = !( objEmailList.GetByIndex( i6 ).IsActive );
                            dsUser.Tables[ "dtEmail" ].Rows.Add( newRowEmailList );
                            newRowEmailList = null;
                        }
                    }

                    gridViewUserList.FocusedRowHandle = iRowHandle;
                    gridViewUserList.RefreshData();
                    gridViewCompany.RefreshData();
                    gridViewEmailList.RefreshData();
                } // iItemsCount > 0
                // ������������ ��������� � ������ ������
                dsUser.AcceptChanges();
                bRes = true;
            }//try
            catch( System.Exception e )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ������ ������ �������������\n " + e.Message, 
                    "������", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            finally
            {
                SetModifiedToFalse();
                dsUserAddEvents();
            }
            return bRes;
        }
        /// <summary>
        /// ��������� ������ �������������
        /// </summary>
        /// <param name="iPosdtUser">��������� �� ������ � ���������</param>
        /// <returns>true - �������� ����������; false - ������</returns>
        private System.Boolean bRefreshViewUserInfo( System.Int32 iPosdtUser )
        {
            System.Boolean bRet = false;
            try
            {
                // ��������� ����������
                bRet = bLoadUserList( iPosdtUser );
            }
            catch( System.Exception e )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ���������� ����������\n" + e.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error );
            }
            return bRet;
        }
        private void barBtnRefresh_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
        {
            try
            {
                // ��������� ����������
                System.Int32 iPosdtUser = ( gridViewUserList.FocusedRowHandle >= 0 ) ? gridViewUserList.FocusedRowHandle : 0;
                bLoadUserList( iPosdtUser );
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ���������� ������ �������������\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error );
            }
            return ;
        }
        private void mitemRefresh_Click( object sender, EventArgs e )
        {
            try
            {
                // ��������� ����������
                System.Int32 iPosdtUser = ( gridViewUserList.FocusedRowHandle >= 0 ) ? gridViewUserList.FocusedRowHandle : 0;
                bLoadUserList( iPosdtUser );
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ���������� ������ �������������\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }
        #endregion

        #region ��������� ��������� � ������ ������

        private System.Boolean m_bIsDebtorModified;
        private System.Boolean m_bCancelEvents;

        /// <summary>
        /// ������������� ��������� "�������� ������" � true
        /// </summary>
        private void SetModifiedToTrue()
        {
            try
            {
                m_bIsDebtorModified = true;
                btnSave.Enabled = m_bIsDebtorModified;
                btnCancel.Enabled = m_bIsDebtorModified;
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ SetModifiedToTrue()\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }
        /// <summary>
        /// ������������� ��������� "�������� ������" � false
        /// </summary>
        private void SetModifiedToFalse()
        {
            try
            {
                m_bIsDebtorModified = false;
                btnSave.Enabled = m_bIsDebtorModified;
                btnCancel.Enabled = m_bIsDebtorModified;
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ SetModifiedToFalse()\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }
        /// <summary>
        /// ���������� ������� ����, ���������� �� ������
        /// </summary>
        /// <returns>true - ����������; false - �� ����������</returns>
        private System.Boolean bIsUserListModif()
        {
            System.Boolean bRes = false;
            try
            {
                bRes = ( m_bIsDebtorModified );
            }
            catch( System.Exception e )
            {
                System.Windows.Forms.MessageBox.Show( this,
                    e.Message, "������",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
            }
            return bRes;
        }
        /// <summary>
        /// ���������� ������������ ������� ��� ��������� ������� ������ ������ dsUser
        /// </summary>
        private void dsUserCancelEvents()
        {
            // ��������� ����������� ������� ��� ��������� �������
            try
            {
                m_bCancelEvents = true;
                this.dsUser.Tables[ "dtCompany" ].ColumnChanging -=
                    new System.Data.DataColumnChangeEventHandler( this.dsUserTablesColumnChaining );
                this.gridViewUserList.FocusedRowChanged -= new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler( this.gridViewUserList_FocusedRowChanged );
                this.gridViewUserList.BeforeLeaveRow -= new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler( this.gridViewUserList_BeforeLeaveRow );

            }
            catch( System.Exception e )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ���������� ������������ �������\n" + e.Message, "������",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }

        /// <summary>
        /// ����������� ������������ ������� ��� ��������� ������� ������ ������ dsUser
        /// </summary>
        private void dsUserAddEvents()
        {
            try
            {
                m_bCancelEvents = false;
                this.dsUser.Tables[ "dtCompany" ].ColumnChanging +=
                    new System.Data.DataColumnChangeEventHandler( this.dsUserTablesColumnChaining );
                this.gridViewUserList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler( this.gridViewUserList_FocusedRowChanged );
                this.gridViewUserList.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler( this.gridViewUserList_BeforeLeaveRow );

            }
            catch( System.Exception e )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ����������� ������������ �������\n" + e.Message, "������",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }
        /// <summary>
        /// ���������� �������, ������������ ��� ��������� �������� ������� � �������� ������ ������ "dsUser"
        /// </summary>
        private void dsUserTablesColumnChaining( object sender, System.Data.DataColumnChangeEventArgs e )
        {
            try
            {
                if( !m_bCancelEvents )
                {
                    SetModifiedToTrue();
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "dsUserTablesColumnChaining()\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }

        #endregion

        #region ��������� �� ������ �������
        /// <summary>
        /// ���������� �������, ������������ ��� ������� ������� ������ � ��������� gridViewUserList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewUserList_BeforeLeaveRow( object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e )
        {
            try
            {
                System.Data.DataRow dr = gridViewUserList.GetDataRow( e.RowHandle );
                if( bIsUserListModif() )
                {
                    System.Windows.Forms.DialogResult dRes =
                 ( System.Windows.Forms.MessageBox.Show( this, "�������� ������������ ���� ��������.\n ��������� ���������?", "��������",
                       System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Question ) );
                    // ��������� ������� ����������
                    if( dRes == System.Windows.Forms.DialogResult.Yes )
                    {
                        if( bIsAllValuesValidation() )
                        {
                            if( bSaveChange() == false )
                            {
                                System.Windows.Forms.MessageBox.Show( this,
                                   "��� ���������� ��������� �������� ������!\n ���������, ����������, �������� ���� �����.", "������",
                                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
                                e.Allow = false;
                            }
                        }
                        else
                        {
                            e.Allow = false;
                        }
                    }
                    if( dRes == System.Windows.Forms.DialogResult.No )
                    // ������ ��������� ���������
                    {
                        e.Allow = bCancelChange();
                    }
                    if( dRes == System.Windows.Forms.DialogResult.Cancel )
                    {
                        e.Allow = false;
                    }
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "��� ����� ������ �������� ������!\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            finally
            {
            }
            return;
        }
        /// <summary>
        /// ��������� ������ ������ � ����� UserList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewUserList_FocusedRowChanged( object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            try
            {
                if( gridViewUserList.SelectedRowsCount > 0 )
                {
                    // � ����� �������� �����-�� ������
                }
                else
                {
                    // � ����� ������ �� �������
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "��� ����� ������ �������� ������!\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            finally
            {
                SetModifiedToFalse();
            }
            return;
        }

        #endregion

        #region ������ ��������� ���������
        /// <summary>
        /// �������� ��������� � ������ ���������
        /// </summary>
        /// <returns></returns>
        private System.Boolean bCancelChange()
        {
            System.Boolean bRet = false;
            try
            {
                // ������ �������������
                if( bIsUserListModif() )
                {
                    // �������� ��������� � ������ �������� �������
                    dsUser.Tables[ "dtUserEmail" ].RejectChanges();
                    // �������� ��������� � ������ ���������� ����������
                    dsUser.Tables[ "dtUserCompany" ].RejectChanges();
                    SetModifiedToFalse();
                    bRet = true;
                }
            }
            catch( System.Exception e )
            {
                System.Windows.Forms.MessageBox.Show( this,
                   "������ ������ ��������� ���������.\n" + e.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return bRet;
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            try
            {
                if( System.Windows.Forms.MessageBox.Show( this,
                   "�������� ��� ��������� ���������?", "�������������",
                   System.Windows.Forms.MessageBoxButtons.YesNoCancel, 
                   System.Windows.Forms.MessageBoxIcon.Question ) == System.Windows.Forms.DialogResult.Yes )
                {
                    bCancelChange();
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this,
                   "������ ������ ��������� ���������.\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }

        #endregion

        #region ���������� � �� ��������� ���������
        /// <summary>
        /// ��������� ���������� ������������ �����
        /// </summary>
        /// <returns>true - ��� ������������ ���� ���������; false - �� ��� ������������ ���� ���������</returns>
        private System.Boolean bIsAllValuesValidation()
        {
            System.Boolean bRet = false;
            try
            {
                //if( txtCompanyAcronym.Text.Length == 0 )
                //{
                //    System.Windows.Forms.MessageBox.Show( this,
                //        "������������ �������� �������� ������������ ����������!", "��������!",
                //        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
                //    return bRet;
                //}
                //if( txtCompanyName.Text.Length == 0 )
                //{
                //    System.Windows.Forms.MessageBox.Show( this,
                //        "������������ �������� �������� ������������ ����������!", "��������!",
                //        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
                //    return bRet;
                //}
                bRet = true;
            }
            catch( System.Exception e )
            {
                System.Windows.Forms.MessageBox.Show( this,
                    "������ �������� ��������� ��������.\n " + e.Message, "������",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return bRet;
        }
        /// <summary>
        /// ��������� ��������� � �������� �������� 
        /// </summary>
        /// <returns>true - ������� ���������� ��������; false - ������</returns>
        private System.Boolean bSaveChange()
        {
            System.Boolean bRet = false;
            System.Windows.Forms.Cursor curCursor = this.Cursor;
            try
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                // �� ������ ���������� ���������� � �� ��������� ����� � ����������� �������
                gridUserList.Enabled = false;
                gridCompany.Enabled = false;
                gridEmailList.Enabled = false;

                // ��������� ������ �������������
                if( bIsUserListModif() )
                {
                    // ��������� ���������� � ������������
                    bRet = bSaveUserInfo( gridViewUserList.FocusedRowHandle );
                }
                // ��������� ���������� � ������������
                if( bRet )
                {
                    bRet = bRefreshViewUserInfo( gridViewUserList.FocusedRowHandle );
                }
            }
            catch( System.Exception e )
            {
                System.Windows.Forms.MessageBox.Show( this,
                    "bSaveChange()\n " + e.Message, "������",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            finally
            {
                gridUserList.Enabled = true;
                gridCompany.Enabled = true;
                gridEmailList.Enabled = true;
                this.Cursor = curCursor;
            }
            return bRet;
        }
        /// <summary>
        /// ��������� � �� ��������� � �������� �������� 
        /// </summary>
        /// <param name="iRowHndl">��������� �� ����������� ������ � ��������� </param>
        /// <returns>true - ������� ���������� ��������; false - ������</returns>
        private System.Boolean bSaveUserInfo( System.Int32 iRowHndl )
        {
            System.Boolean bRet = false;
            try
            {
                // ������� ������ ������ CUser
                ERP_Budget.Common.CUser objUser = new ERP_Budget.Common.CUser();
                if( objUser == null ) { return bRet; }
                System.Data.DataRow rowUser = gridViewUserList.GetDataRow( iRowHndl );
                if( rowUser == null ){ return bRet; }
                objUser.ulID = ( System.Int32 )rowUser[ "USER_ID" ];

                // ����������������� ������ ����������
                ERP_Budget.Common.CBaseList<ERP_Budget.Common.CCompanyPost> objCompanyPostList = new ERP_Budget.Common.CBaseList<ERP_Budget.Common.CCompanyPost>();
                System.Data.DataRow[] CompanyList = rowUser.GetChildRows( dsUser.Relations[ "rlUserCompany" ] );
                if( CompanyList.Length > 0 )
                {
                    System.Data.DataRow rowCompany = null;
                    ERP_Budget.Common.CCompanyPost objCompanyPost = null;
                    ERP_Budget.Common.CCompany objCompany = null;
                    ERP_Budget.Common.CEmployeePost objEmployeePost = null;

                    for( System.Int32 i = 0; i < CompanyList.Length; i++ )
                    {
                        rowCompany = CompanyList[ i ];
                        // ������ "��������� - ��������"
                        objCompanyPost = new ERP_Budget.Common.CCompanyPost();
                        // ������ "��������"
                        objCompany = new ERP_Budget.Common.CCompany();
                        objCompany.uuidID = ( System.Guid )rowCompany[ "USERCOMPANY_COMPANY_GUID_ID" ];
                        objCompanyPost.Company = objCompany;
                        // ������ "���������"
                        objEmployeePost = new ERP_Budget.Common.CEmployeePost();
                        objEmployeePost.uuidID = ( System.Guid )rowCompany[ "USERCOMPANY_EMPLOYEEPOST_GUID_ID" ];;
                        objCompanyPost.EmploeePost = objEmployeePost;
                        // ��������� ������ � ������
                        objCompanyPostList.AddItemToList( objCompanyPost );

                        // �������� ����������
                        objCompanyPost = null;
                        objCompany = null;
                        objEmployeePost = null;
                        rowCompany = null;
                    } //for
                }

                // ����������������� ������ �������� �������
                ERP_Budget.Common.CBaseList<ERP_Budget.Common.CEmail> objEmailList = new ERP_Budget.Common.CBaseList<ERP_Budget.Common.CEmail>();
                System.Data.DataRow[] EmailList = rowUser.GetChildRows( dsUser.Relations[ "rlUserEmail" ] );
                if( EmailList.Length > 0 )
                {
                    System.Data.DataRow rowEmail = null;
                    ERP_Budget.Common.CEmail objEmail = null;

                    for( System.Int32 i = 0; i < EmailList.Length; i++ )
                    {
                        rowEmail = EmailList[ i ];
                        // ������ "�������� �����"
                        objEmail = new ERP_Budget.Common.CEmail();
                        //objEmail.uuidID = ( System.Guid )rowEmail[ "USERMAIL_EMAIL_GUID_ID" ];
                        objEmail.Adress = ( System.String )rowEmail[ "USERMAIL_EMAIL_ADDRESS" ];
                        objEmail.IsActive = !( ( System.Boolean )rowEmail[ "USERMAIL_EMAIL_NOTACTIVE" ] );
                        objEmail.IsMain = ( System.Boolean )rowEmail[ "USERMAIL_EMAIL_MAIN" ];

                        // ��������� ������ � ������
                        objEmailList.AddItemToList( objEmail );

                        // �������� ����������
                        objEmail = null;
                    } //for
                }
                objUser.EmailList = objEmailList;
                objUser.EmployeePostList = objCompanyPostList;
                // ���������� ���������� � ��
                bRet = objUser.Update( m_objProfile );
                objUser = null;
            }
            catch( System.Exception e )
            {
                System.Windows.Forms.MessageBox.Show( this,
                    "bSaveUserInfo\n " + e.Message, "������",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            finally
            {
            }
            return bRet;
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            try
            {
                if( System.Windows.Forms.MessageBox.Show( this,
                   "��������� ���������?", "�������������",
                   System.Windows.Forms.MessageBoxButtons.YesNoCancel,
                   System.Windows.Forms.MessageBoxIcon.Question ) == System.Windows.Forms.DialogResult.Yes )
                {
                    bSaveChange();
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this,
                   "������ ���������� ���������.\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }

        #endregion

        #region �������� �����
        private void frmCompany_FormClosing( object sender, FormClosingEventArgs e )
        {
            try
            {
                if( bIsUserListModif() )
                {
                    if( System.Windows.Forms.MessageBox.Show( this,
                        "�������� ������������ ���� ��������.\n����� �� ����� ��� ���������� ���������?", "��������",
                        System.Windows.Forms.MessageBoxButtons.YesNo,
                        System.Windows.Forms.MessageBoxIcon.Question ) == System.Windows.Forms.DialogResult.No )
                    // ��������� ������� ����������
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "frmCompany_FormClosing\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }

            return;
        }
        #endregion

        #region ����������� ����
        private void gridUserList_MouseDown( object sender, MouseEventArgs e )
        {
            try
            {
                if( e.Button == System.Windows.Forms.MouseButtons.Right )
                {
                    DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hi = gridViewUserList.CalcHitInfo( new System.Drawing.Point( e.X, e.Y ) );
                    if( hi.InRow )
                    {
                        gridUserList.ContextMenuStrip =  contextMenuStrip;
                        mitemRefresh.Enabled = !( bIsUserListModif() );

                        System.Int32 intRowIndex =  hi.RowHandle;
                        if( intRowIndex !=  gridViewUserList.FocusedRowHandle )
                        {
                            gridViewUserList.FocusedRowHandle = intRowIndex;
                        }
                    }
                    else
                    {
                        gridUserList.ContextMenuStrip =  contextMenuStrip;
                        mitemRefresh.Enabled = !( bIsUserListModif() );
                    }
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "gridUserList_MouseDown\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }

        }
        #endregion

        #region ������

        private void barBtnPrint_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
        {
            System.Collections.ArrayList ColumnList = new System.Collections.ArrayList();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                foreach( DevExpress.XtraGrid.Columns.GridColumn col in gridViewUserList.Columns )
                {
                    if( col.VisibleIndex == -1 )
                    {
                        ColumnList.Add( col );
                        col.Visible = true;
                    }
                }
                gridUserList.ShowPrintPreview();
                //gridCompanyList.Print();
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ������\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            finally
            {
                for( System.Int32 i = 0; i < ColumnList.Count; i++ )
                {
                    gridViewUserList.Columns[ ( ( DevExpress.XtraGrid.Columns.GridColumn )ColumnList[ i ] ).FieldName ].VisibleIndex = -1;
                }
                ColumnList = null;
                Cursor.Current = Cursors.Default;
            }

            return;
        }

        #endregion

        #region ����������� gridViewCompany
        /// <summary>
        /// ���������� �������, ������������ ��� ������� ������� ������ � ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewCompany_BeforeLeaveRow( object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e )
        {
            try
            {
                if( bIsUserListModif() == false ) { e.Allow = true; }
                else
                {
                    System.Data.DataRow row = gridViewCompany.GetDataRow( e.RowHandle );
                    if( row != null )
                    {
                        if( ( ( ( System.Guid )row[ "USERCOMPANY_COMPANY_GUID_ID" ] ).CompareTo( System.Guid.Empty ) == 0 ) &&
                            ( ( ( System.Guid )row[ "USERCOMPANY_EMPLOYEEPOST_GUID_ID" ] ).CompareTo( System.Guid.Empty ) == 0 ) )
                        {
                            gridViewCompany.DeleteRow( e.RowHandle );
                            SetModifiedToTrue();
                            e.Allow = true;
                        }
                        else
                        {
                            System.String strErrText = "���������� ������� ��������� ������:\n";
                            System.UInt16 iErrCount = 0;
                            if( ( row[ "USERCOMPANY_COMPANY_GUID_ID" ] == System.DBNull.Value ) ||
                            ( ( ( System.Guid )row[ "USERCOMPANY_COMPANY_GUID_ID" ] ).CompareTo( System.Guid.Empty ) == 0 ) )
                            {
                                strErrText += ( iErrCount > 0 ) ? ", ��������" : "��������";
                                iErrCount++;
                            }
                            if( ( row[ "USERCOMPANY_EMPLOYEEPOST_GUID_ID" ] == System.DBNull.Value ) ||
                            ( ( ( System.Guid )row[ "USERCOMPANY_EMPLOYEEPOST_GUID_ID" ] ).CompareTo( System.Guid.Empty ) == 0 ) )
                            {
                                strErrText += ( iErrCount > 0 ) ? ", ���������" : "���������";
                                iErrCount++;
                            }
                            if( iErrCount > 0 )
                            {
                                System.Windows.Forms.MessageBox.Show( this, strErrText, "������",
                                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
                                e.Allow = false;
                            }
                            else
                            {
                                e.Allow = true;
                            }
                        }
                    }
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "gridViewCompany_ValidateRow\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }
        /// <summary>
        /// ���������� �������, ������������ ��� ��������� �������� � ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewCompany_CellValueChanging( object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e )
        {
            try
            {
                if( !m_bCancelEvents )
                {
                    SetModifiedToTrue();
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "gridViewCompany_CellValueChanging()\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }
        /// <summary>
        /// ���������� ����� ���������
        /// </summary>
        private void AddCompany()
        {
            try
            {
                if( gridViewCompany.RowCount > 0 )
                {
                    // ��������� ������� ������
                    gridViewCompany.UpdateCurrentRow();
                    System.Data.DataRow CurrentRow = gridViewCompany.GetDataRow( gridViewCompany.FocusedRowHandle );
                    if( CurrentRow != null )
                    {
                        // ��������� ������������ ��������� �������� � ������� ������
                        System.String strErrText = "���������� ������� ��������� ������:\n";
                        System.UInt16 iErrCount = 0;
                        if( ( CurrentRow[ "USERCOMPANY_COMPANY_GUID_ID" ] == System.DBNull.Value ) ||
                            ( ( ( System.Guid )CurrentRow[ "USERCOMPANY_COMPANY_GUID_ID" ] ).CompareTo( System.Guid.Empty ) == 0 ) )
                        {
                            strErrText += ( iErrCount > 0 ) ? ", ��������" : "��������";
                            iErrCount++;
                        }
                        if( ( CurrentRow[ "USERCOMPANY_EMPLOYEEPOST_GUID_ID" ] == System.DBNull.Value ) ||
                            ( ( ( System.Guid )CurrentRow[ "USERCOMPANY_EMPLOYEEPOST_GUID_ID" ] ).CompareTo( System.Guid.Empty ) == 0 ) )
                        {
                            strErrText += ( iErrCount > 0 ) ? ", ���������" : "���������";
                            iErrCount++;
                        }
                        if( iErrCount > 0 )
                        {
                            System.Windows.Forms.MessageBox.Show( this, strErrText, "��������������",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
                            return;
                        }
                    }
                }
                // ��������� ����� ������
                System.Data.DataRow row = dsUser.Tables[ "dtUserCompany" ].NewRow();
                row[ "USERCOMPANY_USER_ID" ] = ( System.Int32 )( gridViewUserList.GetDataRow( gridViewUserList.FocusedRowHandle ) )[ "USER_ID" ];
                row[ "USERCOMPANY_COMPANY_GUID_ID" ] = System.Guid.Empty;
                row[ "USERCOMPANY_EMPLOYEEPOST_GUID_ID" ] = System.Guid.Empty;
                dsUser.Tables[ "dtUserCompany" ].Rows.Add( row );
                // ��������� ���������� � ���������
                gridViewCompany.RefreshData();
                // ������ ������� "� ����� ������ ������� ���������"
                SetModifiedToTrue();
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ���������� ������\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }
        /// <summary>
        /// ���������� ����� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCompany_Click( object sender, EventArgs e )
        {
            try
            {
                AddCompany();
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ���������� ������\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }
        /// <summary>
        /// �������� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelCompany_Click( object sender, EventArgs e )
        {
            try
            {
                gridViewCompany.BeforeLeaveRow -= new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler( gridViewCompany_BeforeLeaveRow );
                // �������� ����� �� ������� ������
                if( ( gridViewCompany.RowCount > 0 ) && ( gridViewCompany.FocusedRowHandle >= 0 ) )
                {
                    System.Data.DataRow row = gridViewCompany.GetDataRow( gridViewCompany.FocusedRowHandle );
                    if( row != null )
                    {
                        if( System.Windows.Forms.MessageBox.Show( this, "������� ������?", "�������������",
                           System.Windows.Forms.MessageBoxButtons.YesNo,
                           System.Windows.Forms.MessageBoxIcon.Question ) == DialogResult.Yes )
                        {
                            gridViewCompany.DeleteRow( gridViewCompany.FocusedRowHandle );
                            SetModifiedToTrue();
                        }
                    }
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ �������� ������\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            finally
            {
                gridViewCompany.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler( gridViewCompany_BeforeLeaveRow );
            }
            return;
        }
        /// <summary>
        /// ���������� ������������� �������� ����� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewCompany_InitNewRow( object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e )
        {
            try
            {
                System.Data.DataRow row = gridViewUserList.GetDataRow( gridViewUserList.FocusedRowHandle );
                if( row != null )
                {
                    DevExpress.XtraGrid.Views.Base.ColumnView view = sender as DevExpress.XtraGrid.Views.Base.ColumnView;
                    view.SetRowCellValue( e.RowHandle, view.Columns[ "USERCOMPANY_COMPANY_GUID_ID" ], System.Guid.Empty );
                    view.SetRowCellValue( e.RowHandle, view.Columns[ "USERCOMPANY_EMPLOYEEPOST_GUID_ID" ], System.Guid.Empty );
                    view.SetRowCellValue( e.RowHandle, view.Columns[ "USERCOMPANY_USER_ID" ], ( System.Int32 )row[ "USER_ID" ] );
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ������������� �������� ����� ������\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            finally
            {
            }
            return;
        }
        /// <summary>
        /// ���������� �������, ������������, ���� ��� �������� ������������ ��������� �������� � ������ �������� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewCompany_InvalidRowException( object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e )
        {
            try
            {
                if( e.Exception.GetType().Name == "ConstraintException" )
                {
                    e.ErrorText = "������� ������������ ��� ��������� ����� �� ��������� � ��������.\n���������, ����������, ��������� �������� ��� ������� ������.\n";
                    e.WindowCaption = "������������ ������";
                    if( System.Windows.Forms.MessageBox.Show( this, "������� ������������ ��� ��������� ����� �� ��������� � ��������.\n�������� ���������?\n", "������������ ������",
                       System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error ) == DialogResult.Yes )
                    {
                        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
                    }
                    else
                    {
                        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                    }
                }
                else
                {
                    e.ErrorText = "�������� �������� � ������� ������.\n���������, ����������, ��������� ��������.\n����� ������: " + e.Exception.Message;
                    e.WindowCaption = "������";
                    e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "gridViewCompany_InvalidRowException" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }

        private void gridViewCompany_KeyDown( object sender, KeyEventArgs e )
        {
            try
            {
                if( ( e.Alt == false ) && ( e.Control == false ) && ( e.KeyCode == Keys.Down ) )
                {
                    // ������ ������� "������� ����"
                    if( gridViewCompany.FocusedRowHandle == ( gridViewCompany.RowCount - 1 ) )
                    {
                        // ������ ��������� �� ��������� ������
                        AddCompany();
                    }
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "gridViewCompany_KeyDown" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }

        #endregion

        #region ����������� gridViewEmail
        /// <summary>
        /// ���������� �������, ������������ ��� ������� ������� ������ � ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewEmailList_BeforeLeaveRow( object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e )
        {
            try
            {
                if( bIsUserListModif() == false ) { e.Allow = true; }
                else
                {
                    System.Data.DataRow row = gridViewEmailList.GetDataRow( e.RowHandle );
                    if( row != null )
                    {
                        if( ( ( row[ "USERMAIL_EMAIL_ADDRESS" ] == System.DBNull.Value ) ||
                            ( ( ( System.String )row[ "USERMAIL_EMAIL_ADDRESS" ] ).CompareTo( "" ) == 0 ) ) )
                        {
                            gridViewEmailList.DeleteRow( e.RowHandle );
                            SetModifiedToTrue();
                            e.Allow = true;
                        }
                        else
                        {
                            System.String strErrText = "���������� ������� ��������� ������:\n";
                            System.UInt16 iErrCount = 0;
                            if( ( row[ "USERMAIL_EMAIL_ADDRESS" ] == System.DBNull.Value ) ||
                            ( ( ( System.String )row[ "USERMAIL_EMAIL_ADDRESS" ] ).CompareTo( "" ) == 0 ) )
                            {
                                strErrText += ( iErrCount > 0 ) ? ", �����" : "�����";
                                iErrCount++;
                            }
                            if( iErrCount > 0 )
                            {
                                System.Windows.Forms.MessageBox.Show( this, strErrText, "��������������",
                                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
                                e.Allow = false;
                            }
                            else
                            {
                                e.Allow = true;
                            }
                        }
                    }
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "gridViewEmailList_BeforeLeaveRow\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }

            return;
        }
        private const System.String m_strEmailDomen = "@dolcevita.by";
        /// <summary>
        /// ���������� ������������� �������� ����� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewEmailList_InitNewRow( object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e )
        {
            try
            {
                System.Data.DataRow row = gridViewUserList.GetDataRow( gridViewUserList.FocusedRowHandle );
                if( row != null )
                {
                    DevExpress.XtraGrid.Views.Base.ColumnView view = sender as DevExpress.XtraGrid.Views.Base.ColumnView;
                    view.SetRowCellValue( e.RowHandle, view.Columns[ "USERMAIL_EMAIL_ADDRESS" ], ( System.String )row[ "USER_LOGONNAME" ] + m_strEmailDomen );
                    view.SetRowCellValue( e.RowHandle, view.Columns[ "USERMAIL_EMAIL_NOTACTIVE" ], false );
                    view.SetRowCellValue( e.RowHandle, view.Columns[ "USERMAIL_EMAIL_MAIN" ], false );
                    view.SetRowCellValue( e.RowHandle, view.Columns[ "USEREMAIL_USER_ID" ], ( System.Int32 )row[ "USER_ID" ] );
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ������������� �������� ����� ������\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            finally
            {
            }
            return;
        }
        /// <summary>
        /// ���������� �������, ������������ ��� ��������� �������� � ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewEmailList_CellValueChanging( object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e )
        {
            try
            {
                if( !m_bCancelEvents )
                {
                    if( e.Column == this.colEmailChecked )
                    {
                        // ������� "�������� �������� �����"
                        if( ( ( System.Boolean )e.Value ) == true )
                        {
                            // � ���� ������� ��������� �������
                            if( gridViewEmailList.RowCount > 1 )
                            {
                                // �����, �������� ������� ����� �������
                                System.String strMainAdress = ( System.String )( gridViewEmailList.GetDataRow( gridViewEmailList.FocusedRowHandle ) )[ "USERMAIL_EMAIL_ADDRESS" ];
                                // ������ ���� ������� ������������
                                System.Data.DataRow[] EmailList = gridViewUserList.GetDataRow( gridViewUserList.FocusedRowHandle ).GetChildRows( dsUser.Relations[ "rlUserEmail" ] );
                                if( EmailList.Length > 1 )
                                {
                                    // ��������� �� ������ � ��������� ������ ���� �������� �����
                                    foreach( System.Data.DataRow row in EmailList )
                                    {
                                        row[ "USERMAIL_EMAIL_MAIN" ] = ( ( ( System.String )row[ "USERMAIL_EMAIL_ADDRESS" ] ) == strMainAdress );
                                    }
                                }
                            }
                            // ��������� ��������
                            gridViewEmailList.RefreshData();
                        }
                    }
                    SetModifiedToTrue();

                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "gridViewEmailList_CellValueChanging()\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }
        /// <summary>
        /// ���������� ������ ��������� ������
        /// </summary>
        private void AddEmail()
        {
            try
            {
                if( gridViewEmailList.RowCount > 0 )
                {
                    // ��������� ������� ������
                    gridViewEmailList.UpdateCurrentRow();
                    System.Data.DataRow CurrentRow = gridViewEmailList.GetDataRow( gridViewEmailList.FocusedRowHandle );
                    if( CurrentRow != null )
                    {
                        // ��������� ������������ ��������� �������� � ������� ������
                        System.String strErrText = "���������� ������� ��������� ������:\n";
                        System.UInt16 iErrCount = 0;
                        if( ( CurrentRow[ "USERMAIL_EMAIL_ADDRESS" ] == System.DBNull.Value ) ||
                            ( ( ( System.String )CurrentRow[ "USERMAIL_EMAIL_ADDRESS" ] ).CompareTo( "" ) == 0 ) )
                        {
                            strErrText += ( iErrCount > 0 ) ? ", �����" : "�����";
                            iErrCount++;
                        }
                        if( iErrCount > 0 )
                        {
                            System.Windows.Forms.MessageBox.Show( this, strErrText, "��������������",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
                            return;
                        }
                    }
                }
                // ��������� ����� ������
                System.Data.DataRow row = dsUser.Tables[ "dtUserEmail" ].NewRow();
                //row[ "USERMAIL_EMAIL_ADDRESS" ] = ( System.String )( gridViewUserList.GetDataRow( gridViewUserList.FocusedRowHandle ) )[ "USER_LOGONNAME" ] + m_strEmailDomen;
                row[ "USERMAIL_EMAIL_NOTACTIVE" ] = false;
                row[ "USERMAIL_EMAIL_MAIN" ] = false;
                row[ "USEREMAIL_USER_ID" ] = ( System.Int32 )( gridViewUserList.GetDataRow( gridViewUserList.FocusedRowHandle ) )[ "USER_ID" ];
                dsUser.Tables[ "dtUserEmail" ].Rows.Add( row );
                // ��������� ���������� � ���������
                gridViewEmailList.RefreshData();
                // ������ ������� "� ����� ������ ������� ���������"
                SetModifiedToTrue();
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ���������� ������\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }

            return;
        }

        /// <summary>
        /// ���������� ����� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEmail_Click( object sender, EventArgs e )
        {
            try
            {
                AddEmail();
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ ���������� ������\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }
        /// <summary>
        /// �������� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteEmail_Click( object sender, EventArgs e )
        {
            try
            {
                gridViewEmailList.BeforeLeaveRow -= new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler( gridViewEmailList_BeforeLeaveRow );
                // �������� ����� �� ������� ������
                if( ( gridViewEmailList.RowCount > 0 ) && ( gridViewEmailList.FocusedRowHandle >= 0 ) )
                {
                    System.Data.DataRow row = gridViewEmailList.GetDataRow( gridViewEmailList.FocusedRowHandle );
                    if( row != null )
                    {
                        if( System.Windows.Forms.MessageBox.Show( this, "������� ������?", "�������������",
                           System.Windows.Forms.MessageBoxButtons.YesNo,
                           System.Windows.Forms.MessageBoxIcon.Question ) == DialogResult.Yes )
                        {
                            gridViewEmailList.DeleteRow( gridViewEmailList.FocusedRowHandle );
                            SetModifiedToTrue();
                        }
                    }
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "������ �������� ������\n" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            finally
            {
                gridViewEmailList.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler( gridViewEmailList_BeforeLeaveRow );
            }
            return;
        }
        /// <summary>
        /// ���������� �������, ������������, ���� ��� �������� ������������ ��������� �������� � ������ �������� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewEmailList_InvalidRowException( object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e )
        {
            try
            {
                if( gridViewEmailList.GetDataRow( e.RowHandle ) != null )
                {
                    if( e.Exception.GetType().Name == "ConstraintException" )
                    {
                        e.ErrorText = "������� ������������ ��� �������� ����� �������� �����\n���������, ����������, ��������� �������� ��� ������� ������.\n";
                        e.WindowCaption = "������������ ������";
                        if( System.Windows.Forms.MessageBox.Show( this, "������� ������������ ��� �������� ����� �������� �����.\n�������� ���������?\n", "������������ ������",
                           System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error ) == DialogResult.Yes )
                        {
                            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
                        }
                        else
                        {
                            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                        }
                    }
                    else
                    {
                        e.ErrorText = "�������� �������� � ������� ������.\n���������, ����������, ��������� ��������.\n����� ������: " + e.Exception.Message;
                        e.WindowCaption = "������";
                        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
                    }
                }
            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "gridViewCompany_InvalidRowException" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }

        private void gridViewEmailList_KeyDown( object sender, KeyEventArgs e )
        {
            try
            {
                if( ( e.Alt == false ) && ( e.Control == false ) && ( e.KeyCode == Keys.Down ) )
                {
                    // ������ ������� "������� ����"
                    if( gridViewEmailList.FocusedRowHandle == ( gridViewEmailList.RowCount - 1 ) )
                    {
                        // ������ ��������� �� ��������� ������
                        AddEmail();
                    }
                }

            }
            catch( System.Exception f )
            {
                System.Windows.Forms.MessageBox.Show( this, "gridViewEmailList_KeyDown" + f.Message, "������",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
            }
            return;
        }

        #endregion

    }

    public class ViewUser : PlugIn.IClassTypeView
    {
        public override void Run( UniXP.Common.MENUITEM objMenuItem, System.String strCaption )
        {
            frmUser obj = new frmUser( objMenuItem.objProfile );
            obj.Text = strCaption;
            obj.MdiParent = objMenuItem.objProfile.m_objMDIManager.MdiParent;
            obj.Visible = true;
        }
    }

}