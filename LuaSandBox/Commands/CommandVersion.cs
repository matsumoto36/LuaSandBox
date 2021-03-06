﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaSandBox.Commands {

	/// <summary>
	/// バージョンを確認するコマンド
	/// </summary>
	public class CommandVersion : ICommand {

		public CommandResult Execute(string[] inputCommands) {
			Console.WriteLine("version is 1.0.0");
			return CommandResult.Executed;
		}

		public string GetCommandString() => "version";
	}
}
