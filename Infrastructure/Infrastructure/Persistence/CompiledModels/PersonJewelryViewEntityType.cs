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
    public partial class PersonJewelryViewEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.PersonJewelryView",
                typeof(PersonJewelryView),
                baseEntityType,
                propertyCount: 48);

            var createDateTimeStamp = runtimeEntityType.AddProperty(
                "CreateDateTimeStamp",
                typeof(DateTime),
                propertyInfo: typeof(PersonJewelryView).GetProperty("CreateDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<CreateDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            createDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            createDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 255);
            description.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var heightMeasure = runtimeEntityType.AddProperty(
                "HeightMeasure",
                typeof(double?),
                propertyInfo: typeof(PersonJewelryView).GetProperty("HeightMeasure", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<HeightMeasure>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            heightMeasure.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool?),
                propertyInfo: typeof(PersonJewelryView).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemCategoryCode = runtimeEntityType.AddProperty(
                "ItemCategoryCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemCategoryCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemCategoryCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemCategoryCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemCategoryDescription = runtimeEntityType.AddProperty(
                "ItemCategoryDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemCategoryDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemCategoryDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemCategoryDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemConditionCode = runtimeEntityType.AddProperty(
                "ItemConditionCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemConditionCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemConditionCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemConditionCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemConditionDescription = runtimeEntityType.AddProperty(
                "ItemConditionDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemConditionDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemConditionDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemConditionDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemId = runtimeEntityType.AddProperty(
                "ItemId",
                typeof(long),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            itemId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemInvolvementCode = runtimeEntityType.AddProperty(
                "ItemInvolvementCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemInvolvementCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemInvolvementCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemInvolvementCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemInvolvementDescription = runtimeEntityType.AddProperty(
                "ItemInvolvementDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemInvolvementDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemInvolvementDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemInvolvementDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemMakeModelCode = runtimeEntityType.AddProperty(
                "ItemMakeModelCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemMakeModelCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemMakeModelCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            itemMakeModelCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemMakeModelMake = runtimeEntityType.AddProperty(
                "ItemMakeModelMake",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemMakeModelMake", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemMakeModelMake>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            itemMakeModelMake.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemMakeModelModel = runtimeEntityType.AddProperty(
                "ItemMakeModelModel",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemMakeModelModel", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemMakeModelModel>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            itemMakeModelModel.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemName = runtimeEntityType.AddProperty(
                "ItemName",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            itemName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemPrimaryColorCode = runtimeEntityType.AddProperty(
                "ItemPrimaryColorCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemPrimaryColorCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemPrimaryColorCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemPrimaryColorCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemPrimaryColorDescription = runtimeEntityType.AddProperty(
                "ItemPrimaryColorDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemPrimaryColorDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemPrimaryColorDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemPrimaryColorDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemSecondaryColorCode = runtimeEntityType.AddProperty(
                "ItemSecondaryColorCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemSecondaryColorCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemSecondaryColorCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemSecondaryColorCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemSecondaryColorDescription = runtimeEntityType.AddProperty(
                "ItemSecondaryColorDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemSecondaryColorDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemSecondaryColorDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemSecondaryColorDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemStatusCode = runtimeEntityType.AddProperty(
                "ItemStatusCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemStatusDescription = runtimeEntityType.AddProperty(
                "ItemStatusDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemStatusDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemStatusDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemStatusDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemUsageCode = runtimeEntityType.AddProperty(
                "ItemUsageCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemUsageCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemUsageCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemUsageCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemUsageDescription = runtimeEntityType.AddProperty(
                "ItemUsageDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemUsageDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemUsageDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemUsageDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemValue = runtimeEntityType.AddProperty(
                "ItemValue",
                typeof(double?),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ItemValue", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ItemValue>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            itemValue.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var jewelryCaratCode = runtimeEntityType.AddProperty(
                "JewelryCaratCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("JewelryCaratCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<JewelryCaratCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            jewelryCaratCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var jewelryCaratDescription = runtimeEntityType.AddProperty(
                "JewelryCaratDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("JewelryCaratDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<JewelryCaratDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            jewelryCaratDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var jewelryCategoryCode = runtimeEntityType.AddProperty(
                "JewelryCategoryCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("JewelryCategoryCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<JewelryCategoryCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            jewelryCategoryCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var jewelryCategoryDescription = runtimeEntityType.AddProperty(
                "JewelryCategoryDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("JewelryCategoryDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<JewelryCategoryDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            jewelryCategoryDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var jewelryGenderCode = runtimeEntityType.AddProperty(
                "JewelryGenderCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("JewelryGenderCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<JewelryGenderCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            jewelryGenderCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var jewelryGenderDescription = runtimeEntityType.AddProperty(
                "JewelryGenderDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("JewelryGenderDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<JewelryGenderDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            jewelryGenderDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var jewelryMetalTypeCode = runtimeEntityType.AddProperty(
                "JewelryMetalTypeCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("JewelryMetalTypeCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<JewelryMetalTypeCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            jewelryMetalTypeCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var jewelryMetalTypeDescription = runtimeEntityType.AddProperty(
                "JewelryMetalTypeDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("JewelryMetalTypeDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<JewelryMetalTypeDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            jewelryMetalTypeDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var jewelryStyleCode = runtimeEntityType.AddProperty(
                "JewelryStyleCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("JewelryStyleCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<JewelryStyleCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            jewelryStyleCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var jewelryStyleDescription = runtimeEntityType.AddProperty(
                "JewelryStyleDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("JewelryStyleDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<JewelryStyleDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            jewelryStyleDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lengthMeasure = runtimeEntityType.AddProperty(
                "LengthMeasure",
                typeof(double?),
                propertyInfo: typeof(PersonJewelryView).GetProperty("LengthMeasure", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<LengthMeasure>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lengthMeasure.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modelYear = runtimeEntityType.AddProperty(
                "ModelYear",
                typeof(int?),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ModelYear", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ModelYear>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modelYear.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedDateTimeStamp = runtimeEntityType.AddProperty(
                "ModifiedDateTimeStamp",
                typeof(DateTime),
                propertyInfo: typeof(PersonJewelryView).GetProperty("ModifiedDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<ModifiedDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            modifiedDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            modifiedDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var originalIdent = runtimeEntityType.AddProperty(
                "OriginalIdent",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("OriginalIdent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<OriginalIdent>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            originalIdent.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personId = runtimeEntityType.AddProperty(
                "PersonId",
                typeof(long),
                propertyInfo: typeof(PersonJewelryView).GetProperty("PersonId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<PersonId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            personId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personItemDescription = runtimeEntityType.AddProperty(
                "PersonItemDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("PersonItemDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<PersonItemDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 300);
            personItemDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personItemId = runtimeEntityType.AddProperty(
                "PersonItemId",
                typeof(long),
                propertyInfo: typeof(PersonJewelryView).GetProperty("PersonItemId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<PersonItemId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            personItemId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusCode = runtimeEntityType.AddProperty(
                "RowStatusCode",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("RowStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<RowStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            rowStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusDescription = runtimeEntityType.AddProperty(
                "RowStatusDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("RowStatusDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<RowStatusDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            rowStatusDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var serialIdentification = runtimeEntityType.AddProperty(
                "SerialIdentification",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("SerialIdentification", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<SerialIdentification>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            serialIdentification.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sizeDescription = runtimeEntityType.AddProperty(
                "SizeDescription",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("SizeDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<SizeDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            sizeDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceName = runtimeEntityType.AddProperty(
                "SourceName",
                typeof(string),
                propertyInfo: typeof(PersonJewelryView).GetProperty("SourceName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<SourceName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            sourceName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var weightMeasure = runtimeEntityType.AddProperty(
                "WeightMeasure",
                typeof(double?),
                propertyInfo: typeof(PersonJewelryView).GetProperty("WeightMeasure", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<WeightMeasure>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            weightMeasure.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var widthMeasure = runtimeEntityType.AddProperty(
                "WidthMeasure",
                typeof(double?),
                propertyInfo: typeof(PersonJewelryView).GetProperty("WidthMeasure", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonJewelryView).GetField("<WidthMeasure>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            widthMeasure.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "PersonJewelryView");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
