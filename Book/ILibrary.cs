using System.Collections.Generic;
using System.ServiceModel;

namespace BookNS
{
    /// <summary>
    /// Library serviceS
    /// </summary>
    [ServiceContractAttribute]
    public interface ILibrary
    {
        [OperationContract]
        List<Book> AllBooks();

        [OperationContract]
        void AddBook(Book book);

        [OperationContract]
        void UpdatePrice(Book book, double newPrice);
        
    }
}
