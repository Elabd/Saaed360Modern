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
    public partial class LocationQuestionnaireViewEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.LocationQuestionnaireView",
                typeof(LocationQuestionnaireView),
                baseEntityType,
                propertyCount: 34);

            var createDateTimeStamp = runtimeEntityType.AddProperty(
                "CreateDateTimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("CreateDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<CreateDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            createDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            createDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            description.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var documentCategoryCode = runtimeEntityType.AddProperty(
                "DocumentCategoryCode",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("DocumentCategoryCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<DocumentCategoryCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            documentCategoryCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var documentCategoryDescription = runtimeEntityType.AddProperty(
                "DocumentCategoryDescription",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("DocumentCategoryDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<DocumentCategoryDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            documentCategoryDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var documentFormatCode = runtimeEntityType.AddProperty(
                "DocumentFormatCode",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("DocumentFormatCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<DocumentFormatCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            documentFormatCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var documentFormatDescription = runtimeEntityType.AddProperty(
                "DocumentFormatDescription",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("DocumentFormatDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<DocumentFormatDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            documentFormatDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var documentId = runtimeEntityType.AddProperty(
                "DocumentId",
                typeof(long),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("DocumentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<DocumentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            documentId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var documentInvolvementCode = runtimeEntityType.AddProperty(
                "DocumentInvolvementCode",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("DocumentInvolvementCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<DocumentInvolvementCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            documentInvolvementCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var documentInvolvementDescription = runtimeEntityType.AddProperty(
                "DocumentInvolvementDescription",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("DocumentInvolvementDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<DocumentInvolvementDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            documentInvolvementDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var documentStatusCode = runtimeEntityType.AddProperty(
                "DocumentStatusCode",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("DocumentStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<DocumentStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            documentStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var documentStatusDescription = runtimeEntityType.AddProperty(
                "DocumentStatusDescription",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("DocumentStatusDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<DocumentStatusDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            documentStatusDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var documentUri = runtimeEntityType.AddProperty(
                "DocumentUri",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("DocumentUri", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<DocumentUri>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 300);
            documentUri.AddAnnotation("Relational:ColumnName", "DocumentURI");
            documentUri.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var effectiveDate = runtimeEntityType.AddProperty(
                "EffectiveDate",
                typeof(DateTime?),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("EffectiveDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<EffectiveDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            effectiveDate.AddAnnotation("Relational:ColumnType", "datetime");
            effectiveDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var expirationDate = runtimeEntityType.AddProperty(
                "ExpirationDate",
                typeof(DateTime?),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("ExpirationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<ExpirationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            expirationDate.AddAnnotation("Relational:ColumnType", "datetime");
            expirationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var fileBody = runtimeEntityType.AddProperty(
                "FileBody",
                typeof(byte[]),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("FileBody", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<FileBody>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            fileBody.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var fileBodyXml = runtimeEntityType.AddProperty(
                "FileBodyXml",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("FileBodyXml", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<FileBodyXml>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            fileBodyXml.AddAnnotation("Relational:ColumnName", "FileBodyXML");
            fileBodyXml.AddAnnotation("Relational:ColumnType", "xml");
            fileBodyXml.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var fileControlNumber = runtimeEntityType.AddProperty(
                "FileControlNumber",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("FileControlNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<FileControlNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            fileControlNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var fileDateTime = runtimeEntityType.AddProperty(
                "FileDateTime",
                typeof(DateTime?),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("FileDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<FileDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            fileDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            fileDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var fileExtension = runtimeEntityType.AddProperty(
                "FileExtension",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("FileExtension", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<FileExtension>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 10);
            fileExtension.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var fileName = runtimeEntityType.AddProperty(
                "FileName",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("FileName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<FileName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            fileName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool?),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var locationDocumentDescription = runtimeEntityType.AddProperty(
                "LocationDocumentDescription",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("LocationDocumentDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<LocationDocumentDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 300);
            locationDocumentDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var locationDocumentId = runtimeEntityType.AddProperty(
                "LocationDocumentId",
                typeof(long),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("LocationDocumentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<LocationDocumentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            locationDocumentId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var locationId = runtimeEntityType.AddProperty(
                "LocationId",
                typeof(long),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("LocationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<LocationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            locationId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedDateTimeStamp = runtimeEntityType.AddProperty(
                "ModifiedDateTimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("ModifiedDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<ModifiedDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modifiedDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            modifiedDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var originalIdent = runtimeEntityType.AddProperty(
                "OriginalIdent",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("OriginalIdent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<OriginalIdent>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            originalIdent.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var permanentRecordIndicator = runtimeEntityType.AddProperty(
                "PermanentRecordIndicator",
                typeof(bool?),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("PermanentRecordIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<PermanentRecordIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            permanentRecordIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var privacyActIndicator = runtimeEntityType.AddProperty(
                "PrivacyActIndicator",
                typeof(bool?),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("PrivacyActIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<PrivacyActIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            privacyActIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var questionnaireCategoryCode = runtimeEntityType.AddProperty(
                "QuestionnaireCategoryCode",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("QuestionnaireCategoryCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<QuestionnaireCategoryCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            questionnaireCategoryCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var questionnaireCategoryDescription = runtimeEntityType.AddProperty(
                "QuestionnaireCategoryDescription",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("QuestionnaireCategoryDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<QuestionnaireCategoryDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            questionnaireCategoryDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusCode = runtimeEntityType.AddProperty(
                "RowStatusCode",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("RowStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<RowStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            rowStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusDescription = runtimeEntityType.AddProperty(
                "RowStatusDescription",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("RowStatusDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<RowStatusDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            rowStatusDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceName = runtimeEntityType.AddProperty(
                "SourceName",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("SourceName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<SourceName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            sourceName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var title = runtimeEntityType.AddProperty(
                "Title",
                typeof(string),
                propertyInfo: typeof(LocationQuestionnaireView).GetProperty("Title", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationQuestionnaireView).GetField("<Title>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            title.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "LocationQuestionnaireView");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
