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
    public partial class TfaenqueryLogEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.TfaenqueryLog",
                typeof(TfaenqueryLog),
                baseEntityType,
                propertyCount: 13,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(long),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var enqueryDateTime = runtimeEntityType.AddProperty(
                "EnqueryDateTime",
                typeof(DateTime),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("EnqueryDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<EnqueryDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            enqueryDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            enqueryDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var errorMsg = runtimeEntityType.AddProperty(
                "ErrorMsg",
                typeof(string),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("ErrorMsg", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<ErrorMsg>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            errorMsg.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isFound = runtimeEntityType.AddProperty(
                "IsFound",
                typeof(bool),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("IsFound", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<IsFound>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isFound.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var ownerAddress = runtimeEntityType.AddProperty(
                "OwnerAddress",
                typeof(string),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("OwnerAddress", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<OwnerAddress>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            ownerAddress.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var ownerName = runtimeEntityType.AddProperty(
                "OwnerName",
                typeof(string),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("OwnerName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<OwnerName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            ownerName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var plateColorId = runtimeEntityType.AddProperty(
                "PlateColorId",
                typeof(long),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("PlateColorId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<PlateColorId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            plateColorId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var plateKindId = runtimeEntityType.AddProperty(
                "PlateKindId",
                typeof(long),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("PlateKindId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<PlateKindId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            plateKindId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var plateNo = runtimeEntityType.AddProperty(
                "PlateNo",
                typeof(string),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("PlateNo", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<PlateNo>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50);
            plateNo.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var plateSourceId = runtimeEntityType.AddProperty(
                "PlateSourceId",
                typeof(long),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("PlateSourceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<PlateSourceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            plateSourceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var plateTypeId = runtimeEntityType.AddProperty(
                "PlateTypeId",
                typeof(long),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("PlateTypeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<PlateTypeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            plateTypeId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vehicleCategoryId = runtimeEntityType.AddProperty(
                "VehicleCategoryId",
                typeof(long?),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("VehicleCategoryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<VehicleCategoryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            vehicleCategoryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vehicleChassisNumber = runtimeEntityType.AddProperty(
                "VehicleChassisNumber",
                typeof(string),
                propertyInfo: typeof(TfaenqueryLog).GetProperty("VehicleChassisNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TfaenqueryLog).GetField("<VehicleChassisNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            vehicleChassisNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "TFAEnqueryLog");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
