( If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000. )

: g if r@ + else then ;

: f r@ pushn 0 == if else
  r@ pushn 3 %  pushn 0 ==
  r@ pushn 5 % pushn 0 ==
  or pushn g call
  r> pushn 1 - >r pushn recurse call then ;
push1 231 3 0 0 >r pushn 0 pushn f call print
( pushn 9 >r pushn 0 pushn f call print )
