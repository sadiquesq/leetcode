/* Write your T-SQL query statement below */
-- select  employee_id from Employees 
-- where manager_id not in
-- (select employee_id from Employees where (manager_id not in employee_id) and salary<30000)

SELECT employee_id FROM Employees WHERE salary<30000 and manager_id NOT IN (SELECT employee_id FROM Employees) order by employee_id