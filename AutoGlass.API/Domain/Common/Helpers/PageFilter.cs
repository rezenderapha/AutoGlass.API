namespace AutoGlass.API.Domain.Common.Helpers
{
    public class PageFilter
    {
        public const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int ControlPageSize 
        {
            get { return PageSize; }
            set { PageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
    }
}
