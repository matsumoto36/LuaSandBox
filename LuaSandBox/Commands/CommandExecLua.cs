using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MoonSharp.Interpreter;

namespace LuaSandBox.Commands {

	/// <summary>
	/// luaスクリプトを実行するコマンド
	/// </summary>
	public class CommandExecLua : ICommand {
		public CommandResult Execute(string[] inputCommands) {

			if(inputCommands.Length <= 1) {
				Console.WriteLine("exec [path]");
				return CommandResult.Canceled;
			}

			if(!File.Exists(inputCommands[1])) {
				Console.WriteLine("file not exits.");
				return CommandResult.Canceled;
			}

			var lua = new Script();
			lua.DoFile(inputCommands[1]);

			return CommandResult.Executed;
		}

		public string GetCommandString() => "exec";
	}
}
