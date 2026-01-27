import random

def the_real_biggest(a, b, c):
   
    if a >= b:
        m = a
    else:
        m = b
    
   
    if c > m:
        m = c
        
    return m

a = random.randint(1, 1000)
b = random.randint(1, 1000)
c = random.randint(1, 1000)

print(f"Sayılar: {a}, {b}, {c}")
print("En Büyük (Hesaplanan):", the_real_biggest(a, b, c))

print("En Büyük (Python max):", max(a, b, c))
