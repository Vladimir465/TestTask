namespace TextQuests
{
	class Program
	{
		static void Main(string[] args)
		{
			Room road = new Room("Путник, я тебе передаю медальон и 50 монет\n","...\n","Вы видите перед собой дорогу и бродягу\n");
			IAction[] actions = new IAction[2] {new Talk(road), new Exploration(road) };
			Game game = new GameTest(actions, road);
			
			game.Run();
		}
	}
}