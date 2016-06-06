/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/19
 * 时间: 21:07
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace HangUpGame.Equipment.Weapon
{
	/// <summary>
	/// Description of BaseWeapon.
	/// </summary>
	public class BaseWeapon:IWeapon
	{
		#region IWeapon implementation

		public string Name {
			get ;
			set;
		}

		public Int64 MinAttack {
			get ;
			set ;
		}

		public Int64 MaxAttack {
			get;
			set ;
		}

		public double CritChance {
			get ;
			set ;
		}

		#endregion

		public BaseWeapon()
		{
			this.Name = "电动玩具";
			this.CritChance = 2;
			this.MinAttack = 3;
			this.MaxAttack = 3;
		}
	}
}
