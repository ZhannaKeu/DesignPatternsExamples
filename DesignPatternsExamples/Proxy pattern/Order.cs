namespace DesignPatternsExamples.Proxy_pattern
{
    public class Order
    {
        public List<Item> itemList = null;

        public Order(List<Item> itemList)
        {
            this.itemList = itemList;
        }
    }
}