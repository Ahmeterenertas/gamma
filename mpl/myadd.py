import kodlar
import unittest

class TestAdd(unittest.TestCase):
    def test1(self):
        self.assertEqual(kodlar.add(5,5),10)



if __name__=='__main__':
    unittest.main()
