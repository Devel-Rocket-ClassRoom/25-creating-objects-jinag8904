using System;

Product[] products = new Product[3]
{
    new Product { Name = "노트북", Price = 1500000, Stock = 5 },
    new Product { Name = "마우스", Price = 35000, Stock = 20 },
    new Product { Name = "키보드", Price = 89000, Stock = 15 }
};

Console.WriteLine("=== 상품 목록 ===");

foreach (var product in products)
{
    Console.WriteLine(product);
}

Console.WriteLine("\n=== 거래 ===");

products[0].Sell(2);
products[1].Sell(5);
products[2].Sell(20);
products[2].AddStock(10);

Console.WriteLine("\n=== 최종 상품 목록 ===");

foreach (var product in products)
{
    Console.WriteLine(product);
}

Console.WriteLine("\n=== 총 재고 가치 ===");

int totalValue = 0;

foreach (var product in products)
{
    Console.WriteLine($"{product.Name}: {product.GetTotalValue()}원");
    totalValue += product.GetTotalValue();
}

Console.WriteLine($"---\n전체 재고 총 가치: {totalValue}원");