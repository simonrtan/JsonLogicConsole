using JsonLogic.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RowRules
{
    public class RowRules
    {
        public bool EvaluateData(object data, string rule)
        {
            var jObjectRule = JObject.Parse(rule);

            var evaluator = new JsonLogicEvaluator(EvaluateOperators.Default);

            var result = evaluator.Apply(jObjectRule, data);

            if (result.IsTruthy())
                return true;

            return false;
        }
    }
}