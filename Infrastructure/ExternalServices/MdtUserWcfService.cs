using System.ServiceModel;
using System.Threading.Tasks;
using Application.Abstractions;

namespace Saaed360Modern.Infrastructure.ExternalServices;

public class MdtUserWcfService : IMdtUserWcfService
{
    private readonly MdtUserServiceRef.IMdtUserServiceChannel _client;

    public MdtUserWcfService()
    {
        var binding = new BasicHttpBinding
        {
            MaxReceivedMessageSize = 2147483647,
            Security = new BasicHttpSecurity
            {
                Mode = BasicHttpSecurityMode.Transport
            }
        };

        var endpoint = new EndpointAddress("https://saaed360test.saaed.ae/Saaed360WCF/MdtUserService.svc");
        _client = new ChannelFactory<MdtUserServiceRef.IMdtUserServiceChannel>(binding, endpoint).CreateChannel();
    }

    


} 