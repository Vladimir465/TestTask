using System;

namespace TextQuests
{
	class RoadInteractionText : RoadInteraction
	{
		protected override void IteractToTramp()
		{
			Console.WriteLine("Получено = медальон и 50 монет\n"); 
		}

		protected override void IgnoreToTramp()
		{
			Console.WriteLine("...\n");
		}

		public override void Explore()
		{
			Console.WriteLine("Осмотр завершен\n");
		}
	}
}
