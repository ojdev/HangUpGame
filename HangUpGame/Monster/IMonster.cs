/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/17
 * 时间: 22:39
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace HangUpGame.Monster
{
	/// <summary>
	/// Description of IMonster.
	/// </summary>
	public interface IMonster
	{
		#region 主角属性
		/// <summary>
		/// 姓名
		/// </summary>
		string Name{ set; get; }
		/// <summary>
		/// 当前血量
		/// </summary>
		Int64 CurrentBlood{ set; get; }
		/// <summary>
		/// 总血量
		/// </summary>
		Int64 TotaleBlood{ set; get; }
		/// <summary>
		/// 最小攻击力
		/// </summary>
		Int64 AttackMin{ set; get; }
		/// <summary>
		/// 最大攻击力
		/// </summary>
		Int64 AttackMax{ set; get; }
		/// <summary>
		/// 掉落的经验值
		/// </summary>
		Int64 DropXP{ set; get; }
		#endregion
		/// <summary>
		/// 受到攻击
		/// </summary>
		/// <param name="attack"></param>
		void Attacked(Int64 attack);
	}
}
