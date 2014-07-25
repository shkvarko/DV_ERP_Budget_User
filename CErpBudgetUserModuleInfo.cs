using System;
using System.Collections.Generic;
using System.Text;

namespace ErpBudgetUser
{
    public class CErpBudgetUserModuleClassInfo : UniXP.Common.CModuleClassInfo
    {
        public CErpBudgetUserModuleClassInfo()
        {
            UniXP.Common.CLASSINFO objClassInfo;

            objClassInfo = new UniXP.Common.CLASSINFO();
            objClassInfo.enClassType = UniXP.Common.EnumClassType.mcView;
            objClassInfo.strClassName = "ErpBudgetUser.ViewUser";
            objClassInfo.strName = "���������� �������������";
            objClassInfo.strDescription = "������ ��� �������������� ������� �������������";
            objClassInfo.lID = 0;
            objClassInfo.nImage = 1;
            objClassInfo.strResourceName = "IMAGES_USERSMALL";
            m_arClassInfo.Add( objClassInfo );
        }
    }

    public class CErpBudgetUserModuleInfo : UniXP.Common.CClientModuleInfo
    {
        public CErpBudgetUserModuleInfo()
            : base( System.Reflection.Assembly.GetExecutingAssembly(),
            UniXP.Common.EnumDLLType.typeItem,
            new System.Guid( "{8EB5580D-22D0-4bee-8770-684180B63278}" ),
            new System.Guid( "{a8e694df-15a3-4713-80ac-304b3fe911e8}" ),
            ErpBudgetUser.Properties.Resources.IMAGES_USER,
            ErpBudgetUser.Properties.Resources.IMAGES_USERSMALL_PNG )
        {
        }

        /// <summary>
        /// ��������� �������� �� �������� ������������ ��������� ������ � �������.
        /// </summary>
        /// <param name="objProfile">������� ������������.</param>
        public override System.Boolean Check( UniXP.Common.CProfile objProfile )
        {
            return true;
        }
        /// <summary>
        /// ��������� �������� �� ��������� ������ � �������.
        /// </summary>
        /// <param name="objProfile">������� ������������.</param>
        public override System.Boolean Install( UniXP.Common.CProfile objProfile )
        {
            return true;
        }
        /// <summary>
        /// ��������� �������� �� �������� ������ �� �������.
        /// </summary>
        /// <param name="objProfile">������� ������������.</param>
        public override System.Boolean UnInstall( UniXP.Common.CProfile objProfile )
        {
            return true;
        }
        /// <summary>
        /// ���������� �������� �� ���������� ��� ��������� ����� ������ ������������� ������.
        /// </summary>
        /// <param name="objProfile">������� ������������.</param>
        public override System.Boolean Update( UniXP.Common.CProfile objProfile )
        {
            return true;
        }
        /// <summary>
        /// ���������� ������ ��������� ������� � ������ ������.
        /// </summary>
        public override UniXP.Common.CModuleClassInfo GetClassInfo()
        {
            return new CErpBudgetUserModuleClassInfo();
        }
    }

    public class ModuleInfo : PlugIn.IModuleInfo
    {
        public UniXP.Common.CClientModuleInfo GetModuleInfo()
        {
            return new CErpBudgetUserModuleInfo();
        }
    }

}
