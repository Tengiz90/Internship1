using System.Diagnostics;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter symbol of device you want to add:");
            Console.WriteLine("M - Monitor\nC - Processor\nR - Memory\nH - Internal Memory");
            var device = Console.ReadLine().ToUpper();

            while (device != "M" && device != "C" && device != "R" && device != "H")
            {
                Console.WriteLine("Enter symbol of device you want to add correctly:");
                device = Console.ReadLine().ToUpper();
            }

            Console.Write("Enter Product Name: ");
            var name = Console.ReadLine();

            Console.Write("Enter Brand: ");
            var brand = Console.ReadLine();

            Console.Write("Enter Model: ");
            var model = Console.ReadLine();

            decimal price;
            Console.Write("Enter Price: ");
            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.Write("Invalid input. Please enter a valid Price: ");
            }

            int quantity;
            Console.Write("Enter Quantity: ");
            while (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.Write("Invalid input. Please enter a valid Quantity: ");
            }

            switch (device)
            {
                case "M":
                    var monitor = new Monitor
                    {
                        Name = name,
                        Brand = brand,
                        Model = model,
                        Price = price,
                        Quantity = quantity
                    };

                    Console.Write("Enter Diagonal Size (inches): ");
                    var diagonal = 0.0;
                    while (!double.TryParse(Console.ReadLine(), out diagonal))
                    {
                        Console.Write("Invalid input. Please enter a valid diagonal size: ");
                    }
                    monitor.Diagonal = diagonal;

                    Console.Write("Enter Resolution (in pixels): ");
                    var resolution = 0.0;
                    while (!double.TryParse(Console.ReadLine(), out resolution))
                    {
                        Console.Write("Invalid input. Please enter a valid resolution: ");
                    }
                    monitor.Resolution = resolution;

                    Console.Write("Enter Color: ");
                    monitor.Color = Console.ReadLine();

                    Console.WriteLine("\nMonitor Details:");
                    PrintProductDetails(monitor);
                    break;

                case "C":
                    var processor = new Processor
                    {
                        Name = name,
                        Brand = brand,
                        Model = model,
                        Price = price,
                        Quantity = quantity
                    };

                    Console.Write("Enter Number of Cores: ");
                    var cores = 0;
                    while (!int.TryParse(Console.ReadLine(), out cores))
                    {
                        Console.Write("Invalid input. Please enter a valid number of cores: ");
                    }
                    processor.NumberOfCores = cores;

                    Console.Write("Enter Speed (in GHz): ");
                    var speed = 0.0;
                    while (!double.TryParse(Console.ReadLine(), out speed))
                    {
                        Console.Write("Invalid input. Please enter a valid speed: ");
                    }
                    processor.Speed = speed;

                    Console.WriteLine("\nProcessor Details:");
                    PrintProductDetails(processor);
                    break;

                case "R":
                    var memory = new Memory
                    {
                        Name = name,
                        Brand = brand,
                        Model = model,
                        Price = price,
                        Quantity = quantity
                    };

                    Console.Write("Enter Memory Amount (in GB): ");
                    var memoryAmount = 0;
                    while (!int.TryParse(Console.ReadLine(), out memoryAmount))
                    {
                        Console.Write("Invalid input. Please enter a valid memory amount: ");
                    }
                    memory.MemoryAmount = memoryAmount;

                    Console.WriteLine("\nMemory Details:");
                    PrintProductDetails(memory);
                    break;

                case "H":
                    var internalMemory = new InternalMemory
                    {
                        Name = name,
                        Brand = brand,
                        Model = model,
                        Price = price,
                        Quantity = quantity
                    };

                    Console.Write("Enter Type (e.g., SSD, HDD): ");
                    internalMemory.Type = Console.ReadLine();

                    Console.Write("Enter Storage Capacity (in GB): ");
                    var storageCapacity = 0;
                    while (!int.TryParse(Console.ReadLine(), out storageCapacity))
                    {
                        Console.Write("Invalid input. Please enter a valid storage capacity: ");
                    }
                    internalMemory.StorageCapacity = storageCapacity;

                    Console.WriteLine("\nInternal Memory Details:");
                    PrintProductDetails(internalMemory);
                    break;
            }
        }

        static void PrintProductDetails(Product product)
        {
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Brand: {product.Brand}");
            Console.WriteLine($"Model: {product.Model}");
            Console.WriteLine($"Price: {product.Price:C}");
            Console.WriteLine($"Quantity: {product.Quantity}");

            switch (product)
            {
                case Monitor monitor:
                    Console.WriteLine($"Diagonal: {monitor.Diagonal} inches");
                    Console.WriteLine($"Resolution: {monitor.Resolution} pixels");
                    Console.WriteLine($"Color: {monitor.Color}");
                    break;
                case Processor processor:
                    Console.WriteLine($"Number of Cores: {processor.NumberOfCores}");
                    Console.WriteLine($"Speed: {processor.Speed} GHz");
                    break;
                case Memory memory:
                    Console.WriteLine($"Memory Amount: {memory.MemoryAmount} GB");
                    break;
                case InternalMemory internalMemory:
                    Console.WriteLine($"Type: {internalMemory.Type}");
                    Console.WriteLine($"Storage Capacity: {internalMemory.StorageCapacity} GB");
                    break;
            }
        }
    }
}