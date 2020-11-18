namespace TextQuests
{
	abstract class RoadInteraction : Rooms
	{
		bool conversation = true;

		public void Talk()
		{
			if (conversation)
			{
				conversation = false;
				IteractToTramp();
			}	
			else
				IgnoreToTramp();
		}

		protected abstract void IteractToTramp();
		protected abstract void IgnoreToTramp();
		public abstract void Explore();
	}
}
