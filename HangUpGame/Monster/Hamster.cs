/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/19
 * 时间: 22:37
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace HangUpGame.Monster
{
	/// <summary>
	/// Description of Hamster.
	/// </summary>
	public class Hamster:IMonster
	{
		#region IMonster implementation
		public string Name {
			get;
			set;
		}

		public Int64 CurrentBlood {
			get;
			set ;
		}

		public Int64 TotaleBlood {
			get ;
			set ;
		}

		public Int64 AttackMin {
			get;
			set ;
		}

		public Int64 AttackMax {
			get ;
			set ;
		}
		public Int64 DropXP {
			get ;
			set ;
		}
		#endregion
		public Hamster()
		{
			this.Name = "仓鼠";
			this.CurrentBlood = this.TotaleBlood = 75;
			this.AttackMin = 2;
			this.AttackMax = 3;
			this.DropXP = 75;
		}
		
		public void Attacked(Int64 attack)
		{
			this.CurrentBlood -= attack;
		}
	}
}
