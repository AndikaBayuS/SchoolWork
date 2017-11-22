#include <stdio.h> 
void misteri1(char *);
main()
{
	char string[] = "characters";
	printf("String sebelum proses adalah %s", string);
	misteri1(string);
	printf("String setelah proses adalah %s", string);
}
void misteri1(char*s)
{
	while(*s != '\0')
	{
		if(*s >= 'a' && *s <= 'z') *s -= 32;
		++s;
	}
}
