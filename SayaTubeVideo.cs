using System.Diagnostics;

namespace MOD5
{
    public class SayaTubeVideo
    {
		private int id;
		private string title;
		private int playCount;

		public int Id { get; set; }
		public string Title { get; set; }
		public int PlayCount { get; set; }

		public SayaTubeVideo(string title)
		{
			Debug.Assert(title.Length <= 200);
			Debug.Assert(title != null);

			Random rand = new Random();
			this.id = rand.Next(10000, 99999);

			this.Title = title;

			this.playCount = 0;
		}

		public void IncreasePlayCount(int add)
		{
			Debug.Assert(add <= 25000000);
			Debug.Assert(add >= 0);

			playCount += add;
		}

		public void PrintVideoDetails()
		{
			Console.WriteLine($"ID/t/t: {this.id}");
			Console.WriteLine($"Title/t: {this.title}");
			Console.WriteLine($"Play Count/t: {this.playCount}");
		}
	}
}