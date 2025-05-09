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
    public partial class IcccincidentRequestInfoEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.IcccincidentRequestInfo",
                typeof(IcccincidentRequestInfo),
                baseEntityType,
                propertyCount: 14,
                navigationCount: 1,
                keyCount: 1);

            var icccincidentRequestInfoId = runtimeEntityType.AddProperty(
                "IcccincidentRequestInfoId",
                typeof(long),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("IcccincidentRequestInfoId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<IcccincidentRequestInfoId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            icccincidentRequestInfoId.AddAnnotation("Relational:ColumnName", "ICCCIncidentRequestInfoID");
            icccincidentRequestInfoId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var address = runtimeEntityType.AddProperty(
                "Address",
                typeof(string),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("Address", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<Address>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            address.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var area = runtimeEntityType.AddProperty(
                "Area",
                typeof(long),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("Area", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<Area>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            area.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callerName = runtimeEntityType.AddProperty(
                "CallerName",
                typeof(string),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("CallerName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<CallerName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 100);
            callerName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callerNumber = runtimeEntityType.AddProperty(
                "CallerNumber",
                typeof(string),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("CallerNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<CallerNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 250);
            callerNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            description.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emirate = runtimeEntityType.AddProperty(
                "Emirate",
                typeof(long),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("Emirate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<Emirate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            emirate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentPriorityId = runtimeEntityType.AddProperty(
                "IncidentPriorityId",
                typeof(int),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("IncidentPriorityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<IncidentPriorityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            incidentPriorityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentType = runtimeEntityType.AddProperty(
                "IncidentType",
                typeof(string),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("IncidentType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<IncidentType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 200);
            incidentType.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isAml = runtimeEntityType.AddProperty(
                "IsAml",
                typeof(bool?),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("IsAml", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<IsAml>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isAml.AddAnnotation("Relational:ColumnName", "isAml");
            isAml.AddAnnotation("Relational:DefaultValue", false);
            isAml.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDetectLocation = runtimeEntityType.AddProperty(
                "IsDetectLocation",
                typeof(bool?),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("IsDetectLocation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<IsDetectLocation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isDetectLocation.AddAnnotation("Relational:ColumnName", "isDetectLocation");
            isDetectLocation.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var latitude = runtimeEntityType.AddProperty(
                "Latitude",
                typeof(double?),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("Latitude", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<Latitude>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            latitude.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var longitude = runtimeEntityType.AddProperty(
                "Longitude",
                typeof(double?),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("Longitude", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<Longitude>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            longitude.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceOperationRoomId = runtimeEntityType.AddProperty(
                "SourceOperationRoomId",
                typeof(int),
                propertyInfo: typeof(IcccincidentRequestInfo).GetProperty("SourceOperationRoomId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccincidentRequestInfo).GetField("<SourceOperationRoomId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            sourceOperationRoomId.AddAnnotation("Relational:ColumnName", "SourceOperationRoomID");
            sourceOperationRoomId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { icccincidentRequestInfoId });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ICCCIncidentRequestInfo");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
