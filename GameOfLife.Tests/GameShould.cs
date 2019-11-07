using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace GameOfLife.Tests
{
    public class GameShould
    {
        [Test]
        public void not_kill_or_create_cells()
        {
            var initialWorld = new World(4, 8);
            var outputWorld = new Game().calculateNextGeneration(initialWorld);
            outputWorld.LiveCells.Count.Should().Be(0);
        }
    }

    public class Game
    {
        public World calculateNextGeneration(World initialWorld)
        {
            return initialWorld;
        }
    }

    public class World
    {
        private int Rows { get; set; }
        private int Columns { get; set; }
        public List<Cell> LiveCells { get; private set; }

        public World(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            LiveCells = new List<Cell>();
        }
    }

    public class Cell
    {
    }
}