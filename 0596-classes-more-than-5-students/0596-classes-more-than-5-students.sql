/* Write your T-SQL query statement below */
select class from Courses group by class having 4<count(class)