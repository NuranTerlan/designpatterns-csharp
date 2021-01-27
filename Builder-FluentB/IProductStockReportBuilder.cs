namespace DesignPatterns
{
    public interface IProductStockReportBuilder
    {
        // if you specify the return type as an interface itself this type of builder pattern is called fluent builder
        // otherwise (*void) called just normal builder
        IProductStockReportBuilder BuildHeader();
        IProductStockReportBuilder BuildBody();
        IProductStockReportBuilder BuildFooter();

        ProductStockReport GetReport();
    }
}