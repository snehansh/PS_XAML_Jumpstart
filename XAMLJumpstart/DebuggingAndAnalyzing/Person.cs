using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLJumpstart.DebuggingAndAnalyzing
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
		}

	}
}
