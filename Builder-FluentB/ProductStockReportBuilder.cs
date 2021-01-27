using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    public class ProductStockReportBuilder : IProductStockReportBuilder
    {
        private ProductStockReport _productStockReport;
        private readonly IEnumerable<Product> _products;

        public ProductStockReportBuilder(IEnumerable<Product> products)
        {
            _productStockReport = new ProductStockReport();
            _products = products;
        }

        public IProductStockReportBuilder BuildHeader()
        {
            // We give current datetime to the user to know when got this report
            _productStockReport.Header = $"Report #{_productStockReport.Id} is built in {DateTime.Now}\n";
            return this;
        }

        public IProductStockReportBuilder BuildBody()
        {
            var productsInfoList = _products.Select(p => $"#{p.Id}: {p.Name}\n" +
                                                         $"Number in stock: {p.NumberInStock}\n" +
                                                         $"Price: ${p.Price}");
            _productStockReport.Body = String.Join("\n\n------------------\n\n", productsInfoList);
            return this;
        }

        public IProductStockReportBuilder BuildFooter()
        {
            _productStockReport.Footer = $"\nProvided by | devvhale {DateTime.Now.Year}";
            return this;
        }

        public ProductStockReport GetReport()
        {
            var report = _productStockReport;
            Clear();
            return report;
        }

        private void Clear() => _productStockReport = new ProductStockReport();
    }
}