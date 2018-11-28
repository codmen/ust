#include <stdio.h>
int a_to_i(char *str)
{
    int res = 0; // Initialize result

    // Iterate through all characters of input string and
    // update result
    for (int i = 0; str[i] != '\0'; ++i)
        res = res*10 + str[i] - '0';

    // return result.
    return res;
}
int isNegative(int num) {
if (num >=0 ){
    return num;
}
else
if (num<0){
    num=num*(-1);
    return num;
}
}


char reeVal(int num)
{
	if (num >= 0 && num <= 9)
		return (char)(num + '0');
	else
		return (char)(num - 10 + 'A');
}
int val(char c)
{
	if (c >= '0' && c <= '9')
		return (int)c - '0';
	else
		return (int)c - 'A' + 10;
}
str_lenght(char str[200]){

    char  *pt;
    int i=0;
    pt = str;
  while (*pt != '\0') {
    i++;
    pt++;
  }
  return i;

}
void strev(char *str)
{
	int len = str_lenght(str);
	int i;
	for (i = 0; i < len/2; i++)
	{
		char temp = str[i];
		str[i] = str[len-i-1];
		str[len-i-1] = temp;
	}
}

char* fromDeci(char res[], int base, int inputNum)
{

	int index = 0;
	while (inputNum > 0)
	{
		res[index++] = reeVal(inputNum % base);
		inputNum /= base;
	}
	res[index] = '\0';
	strev(res);

	return res;
}


int int_length(int num)
{
    int digit_count = 0;

    while(num > 0)
    {
        digit_count++;
        num /= 10;
    }

    return digit_count;
}
int toDeci(char *str, int base)
{
	int len = str_lenght(str);
	int power = 1;
	int num = 0;
	int i;
	for (i = len - 1; i >= 0; i--)
	{
		if (val(str[i]) >= base)
		{
		return -1;
		}

		num += val(str[i]) * power;
		power = power * base;
	}

	return num;
}
int floatfromDeci(float real , int base){
    int converted[100], i = 1, point;
	long int quotient;
	long int decpart = (int)(real);
	float realpart = real - decpart;


	quotient = decpart;
	do
	{
		converted[i++] = quotient % base;
		quotient = quotient / base;
	} while (quotient != 0);

	point = i++;
	while (realpart != 0.0 && ((i - point) < 8))
	{
		realpart *= base;
		int temp = (int)(realpart);
		converted[i++] = temp;
		realpart = realpart - temp;
	}

	for (int j = point - 1; j > 0; j--)
	{
		if (j != point)
			printf("%X", converted[j]);
	}
	printf(".");

	for (int j = i - 1; j > point; j--)
	{
		if (j != point)
			printf("%X", converted[j]);
	}


}

float power(float x, int y)
{
    float temp;
    if( y == 0)
       return 1;
    temp = power(x, y/2);
    if (y%2 == 0)
        return temp*temp;
    else
    {
        if(y > 0)
            return x*temp*temp;
        else
            return (temp*temp)/x;
    }
}
int declen(char* str)
{
	int k = 0;
	while (str[k] != '.')
		k++;

	return k;
}
double floattoDeci(const char binary[]){
  int bi,i;
  int len = 0;
  int dot = -1;
  double result = 0;

  for(bi = 0; binary[bi] != '\0'; bi++){
    if(binary[bi] == '.'){
      dot = bi;
    }
    len++;
  }
  if(dot == -1)
    dot=len;

  for(i = dot; i >= 0 ; i--){
    if (binary[i] == '1'){
      result += (double) power(2,(dot-i-1));
    }
  }
  for(i=dot; binary[i] != '\0'; i++){
    if (binary[i] == '1'){
      result += 1.0/(double) power(2.0,(double)(i-dot));
    }
  }
  return result;
}


int binaryToBase(char *init,int base){
float decimal = 0;
int temp;

	int len = declen(init) - 1;


	for (int i = 0; init[i] != '\0'; i++)
	{
		if(init[i] >= '0' && init[i] <= '9')
		{
			temp = init[i] - 48;
		}

		else if(init[i] >= 'A' && init[i] <= 'F')
		{
			temp = init[i] - 55;
		}
		else if (init[i] == '.')
		{
			continue;
		}

		decimal += (temp) * power(2, len--);
	}

	float real = decimal;
	long int quotient;
	int converted[100], i = 1;
	int point;

	long int decpart = (int)(real);
	float realpart = real - decpart;


	quotient = decpart;
	do
	{
		converted[i++] = quotient % base;
		quotient = quotient / base;
	} while (quotient != 0);

	point = i++;
	while (realpart != 0.0)
	{
		realpart *= base;
		temp = (int)(realpart);
		converted[i++] = temp;
		realpart = realpart - temp;
	}

	for (int j = 1; j < i; j++)
	{
		if (j != point)
			printf("%X", converted[j]);
		else
			printf(".");
	}


}
int baseToBinaryInt(char *init, int base){
long int decimal = 0;
int temp;

	int len = (int)(str_lenght(init)) - 1;

	for (int i = 0; init[i] != '\0'; i++)
	{
		if(init[i] >= '0' && init[i] <= '9')
		{
			temp = init[i] - 48;
		}

		else if(init[i] >= 'A' && init[i] <= 'F')
		{
			temp = init[i] - 55;
		}

		decimal += (temp) * power(base, len--);
	}

	long int quotient = decimal;
	int converted[100], j, i = 1;

	while (quotient != 0)
	{
		converted[i++] = quotient % 2;
		quotient = quotient / 2;
	}

	for (j = i - 1; j > 0; j--)
		printf("%d", converted[j]);


}

int baseToBinaryFloat(char *init , int base){
float decimal = 0;
int temp;

int len = declen(init) - 1;


	for (int i = 0; init[i] != '\0'; i++)
	{
		if ( init[i] >= '0' && init[i] <= '9' )
		{
			temp = init[i] - 48;
		} else if ( init[i] >= 'A' && init[i] <= 'F' )
		{
			temp = init[i] - 55;
		} else if ( init[i] == '.' )
		{
			continue;
		}

		decimal += (temp) * power(base, len--);
	}

	float real = decimal;
	long int quotient;
	int converted[100], i = 1;
	int point;

	long int decpart = (int) (real);
	float realpart = real - decpart;


	quotient = decpart;
	do
	{
		converted[i++] = quotient % 2;
		quotient = quotient / 2;
	} while (quotient != 0);

	point = i++;
	while (realpart != 0.0)
	{
		realpart *= 2;
		temp = (int) (realpart);
		converted[i++] = temp;
		realpart = realpart - temp;
	}

	for (int j = 1; j < i; j++)
	{
		if ( j != point )
			printf("%X", converted[j]);
		else
			printf(".");
	}


}
void printb(int *x)
{
	for (int j = 15; j >= 0; j--)
	{
		if (j == 8)
			printf(" ");
		printf("%d", x[j]);
	}
}

void next_sequence(int *arr, int length)
{
	int j;

	j = 0;
	while (arr[j] == 1)
	{
		arr[j] = 0;
		j++;
	}
	arr[j] = 1;
}
