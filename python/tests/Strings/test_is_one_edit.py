from problems.Strings import Strings

def test_is_one_replacement_asserts_true():
    result = Strings.is_one_edit_away("ple", "ble")
    assert result is True

def test_is_one_insertion_asserts_true():
    result = Strings.is_one_edit_away("ple", "pale")
    assert result is True

def test_is_one_deletion_asserts_true():
    result = Strings.is_one_edit_away("pale", "ple")
    assert result is True

def test_are_equal_asserts_true():
    result = Strings.is_one_edit_away("pale", "pale")
    assert result is True

def test_are_not_one_edit_asserts_false():
    result = Strings.is_one_edit_away("pale", "paless")
    assert result is False

def test_is_one_replacement_reversed_asserts_true():
    result = Strings.is_one_edit_away("ble", "ple")
    assert result is True

def test_empty_string_asserts_false():
    result = Strings.is_one_edit_away("", "ple")
    assert result is False 

def test_empty_string_asserts_true():
    result = Strings.is_one_edit_away("", "p")
    assert result is True

