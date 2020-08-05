//-----------------------------------------------------------------------
// <summary>
//      Sql Helper Class intends to encapsulate sql native functionalities
// </summary>
//-----------------------------------------------------------------------
namespace EGift.Infrastructure.Helpers
{
    public interface ISqlConnectionHelper<T>
    {
        T EstablishConnection();
    }
}