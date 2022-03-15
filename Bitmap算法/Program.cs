using Bitmap算法;
using static System.Console;

Bitmap bitmap = new Bitmap(128);
bitmap.setBit(69);
bitmap.setBit(127);
WriteLine(bitmap.getBit(69));
WriteLine(bitmap.getBit(70));