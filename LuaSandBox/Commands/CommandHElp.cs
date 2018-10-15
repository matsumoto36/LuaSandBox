using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaSandBox.Commands {

	/// <summary>
	/// ヘルプを表示するコマンド
	/// </summary>
	public class CommandHelp : ICommand {

		public CommandResult Execute(string[] inputCommands) {
			Console.WriteLine("Commands :");
			foreach(var item in CommandList.Commands) {
				if(item is CommandHelp) continue;

				Console.Write(item.GetCommandString());
				Console.Write(" ");
			}
			Console.WriteLine();

			return CommandResult.Executed;
		}

		public string GetCommandString() => "help";
	}
}
