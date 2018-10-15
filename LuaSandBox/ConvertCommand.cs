using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaSandBox {
	public static class ConvertCommand {

		/// <summary>
		/// コマンドに変換する拡張
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string[] ToCommandList(this string str) =>
			str.Split(' ');

	}
}
