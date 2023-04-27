using System.Globalization;

namespace LocalizationDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

		string s1 = string.Format("Thread.CurrentThread.CurrentCulture:{0}\r\n", Thread.CurrentThread.CurrentUICulture);
		string s2 = string.Format("Thread.CurrentThread.CurrentUICulture:{0}\r\n", Thread.CurrentThread.CurrentUICulture);
		string s3 = string.Format("CultureInfo.DefaultThreadCurrentCulture:{0}\r\n", CultureInfo.DefaultThreadCurrentCulture);
		string s4 = string.Format("CultureInfo.DefaultThreadCurrentUICulture:{0}\r\n", CultureInfo.DefaultThreadCurrentUICulture);
		string s5 = string.Format("CultureInfo.CurrentCulture:{0}\r\n", CultureInfo.CurrentCulture);
		string s6 = string.Format("CultureInfo.CurrentUICulture:{0}\r\n", CultureInfo.CurrentUICulture);

		Shell.Current.DisplayAlert("cul",s1+s2+s3+s4+s5+s6,"OK");

		Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");

    }
}

