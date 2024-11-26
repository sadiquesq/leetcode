/* Write your T-SQL query statement below */
select user_id,UPPER(left(name,1))+LOWER(substring(name,2,len(name))) as name from Users order by user_id