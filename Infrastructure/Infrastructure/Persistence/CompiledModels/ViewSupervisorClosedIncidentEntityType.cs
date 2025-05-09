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
    public partial class ViewSupervisorClosedIncidentEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.ViewSupervisorClosedIncident",
                typeof(ViewSupervisorClosedIncident),
                baseEntityType,
                propertyCount: 16);

            var activityStartDate = runtimeEntityType.AddProperty(
                "ActivityStartDate",
                typeof(DateTime?),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("ActivityStartDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<ActivityStartDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            activityStartDate.AddAnnotation("Relational:ColumnType", "datetime");
            activityStartDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var adpDate = runtimeEntityType.AddProperty(
                "AdpDate",
                typeof(DateTime?),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("AdpDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<AdpDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            adpDate.AddAnnotation("Relational:ColumnType", "datetime");
            adpDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var areaId = runtimeEntityType.AddProperty(
                "AreaId",
                typeof(long),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("AreaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<AreaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            areaId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentDateTime = runtimeEntityType.AddProperty(
                "IncidentDateTime",
                typeof(DateTime?),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("IncidentDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<IncidentDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            incidentDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentDesription = runtimeEntityType.AddProperty(
                "IncidentDesription",
                typeof(string),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("IncidentDesription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<IncidentDesription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentDesription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentGeneratedNumber = runtimeEntityType.AddProperty(
                "IncidentGeneratedNumber",
                typeof(string),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("IncidentGeneratedNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<IncidentGeneratedNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            incidentGeneratedNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentId = runtimeEntityType.AddProperty(
                "IncidentId",
                typeof(long),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("IncidentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<IncidentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            incidentId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentPrioirtyId = runtimeEntityType.AddProperty(
                "IncidentPrioirtyId",
                typeof(int?),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("IncidentPrioirtyId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<IncidentPrioirtyId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentPrioirtyId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentStatusCode = runtimeEntityType.AddProperty(
                "IncidentStatusCode",
                typeof(string),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("IncidentStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<IncidentStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            incidentStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentStatusId = runtimeEntityType.AddProperty(
                "IncidentStatusId",
                typeof(int),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("IncidentStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<IncidentStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            incidentStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentType = runtimeEntityType.AddProperty(
                "IncidentType",
                typeof(string),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("IncidentType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<IncidentType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            incidentType.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isCompleted = runtimeEntityType.AddProperty(
                "IsCompleted",
                typeof(bool?),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("IsCompleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<IsCompleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isCompleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var ringingTime = runtimeEntityType.AddProperty(
                "RingingTime",
                typeof(DateTime?),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("RingingTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<RingingTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            ringingTime.AddAnnotation("Relational:ColumnType", "datetime");
            ringingTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var serviceCallIncidentTypeId = runtimeEntityType.AddProperty(
                "ServiceCallIncidentTypeId",
                typeof(int?),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("ServiceCallIncidentTypeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<ServiceCallIncidentTypeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            serviceCallIncidentTypeId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceId = runtimeEntityType.AddProperty(
                "SourceId",
                typeof(long),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("SourceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<SourceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            sourceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var telephoneCall = runtimeEntityType.AddProperty(
                "TelephoneCall",
                typeof(long),
                propertyInfo: typeof(ViewSupervisorClosedIncident).GetProperty("TelephoneCall", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewSupervisorClosedIncident).GetField("<TelephoneCall>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            telephoneCall.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "ViewSupervisorClosedIncident");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
