#include "pch.h"
#include <iostream>
using namespace std;

int main()
{
	int a[8], count = 0;
	cout << "Enter mas: \n";

	for (int i = 0; i < 8; i++)
		cin >> a[i];

	for (int i = 0; i < 8; i++)
		if (a[i] > 0) { count++; }

	cout << "Kol-vo = " << count;
}