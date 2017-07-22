from problems.Strings import Strings

def test_one_space_returns_correctly():
    input_val = ['I', ' ', 'C', 'a', 't', '', '']
    expected = ['I', '%', '2', '0', 'C', 'a', 't']
    result = Strings.convert_spaces(input_val, 5)
    assert result  == expected

def test_two_spaces_returns_correctly():
    input_val = ['I', ' ', 'a', ' ', 'C', 'a', 't', '', '', '', '']
    expected = ['I', '%', '2', '0', 'a', '%', '2', '0', 'C', 'a', 't']
    result = Strings.convert_spaces(input_val, 7)
    assert result  == expected

def test_all_spaces_returns_correctly():
    input_val = [' ', ' ', ' ', ' ', ' ', ' ']
    expected = ['%', '2', '0', '%', '2', '0']
    result = Strings.convert_spaces(input_val, 2)
    assert result  == expected

def test_no_spaces_returns_correctly():
    input_val = ['I', 'C', 'a', 't']
    expected = ['I', 'C', 'a', 't']
    result = Strings.convert_spaces(input_val, 4)
    assert result  == expected
