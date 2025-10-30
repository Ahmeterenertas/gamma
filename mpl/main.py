import random
meetings = [3, 4, 6, 1]
print(meetings)
meetings.append(10)
print(meetings)
#------------------------
#total = 0 
#for i in range(len(meetings)):
    #total += meetings[i]
    
total = sum(meetings)
#print("avg number of people at a meeting: " + str(round(total/len(meetings))))
    