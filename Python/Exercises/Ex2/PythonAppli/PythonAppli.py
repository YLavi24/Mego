a=[10,20,31,40,57,62,70,89,77]
right=len(a)-1
left=0
while(left<len(a) and a[left]%2==0):
    left+=1
if(left<len(a)-1):
    while(left<right and a[right]%2==1):
        right-=1
    while(left<right):
        if(a[right]%2==0 and a[left]%2==1):
            ezer=a[left]
            a[left]=a[right]
            a[right]=ezer
            right-=1
            left+=1