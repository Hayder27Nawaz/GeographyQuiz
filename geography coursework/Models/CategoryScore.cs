namespace geography_coursework.Models
{
    public class CategoryScore
    {
        private readonly string _category;
        private readonly string _score;

        public CategoryScore(string category, string score)
        {
            _category = category;
            _score = score;
        }
    }
}
