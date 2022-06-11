CREATE PROCEDURE sp_finished_product 
AS
--check is there any finished product
SELECT count(stock) FROM Products 
WHERE stock=0