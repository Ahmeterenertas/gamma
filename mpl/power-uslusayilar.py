import kodlar
import unittest
# Kullanıcıdan iki sayı al
Base = float(input("First number: "))
Power = float(input("Power of first number: "))

# Üs hesapla
Result = Base ** Power

# Sonucu göster
print(f"Sonuç: {Result}")

def test_1(self):
        self.assertEqual(kodlar.my_power(3,5), 125)

if __name__ == "__main__":
    unittest.main()     