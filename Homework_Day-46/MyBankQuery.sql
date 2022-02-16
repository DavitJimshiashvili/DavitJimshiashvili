use MyBank


--1.1. ჯოინის და Distinct-ის გარეშე გავარკვიოთ ვის გააჩნია დეპოზიტებიც და
--ანაბრებიც.


select* from Customers where CustomerID in ( select CustomerID from Deposits)



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



 --6.დავითვალოთ თითეული სესხის ვადა (დღეებში).


select l.*, DATEDIFF(day,l.StartDate, l.EndDate) as DaysDiff 
 from loan.loans as l



--7.დავადგინოთ თითეული მომხამრებელი რამდენი თვისააა.


select c.*, DATEDIFF(month, c.BirthDate, GETDATE())as MonthsOld 
from Customers as c



--8.გაარჩიეთ დანარჩენი ფუნქციები (მათემატიკური, ტექსტებზე, თარიღებზე)



--9.დავადგინოთ თითეული შტატიდან რამდენ წარმომადნელი გვყავს (შემდეგ
--გავაკეთოთ იგივე შტატებისა და ქალაქების ჭრილშიც)


select c.State ,Count(c.State)as FromState
from Customers as c
group by c.State 


select c.State, c.City, Count(*) as FromCity
from Customers as c
group by c.State, c.City



--10.დავადგინოთ თითოეულ ანგარიშიდან ჯამურად რა არის გადარიცხული.
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


select l.Currency, Sum(Amount) as TotalInCurrency 
from loan.Loans as l
group by l.Currency


select l.Currency,p.ProductID,l.filialID,Sum(Amount) as total from loan.Loans as l
join loan.Products as p
on l.ProductID=p.ProductID
group by l.Currency,p.ProductID, l.FilialID
order by l.Currency, p.ProductID, l.FilialID



--13.კლიენტების ჭრილში გამოვიტანოთ თითეუილი კლიენტის სესხებში რომელია
--მინიმალური თანხა, მაქსიმალური თანხა, რაოდენობა.


select l.CustomerID ,Min(Amount) as MinAmount,Max(Amount) as MaxAmount,Count(*) LoanCount
from loan.Loans as l
group by l.CustomerID
order by l.CustomerID



--14.დავადგინოთ თითეული კლიენტის პირველი გადარიცხვის ტრანზაქციის
--თარიღი.


select c.CustomerID,Min(t.TransactionDate) as FirstDebitTransactionDate
from Customers as c
join Accounts as a
on c.CustomerID=a.CustomerID
join Transactions as t
on a.AccountID=t.DebitAccountID
group by c.CustomerID



--15.დავადგინოთ ის კლიენტები რომლებლაც ჯამში აითვისეს 5000 დოლარზე მეტი
--თანხა. (სესხი)


select l.CustomerID, Sum(Amount) as TotalAmountUSD 
from loan.loans as l
where l.Currency= 'USD' 
group by l.CustomerID
having Sum(Amount)>5000
order by TotalAmountUSD



--16. ვიპოვნოთ მომხმარებლებში ხომ არ მოიძებნება ისეთი პიროვნებები ვინც ერთ
--ქუჩაზე ცხოვრობენდა ვაჩვენოთ რომელ ქუჩაზე და რამდენი ?


select Street ,count(*) as count
from (select C.CustomerID,SUBSTRING(c.CustomerAddress,1, CHARINDEX('#',c.customerAddress)-1) as Street from Customers as c) as t1
group by Street



--select* from Customers as c
--where c.CustomerAddress like 'Charlotte wh%'