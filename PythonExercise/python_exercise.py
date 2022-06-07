from typing import List, Dict

def merge_dicts(first_dict: Dict[str, int], second_dict: Dict[str, int]) -> Dict[str, int]:
    result: Dict[str, int] = dict()
    if first_dict is None: first_dict = dict()

    if second_dict is None: second_dict = dict()
        
    for res_key, res_val in first_dict.items():    
        if res_key in second_dict:
            val2 = second_dict[res_key]
            res_val = max(res_val, val2)

        result[res_key] = res_val

    for res_key, res_val in second_dict.items():
        if res_key in result:
            continue

        result[res_key] = res_val

    return result

# Complexity: O(n)
def get_biggest_str(strings: List[str]) -> str:
    if not strings:
        return None
    max_str = max(strings, key = len)
    return max_str

def main():
    # my_dict1 = { "Australia": 200, "Newyork": 100, "Srilanka": 700 }
    my_dict1 = None
    my_dict2 = {}
    # my_dict2 = { "Austraila": 300, "Newyork": 300, "Srilanka": 600, "D": 900 }
    res = merge_dicts(my_dict1, my_dict2)
    print()

if __name__ == "__main__":
    main()
