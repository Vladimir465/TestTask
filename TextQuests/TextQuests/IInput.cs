namespace TextQuests
{
	interface IInput
	{
		void Handle();
		void ShowCases(int number,string showCases);
		void NumberOfRequests(int number);
	}
}
