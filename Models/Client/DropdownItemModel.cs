namespace SmartDanfe.WebApp.Models.Client
{
    public class DropdownItemModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }
        public Guid? ParentId { get; set; }
        public Guid DropdownTypeId { get; set; }
        public DropdownItemModel? Parent { get; set; }
        public DropdownItemModel DropdownType { get; set; } = null!;
        public ICollection<DropdownItemModel> Children { get; set; } = new List<DropdownItemModel>();
    }
}
