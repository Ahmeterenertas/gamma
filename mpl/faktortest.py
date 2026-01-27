import faktor
import unittest

class testfactor(unittest.TestCase):
    def test1(self):
        self.assertEqual(faktor.factorial(5),120)
    def test2(self):
        self.assertEqual(faktor.factorial(4),24)
    def test3(self):
        self.assertEqual(faktor.factorial(3),6)

if __name__ == '__main__':
    unittest.main()