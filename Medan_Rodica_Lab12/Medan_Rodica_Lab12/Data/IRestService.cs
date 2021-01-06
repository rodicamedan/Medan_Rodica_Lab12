using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Medan_Rodica_Lab12.Models;

namespace Medan_Rodica_Lab12.Data
{
    public interface IRestService
    {
            Task<List<ShopList>> RefreshDataAsync();
            Task SaveShopListAsync(ShopList item, bool isNewItem);
            Task DeleteShopListAsync(int id);
        
    }
}
