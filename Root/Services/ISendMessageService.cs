using System.Threading.Tasks;
using Root.DTO;

namespace Root.Services
{
    public interface ISendMessageService
    {
        Task<string> SendTheMessage(MessageModel model);
    }
}