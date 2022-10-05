using System;
namespace Model
{
	public class Board
	{
		public long BoardId { get; set; }
		public List<Todo> Todos { get; set; } = new List<Todo>();

		public Board(List<Todo> todos)
		{
			this.Todos = todos;
		}
		public Board()
		{
			;
		}
	}
}

