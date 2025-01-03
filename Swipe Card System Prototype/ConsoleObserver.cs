using System.Collections.Generic;
using System.Windows.Forms;

public class ConsoleObserver : IObserver<List<string>>
{
    private ListBox listBox;

    public ConsoleObserver(ListBox listBox)
    {
        this.listBox = listBox;
    }

    public void Update(List<string> data)
    {
        listBox.Items.Clear();
        foreach (var item in data)
        {
            listBox.Items.Add(item);
        }
    }
}