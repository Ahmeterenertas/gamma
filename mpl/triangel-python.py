def main():
    a = float(input("a kenarını girin: "))
    b = float(input("b kenarını girin: "))
    c = float(input("c kenarını girin: "))

    if a + b > c and a + c > b and b + c > a:
        print("Üçgen oluşturulabilir")
    else:
        print("Üçgen oluşturulamaz")

main()