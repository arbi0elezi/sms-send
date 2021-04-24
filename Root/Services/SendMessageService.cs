using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Root.DTO;

namespace Root.Services
{
    public class SendMessageService : ISendMessageService
    {
        private readonly AmazonSimpleNotificationServiceClient _sns;

        public SendMessageService()
        {
            var sns = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USWest2);

            _sns = sns;
        }

        public async Task<string> SendTheMessage(MessageModel model)
        {
            var pubRequest = new PublishRequest
            {
                Message = model.Text,
                PhoneNumber = model.PhoneNumber
            };

            var result = await _sns.PublishAsync(pubRequest);

            return result.MessageId;
        }
    }
}