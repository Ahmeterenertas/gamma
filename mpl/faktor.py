def factorial(a):
    sonuc = 1
    for i in range(1, a + 1):
        sonuc *= i
    return sonuc

print(factorial(5))
