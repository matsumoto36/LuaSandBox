using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaSandBox.Commands {
	public class CommandVersion : ICommand {

		public void Execute(string[] inputCommands) {
			Console.WriteLine("version is 1.0.0");
		}

		public string GetCommandString() => "version";
	}
}
