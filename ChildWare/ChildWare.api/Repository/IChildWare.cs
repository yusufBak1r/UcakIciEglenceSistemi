using Aptech.Product.Erp.Api.Response;
using ChildWare.api.Model;

namespace ChildWare.api.Repository
{
    public interface IChildWare
    {
     Task<DatabaseResponse<bool>> Execution(string command);   
    }
    

  
    
}
