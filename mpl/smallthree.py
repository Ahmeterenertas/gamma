# a = 22
# b = 8
# c = 115

'''
m = a

if m >= b:
    if m >= c:
        print("m is the biggest number : " + str(m))
        
        
m = b

if m >= a:
    if m >= c:
        print("m is the biggest number : " + str(m))
    
    
m = c

if m >= a:
    if m >= b:
        print("m is the biggest number : " + str(m))


m = a
if m >= b and m >= c:
    print("m is the biggest number : " + str(m))
    
m = b
if m >= a and m >= c:
    print("m is the biggest number : " + str(m))
    
m = c
if m >= a and m >= b:
    print("m is the biggest number : " + str(m))
    
    '''
    
import random
    
def the_biggest(a,b,c,):
    if a <= b:
        m = a
    else:
        m = b
    if m >= c:
        m = c
    return m
    
a = random.randint(1,1000)
b = random.randint(1,1000)
c = random.randint(1,1000)
print(a, b, c)
print(the_biggest(a,b,c))



