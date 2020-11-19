namespace TextQuests
{
	class Exploration : IAction
	{
		Room room;

		public Exploration(Room room)
		{
			this.room = room;
		}

		public void Act()
		{
			room.Explore();
		}

		public string Info()
		{
			return "Осмотреться";
		}
	}
}
