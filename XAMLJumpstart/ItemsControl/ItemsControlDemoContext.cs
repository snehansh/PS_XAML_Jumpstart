using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLJumpstart.ItemsControl
{
	public class ItemsControlDemoContext : BindableBase
	{
		private ObservableCollection<Person> _people;
		public ObservableCollection<Person> People
		{
			get
			{
				return _people;
			}
			set
			{
				if (value != _people)
				{
					_people = value;
					OnPropertyChanged();
				}
			}
		}

		private Person _currentPerson;
		public Person CurrentPerson
		{
			get
			{
				return _currentPerson;
			}
			set
			{
				if (value != _currentPerson)
				{
					_currentPerson = value;
					OnPropertyChanged();
				}
			}
		}

		public ItemsControlDemoContext()
		{
			People = CreateAndReturnPeople();
		}

		private ObservableCollection<Person> CreateAndReturnPeople()
		{
			return new ObservableCollection<Person>()
			{
				new Person("Tom",20),
				new Person("Dick",21),
				new Person("Harry",32)
			};
		}
	}
}
