using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSklad.Models.ViewModels
{
    public class UserListViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public IEnumerable<string> RoleName { get; set; }
    }
}