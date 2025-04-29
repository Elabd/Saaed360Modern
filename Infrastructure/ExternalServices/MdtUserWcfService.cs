using System.ServiceModel;
using System.Threading.Tasks;
using Application.Abstractions;
using Saaed360Modern.Infrastructure.ExternalServices.MDTReportServiceRef;
using Saaed360Modern.Infrastructure.ExternalServices.MdtUserServiceRef;

namespace Saaed360Modern.Infrastructure.ExternalServices;

public class MdtUserWcfService : IMdtUserWcfService
{
    private readonly MdtUserServiceClient _client;

    public MdtUserWcfService()
    {
        var binding = new BasicHttpBinding
        {
            Security = new BasicHttpSecurity { Mode = BasicHttpSecurityMode.Transport },
            MaxReceivedMessageSize = 1024 * 1024 * 20 // 20 MB – tune as needed
        };

        // TODO: Read endpoint address from configuration
        var endpoint = new EndpointAddress("https://saaed360test.saaed.ae/Saaed360WCF/MdtUserService.svc");
        _client = new MdtUserServiceClient(binding, endpoint);
    }


} 