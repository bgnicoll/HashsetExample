using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HashsetExample.Helpers
{
    public class HashsetHelper
    {
        public HashSet<string> InitializeHashset()
        {
            return new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Cheeseburger",
                "Hot Dog",
                "Pizza",
                "Steak",
                "Ham Sandwich",
                "Pasta",
                "Chicken Salad"
            };
        }

    }
}