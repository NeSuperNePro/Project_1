from Z9 import DIV_ZZ_Z  # Частное от деления целого на целое (делитель отличен от нуля)
from Z8 import MUL_ZZ_Z  # Умножение целых чисел
from Z7 import SUB_ZZ_Z  # Вычитание целых чисел
from Z3 import MUL_ZM_Z  # Умножение целого на (-1)

def MOD_ZZ_Z(number_1, number_2):  # Остаток от деления целого на целое(делитель отличен от нуля)
    int(number_1)
    int(number_2)

    if number_2 == 0:  # Если делитель ноль то выдать ошибку
        return -1

    if number_1 == 0:  # Если делимое ноль то выдать делитель
        return number_2

    if number_2 < 0:  # Если делитель отрицательный то выдать делитель
        return number_2

    output = DIV_ZZ_Z(abs(number_1), number_2)
    output = MUL_ZZ_Z(output, number_2)
    output = SUB_ZZ_Z(abs(number_1), output)

    if number_1 > 0:
        return output
    if number_1 < 0:
        return MUL_ZM_Z(output)

