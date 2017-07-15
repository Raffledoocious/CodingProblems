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
