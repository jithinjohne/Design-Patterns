
namespace ChainOfResponsibility
{
    public interface IHandler
    {
        void Handle(int withdrawalAmount);
    }
}