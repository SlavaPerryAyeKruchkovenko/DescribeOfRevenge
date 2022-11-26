using System.Linq;
using System.Collections.ObjectModel;
using Godot;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

public class Inventory : Node
{
    public ObservableCollection<Item> Items { get; private set; }

    public override void _Ready()
    {
        Items = new ObservableCollection<Item>();
        Items.CollectionChanged += Items_CollectionChanged;
    }

    [Signal] public delegate void InventoryChanged(Item[] item);

    private void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        EmitSignal(nameof(InventoryChanged), Items.ToArray());
    }
}
