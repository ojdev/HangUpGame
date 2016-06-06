/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/17
 * 时间: 19:53
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace HangUpGame.Equipment.Head
{
	/// <summary>
	/// Description of IHead.
	/// </summary>
	public interface IHead
	{
		string Name{ set; get; }
		/// <summary>
		/// 物理防护能力小
		/// </summary>
		float PhysicalProtectionMin{ set; get; }
		/// <summary>
		/// 物理防护能力大
		/// </summary>
		float PhysicalProtectionMax{ set; get; }
	}
}
