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
    public partial class MdtGetRspReportBasicDetailEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.MdtGetRspReportBasicDetail",
                typeof(MdtGetRspReportBasicDetail),
                baseEntityType,
                propertyCount: 18);

            var activityId = runtimeEntityType.AddProperty(
                "ActivityId",
                typeof(long?),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("ActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<ActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            activityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var affectedLanes = runtimeEntityType.AddProperty(
                "AffectedLanes",
                typeof(string),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("AffectedLanes", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<AffectedLanes>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 500,
                unicode: false);
            affectedLanes.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var comments = runtimeEntityType.AddProperty(
                "Comments",
                typeof(string),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("Comments", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<Comments>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 1000,
                unicode: false);
            comments.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var damagedLevelId = runtimeEntityType.AddProperty(
                "DamagedLevelId",
                typeof(long?),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("DamagedLevelId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<DamagedLevelId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            damagedLevelId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            description.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var eventTypes = runtimeEntityType.AddProperty(
                "EventTypes",
                typeof(string),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("EventTypes", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<EventTypes>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 500,
                unicode: false);
            eventTypes.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var fieldsFactors = runtimeEntityType.AddProperty(
                "FieldsFactors",
                typeof(string),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("FieldsFactors", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<FieldsFactors>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 500,
                unicode: false);
            fieldsFactors.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentLaneId = runtimeEntityType.AddProperty(
                "IncidentLaneId",
                typeof(long?),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("IncidentLaneId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<IncidentLaneId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentLaneId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentLattitude = runtimeEntityType.AddProperty(
                "IncidentLattitude",
                typeof(double?),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("IncidentLattitude", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<IncidentLattitude>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentLattitude.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentLongitude = runtimeEntityType.AddProperty(
                "IncidentLongitude",
                typeof(double?),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("IncidentLongitude", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<IncidentLongitude>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentLongitude.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentNumber = runtimeEntityType.AddProperty(
                "IncidentNumber",
                typeof(string),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("IncidentNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<IncidentNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            incidentNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentTime = runtimeEntityType.AddProperty(
                "IncidentTime",
                typeof(DateTime?),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("IncidentTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<IncidentTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentTime.AddAnnotation("Relational:ColumnType", "datetime");
            incidentTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var priority = runtimeEntityType.AddProperty(
                "Priority",
                typeof(string),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("Priority", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<Priority>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 20);
            priority.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportId = runtimeEntityType.AddProperty(
                "ReportId",
                typeof(int),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("ReportId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<ReportId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            reportId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportNumber = runtimeEntityType.AddProperty(
                "ReportNumber",
                typeof(string),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("ReportNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<ReportNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            reportNumber.AddAnnotation("Relational:ColumnName", "reportNumber");
            reportNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rspReportBasicDetailsId = runtimeEntityType.AddProperty(
                "RspReportBasicDetailsId",
                typeof(long),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("RspReportBasicDetailsId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<RspReportBasicDetailsId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            rspReportBasicDetailsId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceName = runtimeEntityType.AddProperty(
                "SourceName",
                typeof(string),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("SourceName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<SourceName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            sourceName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var trafficStatusId = runtimeEntityType.AddProperty(
                "TrafficStatusId",
                typeof(long?),
                propertyInfo: typeof(MdtGetRspReportBasicDetail).GetProperty("TrafficStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtGetRspReportBasicDetail).GetField("<TrafficStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            trafficStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "MdtGetRspReportBasicDetails");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
