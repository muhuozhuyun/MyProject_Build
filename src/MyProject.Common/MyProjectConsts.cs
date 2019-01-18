using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Common
{
    public static class MyProjectConsts
    {
        public const string ProjectIdResolveKey = "MyProjectId";
        public const string SysAdminName = "ADMIN";
        public const string AlterApproval = "变更审批";

        public const string InspectionProblemType_Quality = "质量";
        public const string InspectionProblemType_Safety = "安全";
        public const string InspectionProblemType_Other = "其他";
        public const string InspectionProblemType_EnviromentProtection = "环保";

        public const string MeasureContractTermName = "本期交工金额";
        public const string EngineeringParts = "工程部位";
        public const string QuantitySupervisions = "质量监管清单";

        public const string ApiGroup_User = "用户登录与用户信息";
        public const string ApiGroup_Organization = "组织架构信息";
        public const string ApiGroup_File = "文件上传/下载";
        public const string ApiGroup_UsersAttendance = "用户考勤情况表";
        public const string ApiGroup_UsersProject = "用户获取项目/单位信息";
        public const string ApiGroup_SecurityInsoection = "质安巡检/质安问题整改";

        public const string ApiCgroup_QualityTracing = "质量安全溯源";
        public const string ApiGroup_QualitySupervision = "质量监督";
        public const string ApiGroup_Instrucstion = "指令";
        public const string PressGet = "压力机组列表";
        public const string Presssk = "压力机试块数据";
        public const string ApiSave = "拌合站接口数据";
        public const string PressApiSave = "试验数据接口";
        public const string ApiGroup_ConstructionLog = "施工日志";
        public const string ApiGroup_ConcealedWork = "隐蔽工程";
        public const string ApiGroup_Process = "工序";
        public const string ApiGroup_OA = "OA";
        public const string ApiGroup_DecisionSupport = "辅助决策";
        public const string ApiGroup_EngineeringDivision = "检测任务管理";
        public const string ApiGroup_DataCollect = "数据采集";

        public const string Dict_ProjectStatusName = "项目状态";
        public const string Dict_ContractTypeName = "合同类型";
        public const string Dict_ContractStatusName = "合同状态";
        public const string Dict_AlterationConditionTypeName = "变更条件类型";
        public const string Dict_AlterationTypeName = "变更类别";
        public const string Dict_ProjectPhaseName = "项目阶段";
        public const string Dict_VisualProgressStatus = "形象进度状态";

        /// <summary>
        /// 合同类型字典值
        /// </summary>
        public static class Dict_ContractTypeValues
        {
            public static readonly string Constraction = "1"; // 施工合同
            public static readonly string Supervising = "2"; // 监理合同
        }

        public static class Dict_ProjectStatusValues
        {
            public static readonly string Done = "5"; // 完工待验收
            public static readonly string Transfered = "7"; // 已移交
        }
    }
}
