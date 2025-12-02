def checkTriangle(a, b, c):
    result = False
    
    if((a<b+c) and (b<a+c) and (c<a+b)):
        result = True
    return result
def my_power(a,n):
    result = 1
    for i in range(n):
        result *=  a
    return result

def add(a,b):
    return a+b