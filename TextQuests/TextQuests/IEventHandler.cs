namespace TextQuests
{
	interface IEventHandler
	{
		void Exit();
		void Act(int action);
	}
}
