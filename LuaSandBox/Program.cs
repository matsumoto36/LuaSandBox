using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaSandBox {
	class Program {
		static void Main(string[] args) {

			while(true) {

				var input = Console.ReadLine().ToCommandList();

				if(input.Length <= 0) continue;

				if(input[0] == CommandList.GetExitCode()) break;

				foreach(var item in CommandList.Commands) {
					if(input[0] == item.GetCommandString())
						item.Execute(input);
				}

			}

		}
	}
}
