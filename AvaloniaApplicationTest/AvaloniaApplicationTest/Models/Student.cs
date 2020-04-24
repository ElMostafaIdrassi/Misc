using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaApplicationTest.Models
{
	public class Student
	{
		[Reactive]
		public string Name { get; set; }

		[Reactive]
		public string Grade { get; set; }

		[Reactive]
		public bool Present { get; set; }
	}
}
