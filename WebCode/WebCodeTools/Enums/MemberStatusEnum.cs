using System.ComponentModel;

namespace WebCodeTools.Enums
{
    public enum MemberStatusEnum
    {
        [Description("启用")]
        Use=0,
        [Description("删除")]
        Delete=1,
        [Description("冻结")]
        Block = 2
    }
}
