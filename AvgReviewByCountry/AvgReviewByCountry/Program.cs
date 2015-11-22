using Microsoft.Hadoop.MapReduce;

namespace AvgReviewByCountry
{
    class Program
    {
        public class AvgReviewJob : HadoopJob<AvgReviewMapper, AvgReviewReducer>
        {
            public override HadoopJobConfiguration Configure(ExecutorContext context)
            {
                HadoopJobConfiguration config = new HadoopJobConfiguration();
                config.InputPath = "Input/avgreview";
                config.OutputFolder = "Output/avgreview";
                return config;
            }
        }

        static void Main(string[] args)
        {
            var hadoop = Hadoop.Connect();
            var result = hadoop.MapReduceJob.ExecuteJob<AvgReviewJob>();
        }
    }
}