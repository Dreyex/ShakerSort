
using algorithms;

int[] array = new int[] {20, 14, 8, 9, 33, 66, 5, 1, 100};
int[] array2 = new int[array.Length];
ShakerSort shake = new ShakerSort();

array2 = shake.sort(array);
//shake.output(array2);
