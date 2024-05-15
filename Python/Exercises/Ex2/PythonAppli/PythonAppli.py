
w="boker tov BOKER TOV"   #   ascii code
print(w)
i=0
while(i<len(w)):
    print(w[i], ord(w[i]))
    i+=1




# m=[324, 123, 98, 4587, 3, 99]
# i=1
# while(i<len(m)):
#     print(m[i-1]-m[i])
#     i+=1      
# print("SOF")



# m=[12,84,456,34,643,566]
# i=0
# while(i<len(m)):
#     x=int(input("Enter a number: "))
#     if((x-10)>m[i] or (x+10)<m[i]):
#         m[i]=x
#     i+=1
# print(m)


# m=[324, 123, 98, 4587, 3, 99]
# print(m)
# i=0
# while(i<len(m)):
#     x=int(input("Enter a number: "))
#     if((x-10)>m[i] or (x+10)<m[i]):
#         m[i]=x
#     i+=1
# print(m)



# m=[324, 123, 98, 4587, 3, 99]
# #m=[32, 12, 98, 45, 3, 99]
# print(m)    
# i=0
# while(i<len(m)):
#     while(m[i]>9):
#         m[i]=m[i]//10
#     i+=1
# print(m)




# m=[324, 123, 98, 4587, 3, 99]
# print(m)
# i=0
# while(i<len(m)):
#       e=0
#       while(m[i]>0):
#           e=e+m[i]%10 
#           m[i]=m[i]//10
#       m[i]=e
#       i+=1
# print(m)









# while(i<len(m)):
#     e=0
#     while(m[i]>0):
#         e=e+m[i]%10
#         m[i]=m[i]//10
#     m[i]=e
#     i+=1
# print(m)




# a=[4, 5, 8, 7, 9, 2]       #   4+8+2 14
# print(a)    
# i=0
# s=0
# while(i<len(a)):
#     if(a[i]%2==0):
#         s=s+a[i]
#     i+=1
# print(s) 





# a=[4,5,8,7,9,2]
# print(a)
# print(len(a))
# print(a[1:6])
# i=0
# while(i<len(a)):
#     if(a[i]%2==1):
#         a[i]=a[i]+1
#     i+=1
# print(a)





# a=[10,20,31,40,57,6
# 2,70,89,77]
# right=len(a)-1
# left=0
# while(left<len(a) and a[left]%2==0):
#     left+=1
# if(left<len(a)-1):
#     while(left<right and a[right]%2==1):
#         right-=1
#     while(left<right):
#         if(a[right]%2==0 and a[left]%2==1):
#             ezer=a[left]
#             a[left]=a[right]
#             a[right]=ezer
#             right-=1
#             left+=1