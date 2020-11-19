using System;

namespace TextQuests
{
	/// <summary>
	/// Реализация ввода и вывода через консоль
	/// </summary>
	class ConsoleIO : IInput, IOutput
	{
		IEventHandler handler;
		string[] commands;
		int answer;
		int lastCommandID;
		bool err;

		public ConsoleIO(IEventHandler handler)
		{
			this.handler = handler;
		}

		/// <summary>
		/// Ожидание ввода игрока
		/// </summary>
		public void Handle()
		{
			Console.Write("Выберите действие: ");
			for (int i = 0; i < commands.Length; i++)
			{
				Console.Write((i + 1) + ", ");
			}
			Console.WriteLine(commands.Length + 1);


			for (int i = 0; i < commands.Length; i++)
			{
				Console.WriteLine($"{i + 1} - {commands[i]}");
			}
			Console.WriteLine($"{commands.Length + 1} - Уйти");


			err = !int.TryParse(Console.ReadLine(), out answer);
			err |= answer > (commands.Length + 1);
			err |= answer <= 0;

			if (err)
				Console.WriteLine("Вы ввели неверное значение, попробуйте снова");
			else if (answer == (commands.Length + 1))
				handler.Exit();
			else
				handler.Act(answer);
		}

		/// <summary>
		/// Сброс массива
		/// </summary>
		/// <param name="number"></param>
		public void NumberOfRequests(int number)
		{
			commands = new string[number];
			lastCommandID = 0;
		}

		/// <summary>
		/// Формирование нужных вариантов ответа
		/// </summary>
		/// <param name="number"></param>
		/// <param name="showCases"></param>
		public void ShowCases(string showCases)
		{
			commands[lastCommandID++] = showCases;
		}

		/// <summary>
		/// Выдать текст
		/// </summary>
		/// <param name="write"></param>
		public void Write(string write)
		{
			Console.WriteLine(write);
		}
	}
}
