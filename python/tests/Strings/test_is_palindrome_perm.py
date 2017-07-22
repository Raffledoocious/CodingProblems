from problems.Strings import Strings

def test_is_palindrome_even_length_returns_true():
    val = "agagbb"
    result = Strings.is_palindrome_perm(val)
    assert result is True

def test_is_palindrome_odd_length_returns_true():
    val = "attcc"
    result = Strings.is_palindrome_perm(val)
    assert result is True

def test_is_not_palindrome_odd_length_returns_false():
    val = "abbc"
    result = Strings.is_palindrome_perm(val)
    assert result is False

def test_is_not_palindrome_even_length_returns_false():
    val = "abbcceef"
    result = Strings.is_palindrome_perm(val)
    assert result is False

def test_is_empty_string_returns_false():
    val = ""
    result = Strings.is_palindrome_perm(val)
    assert result is False
