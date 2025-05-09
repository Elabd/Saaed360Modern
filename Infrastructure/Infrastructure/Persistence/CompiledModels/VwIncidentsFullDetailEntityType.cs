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
    public partial class VwIncidentsFullDetailEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.VwIncidentsFullDetail",
                typeof(VwIncidentsFullDetail),
                baseEntityType,
                propertyCount: 36);

            var area = runtimeEntityType.AddProperty(
                "Area",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("Area", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<Area>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            area.AddAnnotation("Relational:ColumnName", "AREA");
            area.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callTakerName = runtimeEntityType.AddProperty(
                "CallTakerName",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("CallTakerName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<CallTakerName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            callTakerName.AddAnnotation("Relational:ColumnName", "CALL TAKER NAME");
            callTakerName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var city = runtimeEntityType.AddProperty(
                "City",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("City", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<City>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            city.AddAnnotation("Relational:ColumnName", "CITY");
            city.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var closingComment = runtimeEntityType.AddProperty(
                "ClosingComment",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("ClosingComment", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<ClosingComment>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 2);
            closingComment.AddAnnotation("Relational:ColumnName", "CLOSING COMMENT");
            closingComment.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var closingEndDatetime = runtimeEntityType.AddProperty(
                "ClosingEndDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("ClosingEndDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<ClosingEndDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            closingEndDatetime.AddAnnotation("Relational:ColumnName", "CLOSING END DATETIME");
            closingEndDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            closingEndDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var closingReasons = runtimeEntityType.AddProperty(
                "ClosingReasons",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("ClosingReasons", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<ClosingReasons>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            closingReasons.AddAnnotation("Relational:ColumnName", "CLOSING REASONS");
            closingReasons.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var closingStartDatetime = runtimeEntityType.AddProperty(
                "ClosingStartDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("ClosingStartDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<ClosingStartDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            closingStartDatetime.AddAnnotation("Relational:ColumnName", "CLOSING START DATETIME");
            closingStartDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            closingStartDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            description.AddAnnotation("Relational:ColumnName", "DESCRIPTION");
            description.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var dispatcherName = runtimeEntityType.AddProperty(
                "DispatcherName",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("DispatcherName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<DispatcherName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            dispatcherName.AddAnnotation("Relational:ColumnName", "DISPATCHER NAME");
            dispatcherName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emi = runtimeEntityType.AddProperty(
                "Emi",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("Emi", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<Emi>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            emi.AddAnnotation("Relational:ColumnName", "EMI");
            emi.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var firstArrivalDatetime = runtimeEntityType.AddProperty(
                "FirstArrivalDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("FirstArrivalDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<FirstArrivalDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            firstArrivalDatetime.AddAnnotation("Relational:ColumnName", "FIRST ARRIVAL DATETIME");
            firstArrivalDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            firstArrivalDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var firstArrivalReasons = runtimeEntityType.AddProperty(
                "FirstArrivalReasons",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("FirstArrivalReasons", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<FirstArrivalReasons>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 1,
                unicode: false);
            firstArrivalReasons.AddAnnotation("Relational:ColumnName", "FIRST ARRIVAL REASONS");
            firstArrivalReasons.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var handOverDocumentsDatetime = runtimeEntityType.AddProperty(
                "HandOverDocumentsDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("HandOverDocumentsDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<HandOverDocumentsDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            handOverDocumentsDatetime.AddAnnotation("Relational:ColumnName", "HAND OVER DOCUMENTS DATETIME");
            handOverDocumentsDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            handOverDocumentsDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentAssignmentDatetime = runtimeEntityType.AddProperty(
                "IncidentAssignmentDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("IncidentAssignmentDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<IncidentAssignmentDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentAssignmentDatetime.AddAnnotation("Relational:ColumnName", "INCIDENT ASSIGNMENT DATETIME");
            incidentAssignmentDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            incidentAssignmentDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentDatetime = runtimeEntityType.AddProperty(
                "IncidentDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("IncidentDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<IncidentDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incidentDatetime.AddAnnotation("Relational:ColumnName", "INCIDENT DATETIME");
            incidentDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            incidentDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentMasterId = runtimeEntityType.AddProperty(
                "IncidentMasterId",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("IncidentMasterId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<IncidentMasterId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            incidentMasterId.AddAnnotation("Relational:ColumnName", "INCIDENT MASTER ID");
            incidentMasterId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentSourceDescription = runtimeEntityType.AddProperty(
                "IncidentSourceDescription",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("IncidentSourceDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<IncidentSourceDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            incidentSourceDescription.AddAnnotation("Relational:ColumnName", "INCIDENT SOURCE DESCRIPTION");
            incidentSourceDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentTypeDescription = runtimeEntityType.AddProperty(
                "IncidentTypeDescription",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("IncidentTypeDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<IncidentTypeDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            incidentTypeDescription.AddAnnotation("Relational:ColumnName", "INCIDENT TYPE DESCRIPTION");
            incidentTypeDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var latitude = runtimeEntityType.AddProperty(
                "Latitude",
                typeof(double?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("Latitude", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<Latitude>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            latitude.AddAnnotation("Relational:ColumnName", "LATITUDE");
            latitude.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var longitude = runtimeEntityType.AddProperty(
                "Longitude",
                typeof(double?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("Longitude", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<Longitude>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            longitude.AddAnnotation("Relational:ColumnName", "LONGITUDE");
            longitude.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var patrolCode = runtimeEntityType.AddProperty(
                "PatrolCode",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("PatrolCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<PatrolCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            patrolCode.AddAnnotation("Relational:ColumnName", "PATROL CODE");
            patrolCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var policeDatetime = runtimeEntityType.AddProperty(
                "PoliceDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("PoliceDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<PoliceDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            policeDatetime.AddAnnotation("Relational:ColumnName", "POLICE DATETIME");
            policeDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            policeDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var policeNo = runtimeEntityType.AddProperty(
                "PoliceNo",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("PoliceNo", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<PoliceNo>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 255);
            policeNo.AddAnnotation("Relational:ColumnName", "POLICE NO");
            policeNo.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var secondArrivalEndDatetime = runtimeEntityType.AddProperty(
                "SecondArrivalEndDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("SecondArrivalEndDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<SecondArrivalEndDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            secondArrivalEndDatetime.AddAnnotation("Relational:ColumnName", "SECOND ARRIVAL End DATETIME");
            secondArrivalEndDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            secondArrivalEndDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var secondArrivalReasons = runtimeEntityType.AddProperty(
                "SecondArrivalReasons",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("SecondArrivalReasons", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<SecondArrivalReasons>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 1,
                unicode: false);
            secondArrivalReasons.AddAnnotation("Relational:ColumnName", "SECOND ARRIVAL REASONS");
            secondArrivalReasons.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var secondArrivalStartDatetime = runtimeEntityType.AddProperty(
                "SecondArrivalStartDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("SecondArrivalStartDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<SecondArrivalStartDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            secondArrivalStartDatetime.AddAnnotation("Relational:ColumnName", "SECOND ARRIVAL START DATETIME");
            secondArrivalStartDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            secondArrivalStartDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var severityStatus = runtimeEntityType.AddProperty(
                "SeverityStatus",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("SeverityStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<SeverityStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            severityStatus.AddAnnotation("Relational:ColumnName", "SEVERITY STATUS");
            severityStatus.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sketchEndDatetime = runtimeEntityType.AddProperty(
                "SketchEndDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("SketchEndDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<SketchEndDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            sketchEndDatetime.AddAnnotation("Relational:ColumnName", "SKETCH End DATETIME");
            sketchEndDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            sketchEndDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sketchStartDatetime = runtimeEntityType.AddProperty(
                "SketchStartDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("SketchStartDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<SketchStartDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            sketchStartDatetime.AddAnnotation("Relational:ColumnName", "SKETCH START DATETIME");
            sketchStartDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            sketchStartDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sketchingReasons = runtimeEntityType.AddProperty(
                "SketchingReasons",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("SketchingReasons", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<SketchingReasons>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 1,
                unicode: false);
            sketchingReasons.AddAnnotation("Relational:ColumnName", "SKETCHING REASONS");
            sketchingReasons.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var trafficExpertName = runtimeEntityType.AddProperty(
                "TrafficExpertName",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("TrafficExpertName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<TrafficExpertName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            trafficExpertName.AddAnnotation("Relational:ColumnName", "TRAFFIC EXPERT NAME");
            trafficExpertName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var trafficExpertReceiveDatetime = runtimeEntityType.AddProperty(
                "TrafficExpertReceiveDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("TrafficExpertReceiveDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<TrafficExpertReceiveDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            trafficExpertReceiveDatetime.AddAnnotation("Relational:ColumnName", "TRAFFIC EXPERT RECEIVE DATETIME");
            trafficExpertReceiveDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            trafficExpertReceiveDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var transferToPoliceCenterDatetime = runtimeEntityType.AddProperty(
                "TransferToPoliceCenterDatetime",
                typeof(DateTime?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("TransferToPoliceCenterDatetime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<TransferToPoliceCenterDatetime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            transferToPoliceCenterDatetime.AddAnnotation("Relational:ColumnName", "TRANSFER TO POLICE CENTER DATETIME");
            transferToPoliceCenterDatetime.AddAnnotation("Relational:ColumnType", "datetime");
            transferToPoliceCenterDatetime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var transferToPoliceCenterReasons = runtimeEntityType.AddProperty(
                "TransferToPoliceCenterReasons",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("TransferToPoliceCenterReasons", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<TransferToPoliceCenterReasons>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            transferToPoliceCenterReasons.AddAnnotation("Relational:ColumnName", "TRANSFER TO POLICE CENTER REASONS");
            transferToPoliceCenterReasons.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var userFullName = runtimeEntityType.AddProperty(
                "UserFullName",
                typeof(string),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("UserFullName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<UserFullName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            userFullName.AddAnnotation("Relational:ColumnName", "USER FULL NAME");
            userFullName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var userId = runtimeEntityType.AddProperty(
                "UserId",
                typeof(long?),
                propertyInfo: typeof(VwIncidentsFullDetail).GetProperty("UserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VwIncidentsFullDetail).GetField("<UserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            userId.AddAnnotation("Relational:ColumnName", "USER ID");
            userId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "vw_IncidentsFullDetails");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
