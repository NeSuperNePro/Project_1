#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>//��� �������� �����
#include <malloc.h> //��� ������������� ��������� ������
#include <math.h>   //��� �������������� �������

int main()
{

SetConsoleTitle("test 4");//��� �������

SetConsoleCP(1251); //��������� ������� �������� win-cp 1251 � ����� �����
SetConsoleOutputCP(1251);  //��������� ������� �������� win-cp 1251 � �����

int *array;     // ������ ������������������
int N;          // �����
int Fsimple = 0; // ���� �� ����������
int Fdown = 0; // ���� �� ��������
int Fup = 0;    //���� ����� (�����������)
int size = 1;   // ������� ������ �������
int quantityReductions = 0;// ���������� ���������� �������� ������������������, �� ������� �������� �������� ����� �����������
int quantityIncreases = 0;// ���������� ���������� �������� ������������������, �� ������� �������� �������� ����� ����������
int end = 0;    // ������� ����� ������������������
int down = 0, simple = 0; // ���������� �������� �������� � ����������
int lenDown =1, lenSimple = 1; // ����� ������������������ �� �������� � ����������
int MaxDown = 0, MaxSimple = 0; // ������������ ����� �������� � ����������



printf("������ �����:\n");

scanf("%d",&N);

system("cls");//�������  �������

array = (int *)malloc(sizeof(int));//��������� ������ �������

printf("������ ������������������:\n");

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
system("cls");//�������  �������

printf("���� ������������������:\n");
for( int i = 0 ; i < size ; i++ ){
    printf(" %d ", array[i]);
}

printf("\n");
printf("\n");

printf("�����:\n");
printf(" %d %d %d %d ", down, MaxDown, simple, MaxSimple);




    return 0;

}




