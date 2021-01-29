﻿using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            // ********* Builder(Fluent) Pattern Usage: START *********

            // creating dummy data for products simulation
            int capacity = 3;
            var products = new List<Product>(capacity);
            for (int i = 1; i <= capacity; i++)
                products.Add(
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = $"Product {i}",
                        Price = Math.Round(random.NextDouble() * 100, 2),
                        NumberInStock = random.Next(100)
                    });

            // creation of builder is mandatory. because we use it when we create manager for report builder
            var builder = new ProductStockReportBuilder(products);
            var manager = new ProductStockReportManager(builder);

            // report is generated by manager
            manager.BuildReport();

            var productsReport = builder.GetReport();
            Console.WriteLine(productsReport);

            // ********* Builder(Fluent) Pattern Usage: END *********

            // -------------------------------------------------------------------------

            // ********* Fluent Builder Interface with Recursive Generics Usage: START *********

            var emp = EmployeeBuilderManager.NewEmployee
                .WithFirstName("Nuran").WithLastName("Tarlan").WithAge(18)
                .WithEMail("xxxx.xxxxx@helloworld.com")
                .WithMainPhone("xxx-xxx-xx-xx").WithBackupPhone("xxx-xxx-xx-xx")
                .AtPosition(Positions.FullStackDeveloper).WithSalary(500).Build();

            Console.WriteLine(emp.ToString());

            // ********* Fluent Builder Interface with Recursive Generics Usage: END *********
        }
    }
}