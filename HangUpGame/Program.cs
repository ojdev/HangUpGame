/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/17
 * 时间: 19:47
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Windows.Forms;

namespace HangUpGame
{
	internal sealed class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new World());
			/*Console.WriteLine("HangUp Start.");
			Lead lead = new Lead("兔子宝宝");
			// TODO: Implement Functionality Here
			lead.Go(5);
			//Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);*/
		}
	}
}