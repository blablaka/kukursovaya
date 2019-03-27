// ConsoleApplication1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#include "pch.h"
#include <iostream>
#include <stack>
#include <locale.h>

using namespace std;

int main(void) {

	setlocale(LC_ALL, "rus");
	stack<int> stack1;
	stack<int> stack2;
	for (int i = 0; i < 5; i++) {
		cout << i+1 << " ";
	}
	cout << " - первый до обмена\n";
	for (int i = 0; i < 5; i++) {
		cout << i + 20 << " ";
	}
	cout << " - второй до обмена\n";
	for (int i = 0; i < 5; i++) {
		stack1.push(i + 1);
	}
	for (int i = 0; i < 5; i++)
		stack2.push(i + 20);
	swap(stack1, stack2);
	cout << "первый после обмена: ";
	while (!stack1.empty()) {
		cout << stack1.top() << " ";
		stack1.pop();
	}
	cout << endl;
	cout << "\nвторой после обмена: ";
	while (!stack2.empty()) {
		cout << stack2.top() << " ";
		stack2.pop();
	}

	cout << endl;

	return 0;
}