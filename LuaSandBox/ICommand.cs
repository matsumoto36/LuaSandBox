using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaSandBox {
	public interface ICommand {

		string GetCommandString();

		void Execute(string[] inputCommands);
	}
}
