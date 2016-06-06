/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/19
 * 时间: 21:09
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace HangUpGame.Equipment.Weapon
{
	/// <summary>
	/// Description of ShortDagger.
	/// </summary>
	public class ShortDagger:IWeapon
	{

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

		public ShortDagger()
		{
			this.Name = "短小的匕首";
			this.CritChance = 2.3;
			this.MinAttack = 7;
			this.MaxAttack = 11;
		}
	}
}
