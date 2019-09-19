def sumIntervals(x):
    sums=[]
    duplicates=[]
    
    for i in range(0,len(x)) :
        start=x[i][0]
        end=x[i][1]        

        if start in sums:
            duplicates.append(start)
        else:
            sums.append(start)
        
        while start<end:
            start+=1
            if start in sums:
                duplicates.append(start)    
            else:
                sums.append(start)

    z=len(sums)
    length=z-2
    print(length)
    
sumIntervals([[0,2],[1,3],[5,6],[6,8]])
