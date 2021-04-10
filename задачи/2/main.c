#include <stdio.h>

#define MAXLEN 100

int input1(int k, int a[MAXLEN][MAXLEN])
{

    int i, j, m;

    m = 0;
    i = 0;

    while (k == 0)
    {

        scanf("%d", &a[0][i]);

        for (j = 0; j < i; j++)
        {

            if (a[0][i] == a[0][j])
            {

                k = 1;

                j = i;
            }
        }

        i++;

        m++;
    }

    return m;
}

void arrinput(int n, int m, int a[MAXLEN][MAXLEN])
{

    int i, j;

    for (i = 1; i < n; i++)
    {

        for (j = 0; j < m; j++)
        {

            scanf("%d", &a[i][j]);
        }
    }
}

void arrout(int a[MAXLEN][MAXLEN], int n, int m)
{

    printf("\n");

    int i, j;

    for (i = 0; i < n; i++)
    {

        for (j = 0; j < m; j++)
        {

            printf("%d ", a[i][j]);
        }

        printf("\n");
    }

    printf("\n");
}

int count_even(int a[MAXLEN][MAXLEN], int n, int j, int r)
{

    int i, c = 0, y = 0;

    for (i = 0; i < n; i++)
    {

        if (a[i][j] % 2 == 0)
        {

            c++;
        }
    }

    if (c >= r)
    {

        y = 1;
    }

    return y;
}

int create_new_array(int a[MAXLEN][MAXLEN], int n, int m, int r, int b[MAXLEN][MAXLEN])
{

    int p = 0, y, j, i, q;

    for (j = m - 1; j >= 0; j--)
    {

        y = count_even(a, n, j, r);

        if (y == 1)
        {

            for (i = 0, q = 0; i < n; i++, q++)
            {

                b[p][q] = a[i][j];
            }

            p++;
        }
    }

    return p;
}

int main()
{

    int i, j, m, n, k, r, p;

    int a[MAXLEN][MAXLEN], b[MAXLEN][MAXLEN];

    scanf("%d", &n);

    k = 0;

    m = input1(k, a);

    arrinput(n, m, a);

    scanf("%d", &r);

    printf("\nOriginal array:");

    arrout(a, n, m);

    p = create_new_array(a, n, m, r, b);

    printf("New array:");

    arrout(b, p, n);

    return 0;
}