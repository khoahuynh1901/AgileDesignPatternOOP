import unittest
def add(x, y):
    return x + y


class SimpleTest(unittest.TestCase):
    def testadd1(self):
        SimpleTest.assertEqual(add(4, 5), 9)


if __name__ == '__main__':
    unittest.main()

    import unittest


    def add(x, y):
        return x + y


    class SimpleTest(unittest.TestCase):
        def testadd1(self):
            # Calling assertEqual from the class SimpleTest
            SimpleTest().assertEqual(add(4, 5), 9)


    if __name__ == '__main__':
        unittest.main()
