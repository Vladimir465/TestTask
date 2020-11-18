namespace TextQuests
{
	class Program
	{
		static void Main(string[] args)
		{
			Rooms room = new RoadInteractionText();
			Game game = new GameText(room);

			game.Run();
		}
	}
}