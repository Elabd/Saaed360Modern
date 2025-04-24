namespace Application.DTOs.Lookup;

public class CheckinSendDto 
{

    public long PersonId { get; set; }

    public long AreaId { get; set; }

    public List<long> SectorIdList { get; set; }

    public long PatrolId { get; set; }

    public DateTime CheckinTime { get; set; }

}