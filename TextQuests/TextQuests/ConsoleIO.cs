using System;

namespace TextQuests
{
	class ConsoleIO : IInput, IOutput
	{
		IEventHandler handler;
		string[] commands;
		int answer;
		bool err;

		public ConsoleIO(IEventHandler handler)
		{
			this.handler = handler;
		}

		public void Handle()
		{
			Console.Write("Нажмите ");
			for (int i = 0; i < commands.Length; i++)
			{
				if (commands[i] == null)
					break;
				Console.Write((i + 1) + ", ");
			}
			Console.WriteLine(commands.Length + 1);


			for (int i = 0; i < commands.Length; i++)
			{				
				if (commands[i] == null)
					break;
				Console.WriteLine($"{i + 1} - {commands[i]}");
			}
			Console.WriteLine($"{commands.Length + 1} - Уйти");


			err = !int.TryParse(Console.ReadLine(), out answer);
			err |= answer > (commands.Length + 1);
			err |= answer < 0;
			//err |= (commands[answer - 1] == string.Empty);

			if (err)
				Console.WriteLine("Вы ввели неверное значение, попробуйте снова");
			else if (answer == (commands.Length + 1))
				handler.Exit();
			else
				handler.Act(answer);
		}

		public void NumberOfRequests(int namber)
		{
			commands = new string[namber];
		}

		public void ShowCases(int number, string showCases)
		{
			commands[number - 1] = showCases;
		}

		public void Write(string write)
		{
			Console.WriteLine(write);
		}
	}
}
