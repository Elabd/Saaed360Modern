using System;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Domain.Enums
{
    public enum PersistanceInstruction : int
    {
        None = 0,
        Add = 1,
        Update = 2,
        SoftDelete = 3
    }

    public enum AuthenticationStatus : int
    {
        Success = 1,
        Fail = 0,
        AlreadyLoggedIn = 2,
        TempLogin = 3
    }

    

    public enum RoleCategory : int
    {
        CallTaker = 1,
        Dispatcher = 2,
        TrafficExpert = 3,
        Supervisior = 4
    }

    public enum ActivityCategory : int
    {
        Incident = 1,
        Call = 2,
        Dispatching = 4,
        SupportRequest = 5,
        Checkin = 1010,
        Checkout = 1011,
        [StringValue("PR")]
        PartolIncidentRequest = 1012,
        [StringValue("PRS")]
        PatrolRequestSupport = 1013,
        DeviceCheckup = 2012,
        CorrectDevice = 2013,
        FaultyDevice = 2014,
        RequestMission = 2041,
        Mission = 2042,
        AcceptMission = 2043,
        CancelMission = 2048,
        RejectMission = 2044,
        FinishMission = 2045,
        DispatcherRecievedIncidentDelayed = 2054,
        AssignResourceDelayed = 2055,
        ArriveAtSceneDelayed = 2056,
        LeftTheSceneDelayed = 2057,
        FinishPatrol = 2060,
        Arrival2Reasons = 2085,
        EndARCDelayReason = 2086,
    }

    public enum LocationCategory : int
    {
        LandMark = 1
    }

    [DataContract]
    [Flags]
    public enum OrganizationCategory : int
    {
        [EnumMember]
        CallTaker = 5,
        [EnumMember]
        Dispatcher = 2,
        [EnumMember]
        SupportRequest = 3,
        [EnumMember]
        LandMarkType = 4,
        [EnumMember]
        InternalSupportRequest = 6,
        [EnumMember]
        ExtrnalSupportRequest = 7
    }

    public enum AreaRelationType : int
    {
        AreaInEmirate = 1,
        LandmarkInArea = 2
    }

    public enum AreaRelationCategory : int
    {
        AreaRelationCategory = 1
    }

    public enum SourceEnum : int
    {
        Source = 1,
        Source1 = 3,
        Source2 = 4
    }

    public enum OrganizationEnum : int
    {
        Ambulance = 4,
        RSP = 6
    }

    public enum StatusEnum : int
    {
        SaveIncident = 5,
        IdentifiedLocation = 4,
        DeviceCheckUp = 2023,
        AssignResource = 12,
        RequestMission = 2038,
        AcceptMission = 2039,
        FinishMission = 2041,
        CancelMission = 2043,
        IL = 2042,
    }

    public enum NotificationRecordingTypeId
    {
        IncidentId = 1,
        CallActivityId = 2,
        IncidentRequestId = 6,
        PatrolAssignmentId = 3,
        MDTRequestId = 4,
        AdminResponseId = 5,
        Mission = 6
    }

    public enum NotificationCriticality
    {
        IncidentAdded = 1,
        IncidentUpdated = 1,
        CommentAdded = 1,
        DispatcherAdded = 3,
        DispatcherDeleted = 3,
        OwnerUpdated = 3,
        CallInformationUpdated = 3,
        SupportAdded = 2,
        SupportStatusChanged = 2,
        IncidentDelayed = 3,
        IncidentNotDelayed = 3,
        IncidentOpened = 3,
        CallArrived = 3,
        Redialed = 3,
        RedialedBeforeSave = 3,
        SmsReceived = 3,
        CallDiverted = 3,
        PatrolDelayed = 3,
        PatrolNotDelayed = 3,
        PatrolAcknowledge = 2,
        RspPatrolAcknowledge = 2,
        PatrolOnRoute = 2,
        RspPatrolOnRoute = 2,
        PatrolAtScene = 3,
        RspPatrolFirstArrival = 2,
        RspPatrolSecondArrival = 2,
        RspPatrolStartSecure = 3,
        RspPatrolEndSecure = 3,
        RspPatrolStartSweeping = 3,
        RspPatrolEndSweeping = 3,
        RspPatrolStartReporting = 3,
        RspPatrolEndReporting = 3,
        RspPatrolFinish = 2,
        PatrolClosed = 2,
        IncidentClosed = 2,
        SupportCancelled = 3,
        PatrolAssigned = 3,
        DispatcherReceivedIncident = 1,
        IncidentAssignedResource = 3,
        IncidentArriveAtScene = 3,
        IncidentLeftTheScene = 3,
        MdtUserLoggedIn = 1,
        MdtUserTempLoggedOut = 3,
        MdtUserLoggedOut = 1,
        MdtUserTempLoggedIn = 3,
        MdtUserLoginAcknowledged = 3,
        TemporaryLogoutRequest = 3,
        TemporaryLogoutRequestConfirmed = 3,
        TemporaryLogoutRequestCancel = 3,
        LogoutRequestCancel = 3,
        TempLogoutByOperator = 3,
        LogoutByOperator = 1,
        PermanentLogoutRequest = 3,
        PermanentLogoutRequestConfirmed = 3,
        PatrolStartReport = 2,
        PatrolEndReport = 2,
        IncidentRequest = 2,
        PatrolAtArrival1 = 2,
        PatrolAtArrival2 = 2,
        PatrolCanceled = 2,
        IncidentCanceled = 3,
        RequestMission = 1,
        AcceptMission = 1,
        RejectMission = 1,
        FinishMission = 1,
        CancelMission = 1,
        IncidentConvertToStation = 2,
    }

    [DataContract]
    [Flags]
    public enum SupportStatusEnum : int
    {
        [EnumMember]
        [StringValue("SRC")]
        Created = 1,
        [EnumMember]
        [StringValue("SROW")]
        OnRoute = 2,
        [EnumMember]
        [StringValue("SRAR")]
        Arrived = 3,
        [EnumMember]
        [StringValue("SRLS")]
        LeftScene = 4,
        [EnumMember]
        [StringValue("SRCA")]
        Cancelled = 5,
        [EnumMember]
        [StringValue("NotAssigned")]
        NotAssigned = 6,
        [EnumMember]
        [StringValue("ISRS")]
        StartSupport = 7,
        [EnumMember]
        [StringValue("ISRE")]
        EndSupport = 8,
    }

    public enum VehicleRole : int
    {
        Causing = 1,
        Damaged = 2
    }

    [DataContract]
    public enum PatrolStatusEnum
    {
        [StringValue("AD")]
        [EnumMember]
        AD = 1,
        [StringValue("AK")]
        [EnumMember]
        AK = 2,
        [StringValue("AR1")]
        [EnumMember]
        AR1 = 3,
        [StringValue("AR2")]
        [EnumMember]
        AR2 = 4,
        [StringValue("SARC")]
        [EnumMember]
        SARC = 5,
        [StringValue("EARC")]
        [EnumMember]
        EARC = 6,
        [StringValue("CL")]
        [EnumMember]
        CL = 7,
        [StringValue("RSPAD")]
        [EnumMember]
        RSPAD = 20,
        [StringValue("RSPAK")]
        [EnumMember]
        RSPAK = 21,
        [StringValue("RSPOR")]
        [EnumMember]
        RSPOR = 22,
        [StringValue("RSPFAR")]
        [EnumMember]
        RSPFAR = 23,
        [StringValue("RSPSAR")]
        [EnumMember]
        RSPSAR = 24,
        [StringValue("RSPSSEC")]
        [EnumMember]
        RSPSSEC = 25,
        [StringValue("RSPESEC")]
        [EnumMember]
        RSPESEC = 26,
        [StringValue("RSPSSWE")]
        [EnumMember]
        RSPSSWE = 27,
        [StringValue("RSPESWE")]
        [EnumMember]
        RSPESWE = 28,
        [StringValue("RSPSREP")]
        [EnumMember]
        RSPSREP = 29,
        [StringValue("RSPEREP")]
        [EnumMember]
        RSPEREP = 30,
        [StringValue("RSPFIN")]
        [EnumMember]
        RSPFIN = 31,
        [StringValue("CA")]
        [EnumMember]
        CA = 9
    }

    public enum RequestSupportStatus : int
    {
        Requested = 1017,
        OnRoute = 1018,
        Arrived = 1019
    }

    public enum PersonInvolvement : int
    {
        IncidentCaller = 1,
        Commenter = 2,
        Dispatcher = 3,
        TrafficExpert = 4,
    }

    public enum OrganizationInvolvement : int
    {
        SupportRequest = 3,
    }

    public enum ActivityRelationType : int
    {
        PatrolsSupportRequestToIncident = 1007,
        SupportToIncident = 3,
        DeviceInspectionToCorrect = 2007,
        DeviceInspectionToFaulty = 2008
    }

    public enum ActivityRelationCategory : int
    {
        SupportRequestToIncident = 2,
        DeviceInspectionToCorrect = 3,
        DeviceInspectionToFaulty = 4,
        RequestMissionToAcceptMission = 20,
        AcceptToFinishMission = 22,
        AcceptToCancelMission = 23,
    }

    public enum ItemInvolvementCategory : int
    {
        Owner = 1,
        Support = 2,
        Mission = 5,
    }

    public enum ActivityStatusEnum
    {
        [StringValue("Saved_123")]
        Ringing = 1,
        [StringValue("Canceled")]
        CallReceived = 2,
        [StringValue("Created Incident")]
        IncidentOpened = 3,
        [StringValue("Identified Location")]
        LocationIdentified = 4,
        [StringValue("Save Incident")]
        SaveIncident = 5,
        [StringValue("Transfer Incident")]
        TransferDispatcher = 6,
        [StringValue("On Road")]
        DispatcherRecievedIncident = 7,
        [StringValue("On Scene")]
        AssignResource = 8,
        [StringValue("AS")]
        ArriveAtScene = 9,
        [StringValue("LS")]
        LeftTheScene = 10,
        [StringValue("Closed Incident")]
        Closed = 11,
        [StringValue("Dispose Incident")]
        Canceled = 12,
        [StringValue("SRC")]
        SupportRequestCreated = 1013,
        [StringValue("SRLS")]
        SupportRequestLeftTheScene = 1014,
        [StringValue("SROW")]
        OnTheWay = 1015,
        [StringValue("SRAR")]
        Arrive = 1016,
        [StringValue("PRS")]
        Requested = 1017,
        [StringValue("PRS")]
        Arrived = 1019,
        [StringValue("OR")]
        OnRoute = 2017,
        [StringValue("AR1")]
        PatrolArrival1 = 2018,
        [StringValue("AR2")]
        PatrolArrival2 = 2019,
        [StringValue("SARC")]
        StartArc = 2020,
        [StringValue("EARC")]
        EndArc = 2021,
        [StringValue("CL")]
        CloseRequest = 2022,
        [StringValue("DCKP")]
        DeviceCheckUp = 2023
    }

    public enum MissionStatus
    {
        Opened,
        Canceled,
        Finished
    }

    public enum DispatcherIncidentStatusEnum : int
    {
        TransferIncident = 6,
        DispatcherRecievedIncident = 11,
        AssignResource = 12,
        ArriveAtScene = 13,
        LeftTheScene = 14,
        Closed = 15,
        ArriveAtScene2 = 16,
        EndARC = 17,
    }

    public enum ReportStatus
    {
        [Description("فعال")]
        AC = 1,
        [Description("مبدئي (كروكي)")]
        DAC = 2
    }

    public enum ReportType
    {
        [Description("Simple Accident Without Injuries")]
        SAWI = 2,
        [Description("Against Unknown")]
        AU = 3,
    }

    public class StringValueAttribute : System.Attribute
    {
        private string _value;

        public StringValueAttribute(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }
    }


  
    public enum ReportChannelIdEnum
    {
        WHATSAPP = 1,
        SMS = 2,
        SAAEDWEBSITE = 3,
        SAAEDMOBILE = 4,
        Remenderservice = 5,
    }
    public enum ElectronicReportInspectionStatus
    {
        [Description("قيد الانشاء")]
        Pending = 1,
        [Description("يحتوي على أضرار– قيد الاجراء")]
        WithDamages = 2,
        [Description("لا يحتوي على اضرار")]
        WithoutDamages = 3,
        [Description("يحتوي على أضرار – مغلق")]
        Closed = 4
    }

    public enum ElectronicInspectionPatrolAttendanceStatus
    {
        [Description("دخول")]
        CheckedIn = 1,
        [Description("خروج")]
        CheckedOut = 2
    }



    public enum ElectronicReportInspectionQuestions
    {
        OilLevel = 1,
        InternalCleanliness = 2,
        DistanceToChangeOil = 3,
        ExternalCleanliness = 4,
        ExternalDamages = 5,
        InternalDamages = 6,
        GeneralDamages = 7,
        BelowPatrolDamage = 8,
        CommunicationMachineExistance = 9,
        CommunicationMachineWork = 10,
        CommunicationMachineCharger = 11,
        Computer = 12,
        ComputerChager = 13,
        Printer = 14,
        Lawah = 15,
        LawahCleanliness = 16,
        AlWanan = 17,
        Camera = 18,
        CameraCaple = 19,
        PatrolInstrument = 20

    }

    public enum ElectronicReportInspectionAnswerStatus
    {
        [Description("تم تسجيل العطل")]
        Pending = 1,
        [Description("تم ارساله للصيانة")]
        SentToMaintenance = 2,
        [Description("تحويل إلى تقنية المعلومات")]
        SentToHelpDesk = 3,
        [Description("إرسال إلى مجموعة بريدية")]
        SentToEmailGroup = 4,
        [Description("مغلق")]
        Closed = 5,
        [Description(" لم يتم التعامل من الصيانة")]
        NotDealFromMaintenance = 6,
        [Description("تم إنشاء بلاغ وقيد التعامل")]
        ReportRecordedAtMaintenance = 7,
        [Description("تم حل المشكلة")]
        ProblemWasResolvedatMaintenance = 8,
        [Description("لا يمكن حل المشكلة")]
        ProblemCanNotResolvedatMaintenance = 9
    }

   
    public enum PlateCatergory : int
    {
        MotorNumber = 1,
        ChassisNo = 2,
    }
    public enum DocumentCategory : int
    {
        NationalID = 1
    }
    public enum ImageCategory : int
    {
        PersonalPhoto = 1
    }
    public enum ContactCategory : int
    {
        Mobile1 = 1,
        Mobile2 = 2
    }
    public enum Source : int
    {
        ICCC = 3
    }
    public enum PersonContactInvolvment : int
    {
        PersonContacts = 1
    }
    public enum DocumentInvolvemnt : int
    {
        PatrolLicenseNo = 1,
        StaffID = 2
    }
    public enum ImageInvolvment : int
    {
        PersonalPhoto = 1
    }

    //public enum OrganizationCategory : int
    //{
    //    Dispatcher = 2,
    //    ControlCenter = 1008,
    //    Role = 1006,
    //    Departments = 1007
    //}

    public enum AreaCategory : int
    {
        Emirate = 1,
        Area = 2,
        Landmark = 3,
        Sector = 4,
        Street = 9,
    }
    public enum OrganizationPersonnalCategory : int
    {
        OrganizationPersonnalCategory = 1,
    }

    public enum PersonInvolvment : int
    {
        IncidentCaller = 1,
        Commenter = 2,
        Dispatcher = 3,
        User = 4
    }
    public enum Applications : int
    {
        ICCC = 1
    }
    public enum AccessType : int
    {
        FullControl = 1,
        ViewOnly = 2,
        Custom = 3
    }
    public enum ItemInvolvment : int
    {
        Owner = 1,
    }
    public enum DismissTypeEnum : int
    {
        FinalDismiss = 0,
        TempDismiss = 1
    }

    public enum EnumSessionKey
    {
        SubId,//Don't use it and instead use the function Get Sub Id in Utilities class
        UserName,
        Language,
        userinfo,
        LoggedPersonId,
        IsPoliceLogin,
        IsInspectionLogin,
        UserToken,
        CsrfToken
    }

    public enum EnumLanguage
    {
        [Description("en-US")]
        English,
        [Description("ar-EG")]
        Arabic
    }

    public enum OrganizationItemDispatcher : int
    {
        Accident = 4,
        RoadServiceSupport = 6,
        SheikhZayedTunnel = 7,
        Escorts = 8
    }
    public enum Roles : int
    {
        CR = 0, // filter the employee to roles مشرف العمليات,  متلقى بلاغات ,قائد منصة 
        TE = 1, // filter the employee to roles خبير سير 
        TS = 2  // filter the employee to roles الدعم الفنى
    }

    public enum PaymentRequestTypes
    {
        traffic_accident_report = 4,
        lost_accident_report = 7,
        repair_permission = 13,
        simple_accident_planning_500 = 8,
        simple_accident_planning_400 = 9,
        escort = 10,
        Direct_Payment_400 = 11,
        Direct_Payment_500 = 12
    }

    public enum ReportsReuploadReasons
    {
        UnknownToSimple = 1,
        SimpleToUnknown = 2,
        Other = 10
    }

    public enum ObjectionRequestType
    {
        DisputeToAccidentReport = 1,
        ModifyAccidentReport = 2,
        ExemptionOfAccidentFees = 3,
        RenewAccidentReport = 4,
        Clearance = 5,
        RefundOfAccidentReportFees = 6,
        PrintLostAccidentReport = 7,
        ReportUnknownAccident = 8,
        VehicleRepairPermission = 9,
    }

    public enum ObjectionStatus
    {
        [Description("جديدة")]
        NEW = 1,

        [Description("تحت الاجراء")]
        INPROGREES = 2,

        [Description("منتهية")]
        REJECTED = 3,

        [Description("تم قبول الطلب")]
        ACCEPTED = 4,

        [Description("تم تحويل الطلب للمركز")]
        CONVERTTOCENTER = 5,

        [Description("مرجع إلى العميل")]
        ReturnedToClient = 6,

        [Description("مرجع من العميل")]
        ReturnedFromClient = 7
    }

    public enum ObjectionResult
    {
        ACCEPTED = 1,
        REJECTED = 2,
        RetutnToClient = 3,
        ReturnFromClient = 4
    }

    public enum PaymentStatus
    {
        Initiated = 1,
        Accepted = 2,
        Rejected = 3,
    }
} 