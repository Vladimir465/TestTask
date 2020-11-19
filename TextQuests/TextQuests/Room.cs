namespace TextQuests
{
	/// <summary>
	/// Определяет комнату с окружением и одним персонажем
	/// </summary>
	class Room
	{
		string interactToPerson;
		string ignorePerson;
		string description; //Описание местности
		bool isGave = false;

		public IOutput Output { get; set; }

		public Room(string interactToPerson, string ignorePerson, string description)
		{
			this.interactToPerson = interactToPerson;
			this.ignorePerson = ignorePerson;
			this.description = description;
		}

		/// <summary>
		/// Разговор с персонажем
		/// </summary>
		public void Talk()
		{
			if (isGave == true)
				Output.Write(ignorePerson);
			else
			{
				isGave = true;
				Output.Write(interactToPerson);
			}	
		}
		
		/// <summary>
		/// Осмотр местности
		/// </summary>
		public void Explore()
		{
			Output.Write(description);
		}
	}
}
