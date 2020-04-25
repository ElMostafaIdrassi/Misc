using AvaloniaApplicationTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AvaloniaApplicationTest.ViewModels
{
	public class MainWindowViewModel : ViewModelBase
	{
		public ObservableCollection<Student> Students { get; }
		public string NamesHeader => "Names";
		public string GradesHeader => "Grades";
		public string CitiesHeader => "Cities";
		public string PresenceHeader => "Presence";

		public MainWindowViewModel()
		{
			Students = new ObservableCollection<Student>();
			Students.Add(new Student { Grade = "10", Name = "John", Present = false, City = "Paris" });
			Students.Add(new Student { Grade = "5", Name = "Karen", Present = true, City = "Boston" });
			Students.Add(new Student { Grade = "8", Name = "Boris", Present = false, City = "Amsterdam" });
		}
	}
}
