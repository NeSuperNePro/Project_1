#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>//��� �������� �����
#include <malloc.h> //��� ������������� ��������� ������
#include <math.h>   //��� �������������� �������

int main()
{
SetConsoleTitle("test 2");//��� �������

SetConsoleCP(1251); //��������� ������� �������� win-cp 1251 � ����� �����
SetConsoleOutputCP(1251);  //��������� ������� �������� win-cp 1251 � �����

int **array;// �������� ������
int **arrayRezult;// �������������� ������
int numberOfLines = 0;//���������� �����
int numberOfColumns = 0;//���������� ��������
int F = 0;//����
int numberOfEvenNumbers = 0;//���������� ������ �����
int numberOfEvenNumbersSum = 0;//������� ���������� ������ �����
int arrayRezultOfLines = 0;

array = (int **)malloc(sizeof(int *));//��������� ������ ��������� �������
array[0] = (int*)malloc(sizeof(int)); //

arrayRezult = (int **)malloc( sizeof(int *));//��������� ������ ��������������� �������
arrayRezult[0] = (int*)malloc(sizeof(int));  //

//====================================================

printf("������� ���������� �����:\n");
scanf("%d",&numberOfLines);

system("cls");//�������  �������

//====================================================


//====================================( ���� ������ 1 ������ )

printf("������� ������:\n");

    scanf("%d",&array[0][numberOfColumns]);
    numberOfColumns++;
    array[0] = (int *)realloc(array[0],(numberOfColumns+1)*sizeof(int));


while( F != 1){

    scanf("%d",&array[0][numberOfColumns]);
    for(int i = 0; i < numberOfColumns; i++){
        if(array[0][numberOfColumns] == array[0][i]){
            F = 1;
        }

    }
    numberOfColumns++;

    array[0] = (int *)realloc(array[0],(numberOfColumns+1)*sizeof(int));

}

//====================================( ����� )




//====================================( ���� ���������� ������� �� ���������� ����� )
array = (int **)realloc(array,numberOfLines*sizeof(int *));
for(int i = 1; i < numberOfLines; i++){
array[i] = (int*)malloc(sizeof(int));
array[i] = (int *)realloc(array[i],numberOfLines*sizeof(int));
}

//====================================( ����� )




//====================================( ���� ���������� ����� )

for(int i = 1; i < numberOfLines; i++){
for(int j = 0; j < numberOfColumns; j++){
 scanf("%d",&array[i][j]);
}
}

//====================================( ����� )




//====================================================






//====================================================
system("cls");//�������  �������

printf("������� ���������� ������ �����:\n");
scanf("%d",&numberOfEvenNumbers);

system("cls");//�������  �������


//====================================================
arrayRezult = (int **)realloc(arrayRezult,numberOfLines*sizeof(int *));


for(int j = 0; j < numberOfColumns; j++){
    for(int i = 0; i < numberOfLines; i++){

        if(array[i][j] % 2 == 0){

          numberOfEvenNumbersSum++;

        }

    }

    if(numberOfEvenNumbersSum >= numberOfEvenNumbers){

        for(int i = 0; i < numberOfLines; i++){

            arrayRezult[arrayRezultOfLines][i]=array[i][j];
        }

        arrayRezultOfLines++;
        for(int i = 1; i < numberOfLines; i++){

            arrayRezult[i] = (int*)malloc(sizeof(int));
            arrayRezult[i] = (int *)realloc(arrayRezult[i],numberOfLines*sizeof(int));

        }
    }

    numberOfEvenNumbersSum = 0;
}








//====================================================
printf("�������� ������:\n");

for(int i = 0; i < numberOfLines; i++){
for(int j = 0; j < numberOfColumns; j++){
 printf(" %d ",array[i][j]);
}
printf("\n");
}

printf("�������������� ������:\n");

for(int i = 0; i < arrayRezultOfLines; i++){
for(int j = 0; j < numberOfLines; j++){
 printf(" %d ",arrayRezult[i][j]);
}
printf("\n");
}

    return 0;
}
