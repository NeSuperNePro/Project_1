#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>//��� �������� �����
#include <malloc.h> //��� ������������� ��������� ������
#include <math.h>   //��� �������������� �������

int main()
{
SetConsoleTitle("test 6");//��� �������

SetConsoleCP(1251); //��������� ������� �������� win-cp 1251 � ����� �����
SetConsoleOutputCP(1251);  //��������� ������� �������� win-cp 1251 � �����

int **array;//�������� ������
int **arrayRezult;//������ ��������������
int N;//�������� ����� ( ��� ������� � ������ )
int numberOfLines;// ���������� �����
int numberOfColumns;//���������� ��������
int sumMinus = 0;//������� ���������� ������������� ����� � ������
int sumNotZero = 0;//����� �� ������� ��������� � ������
int h = -1;
int size = 1;

/*printf("������� �������� �����\n");
scanf(" %d \n",&N);

printf("������� ���������� �����\n");
scanf(" %d \n",&numberOfLines);

printf("������� ���������� ��������\n");
scanf(" %d \n",&numberOfColumns); */

N = 2;
numberOfLines = 3;
numberOfColumns = 4;

system("cls");//�������  �������


array = (int **)malloc(numberOfLines * sizeof(int *));      //
for(int i = 0 ; i < numberOfLines ; i++){                   //������������ ����������� ��������� �������
    array[i] = (int *)malloc(numberOfLines * sizeof(int));  //
}                                                           //

printf("������� �������� ������:\n");

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

system("cls");//�������  �������

printf("�������� ������:\n");
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

printf("�������������� ������:\n");

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

