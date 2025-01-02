/* Write your T-SQL query statement below */

select w2.id from weather w1,weather w2 where DATEDIFF(DAY,w1.recordDate,w2.recordDate)=1 
and w1.temperature<w2.temperature
