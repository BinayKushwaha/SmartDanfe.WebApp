namespace SmartDanfe.WebApp.Models.Client
{
    public class MaterialReceivedCheckListModel
    {
        public Guid Id { get; set; }
        public Guid MaterialTypeId { get; set; }
        public string MaterialTypeName { get; set; } = null!;
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime RetestDate { get; set; }
        public string BatchNumber { get; set; } = null!;
        public DateTime ReceivedDate { get; set; }
        public decimal QuantityReceived { get; set; }
        public Guid UnitOfMeasureId { get; set; }
        public string UnitOfMeasureCode { get; set; } = null!;
        public int NumberOfDrums { get; set; }
        public int NumberOfCartons { get; set; }
        public int NumberOfSacks { get; set; }
        public string PerformaInvoiceNumber { get; set; } = null!;
        public string ImportCustomClearanceNumber { get; set; } = null!;
        public string ImportCustomClearanceDate { get; set; } = null!;
        public string FactorySecurityEntryNumber { get; set; } = null!;
        public string FactorySecurityEntryDate { get; set; } = null!;
        public Guid StatusOfPackingId { get; set; }
        public DropdownItemModel StatusOfPackingName { get; set; } = null!;
        public bool COAReceived { get; set; }
        public string StorageCondition { get; set; } = null!;
        public string Deficiency { get; set; } = null!;
        public decimal PricePerQuantity { get; set; }
        public string GoodsReceiptNumber { get; set; } = null!;
        public string MaterialFrom { get; set; } = null!;
        public Guid MaterialId { get; set; }
        public string MaterialName { get; set; } = null!;
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;
        public Guid ManufacturerCompanyId { get; set; }
        public string ManufacturerCompanyName { get; set; } = null!;
        public bool IsApprovedVendor { get; set; }
        public string MaterialStatus { get; set; } = null!;
    }
}
