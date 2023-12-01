namespace Proper.Core.Interface
{
    public interface IBanner
    {
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ButtonText { get; set; }
    }
}
