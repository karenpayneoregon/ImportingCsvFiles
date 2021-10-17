namespace StackOverFlowQuestion.Classes
{
    public class Item
    {
        public string Symbol { get; set; }
        public int Size { get; set; }
        public string Direction { get; set; }
        public string Action { get; set; }
        public string Row => $"{Symbol},{Size},{Direction},{Action}";
    }
}