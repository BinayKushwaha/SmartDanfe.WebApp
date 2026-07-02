namespace SmartDanfe.WebApp.Models.Client
{
    public class DropdownTypeModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public ICollection<DropdownItemModel> DropdownItems { get; set; } = new List<DropdownItemModel>();
    }
}
