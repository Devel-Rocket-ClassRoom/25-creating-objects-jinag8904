using System;

class Product
{
    public string Name;
    public int Price;
    public int Stock;

    public void AddStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"{Name} {quantity}개 재고 추가. 현재 재고: {Stock}개)");
    }

    public void Sell(int quantity)
    {
        if (Stock < quantity)
        {
            Console.WriteLine($"{Name} {quantity}개 판매 실패. 재고가 부족합니다. (현재 재고: {Stock}개)");
        }

        else
        {
            Stock -= quantity;
            Console.WriteLine($"{Name} {quantity}개 판매 성공. 남은 재고: {Stock}개)");
        }
    }

    public int GetTotalValue() => Price * Stock;

    public override string ToString() => $"[{Name}] {Price}원 (재고: {Stock}개)";
}