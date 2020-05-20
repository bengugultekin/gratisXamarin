using System;
using System.Collections.Generic;
using System.Text;

namespace gratisXamarin.Models
{
    public enum MenuItemType
    {
        Anasayfa,
        Makyaj,
        CiltBakim,
        SacBakim,
        SaglikHijyen,
        ParfumDeodorant,
        ErkekBakım,
        EvYasam,
        AnneBebek,
        OUTLET,
        Trendler

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
