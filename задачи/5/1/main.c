#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>//��� �������� �����
#include <malloc.h>//��� ������������� ��������� ������
#include <math.h>


int main()
{
SetConsoleTitle("test 5");//��� �������

int *a;//������
int F1,F2 = 0;//����� ��� ������ ������� � ���������� ������� ������������ ������ �������� ���������������
int g = 0;//������� ������ ������
int min = 0;//���������� ������ ��������
int n1,n2 = 0;//��� ��������
int index;//������� ������
int answer;//�����

a = (int *)malloc(sizeof(int));//��������� ������ �������

SetConsoleCP(1251); //��������� ������� �������� win-cp 1251 � ����� �����
SetConsoleOutputCP(1251);  //��������� ������� �������� win-cp 1251 � �����

printf("������� ������������������\n");

scanf("%d",&a[g]);
g++;
a = (int *)realloc(a,(g+1)*sizeof(int));
while( F1 != 1 ){
    scanf("%d",&a[g]);
    for(int i = 0; i < g ; i++){
        if( a[i] == a[g]){
            F1 = 1;
        }
    }
 g++;
 a = (int *)realloc(a,(g+1)*sizeof(int));
}


system("cls");//�������  �������


for(int i = 0; i < g ; i++){    //
        if(sqrt(a[i]) > min){   // ���������� ��������������
            min = a[i];         //
        }                       //
    }                           //


index = 1;

while( F2 != 1 ){

    for(int i = 0; i < index ; i++){
        n1 = n1 + a[i];
    }

    for(int i = index+1; i < g ; i++){ //index+1 ��� ��� ��� �� ����� �������� ��� ������ � ������ ������������������
        n2 = n2 + a[i];
    }

    if( sqrt(n1-n2) < min ){
        min = sqrt(n1-n2);
        answer = index;
    }

    if( index == g ){
        F2 = 1;
    }

    n1=0;
    n2=0;
    index++;

}

printf("���� ������������������:\n");
for(int i = 0; i < g ; i++){
    printf(" %d ", a[i]);
}

printf("\n");
printf("\n");

printf("�����:  %d ", answer);

printf("\n");

    return 0;
}
