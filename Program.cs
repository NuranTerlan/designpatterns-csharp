﻿using System;
using System.Collections.Generic;
using DesignPatterns.Adapter;
using DesignPatterns.Command;
using DesignPatterns.Command.Invokers;
using DesignPatterns.Command.Receivers;
using DesignPatterns.Composite.Composites;
using DesignPatterns.Composite.Leaves;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.FacetedB;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Iterator;
using DesignPatterns.Prototype;
using DesignPatterns.Proxy;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;

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

            // ********* Fluent Builder Interface with Recursive Generics Pattern Usage: START *********

            var emp = EmployeeBuilderManager.NewEmployee
                .WithFirstName("Nuran").WithLastName("Tarlan").WithAge(18)
                .WithEMail("xxxx.xxxxx@helloworld.com")
                .WithMainPhone("xxx-xxx-xx-xx").WithBackupPhone("xxx-xxx-xx-xx")
                .AtPosition(Positions.FullStackDeveloper).WithSalary(500).Build();

            Console.WriteLine(emp);

            // ********* Fluent Builder Interface with Recursive Generics Pattern Usage: END *********

            // -------------------------------------------------------------------------

            // ********* Faceted Builder Pattern Usage: START

            var car = new CarBuilderFacade()
                .Info.WithBrand(CarBrands.Subaru).WithModel("Impreza").CreatedAt(2003).WithDistance(186522.5)
                .Engine.WithEngine(1800).WithHorsePower(422).WithTorque(600)
                .Trade.WithPrice(18000.0m).IsSecondHand(true)
                .Address.InCity("Baku").InDealer("Subaru XXXXX-XX")
                .Build();

            Console.WriteLine(car);

            // ********* Faceted Builder Pattern Usage: END

            // -------------------------------------------------------------------------

            // ********* Factory Method Pattern Usage: START

            AirConditioner.InitializeFactories()
                .ExecuteCreation(Actions.Cooling, 20.2)
                .Operate();

            // ********* Factory Method Pattern Usage: END

            // -------------------------------------------------------------------------
            Console.WriteLine("\n-------------------------------\n");

            // ********* Singleton Pattern Usage: START

            var db1 = SingletonDataContainer.GetInstance;
            Console.WriteLine($"Population of Sumqayit: {db1.GetPopulation("Sumqayit")}");

            var db2 = SingletonDataContainer.GetInstance;
            Console.WriteLine($"Baku: {db2.GetPopulation("Baku")} people");

            // ********* Singleton Pattern Usage: END

            // -------------------------------------------------------------------------
            Console.WriteLine("\n-------------------------------\n");

            // ********* Adapter Pattern Usage: START

            var xmlConverter = new CustomXmlConverter();
            var adapter = new XmlToJsonAdapter(xmlConverter);
            adapter.ConvertXmlToJson();

            // ********* Adapter Pattern Usage: END

            // -------------------------------------------------------------------------
            Console.WriteLine("\n-------------------------------\n");

            // ********* Composite Pattern Usage: START

            // single gift
            var phone = new SingleGift("Phone", 500);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            // composite many gifts together
            var rootBox = new CompositeGift("Surprise Box for Teenagers", true);
            var truckToy = new SingleGift("Truck Toy", 220);
            var plainToy = new SingleGift("Plain Toy", 89);
            rootBox.Add(truckToy);
            rootBox.Add(plainToy);

            var childBox = new CompositeGift("Surprise Box for Children", false);
            var soldierToy = new SingleGift("Soldier Toy", 15);
            childBox.Add(soldierToy);
            rootBox.Add(childBox);

            rootBox.CalculateTotalPrice();

            // ********* Composite Pattern Usage: END

            // -------------------------------------------------------------------------
            Console.WriteLine("\n-------------------------------\n");

            // ********* Decorator Pattern Usage: START

            var regularOrder = new RegularOrder();
            Console.WriteLine(regularOrder.CalculateTotalOrderPrice() + "\n");

            var preOrder = new PreOrder();
            Console.WriteLine(preOrder.CalculateTotalOrderPrice() + "\n");

            var premiumPreOrder = new PremiumPreOrder(preOrder);
            Console.WriteLine(premiumPreOrder.CalculateTotalOrderPrice());

            // ********* Decorator Pattern Usage: END

            // -------------------------------------------------------------------------
            Console.WriteLine("\n-------------------------------\n");

            // ********* Command Pattern Usage: START

            var modifyPrice = new ModifyPrice();
            var product = new Product2("Phone", 500);
            modifyPrice.Execute(new ProductCommand(product, PriceAction.Increase, 100));
            modifyPrice.Execute(new ProductCommand(product, PriceAction.Decrease, 700));
            modifyPrice.Execute(new ProductCommand(product, PriceAction.Decrease, 20));

            Console.WriteLine(product);
            modifyPrice.UndoActions();
            Console.WriteLine(product);

            // ********* Command Pattern Usage: END

            // -------------------------------------------------------------------------
            Console.WriteLine("\n-------------------------------\n");

            // ********* Strategy Pattern Usage: START

            var reports = new List<DeveloperReport>
            {
                new DeveloperReport {Id = 1, Name = "Dev1", Level = DeveloperLevel.Senior, HourlyRate = 30.5, WorkingHours = 160 },
                new DeveloperReport { Id = 2, Name = "Dev2", Level = DeveloperLevel.Junior, HourlyRate = 20, WorkingHours = 120 },
                new DeveloperReport { Id = 3, Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate = 32.5, WorkingHours = 130 },
                new DeveloperReport { Id = 4, Name = "Dev4", Level = DeveloperLevel.Junior, HourlyRate = 24.5, WorkingHours = 140 }
            };
            var calculatorContext = new SalaryCalculator(new JuniorDeveloperSalaryCalculator());
            var juniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for junior salaries is: {juniorTotal}");
            calculatorContext.SetCalculator(new SeniorDeveloperSalaryCalculator());
            var seniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for senior salaries is: {seniorTotal}");
            Console.WriteLine($"Total cost for all the salaries is: {juniorTotal + seniorTotal}");

            // ********* Strategy Pattern Usage: END

            // -------------------------------------------------------------------------
            Console.WriteLine("\n-------------------------------\n");

            // ********* Facade Pattern Usage: START

            var facade = new Facade.Facade();

            var chickenOrder = new Order() { DishName = "Chicken with rice", DishPrice = 20.0, User = "User1", ShippingAddress = "Random street 123" };
            var sushiOrder = new Order() { DishName = "Sushi", DishPrice = 52.0, User = "User2", ShippingAddress = "More random street 321" };

            facade.OrderFood(new List<Order> {chickenOrder, sushiOrder});

            // ********* Facade Pattern Usage: END

            // -------------------------------------------------------------------------
            Console.WriteLine("\n-------------------------------\n");

            // ********* Prototype Pattern Usage: START

            var grid = new List<IBlock>();
            grid.AddRange(new List<IBlock>
            {
                BlockFactory.Create("Hello, world!"),
                BlockFactory.Create("3"),
                BlockFactory.Create("16/05/2002"), // datetime
                BlockFactory.Create("08/22/2021") // string, because 12 month exist in calendar
            });

            foreach (var block in grid)
            {
                Console.WriteLine(block);
            }

            var block5 = (DateTimeBlock) grid[2].Clone();
            block5.Format = "MM/dd/yyyy";
            grid.Add(block5);
            Console.WriteLine("\nblock5 is added...");
            Console.WriteLine(block5);

            var block6 = (DateTimeBlock) grid[4].Clone();
            block6.DateTime = DateTime.UtcNow;
            grid.Add(block6);
            Console.WriteLine("\nblock6 is added...");
            Console.WriteLine(block6);

            // ********* Prototype Pattern Usage: END

            // -------------------------------------------------------------------------
            Console.WriteLine("\n-------------------------------\n");

            // ********* Protection-Proxy Pattern Usage: START

            var settings = new Settings("settings config");
            Console.WriteLine(settings.GetConfig());

            var authService = new AuthService();
            var protectedSettings = new ProtectedSettings(authService);
            Console.WriteLine(protectedSettings.GetConfig());

            // ********* Protection-Proxy Pattern Usage: END

            // ********* Iterator Pattern Usage: START

            var numbers = new CustomLinkedList<int>(1);
            for (int i = 2; i < 8; i++)
            {
                numbers.Add(i);
            }

            var iterator = numbers.Iterator;
            while (!iterator.Complete)
            {
                Console.WriteLine(iterator.Next());
            }

            // Exception will be thrown
            // Console.WriteLine(iterator.Next());

            // ********* Iterator Pattern Usage: END
        }
    }
}
