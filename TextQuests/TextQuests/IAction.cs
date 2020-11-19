namespace TextQuests
{
	/// <summary>
	/// Интерфейс действия игрока - получает описание действия и можно выполнить это действие
	/// </summary>
	interface IAction
	{
		void Act();
		string Info();
	}
}
