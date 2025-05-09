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
    public partial class ActivityVehicleDatumEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.ActivityVehicleDatum",
                typeof(ActivityVehicleDatum),
                baseEntityType,
                propertyCount: 5,
                keyCount: 1);

            var activityVehicleDataId = runtimeEntityType.AddProperty(
                "ActivityVehicleDataId",
                typeof(int),
                propertyInfo: typeof(ActivityVehicleDatum).GetProperty("ActivityVehicleDataId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ActivityVehicleDatum).GetField("<ActivityVehicleDataId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            activityVehicleDataId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var activityId = runtimeEntityType.AddProperty(
                "ActivityId",
                typeof(long),
                propertyInfo: typeof(ActivityVehicleDatum).GetProperty("ActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ActivityVehicleDatum).GetField("<ActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            activityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime?),
                propertyInfo: typeof(ActivityVehicleDatum).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ActivityVehicleDatum).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDate.AddAnnotation("Relational:ColumnType", "datetime");
            creationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var timeStamp = runtimeEntityType.AddProperty(
                "TimeStamp",
                typeof(byte[]),
                propertyInfo: typeof(ActivityVehicleDatum).GetProperty("TimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ActivityVehicleDatum).GetField("<TimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                concurrencyToken: true,
                valueGenerated: ValueGenerated.OnAddOrUpdate,
                beforeSaveBehavior: PropertySaveBehavior.Ignore,
                afterSaveBehavior: PropertySaveBehavior.Ignore);
            timeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vehicleDataId = runtimeEntityType.AddProperty(
                "VehicleDataId",
                typeof(int),
                propertyInfo: typeof(ActivityVehicleDatum).GetProperty("VehicleDataId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ActivityVehicleDatum).GetField("<VehicleDataId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            vehicleDataId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { activityVehicleDataId });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ActivityVehicleData");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
