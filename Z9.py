from Z1 import ABS_Z_N  # Абсолютная величина числа, результат - натуральное
from Z2 import POS_Z_D  # Определение положительности числа (2 - положительное, 0 — равное нулю, 1 - отрицательное)
from N1_12 import DIV_NN_N  # Частное от деления большего натурального числа на меньшее или равное натуральное с остатком(делитель отличен от нуля)
from N1_12 import ADD_1N_N  # Добавление 1 к натуральному числу

def DIV_ZZ_Z(number_1, number_2):  # Частное от деления целого на целое (делитель отличен от нуля)
    int(number_1)
    int(number_2)

    if POS_Z_D(number_2) == 0:   # Если делитель ноль выдать ошибку
        return -1

    if POS_Z_D(number_1) == 0:   # Если делимое ноль выдать ноль
        return 0

    if (POS_Z_D(number_1) == 1) and (POS_Z_D(number_2) == 1):  # Если оба отрицательные
        return int(DIV_NN_N(ABS_Z_N(number_1), ABS_Z_N(number_2)))

    if (POS_Z_D(number_1) == 2) and (POS_Z_D(number_2) == 2):  # Если оба положительные
        return int(DIV_NN_N(ABS_Z_N(number_1), ABS_Z_N(number_2)))

    if (POS_Z_D(number_1) == 2) or (POS_Z_D(number_2) == 1):  # Если делитель отрицательный
        return int(-1 * DIV_NN_N(ABS_Z_N(number_1), ABS_Z_N(number_2)))

    if (POS_Z_D(number_1) == 1) or (POS_Z_D(number_2) == 2):  # Если делимое отрицательный
        return int(-1 * DIV_NN_N(ABS_Z_N(number_1), ABS_Z_N(number_2)))