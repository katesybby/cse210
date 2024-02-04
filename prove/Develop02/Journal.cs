using System.Collections.Generic;
using System.Configuration.Assemblies;

public class Journal
{
    public List<Entry> entries = new List<Entry>(); 

    public void AddEntry(Entry entry) //adds entry to journal
    {
        entries.Add(entry);
    }

    public List<Entry> GetEntries() //displays entries
    {
        return entries;
    }
}
