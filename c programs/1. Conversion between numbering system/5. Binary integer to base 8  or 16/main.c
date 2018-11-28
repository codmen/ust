#include <stdio.h>
#include "my.h"
int main(){

    char binary_number[200],condition[3],result[100];
	int number,base=2,base_translate;
    printf ("Give a binary number: \n");
    scanf ("%s",&binary_number);
    number= toDeci(binary_number, base);
    printf("Write the base you want to translate this binary number : %s \n", binary_number);
    scanf("%d", &base_translate);
    printf ("Binary number %s in base %d is %s",binary_number,base_translate, fromDeci(result,base_translate,number));
}
