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
    public partial class OrganizationUnitPersonnelEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.OrganizationUnitPersonnel",
                typeof(OrganizationUnitPersonnel),
                baseEntityType,
                propertyCount: 12,
                navigationCount: 4,
                foreignKeyCount: 4,
                unnamedIndexCount: 4,
                keyCount: 1);

            var organizationUnitPersonnelId = runtimeEntityType.AddProperty(
                "OrganizationUnitPersonnelId",
                typeof(long),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("OrganizationUnitPersonnelId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<OrganizationUnitPersonnelId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            organizationUnitPersonnelId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var createDateTimeStamp = runtimeEntityType.AddProperty(
                "CreateDateTimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("CreateDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<CreateDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            createDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            createDateTimeStamp.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            createDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool?),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isDeleted.AddAnnotation("Relational:DefaultValue", false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedDateTimeStamp = runtimeEntityType.AddProperty(
                "ModifiedDateTimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("ModifiedDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<ModifiedDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            modifiedDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            modifiedDateTimeStamp.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            modifiedDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var organizationUnitGuid = runtimeEntityType.AddProperty(
                "OrganizationUnitGuid",
                typeof(Guid),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("OrganizationUnitGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<OrganizationUnitGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            organizationUnitGuid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var organizationUnitId = runtimeEntityType.AddProperty(
                "OrganizationUnitId",
                typeof(long),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("OrganizationUnitId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<OrganizationUnitId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            organizationUnitId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var organizationUnitPersonnelDescription = runtimeEntityType.AddProperty(
                "OrganizationUnitPersonnelDescription",
                typeof(string),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("OrganizationUnitPersonnelDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<OrganizationUnitPersonnelDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 300);
            organizationUnitPersonnelDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var organizationUnitPersonnelGuid = runtimeEntityType.AddProperty(
                "OrganizationUnitPersonnelGuid",
                typeof(Guid),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("OrganizationUnitPersonnelGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<OrganizationUnitPersonnelGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            organizationUnitPersonnelGuid.AddAnnotation("Relational:DefaultValueSql", "(newid())");
            organizationUnitPersonnelGuid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var organzationPersonGuid = runtimeEntityType.AddProperty(
                "OrganzationPersonGuid",
                typeof(Guid),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("OrganzationPersonGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<OrganzationPersonGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            organzationPersonGuid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var organzationPersonId = runtimeEntityType.AddProperty(
                "OrganzationPersonId",
                typeof(long),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("OrganzationPersonId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<OrganzationPersonId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            organzationPersonId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusId = runtimeEntityType.AddProperty(
                "RowStatusId",
                typeof(int?),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("RowStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<RowStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            rowStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceId = runtimeEntityType.AddProperty(
                "SourceId",
                typeof(long?),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("SourceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<SourceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            sourceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { organizationUnitPersonnelId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { organizationUnitId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { organzationPersonId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { rowStatusId });

            var index2 = runtimeEntityType.AddIndex(
                new[] { sourceId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("OrganizationUnitId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("OrganizationUnitId") }),
                principalEntityType,
                required: true);

            var organizationUnit = declaringEntityType.AddNavigation("OrganizationUnit",
                runtimeForeignKey,
                onDependent: true,
                typeof(OrganizationUnit),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("OrganizationUnit", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<OrganizationUnit>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var organizationUnitPersonnel = principalEntityType.AddNavigation("OrganizationUnitPersonnel",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<OrganizationUnitPersonnel>),
                propertyInfo: typeof(OrganizationUnit).GetProperty("OrganizationUnitPersonnel", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnit).GetField("<OrganizationUnitPersonnel>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "OrganizationUnit_OrganizationUnitPersonnel_FK1");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("OrganzationPersonId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("OrganizationPersonId") }),
                principalEntityType,
                required: true);

            var organzationPerson = declaringEntityType.AddNavigation("OrganzationPerson",
                runtimeForeignKey,
                onDependent: true,
                typeof(OrganizationPerson),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("OrganzationPerson", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<OrganzationPerson>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var organizationUnitPersonnel = principalEntityType.AddNavigation("OrganizationUnitPersonnel",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<OrganizationUnitPersonnel>),
                propertyInfo: typeof(OrganizationPerson).GetProperty("OrganizationUnitPersonnel", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationPerson).GetField("<OrganizationUnitPersonnel>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_OrganizationUnitPersonnel_OrganizationPerson");
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
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("RowStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<RowStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var organizationUnitPersonnel = principalEntityType.AddNavigation("OrganizationUnitPersonnel",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<OrganizationUnitPersonnel>),
                propertyInfo: typeof(RowStatusDim).GetProperty("OrganizationUnitPersonnel", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RowStatusDim).GetField("<OrganizationUnitPersonnel>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_OrganizationUnitPersonnel_RowStatusDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("SourceId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("SourceId") }),
                principalEntityType);

            var source = declaringEntityType.AddNavigation("Source",
                runtimeForeignKey,
                onDependent: true,
                typeof(Source),
                propertyInfo: typeof(OrganizationUnitPersonnel).GetProperty("Source", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(OrganizationUnitPersonnel).GetField("<Source>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var organizationUnitPersonnel = principalEntityType.AddNavigation("OrganizationUnitPersonnel",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<OrganizationUnitPersonnel>),
                propertyInfo: typeof(Source).GetProperty("OrganizationUnitPersonnel", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Source).GetField("<OrganizationUnitPersonnel>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_OrganizationUnitPersonnel_Source");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "OrganizationUnitPersonnel");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
