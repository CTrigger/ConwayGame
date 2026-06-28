namespace RulesTest
{
    public class MatrixMockup
    {
        public static bool[,] Matrix_3x3_A0 = {
            {true,  false, false},
            {false, true,  false},
            {false, false, true},
        };
        static bool[,] Matrix_3x3_A1 = {
            {false, false, false},
            {false, true, false},
            {false, false, false},
        };

        public static bool[,] Matrix_3x3_B0 = {
            {true,  false, true},
            {false, true,  false},
            {false, false, false},
        };
        static bool[,] Matrix_3x3_B1 = {
            {false, true, false},
            {false, true,  false},
            {false, false, false},
        };

        public static bool[,] Matrix_7x7 =
        {
            {true , true , false, false, false, true , true },
            {false, true , false, false, false, false, false},
            {false, false, true , false, false, true , false},
            {false, false, true , true,  false, false, false},
            {false, true , false, false, false, false, true },
            {true , false, false, false, false, true , false},
            {false, true , false, true , false, true , false},
        };
        public static IEnumerable<TestCaseData> Matrix3x3_0_1()
        {
            yield return new TestCaseData(Matrix_3x3_A0, Matrix_3x3_A1);
            //yield return new TestCaseData(Matrix_3x3_B0, Matrix_3x3_B1);
        }
    }
}
