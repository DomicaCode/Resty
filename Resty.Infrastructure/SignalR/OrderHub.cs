using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Resty.Infrastructure.SignalR
{
    public class OrderHub : Hub
    {
        #region Methods

        public async Task Send()
        {
            await Clients.All.SendAsync("Send", "test");
        }

        #endregion Methods
    }
}