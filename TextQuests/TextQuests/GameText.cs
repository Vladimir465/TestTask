using System;

namespace TextQuests
{
	class GameText	: Game
	{
		Rooms _room;
		public GameText(Rooms room)
		{
			_room = room;
		}
		protected override void ExitInfo()
		{
			Console.WriteLine("Вы вышли");
			Console.ReadLine();
		}
		private void Error()
		{
			Console.WriteLine("Введите верное значение 1,2 или 3\n");
		}

		protected override void Info()
		{
			Console.WriteLine("Нажмите 1,2 или 3");
			Console.WriteLine("1 - Поговорить с бродягой");
			Console.WriteLine("2 - Осмотреть окрестности");
			Console.WriteLine("3 - Выход из локации\n");
		}

		protected override void Handle()
		{
			string enteredValue = Console.ReadLine();

			switch (enteredValue)
			{
				case "1":
					_room.Talk();
					break;
				case "2":
					_room.Explore();
					break;
				case "3":
					Exit();
					break;
				default:
					Error();
					break;
			}
		}
	}
}
