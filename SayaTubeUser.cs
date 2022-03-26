using System;
using System.Diagnostics;

namespace MOD5
{
	public class SayaTubeUser
	{
		private int id;
		private List<SayaTubeVideo> uploadedVideos;
		public string username;

		public SayaTubeUser(string username)
		{
			Debug.Assert(username.Length <= 100);
			Debug.Assert(username != null);

			Random rand = new Random();
			this.id = rand.Next(10000, 99999);

			this.uploadedVideos = new List<SayaTubeVideo>();
			this.username = username;
		}

		public int GetTotalVideoPlayCount()
		{
			int total = 0;

			foreach (var item in this.uploadedVideos)
			{
                try
                {
					total = checked(total += item.PlayCount);
                }
                catch (OverflowException e)
                {
					Console.WriteLine($"Found that {e.ToString()}");
                }

			}

			return total;
		}

		public void AddVideo(SayaTubeVideo video)
		{
			Debug.Assert(video != null);
			Debug.Assert(video.PlayCount < 2147483647);

			this.uploadedVideos.Add(video);
		}

		public void PrintAllVideoPlaycount()
        {
			Console.WriteLine($"User: {this.username}");
			int counter = 1;
			foreach (var item in this.uploadedVideos)
            {
				Console.WriteLine($"Video {counter} judul: {item.Title}");
				counter++;
            }
        }
	}
}
