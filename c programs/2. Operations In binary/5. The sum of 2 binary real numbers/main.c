#include <stdio.h>
#include "my.h"
int main()
{
    char str1[200], str2[200];
	float num1,num2,sum;
	int base=2;
    printf ("Give two binary real numbers: \n");
    scanf ("%s",&str1);
    scanf ("%s",&str2);
    num1 = floattoDeci(str1);
    num2 = floattoDeci(str2);
    sum = num1+num2 ;
    printf ("%s",str1); printf (" => %f\n",num1);
    printf ("%s",str2); printf (" => %f\n",num2);
    floatfromDeci(sum,base) ; printf (" => %f\n",sum);
	return 0;
}
