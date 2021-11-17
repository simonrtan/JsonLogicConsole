// See https://aka.ms/new-console-template for more information
using JsonLogic.Net;
using Newtonsoft.Json;

var input = new
{
    Name = "John Doe",
    Age = 23,
    IsDeveloper = false
};

var rule = File.ReadAllText(@$"sample.json");

var evaluator = new JsonLogicEvaluator(EvaluateOperators.Default);

var result = evaluator.Apply(rule, input);

if (result.IsTruthy())
    Console.WriteLine("Truth!");
else
    Console.WriteLine("Lie!");
