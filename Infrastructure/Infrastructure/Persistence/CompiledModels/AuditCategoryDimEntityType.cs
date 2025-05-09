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
    public partial class AuditCategoryDimEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.AuditCategoryDim",
                typeof(AuditCategoryDim),
                baseEntityType,
                propertyCount: 5,
                navigationCount: 3,
                foreignKeyCount: 1,
                unnamedIndexCount: 1,
                keyCount: 1);

            var auditCategoryId = runtimeEntityType.AddProperty(
                "AuditCategoryId",
                typeof(int),
                propertyInfo: typeof(AuditCategoryDim).GetProperty("AuditCategoryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AuditCategoryDim).GetField("<AuditCategoryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            auditCategoryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var code = runtimeEntityType.AddProperty(
                "Code",
                typeof(string),
                propertyInfo: typeof(AuditCategoryDim).GetProperty("Code", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AuditCategoryDim).GetField("<Code>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 20);
            code.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(AuditCategoryDim).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AuditCategoryDim).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            description.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusId = runtimeEntityType.AddProperty(
                "RowStatusId",
                typeof(int?),
                propertyInfo: typeof(AuditCategoryDim).GetProperty("RowStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AuditCategoryDim).GetField("<RowStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            rowStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var versionDateTime = runtimeEntityType.AddProperty(
                "VersionDateTime",
                typeof(DateTime),
                propertyInfo: typeof(AuditCategoryDim).GetProperty("VersionDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AuditCategoryDim).GetField("<VersionDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            versionDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            versionDateTime.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            versionDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { auditCategoryId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__AuditCat__56F2834AF4F7E8F4");

            var index = runtimeEntityType.AddIndex(
                new[] { rowStatusId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("RowStatusId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("RowStatusId") }),
                principalEntityType);

            var rowStatus = declaringEntityType.AddNavigation("RowStatus",
                runtimeForeignKey,
                onDependent: true,
                typeof(RowStatusDim),
                propertyInfo: typeof(AuditCategoryDim).GetProperty("RowStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AuditCategoryDim).GetField("<RowStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var auditCategoryDims = principalEntityType.AddNavigation("AuditCategoryDims",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<AuditCategoryDim>),
                propertyInfo: typeof(RowStatusDim).GetProperty("AuditCategoryDims", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RowStatusDim).GetField("<AuditCategoryDims>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_AuditCategoryDIM_RowStatusDIM");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "AuditCategoryDIM");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
