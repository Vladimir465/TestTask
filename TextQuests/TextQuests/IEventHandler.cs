namespace TextQuests
{
	/// <summary>
	/// Интерфейс для обработки событий
	/// </summary>
	interface IEventHandler
	{
		void Exit();
		void Act(int action);
	}
}
