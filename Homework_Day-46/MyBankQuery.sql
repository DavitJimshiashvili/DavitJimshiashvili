use MyBank


--select* from Customers where CustomerID in ( select CustomerID from Deposits)
--select * from Customers as c
--join deposits as d
--on c.CustomerID=d.CustomerID
--join loan.Products as p
--on d.ProductID=p.ProductID


--1.1. ჯოინის და Distinct-ის გარეშე გავარკვიოთ ვის გააჩნია დეპოზიტებიც და
--ანაბრებიც.



--2.დავწეროთ query სადაც დავინახავთ ყველა ჩანაწერს ისე რომ არც ერთი მათგანის
--სესხს დანიშნულების მნიშველობა არ იყოს NULL, შევცვალოთ ჩვენთვის სასურველი
--რაიმე მნიშველობით.

select LoanID ,CustomerID, Purpose 
from (select l.LoanID,l.CustomerID,  ISNULL(l.Purpose,'no details') as purpose 
from loan.Loans as l) as t1
-- აქ ვერ მივხვდი ერთის გარდა ყველა როგორ უნდა დაასელექთოს ისე რომ სათითაოდ ჩამოწერა არ დაჭირდეს


--3.მომხმრებლების რეპორტში დავამატოთ სვეტი სადაც იქნება იმეილები
--რომლებსაც მოშრებული ექნებათ დომეინი
--(@gmail) და ტელეფონებისაგან გამოვყოთ მხოლოდ პროვაიდერები. გამოვიყენოთ
--LEN, CHARINDEX და SUBSTRING.

select CustomerID,EmailAddress,Phone
from (select  c.CustomerID,SUBSTRING(c.EmailAddress,1,charindex('@gmail.com',c.EmailAddress)-1) as EmailAddress,
SUBSTRING(c.Phone,1,CHARINDEX(')',c.Phone)) as Phone from Customers as c) as allias


--4.ვიპოვნოთ ისეთი მომხმარებელი რომლის სახელი მეტია 7 სიმბოლოზე.

SELECT * FROM Customers AS C
WHERE LEN(C.CustomerFirstName)>7


--5.დავადგინოთ რომელ თარიღში ვიქნებით თითოეული ჩვენთაგანი 18000 დღის და
--კვირის რომელი დღე იქნება.

 select datename(WEEKDAY,dateadd(day,18000,GETDATE())) as WhichDay


 --6.

-- დავითვალოთ თითეული სესხის ვადა (დღეებში).

--select*from loan.Loans

select l.*, DATEDIFF(day,l.StartDate, l.EndDate) as DaysDiff 
 from loan.loans as l


--7.

--დავადგინოთ თითეული მომხამრებელი რამდენი თვისააა.

----select* from Customers
select c.*, DATEDIFF(month, c.BirthDate, GETDATE())as MonthsOld 
from Customers as c


--8.

--გაარჩიეთ დანარჩენი ფუნქციები (მათემატიკური, ტექსტებზე, თარიღებზე)


--9.

--დავადგინოთ თითეული შტატიდან რამდენ წარმომადნელი გვყავს (შემდეგ
--გავაკეთოთ იგივე შტატებისა და ქალაქების ჭრილშიც)


----select*from Customers
----order by City

select c.State ,Count(c.State)as FromState
from Customers as c
group by c.State 


select c.State, c.City, Count(*) as FromCity
from Customers as c
group by c.State, c.City


--10.

--დავადგინოთ თითოეულ ანგარიშიდან ჯამურად რა არის გადარიცხული.
--(ვალუტას არ მიაქციოთ ყურადღება)


select t.DebitAccountID,  SUM(Amount) as TotalTransferedAmount
from Transactions as t
group by t.DebitAccountID
order by t.DebitAccountID

select t.CreditAccountID,  SUM(Amount) as TotalRecievedAmount
from Transactions as t
group by t.CreditAccountID
order by t.CreditAccountID


--11.დავადგინოთ თითოეულ კლიენტს ჯამურად რა თანხა აქვს გადარიცხული.
--(ვალუტას არ მიაქციოთ ყურადღება)


select c.customerID,Sum(Amount) as TotalTransferedAmount from Customers as c
join Accounts as a
on c.CustomerID=a.CustomerID
join Transactions as t
on a.AccountID=t.DebitAccountID
group by c.CustomerID
order by c.CustomerID

select c.customerID,Sum(Amount) as TotalReceivedAmount from Customers as c
join Accounts as a
on c.CustomerID=a.CustomerID
join Transactions as t
on a.AccountID=t.CreditAccountID
group by c.CustomerID
order by c.CustomerID


--12.დავადგინოთ ვალუტის ჭრილში რა სესხის თანხა გაიცა ჯამურად (შემდეგ
--ვალუტას დავამატოთ პროდუქტების და ფილიალების ჭრილშიც)

--select* from loan.Loans

select l.Currency, Sum(Amount) as TotalInCurrency 
from loan.Loans as l
group by l.Currency


select* from loan.Loans as l
join loan.Products as p
on l.ProductID=p.ProductID

select l.Currency,p.ProductID,Sum(Amount) as totl from loan.Loans as l
join loan.Products as p
on l.ProductID=p.ProductID
group by p.ProductID,l.Currency
----არ დამისრულებია ბოლომდე ეს ვერ მოვასწარი----------



--13.კლიენტების ჭრილში გამოვიტანოთ თითეუილი კლიენტის სესხებში რომელია
--მინიმალური თანხა, მაქსიმალური თანხა, რაოდენობა.


--select* from loan.loans as l
--order by l.CustomerID

select l.CustomerID, Min(Amount) as Minamount
from loan.loans as l
group by l.CustomerID
order by l.CustomerID

select l.CustomerID, Max(Amount) as Maxamount
from loan.loans as l
group by l.CustomerID
order by l.CustomerID

select l.CustomerID, Sum(Amount) as TotalAmount
from loan.loans as l
group by l.CustomerID
order by l.CustomerID


--14.დავადგინოთ თითეული კლიენტის პირველი გადარიცხვის ტრანზაქციის
--თარიღი.

select*from Transactions

select c.CustomerID,Min(t.TransactionDate) as FirstDebitTransactionDate
from Customers as c
join Accounts as a
on c.CustomerID=a.CustomerID
join Transactions as t
on a.AccountID=t.DebitAccountID
group by c.CustomerID


--15.დავადგინოთ ის კლიენტები რომლებლაც ჯამში აითვისეს 5000 დოლარზე მეტი
--თანხა. (სესხი)


--16. ვიპოვნოთ მომხმარებლებში ხომ არ მოიძებნება ისეთი პიროვნებები ვინც ერთ
--ქუჩაზე ცხოვრობენდა ვაჩვენოთ რომელ ქუჩაზე და რამდენი ?