select * from Products P inner join [Order Details] O
on P.ProductID=O.ProductID

--hiç satış yapılamayan ürünleri getir 
--solda olup sağda olmayanları da getir 
select * from Products P left join [Order Details] O
on P.ProductID=O.ProductID

--sistemimize kayıt olmuş ama sipariş vermemişse hiç
Select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null


select * from Products P inner join [Order Details] O
on P.ProductID=O.ProductID
inner join Orders od
on od.OrderID=o.OrderID