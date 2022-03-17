using A星寻路算法;
using static System.Console;
SearchRoute searchRoute = new SearchRoute();
int[][] MAZE = new int[][]{
    new int[]{0,1,0,0,0,0,0},
    new int[]{0,0,0,1,0,0,0},
    new int[]{0,0,0,1,1,0,0},
    new int[]{0,0,0,0,1,1,0},
    new int[]{0,1,1,0,0,1,0}
};
Grid start = new Grid(2, 1);
Grid end = new Grid(2, 5);
searchRoute.ResetAll(MAZE, start, end);
searchRoute.GetResultGrid();
searchRoute.OutPutRoute();