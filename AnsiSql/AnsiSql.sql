﻿--Select
--ANSI
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
select * from Products where categoryId = 1 or CategoryID=3

select * from Products where categoryId = 1 or UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc --ascending --descending

select count(*) adet from Products where categoryId = 2

select CategoryID, count(*) from products where unitprice>20 group by CategoryID having count(*) < 10

select products.ProductID, products.ProductName, Products.UnitPrice, Categories.CategoryName
from products inner join Categories
on Products.CategoryID = Categories.CategoryID
where products.UnitPrice>10


--DTO Data Transformation Object

select * from products p inner join [Order Details] od
on p.ProductID = od.ProductID 
inner join orders o
on o.OrderID = od.OrderID

select * from customers c left join orders o
on c.CustomerID = o.CustomerID

where o.CustomerID is null




select count(*) numberofunitprices, UnitPrice from products group by UnitPrice order by unitprice asc

select ProductName, UnitPrice from products order by unitprice asc

select customerid, shipcountry from orders order by ShipCountry

select count(distinct customerid) numberofcustomerspersc, shipcountry from orders group by shipcountry

select p.Productname, sum(od.UnitPrice * od.Quantity) totalrevenueperproduct from Products p
inner join [Order Details] od on od.ProductID = p.ProductID inner join orders o
on od.OrderID = o.Orderid group by p.ProductName
