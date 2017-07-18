from problems.Strings import Strings

def test_are_permutations_returns_true():
    is_permutation = Strings.is_perm("cat", "tac")
    assert is_permutation is True

def test_are_not_permutations_returns_false():
    is_permutation = Strings.is_perm("cat", "dog")
    assert is_permutation is False 
    
def test_mixed_case_returns_true():
    is_permutation = Strings.is_perm("Cat", "TaC")
    assert is_permutation is True 

def test_special_chars_returns_true():
    is_permutation = Strings.is_perm("IAMCAT1!", "!1CATMAI")
    assert is_permutation is True 

def test_empty_string_returns_true():
    is_permutation = Strings.is_perm("", "")
    assert is_permutation is True 

def test_empty_string_and_chars_returns_false():
    is_permutation = Strings.is_perm("tac", "")
    assert is_permutation is False 
