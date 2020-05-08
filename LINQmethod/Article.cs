using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

//(Id, CategoryId, Title and Body)

namespace LINQmethod
{
	public class Article
	{
		public int Id { get; set; }

		public int CategoryId{ get; set; }

		public string Title { get; set; }

		public string Body { get; set; }

		public Article (int id, int categId, string title, string body)
		{
			this.Id = id;
			this.CategoryId = categId;
			this.Title = title;
			this.Body = body;
		}
	}
}

