namespace taller_idwm_backend.Src.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public int Amount { get; set; }
        public int Price { get; set; }
        public string? ImageUri { get; set; }
        public int IsEnabled { get; set; }
    }
}