using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI.Models
{
    public class Requests
    {
        public class UnitRequest
        {
            public string Name { get; set; }
        }

        public class UnitResponse
        {
            public int Id { get; set; }
            public string UnitName { get; set; }
            public string DateCreated { get; set; }
            public string UserCreated { get; set; }
            public string DateModified { get; set; }
            public string ModifiedBy { get; set; }

        }

        public class BranchRequest
        {
            public string BranchName { get; set; }
            public string BranchCode { get; set; }
            public string Location { get; set; }
            public string hopName { get; set; }
            public string hopEmail { get; set; }
        }

        public class BranchResponse
        {
            public int Id { get; set; }
            public string BranchName { get; set; }
            public string BranchCode { get; set; }
            public string Location { get; set; }
            public string hopName { get; set; }
            public string hopEmail { get; set; }
            public string DateCreated { get; set; }
            public string UserCreated { get; set; }
            public string DateModified { get; set; }
            public string ModifiedBy { get; set; }

        }

        public class CategoryRequest
        {
            public string Name { get; set; }
        }

        public class CategoryResponse
        {
            public int Id { get; set; }
            public string CategoryName { get; set; }
            public string DateCreated { get; set; }
            public string UserCreated { get; set; }
            public string DateModified { get; set; }
            public string ModifiedBy { get; set; }

        }
        public class ItemRequest
        {
            public string ItemName { get; set; }
            public string CurrentStock { get; set; }
            public string SafetyStock { get; set; }
            public string ActualStock { get; set; }
            public string OrderQuantity { get; set; }
            public string Brand { get; set; }
            public string CategoryId { get; set; }
            public string UnitId { get; set; }
        }
        public class ItemResponse
        {
            public int Id { get; set; }
            public string ItemName { get; set; }
            public string CurrentStock { get; set; }
            public string SafetyStock { get; set; }
            public string ActualStock { get; set; }
            public string OrderQuantity { get; set; }
            public string Brand { get; set; }
            public string CategoryId { get; set; }
            public string UnitId { get; set; }
            public string DateCreated { get; set; }
            public string UserCreated { get; set; }
            public string DateModified { get; set; }
            public string ModifiedBy { get; set; }
        }
    }
}