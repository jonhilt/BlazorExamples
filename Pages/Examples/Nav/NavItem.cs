using System.Collections.Generic;

namespace BlazorExamples.Pages.Examples.Nav;

public class NavSubMenu
{
    public NavSubMenu(string Title)
    {
        this.Title = Title;
    }

    public string Title { get; set; }
    public List<NavItem> Items { get; private set; }
    
    public void AddItem(NavItem item)
    {
        Items ??= new List<NavItem>();
        Items.Add(item);
    }
}

public record NavItem(string Name, string Link)
{
    public string Link { get; set; } = Link;
    public string Name { get; set; } = Name;
}