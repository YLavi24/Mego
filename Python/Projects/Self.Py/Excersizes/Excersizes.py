num=int(input("Please Enter 3 Digits: "))

x1 = num%10
num //= 10

x2 = num%10
num //= 10

x3 = num

sumOfStones = x1+x2+x3

print("the number of the stones collected by all the pigs is:", sumOfStones)
print("if they divied the stones equally, each willl get:", sumOfStones // 3)
print("The remainder of the division of the stones is:", sumOfStones % 3)
print((sumOfStones % 3 ) == False)