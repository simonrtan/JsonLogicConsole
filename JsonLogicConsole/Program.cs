var input = new
{
    Name = "John Doe",
    Age = 23,
    IsDeveloper = false
};

var rule = File.ReadAllText(@$"sample.json");

var rules = new RowRules.RowRules();
if (rules.EvaluateData(input, rule))
    Console.WriteLine("Truth!");
else
    Console.WriteLine("Lie!");
