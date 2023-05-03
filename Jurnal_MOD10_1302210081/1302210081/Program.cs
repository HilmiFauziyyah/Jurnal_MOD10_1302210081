using MatematikaLibraries;

string jawaban = MatematikaLibraries.Class1.turunan(new int[] { 1, 4, -12, 9 });
string jawaban2 = MatematikaLibraries.Class1.integral(new int[] {4,5,-12,9});

Console.WriteLine($"hasil  dari 4x^3 + 6x^2-12x +9 yaitu = \n" +
     $"turunan = 3x2 +8x - 12\n"+
     $"integral = x4 + 2x3 - 6x2 +9x+C"
    );

