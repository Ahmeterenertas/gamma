import random

sayi1 = random.randint(1,10)
sayi2 = random.randint(1,10)
sayi3 = random.randint(1,10)
sayi4 = random.randint(1,10)

meetings = [sayi1,sayi2,sayi3,sayi4]
print(meetings)
meetings.append(10)
print(meetings)
#-------------------
total = 0
for i in range(len(meetings)):
    total = sum(meetings)

print("avg number of people at a meeting : " + str(round(total/len(meetings))))
