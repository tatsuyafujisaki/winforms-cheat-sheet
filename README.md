[![Build status](https://ci.appveyor.com/api/projects/status/ku6lve8st7yxy6ow?svg=true)](https://ci.appveyor.com/project/tatsuya/winforms-cheat-sheet)

###### Form
* AutoSize = True
* AutoSizeMode = GrowAndShrink
* StartPosition = CenterScreen
  * Form.CenterToScreen() is not intended to be used directly from your code.
  * https://msdn.microsoft.com/en-us/library/system.windows.forms.form.centertoscreen.aspx
* TopMost = True

###### ComboBox
* Sorted = True

###### DataGridView
* MultiSelect = False

###### ListView
```csharp
lvTrades.BeginUpdate();

liewView1.Items.Clear();

// Say, xs is defined somewhere else.
foreach (var lvi in xs.Select(x => new ListViewItem(new[]
{
    x.Foo,
    x.Bar,
    x.Baz
}) { Tag = x }))
{
    liewView1.Items.Add(lvi);
}

liewView1.AutoResizeColumns(liewView1.Items.Count == 0
    ? ColumnHeaderAutoResizeStyle.HeaderSize
    : ColumnHeaderAutoResizeStyle.ColumnContent);
    
liewView1.EndUpdate();
```
