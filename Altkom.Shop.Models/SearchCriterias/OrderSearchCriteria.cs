using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.Shop.Models.SearchCriterias
{
    public class DateRange
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }

    public abstract class SearchCriteria : Base
    {

    }

    public class OrderSearchCriteria : SearchCriteria
    {
        public DateRange Period { get; set; }
        public string Number { get; set; }

        public OrderSearchCriteria()
        {
            Period = new DateRange();
        }
    }
}
