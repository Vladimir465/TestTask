namespace TextQuests
{
	/// <summary>
	/// Реализация обработки события + игровой цикл
	/// </summary>
	class Game : IEventHandler
	{
		bool isExit = false;
		
		IAction[] action;

		public IInput Input { get; set; }

		public Game(IAction[] action)
		{
			this.action = action;
		}

		/// <summary>
		/// Запуск игры
		/// </summary>
		public void Run()
		{
			while (!isExit)
			{
				Input.NumberOfRequests(action.Length);

				for (int i = 0; i < action.Length; i++)
				{
					Input.ShowCases(action[i].Info());
				}

				Input.Handle();
			}
		}

		/// <summary>
		/// Выход из игры
		/// </summary>
		public void Exit()
		{
			isExit = true;
		}

		/// <summary>
		/// Реализация обработки события Act - действие
		/// </summary>
		/// <param name="actionID"></param>
		public void Act(int actionID)
		{
			action[actionID-1].Act();
		}
	}
}
