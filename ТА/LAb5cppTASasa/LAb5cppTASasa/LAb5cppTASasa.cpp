#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <fstream>
using namespace std;
#define max_v 100000
#define min(x,y) ((x)<(y)?(x):(y))

int mass[100][100];         // матрица смежностей
int i, j, N, M, W;
int a, b, c;
int start, konec;
int D[100];		// массив, который хранит минимальный путь
int used[100];
int buff[50];

int short_way(int start, int end);

int main()
{

	std::ifstream inp("Gf.txt");

	//FILE* inp = fopen("Gf.txt", "rt");

	if (!inp.is_open()) // если файл не открыт
		cout << "Файл не может быть открыт!\n"; // сообщить об этом
	else
	{
			inp >> N >> M;
			cout << N << "  " << M << endl;
		for (i = 0; i < N; i++)      // присваиваем элементам матрицы максимальные значения 
			for (j = 0; j < N; j++) {
				mass[i][j] = max_v;
				mass[j][i] = max_v;
			}

		for (i = 0; i < M; i++)	// заполняем матрицу значениями из файла
		{
			inp >> a >> b >> c;
			cout << a << b << c << endl;
			//fscanf(inp, "%d %d %d", &a, &b, &c);
			mass[a][b] = c;
			mass[b][a] = c;
		}
		inp.close(); // закрываем файл
	}
	//fscanf(inp, "%d %d", &N, &M);	// количество узлов и ребер

	/*for (i = 0; i < N; i++)      // присваиваем элементам матрицы максимальные значения 
		for (j = 0; j < N; j++) {
			mass[i][j] = max_v;
			mass[j][i] = max_v;
		}

	for (i = 0; i < M; i++)	// заполняем матрицу значениями из файла
	{
		inp >> a >> b >> c;
		cout << a << b << c << endl;
		//fscanf(inp, "%d %d %d", &a, &b, &c);
		mass[a][b] = c;
		mass[b][a] = c;
	}*/

	


	cout << "Enter the first and the last point: ";    // пример : " 1 3 " : 1 - начало , 3 - конец пути 
	cin >> start >> konec;
													 //scanf("%d %d", &start, &end);
	cout << "The shortest way is : " << short_way(start, konec);
	//printf("\The shortest way is:  %d\n", short_way(start, konec));

	return 0;
}

int short_way(int start, int end)
{
	/* используем алгоритм Дейкстры */

	for (i = 0; i < N; i++) //  заполняем массив, который отвечает за проход узла (если побывали в узле, то присваиваем 1, иначе 0)
		used[i] = 0;

	for (i = 0; i < N; i++)
		D[i] = mass[start][i];	// массив, который содержит кратчайший путь из заданной вершины в вершину с номером i

	used[start] = 1;	// побывали в начальном узле

	for (i = 0; i < N - 2; i++)
	{
		int	min_v = 1000000;
		for (j = 0; j < N; j++)
			if (used[j] == 0 && D[j] < min_v) // если еще не побывали в вершине j, и значение в вершине с номером j меньше, чем предыдущее значение,
			{
				min_v = D[j];	// min_v присваивам минимальное значение.
				W = j;	        // W - номер узла с наименьшим значением пути 
			}
		used[W] = 1;

		for (j = 0; j < N; j++)
			if (used[j] == 0)
				D[j] = min(D[j], D[W] + mass[W][j]);	// выбираем минимальный путь
	}

	if (start == end) // если начальный узел является конечным,
		D[end] = 0; // то путь равен 0


	return D[end];
}