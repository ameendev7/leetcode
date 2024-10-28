/* Write your T-SQL query statement below */
--select p.product_id ,ifnull(round(avg(p.prices*u.units*1.0)/sum(u.units),2),0) as average_price   from Prices p join UnitsSold u on p.product_id=u.product_id and purchase_date between start_date and end_date  group by product_id ; 
SELECT p.product_id, COALESCE(ROUND(SUM(p.price * u.units * 1.0) / SUM(u.units), 2), 0) AS average_price
FROM Prices p
LEFT JOIN UnitsSold u 
    ON p.product_id = u.product_id
    AND purchase_date BETWEEN start_date AND end_date
GROUP BY p.product_id;