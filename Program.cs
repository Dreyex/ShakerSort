using algorithms;


//The Method Definitions
// shake.sort([array]): sorts the array with shakeSort nad outputs every change numerical
// shake.sortBar([array]): sorts the array with shakeSort nad outputs every change with a BarGraphing


//numerical output
int[] array = new int[] {20, 14, 8, 9, 33, 66, 5, 1, 100};
ShakerSort shake = new ShakerSort();
shake.sort(array);

//Bar Graphing output
// int[] array2 = new int[] {10, 8, 5, 9, 4, 6, 3, 1, 2, 7};
// shake.sortBar(array2);