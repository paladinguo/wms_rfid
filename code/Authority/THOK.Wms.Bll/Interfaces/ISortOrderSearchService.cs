﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using THOK.Wms.DbModel;

namespace THOK.Wms.Bll.Interfaces
{
    public interface ISortOrderSearchService : IService<SortOrder>
    {
        object GetDetails(int page, int rows, string OrderID, string OrderDate);
    }
}
