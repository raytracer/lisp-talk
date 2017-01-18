static async Task<int> TestAsync()
{
    Console.WriteLine("Init test method");

    var firstResult = await GetNumberAsync(1);
    Console.WriteLine(firstResult);

    var secondResult = await GetNumberAsync(2);
    Console.WriteLine(secondResult + firstResult);

    var thirdResult = await GetNumberAsync(4);

    Console.WriteLine("I'm done");
    return firstResult - secondResult + thirdResult;
}

public static async Task<int> GetNumberAsync(int number)
    => await Task.Run(() => number);
