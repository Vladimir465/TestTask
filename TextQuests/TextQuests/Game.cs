namespace TextQuests
{
	abstract class Game
	{
		bool isExit = false;

		protected void Exit()
		{
			isExit = true;
			ExitInfo();
		}

		public void Run()
		{
			while (!isExit)
			{
				Info();
				Handle();
			}
		}

		protected abstract void ExitInfo();
		protected abstract void Info();
		protected abstract void Handle();
	}
}
