using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaSandBox {
	public static class ConvertCommand {

		public static string[] ToCommandList(this string str) =>
			str.Split(' ');

	}
}
