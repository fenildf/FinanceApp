namespace FinanceApp.Common
{
    /// <summary>
    /// 状态枚举
    /// </summary>
    public enum StatusEnum
    {
        无效数据 = -1,
        已作废 = 1,
        已关闭 = 10,
        已录入 = 20,
        已撤返 = 25,
        录入禁提交 = 30,
        审核拒绝 = 35,
        待审核 = 40,
        绑定合约 = 42,
        已生效 = 50,
        已冻结 = 60,
        执行修改 = 70,
        已完成 = 80,
        部分完成=81
    }
}
