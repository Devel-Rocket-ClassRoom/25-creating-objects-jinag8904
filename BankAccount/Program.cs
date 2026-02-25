using System;

Console.WriteLine("=== 계좌 개설 ===");
BankAccount bankAccount1 = new BankAccount("홍길동", "1001", 100000);
BankAccount bankAccount2 = new BankAccount("이순신", "1002", 50000);
BankAccount.ShowTotalAccounts();

Console.WriteLine();

Console.WriteLine("=== 거래 ===");
bankAccount1.Deposit(50000);
bankAccount2.Deposit(30000);
bankAccount1.Withdraw(200000);
bankAccount1.Withdraw(100000);

Console.WriteLine();

Console.WriteLine("=== 최종 계좌 정보 ===");
bankAccount1.ShowInfo();
bankAccount2.ShowInfo();