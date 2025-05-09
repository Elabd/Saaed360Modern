﻿// <auto-generated />
using System;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Infrastructure.Persistence.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class VSaaedGetConsentIncidentListEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.VSaaedGetConsentIncidentList",
                typeof(VSaaedGetConsentIncidentList),
                baseEntityType,
                propertyCount: 21);

            var address = runtimeEntityType.AddProperty(
                "Address",
                typeof(string),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("Address", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<Address>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            address.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var adpdate = runtimeEntityType.AddProperty(
                "Adpdate",
                typeof(DateTime?),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("Adpdate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<Adpdate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            adpdate.AddAnnotation("Relational:ColumnName", "adpdate");
            adpdate.AddAnnotation("Relational:ColumnType", "datetime");
            adpdate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var adpnumber = runtimeEntityType.AddProperty(
                "Adpnumber",
                typeof(string),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("Adpnumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<Adpnumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 255);
            adpnumber.AddAnnotation("Relational:ColumnName", "adpnumber");
            adpnumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var area = runtimeEntityType.AddProperty(
                "Area",
                typeof(string),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("Area", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<Area>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            area.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var areaId = runtimeEntityType.AddProperty(
                "AreaId",
                typeof(long),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("AreaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<AreaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            areaId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callTakerId = runtimeEntityType.AddProperty(
                "CallTakerId",
                typeof(long?),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("CallTakerId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<CallTakerId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            callTakerId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callerName = runtimeEntityType.AddProperty(
                "CallerName",
                typeof(string),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("CallerName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<CallerName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 152);
            callerName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callerNumber = runtimeEntityType.AddProperty(
                "CallerNumber",
                typeof(string),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("CallerNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<CallerNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            callerNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callerTakerName = runtimeEntityType.AddProperty(
                "CallerTakerName",
                typeof(string),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("CallerTakerName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<CallerTakerName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 152);
            callerTakerName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var compromiseId = runtimeEntityType.AddProperty(
                "CompromiseId",
                typeof(long),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("CompromiseId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<CompromiseId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            compromiseId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var compromiseNumber = runtimeEntityType.AddProperty(
                "CompromiseNumber",
                typeof(string),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("CompromiseNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<CompromiseNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            compromiseNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var controlCenterId = runtimeEntityType.AddProperty(
                "ControlCenterId",
                typeof(long),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("ControlCenterId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<ControlCenterId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            controlCenterId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var controlCenterName = runtimeEntityType.AddProperty(
                "ControlCenterName",
                typeof(string),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("ControlCenterName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<ControlCenterName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 250);
            controlCenterName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emirate = runtimeEntityType.AddProperty(
                "Emirate",
                typeof(string),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("Emirate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<Emirate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            emirate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emirateId = runtimeEntityType.AddProperty(
                "EmirateId",
                typeof(long?),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("EmirateId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<EmirateId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            emirateId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentDate = runtimeEntityType.AddProperty(
                "IncidentDate",
                typeof(DateTime?),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("IncidentDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<IncidentDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentDate.AddAnnotation("Relational:ColumnType", "datetime");
            incidentDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentDescription = runtimeEntityType.AddProperty(
                "IncidentDescription",
                typeof(string),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("IncidentDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<IncidentDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentId = runtimeEntityType.AddProperty(
                "IncidentId",
                typeof(long?),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("IncidentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<IncidentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentNumber = runtimeEntityType.AddProperty(
                "IncidentNumber",
                typeof(string),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("IncidentNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<IncidentNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            incidentNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceid = runtimeEntityType.AddProperty(
                "Sourceid",
                typeof(long?),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("Sourceid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<Sourceid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            sourceid.AddAnnotation("Relational:ColumnName", "sourceid");
            sourceid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourcename = runtimeEntityType.AddProperty(
                "Sourcename",
                typeof(string),
                propertyInfo: typeof(VSaaedGetConsentIncidentList).GetProperty("Sourcename", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VSaaedGetConsentIncidentList).GetField("<Sourcename>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            sourcename.AddAnnotation("Relational:ColumnName", "sourcename");
            sourcename.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "V_SaaedGetConsentIncidentList");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
