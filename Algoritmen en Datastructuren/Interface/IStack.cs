namespace Algoritmen_en_Datastructuren.Interface
{
    public interface IStack<T>
    {
        void Push(T data);
        T Pop();
        T Top();
    }
}
