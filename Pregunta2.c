#include "stdafx.h"
#include <assert.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include <limits.h>

int freeMem = 50000;
typedef struct
{
	int start;
	int end;
} estructura;
void NewFree(void * p)

{
	
estructura *ptr = (estructura *)p;

	ptr--;
	
	freeMem = freeMem + (ptr->end - ptr->start) + sizeof(estructura);
	
	if (ptr->start != 0)

	{
	
	printf("\nTamaño de memoria : %d\t", ptr->end - ptr->start);
	
	printf("Memoria disponible : %d ", freeMem);
	
	ptr->start = 0;
		//free(ptr);
		printf("\nMemoria liberada...\n");

	}

}

int _tmain(int argc, _TCHAR* argv[])
{
	char *dest;
	dest = (char*)malloc(100);
	NewFree(dest);	
	return 0;	
}