namespace SearchService.RequestHelpers
{
    public class SearchParams
    {
        public String SearchTerm { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize  { get; set; } = 4;
        public String Seller { get; set; }
        public String Winner { get; set; }
        public String OrderBy { get; set; }
        public String FilterBy { get; set; }
    }
}