namespace TextQuests
{
	class Program
	{
		static void Main(string[] args)
		{
			Room room = new Room("Путник, я тебе передаю медальон и 50 монет\n","...\n","Местность описана\n", false);
			IAction[] actions = new IAction[2] {new Talk(room), new Exploration(room)};
			Game game = new Game(actions);
			ConsoleIO console = new ConsoleIO(game);
			room.Output = console;
			game.Input = console;

			game.Run();
		}
	}
}