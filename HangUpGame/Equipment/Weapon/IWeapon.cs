/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/19
 * 时间: 20:59
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace HangUpGame.Equipment.Weapon
{
	/// <summary>
	/// Description of IWeapon.
	/// </summary>
	public interface IWeapon
	{
		string Name{ set; get; }
		Int64 MinAttack{ set; get; }
		Int64 MaxAttack{ set; get; }
		double CritChance{ set; get; }
	}
}
