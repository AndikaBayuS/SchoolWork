#include <stdio.h> 

void misteri1(char *);

int main()
{
	char string[] = "characters";
	printf("String sebelum diproses adalah %s\n", string);
	misteri1(string);
	printf("String setelah diproses adalah %s\n", string);
	getch();
}

void misteri1(char *s)
{
	while(*s != '\0')
	{
		if(*s >= 'a' && *s <= 'z') *s -= 32;
		++s;
	}
}