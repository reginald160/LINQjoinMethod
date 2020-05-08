using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace LINQmethod
{
	public class Category
	{
		public int ID { get; set; }

		public string CategoryName{ get; set; }

		public Category (int id, string categName)
		{
			this.ID = id;
			this.CategoryName = categName;
		}
	}
}

