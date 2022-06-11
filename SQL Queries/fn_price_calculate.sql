CREATE FUNCTION fn_price_calculate (@kur decimal, @id int)
-- get exchange rate and product id
RETURNS decimal
AS
BEGIN
 
  DECLARE @price decimal, @area int
  
  -- ask width and height from productfeatures by id

  select @area = width*height from ProductFeatures

  -- calculate
  Set @price = @area * @kur

  RETURN @price

END