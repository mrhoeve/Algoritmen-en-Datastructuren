namespace Algoritmen_en_Datastructuren.Interface
{
    public interface IQueue
    {
        void enqueue(int data);
        int? dequeue();
        bool isEmpty();
        void clear();
    }
}
