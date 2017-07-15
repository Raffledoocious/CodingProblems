from problems.Strings import Strings

def test_are_unique_returns_true():
    unique = Strings.chars_unique("IAmUnique")
    assert unique == True

def test_empty_str_returns_true():
    unique = Strings.chars_unique("")
    assert unique == True

def test_unique_num_returns_true():
    unique = Strings.chars_unique("123abc")
    assert unique == True

def test_non_unique_num_returns_true():
    unique = Strings.chars_unique("123abcc")
    assert unique == False 

def test_unique_special_returns_true():
    unique = Strings.chars_unique("!123abc$")
    assert unique == True

def test_non_unique_special_returns_true():
    unique = Strings.chars_unique("!123abcc!")
    assert unique == False 

def test_unique_diff_case_returns_true():
    unique = Strings.chars_unique("abcABC")
    assert unique == True

def test_single_char_returns_true():
    unique = Strings.chars_unique("a")
    assert unique == True

def test_not_unique_returns_false():
    unique = Strings.chars_unique("DefinitelyNotUnique")
    assert unique == False 
