#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>//��� �������� �����
#include <malloc.h> //��� ������������� ��������� ������
#include <math.h>   //��� �������������� �������
#include <string.h> //��� ������ �� ��������

int main()
{

SetConsoleTitle("test 3");//��� �������

SetConsoleCP(1251); //��������� ������� �������� win-cp 1251 � ����� �����
SetConsoleOutputCP(1251);  //��������� ������� �������� win-cp 1251 � �����

char *array;// ������ ������
char *arrayRazd;// ������ ������������
int N;// ���������� ������������
char c;//������ ����� � ������
int g = 0;//������� ������ ������
int quantityWordsMaxLen = 0;//���������� ���� ������������ ������
int maxLen = 0;//������������ ������ �����
int Fdiscrepancies = 0;//���� ������������ � ������������
int maxLenIntermediate = 0;//������� ������ �����

//====================================================

printf("������� ������:\n");

array = (char*)malloc(sizeof(char));// ��������� ������ ������� ������
arrayRazd = (char*)malloc(sizeof(char));// ��������� ������ ������� ������������

_flushall();// ��� ��������� ������ 1 ������
while((c = getchar()) != '\n'){
array[g] = c;
g++;
array = (char*)realloc(array, (g+1)*sizeof(char));
}
array[g] = '\0';

system("cls");//�������  �������

//====================================================

printf("������� ���������� ������������:\n");
scanf("%d", &N);

system("cls");//�������  �������
//====================================================

printf("������� ���������������:\n");

arrayRazd = (char*)realloc(arrayRazd, (N+1)*sizeof(char));// ���������� ������� ������������

_flushall();// ��� ��������� ������ 1 ������
for(int i = 0 ; i < N ; i++){
arrayRazd[i] = getchar();
}
arrayRazd[N]= '\0';


system("cls");//�������  �������

//====================================================

//=================================(���� ���������� ����� ������������ ������)

for(int i = 0; i <= g ; i++){
    for(int j = 0; j <= N ; j++){
        if( array[i] == arrayRazd[j] ) {

            Fdiscrepancies = 1;

        }
    }



  if(Fdiscrepancies != 1){

     maxLenIntermediate++;
    printf(" %d ",maxLenIntermediate);
     } else{

        if(maxLenIntermediate > maxLen){

            maxLen = maxLenIntermediate;

        }
        maxLenIntermediate = 0;
     }


  Fdiscrepancies = 0;

}

printf(" { %d } \n",maxLen );
//=================================(����� �����)

//=================================(���� ���������� ���������� ���� ������������ ������)
Fdiscrepancies = 0;


for(int i = 0; i <= (g-maxLen) ; i++){
    for(int j = i ; j < (i+maxLen)  ; j++ ){
       for(int b = 0; b <= N ; b++){
        if(array[j] == arrayRazd[b]){
            Fdiscrepancies = 1;
        }
       }
    }
  if(Fdiscrepancies == 0){
    quantityWordsMaxLen++;
  }
  Fdiscrepancies = 0;
}



//=================================(����� �����)

//====================================================

printf("���� ������:\n");
for(int i = 0 ; i < g ; i++){
    printf("%c", array[i]);
}

printf("\n");
printf("\n");

printf("������ ������������:\n");
for(int i = 0 ; i < N ; i++){
    printf("%c", arrayRazd[i]);
}

printf("\n");
printf("\n");

printf("���������� ���� ������������ ����� � ������:\n");
printf("%d",quantityWordsMaxLen);
    return 0;
}

