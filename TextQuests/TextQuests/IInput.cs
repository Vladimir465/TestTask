namespace TextQuests
{
	/// <summary>
	/// Интерфейс определяет ввод игрока
	/// </summary>
	interface IInput
	{
		void Handle();
		void ShowCases(string showCases);
		void NumberOfRequests(int number);
	}
}