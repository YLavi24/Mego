USE NORTHWND
--SELECT	OD.OrderID, 
--		OD.ProductID, 
--		OD.Quantity, 
--		OD.UnitPrice,
--		OD.Quantity * OD.UnitPrice AS TotalPerRaw


--FROM [Order Details] AS OD

--SELECT	P.ProductName,
--		P.UnitPrice,
--		P.UnitPrice * 3.5 AS PriceInNIS
					   		 
--FROM	Products AS P, [Order Details] AS OD


--/* פקודת WHERE */

SELECT E.*

FROM Employees AS E

WHERE EmployeeID = 5 OR E.EmployeeID = 6

SELECT E.*
FROM Employees AS E
WHERE EmployeeId != 5

SELECT *
FROM Employees AS E
WHERE EmployeeId >= 3 AND EmployeeId <= 8


SELECT *
FROM Employees AS E
WHERE EmployeeId BETWEEN 3 AND 8


/* פקודות על טקסט */


SELECT *
FROM Employees AS E
WHERE E.FirstName = 'דוד'


SELECT E.*
FROM Employees AS E
WHERE E.FirstName LIKE 'דוד'

SELECT *
FROM Employees AS E
WHERE E.FirstName <> 'דוד'

SELECT E.*
FROM Employees AS E
WHERE E.FirstName = 'Nancy'

SELECT E.*
FROM Employees AS E
WHERE E.FirstName LIKE 'Nancy'


/* פקודת IN */

SELECT C.*
FROM Customers AS C
WHERE C.Country LIKE 'USA' OR C.Country LIKE 'CANADA' OR C.Country LIKE 'MEXICO'


SELECT C.*
FROM Customers AS C
WHERE C.Country IN ('USA', 'CANADA', 'MEXICO')


/* פקודה של תאריך */

SELECT E.*
FROM Employees AS E
WHERE E.HireDate = '03/15/1995'

SELECT E.*
FROM Employees AS E
WHERE E.HireDate LIKE '03/15/1995'

SELECT E.*
FROM Employees AS E
WHERE E.HireDate BETWEEN '01/06/1965' AND '04/05/2005'




SELECT C.*
FROM Customers AS C
WHERE CustomerId > 200 AND DEPTID=14


SELECT	C.CustomerID,
		C.CompanyName,
		C.City,
		C.Country
FROM Customers AS C
WHERE	C.Country = 'France' AND C.ContactTitle = 'Owner' 




SELECT C.CustomerID,
		C.CompanyName,
		C.City,
		C.Country,
		C.ContactTitle
FROM Customers AS C
WHERE C.Country = 'USA' OR C.Country = 'France'


/* פקודת ORDER BY */

SELECT DISTINCT C.Country,
				C.City
FROM Customers AS C
ORDER BY C.Country DESC


SELECT C.*
FROM Customers AS C
WHERE C.City = 'London'
ORDER BY C.ContactName

SELECT C.CustomerID,
		C.ContactTitle,
		C.ContactName,
		C.Country
FROM Customers AS C
WHERE C.Country LIKE 'USA'

SELECT E.*
FROM Employees AS E
WHERE EmployeeID < 10

SELECT	DISTINCT	E.City,
					E.Country
FROM Employees AS E

SELECT	E.City,
		E.Country	
FROM Employees AS E


SELECT P.*
FROM Products AS P

SELECT P.*
FROM Products AS P
WHERE P.ProductID = 1

SELECT C.*
FROM Categories AS C


SELECT	P.ProductID,
		P.ProductName,
		P.QuantityPerUnit
FROM Products AS P
-- WHERE P.QuantityPerUnit like 'Boxes%'
-- WHERE P.QuantityPerUnit like '%Boxes%'
WHERE P.QuantityPerUnit like '___Boxes%'



SELECT	P.ProductID,
		P.ProductName,
		P.QuantityPerUnit
FROM Products AS P
--WHERE P.ProductName like '[ABC]%'
WHERE P.ProductName LIKE 'A%'
OR P.ProductName LIKE 'B%'
OR P.ProductName LIKE 'C%'

SELECT O.OrderID,
		O.OrderDate,
		O.Freight 
FROM Orders AS O
WHERE O.Freight > 35
ORDER BY O.Freight 


SELECT O.OrderID,
		O.OrderDate	
FROM Orders AS O
--WHERE YEAR(O.OrderDate) = 1998
--WHERE MONTH(O.OrderDate) = 10
WHERE DATEPART(QUARTER,O.OrderDate) = 2


SELECT O.OrderID,
		O.OrderDate,
		O.ShipAddress,
		DATEPART(QUARTER, O.OrderDate) AS QUARTER
FROM Orders AS O
WHERE DATEPART(QUARTER, O.OrderDate) %2=0
ORDER BY QUARTER


SELECT P.ProductID,
P.ProductName,
P.CategoryID,
P.UnitPrice,
		P.UnitPrice + (P.UnitPrice * 10 / 100 ) AS TEN

FROM Products AS P
WHERE P.CategoryID = 1


SELECT P.ProductName,
P.UnitPrice,
P.QuantityPerUnit
FROM Products AS P
WHERE P.UnitPrice BETWEEN 50 AND 100
OR 
P.QuantityPerUnit LIKE '%Boxes%'
ORDER BY P.UnitPrice


SELECT O.OrderID,
		O.OrderDate,
		DATEPART(MONTH, O.OrderDate) AS Month,
		O.Freight * 3.5 AS Shekels,
		O.Freight

FROM Orders AS O
WHERE DATEPART(YEAR, O.OrderDate) BETWEEN 1996 AND 1997
AND DATEPART(MONTH, O.OrderDate) %2=0
ORDER BY Month, Shekels

SELECT O.OrderID,
DATEPART(MONTH, O.OrderDate) AS Month,
DATEPART(QUARTER, o.OrderDate) AS Quarter,
O.OrderDate,
O.Freight

FROM Orders AS O
WHERE DATEPART(QUARTER, O.OrderDate) %2 = 0 
ORDER BY Quarter, Month, Freight


SELECT O.OrderID,
		DATEPART(MONTH, O.OrderDate) AS MONTH,
		DATEPART(QUARTER, O.OrderDate)AS QUARTER,
		O.OrderDate,
		O.Freight,
		O.ShipCountry
FROM Orders AS O
WHERE ShipCountry IN ('USA', 'CANADA', 'MEXICO') 
		AND DATEPART(QUARTER, O.OrderDate) %2=0 
		AND O.Freight > 20
ORDER BY MONTH, ShipCountry, Freight