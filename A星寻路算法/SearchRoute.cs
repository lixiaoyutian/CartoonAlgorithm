using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace A星寻路算法
{
    public class SearchRoute
    {
        private int[][] MAZE;
        private Grid start;
        private Grid end;
        private Grid resultGird = null;
        public SearchRoute(int[][] maze = null, Grid start = null, Grid end = null)
        {
            this.MAZE = maze;
            this.start = start;
            this.end = end;
        }
        public void ResetAll(int[][] maze = null, Grid start = null, Grid end = null)
        {
            this.MAZE = maze;
            this.start = start;
            this.end = end;
        }

        public void ResetStartEnd(Grid start, Grid end)
        {
            this.start = start;
            this.end = end;
        }
        public void OutPutRoute()
        {
            Grid temp = this.resultGird;
            List<Grid> path = new List<Grid>();
            while (temp != null)
            {
                path.Add(new Grid(temp.x, temp.y));
                temp = temp.parent;
            }
            for (int i = 0; i < MAZE.Length; i++)
            {
                for (int j = 0; j < MAZE[0].Length; j++)
                {
                    if (path.Any(p => p.x == i && p.y == j))
                    {
                        Write("*, ");
                    }
                    else
                    {
                        Write(MAZE[i][j] + ", ");
                    }
                }
                WriteLine();
            }
        }
        public Grid GetResultGrid()
        {
            List<Grid> openList = new List<Grid>();
            List<Grid> closeList = new List<Grid>();
            openList.Add(this.start);
            while (openList.Count() > 0)
            {
                Grid currentGrid = findMinGrid(openList);
                openList.Remove(currentGrid);
                closeList.Add(currentGrid);
                List<Grid> neighbors = findNeighbors(currentGrid, openList, closeList);
                foreach (var item in neighbors)
                {
                    item.initGrid(currentGrid, this.end);
                    openList.Add(item);
                }
                if (openList.Any(p => p.x == end.x && p.y == end.y))
                {
                    this.resultGird = openList.Where(p => p.x == end.x && p.y == end.y).FirstOrDefault();
                    return resultGird;
                }
            }
            return null;
        }

        private Grid findMinGrid(List<Grid> openList)
        {
            Grid tempGird = openList[0];
            foreach (var item in openList)
            {
                if (tempGird.f > item.f)
                {
                    tempGird = item;
                }
            }
            return tempGird;
        }

        private List<Grid> findNeighbors(Grid grid, List<Grid> openList, List<Grid> closeList)
        {
            List<Grid> gridList = new List<Grid>();
            Grid gridy1 = new Grid(grid.x, grid.y + 1);
            Grid gridy2 = new Grid(grid.x, grid.y - 1);
            Grid gridx1 = new Grid(grid.x + 1, grid.y);
            Grid gridx2 = new Grid(grid.x - 1, grid.y);
            if (isValidGrid(gridy1, openList, closeList))
            {
                gridList.Add(gridy1);
            }
            if (isValidGrid(gridy2, openList, closeList))
            {
                gridList.Add(gridy2);
            }
            if (isValidGrid(gridx1, openList, closeList))
            {
                gridList.Add(gridx1);
            }
            if (isValidGrid(gridx2, openList, closeList))
            {
                gridList.Add(gridx2);
            }
            return gridList;
        }

        private bool isValidGrid(Grid grid, List<Grid> openList, List<Grid> closeList)
        {
            if (grid.x < 0 || grid.x >= MAZE.Length || grid.y < 0 || grid.y >= MAZE[0].Length)
            {
                return false;
            }
            if (MAZE[grid.x][grid.y] == 1)
            {
                return false;
            }
            if (containGrid(openList, grid) || containGrid(closeList, grid))
            {
                return false;
            }
            return true;
        }

        private bool containGrid(List<Grid> gridList, Grid grid)
        {
            if (gridList.Any(p => p.x == grid.x && p.y == grid.y))
                return true;
            return false;
        }
    }
}