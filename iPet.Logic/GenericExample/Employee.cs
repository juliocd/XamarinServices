using System;
namespace iPet.Logic.GenericExample
{
	public class Employee 
	{
		private string name;
		private int id;

		public Employee(string s, int i)
		{
			name = s;
			id = i;
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int ID
		{
			get { return id; }
			set { id = value; }
		}
	}
}
