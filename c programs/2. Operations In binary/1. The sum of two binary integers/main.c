#include <stdio.h>
#include "my.h"
int main()
{
    char str1[200], str2[200],result[100];
	int num1,num2,sum,base=2;
    printf ("Give two binary numbers: \n");
    scanf ("%s",&str1);
    scanf ("%s",&str2);
    num1= toDeci(str1, base);
    num2= toDeci(str2, base);
    sum= num1+num2 ;
    printf("%s", str1);printf(" => %d \n", num1);
    printf("%s", str2);printf(" => %d \n", num2);
    printf("%s", fromDeci(result, base, sum));printf(" => %d \n", sum);
	return 0;
}
