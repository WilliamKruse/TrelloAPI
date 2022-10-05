using System;
namespace Model
{
	public class Todo
	{
		public long TodoId { get; set; }
		public string Title { get; set; }
		//public string Name { get; set; }
		//public string Category { get; set; }
		public User User { get; set; }

		public Todo(string title, User user)
		{
			//this.Name = name;
			//this.Category = category;
			this.Title = title;
			this.User = user;
		}
		public Todo()
		{
			;
		}
	}
}

