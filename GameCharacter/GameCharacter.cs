using System;

class GameCharacter
{
    public string Name;
    public string Job;
    int Level = 1;
    int Exp = 0;

    public void ShowStatus() => Console.WriteLine($"[{Job}] {Name} - Lv.{Level} (Exp: {Exp}/100)");

    public void GainExp(int amount)
    {
        Exp += amount;
        
        if (Exp >= 100)
        {
            Level++; Exp -= 100;
            Console.WriteLine($"레벨 업! {Name} Lv.{Level} 달성!");
        }

        else
        {
            Console.WriteLine($"경험치 획득! 현재 Exp: {Exp}/100");
        }
    }
}