
-- AND, OR, ORDER BY
SELECT  CustomerID,CustomerAddress, CustomerFirstName,State
FROM Customers
WHERE CustomerLastName='Nelson' AND IsJuridical!=1 OR State='Arizona'
ORDER BY BirthDate
--მოგვაწოდოს ისეთი customer-ების ID , მისამართი და სახელი, (რომელთა გვარია ნელსონი და ამასთანავე არ არის იურიდული პირი) ან ყველა მომხმარებელი არიზონას შტატიდან,
--დაალაგოს დაბადების თარიღის მიხედვით, ზრდადობით.


--AND NOT
SELECT  CustomerFirstName, CustomerAddress,State
FROM Customers
WHERE CustomerLastName='Brown' AND NOT	State='Ohio'
--აირჩიოს ისეთი მომხმარებლების სვეტები(  სახელი ,მისამართი და შტატი) , რომელთა გვარია ბრაუნი და არ არიან Ohio-სშტატიდან.


--AND, OR, IN, AND NOT
SELECT *FROM Customers
WHERE CustomerID>=40 AND NOT CustomerID IN(45,50,55,60) AND CustomerID<61 
OR State='California' AND CustomerID<=39 OR CustomerID=50 AND IsJuridical=1
-- დაასელექტოს ისეთი მომხმარებლების ყოველი სვეტი, რომელთა ID  არის 39-61 შუალედში და არ არის 5ის ჯერადი 
--ან 0-40 შუალედიდან რომელი მომხმარებელიც არის კალიფორნიის შტატიდან
--ან მომხმარებლის აიდი უდრის 50-ს და ამასთანავე არის იურიდიული პირი(თუ ასეთი არსებობს)


--DATETIME FILTER 
SELECT DepositID,ProductID,Amount 
FROM Deposits 
WHERE StartDate>'2018-03-02 11:49:53' AND EndDate<'2018-05-04 12:00:53' AND Amount>5000 AND Amount<38000
--დაასელექთოს დეპოზიტის აიდი, პროდუქტის აიდი და თანხის რაოდენობა როდესაც დეპოზიტი გაკეთდა ზემოთ მითითბული დროის შუალედში 
--და ამასთანავე თანხის მოცულობა იყო 5000დან 38000მ-დე

--BETWEEN
SELECT AccountID,OverDraftAmount
FROM OverDrafts 
WHERE OverDraftAmount  BETWEEN 8000 AND 9000
ORDER BY OverDraftAmount

-- OverDrafts გაფილტროს თანხის მოცულობის მიხედვით(8000-9000 შუალედში) და დაალაგოს ზრდადობით,
-- დაგვისელექთოს მხოლოდ ანგარიშის აიდი და თანხის მოცულობა



--IN SELECT
SELECT CustomerID, CustomerFirstName,CustomerLastName, IsJuridical
FROM Customers
WHERE CustomerID in
(SELECT CustomerID FROM Accounts WHERE FilialID=1 and Currency='USD' and AccountTypeID=4)
 --მომხმარებლებიდან დაასელექთოს ისეთი CustomerID, მომხმარებლის სახელი და გვარი ასევე არის თუ არა იურიდიული პირი,
 -- რომელიც აკმაყოფილებს პირობას: ფილიალის ნომერი არის 1, ვალუტა არის დოლარში და ექაუნთის ტიპის აიდი არის 4 



--IN , SELECT
SELECT ProductID, CustomerID,LoanID
FROM loan.Loans
WHERE ProductID IN
    (SELECT ProductID
     FROM loan.Products
	 where ProductName='Personal Loans')
--დაასელექთოს ისეთი მომხმარებლების აიდი და სესხის აიდი რომლებსაც აქვთ პირადი სესხები



--NESTED SELECT
SELECT *FROM Customers
WHERE CustomerID=
    (SELECT DISTINCT CustomerID
     FROM Deposits
     WHERE Deposits.Amount=38609.6609 AND InterestRate=4.00)
--დეპოზიტების თანხის რაოდენობით და ინტერესთ რეითით გაფილტროს დეპოზიტების ცხრილი და აირჩიოს არადუბლირებული
--თუ მომხმარებელს აქვს რამდენიმე ასეთი დეპოზიტი, შემდეგ დაასელექთოს აიდი და ქასთომერების ცხრილიდან გამოუტანოს ყოველი სვეტის მნიშვნელობა 
-- ამ აიდის მიხედვით.

--DISTINCT
SELECT DISTINCT Currency,AccountTypeID FROM Accounts WHERE AccountID>4 and AccountID<=8
--SELECT Currency,AccountTypeID FROM Accounts WHERE AccountID>4 and AccountID<=8
--ექაუნთის ვალუტისა და ექაუნთის ტიპების ყველა წყვილი რომელიც არ მეორდება

SELECT DISTINCT CustomerFirstName FROM Customers WHERE IsJuridical=0 AND State='Colorado'
--ყოველი განსხვავებული არაიურუდიული პირის სახელი კოლორადოს შტატიდან


--LIKE
SELECT AccountID,OverDraftAmount FROM OverDrafts WHERE OverDraftAmount >1000 AND OverDraftAmount<2000 AND OverdraftAmount LIKE '%.00'
ORDER BY OverDraftAmount
--1000-2000 შუალედში რომელთა OverDraftAmount ბოლოვდება 2 ნულიანზე (ამ შემთხვევაში გამოდის რომ მთელი რიცხვია)


SELECT OverDraftAmount FROM OverDrafts WHERE OverDraftAmount LIKE '____.%'
ORDER BY OverDraftAmount
----ანგარიშის ნომრები სადაც OVERDRAFTAMOUNT-ის მთელი ნაწილი არის ოთხნიშნა


