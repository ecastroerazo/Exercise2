using static System.Console;

    string[] numberTypes = {"sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal"};

    int[] size = {sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort), sizeof(int), sizeof(uint),
        sizeof(long), sizeof(ulong), sizeof(float), sizeof(double), sizeof(decimal)};

    object[] minValues = {sbyte.MinValue, byte.MinValue, short.MinValue, ushort.MinValue, int.MinValue, uint.MinValue,
        long.MinValue, ulong.MinValue, float.MinValue, double.MinValue, decimal.MinValue};

    object[] maxValues = {sbyte.MaxValue, byte.MaxValue, short.MaxValue, ushort.MaxValue, int.MaxValue, uint.MaxValue,
        long.MaxValue, ulong.MaxValue, float.MaxValue, double.MaxValue, decimal.MaxValue};

string dashedLine = new string('-', 93);

WriteLine(dashedLine);
WriteLine($"{"Type",-10} {"Byte(s) of memory",-20} {"Min",30} {"Max",30}");
WriteLine(dashedLine);

for (int i = 0; i < numberTypes.Length; i++){
    WriteLine($"{numberTypes[i],-10} {size[i],-20} {minValues[i],30} {maxValues[i],30}");
}
WriteLine(dashedLine);
