using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaSandBox.Commands;

namespace LuaSandBox {

	/// <summary>
	/// コマンドのリストを保管しておくクラス
	/// </summary>
	public static class CommandList {

		public static ICommand[] Commands {
			get; private set;
		} = new ICommand[] {
			new CommandExit(),
			new CommandVersion(),
			new CommandExecLua(),
			new CommandInteractiveLua(),
			new CommandHelp(),
		};
	}
}
