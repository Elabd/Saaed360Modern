﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Infrastructure.Persistence.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class EsAttachmentEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.EsAttachment",
                typeof(EsAttachment),
                baseEntityType,
                propertyCount: 17,
                navigationCount: 3,
                foreignKeyCount: 3,
                unnamedIndexCount: 2,
                namedIndexCount: 4,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(EsAttachment).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var conditionId = runtimeEntityType.AddProperty(
                "ConditionId",
                typeof(int?),
                propertyInfo: typeof(EsAttachment).GetProperty("ConditionId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<ConditionId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            conditionId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var conditionValue = runtimeEntityType.AddProperty(
                "ConditionValue",
                typeof(string),
                propertyInfo: typeof(EsAttachment).GetProperty("ConditionValue", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<ConditionValue>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            conditionValue.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createdAt = runtimeEntityType.AddProperty(
                "CreatedAt",
                typeof(DateTime),
                propertyInfo: typeof(EsAttachment).GetProperty("CreatedAt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<CreatedAt>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            createdAt.AddAnnotation("Relational:ColumnType", "datetime");
            createdAt.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            createdAt.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var documentTypeId = runtimeEntityType.AddProperty(
                "DocumentTypeId",
                typeof(int),
                propertyInfo: typeof(EsAttachment).GetProperty("DocumentTypeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<DocumentTypeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            documentTypeId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var index = runtimeEntityType.AddProperty(
                "Index",
                typeof(int),
                propertyInfo: typeof(EsAttachment).GetProperty("Index", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<Index>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            index.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool),
                propertyInfo: typeof(EsAttachment).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isMultiple = runtimeEntityType.AddProperty(
                "IsMultiple",
                typeof(bool),
                propertyInfo: typeof(EsAttachment).GetProperty("IsMultiple", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<IsMultiple>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isMultiple.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isRequired = runtimeEntityType.AddProperty(
                "IsRequired",
                typeof(bool),
                propertyInfo: typeof(EsAttachment).GetProperty("IsRequired", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<IsRequired>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: true);
            isRequired.AddAnnotation("Relational:DefaultValue", true);
            isRequired.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isRequiredAfterDays = runtimeEntityType.AddProperty(
                "IsRequiredAfterDays",
                typeof(int?),
                propertyInfo: typeof(EsAttachment).GetProperty("IsRequiredAfterDays", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<IsRequiredAfterDays>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isRequiredAfterDays.AddAnnotation("Relational:DefaultValueSql", "(NULL)");
            isRequiredAfterDays.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var maxAttachmentSize = runtimeEntityType.AddProperty(
                "MaxAttachmentSize",
                typeof(int),
                propertyInfo: typeof(EsAttachment).GetProperty("MaxAttachmentSize", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<MaxAttachmentSize>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            maxAttachmentSize.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var maxAttachmentsCount = runtimeEntityType.AddProperty(
                "MaxAttachmentsCount",
                typeof(int?),
                propertyInfo: typeof(EsAttachment).GetProperty("MaxAttachmentsCount", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<MaxAttachmentsCount>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            maxAttachmentsCount.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedAt = runtimeEntityType.AddProperty(
                "ModifiedAt",
                typeof(DateTime?),
                propertyInfo: typeof(EsAttachment).GetProperty("ModifiedAt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<ModifiedAt>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modifiedAt.AddAnnotation("Relational:ColumnType", "datetime");
            modifiedAt.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var nameArabic = runtimeEntityType.AddProperty(
                "NameArabic",
                typeof(string),
                propertyInfo: typeof(EsAttachment).GetProperty("NameArabic", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<NameArabic>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 255);
            nameArabic.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var nameEnglish = runtimeEntityType.AddProperty(
                "NameEnglish",
                typeof(string),
                propertyInfo: typeof(EsAttachment).GetProperty("NameEnglish", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<NameEnglish>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 255);
            nameEnglish.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var nameUrdu = runtimeEntityType.AddProperty(
                "NameUrdu",
                typeof(string),
                propertyInfo: typeof(EsAttachment).GetProperty("NameUrdu", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<NameUrdu>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 255);
            nameUrdu.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var serviceId = runtimeEntityType.AddProperty(
                "ServiceId",
                typeof(int),
                propertyInfo: typeof(EsAttachment).GetProperty("ServiceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<ServiceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            serviceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__ES_Attac__3214EC07E5CB47A7");

            var index0 = runtimeEntityType.AddIndex(
                new[] { conditionId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { documentTypeId });

            var uK_StepId_AttachmentIndex = runtimeEntityType.AddIndex(
                new[] { serviceId, index },
                name: "UK_StepId_AttachmentIndex",
                unique: true);

            var uK_StepId_Attachment_NameArabic = runtimeEntityType.AddIndex(
                new[] { serviceId, nameArabic },
                name: "UK_StepId_Attachment_NameArabic",
                unique: true);

            var uK_StepId_Attachment_NameEnglish = runtimeEntityType.AddIndex(
                new[] { serviceId, nameEnglish },
                name: "UK_StepId_Attachment_NameEnglish",
                unique: true);

            var uK_StepId_Attachment_NameUrdu = runtimeEntityType.AddIndex(
                new[] { serviceId, nameUrdu },
                name: "UK_StepId_Attachment_NameUrdu",
                unique: true);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ConditionId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade);

            var condition = declaringEntityType.AddNavigation("Condition",
                runtimeForeignKey,
                onDependent: true,
                typeof(EsConditionDim),
                propertyInfo: typeof(EsAttachment).GetProperty("Condition", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<Condition>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var esAttachments = principalEntityType.AddNavigation("EsAttachments",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<EsAttachment>),
                propertyInfo: typeof(EsConditionDim).GetProperty("EsAttachments", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsConditionDim).GetField("<EsAttachments>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Attachment_Condition");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DocumentTypeId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ObjectionCustomerDocumentTypeId") }),
                principalEntityType,
                required: true);

            var documentType = declaringEntityType.AddNavigation("DocumentType",
                runtimeForeignKey,
                onDependent: true,
                typeof(ObjectionCustomerDocumentTypeDim),
                propertyInfo: typeof(EsAttachment).GetProperty("DocumentType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<DocumentType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var esAttachments = principalEntityType.AddNavigation("EsAttachments",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<EsAttachment>),
                propertyInfo: typeof(ObjectionCustomerDocumentTypeDim).GetProperty("EsAttachments", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ObjectionCustomerDocumentTypeDim).GetField("<EsAttachments>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Attachment_DocumentType");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ServiceId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            var service = declaringEntityType.AddNavigation("Service",
                runtimeForeignKey,
                onDependent: true,
                typeof(EsService),
                propertyInfo: typeof(EsAttachment).GetProperty("Service", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsAttachment).GetField("<Service>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var esAttachments = principalEntityType.AddNavigation("EsAttachments",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<EsAttachment>),
                propertyInfo: typeof(EsService).GetProperty("EsAttachments", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsService).GetField("<EsAttachments>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Attachment_Service");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ES_Attachment");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
