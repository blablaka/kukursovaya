#include "pch.h"
#include <iostream>
#include <conio.h>

void main()
{
	const int size = 11;
	int mas[size] = { 11,13,15,26,27,317,322,334,348,540,154686486 };
	int min = mas[0];
	int index = 0;
	for (int i = 0; i < size; i++)
	{
		if (mas[i] < min)
		{
			min = mas[i];
			index = i;
		}
	}
	std::cout << min << std::endl;
}