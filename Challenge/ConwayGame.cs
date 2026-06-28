using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("RulesTest")]
namespace Rules
{
    public class ConwayGame
    {
        #region Variables
        public bool[,] table;

        #endregion

        #region ctor
        public ConwayGame(bool[,] data)
        {

            table = data;

        }

        #endregion

        #region Rules
        public void Next()
        {
            int x = table.GetLength(0);
            int y = table.GetLength(1);
            bool[,] tmp = (bool[,])table.Clone();
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    tmp[i, j] = CellLiveCondition(i, j);

            table = tmp;

        }

        internal bool CellLiveCondition(int line, int column)
        {
            int neighboors = LivingNeighboors(line, column);
            switch (neighboors)
            {
                //Survival
                case 2:
                    return table[line, column];
                //Survival|Revive
                case 3:
                    return true;
                //under | over population
                case 0:
                case 1:
                default:
                    return false;
            }
        }

        internal int LivingNeighboors(int line, int column)
        {
            byte leftTop = Convert.ToByte(IsTop(line) || IsLeft(column) ? false : table[line - 1, column - 1]);
            byte left = Convert.ToByte(IsLeft(column) ? false : table[line, column - 1]);
            byte leftBottom = Convert.ToByte(IsBottom(line) || IsLeft(column) ? false : table[line + 1, column - 1]);
            byte top = Convert.ToByte(IsTop(line) ? false : table[line - 1, column]);
            byte rightTop = Convert.ToByte(IsTop(line) || IsRight(column) ? false : table[line - 1, column + 1]);
            byte right = Convert.ToByte(IsRight(column) ? false : table[line, column + 1]);
            byte rightBottom = Convert.ToByte(IsBottom(line) || IsRight(column) ? false : table[line + 1, column + 1]);
            byte bottom = Convert.ToByte(IsBottom(line) ? false : table[line + 1, column]);
            return leftTop + left + leftBottom + top + bottom + rightTop + right + rightBottom;
        }
        private bool IsTop(int x) => x == 0;
        private bool IsBottom(int x) => x == table.GetLength(0) - 1; //line
        private bool IsLeft(int y) => y == 0;
        private bool IsRight(int y) => y == table.GetLength(1) - 1; //column

        #endregion
    }
}
