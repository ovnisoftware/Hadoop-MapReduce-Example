using Microsoft.Hadoop.MapReduce;
using System.Collections.Generic;

namespace AvgReviewByCountry
{
    public class AvgReviewReducer : ReducerCombinerBase
    {
        public override void Reduce(string key, IEnumerable<string> values, ReducerCombinerContext context)
        {
            int totalSurveyTakers = 0;
            int totalFeedback = 0;

            foreach (string value in values)
            {
                totalSurveyTakers++;
                totalFeedback += int.Parse(value);
            }
            double avg = ((double)totalFeedback / (double)totalSurveyTakers);
            context.EmitKeyValue(key, avg.ToString());
        }
    }
}