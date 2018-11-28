#include <stdio.h>
#include "my.h"

int main()
{   int inputNum, base;
    char result[100];
    printf ("Give the number in base 10: \n");
    scanf ("%d",&inputNum);
    printf ("In which base do you want to convert number %d ?\n", inputNum);
    scanf ("%d",&base);
	printf("Equivalent of number %d in base %d is %s\n", inputNum, base, fromDeci(result, base, inputNum));
	return 0;
}
