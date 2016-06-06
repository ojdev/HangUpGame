/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/19
 * 时间: 21:19
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using HangUpGame.Monster;

namespace HangUpGame.Map
{
	/// <summary>
	/// Description of IMap.
	/// </summary>
	public interface IMap
	{
		string Name{ set; get; }
		Int64 [][] Coordinate{ set; get; }
		IMonster[] Monsters{  get; }
		IMonster BuildMonster();
	}
}
