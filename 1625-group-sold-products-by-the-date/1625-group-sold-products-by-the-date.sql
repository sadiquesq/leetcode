/* Write your T-SQL query statement below */


select sell_date, count(product) as num_sold,
string_agg(product, ',') within group (order by product) as products
from (select distinct * from Activities) b
group by sell_date
order by sell_date, products