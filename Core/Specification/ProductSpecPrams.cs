namespace Core.Specification
{
    public class ProductSpecPrams
    {

        private const int MaxPageSize = 10;

        public int PageIndex { get; set;} = 1;
        private int _pageSize = 4;

        public int PageSize{

             get => _pageSize;
             set => _pageSize = (value > MaxPageSize)? MaxPageSize : value;
        }


        public string Sort{get;set;}
        public int? BrandId { get; set;}
        public int? TypeId { get; set;}

        
    }
}