namespace TextQuests
{
	class Game : IEventHandler
	{
		bool isExit = false;
		IAction[] action;

		public IInput Input { get; set; }

		public Game(IAction[] action)
		{
			this.action = action;
		}

		public void Run()
		{
			while (!isExit)
			{
				Input.NumberOfRequests(action.Length);

				for (int i = 0; i < action.Length; i++)
				{
					Input.ShowCases(i+1, action[i].Info());
				}

				Input.Handle();
			}
		}

		public void Exit()
		{
			isExit = true;
		}

		public void Act(int actionID)
		{
			action[actionID-1].Act();
		}
	}
}
