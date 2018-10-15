using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaSandBox {

	/// <summary>
	/// コマンドのインターフェース
	/// </summary>
	public interface ICommand {

		/// <summary>
		/// コマンドを実行するための文字列
		/// </summary>
		/// <returns></returns>
		string GetCommandString();

		/// <summary>
		/// 実行内容
		/// </summary>
		/// <param name="inputCommands"></param>
		/// <returns></returns>
		CommandResult Execute(string[] inputCommands);
	}
}
