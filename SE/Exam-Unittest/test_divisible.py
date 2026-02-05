import unittest
from divisible import is_divisible_by_3_or_5


class TestDivisibility(unittest.TestCase):

    def test_case_1(self):
        self.assertTrue(is_divisible_by_3_or_5(3))

    def test_case_2(self):
        self.assertTrue(is_divisible_by_3_or_5(5))

    def test_case_3(self):
        self.assertTrue(is_divisible_by_3_or_5(15))

    def test_case_4(self):
        self.assertFalse(is_divisible_by_3_or_5(7))

    def test_case_5(self):
        self.assertFalse(is_divisible_by_3_or_5(22))


if __name__ == "__main__":
    unittest.main()
