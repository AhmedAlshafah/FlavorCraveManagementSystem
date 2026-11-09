using System;
using System.Collections.Generic;
using System.Text;

namespace FlavorCraveManagementSystem.Models
{
    public class MenuItemModel
    {
        public int MenuItemId { get; set; }

        public string Name { get; set; } = "";

        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = "";

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public bool IsActive { get; set; }
    }
}