

namespace InventoryMangementSystemEntities.ViewModels.Administration

{
    public class RolesViewModel
    {
        public string Id { get; set; }
        public string RoleName { get; set; }
        public IEnumerable<string> Users { get; set; }

    }
}
