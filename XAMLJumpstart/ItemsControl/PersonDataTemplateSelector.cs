using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace XAMLJumpstart.ItemsControl
{
	public class PersonDataTemplateSelector : DataTemplateSelector
	{
		public DataTemplate UnderThirtyTemplate { get; set; }
		public DataTemplate ThirtyOrOlderTemplate { get; set; }

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			var person = (Person)item;
			if (person.Age < 30)
			{
				return UnderThirtyTemplate;
			}
			else
			{
				return ThirtyOrOlderTemplate;
			}

		}
	}
}
