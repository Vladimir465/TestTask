using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextQuests
{
	/// <summary>
	/// Задание конфигурации игры
	/// </summary>
	class GameTest : Game
	{
		public GameTest(IAction[] action, Room road) : base(action)
		{
			ConsoleIO console = new ConsoleIO(this);
			road.Output = console;
			Input = console;
		}
	}
}
