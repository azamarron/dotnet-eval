using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_eval.Models;

namespace dotnet_eval.Services.InventoryServices
{
    public interface IinventoryService
    {
        void AddItems(Inventory newUser);
        List<Inventory>GetItems (int itemId);
        List<Inventory>GetByUser (int userId);
        List<Inventory>GetAllItems ();

    }
}