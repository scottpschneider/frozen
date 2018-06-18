using System.Collections.Generic;

namespace Frozen.Project
{
    public interface IRoom
    {
        string Name { get; set; }
        string Description { get; set; }
        List<Item> Items { get; set; }

        void UseItem(Item item);

    }
}