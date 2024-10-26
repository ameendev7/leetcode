/* Write your T-SQL query statement below */
--select e.name,b.bonus from Employee e left join bonus b Using (empid) where bonus<1000 or bonus is null  ;
SELECT e.name ,b.bonus from
        Employee e LEFT JOIN Bonus b 
          on e.empId=b.empId 
        where 
            bonus < 1000 or 
            bonus is null ;