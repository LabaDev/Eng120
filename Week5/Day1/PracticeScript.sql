/*Write a query that lists all Customers in either Paris or London. Include Customer ID, Company Name and all address fields.(5 marks) */
select CompanyName, City from Customers where City = 'Paris' or City= 'London';

/*List all products stored in bottles.(5 marks)*/
select ProductName, QuantityPerUnit  from Products where QuantityPerUnit like '%bottles%';

/* Repeat question above, but add in the Supplier Name and Country.*/
--select ProductName, QuantityPerUnit, SupplierID from Products where QuantityPerUnit like '%bottles%';
select p.ProductName, p.QuantityPerUnit, s.CompanyName, s.Country
from Products p 
inner join Suppliers s
 on p.SupplierID = s.SupplierID
where QuantityPerUnit like '%bottles%'

--Write an SQL Statement that shows how many products there are in each category. 
--Include Category Name in result set and list the highest number first.

select c.CategoryName as "Category Name", Count(*) as "No of Products"
from Products p
join Categories c 
 on c.CategoryID = p.CategoryID
group by c.CategoryName
order by COUNT(*) desc

--List all UK employees using concatenation to join their titleof courtesy, first name and last name together. 
--Also include their city of residence.(5 marks)

select firstname + ' ' + lastname as "Full Name",City
from Employees
where Country = 'UK'

--Count how many Orders have a Freight amount greater than 100.00 and either USA or UK as Ship Country.(5 marks)
select count(*) as "Shipping from UK or USA where Freight > 100"
from Orders
where Freight > 100 and (ShipCountry = 'UK' or ShipCountry = 'USA')

--Write an SQL Statement to identify the Order Number of the Order with the highest amount of discount applied to that order.(10 marks)

select OrderID, (UnitPrice*Quantity)* Discount as "Total Discount"
from [Order Details]
where UnitPrice * Quantity * Discount = 
(
select max(UnitPrice * Quantity *Discount) as "Discount Amount"
from [Order Details]
)



--List all Employees from the Employees table and who they report to.No Excel required.(5 Marks)
select e.FirstName + ' ' + e.LastName as "Employee", b.FirstName + ' ' + b.LastName as "Boss"
from Employees e
left join Employees b
 on e.ReportsTo = b.EmployeeID
order by "Boss", "Employee"








--Examples

--select 
--c.CustomerID
--, c.ContactName
--, COUNT(*) As "Total Orders"
--FROM Customers c
--INNER JOIN Orders o
--ON c.CustomerId = o.CustomerID
--GROUP BY c.CustomerID, c.ContactName


--select c.CompanyName, e.FirstName + ' ' + e.LastName as "Full Name" , o.OrderID, o.OrderDate, o.Freight
--from Orders o
--join Customers c
-- on o.CustomerID = c.CustomerID
--join Employees e
-- on e.EmployeeID = o.EmployeeID