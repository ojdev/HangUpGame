/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/17
 * 时间: 22:41
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace HangUpGame.Monster
{
	/// <summary>
	/// Description of PinkRabbit.
	/// </summary>
	public class Rabbit : IMonster
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

		public Rabbit()
		{
			this.Name = "粉色兔子";
			this.CurrentBlood = this.TotaleBlood = 50;
			this.AttackMin = this.AttackMax = 1;
			this.DropXP = 50;
		}
		public void Attacked(Int64 attack)
		{
			this.CurrentBlood -= attack;
		}
	}
}
