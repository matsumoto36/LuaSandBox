using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.REPL;

namespace LuaSandBox.Commands {

	/// <summary>
	/// luaをREPLで実行するコマンド
	/// </summary>
	public class CommandInteractiveLua : ICommand {

		const string ExtensionFilePath = @"LuaExtensions\CommandExtensions.lua";
		const string ExtensionObjectName = "luaExtensionObject";


		bool _isActive = false;
		ReplInterpreter _luaInterpreter;

		public CommandResult Execute(string[] inputCommands) {

			//REPLをセットアップする
			SetUpREPL();

			_isActive = true;

			Console.WriteLine("Start REPL.");

			while(_isActive) {

				Console.Write(_luaInterpreter.ClassicPrompt);

				var input = Console.ReadLine();
				var inputByte = Encoding.UTF8.GetBytes(input);

				try {
					_luaInterpreter.Evaluate(input);
				}
				catch (Exception e) {
					Console.WriteLine("[ERROR] " + e.Message);
				}

			}

			Console.WriteLine("End REPL.");

			return CommandResult.Executed;
		}

		public string GetCommandString() => "lua";

		/// <summary>
		/// REPLのセットアップ
		/// </summary>
		public void SetUpREPL() {
			var lua = new Script();
			UserData.RegisterType<LuaREPLExtension>();
			lua.Globals.Set(ExtensionObjectName, UserData.Create(new LuaREPLExtension(this)));
			_luaInterpreter = new ReplInterpreter(lua);

			//拡張用のスクリプトを読み込み
			using(var sr = new StreamReader(ExtensionFilePath, Encoding.GetEncoding("UTF-8"))) {

				//テキストをインタプリタ用に変換
				var text = sr.ReadToEnd()
					.Split(new string[] { Environment.NewLine, "\t" }, StringSplitOptions.RemoveEmptyEntries)
					.Aggregate((s1, s2) => s1 + " " + s2);

				//拡張用スクリプトをあらかじめ実行
				_luaInterpreter.Evaluate(text);
			}

		}

		public void ExitREPL() {
			_isActive = false;
		}

		public void ResetREPL() {
			SetUpREPL();
			Console.WriteLine("Reset REPL.");
		}
	}

	/// <summary>
	/// REPLの拡張コマンドを実装
	/// </summary>
	class LuaREPLExtension {

		CommandInteractiveLua _command;

		public LuaREPLExtension(CommandInteractiveLua command) {
			_command = command;
		}

		public void CommandExit() {
			_command.ExitREPL();
		}
		
		public void CommandReset() {
			_command.ResetREPL();
		}

	}

}
