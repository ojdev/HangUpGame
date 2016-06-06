/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/17
 * 时间: 22:21
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using HangUpGame.Map;
using HangUpGame.Monster;

namespace HangUpGame
{
	/// <summary>
	/// Description of Nature.
	/// </summary>
	public static class Nature
	{
		static Nature()
		{
			CurrentMap = new Kitchen();
			ProcressingValue = 1;
			CurrectAttack = true;
		}
		private static readonly Random rand = new Random(DateTime.Now.Millisecond);
		#region 自然属性
		public static Int64 ProcressingValue { set; get; }
		/// <summary>
		/// 一年包含多少天
		/// </summary>
		public static Int64 YearOfDay{ get { return 365; } }
		/// <summary>
		/// 遇敌几率
		/// </summary>
		public static Int64 EncounterProbability{ get { return 30; } }
		/// <summary>
		/// 当前对战的怪物
		/// </summary>
		public static IMonster CurrentMonster{ set; get; }
		/// <summary>
		/// 当前地图
		/// </summary>
		public static IMap CurrentMap{ set; get; }
		/// <summary>
		/// 当前出手的是谁
		/// </summary>
		public static bool CurrectAttack { set; get; }
		#endregion
		public static void HadMet(Lead lead)
		{
			CurrentMonster = CurrentMap.BuildMonster();
			//根据敏捷决定出手顺序
			CurrectAttack = true;
		}
		public static Int64 BuildRandomNumber(Int64 minValue, Int64 maxValue)
		{
			return (Int64)rand.Next((int)minValue, (int)maxValue);
		}
		public static Int64 Battle(Lead lead)
		{
			Int64 attack = 0;
			//真：主角，假：怪物
			if (CurrectAttack) {
				if (lead.CurrentBlood > 0) {
					attack = BuildRandomNumber(lead.AttackMin, lead.AttackMax);
					CurrentMonster.CurrentBlood -= attack;
				}
			} else {
				if (CurrentMonster.CurrentBlood > 0) {
					attack = BuildRandomNumber(CurrentMonster.AttackMin, CurrentMonster.AttackMax);
					lead.CurrentBlood -= attack;
				}
			}
			CurrectAttack = !CurrectAttack;
			return attack;
		}
	}
}
