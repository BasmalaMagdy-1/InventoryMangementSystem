﻿

namespace InventoryMangementSystemEntities.ViewModels.Administration
{
    public class UserRolesViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public  List<SelectedRoles> UserRoles { get; set; }

    }
}
