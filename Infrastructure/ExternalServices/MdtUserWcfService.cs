using System.ServiceModel;
using System.Threading.Tasks;
using Application.Abstractions;
using Saaed360Modern.Contracts.Wcf.MdtUserServiceRef; // Ensure this matches the namespace in Contracts/Wcf/MdtUserServiceRef/Reference.cs
using Saaed360Modern.Infrastructure.ExternalServices.MdtUserServiceRef; // Ensure this matches the namespace in Infrastructure/ExternalServices/MdtUserServiceRef/Reference.cs

namespace Saaed360Modern.Infrastructure.ExternalServices;

public class MdtUserWcfService : IMdtUserWcfService
{
    private readonly MdtUserServiceClient _client;

    // TODO: Inject IConfiguration to read endpoint address and potentially binding settings
    public MdtUserWcfService()
    {
        // Consider using dependency injection for the client or a client factory
        var binding = new BasicHttpBinding
        {
            Security = new BasicHttpSecurity { Mode = BasicHttpSecurityMode.Transport }, // Assuming HTTPS endpoint
            MaxReceivedMessageSize = 20 * 1024 * 1024, // 20 MB - adjust as needed
            MaxBufferSize = 20 * 1024 * 1024, // Match MaxReceivedMessageSize
            ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max // Use Max for simplicity, or configure specific quotas
        };

        // TODO: Read endpoint address from configuration (e.g., appsettings.json)
        // Using the HTTPS endpoint found in Reference.cs as default
        var endpoint = new EndpointAddress("https://saaed360test.saaed.ae/Saaed360WCF/MdtUserService.svc");

        _client = new MdtUserServiceClient(binding, endpoint);
    }

    // --- Implementation of methods from IMdtUserWcfService ---

    public Task<MdtUserResponse> SaveTemporaryLogoutRequestAsync(MdtUserRequest request)
    {
        return _client.SaveTemporaryLogoutRequestAsync(request);
    }

    public Task<AdminResponse> ConfirmTemporaryLogoutRequestAsync(AdminRequest request)
    {
        return _client.ConfirmTemporaryLogoutRequestAsync(request);
    }

    public Task<AdminResponse> RejectTemporaryLogoutRequestAsync(AdminRequest request)
    {
        return _client.RejectTemporaryLogoutRequestAsync(request);
    }

    public Task<ActivityReasonDto[]> GetRejectionCategoryAsync()
    {
        return _client.GetRejectionCategoryAsync();
    }

    public Task<long> SaveTSIncidentAsync(TSIncidentDto incidentRequestSendDto)
    {
        return _client.SaveTSIncidentAsync(incidentRequestSendDto);
    }

    public Task<DispatcherSendDto> GetTSDispatcherIncidentAsync(long incidentID)
    {
        return _client.GetTSDispatcherIncidentAsync(incidentID);
    }

    public Task<AttendedPatrolResponse> GetAttendedPatrolsAsync(AttendedPatrolRequest request)
    {
        return _client.GetAttendedPatrolsAsync(request);
    }

    public Task<AttendedPatrolResponse> GetAttendedPatrolByLoginIdAsync(AttendedPatrolRequest request)
    {
        return _client.GetAttendedPatrolByLoginIdAsync(request);
    }

    public Task<MDTLogoutRequestResponse> GetMDTLogoutRequestAsync(MDTLogoutRequestRequest request)
    {
        return _client.GetMDTLogoutRequestAsync(request);
    }

    public Task<MDTLogoutRequestResponse> GetMDTLogoutRequestByRequestIdAsync(MDTLogoutRequestRequest request)
    {
        return _client.GetMDTLogoutRequestByRequestIdAsync(request);
    }

    public Task<MdtUserResponse> SavePermanentLogoutRequestAsync(MdtUserRequest request)
    {
        return _client.SavePermanentLogoutRequestAsync(request);
    }

    public Task<AdminResponse> AcknowledgeMdtUserLoginAsync(AdminRequest request)
    {
        return _client.AcknowledgeMdtUserLoginAsync(request);
    }

    public Task<AdminResponse> RejectLogoutRequestAsync(AdminRequest request)
    {
        return _client.RejectLogoutRequestAsync(request);
    }

    public Task<AdminResponse> ConfirmPermanentLogoutRequestAsync(AdminRequest request)
    {
        return _client.ConfirmPermanentLogoutRequestAsync(request);
    }

    public Task<AdminResponse> TempDismissMdtUserAsync(AdminRequest request)
    {
        return _client.TempDismissMdtUserAsync(request);
    }

    public Task<AdminResponse> DismissMdtUserAsync(AdminRequest request)
    {
        return _client.DismissMdtUserAsync(request);
    }

    public Task<ManualLoginPatrolResponse> GetManualLoginPatrolAsync(ManualLoginPatrolRequest request)
    {
        return _client.GetManualLoginPatrolAsync(request);
    }

    public Task<bool> SaveManualLoginAsync(ManualAttandanceDTO[] PatrolsWithOfficers, long OperatorId)
    {
        return _client.SaveManualLoginAsync(PatrolsWithOfficers, OperatorId);
    }

    public Task<CompromiseDTO> GetIncidentCompromiseAsync(string incidentId)
    {
        return _client.GetIncidentCompromiseAsync(incidentId);
    }

    public Task<CompromiseDTO> SaveCompromiseAsync(CompromiseDTO compromise)
    {
        return _client.SaveCompromiseAsync(compromise);
    }

    public Task<DataItemDTO[]> GetDamagePartsAsync()
    {
        return _client.GetDamagePartsAsync();
    }

    public Task<DataItemDTO[]> GetVehicleTypesAsync()
    {
        return _client.GetVehicleTypesAsync();
    }
}
