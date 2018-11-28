#include <stdio.h>
#include "my.h"
int main()
{
    int base;
	char* init = malloc(100);
    scanf("%s", init);
	scanf("%d", &base);
    floattoDeci(init, base);
	return 0;
}
