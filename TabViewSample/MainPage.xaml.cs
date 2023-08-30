using Syncfusion.Maui.TabView;
using System.ComponentModel;

namespace TabViewSample;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}


}
public class ViewModel : INotifyPropertyChanged
{
    private TabItemCollection items;
    public event PropertyChangedEventHandler PropertyChanged;
    public TabItemCollection Items
    {
        get { return items; }
        set
        {
            items = value;
            OnPropertyChanged("Items");
        }
    }
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public ViewModel()
    {
        SetItems();

    }
    internal void SetItems()
    {
        Items = new TabItemCollection();
        TabViewPage1 page1 = new TabViewPage1();
        TabViewPage2 page2 = new TabViewPage2();
        TabViewPage3 page3 = new TabViewPage3();
        TabViewPage4 page4 = new TabViewPage4();
        Items.Add(new SfTabItem { Content = page1.Content, Header = "Page1" });
        Items.Add(new SfTabItem { Content = page2.Content, Header = "Page2" });
        Items.Add(new SfTabItem { Content = page3.Content, Header = "Page3" });
        Items.Add(new SfTabItem { Content = page4.Content, Header = "Page4" });
    }
}

