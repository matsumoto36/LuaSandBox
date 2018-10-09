using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaSandBox.Commands;

namespace LuaSandBox {
	public class CommandList {

		public static ICommand[] Commands {
			get; private set;
		} = new ICommand[] {
			new CommandVersion(),
			new CommandExecLua()
		};

		public static string GetExitCode() => "exit";
	}
}
