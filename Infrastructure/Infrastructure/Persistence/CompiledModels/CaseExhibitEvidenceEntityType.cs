﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Infrastructure.Persistence.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class CaseExhibitEvidenceEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.CaseExhibitEvidence",
                typeof(CaseExhibitEvidence),
                baseEntityType,
                propertyCount: 12,
                navigationCount: 4,
                foreignKeyCount: 4,
                unnamedIndexCount: 4,
                keyCount: 1);

            var caseExhibitEvidenceId = runtimeEntityType.AddProperty(
                "CaseExhibitEvidenceId",
                typeof(long),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("CaseExhibitEvidenceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<CaseExhibitEvidenceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            caseExhibitEvidenceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var activityGuid = runtimeEntityType.AddProperty(
                "ActivityGuid",
                typeof(Guid),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("ActivityGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<ActivityGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            activityGuid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var activityId = runtimeEntityType.AddProperty(
                "ActivityId",
                typeof(long),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("ActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<ActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            activityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var caseExhibitEvidenceDescription = runtimeEntityType.AddProperty(
                "CaseExhibitEvidenceDescription",
                typeof(string),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("CaseExhibitEvidenceDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<CaseExhibitEvidenceDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 300);
            caseExhibitEvidenceDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var caseExhibitEvidenceGuid = runtimeEntityType.AddProperty(
                "CaseExhibitEvidenceGuid",
                typeof(Guid),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("CaseExhibitEvidenceGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<CaseExhibitEvidenceGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            caseExhibitEvidenceGuid.AddAnnotation("Relational:DefaultValueSql", "(newid())");
            caseExhibitEvidenceGuid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createDateTimeStamp = runtimeEntityType.AddProperty(
                "CreateDateTimeStamp",
                typeof(DateTime),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("CreateDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<CreateDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            createDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            createDateTimeStamp.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            createDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemGuid = runtimeEntityType.AddProperty(
                "ItemGuid",
                typeof(Guid),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("ItemGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<ItemGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            itemGuid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemId = runtimeEntityType.AddProperty(
                "ItemId",
                typeof(long),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("ItemId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<ItemId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            itemId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedDateTimeStamp = runtimeEntityType.AddProperty(
                "ModifiedDateTimeStamp",
                typeof(DateTime),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("ModifiedDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<ModifiedDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            modifiedDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            modifiedDateTimeStamp.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            modifiedDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusId = runtimeEntityType.AddProperty(
                "RowStatusId",
                typeof(int?),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("RowStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<RowStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            rowStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceId = runtimeEntityType.AddProperty(
                "SourceId",
                typeof(long),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("SourceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<SourceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            sourceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { caseExhibitEvidenceId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__CaseExhi__485CDE9FC9E07E3F");

            var index = runtimeEntityType.AddIndex(
                new[] { activityId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { itemId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { rowStatusId });

            var index2 = runtimeEntityType.AddIndex(
                new[] { sourceId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ActivityId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ActivityId") }),
                principalEntityType,
                required: true);

            var activity = declaringEntityType.AddNavigation("Activity",
                runtimeForeignKey,
                onDependent: true,
                typeof(Activity),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("Activity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<Activity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var caseExhibitEvidences = principalEntityType.AddNavigation("CaseExhibitEvidences",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<CaseExhibitEvidence>),
                propertyInfo: typeof(Activity).GetProperty("CaseExhibitEvidences", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Activity).GetField("<CaseExhibitEvidences>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_CaseExhibitEvidence_Activity");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ItemId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ItemId") }),
                principalEntityType,
                required: true);

            var item = declaringEntityType.AddNavigation("Item",
                runtimeForeignKey,
                onDependent: true,
                typeof(Item),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("Item", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<Item>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var caseExhibitEvidences = principalEntityType.AddNavigation("CaseExhibitEvidences",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<CaseExhibitEvidence>),
                propertyInfo: typeof(Item).GetProperty("CaseExhibitEvidences", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Item).GetField("<CaseExhibitEvidences>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_CaseExhibitEvidence_Item");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("RowStatusId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("RowStatusId") }),
                principalEntityType);

            var rowStatus = declaringEntityType.AddNavigation("RowStatus",
                runtimeForeignKey,
                onDependent: true,
                typeof(RowStatusDim),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("RowStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<RowStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var caseExhibitEvidences = principalEntityType.AddNavigation("CaseExhibitEvidences",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<CaseExhibitEvidence>),
                propertyInfo: typeof(RowStatusDim).GetProperty("CaseExhibitEvidences", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RowStatusDim).GetField("<CaseExhibitEvidences>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_CaseExhibitEvidence_RowStatusDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("SourceId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("SourceId") }),
                principalEntityType,
                required: true);

            var source = declaringEntityType.AddNavigation("Source",
                runtimeForeignKey,
                onDependent: true,
                typeof(Source),
                propertyInfo: typeof(CaseExhibitEvidence).GetProperty("Source", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CaseExhibitEvidence).GetField("<Source>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var caseExhibitEvidences = principalEntityType.AddNavigation("CaseExhibitEvidences",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<CaseExhibitEvidence>),
                propertyInfo: typeof(Source).GetProperty("CaseExhibitEvidences", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Source).GetField("<CaseExhibitEvidences>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_CaseExhibitEvidence_Source");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "CaseExhibitEvidence");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
