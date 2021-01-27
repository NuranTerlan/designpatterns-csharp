namespace DesignPatterns
{
    public class ProductStockReportManager
    {
        private readonly IProductStockReportBuilder _productStockReportBuilder;

        public ProductStockReportManager(IProductStockReportBuilder productStockReportBuilder)
        {
            _productStockReportBuilder = productStockReportBuilder;
        }

        public void BuildReport()
        {
            _productStockReportBuilder.BuildHeader().BuildBody().BuildFooter();
        }
    }
}