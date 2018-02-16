fibb :: Integer -> Integer
fibb n
	| n <= 1 = 0
	| n > 1 = fibb(n-2) + fibb(n-1)