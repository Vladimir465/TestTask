namespace TextQuests
{
	class Room
	{
		string interactToPerson;
		string ignorePerson;
		string description; //Описание местности
		bool isGave = false;

		public IOutput Output { get; set; }

		public Room(string interactToPerson, string ignorePerson, string description, bool isGave)
		{
			this.interactToPerson = interactToPerson;
			this.ignorePerson = ignorePerson;
			this.description = description;
			this.isGave = isGave;
		}

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
		
		public void Explore()
		{
			Output.Write(description);
		}
	}
}
