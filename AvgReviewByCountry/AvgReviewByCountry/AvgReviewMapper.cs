using Microsoft.Hadoop.MapReduce;

namespace AvgReviewByCountry
{
    public class AvgReviewMapper : MapperBase
    {
        public override void Map(string inputLine, MapperContext context)
        {
            string[] inputValues = inputLine.Split(',');
            //Pulls all responses that link to the id of this question
            if (inputValues[1].Trim() == "10001")
            {
                string ip = inputValues[0].Trim();
                string country = IpAddressResolver.Resolve(ip);
                context.EmitKeyValue(country, inputValues[2]);
            }
        }
    }
}