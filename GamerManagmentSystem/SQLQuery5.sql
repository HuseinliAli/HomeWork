select p.ProductName, sum(od.UnitPrice*od.Quantity) Total 
from Products p
inner join [Order Details] od
on od.ProductID = p.ProductID
group by p.ProductName;