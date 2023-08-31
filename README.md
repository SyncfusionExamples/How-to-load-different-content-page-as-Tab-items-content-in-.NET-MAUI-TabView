This article illustrates to load different content page as Tab items content in [.NET MAUI TabView](https://www.syncfusion.com/maui-controls/maui-tab-view), follow the below steps,

**Step 1:** Create a new sample in .NET MAUI and initialize TabView within the page with `BindingContext`.

**Step 2:** Create multiple .NET MAUI content pages in the sample and create new `ViewModel` class for assigning created content pages in the observable collection.

**Step 3:** Give proper name for the observable collection and add the content pages to that collection.

**XAML**
```
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <tabView:SfTabView  Items="{Binding Items}"/>
    
```
**C#**

```
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
```
**Output**

![TabViewPages.png](https://support.bolddesk.com/kb/agent/attachment/article/13619/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEwNTU5Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5ib2xkZGVzay5jb20ifQ.UAU0WqpCG6PimR7gKydxiUQCrsGYjXL6xtDTT8zzhN4)
