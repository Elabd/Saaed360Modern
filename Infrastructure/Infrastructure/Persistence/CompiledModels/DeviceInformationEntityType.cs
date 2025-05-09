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
    public partial class DeviceInformationEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.DeviceInformation",
                typeof(DeviceInformation),
                baseEntityType,
                propertyCount: 10,
                keyCount: 1);

            var deviceInfoId = runtimeEntityType.AddProperty(
                "DeviceInfoId",
                typeof(Guid),
                propertyInfo: typeof(DeviceInformation).GetProperty("DeviceInfoId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeviceInformation).GetField("<DeviceInfoId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            deviceInfoId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime),
                propertyInfo: typeof(DeviceInformation).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeviceInformation).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            creationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var currentSaaedversion = runtimeEntityType.AddProperty(
                "CurrentSaaedversion",
                typeof(string),
                propertyInfo: typeof(DeviceInformation).GetProperty("CurrentSaaedversion", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeviceInformation).GetField("<CurrentSaaedversion>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50);
            currentSaaedversion.AddAnnotation("Relational:ColumnName", "CurrentSAAEDVersion");
            currentSaaedversion.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var deviceCode = runtimeEntityType.AddProperty(
                "DeviceCode",
                typeof(string),
                propertyInfo: typeof(DeviceInformation).GetProperty("DeviceCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeviceInformation).GetField("<DeviceCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 250);
            deviceCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var deviceName = runtimeEntityType.AddProperty(
                "DeviceName",
                typeof(string),
                propertyInfo: typeof(DeviceInformation).GetProperty("DeviceName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeviceInformation).GetField("<DeviceName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50);
            deviceName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var deviceType = runtimeEntityType.AddProperty(
                "DeviceType",
                typeof(int),
                propertyInfo: typeof(DeviceInformation).GetProperty("DeviceType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeviceInformation).GetField("<DeviceType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            deviceType.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModificationDate = runtimeEntityType.AddProperty(
                "LastModificationDate",
                typeof(DateTime?),
                propertyInfo: typeof(DeviceInformation).GetProperty("LastModificationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeviceInformation).GetField("<LastModificationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastModificationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModifiedByUserId = runtimeEntityType.AddProperty(
                "LastModifiedByUserId",
                typeof(Guid?),
                propertyInfo: typeof(DeviceInformation).GetProperty("LastModifiedByUserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeviceInformation).GetField("<LastModifiedByUserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastModifiedByUserId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var osversion = runtimeEntityType.AddProperty(
                "Osversion",
                typeof(string),
                propertyInfo: typeof(DeviceInformation).GetProperty("Osversion", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeviceInformation).GetField("<Osversion>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50);
            osversion.AddAnnotation("Relational:ColumnName", "OSVersion");
            osversion.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var userId = runtimeEntityType.AddProperty(
                "UserId",
                typeof(long),
                propertyInfo: typeof(DeviceInformation).GetProperty("UserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeviceInformation).GetField("<UserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            userId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { deviceInfoId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__DeviceIn__B757D1A715996809");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "DeviceInformation");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
