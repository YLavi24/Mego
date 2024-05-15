def Q3(a, i, v):
    i+=1
    while(i<len(a) and a[i]!=v):
        i+=1
    if(i==len(a)):
        return False
    return True

        
        
