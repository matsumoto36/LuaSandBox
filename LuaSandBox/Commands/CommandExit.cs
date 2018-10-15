using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaSandBox.Commands {

	/// <summary>
	/// 終了するコマンド
	/// </summary>
	public class CommandExit : ICommand {

		public CommandResult Execute(string[] inputCommands) {
			return CommandResult.RequestExit;
		}

		public string GetCommandString() => "exit";
	}
}
