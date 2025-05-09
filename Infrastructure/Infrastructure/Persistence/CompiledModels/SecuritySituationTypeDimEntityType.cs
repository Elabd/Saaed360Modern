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
    public partial class SecuritySituationTypeDimEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.SecuritySituationTypeDim",
                typeof(SecuritySituationTypeDim),
                baseEntityType,
                propertyCount: 8,
                navigationCount: 4,
                foreignKeyCount: 3,
                unnamedIndexCount: 3,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(SecuritySituationTypeDim).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SecuritySituationTypeDim).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(long?),
                propertyInfo: typeof(SecuritySituationTypeDim).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SecuritySituationTypeDim).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            createdBy.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime?),
                propertyInfo: typeof(SecuritySituationTypeDim).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SecuritySituationTypeDim).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDate.AddAnnotation("Relational:ColumnType", "datetime");
            creationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(SecuritySituationTypeDim).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SecuritySituationTypeDim).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            description.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool?),
                propertyInfo: typeof(SecuritySituationTypeDim).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SecuritySituationTypeDim).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isDeleted.AddAnnotation("Relational:DefaultValue", false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modificationDate = runtimeEntityType.AddProperty(
                "ModificationDate",
                typeof(DateTime?),
                propertyInfo: typeof(SecuritySituationTypeDim).GetProperty("ModificationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SecuritySituationTypeDim).GetField("<ModificationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modificationDate.AddAnnotation("Relational:ColumnType", "datetime");
            modificationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedBy = runtimeEntityType.AddProperty(
                "ModifiedBy",
                typeof(long?),
                propertyInfo: typeof(SecuritySituationTypeDim).GetProperty("ModifiedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SecuritySituationTypeDim).GetField("<ModifiedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modifiedBy.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var securitySituationMonitorLevelId = runtimeEntityType.AddProperty(
                "SecuritySituationMonitorLevelId",
                typeof(int?),
                propertyInfo: typeof(SecuritySituationTypeDim).GetProperty("SecuritySituationMonitorLevelId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SecuritySituationTypeDim).GetField("<SecuritySituationMonitorLevelId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            securitySituationMonitorLevelId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__Security__3214EC0796D9CE0F");

            var index = runtimeEntityType.AddIndex(
                new[] { createdBy });

            var index0 = runtimeEntityType.AddIndex(
                new[] { modifiedBy });

            var index1 = runtimeEntityType.AddIndex(
                new[] { securitySituationMonitorLevelId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("CreatedBy") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonId") }),
                principalEntityType);

            var createdByNavigation = declaringEntityType.AddNavigation("CreatedByNavigation",
                runtimeForeignKey,
                onDependent: true,
                typeof(Person),
                propertyInfo: typeof(SecuritySituationTypeDim).GetProperty("CreatedByNavigation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SecuritySituationTypeDim).GetField("<CreatedByNavigation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var securitySituationTypeDimCreatedByNavigations = principalEntityType.AddNavigation("SecuritySituationTypeDimCreatedByNavigations",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<SecuritySituationTypeDim>),
                propertyInfo: typeof(Person).GetProperty("SecuritySituationTypeDimCreatedByNavigations", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Person).GetField("<SecuritySituationTypeDimCreatedByNavigations>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__SecurityS__Creat__4AA7D061");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ModifiedBy") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonId") }),
                principalEntityType);

            var modifiedByNavigation = declaringEntityType.AddNavigation("ModifiedByNavigation",
                runtimeForeignKey,
                onDependent: true,
                typeof(Person),
                propertyInfo: typeof(SecuritySituationTypeDim).GetProperty("ModifiedByNavigation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SecuritySituationTypeDim).GetField("<ModifiedByNavigation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var securitySituationTypeDimModifiedByNavigations = principalEntityType.AddNavigation("SecuritySituationTypeDimModifiedByNavigations",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<SecuritySituationTypeDim>),
                propertyInfo: typeof(Person).GetProperty("SecuritySituationTypeDimModifiedByNavigations", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Person).GetField("<SecuritySituationTypeDimModifiedByNavigations>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__SecurityS__Modif__4B9BF49A");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("SecuritySituationMonitorLevelId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType);

            var securitySituationMonitorLevel = declaringEntityType.AddNavigation("SecuritySituationMonitorLevel",
                runtimeForeignKey,
                onDependent: true,
                typeof(SecuritySituationMonitorLevelDim),
                propertyInfo: typeof(SecuritySituationTypeDim).GetProperty("SecuritySituationMonitorLevel", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SecuritySituationTypeDim).GetField("<SecuritySituationMonitorLevel>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var securitySituationTypeDims = principalEntityType.AddNavigation("SecuritySituationTypeDims",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<SecuritySituationTypeDim>),
                propertyInfo: typeof(SecuritySituationMonitorLevelDim).GetProperty("SecuritySituationTypeDims", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SecuritySituationMonitorLevelDim).GetField("<SecuritySituationTypeDims>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_SecuritySituationTypeDim_SecuritySituationMonitorLevelDim");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "SecuritySituationTypeDim");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
