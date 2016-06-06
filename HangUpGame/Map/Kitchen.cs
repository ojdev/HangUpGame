/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/19
 * 时间: 21:24
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using HangUpGame.Monster;

namespace HangUpGame.Map
{
	/// <summary>
	/// Description of Kitchen.
	/// </summary>
	public class Kitchen:IMap
	{
		#region IMap implementation

		public IMonster BuildMonster()
		{
			return Monsters[Nature.BuildRandomNumber(0, Monsters.Length)];
		}
		private string _Name = "厨房";
		public string Name {
			get {
				return _Name;
			}
			set { 
				_Name = value;
			}
		}

		public Int64[][] Coordinate {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public IMonster[] Monsters {
			get {
				return new IMonster[] {
					new Rabbit(),
					new Rabbit{ Name = "蓝色兔子" },
					new Rabbit{ Name = "白色兔子" },
					new Rabbit{ Name = "黑色兔子" },
					new Rabbit{ Name = "紫色兔子" },
					new Rabbit {
						Name = "大兔宝宝[BOSS]",
						TotaleBlood = 10000000,
						CurrentBlood = 10000000,
						AttackMin = 10000000,
						AttackMax = 10000000
					},
					new Rabbit{ Name = "白色兔子" },
					new Rabbit { 
						Name = "玉兔[精英]",
						TotaleBlood = 100,
						CurrentBlood = 100,
						AttackMin = 100,
						AttackMax = 100
					},
					new Rabbit{ Name = "公兔子" },
					new Rabbit{ Name = "母兔子" },
					new Rabbit { 
						Name = "兔女郎[淫兽]",
						TotaleBlood = 100,
						CurrentBlood = 100,
						AttackMin = 0,
						AttackMax = 0
					},
					new Hamster(),
					new Hamster { 
						Name = "仓鼠王[BOOS]",
						AttackMin = 2000,
						AttackMax = 2000,
						CurrentBlood = 20000,
						TotaleBlood = 20000
					},
					new Hamster { 
						Name = "仓鼠将军",
						AttackMin = 200,
						AttackMax = 200,
						CurrentBlood = 200,
						TotaleBlood = 200
					},
					new Hamster { 
						Name = "胆小的仓鼠",
						AttackMin = 0,
						AttackMax = 10000,
						CurrentBlood = 10000,
						TotaleBlood = 10000
					}, new Hamster { 
						Name = "勇敢的的仓鼠",
						AttackMin = 5000,
						AttackMax = 10000,
						CurrentBlood = 10000,
						TotaleBlood = 10000
					}
				};
			}
		}

		#endregion

		public Kitchen()
		{
		}
	}
}
