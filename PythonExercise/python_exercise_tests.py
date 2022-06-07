import unittest
from typing import List, Dict

from python_exercise import get_biggest_str, merge_dicts

class TestPythonExerciseMethods(unittest.TestCase):

    def test_get_biggest_str(self):
        strs: List[str] = ["1", "22", "333"]
        expected = "333"

        actual = get_biggest_str(strs)

        self.assertEqual(expected, actual)
    
    def test_get_biggest_str_when_input_is_empty(self):
        actual1 = get_biggest_str([])
        actual2 = get_biggest_str([""])

        self.assertIsNone(actual1)
        self.assertEqual("", actual2)

    def test_get_biggest_str_when_input_is_none(self):
        actual = get_biggest_str(None)

        self.assertIsNone(actual)

    def test_merge_dicts(self):
        dict1 = { "Australia": 200, "Newyork": 100, "Srilanka": 700 }
        dict2 = { "Australia": 300, "Newyork": 300, "Srilanka": 600, "D": 900 }
        expected = { "Australia": 300, "Newyork": 300, "Srilanka": 700, "D": 900} 

        actual = merge_dicts(dict1, dict2)

        self.assertDictEqual(expected, actual)

    def test_merge_dicts_when_1input_is_none(self):
        dict1 = { "Australia": 200, "Newyork": 100, "Srilanka": 700 }
        dict2 = None

        actual = merge_dicts(dict1, dict2)

        self.assertDictEqual(dict1, actual)

    def test_merge_dicts_when_1input_is_empty(self):
        dict1 = dict()
        dict2 = { "Australia": 200, "Newyork": 100, "Srilanka": 700 }

        actual = merge_dicts(dict1, dict2)

        self.assertDictEqual(dict2, actual)


if __name__ == '__main__':
    unittest.main()