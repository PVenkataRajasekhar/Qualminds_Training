namespace ASPDotNETCoreWebAPIEntityFrameWork.Models
{
    public class Details
    {
        public int CustomerId {  get; set; }
        public string CustomerName { get; set; } 
        public List<Product> Products { get; set; }
    }
}
