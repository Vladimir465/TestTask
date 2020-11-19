namespace TextQuests
{
	class Talk : IAction
	{
		Room room;

		public Talk(Room room)
		{
			this.room = room;
		}

		public void Act()
		{
			room.Talk();
		}

		public string Info()
		{
			return "Поговорить";
		}
	}
}
