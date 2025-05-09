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
    public partial class Saaed360ViewIncidentSearchDetailEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.Saaed360ViewIncidentSearchDetail",
                typeof(Saaed360ViewIncidentSearchDetail),
                baseEntityType,
                propertyCount: 21);

            var area = runtimeEntityType.AddProperty(
                "Area",
                typeof(string),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("Area", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<Area>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            area.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var areaId = runtimeEntityType.AddProperty(
                "AreaId",
                typeof(long),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("AreaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<AreaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            areaId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callTakerId = runtimeEntityType.AddProperty(
                "CallTakerId",
                typeof(long),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("CallTakerId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<CallTakerId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            callTakerId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callerName = runtimeEntityType.AddProperty(
                "CallerName",
                typeof(string),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("CallerName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<CallerName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 152);
            callerName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callerNumber = runtimeEntityType.AddProperty(
                "CallerNumber",
                typeof(string),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("CallerNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<CallerNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 100);
            callerNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callerTakerName = runtimeEntityType.AddProperty(
                "CallerTakerName",
                typeof(string),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("CallerTakerName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<CallerTakerName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 152);
            callerTakerName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var controlCenterId = runtimeEntityType.AddProperty(
                "ControlCenterId",
                typeof(long),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("ControlCenterId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<ControlCenterId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            controlCenterId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var controlCenterName = runtimeEntityType.AddProperty(
                "ControlCenterName",
                typeof(string),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("ControlCenterName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<ControlCenterName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 250);
            controlCenterName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var dispatcherId = runtimeEntityType.AddProperty(
                "DispatcherId",
                typeof(long),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("DispatcherId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<DispatcherId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            dispatcherId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var dispatcherName = runtimeEntityType.AddProperty(
                "DispatcherName",
                typeof(string),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("DispatcherName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<DispatcherName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 152);
            dispatcherName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentCategoryId = runtimeEntityType.AddProperty(
                "IncidentCategoryId",
                typeof(long),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("IncidentCategoryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<IncidentCategoryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            incidentCategoryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentDate = runtimeEntityType.AddProperty(
                "IncidentDate",
                typeof(DateTime?),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("IncidentDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<IncidentDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentDate.AddAnnotation("Relational:ColumnType", "datetime");
            incidentDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentDescription = runtimeEntityType.AddProperty(
                "IncidentDescription",
                typeof(string),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("IncidentDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<IncidentDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentId = runtimeEntityType.AddProperty(
                "IncidentId",
                typeof(long),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("IncidentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<IncidentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            incidentId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentNumber = runtimeEntityType.AddProperty(
                "IncidentNumber",
                typeof(string),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("IncidentNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<IncidentNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            incidentNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentPriorityId = runtimeEntityType.AddProperty(
                "IncidentPriorityId",
                typeof(int?),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("IncidentPriorityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<IncidentPriorityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentPriorityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentTypeId = runtimeEntityType.AddProperty(
                "IncidentTypeId",
                typeof(int?),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("IncidentTypeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<IncidentTypeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentTypeId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportDate = runtimeEntityType.AddProperty(
                "ReportDate",
                typeof(DateTime?),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("ReportDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<ReportDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            reportDate.AddAnnotation("Relational:ColumnType", "datetime");
            reportDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportNumber = runtimeEntityType.AddProperty(
                "ReportNumber",
                typeof(string),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("ReportNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<ReportNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            reportNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var trafficExpertId = runtimeEntityType.AddProperty(
                "TrafficExpertId",
                typeof(long?),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("TrafficExpertId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<TrafficExpertId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            trafficExpertId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var trafficExpertName = runtimeEntityType.AddProperty(
                "TrafficExpertName",
                typeof(string),
                propertyInfo: typeof(Saaed360ViewIncidentSearchDetail).GetProperty("TrafficExpertName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Saaed360ViewIncidentSearchDetail).GetField("<TrafficExpertName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 152);
            trafficExpertName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "Saaed360ViewIncidentSearchDetail");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
