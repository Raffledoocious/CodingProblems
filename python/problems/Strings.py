from collections import defaultdict

class Strings(object):
    """
    Various methods for s problems
    """

    @staticmethod
    def chars_unique(s):
        """
        Given a s, returns true iff all characters are unique
        """
        previous_chars = {}
        for char in s:
            if char not in previous_chars:
                previous_chars[char] = 1
            else:
                return False
        return True

    @staticmethod
    def is_perm(a, b):
        """
        Given two ss, determines iff a is a permutation of b
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
    def __build_map(s):
        """
        Builds a dictionary mapping of characters to counts of chars in s, ignoring case
        """
        char_map = {}

        for char in s.lower():
            if char in char_map:
                char_map[char] += 1
            else:
                char_map[char] = 1
        
        return char_map

    @staticmethod
    def convert_spaces(s, length):
        """
        Iterates through character array replacing all spaces with %20. 
        It is assumed the s array is the proper length for the new characters
        """
        copy_index = len(s) - 1

        for i in range(0, length):
            read_index = (length - 1) - i

            if s[read_index] is ' ':
                s[copy_index] = '0'
                s[copy_index - 1] = '2'
                s[copy_index - 2] = '%'
                copy_index -= 3
            else:
                s[copy_index] = s[read_index]
                copy_index -= 1

        return s

    @staticmethod
    def is_palindrome_perm(s):
        """
        Given a string, returns true if string is a permtutation of a palindrome. 

        Example
            dggod -> True (permutation of dgogd)
            cat -> False
        """
        even = len(s) % 2 == 0
        chars = defaultdict(int)

        for char in s:
            chars[char] += 1
        
        seen_odd = False
        for key in chars:
            count = chars[key]

            # Only concerned with odd character counts, even character counts are always fine
            if count % 2 == 1:
                # Odd character count in an even length string
                if even:
                    return False
                elif not even:
                    # If we've seen an odd count character already in a non even string
                    if seen_odd:
                        return False
                    else:
                        seen_odd = True
        
        return True






