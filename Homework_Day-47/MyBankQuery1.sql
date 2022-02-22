----1.)
----დადგენილი ზოდიაქოებით და წელიწადით დავაჯგუფოთ (ცალ-
----ცალკე) ორი რეზულტატი. სათითაოდ დავითვალოთ რაოდენობა ცალ-
----ცალკე თითოეულის ჭრილში. (ანუ მაგ: რამდენი მორიელი გვყავს და

----რამდენი ადამიანია დაბადებული ცხენის წელიწადში - ცალკე წლის და
----ცალკე ზოდიაქოს მიხედვით)


----A


--SELECT 
--CASE 
--	WHEN (MONTH(c.BirthDate) = 3 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 4 AND DAY(c.BirthDate) <= 19) THEN 'Aries'
--	WHEN (MONTH(c.BirthDate) = 4 AND DAY(c.BirthDate) >= 20) OR (MONTH(c.BirthDate) = 5 AND DAY(c.BirthDate) <= 20) THEN 'Taurus'
--	WHEN (MONTH(c.BirthDate) = 5 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 6 AND DAY(c.BirthDate) <= 20) THEN 'Gemini'
--	WHEN (MONTH(c.BirthDate) = 6 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 7 AND DAY(c.BirthDate) <= 20) THEN 'Cancer'
--	WHEN (MONTH(c.BirthDate) = 7 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 8 AND DAY(c.BirthDate) <= 20) THEN 'Leo'
--	WHEN (MONTH(c.BirthDate) = 8 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 9 AND DAY(c.BirthDate) <= 20) THEN 'Virgo'
--	WHEN (MONTH(c.BirthDate) = 9 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 10 AND DAY(c.BirthDate) <= 20) THEN 'Libra'
--	WHEN (MONTH(c.BirthDate) = 10 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 11 AND DAY(c.BirthDate) <= 20) THEN 'Scorpio'
--	WHEN (MONTH(c.BirthDate) = 11 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 12 AND DAY(c.BirthDate) <= 20) THEN 'Sagittarius'
--	WHEN (MONTH(c.BirthDate) = 12 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 1 AND DAY(c.BirthDate) <= 20) THEN 'Capricorn'
--	WHEN (MONTH(c.BirthDate) = 1 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 2 AND DAY(c.BirthDate) <= 20) THEN 'Aquarius'
--	WHEN (MONTH(c.BirthDate) = 2 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 3 AND DAY(c.BirthDate) <= 20) THEN 'Pisces'
--END Zodyac,
--COUNT(*) AS People
--FROM customers AS c
--GROUP BY CASE
--	WHEN (MONTH(c.BirthDate) = 3 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 4 AND DAY(c.BirthDate) <= 19) THEN 'Aries'
--	WHEN (MONTH(c.BirthDate) = 4 AND DAY(c.BirthDate) >= 20) OR (MONTH(c.BirthDate) = 5 AND DAY(c.BirthDate) <= 20) THEN 'Taurus'
--	WHEN (MONTH(c.BirthDate) = 5 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 6 AND DAY(c.BirthDate) <= 20) THEN 'Gemini'
--	WHEN (MONTH(c.BirthDate) = 6 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 7 AND DAY(c.BirthDate) <= 20) THEN 'Cancer'
--	WHEN (MONTH(c.BirthDate) = 7 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 8 AND DAY(c.BirthDate) <= 20) THEN 'Leo'
--	WHEN (MONTH(c.BirthDate) = 8 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 9 AND DAY(c.BirthDate) <= 20) THEN 'Virgo'
--	WHEN (MONTH(c.BirthDate) = 9 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 10 AND DAY(c.BirthDate) <= 20) THEN 'Libra'
--	WHEN (MONTH(c.BirthDate) = 10 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 11 AND DAY(c.BirthDate) <= 20) THEN 'Scorpio'
--	WHEN (MONTH(c.BirthDate) = 11 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 12 AND DAY(c.BirthDate) <= 20) THEN 'Sagittarius'
--	WHEN (MONTH(c.BirthDate) = 12 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 1 AND DAY(c.BirthDate) <= 20) THEN 'Capricorn'
--	WHEN (MONTH(c.BirthDate) = 1 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 2 AND DAY(c.BirthDate) <= 20) THEN 'Aquarius'
--	WHEN (MONTH(c.BirthDate) = 2 AND DAY(c.BirthDate) >= 21) OR (MONTH(c.BirthDate) = 3 AND DAY(c.BirthDate) <= 20) THEN 'Pisces'
--END


----B


--SELECT
    
