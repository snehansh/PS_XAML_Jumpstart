using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XAMLJumpstart.DebuggingAndAnalyzing
{
	/// <summary>
	/// Interaction logic for DataBinding.xaml
	/// </summary>
	public partial class DataBinding : Page
	{
		readonly Person person = new Person();
		public DataBinding()
		{
			InitializeComponent();

			//txtName.DataContext = person;
			this.DataContext = person;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			//person.Name = "I will not be visible in the UI";

			//string message = person.Name + " "
			//	+ person.Address.Number + ", " + person.Address.Street;

			//MessageBox.Show(message);
			//person.Name = "Akhaury";

			BindingExpression bindingExpression = txtName.GetBindingExpression(TextBox.TextProperty);
			bindingExpression.UpdateSource();
		}
	}
}
