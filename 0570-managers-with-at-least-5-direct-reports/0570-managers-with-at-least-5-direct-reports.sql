/* Write your T-SQL query statement below */
-- select name from Employee where id in (select managerId from Employee)

SELECT name FROM Employee WHERE id IN (SELECT managerId FROM Employee GROUP BY managerId HAVING COUNT(id)>=5)