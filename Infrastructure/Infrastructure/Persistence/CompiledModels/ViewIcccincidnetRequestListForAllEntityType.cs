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
    public partial class ViewIcccincidnetRequestListForAllEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.ViewIcccincidnetRequestListForAll",
                typeof(ViewIcccincidnetRequestListForAll),
                baseEntityType,
                propertyCount: 26);

            var address = runtimeEntityType.AddProperty(
                "Address",
                typeof(string),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("Address", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<Address>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            address.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var area = runtimeEntityType.AddProperty(
                "Area",
                typeof(long),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("Area", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<Area>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            area.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callerName = runtimeEntityType.AddProperty(
                "CallerName",
                typeof(string),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("CallerName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<CallerName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 100);
            callerName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callerNumber = runtimeEntityType.AddProperty(
                "CallerNumber",
                typeof(string),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("CallerNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<CallerNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 250);
            callerNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var comment = runtimeEntityType.AddProperty(
                "Comment",
                typeof(string),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("Comment", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<Comment>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            comment.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var controlCenterId = runtimeEntityType.AddProperty(
                "ControlCenterId",
                typeof(long?),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("ControlCenterId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<ControlCenterId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            controlCenterId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            description.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var dispatcherId = runtimeEntityType.AddProperty(
                "DispatcherId",
                typeof(long?),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("DispatcherId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<DispatcherId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            dispatcherId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emirate = runtimeEntityType.AddProperty(
                "Emirate",
                typeof(long),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("Emirate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<Emirate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            emirate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var firstName = runtimeEntityType.AddProperty(
                "FirstName",
                typeof(string),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("FirstName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<FirstName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            firstName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var icccincidentNumber = runtimeEntityType.AddProperty(
                "IcccincidentNumber",
                typeof(string),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("IcccincidentNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<IcccincidentNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50);
            icccincidentNumber.AddAnnotation("Relational:ColumnName", "ICCCIncidentNumber");
            icccincidentNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var icccincidentRequestInfoId = runtimeEntityType.AddProperty(
                "IcccincidentRequestInfoId",
                typeof(long),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("IcccincidentRequestInfoId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<IcccincidentRequestInfoId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            icccincidentRequestInfoId.AddAnnotation("Relational:ColumnName", "ICCCIncidentRequestInfoID");
            icccincidentRequestInfoId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var icccservice = runtimeEntityType.AddProperty(
                "Icccservice",
                typeof(int),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("Icccservice", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<Icccservice>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            icccservice.AddAnnotation("Relational:ColumnName", "ICCCService");
            icccservice.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(long),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentGeneratedNumber = runtimeEntityType.AddProperty(
                "IncidentGeneratedNumber",
                typeof(string),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("IncidentGeneratedNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<IncidentGeneratedNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            incidentGeneratedNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentPriorityId = runtimeEntityType.AddProperty(
                "IncidentPriorityId",
                typeof(int),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("IncidentPriorityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<IncidentPriorityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            incidentPriorityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentType = runtimeEntityType.AddProperty(
                "IncidentType",
                typeof(string),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("IncidentType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<IncidentType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 200);
            incidentType.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isAml = runtimeEntityType.AddProperty(
                "IsAml",
                typeof(bool?),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("IsAml", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<IsAml>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isAml.AddAnnotation("Relational:ColumnName", "isAml");
            isAml.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isValid = runtimeEntityType.AddProperty(
                "IsValid",
                typeof(bool),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("IsValid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<IsValid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isValid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var latitude = runtimeEntityType.AddProperty(
                "Latitude",
                typeof(double?),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("Latitude", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<Latitude>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            latitude.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var longitude = runtimeEntityType.AddProperty(
                "Longitude",
                typeof(double?),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("Longitude", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<Longitude>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            longitude.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var receivedBy = runtimeEntityType.AddProperty(
                "ReceivedBy",
                typeof(long?),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("ReceivedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<ReceivedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            receivedBy.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestDateTime = runtimeEntityType.AddProperty(
                "RequestDateTime",
                typeof(DateTime),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("RequestDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<RequestDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            requestDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            requestDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestStatus = runtimeEntityType.AddProperty(
                "RequestStatus",
                typeof(int),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("RequestStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<RequestStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            requestStatus.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var saaedAreaId = runtimeEntityType.AddProperty(
                "SaaedAreaId",
                typeof(long?),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("SaaedAreaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<SaaedAreaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            saaedAreaId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceOperationRoomId = runtimeEntityType.AddProperty(
                "SourceOperationRoomId",
                typeof(int),
                propertyInfo: typeof(ViewIcccincidnetRequestListForAll).GetProperty("SourceOperationRoomId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIcccincidnetRequestListForAll).GetField("<SourceOperationRoomId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            sourceOperationRoomId.AddAnnotation("Relational:ColumnName", "SourceOperationRoomID");
            sourceOperationRoomId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "ViewICCCIncidnetRequestListForAll");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
