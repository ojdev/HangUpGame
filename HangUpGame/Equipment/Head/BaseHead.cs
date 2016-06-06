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
	/// Description of BaseHead.
	/// </summary>
	public class BaseHead : IHead
	{
		#region IHead implementation

		public string Name{ set; get; }
		public float PhysicalProtectionMin { get ; set; }
		public float PhysicalProtectionMax { get ; set; }


		#endregion

 
		public BaseHead()
		{
			this.Name = "没用的头巾";
			this.PhysicalProtectionMin = 10;
			this.PhysicalProtectionMax = 20;
		}
	}
}