--		CASE
--            WHEN YEAR(c.BirthDate)%12 = 0 THEN 'Monkey'
--            WHEN YEAR(c.BirthDate)%12 = 1 THEN 'Rooster'
--            WHEN YEAR(c.BirthDate)%12 = 2 THEN 'Dog'
--            WHEN YEAR(c.BirthDate)%12 = 3 THEN 'Pig'
--            WHEN YEAR(c.BirthDate)%12 = 4 THEN 'Rat'
--            WHEN YEAR(c.BirthDate)%12 = 5 THEN 'Ox'
--            WHEN YEAR(c.BirthDate)%12 = 6 THEN 'Tiger'
--            WHEN YEAR(c.BirthDate)%12 = 7 THEN 'Hare'
--            WHEN YEAR(c.BirthDate)%12 = 8 THEN 'Dragon'
--            WHEN YEAR(c.BirthDate)%12 = 9 THEN 'Snake'
--            WHEN YEAR(c.BirthDate)%12 = 10 THEN 'Horse'
--            WHEN YEAR(c.BirthDate)%12 = 11 THEN 'Sheep'
--        END
--    AS ZodiacYear,
--	Count(*) as People
--FROM Customers as c
--GROUP BY
--		CASE
--            WHEN YEAR(c.BirthDate)%12 = 0 THEN 'Monkey'
--            WHEN YEAR(c.BirthDate)%12 = 1 THEN 'Rooster'
--            WHEN YEAR(c.BirthDate)%12 = 2 THEN 'Dog'
--            WHEN YEAR(c.BirthDate)%12 = 3 THEN 'Pig'
--            WHEN YEAR(c.BirthDate)%12 = 4 THEN 'Rat'
--            WHEN YEAR(c.BirthDate)%12 = 5 THEN 'Ox'
--            WHEN YEAR(c.BirthDate)%12 = 6 THEN 'Tiger'
--            WHEN YEAR(c.BirthDate)%12 = 7 THEN 'Hare'
--            WHEN YEAR(c.BirthDate)%12 = 8 THEN 'Dragon'
--            WHEN YEAR(c.BirthDate)%12 = 9 THEN 'Snake'
--            WHEN YEAR(c.BirthDate)%12 = 10 THEN 'Horse'
--            WHEN YEAR(c.BirthDate)%12 = 11 THEN 'Sheep'
--        END



----2.)
----Case when-ის გამოყენებით სესხების სვეტს მივამატოთ AmountInGel
----ველი და დღევანდელი დღის კურსით დავითვალოთ სესხების თანხა
----ლარში.


--SELECT l.*,
--CASE
--	WHEN l.Currency='USD' THEN Amount*2.98
--	WHEN l.Currency='EUR' THEN Amount*3.38 
--	WHEN l.Currency='GBP' THEN Amount*4.06 
--END AS AmountInGEL
--FROM LOAN.Loans AS l



----3.)შევქმნათ user defined scalar function-ები, რომელიც გააკეთებს
----ფიბონაჩის მიმიდევრობას, ზედა ზღვრამდე.


--CREATE FUNCTION dbo.Fibonacci(@N int)
--RETURNS INT
--WITH EXECUTE AS CALLER
--AS
--BEGIN
--    DECLARE @a int=0,@b int=1, @c int=0;
--WHILE @N > 1
--BEGIN
--	SET @c=@a+@b;
--	SET @a=@b;
--	SET @b=@c;
--	SET @N = @N - 1;
--END;
--    RETURN(@a);
--END;


----CALLING FUNCTION

--BEGIN DECLARE @CNT INT=1
--WHILE @CNT<=46
--BEGIN
--SELECT DBO.fibonacci(@CNT) AS SequenceFib
--SET @CNT=@CNT+1;
--END;
--END;



----4.)შევქმნათ user defined scalar function-ები , რომელიც რიცხვისათვის
----დაითვლის მის ფქტორიალს.


--CREATE FUNCTION DBO.FACTORIAL(@N INT)
--RETURNS INT
--WITH EXECUTE AS CALLER
--AS
--	BEGIN 
--	DECLARE @RESULT INT=1,@CNT INT=1;

--	WHILE @CNT<=@N
--	BEGIN
--	SET @RESULT*=@N;
--	SET @N=@N-1;
--	END;
--	RETURN (@RESULT);
--	END;


----CALLING FUNCTION

--SELECT DBO.FACTORIAL(5)



--5.)შევქმნათ user defined scalar function-ები , რომელიც დაითვლის
--რიცხვის გამყოფებს. (ანუ რამდენი რიცხვი იყოფა მასზე უნაშთოდ)


--CREATE FUNCTION DBO.DIVISORS(@N INT)
--RETURNS INT
--WITH EXECUTE AS CALLER
--AS
--	BEGIN 
--	DECLARE @COUNT INT=0, @ITERATION INT=1;

--	WHILE @ITERATION<=@N
--	BEGIN

--	IF(@N%@ITERATION=0)
--	SET @COUNT=@COUNT+1;

--	SET @ITERATION=@ITERATION+1;
--	END;
--	RETURN (@COUNT)
--	END;


----CALLING FUNCTION
--SELECT DBO.DIVISORS(15)


----6. შევქნნათ Table value function-ი, რომელიც თითეული
----კლიენტისათვის დააბრუნებს რომელ სეგმენტშია, დაბალში საშუალოში
----თუ მაღალში, სეგმენტი გავთვალოთ შემოსავლის მიხედვით, თუ
----ადამიანს ჩაერიცხა x თანხაზე ნაკლები არის დაბალში, თუ ჩაერიცხა x-y
----თანხის შუალედში არის საშუალო და თუ ჩაერიცხა y-თანხაზე მეტი
----არის მაღალში. X, Y უნდა გადაეცემოდეს ფუნქციას პარამეტრებად


--CREATE FUNCTION DBO.AMOUNTINSEGMENT(
--    @X INT, @Y INT
--)
--RETURNS TABLE
--AS
--RETURN
--    SELECT 
--     C.CustomerID,C.CustomerFirstName,T.DebitAccountID,T.Amount, 
--	 CASE 
--	 WHEN T.Amount<@X THEN 'LOW'
--	 WHEN @X<=T.Amount AND T.Amount<=@Y THEN 'MIDDLE'
--	 WHEN T.Amount>@Y THEN 'HIGH'
--	 END AS 'SEGMENT'
--    FROM
--        Transactions AS T
--	JOIN Accounts AS A
--	ON T.DebitAccountID=A.AccountID
--	JOIN CUSTOMERS AS C
--	ON A.CustomerID=C.CustomerID



----CALLING FUNCTION
--SELECT* FROM DBO.AMOUNTINSEGMENT(1000,3500)
