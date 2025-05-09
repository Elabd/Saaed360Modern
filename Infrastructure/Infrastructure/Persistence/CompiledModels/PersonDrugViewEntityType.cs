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
    public partial class PersonDrugViewEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.PersonDrugView",
                typeof(PersonDrugView),
                baseEntityType,
                propertyCount: 49);

            var createDateTimeStamp = runtimeEntityType.AddProperty(
                "CreateDateTimeStamp",
                typeof(DateTime),
                propertyInfo: typeof(PersonDrugView).GetProperty("CreateDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<CreateDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            createDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            createDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 255);
            description.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drugCategoryCode = runtimeEntityType.AddProperty(
                "DrugCategoryCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("DrugCategoryCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<DrugCategoryCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            drugCategoryCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drugCategoryDescription = runtimeEntityType.AddProperty(
                "DrugCategoryDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("DrugCategoryDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<DrugCategoryDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            drugCategoryDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drugCompositionCode = runtimeEntityType.AddProperty(
                "DrugCompositionCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("DrugCompositionCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<DrugCompositionCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            drugCompositionCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drugCompositionDescription = runtimeEntityType.AddProperty(
                "DrugCompositionDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("DrugCompositionDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<DrugCompositionDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            drugCompositionDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drugContainerCode = runtimeEntityType.AddProperty(
                "DrugContainerCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("DrugContainerCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<DrugContainerCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            drugContainerCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drugContainerDescription = runtimeEntityType.AddProperty(
                "DrugContainerDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("DrugContainerDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<DrugContainerDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            drugContainerDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drugFoundCode = runtimeEntityType.AddProperty(
                "DrugFoundCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("DrugFoundCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<DrugFoundCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            drugFoundCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drugFoundDescription = runtimeEntityType.AddProperty(
                "DrugFoundDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("DrugFoundDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<DrugFoundDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            drugFoundDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drugSubstanceFormCode = runtimeEntityType.AddProperty(
                "DrugSubstanceFormCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("DrugSubstanceFormCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<DrugSubstanceFormCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            drugSubstanceFormCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drugSubstanceFormDescription = runtimeEntityType.AddProperty(
                "DrugSubstanceFormDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("DrugSubstanceFormDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<DrugSubstanceFormDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            drugSubstanceFormDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var heightMeasure = runtimeEntityType.AddProperty(
                "HeightMeasure",
                typeof(double?),
                propertyInfo: typeof(PersonDrugView).GetProperty("HeightMeasure", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<HeightMeasure>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            heightMeasure.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool?),
                propertyInfo: typeof(PersonDrugView).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemCategoryCode = runtimeEntityType.AddProperty(
                "ItemCategoryCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemCategoryCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemCategoryCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemCategoryCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemCategoryDescription = runtimeEntityType.AddProperty(
                "ItemCategoryDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemCategoryDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemCategoryDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemCategoryDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemConditionCode = runtimeEntityType.AddProperty(
                "ItemConditionCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemConditionCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemConditionCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemConditionCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemConditionDescription = runtimeEntityType.AddProperty(
                "ItemConditionDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemConditionDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemConditionDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemConditionDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemId = runtimeEntityType.AddProperty(
                "ItemId",
                typeof(long),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            itemId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemInvolvementCode = runtimeEntityType.AddProperty(
                "ItemInvolvementCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemInvolvementCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemInvolvementCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemInvolvementCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemInvolvementDescription = runtimeEntityType.AddProperty(
                "ItemInvolvementDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemInvolvementDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemInvolvementDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemInvolvementDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemMakeModelCode = runtimeEntityType.AddProperty(
                "ItemMakeModelCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemMakeModelCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemMakeModelCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            itemMakeModelCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemMakeModelMake = runtimeEntityType.AddProperty(
                "ItemMakeModelMake",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemMakeModelMake", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemMakeModelMake>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            itemMakeModelMake.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemMakeModelModel = runtimeEntityType.AddProperty(
                "ItemMakeModelModel",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemMakeModelModel", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemMakeModelModel>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            itemMakeModelModel.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemName = runtimeEntityType.AddProperty(
                "ItemName",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            itemName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemPrimaryColorCode = runtimeEntityType.AddProperty(
                "ItemPrimaryColorCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemPrimaryColorCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemPrimaryColorCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemPrimaryColorCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemPrimaryColorDescription = runtimeEntityType.AddProperty(
                "ItemPrimaryColorDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemPrimaryColorDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemPrimaryColorDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemPrimaryColorDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemSecondaryColorCode = runtimeEntityType.AddProperty(
                "ItemSecondaryColorCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemSecondaryColorCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemSecondaryColorCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemSecondaryColorCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemSecondaryColorDescription = runtimeEntityType.AddProperty(
                "ItemSecondaryColorDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemSecondaryColorDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemSecondaryColorDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemSecondaryColorDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemStatusCode = runtimeEntityType.AddProperty(
                "ItemStatusCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemStatusDescription = runtimeEntityType.AddProperty(
                "ItemStatusDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemStatusDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemStatusDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemStatusDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemUsageCode = runtimeEntityType.AddProperty(
                "ItemUsageCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemUsageCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemUsageCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemUsageCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemUsageDescription = runtimeEntityType.AddProperty(
                "ItemUsageDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemUsageDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemUsageDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            itemUsageDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemValue = runtimeEntityType.AddProperty(
                "ItemValue",
                typeof(double?),
                propertyInfo: typeof(PersonDrugView).GetProperty("ItemValue", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ItemValue>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            itemValue.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lengthMeasure = runtimeEntityType.AddProperty(
                "LengthMeasure",
                typeof(double?),
                propertyInfo: typeof(PersonDrugView).GetProperty("LengthMeasure", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<LengthMeasure>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lengthMeasure.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modelYear = runtimeEntityType.AddProperty(
                "ModelYear",
                typeof(int?),
                propertyInfo: typeof(PersonDrugView).GetProperty("ModelYear", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ModelYear>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modelYear.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedDateTimeStamp = runtimeEntityType.AddProperty(
                "ModifiedDateTimeStamp",
                typeof(DateTime),
                propertyInfo: typeof(PersonDrugView).GetProperty("ModifiedDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<ModifiedDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            modifiedDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            modifiedDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var originalIdent = runtimeEntityType.AddProperty(
                "OriginalIdent",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("OriginalIdent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<OriginalIdent>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            originalIdent.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personId = runtimeEntityType.AddProperty(
                "PersonId",
                typeof(long),
                propertyInfo: typeof(PersonDrugView).GetProperty("PersonId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<PersonId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            personId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personItemDescription = runtimeEntityType.AddProperty(
                "PersonItemDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("PersonItemDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<PersonItemDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 300);
            personItemDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personItemId = runtimeEntityType.AddProperty(
                "PersonItemId",
                typeof(long),
                propertyInfo: typeof(PersonDrugView).GetProperty("PersonItemId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<PersonItemId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            personItemId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var quantityMeasure = runtimeEntityType.AddProperty(
                "QuantityMeasure",
                typeof(double?),
                propertyInfo: typeof(PersonDrugView).GetProperty("QuantityMeasure", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<QuantityMeasure>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            quantityMeasure.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusCode = runtimeEntityType.AddProperty(
                "RowStatusCode",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("RowStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<RowStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            rowStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusDescription = runtimeEntityType.AddProperty(
                "RowStatusDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("RowStatusDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<RowStatusDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            rowStatusDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var serialIdentification = runtimeEntityType.AddProperty(
                "SerialIdentification",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("SerialIdentification", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<SerialIdentification>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            serialIdentification.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sizeDescription = runtimeEntityType.AddProperty(
                "SizeDescription",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("SizeDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<SizeDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            sizeDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceName = runtimeEntityType.AddProperty(
                "SourceName",
                typeof(string),
                propertyInfo: typeof(PersonDrugView).GetProperty("SourceName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<SourceName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            sourceName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var weightMeasure = runtimeEntityType.AddProperty(
                "WeightMeasure",
                typeof(double?),
                propertyInfo: typeof(PersonDrugView).GetProperty("WeightMeasure", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<WeightMeasure>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            weightMeasure.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var widthMeasure = runtimeEntityType.AddProperty(
                "WidthMeasure",
                typeof(double?),
                propertyInfo: typeof(PersonDrugView).GetProperty("WidthMeasure", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonDrugView).GetField("<WidthMeasure>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
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
            runtimeEntityType.AddAnnotation("Relational:ViewName", "PersonDrugView");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
