/* Write your T-SQL query statement below */
select max(num) as num from
(select num from myNumbers group by num having count(num)=1) as a