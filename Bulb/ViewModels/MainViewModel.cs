using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Bulb.ViewModels;
using Bulb.Models;
using DynamicData;
using Avalonia.Controls;

namespace Bulb.ViewModels;

public class MainViewModel : ViewModelBase
{
    public List<Note> Notes { get; set; }
    public string MonthHeader { get; set; }
    public DateTime Today { get; set; } = DateTime.Now;
    public MainViewModel()
    {
        MonthHeader = String.Format("{0}, {1}", CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Today.Month), Today.Year);
        using (ApplicationContext db = new ApplicationContext())
        {
            //db.Add(new Note("алалалала", DateTime.Now, true));
            //db.Add(new Note("алалалала", DateTime.Now, true));
            //db.Add(new Note("алалалала", DateTime.Now, true));
            //db.SaveChanges();
            Notes = db.Notes.ToList();
        }
    }
    public void OpenMenuCommand(object a)
    {
        //if (Design.IsDesignMode) return;
        var menuList = (ListBox) a;
        menuList.Width = 200;
    }
}