#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>//дл€ русского €зыка
#include <malloc.h> //дл€ динамического выделени€ пам€ти
#include <math.h>   //дл€ математических функций

int main()
{

SetConsoleTitle("test 4");//им€ консоли

SetConsoleCP(1251); //установка кодовой страницы win-cp 1251 в поток ввода
SetConsoleOutputCP(1251);  //установка кодовой страницы win-cp 1251 в поток

int *array;     // массив последовательности
int N;          // число
int Fsimple = 0; // ‘лаг на повторение
int Fdown = 0; // ‘лаг на убывание
int Fup = 0;    //флаг ввода (возрастание)
int size = 1;   // счетчик длинны массива
int quantityReductions = 0;// количество количество участков последовательности, на которых значени€ вводимых чисел уменьшаютс€
int quantityIncreases = 0;// количество количество участков последовательности, на которых значени€ вводимых чисел возрастают
int end = 0;    // счетчик конца последовательности
int down = 0, simple = 0; // количество участков убывани€ и повторени€
int lenDown =1, lenSimple = 1; // длина последовательности на убывание и повторение
int MaxDown = 0, MaxSimple = 0; // максимальные длины убывани€ и повторени€



printf("¬вести число:\n");

scanf("%d",&N);

system("cls");//очистка  консоли

array = (int *)malloc(sizeof(int));//выделение пам€ти массиву

printf("¬вести последовательность:\n");

scanf("%d",&array[0]);

while (N != end){

scanf("%d",&array[size]);


if(array[size-1] < array[size]){
    if(Fup == 0){
            Fup = 1;
            Fsimple = 0;
            Fdown = 0;
            end++;

        }
}
if(array[size-1] > array[size]){
    lenDown++;
    if(Fdown == 0){
        Fdown = 1;
        Fup = 0;
        Fsimple = 0;
        down++;
    }
    if (lenDown > MaxDown){
    MaxDown = lenDown;
}
    lenSimple = 0;
}
if(array[size-1] == array[size]){
    lenSimple++;
    if(Fsimple == 0){
        Fsimple = 1;
        Fup = 0;
        Fdown = 0;
        simple++;
    }
    if (lenSimple > MaxSimple){
    MaxSimple = lenSimple;
    }
    lenDown = 0;

}
size++;
array = (int *)realloc(array,(size)*sizeof(int));
}
system("cls");//очистка  консоли

printf("¬аша последовательность:\n");
for( int i = 0 ; i < size ; i++ ){
    printf(" %d ", array[i]);
}

printf("\n");
printf("\n");

printf("ќтвет:\n");
printf(" %d %d %d %d ", down, MaxDown, simple, MaxSimple);




    return 0;

}




