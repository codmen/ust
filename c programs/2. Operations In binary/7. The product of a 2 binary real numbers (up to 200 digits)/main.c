#include <stdio.h>
#include "my.h"
int main()
{
    char str1[200], str2[200];
	float num1,num2,product;
	int base=2;
    printf ("Give two binary real numbers: \n");
    scanf ("%s",&str1);
    scanf ("%s",&str2);
    num1 = floattoDeci(str1);
    num2 = floattoDeci(str2);
    product = num1*num2 ;
    printf ("%s",str1); printf (" => %f\n",num1);
    printf ("%s",str2); printf (" => %f\n",num2);
    floatfromDeci(product,base) ; printf (" => %f\n",product);
	return 0;
}
