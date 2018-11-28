#include <stdio.h>
#include "my.h"
int main()
{
    int base;
	char* init = malloc(100);
	scanf("%s %d", init , &base);
    baseToBinaryInt(init, base);
	return 0;
}