SELECT AccountID,CustomerID, AccoutNumber FROM Accounts WHERE AccoutNumber like '%351_D%'
--ყველა ანგარიშის ნომერი რომელიც შეიცავს 351 შემდეგ აუცილებლად 1 ნებისმიერ სიმბოლოს და შემდეგ D სიმბოლოს



SELECT AccountID,CustomerID, AccoutNumber FROM Accounts WHERE AccoutNumber like 'A4%4'
ORDER BY AccountID
--სადაც ანგარიშის ნომრები იწყება A4-ზე და მთავრდება 4-ზე


SELECT CustomerFirstName, CustomerLastName ,State, City 
FROM Customers 
WHERE City LIKE '% % %'
--ისეთი მომხმარებლბის სახელი, გვარი შტატი და ქალაქი
--რომლის ქალაქის სახელწოდებაში არის 2 სფეისი ანუ შედგება 3 სიტყვისგან


--INNER JOIN
SELECT Accounts.AccountID, Accounts.Currency, Accounts.IsActive, AccountTypes.AccountTypeDescription
FROM Accounts
INNER JOIN AccountTypes ON Accounts.AccountTypeID=AccountTypes.AccountTypeID
WHERE Accounts.Currency IN('USD','EUR') AND Accounts.IsActive=1
ORDER BY AccountID

-- დაასელექთოს ანგარიშების ცხრილიდან ველები : ანგარიშის აიდი, რომელ ვალუტაშია ანგარიში, არის თუ არა აქტიური
-- და ანგარიშის ტიპების ცხრილიდან გამოიტანოს მხოლოდ ანგარიშის ტიპის აღწერა,
-- მხოლოდ იმ შემთხვევაში თუ ანგარიში არის აქტიური და ვალუტა არის (დოლარში ან ევროში)
--INNER JOIN თნაკვეთა ჯოინი ხდება ისეთ ტიპზე რომელიც ორივეს გააჩნია, ანგარიშების ცხრილის კონკრეტულ სვეტებს გვერდიდან მიედგმება ანგარიშის ტიპის აღწერა


SELECT Customers.CustomerFirstName, Customers.CustomerLastName,Customers.Phone, Accounts.AccountID,Accounts.AccoutNumber, Accounts.IsActive FROM Customers
INNER JOIN Accounts ON Customers.CustomerID=Accounts.CustomerID
WHERE  NOT Accounts.IsActive=1 and Accounts.FilialID=5

--დაასელექთოს მომხმარებლების ცხრილიდან მათი სახელი გვარი ტელეფონის ნომერი და ანგარიშებიდან სვეტები: ანგარიშის აიდი, ანგარიშის ნომერი არის თუ არა აქტიური 
--ჯოინი მოხდეს მომხმარებლების აიდით მხოლოდ იმ შემთხვევაში თუ აკმაყოფილებს პირობას არ არის აქტიური ანგარიში და ფილიალის აიდი არის 5.



SELECT Transactions.* ,TransactionTypes.TransactionTypeName, TransactionTypes.TransactionTypeDescription,TransactionTypes.TransactionFeeAmount
FROM Transactions
LEFT JOIN TransactionTypes
ON Transactions.TransactionTypeID=TransactionTypes.TransactionTypeID
WHERE AMOUNT BETWEEN 3000 AND 3500
--ტრანზაქციებიდან დაასელექთოს ყველა სვეტი და დააჯოინოს ტრრანზაქიების ტიპები ტრანზაქციებთან ტრანზაქციების ტიპის აიდის მიხედვით,ასევე დაასელექთოს ტრანზაქციების ტიპებიდან აღწერა და გადახდის საკომისიო.
--იმ შემთხვევაში თუ მეორე მხარეს ანუ ტრანზაქციის ტიპების ცხრილიდან  ვერ მონახავს შესაბამისობას , იმ სვეტებში ჩაიწერება null-ები


SELECT Deposits.DepositID,Deposits.Amount, Deposits.Currency,Deposits.CustomerID, Customers.State, Customers.CustomerAddress
FROM Deposits
RIGHT JOIN Customers  ON Customers.CustomerID=Deposits.CustomerID
WHERE ProductID=4
ORDER BY Deposits.Amount
--დააჯოინოს დეპოზიტების ცხრილი მომხმარებლებთან რომლებმაც შეიძინეს პროდუქტი რომლის აიდიც არის 4
--მარჯვენა ჯოინი აბრუნებს მარჯვენა ცხრილიდან ყველა სვეტს და მარცხენადან მხოლოდ იმათ რომლებიც შესაბამისია პირობის , 
--წინააღმდეგ შემთხვევაში სვეტების მნიშვნელობები ივსება null-ებით.



SELECT Accounts.*, OverDrafts.*
FROM Accounts
FULL JOIN OverDrafts ON Accounts.AccountID=OverDrafts.AccountID
ORDER BY OverDraftAmount DESC
-- დააკავშიროს ანგარიშებისა და ოუვერდრაფტების ცხრილები ანგარიშის აიდი-ნომრით
--თუ არ გვაქვს თავსებადობა მაშინ მნიშვნელობებს შეავსებს null-ებით
--full join-ით წამოიღებს პირველი და მეორე ცხრილიდან ყოველ სვეტს და შესაბამის მნიშვნელობებს
--ჩვენ შემთხვევაში ისეთ ანგარიშებს რომელთაც აქვთ საკრედიტო ლიმიტის გადაჭარბება კლებადობის მიხდვით, ხოლო თუ ასეთი ანგარიშის ნომერი არ ემთხვევა 
--overdraft-ების ცხრილში ანგარიშის ნომერს შეავსებს Null-ებით