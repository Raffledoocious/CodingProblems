class Strings(object):
    """
    Various methods for string problems
    """

    @staticmethod
    def chars_unique(string):
        """
        Given a string, returns true iff all characters are unique
        """
        previous_chars = {}
        for char in string:
            if char not in previous_chars:
                previous_chars[char] = 1
            else:
                return False
        return True

    @staticmethod
    def is_permutation(a, b):
        """
        Given two strings, determines iff a is a permutation of b
        """
        if (len(a) != len(b)):
            return False

        a_map = Strings.__build_map(a)

        is_permutation = True
        for char in b.lower():
            if char in a_map:
                if a_map[char] <= 0:
                    is_permutation = False
                    break
                else:
                    a_map[char] -= 1
            else:
                is_permutation = False
                break
        
        return is_permutation

    @staticmethod
    def __build_map(string):
        """
        Builds a dictionary mapping of characters to counts of a string, ignoring case
        """
        char_map = {}

        for char in string.lower():
            if char in char_map:
                char_map[char] += 1
            else:
                char_map[char] = 1
        
        return char_map


