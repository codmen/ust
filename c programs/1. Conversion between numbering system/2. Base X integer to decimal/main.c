#include <stdio.h>
#include "my.h"

int main()
{
    char str[200];
	int base;
     printf ("Give the number that can be in any base from 2 to 16: \n");
    scanf ("%s",&str);
    printf ("From what base do you want to convert %s in decimal\n", &str);
    scanf ("%d",&base);
	printf("Decimal equivalent of %s in base %d is %d\n", str, base, toDeci(str, base));
	return 0;
}
