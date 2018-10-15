using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaSandBox {

	/// <summary>
	/// コマンドの結果の種類
	/// </summary>
	public enum CommandResult {
		Executed,
		Canceled,
		RequestExit
	}
}
