using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLua;

namespace LuaSandBox.Commands {
	public class CommandExecLua : ICommand {
		public void Execute(string[] inputCommands) {

			if(inputCommands.Length <= 1) {
				Console.WriteLine("exec [path]");
				return;
			}

			if(!File.Exists(inputCommands[1])) {
				Console.WriteLine("file not exits.");
				return;
			}

			var lua = new Lua();
			lua.DoFile(inputCommands[1]);
			lua.Close();

		}

		public string GetCommandString() => "exec";
	}
}
