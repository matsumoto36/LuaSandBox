using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaSandBox {
	class Program {
		static void Main(string[] args) {

			//コマンドの結果を格納
			var result = CommandResult.Executed;

			while(result != CommandResult.RequestExit) {

				//コマンドを入力
				var input = Console.ReadLine().ToCommandList();

				if(input.Length <= 0) continue;

				//リストにあるコマンドに一致するか調べる
				foreach(var item in CommandList.Commands) {
					if(input[0] != item.GetCommandString()) continue;

					//一致したらコマンドを実行
					result = item.Execute(input);
					if(result == CommandResult.RequestExit) break;
				}
			}

		}
	}
}
