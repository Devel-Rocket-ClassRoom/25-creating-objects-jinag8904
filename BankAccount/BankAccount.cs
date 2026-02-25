using System;

class BankAccount
{
    static int TotalAccounts;

    string AccountNumber;
    string OwnerName;
    int Balance;

    public BankAccount(string ownerName, string accountNumber, int balance)
    {
        TotalAccounts++;
        OwnerName = ownerName;
        AccountNumber = accountNumber;
        Balance = balance;
        Console.WriteLine($"[{AccountNumber}] {ownerName} 계좌가 개설되었습니다.");
    }

    static public void ShowTotalAccounts()
    {
        Console.WriteLine($"현재 총 계좌 수: {TotalAccounts}개");
    }

    public void Deposit(int amount)
    {
        Balance += amount;
        Console.WriteLine($"[{AccountNumber}] {amount}원 입금 완료. 잔액: {Balance}원");
    }

    public void Withdraw(int amount)
    {
        if (Balance < amount)
        {
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금 실패. 잔액이 부족합니다.");
        }

        else
        {
            Balance -= amount;
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금 완료. 잔액: {Balance}원");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"계좌번호: {AccountNumber}, 예금주: {OwnerName}, 잔액: {Balance}원");
    }
}