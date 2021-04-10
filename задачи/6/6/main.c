#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>//для русского языка
#include <malloc.h> //для динамического выделения памяти
#include <math.h>   //для математических функций

int main()
{
SetConsoleTitle("test 6");//имя консоли

SetConsoleCP(1251); //установка кодовой страницы win-cp 1251 в поток ввода
SetConsoleOutputCP(1251);  //установка кодовой страницы win-cp 1251 в поток

int **array;//исходный массив
int **arrayRezult;//массив результирующий
int N;//некторое число ( как указано в задаче )
int numberOfLines;// количество строк
int numberOfColumns;//количество столбцов
int sumMinus = 0;//счетчик количества отрицательных чисел в строке
int sumNotZero = 0;//сумма не нулевых элементов в строке
int h = -1;
int size = 1;

/*printf("введите некторое число\n");
scanf(" %d \n",&N);

printf("введите количество строк\n");
scanf(" %d \n",&numberOfLines);

printf("введите количество столбцов\n");
scanf(" %d \n",&numberOfColumns); */

N = 2;
numberOfLines = 3;
numberOfColumns = 4;

system("cls");//очистка  консоли


array = (int **)malloc(numberOfLines * sizeof(int *));      //
for(int i = 0 ; i < numberOfLines ; i++){                   //динамическое рассширение исходного массива
    array[i] = (int *)malloc(numberOfLines * sizeof(int));  //
}                                                           //

printf("введите исходный массив:\n");

for(int i = 0 ; i < numberOfLines ; i++){
    for(int j = 0 ; j < numberOfColumns ; j++){

        scanf("%d", &array[i][j]);

        if(array[i][j] < 0){sumMinus++;}
        if(sumMinus >= N){

           for (int b = j+1  ; b < numberOfColumns ; b++){
              array[i][b]  = array[i][0];
           }
            break;
        }
    }
    sumMinus = 0;
}

system("cls");//очистка  консоли

printf("исходный массив:\n");
for(int i = 0 ; i < numberOfLines ; i++){
    for(int j =0 ; j < numberOfColumns ; j++){
        printf(" %d ", array[i][j]);
    }
    printf("\n");
}

printf("\n");


arrayRezult = (int **)malloc(numberOfColumns*sizeof(int *));
for(int i =0; i<numberOfColumns; i++)
{

    arrayRezult[i] = (int*)malloc(sizeof(int));

}

printf("Результирующий массив:\n");

for(int i = 0 ; i < numberOfLines ; i++){
    for(int j = 0 ; j < numberOfColumns ; j++){
       sumNotZero = sumNotZero + array[i][j];
    }

    if( sumNotZero != 0){
        arrayRezult = (int **)realloc(arrayRezult,size*sizeof(int *));
        for(int i = 0 ; i < numberOfColumns ; i++){
        arrayRezult[i] = (int *)realloc(arrayRezult[i] ,numberOfColumns * sizeof(int));
        }
        h++;
        size++;
        for(int b = 0 ; b < numberOfColumns ; b++){
           arrayRezult[b][h] = array[i][b];
        }

    }
    sumNotZero = 0;
}


for(int i = 0 ; i < numberOfColumns ; i++){
    for(int j = 0 ; j < h+1 ; j++){
        printf(" %d ", arrayRezult[i][j]);
    }
    printf("\n");
}


    return 0;
}

