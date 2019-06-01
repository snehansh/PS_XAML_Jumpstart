using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLJumpstart.DataBinding
{
	public class Person : BindableBase
	{
		private string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value != _name)
				{
					_name = value;
					OnPropertyChanged();
				}
			}
		}
		public Address Address { get; set; }
		public Person()
		{
			this.Address = new Address();
			this.Age = 30;
		}

		private int _age;
		public int Age
		{
			get
			{
				return _age;
			}
			set
			{
				if (value != _age)
				{
					_age = value;
					OnPropertyChanged();
				}
			}
		}
	}
}
